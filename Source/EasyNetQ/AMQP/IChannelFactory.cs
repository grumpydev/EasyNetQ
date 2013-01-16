﻿using RabbitMQ.Client;

namespace EasyNetQ.AMQP
{
    public interface IChannelFactory
    {
        IChannel OpenChannel(IConnection connection, ChannelSettings settings);
    }
}