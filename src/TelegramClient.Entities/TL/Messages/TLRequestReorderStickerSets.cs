using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(2016638777)]
    public class TlRequestReorderStickerSets : TlMethod
    {
        public int Flags { get; set; }
        public bool Masks { get; set; }
        public TlVector<long> Order { get; set; }
        public bool Response { get; set; }


        public void ComputeFlags()
        {
            Flags = 0;
            Flags = Masks ? Flags | 1 : Flags & ~1;
        }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = BoolUtil.Deserialize(br);
        }
    }
}