using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(916930423)]
    public class TlRequestReadMessageContents : TlMethod
    {
        [SerializationOrder(0)]
        public TlVector<int> Id { get; set; }

        [SerializationOrder(1)]
        public TlAffectedMessages Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAffectedMessages) ObjectUtils.DeserializeObject(br);
        }
    }
}