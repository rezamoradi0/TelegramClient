using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(2081952796)]
    public class TlPassword : TlAbsPassword
    {
        [SerializationOrder(0)]
        public byte[] CurrentSalt { get; set; }

        [SerializationOrder(1)]
        public byte[] NewSalt { get; set; }

        [SerializationOrder(2)]
        public string Hint { get; set; }

        [SerializationOrder(3)]
        public bool HasRecovery { get; set; }

        [SerializationOrder(4)]
        public string EmailUnconfirmedPattern { get; set; }
    }
}