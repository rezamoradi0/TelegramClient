using System.IO;

namespace TelegramClient.Entities.TL.Channels
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-934882771)]
    public class TlRequestExportMessageLink : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputChannel Channel { get; set; }

        [SerializationOrder(1)]
        public int Id { get; set; }

        public TlExportedMessageLink Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlExportedMessageLink) ObjectUtils.DeserializeObject(br);
        }
    }
}