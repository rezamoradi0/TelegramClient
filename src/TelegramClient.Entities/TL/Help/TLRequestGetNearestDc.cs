using System.IO;

namespace TelegramClient.Entities.TL.Help
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(531836966)]
    public class TlRequestGetNearestDc : TlMethod
    {
        public TlNearestDc Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlNearestDc) ObjectUtils.DeserializeObject(br);
        }
    }
}