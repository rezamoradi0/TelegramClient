using System.IO;

namespace TelegramClient.Entities.TL.Help
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1987579119)]
    public class TlAppUpdate : TlAbsAppUpdate
    {
        [SerializationOrder(0)]
        public int Id { get; set; }

        [SerializationOrder(1)]
        public bool Critical { get; set; }

        [SerializationOrder(2)]
        public string Url { get; set; }

        [SerializationOrder(3)]
        public string Text { get; set; }
    }
}