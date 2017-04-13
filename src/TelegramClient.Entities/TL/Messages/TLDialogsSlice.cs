using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    [TLObject(1910543603)]
    public class TLDialogsSlice : TLAbsDialogs
    {
        public override int Constructor => 1910543603;

        public int count { get; set; }
        public TLVector<TLDialog> dialogs { get; set; }
        public TLVector<TLAbsMessage> messages { get; set; }
        public TLVector<TLAbsChat> chats { get; set; }
        public TLVector<TLAbsUser> users { get; set; }


        public void ComputeFlags()
        {
        }

        public override void DeserializeBody(BinaryReader br)
        {
            count = br.ReadInt32();
            dialogs = ObjectUtils.DeserializeVector<TLDialog>(br);
            messages = ObjectUtils.DeserializeVector<TLAbsMessage>(br);
            chats = ObjectUtils.DeserializeVector<TLAbsChat>(br);
            users = ObjectUtils.DeserializeVector<TLAbsUser>(br);
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(count);
            ObjectUtils.SerializeObject(dialogs, bw);
            ObjectUtils.SerializeObject(messages, bw);
            ObjectUtils.SerializeObject(chats, bw);
            ObjectUtils.SerializeObject(users, bw);
        }
    }
}