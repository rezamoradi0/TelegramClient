using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-847783593)]
    public class TlChannelMessagesFilter : TlAbsChannelMessagesFilter
    {
        public int Flags { get; set; }
        public bool ExcludeNewMessages { get; set; }
        public TlVector<TlMessageRange> Ranges { get; set; }


        public void ComputeFlags()
        {
            Flags = 0;
            Flags = ExcludeNewMessages ? Flags | 2 : Flags & ~2;
        }

        public override void DeserializeBody(BinaryReader br)
        {
            Flags = br.ReadInt32();
            ExcludeNewMessages = (Flags & 2) != 0;
            Ranges = ObjectUtils.DeserializeVector<TlMessageRange>(br);
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ComputeFlags();
            bw.Write(Flags);

            ObjectUtils.SerializeObject(Ranges, bw);
        }
    }
}