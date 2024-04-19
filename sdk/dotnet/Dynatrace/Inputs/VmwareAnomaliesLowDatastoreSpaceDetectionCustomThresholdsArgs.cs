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

    public sealed class VmwareAnomaliesLowDatastoreSpaceDetectionCustomThresholdsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Datastore free space is lower than
        /// </summary>
        [Input("freeSpacePercentage", required: true)]
        public Input<int> FreeSpacePercentage { get; set; } = null!;

        public VmwareAnomaliesLowDatastoreSpaceDetectionCustomThresholdsArgs()
        {
        }
        public static new VmwareAnomaliesLowDatastoreSpaceDetectionCustomThresholdsArgs Empty => new VmwareAnomaliesLowDatastoreSpaceDetectionCustomThresholdsArgs();
    }
}
