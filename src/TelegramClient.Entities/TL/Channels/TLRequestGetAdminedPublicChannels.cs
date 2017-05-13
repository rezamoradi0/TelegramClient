using System.IO;
using TelegramClient.Entities.TL.Messages;

namespace TelegramClient.Entities.TL.Channels
{
    using TelegramClient.Serialization.Attributes;

    public class TlRequestGetAdminedPublicChannels : TlMethod
    {
        public TlChats Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlChats) ObjectUtils.DeserializeObject(br);
        }
    }
}