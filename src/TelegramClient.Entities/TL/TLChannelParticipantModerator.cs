using System.IO;

namespace TelegramClient.Entities.TL
{
    [SerializeAttribute(-1861910545)]
    public class TlChannelParticipantModerator : TlAbsChannelParticipant
    {
        public override int Constructor => -1861910545;

        public int UserId { get; set; }
        public int InviterId { get; set; }
        public int Date { get; set; }


        public void ComputeFlags()
        {
        }

        public override void DeserializeBody(BinaryReader br)
        {
            UserId = br.ReadInt32();
            InviterId = br.ReadInt32();
            Date = br.ReadInt32();
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(UserId);
            bw.Write(InviterId);
            bw.Write(Date);
        }
    }
}