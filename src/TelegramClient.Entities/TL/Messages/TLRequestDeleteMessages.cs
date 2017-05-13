using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1510897371)]
    public class TlRequestDeleteMessages : TlMethod<TlAffectedMessages>
    {
        [SerializationOrder(0)]
        public TlVector<int> Id { get; set; }
    }
}