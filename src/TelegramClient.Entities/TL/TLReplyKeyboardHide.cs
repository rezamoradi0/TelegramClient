using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1606526075)]
    public class TlReplyKeyboardHide : TlAbsReplyMarkup
    {
        public int Flags { get; set; }
        public bool Selective { get; set; }


        public void ComputeFlags()
        {
            Flags = 0;
            Flags = Selective ? Flags | 4 : Flags & ~4;
        }

        public override void DeserializeBody(BinaryReader br)
        {
            Flags = br.ReadInt32();
            Selective = (Flags & 4) != 0;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ComputeFlags();
            bw.Write(Flags);
        }
    }
}