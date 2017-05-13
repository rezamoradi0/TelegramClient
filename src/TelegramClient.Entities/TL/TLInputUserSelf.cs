using System.IO;

namespace TelegramClient.Entities.TL
{
    [SerializeAttribute(-138301121)]
    public class TlInputUserSelf : TlAbsInputUser
    {
        public override int Constructor => -138301121;


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