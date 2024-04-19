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

    public sealed class EnvironmentStorageRetentionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Log Monitoring consumption and quota information on environment level. Not set (and not editable) if Log monitoring is not enabled. Not set (and not editable) if Log monitoring is migrated to Davis data on license level
        /// </summary>
        [Input("logs")]
        public Input<int>? Logs { get; set; }

        /// <summary>
        /// Real user monitoring retention settings on environment level in days. Can be set to any value from 1 to 35 days
        /// </summary>
        [Input("rum", required: true)]
        public Input<int> Rum { get; set; } = null!;

        /// <summary>
        /// Service code level retention settings on environment level in days. Service code level retention time can't be greater than service request level retention time and both can't exceed one year
        /// </summary>
        [Input("serviceCodeLevel", required: true)]
        public Input<int> ServiceCodeLevel { get; set; } = null!;

        /// <summary>
        /// Service request level retention settings on environment level in days. Service code level retention time can't be greater than service request level retention time and both can't exceed one year
        /// </summary>
        [Input("serviceRequestLevel", required: true)]
        public Input<int> ServiceRequestLevel { get; set; } = null!;

        /// <summary>
        /// Session replay storage usage and limit information on environment level in bytes. 0 for unlimited.
        /// </summary>
        [Input("sessionReplay", required: true)]
        public Input<int> SessionReplay { get; set; } = null!;

        /// <summary>
        /// Synthetic monitors consumption and quota information on environment level. Not set (and not editable) if neither Synthetic nor DEM units is enabled
        /// </summary>
        [Input("synthetic", required: true)]
        public Input<int> Synthetic { get; set; } = null!;

        public EnvironmentStorageRetentionArgs()
        {
        }
        public static new EnvironmentStorageRetentionArgs Empty => new EnvironmentStorageRetentionArgs();
    }
}
