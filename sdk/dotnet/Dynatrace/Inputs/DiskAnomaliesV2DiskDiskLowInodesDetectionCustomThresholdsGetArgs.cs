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

    public sealed class DiskAnomaliesV2DiskDiskLowInodesDetectionCustomThresholdsGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Alert if the percentage of available inodes is lower than this threshold in 3 out of 5 samples
        /// </summary>
        [Input("freeInodesPercentage", required: true)]
        public Input<int> FreeInodesPercentage { get; set; } = null!;

        public DiskAnomaliesV2DiskDiskLowInodesDetectionCustomThresholdsGetArgs()
        {
        }
        public static new DiskAnomaliesV2DiskDiskLowInodesDetectionCustomThresholdsGetArgs Empty => new DiskAnomaliesV2DiskDiskLowInodesDetectionCustomThresholdsGetArgs();
    }
}
