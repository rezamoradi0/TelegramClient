using System.IO;

namespace TelegramClient.Entities.TL
{
    [TLObject(410618194)]
    public class TLInputDocument : TLAbsInputDocument
    {
        public override int Constructor => 410618194;

        public long id { get; set; }
        public long access_hash { get; set; }


        public void ComputeFlags()
        {
        }

        public override void DeserializeBody(BinaryReader br)
        {
            id = br.ReadInt64();
            access_hash = br.ReadInt64();
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(id);
            bw.Write(access_hash);
        }
    }
}