using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1418342645)]
    public class TlRequestGetPassword : TlMethod<TlAbsPassword>
    {
    }
}