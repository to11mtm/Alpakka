﻿// //-----------------------------------------------------------------------
// // <copyright file="ProcessorFactory.cs" company="Akka.NET Project">
// //     Copyright (C) 2009-2022 Lightbend Inc. <http://www.lightbend.com>
// //     Copyright (C) 2013-2022 .NET Foundation <https://github.com/akkadotnet/akka.net>
// // </copyright>
// //-----------------------------------------------------------------------

using Azure.Messaging.EventHubs;

namespace Akka.Streams.Azure.EventHub.V5
{
    public interface IProcessorFactory
    {
        public EventProcessorClient CreateProcessor();
    }
}