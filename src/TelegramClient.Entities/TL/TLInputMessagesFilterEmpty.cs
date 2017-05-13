using System.IO;

namespace TelegramClient.Entities.TL
{
    [SerializeAttribute(1474492012)]
    public class TlInputMessagesFilterEmpty : TlAbsMessagesFilter
    {
        public override int Constructor => 1474492012;


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