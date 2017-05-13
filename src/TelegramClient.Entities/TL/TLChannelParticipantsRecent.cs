using System.IO;

namespace TelegramClient.Entities.TL
{
    [SerializeAttribute(-566281095)]
    public class TlChannelParticipantsRecent : TlAbsChannelParticipantsFilter
    {
        public override int Constructor => -566281095;


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