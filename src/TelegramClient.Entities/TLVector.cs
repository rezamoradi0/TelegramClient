using System.Collections.Generic;

namespace TelegramClient.Entities
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(481674261)]
    public class TlVector<T> : TlObject
    {
        [SerializationOrder(0)]
        public List<T> Lists { get; set; }
    }
}