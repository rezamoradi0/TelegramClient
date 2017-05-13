using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1080395925)]
    public class TlRequestSearchGifs : TlMethod
    {
        [SerializationOrder(0)]
        public string Q { get; set; }

        [SerializationOrder(1)]
        public int Offset { get; set; }

        public TlFoundGifs Response { get; set; }
        
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlFoundGifs) ObjectUtils.DeserializeObject(br);
        }
    }
}