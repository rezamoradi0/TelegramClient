using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1068696894)]
    public class TlRequestGetWallPapers : TlMethod
    {
        public TlVector<TlAbsWallPaper> Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = ObjectUtils.DeserializeVector<TlAbsWallPaper>(br);
        }
    }
}