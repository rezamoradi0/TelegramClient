using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    [TLObject(864953444)]
    public class TLRequestGetDocumentByHash : TLMethod
    {
        public override int Constructor => 864953444;

        public byte[] sha256 { get; set; }
        public int size { get; set; }
        public string mime_type { get; set; }
        public TLAbsDocument Response { get; set; }


        public void ComputeFlags()
        {
        }

        public override void DeserializeBody(BinaryReader br)
        {
            sha256 = BytesUtil.Deserialize(br);
            size = br.ReadInt32();
            mime_type = StringUtil.Deserialize(br);
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            BytesUtil.Serialize(sha256, bw);
            bw.Write(size);
            StringUtil.Serialize(mime_type, bw);
        }

        public override void deserializeResponse(BinaryReader br)
        {
            Response = (TLAbsDocument) ObjectUtils.DeserializeObject(br);
        }
    }
}