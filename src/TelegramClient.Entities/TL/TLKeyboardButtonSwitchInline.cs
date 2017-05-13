using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(90744648)]
    public class TlKeyboardButtonSwitchInline : TlAbsKeyboardButton
    {
        public int Flags { get; set; }
        public bool SamePeer { get; set; }
        public string Text { get; set; }
        public string Query { get; set; }


        public void ComputeFlags()
        {
            Flags = 0;
            Flags = SamePeer ? Flags | 1 : Flags & ~1;
        }

        public override void DeserializeBody(BinaryReader br)
        {
            Flags = br.ReadInt32();
            SamePeer = (Flags & 1) != 0;
            Text = StringUtil.Deserialize(br);
            Query = StringUtil.Deserialize(br);
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ComputeFlags();
            bw.Write(Flags);

            StringUtil.Serialize(Text, bw);
            StringUtil.Serialize(Query, bw);
        }
    }
}