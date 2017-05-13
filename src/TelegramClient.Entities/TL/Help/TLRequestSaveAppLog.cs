using System.IO;

namespace TelegramClient.Entities.TL.Help
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1862465352)]
    public class TlRequestSaveAppLog : TlMethod
    {
        [SerializationOrder(0)]
        public TlVector<TlInputAppEvent> Events { get; set; }

        public bool Response { get; set; }
        
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = BoolUtil.Deserialize(br);
        }
    }
}