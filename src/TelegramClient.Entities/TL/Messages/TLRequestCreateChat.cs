using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(164303470)]
    public class TlRequestCreateChat : TlMethod
    {
        [SerializationOrder(0)]
        public TlVector<TlAbsInputUser> Users { get; set; }

        [SerializationOrder(1)]
        public string Title { get; set; }

        public TlAbsUpdates Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsUpdates) ObjectUtils.DeserializeObject(br);
        }
    }
}