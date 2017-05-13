using System.IO;

namespace TelegramClient.Entities.TL
{
    [SerializeAttribute(1450380236)]
    public class TlNull : TlObject
    {
        public override int Constructor => 1450380236;


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