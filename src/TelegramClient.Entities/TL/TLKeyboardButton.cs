using System.IO;

namespace TelegramClient.Entities.TL
{
    [SerializeAttribute(-1560655744)]
    public class TlKeyboardButton : TlAbsKeyboardButton
    {
        public override int Constructor => -1560655744;

        public string Text { get; set; }


        public void ComputeFlags()
        {
        }

        public override void DeserializeBody(BinaryReader br)
        {
            Text = StringUtil.Deserialize(br);
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            StringUtil.Serialize(Text, bw);
        }
    }
}