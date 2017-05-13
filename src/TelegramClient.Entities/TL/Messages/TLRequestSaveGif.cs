using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(846868683)]
    public class TlRequestSaveGif : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputDocument Id { get; set; }

        [SerializationOrder(1)]
        public bool Unsave { get; set; }

        public bool Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = BoolUtil.Deserialize(br);
        }
    }
}