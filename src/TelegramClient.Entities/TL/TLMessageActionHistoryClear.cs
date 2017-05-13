using System.IO;

namespace TelegramClient.Entities.TL
{
    [SerializeAttribute(-1615153660)]
    public class TlMessageActionHistoryClear : TlAbsMessageAction
    {
        public override int Constructor => -1615153660;


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