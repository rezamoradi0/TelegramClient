using System.IO;

namespace TelegramClient.Entities.TL.Help
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1372724842)]
    public class TlRequestGetAppUpdate : TlMethod
    {
        public TlAbsAppUpdate Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsAppUpdate) ObjectUtils.DeserializeObject(br);
        }
    }
}