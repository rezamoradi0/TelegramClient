using System.IO;

namespace TelegramClient.Entities.TL
{
    [TLObject(2009052699)]
    public class TLPhotoSize : TLAbsPhotoSize
    {
        public override int Constructor => 2009052699;

        public string type { get; set; }
        public TLAbsFileLocation location { get; set; }
        public int w { get; set; }
        public int h { get; set; }
        public int size { get; set; }


        public void ComputeFlags()
        {
        }

        public override void DeserializeBody(BinaryReader br)
        {
            type = StringUtil.Deserialize(br);
            location = (TLAbsFileLocation) ObjectUtils.DeserializeObject(br);
            w = br.ReadInt32();
            h = br.ReadInt32();
            size = br.ReadInt32();
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            StringUtil.Serialize(type, bw);
            ObjectUtils.SerializeObject(location, bw);
            bw.Write(w);
            bw.Write(h);
            bw.Write(size);
        }
    }
}