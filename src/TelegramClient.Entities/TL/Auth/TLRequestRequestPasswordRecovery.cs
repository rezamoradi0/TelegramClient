using System.IO;

namespace TelegramClient.Entities.TL.Auth
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-661144474)]
    public class TlRequestRequestPasswordRecovery : TlMethod
    {
        public TlPasswordRecovery Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlPasswordRecovery) ObjectUtils.DeserializeObject(br);
        }
    }
}