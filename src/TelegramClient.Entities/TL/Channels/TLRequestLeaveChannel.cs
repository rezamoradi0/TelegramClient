using System.IO;

namespace TelegramClient.Entities.TL.Channels
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-130635115)]
    public class TlRequestLeaveChannel : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputChannel Channel { get; set; }

        public TlAbsUpdates Response { get; set; }
        
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsUpdates) ObjectUtils.DeserializeObject(br);
        }
    }
}