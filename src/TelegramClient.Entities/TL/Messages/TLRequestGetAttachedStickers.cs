using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-866424884)]
    public class TlRequestGetAttachedStickers : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputStickeredMedia Media { get; set; }

        public TlVector<TlAbsStickerSetCovered> Response { get; set; }
        
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = ObjectUtils.DeserializeVector<TlAbsStickerSetCovered>(br);
        }
    }
}