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

    public sealed class DatabaseAnomaliesLoadGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The configuration of traffic drops detection
        /// </summary>
        [Input("drops")]
        public Input<Inputs.DatabaseAnomaliesLoadDropsGetArgs>? Drops { get; set; }

        /// <summary>
        /// The configuration of traffic spikes detection
        /// </summary>
        [Input("spikes")]
        public Input<Inputs.DatabaseAnomaliesLoadSpikesGetArgs>? Spikes { get; set; }

        public DatabaseAnomaliesLoadGetArgs()
        {
        }
        public static new DatabaseAnomaliesLoadGetArgs Empty => new DatabaseAnomaliesLoadGetArgs();
    }
}
