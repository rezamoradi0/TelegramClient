using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(524838915)]
    public class TlExportedMessageLink : TlObject
    {
        [SerializationOrder(0)]
        public string Link { get; set; }
    }
}