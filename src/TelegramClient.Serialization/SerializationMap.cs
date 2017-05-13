namespace TelegramClient.Serialization
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using TelegramClient.Serialization.Attributes;

    public static class SerializationMap
    {
        private static Dictionary<int, TypeInfo> idToTypeMap;
        private static Dictionary<TypeInfo, int> typeToIdMap;

        public static void Initialize(params Assembly[] assembliesForRegistration)
        {
            var types = assembliesForRegistration
                .SelectMany(a => a.DefinedTypes)
                .Where(t => t.GetCustomAttribute<SerializeAttribute>() != null)
                .ToArray();

            idToTypeMap = types.ToDictionary(t => t.GetCustomAttribute<SerializeAttribute>().TypeId);
            typeToIdMap = types.ToDictionary(t => t, t => t.GetCustomAttribute<SerializeAttribute>().TypeId);
        }

        public static bool GetTypeById(int typeId, out TypeInfo type)
        {
            return idToTypeMap.TryGetValue(typeId, out type);
        }

        public static bool GetIdByType(TypeInfo type, out int typeId)
        {
            return typeToIdMap.TryGetValue(type, out typeId);
        }
    }
}