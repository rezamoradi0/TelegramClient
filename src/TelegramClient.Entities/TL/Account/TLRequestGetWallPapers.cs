using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1068696894)]
    public class TlRequestGetWallPapers : TlMethod<TlVector<TlAbsWallPaper>>
    {
    }
}