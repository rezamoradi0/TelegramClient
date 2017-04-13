using System.IO;

namespace TelegramClient.Entities.TL
{
    [TLObject(942527460)]
    public class TLUpdateServiceNotification : TLAbsUpdate
    {
        public override int Constructor => 942527460;

        public string type { get; set; }
        public string message { get; set; }
        public TLAbsMessageMedia media { get; set; }
        public bool popup { get; set; }


        public void ComputeFlags()
        {
        }

        public override void DeserializeBody(BinaryReader br)
        {
            type = StringUtil.Deserialize(br);
            message = StringUtil.Deserialize(br);
            media = (TLAbsMessageMedia) ObjectUtils.DeserializeObject(br);
            popup = BoolUtil.Deserialize(br);
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            StringUtil.Serialize(type, bw);
            StringUtil.Serialize(message, bw);
            ObjectUtils.SerializeObject(media, bw);
            BoolUtil.Serialize(popup, bw);
        }
    }
}