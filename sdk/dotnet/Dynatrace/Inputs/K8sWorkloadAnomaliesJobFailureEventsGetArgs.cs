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

    public sealed class K8sWorkloadAnomaliesJobFailureEventsGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        public K8sWorkloadAnomaliesJobFailureEventsGetArgs()
        {
        }
        public static new K8sWorkloadAnomaliesJobFailureEventsGetArgs Empty => new K8sWorkloadAnomaliesJobFailureEventsGetArgs();
    }
}
