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

    public sealed class AwsAnomaliesRdsHighCpuDetectionCustomThresholdsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// CPU usage is higher than
        /// </summary>
        [Input("cpuUsage", required: true)]
        public Input<double> CpuUsage { get; set; } = null!;

        public AwsAnomaliesRdsHighCpuDetectionCustomThresholdsArgs()
        {
        }
        public static new AwsAnomaliesRdsHighCpuDetectionCustomThresholdsArgs Empty => new AwsAnomaliesRdsHighCpuDetectionCustomThresholdsArgs();
    }
}
