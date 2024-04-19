// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Lbrlabs.PulumiPackage.Dynatrace.Inputs
{

    public sealed class QueueManagerAliasQueueGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("aliasQueues")]
        private InputList<Inputs.QueueManagerAliasQueueAliasQueueGetArgs>? _aliasQueues;

        /// <summary>
        /// Alias queue definitions for queue manager
        /// </summary>
        public InputList<Inputs.QueueManagerAliasQueueAliasQueueGetArgs> AliasQueues
        {
            get => _aliasQueues ?? (_aliasQueues = new InputList<Inputs.QueueManagerAliasQueueAliasQueueGetArgs>());
            set => _aliasQueues = value;
        }

        public QueueManagerAliasQueueGetArgs()
        {
        }
        public static new QueueManagerAliasQueueGetArgs Empty => new QueueManagerAliasQueueGetArgs();
    }
}