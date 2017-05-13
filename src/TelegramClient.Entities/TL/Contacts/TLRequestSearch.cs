using System.IO;

namespace TelegramClient.Entities.TL.Contacts
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(301470424)]
    public class TlRequestSearch : TlMethod
    {
        [SerializationOrder(0)]
        public string Q { get; set; }

        [SerializationOrder(1)]
        public int Limit { get; set; }

        public TlFound Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlFound) ObjectUtils.DeserializeObject(br);
        }
    }
}