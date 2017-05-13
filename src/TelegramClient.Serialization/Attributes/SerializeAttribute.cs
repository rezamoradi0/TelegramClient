namespace TelegramClient.Serialization.Attributes
{
    using System;

    public class SerializeAttribute: Attribute
    {
        internal int TypeId { get; }

        public SerializeAttribute(int typeId)
        {
            TypeId = typeId;
        }
    }
}