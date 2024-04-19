// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Lbrlabs.PulumiPackage.Dynatrace.Outputs
{

    [OutputType]
    public sealed class ImsBridgesQueueManagerQueueManager
    {
        /// <summary>
        /// The name of the queue manager
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Queue(s) that belong to the queue manager
        /// </summary>
        public readonly ImmutableArray<string> QueueManagerQueues;

        [OutputConstructor]
        private ImsBridgesQueueManagerQueueManager(
            string name,

            ImmutableArray<string> queueManagerQueues)
        {
            Name = name;
            QueueManagerQueues = queueManagerQueues;
        }
    }
}
