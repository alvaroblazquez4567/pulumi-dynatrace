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

    public sealed class OsServicesDetectionConditionsWindowsDetectionConditionsWindowGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// This string has to match a required format. See [OS services monitoring](https://dt-url.net/vl03xzk).
        /// </summary>
        [Input("condition")]
        public Input<string>? Condition { get; set; }

        [Input("hostMetadataCondition")]
        public Input<Inputs.OsServicesDetectionConditionsWindowsDetectionConditionsWindowHostMetadataConditionGetArgs>? HostMetadataCondition { get; set; }

        [Input("property")]
        public Input<string>? Property { get; set; }

        [Input("ruleType")]
        public Input<string>? RuleType { get; set; }

        [Input("startupCondition")]
        public Input<string>? StartupCondition { get; set; }

        public OsServicesDetectionConditionsWindowsDetectionConditionsWindowGetArgs()
        {
        }
        public static new OsServicesDetectionConditionsWindowsDetectionConditionsWindowGetArgs Empty => new OsServicesDetectionConditionsWindowsDetectionConditionsWindowGetArgs();
    }
}
