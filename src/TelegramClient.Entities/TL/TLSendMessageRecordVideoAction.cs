using System.IO;

namespace TelegramClient.Entities.TL
{
    [SerializeAttribute(-1584933265)]
    public class TlSendMessageRecordVideoAction : TlAbsSendMessageAction
    {
        public override int Constructor => -1584933265;


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