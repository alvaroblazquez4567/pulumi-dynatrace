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

    public sealed class DatabaseAnomaliesV2ResponseTimeFixedDetectionOverAlertingProtectionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Only alert if the abnormal state remains for at least
        /// </summary>
        [Input("minutesAbnormalState", required: true)]
        public Input<int> MinutesAbnormalState { get; set; } = null!;

        /// <summary>
        /// Only alert if there are at least
        /// </summary>
        [Input("requestsPerMinute", required: true)]
        public Input<double> RequestsPerMinute { get; set; } = null!;

        public DatabaseAnomaliesV2ResponseTimeFixedDetectionOverAlertingProtectionArgs()
        {
        }
        public static new DatabaseAnomaliesV2ResponseTimeFixedDetectionOverAlertingProtectionArgs Empty => new DatabaseAnomaliesV2ResponseTimeFixedDetectionOverAlertingProtectionArgs();
    }
}
