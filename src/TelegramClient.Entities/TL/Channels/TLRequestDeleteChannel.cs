using System.IO;

namespace TelegramClient.Entities.TL.Channels
{
    [TLObject(-1072619549)]
    public class TLRequestDeleteChannel : TLMethod
    {
        public override int Constructor => -1072619549;

        public TLAbsInputChannel channel { get; set; }
        public TLAbsUpdates Response { get; set; }


        public void ComputeFlags()
        {
        }

        public override void DeserializeBody(BinaryReader br)
        {
            channel = (TLAbsInputChannel) ObjectUtils.DeserializeObject(br);
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(channel, bw);
        }

        public override void deserializeResponse(BinaryReader br)
        {
            Response = (TLAbsUpdates) ObjectUtils.DeserializeObject(br);
        }
    }
}