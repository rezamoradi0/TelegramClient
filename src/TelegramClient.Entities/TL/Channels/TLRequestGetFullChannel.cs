using System.IO;

namespace TelegramClient.Entities.TL.Channels
{
    [TlObject(141781513)]
    public class TlRequestGetFullChannel : TlMethod
    {
        public override int Constructor => 141781513;

        public TlAbsInputChannel Channel { get; set; }
        public Messages.TlChatFull Response { get; set; }


        public void ComputeFlags()
        {
        }

        public override void DeserializeBody(BinaryReader br)
        {
            Channel = (TlAbsInputChannel) ObjectUtils.DeserializeObject(br);
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Channel, bw);
        }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (Messages.TlChatFull) ObjectUtils.DeserializeObject(br);
        }
    }
}