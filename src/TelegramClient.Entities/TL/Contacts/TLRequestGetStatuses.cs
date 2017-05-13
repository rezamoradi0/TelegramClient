using System.IO;

namespace TelegramClient.Entities.TL.Contacts
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-995929106)]
    public class TlRequestGetStatuses : TlMethod
    {
        public TlVector<TlContactStatus> Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = ObjectUtils.DeserializeVector<TlContactStatus>(br);
        }
    }
}