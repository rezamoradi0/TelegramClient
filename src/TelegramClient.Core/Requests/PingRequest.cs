using System;
using System.IO;
using TelegramClient.Core.Utils;
using TelegramClient.Entities;

namespace TelegramClient.Core.Requests
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(0x7abe77ec)]
    public class PingRequest : TlMethod
    {
        [SerializationOrder(0)]
        public long Random { get; set; } = TlHelpers.GenerateRandomLong();
    }
}