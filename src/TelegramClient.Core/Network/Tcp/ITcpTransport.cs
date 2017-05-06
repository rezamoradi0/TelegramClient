﻿namespace TelegramClient.Core.Network.Tcp
{
    using System.Threading.Tasks;

    internal interface ITcpTransport
    {
        void Send(byte[] packet);

        Task<byte[]> Receieve();
    }
}