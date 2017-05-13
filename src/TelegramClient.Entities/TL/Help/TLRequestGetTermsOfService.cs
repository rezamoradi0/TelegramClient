using System.IO;

namespace TelegramClient.Entities.TL.Help
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(889286899)]
    public class TlRequestGetTermsOfService : TlMethod
    {
        public TlTermsOfService Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlTermsOfService) ObjectUtils.DeserializeObject(br);
        }
    }
}