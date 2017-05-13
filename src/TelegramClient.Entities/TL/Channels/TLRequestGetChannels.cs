using System.IO;
using TelegramClient.Entities.TL.Messages;

namespace TelegramClient.Entities.TL.Channels
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(176122811)]
    public class TlRequestGetChannels : TlMethod
    {
        [SerializationOrder(0)]
        public TlVector<TlAbsInputChannel> Id { get; set; }

        public TlChats Response { get; set; }
        
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlChats) ObjectUtils.DeserializeObject(br);
        }
    }
}