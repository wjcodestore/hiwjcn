﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;

namespace Lib.mq
{
    public static class RabbitMQExtension
    {
        public static void QueueDeclareXX(this IModel channel)
        {
            channel.QueueDeclare();
        }
    }
}
