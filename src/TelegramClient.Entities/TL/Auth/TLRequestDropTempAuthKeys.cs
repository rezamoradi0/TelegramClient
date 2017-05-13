using System.IO;

namespace TelegramClient.Entities.TL.Auth
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1907842680)]
    public class TlRequestDropTempAuthKeys : TlMethod
    {
        [SerializationOrder(0)]
        public TlVector<long> ExceptAuthKeys { get; set; }

        public bool Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = BoolUtil.Deserialize(br);
        }
    }
}