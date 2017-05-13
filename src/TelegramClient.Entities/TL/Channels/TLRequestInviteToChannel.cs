using System.IO;

namespace TelegramClient.Entities.TL.Channels
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(429865580)]
    public class TlRequestInviteToChannel : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputChannel Channel { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlAbsInputUser> Users { get; set; }

        public TlAbsUpdates Response { get; set; }
        
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsUpdates) ObjectUtils.DeserializeObject(br);
        }
    }
}