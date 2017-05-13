using System;

using Xunit;

namespace TelegramClient.Serialization.UnitTests
{
    using System.IO;
    using System.Reflection;

    using TelegramClient.Serialization.Attributes;

    public class SerializerTests
    {
        public SerializerTests()
        {
            SerializationMap.Initialize(typeof(SerializerTests).GetTypeInfo().Assembly);
        }

        [SerializeAttribute(1111)]
        private class ClassA
        {
            [SerializationOrder(0)]
            public int A { get; set; } = 5;
        }


        [SerializeAttribute(2222)]
        private class ClassB
        {
            [SerializationOrder(0)]
            public ClassA A { get; set; }
        }

        [SerializeAttribute(3333)]
        private class ClassC
        {
            [SerializationOrder(0)]
            public ClassA[] A { get; set; }
        }

        [Fact]
        public void Serialize_SimpleType_NotThrows()
        {
            var a = new ClassA();

            using (var stream = Serializer.Serialize(a))
            using (var reader = new BinaryReader(stream))
            {
                Assert.Equal(1111, reader.ReadInt32());
                Assert.Equal(5, reader.ReadInt32());
            }

        }

        [Fact]
        public void Serialize_CompositeTypes_NotThrows()
        {
            var b = new ClassB()
                    {
                        A = new ClassA()
                    };

            using (var stream = Serializer.Serialize(b))
            using (var reader = new BinaryReader(stream))
            {
                Assert.Equal(2222, reader.ReadInt32());
                Assert.Equal(1111, reader.ReadInt32());
                Assert.Equal(5, reader.ReadInt32());
            }

        }

        [Fact]
        public void Serialize_Collection_NotThrows()
        {
            var b = new ClassC
                    {
                        A = new[]
                            {
                                new ClassA()
                            }
                    };

            using (var stream = Serializer.Serialize(b))
            using (var reader = new BinaryReader(stream))
            {
                Assert.Equal(3333, reader.ReadInt32());
                Assert.Equal(1, reader.ReadInt32());
                Assert.Equal(1111, reader.ReadInt32());
                Assert.Equal(5, reader.ReadInt32());
            }

        }
    }
}