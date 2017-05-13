using System.IO;

namespace TelegramClient.Entities.TL
{
    [SerializeAttribute(-750828557)]
    public class TlInputMediaGame : TlAbsInputMedia
    {
        public override int Constructor => -750828557;

        public TlAbsInputGame Id { get; set; }


        public void ComputeFlags()
        {
        }

        public override void DeserializeBody(BinaryReader br)
        {
            Id = (TlAbsInputGame) ObjectUtils.DeserializeObject(br);
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Id, bw);
        }
    }
}