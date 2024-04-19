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

    public sealed class BusinessEventsOneagentTriggersTriggerArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Case sensitive
        /// </summary>
        [Input("caseSensitive")]
        public Input<bool>? CaseSensitive { get; set; }

        /// <summary>
        /// Fixed value
        /// </summary>
        [Input("source", required: true)]
        public Input<Inputs.BusinessEventsOneagentTriggersTriggerSourceArgs> Source { get; set; } = null!;

        /// <summary>
        /// Event type
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public BusinessEventsOneagentTriggersTriggerArgs()
        {
        }
        public static new BusinessEventsOneagentTriggersTriggerArgs Empty => new BusinessEventsOneagentTriggersTriggerArgs();
    }
}