using System.IO;

namespace TelegramClient.Entities.TL.Upload
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-562337987)]
    public class TlRequestSaveBigFilePart : TlMethod
    {
        [SerializationOrder(0)]
        public long FileId { get; set; }

        [SerializationOrder(1)]
        public int FilePart { get; set; }

        [SerializationOrder(2)]
        public int FileTotalParts { get; set; }

        [SerializationOrder(3)]
        public byte[] Bytes { get; set; }

        public bool Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = BoolUtil.Deserialize(br);
        }
    }
}