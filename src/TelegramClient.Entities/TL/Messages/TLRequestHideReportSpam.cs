using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    [TlObject(-1460572005)]
    public class TlRequestHideReportSpam : TlMethod
    {
        public override int Constructor => -1460572005;

        public TlAbsInputPeer Peer { get; set; }
        public bool Response { get; set; }


        public void ComputeFlags()
        {
        }

        public override void DeserializeBody(BinaryReader br)
        {
            Peer = (TlAbsInputPeer) ObjectUtils.DeserializeObject(br);
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Peer, bw);
        }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = BoolUtil.Deserialize(br);
        }
    }
}