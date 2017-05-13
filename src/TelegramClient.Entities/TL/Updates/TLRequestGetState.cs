using System.IO;

namespace TelegramClient.Entities.TL.Updates
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-304838614)]
    public class TlRequestGetState : TlMethod
    {
        public TlState Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlState) ObjectUtils.DeserializeObject(br);
        }
    }
}