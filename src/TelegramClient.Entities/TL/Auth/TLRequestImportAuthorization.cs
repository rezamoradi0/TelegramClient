using System.IO;

namespace TelegramClient.Entities.TL.Auth
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-470837741)]
    public class TlRequestImportAuthorization : TlMethod<TlAuthorization>
    {
        [SerializationOrder(0)]
        public int Id { get; set; }

        [SerializationOrder(1)]
        public byte[] Bytes { get; set; }
    }
}