using System;
using System.Collections.Generic;
using System.IO;
using TelegramClient.Entities;

namespace TelegramClient.Core.Requests
{
    using System.Linq;

    using TelegramClient.Serialization.Attributes;

    [Serialize(0x62d6b459)]
    public class AckRequest : TlMethod
    {
        [SerializationOrder(0)]
        public TlVector<ulong> Messages { get; set; } = new TlVector<ulong>();

        public AckRequest(HashSet<ulong> msgs)
        {
            Messages.Lists = msgs.ToList();
        }

        public override bool Confirmed => false;
    }
}