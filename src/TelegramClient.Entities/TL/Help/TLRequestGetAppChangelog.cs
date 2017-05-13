using System.IO;

namespace TelegramClient.Entities.TL.Help
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1189013126)]
    public class TlRequestGetAppChangelog : TlMethod
    {
        public TlAbsAppChangelog Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsAppChangelog) ObjectUtils.DeserializeObject(br);
        }
    }
}