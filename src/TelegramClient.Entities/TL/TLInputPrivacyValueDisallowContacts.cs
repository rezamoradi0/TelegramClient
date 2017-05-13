using System.IO;

namespace TelegramClient.Entities.TL
{
    [SerializeAttribute(195371015)]
    public class TlInputPrivacyValueDisallowContacts : TlAbsInputPrivacyRule
    {
        public override int Constructor => 195371015;


        public void ComputeFlags()
        {
        }

        public override void DeserializeBody(BinaryReader br)
        {
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
        }
    }
}