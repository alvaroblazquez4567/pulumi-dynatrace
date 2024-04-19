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

    public sealed class ProcessMonitoringRuleConditionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// supported only with OneAgent 1.167+
        /// </summary>
        [Input("envVar")]
        public Input<string>? EnvVar { get; set; }

        /// <summary>
        /// Condition target
        /// </summary>
        [Input("item", required: true)]
        public Input<string> Item { get; set; } = null!;

        /// <summary>
        /// Condition operator
        /// </summary>
        [Input("operator", required: true)]
        public Input<string> Operator { get; set; } = null!;

        /// <summary>
        /// Condition value
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public ProcessMonitoringRuleConditionArgs()
        {
        }
        public static new ProcessMonitoringRuleConditionArgs Empty => new ProcessMonitoringRuleConditionArgs();
    }
}
