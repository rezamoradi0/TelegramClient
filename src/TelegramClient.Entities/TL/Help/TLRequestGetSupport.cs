using System.IO;

namespace TelegramClient.Entities.TL.Help
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1663104819)]
    public class TlRequestGetSupport : TlMethod
    {
        public TlSupport Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlSupport) ObjectUtils.DeserializeObject(br);
        }
    }
}