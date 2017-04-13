using System.IO;

namespace TelegramClient.Entities.TL.Contacts
{
    [TLObject(451113900)]
    public class TLRequestResetTopPeerRating : TLMethod
    {
        public override int Constructor => 451113900;

        public TLAbsTopPeerCategory category { get; set; }
        public TLAbsInputPeer peer { get; set; }
        public bool Response { get; set; }


        public void ComputeFlags()
        {
        }

        public override void DeserializeBody(BinaryReader br)
        {
            category = (TLAbsTopPeerCategory) ObjectUtils.DeserializeObject(br);
            peer = (TLAbsInputPeer) ObjectUtils.DeserializeObject(br);
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(category, bw);
            ObjectUtils.SerializeObject(peer, bw);
        }

        public override void deserializeResponse(BinaryReader br)
        {
            Response = BoolUtil.Deserialize(br);
        }
    }
}