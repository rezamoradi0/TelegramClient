namespace TelegramClient.Serialization
{
    using System;
    using System.Collections;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    using TelegramClient.Serialization.Attributes;

    public static class Serializer
    {
        public static MemoryStream Serialize(object obj)
        {
            var stream = new MemoryStream();
            var binaryWriter = new BinaryWriter(stream);
            Serialize(obj, binaryWriter);

            stream.Seek(0, SeekOrigin.Begin);
            return stream;
        }

        public static void Serialize(object obj, BinaryWriter binaryWriter)
        {
            var objectType = obj.GetType().GetTypeInfo();

            if (!SerializationMap.GetIdByType(objectType, out var typeId))
            {
                throw new NotSupportedException();
            }

            binaryWriter.Write(typeId);

            var properties = objectType.DeclaredProperties
                                       .Where((info, i) => info.GetCustomAttribute<SerializationOrderAttribute>() != null)
                                       .OrderBy(info => info.GetCustomAttribute<SerializationOrderAttribute>().Order);

            var writerDeclaredMethods = binaryWriter.GetType()
                                                    .GetTypeInfo()
                                                    .DeclaredMethods
                                                    .Where(info => info.Name == "Write")
                                                    .ToArray();

            foreach (var property in properties)
            {
                var propertyValue = property.GetValue(obj);

                switch (property.PropertyType.GetTypeInfo())
                {
                    case var collectionType when typeof(ICollection).GetTypeInfo().IsAssignableFrom(collectionType):
                        var collection = (ICollection)propertyValue;
                        binaryWriter.Write(collection.Count);
                        foreach (var item in collection)
                        {
                            Serialize(item, binaryWriter);
                        }
                        break;
                    case var simpleType when writerDeclaredMethods.Any(info => Equals(info.GetParameters()[0].ParameterType.GetTypeInfo(), simpleType)):
                        var method = writerDeclaredMethods.First(info => info.GetParameters()[0].ParameterType == property.PropertyType);
                        method.Invoke(binaryWriter, new[] { propertyValue });
                        break;

                    case var classType when classType.IsClass:
                        Serialize(propertyValue, binaryWriter);
                        break;

                    default:
                        throw new NotImplementedException();
                }
            }
        }
    }
}