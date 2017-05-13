using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using System;

    using TelegramClient.Serialization.Attributes;

    [SerializeAttribute(307276766)]
    public class TlAuthorizations: TlObject
    {
        [SerializationOrder(0)]
        public TlVector<TlAuthorization> Authorizations { get; set; }
    }
}