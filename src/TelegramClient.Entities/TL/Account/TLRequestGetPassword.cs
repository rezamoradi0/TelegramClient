using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1418342645)]
    public class TlRequestGetPassword : TlMethod
    {
        public TlAbsPassword Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsPassword) ObjectUtils.DeserializeObject(br);
        }
    }
}