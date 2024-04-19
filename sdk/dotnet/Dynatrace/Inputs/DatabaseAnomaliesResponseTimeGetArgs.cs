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

    public sealed class DatabaseAnomaliesResponseTimeGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Parameters of the response time degradation auto-detection. Violation of **any** criterion triggers an alert
        /// </summary>
        [Input("auto")]
        public Input<Inputs.DatabaseAnomaliesResponseTimeAutoGetArgs>? Auto { get; set; }

        /// <summary>
        /// Fixed thresholds for response time degradation detection
        /// </summary>
        [Input("thresholds")]
        public Input<Inputs.DatabaseAnomaliesResponseTimeThresholdsGetArgs>? Thresholds { get; set; }

        public DatabaseAnomaliesResponseTimeGetArgs()
        {
        }
        public static new DatabaseAnomaliesResponseTimeGetArgs Empty => new DatabaseAnomaliesResponseTimeGetArgs();
    }
}
