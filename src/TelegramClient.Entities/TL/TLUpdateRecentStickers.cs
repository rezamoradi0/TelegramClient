using System.IO;

namespace TelegramClient.Entities.TL
{
    [SerializeAttribute(-1706939360)]
    public class TlUpdateRecentStickers : TlAbsUpdate
    {
        public override int Constructor => -1706939360;


        public void ComputeFlags()
        {
        }

        public override void DeserializeBody(BinaryReader br)
        {
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
        }
    }
}