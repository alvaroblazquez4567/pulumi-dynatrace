// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Lbrlabs.PulumiPackage.Dynatrace.Outputs
{

    [OutputType]
    public sealed class WebApplicationMonitoringSettingsContentCaptureVisuallyCompleteSettings
    {
        /// <summary>
        /// A RegularExpression used to exclude images and iframes from being detected by the VC module
        /// </summary>
        public readonly string? ExcludeUrlRegex;
        /// <summary>
        /// Query selector for mutation nodes to ignore in VC and SI calculation
        /// </summary>
        public readonly string? IgnoredMutationsList;
        /// <summary>
        /// The time in ms the VC module waits for no mutations happening on the page after the load action. Defaults to 1000. Valid values range from 0 to 30000.
        /// </summary>
        public readonly int? InactivityTimeout;
        /// <summary>
        /// Determines the time in ms VC waits after an action closes to start calculation. Defaults to 50. Valid values range from 0 to 5000.
        /// </summary>
        public readonly int? MutationTimeout;
        /// <summary>
        /// no documentation available
        /// </summary>
        public readonly int? Threshold;

        [OutputConstructor]
        private WebApplicationMonitoringSettingsContentCaptureVisuallyCompleteSettings(
            string? excludeUrlRegex,

            string? ignoredMutationsList,

            int? inactivityTimeout,

            int? mutationTimeout,

            int? threshold)
        {
            ExcludeUrlRegex = excludeUrlRegex;
            IgnoredMutationsList = ignoredMutationsList;
            InactivityTimeout = inactivityTimeout;
            MutationTimeout = mutationTimeout;
            Threshold = threshold;
        }
    }
}
