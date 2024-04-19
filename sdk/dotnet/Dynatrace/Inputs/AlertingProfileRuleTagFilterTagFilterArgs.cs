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

    public sealed class AlertingProfileRuleTagFilterTagFilterArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The origin of the tag, such as AWS or Cloud Foundry. Custom tags use the `CONTEXTLESS` value
        /// </summary>
        [Input("context", required: true)]
        public Input<string> Context { get; set; } = null!;

        /// <summary>
        /// The key of the tag. Custom tags have the tag value here
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// The value to compare to
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public AlertingProfileRuleTagFilterTagFilterArgs()
        {
        }
        public static new AlertingProfileRuleTagFilterTagFilterArgs Empty => new AlertingProfileRuleTagFilterTagFilterArgs();
    }
}
