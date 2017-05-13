using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1510897371)]
    public class TlRequestDeleteMessages : TlMethod
    {
        [SerializationOrder(0)]
        public TlVector<int> Id { get; set; }

        public TlAffectedMessages Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAffectedMessages) ObjectUtils.DeserializeObject(br);
        }
    }
}