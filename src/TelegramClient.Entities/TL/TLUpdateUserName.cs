using System.IO;

namespace TelegramClient.Entities.TL
{
    [TLObject(-1489818765)]
    public class TLUpdateUserName : TLAbsUpdate
    {
        public override int Constructor => -1489818765;

        public int user_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string username { get; set; }


        public void ComputeFlags()
        {
        }

        public override void DeserializeBody(BinaryReader br)
        {
            user_id = br.ReadInt32();
            first_name = StringUtil.Deserialize(br);
            last_name = StringUtil.Deserialize(br);
            username = StringUtil.Deserialize(br);
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(user_id);
            StringUtil.Serialize(first_name, bw);
            StringUtil.Serialize(last_name, bw);
            StringUtil.Serialize(username, bw);
        }
    }
}