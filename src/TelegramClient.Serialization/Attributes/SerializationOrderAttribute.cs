namespace TelegramClient.Serialization.Attributes
{
    using System;

    public class SerializationOrderAttribute: Attribute
    {
        internal int Order { get; }

        public SerializationOrderAttribute(int order)
        {
            Order = order;
        }
    }
}