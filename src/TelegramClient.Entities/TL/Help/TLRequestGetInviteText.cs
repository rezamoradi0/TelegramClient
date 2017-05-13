using System.IO;

namespace TelegramClient.Entities.TL.Help
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1295590211)]
    public class TlRequestGetInviteText : TlMethod
    {
        public TlInviteText Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlInviteText) ObjectUtils.DeserializeObject(br);
        }
    }
}