using System.IO;

namespace TelegramClient.Entities.TL.Help
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-990308245)]
    public class TlRequestGetConfig : TlMethod
    {
        public TlConfig Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlConfig) ObjectUtils.DeserializeObject(br);
        }
    }
}