using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1013621127)]
    public class TlRequestGetChats : TlMethod
    {
        [SerializationOrder(0)]
        public TlVector<int> Id { get; set; }

        public TlChats Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlChats) ObjectUtils.DeserializeObject(br);
        }
    }
}