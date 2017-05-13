using System.IO;

namespace TelegramClient.Entities.TL
{
    [SerializeAttribute(2129714567)]
    public class TlInputMessagesFilterUrl : TlAbsMessagesFilter
    {
        public override int Constructor => 2129714567;


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