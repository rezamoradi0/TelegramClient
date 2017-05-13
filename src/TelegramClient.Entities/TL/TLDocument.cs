using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-2027738169)]
    public class TlDocument : TlAbsDocument
    {
        [SerializationOrder(0)]
        public long Id { get; set; }

        [SerializationOrder(1)]
        public long AccessHash { get; set; }

        [SerializationOrder(2)]
        public int Date { get; set; }

        [SerializationOrder(3)]
        public string MimeType { get; set; }

        [SerializationOrder(4)]
        public int Size { get; set; }
    
        [SerializationOrder(5)]
        public TlAbsPhotoSize Thumb { get; set; }

        [SerializationOrder(6)]
        public int DcId { get; set; }

        [SerializationOrder(7)]
        public int Version { get; set; }

        [SerializationOrder(8)]
        public TlVector<TlAbsDocumentAttribute> Attributes { get; set; }
    }
}