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

    public sealed class ApplicationAnomaliesTrafficSpikesArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The detection is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// Alert if the response time degrades by more than *X* %
        /// </summary>
        [Input("percent")]
        public Input<int>? Percent { get; set; }

        public ApplicationAnomaliesTrafficSpikesArgs()
        {
        }
        public static new ApplicationAnomaliesTrafficSpikesArgs Empty => new ApplicationAnomaliesTrafficSpikesArgs();
    }
}
