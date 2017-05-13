using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-2084618926)]
    public class TlRequestGetSavedGifs : TlMethod
    {
        [SerializationOrder(0)]
        public int Hash { get; set; }

        [SerializationOrder(1)]
        public TlAbsSavedGifs Response { get; set; }
        
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsSavedGifs) ObjectUtils.DeserializeObject(br);
        }
    }
}