using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-484392616)]
    public class TlRequestGetAuthorizations : TlMethod<TlAuthorizations>
    {
    }
}