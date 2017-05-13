using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1109588596)]
    public class TlRequestGetMessages : TlMethod
    {
        [SerializationOrder(0)]
        public TlVector<int> Id { get; set; }

        public TlAbsMessages Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsMessages) ObjectUtils.DeserializeObject(br);
        }
    }
}