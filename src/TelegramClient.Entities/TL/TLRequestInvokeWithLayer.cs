using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-627372787)]
    public class TlRequestInvokeWithLayer : TlMethod<TlConfig>
    {
        [SerializationOrder(0)]
        public int Layer { get; set; }

        [SerializationOrder(1)]
        public TlObject Query { get; set; }
    }
}