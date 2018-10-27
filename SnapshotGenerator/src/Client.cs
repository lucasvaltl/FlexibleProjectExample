// Copyright (c) Improbable Worlds Ltd, All Rights Reserved

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Timers;
using Improbable;
using Improbable.Worker;

namespace Demo
{
    class Client
    {
        private const string ProjectName = "beta_lithium_oscar_465";
        private const string WorkerType = "InteractiveClient";
        private const string LoggerName = "Client.cs";
        private const int ErrorExitStatus = 1;
        private const uint GetOpListTimeoutInMilliseconds = 100;
        private const uint CommandRequestTimeoutMS = 100;
        private const int pingIntervalMs = 5000;

        private static readonly EntityId[] EntityIds =
        {
            new EntityId(1),
            new EntityId(2)
        };

        private static readonly string[] WorkerAttributes = {"lifeworker"};

        static int Main(string[] arguments)
        {
            Assembly.Load("GeneratedCode");

            Action printUsage = () =>
            {
                Console.WriteLine("Usage: Client <hostname> <port> <client_id>");
                Console.WriteLine("Connects to a demo deployment.");
                Console.WriteLine("    <hostname>      - hostname of the receptionist to connect to.");
                Console.WriteLine("    <port>          - port to use.");
                Console.WriteLine("    <client_id>     - name of the client.");
                Console.WriteLine("Alternatively: Client <snapshotfile> will generate a snapshot and exit.");
            };



            if (arguments.Length == 1)
            {
                SnapshotGenerator.GenerateSnapshot(arguments[0], WorkerAttributes);
                return 0;
            }
            else
            {
                printUsage();
                return ErrorExitStatus;
            }


        }
    }
}
