using System.IO;

namespace TelegramClient.Entities.TL.Auth
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1998331287)]
    public class TlRequestSendInvites : TlMethod
    {
        [SerializationOrder(0)]
        public TlVector<string> PhoneNumbers { get; set; }

        [SerializationOrder(1)]
        public string Message { get; set; }

        public bool Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = BoolUtil.Deserialize(br);
        }
    }
}