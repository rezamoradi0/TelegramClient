using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(2031374829)]
    public class TlRequestSetEncryptedTyping : TlMethod
    {
        [SerializationOrder(0)]
        public TlInputEncryptedChat Peer { get; set; }

        [SerializationOrder(1)]
        public bool Typing { get; set; }

        public bool Response { get; set; }


       
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = BoolUtil.Deserialize(br);
        }
    }
}