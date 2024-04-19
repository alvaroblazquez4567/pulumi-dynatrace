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
    public sealed class WebApplicationCustomActionApdexSettings
    {
        /// <summary>
        /// Fallback threshold of an XHR action, defining a tolerable user experience, when the configured KPM is not available. Values between 0 and 240000 are allowed.
        /// </summary>
        public readonly int? FrustratingFallbackThreshold;
        /// <summary>
        /// Maximal value of apdex, which is considered as tolerable user experience. Values between 0 and 240000 are allowed.
        /// </summary>
        public readonly int? FrustratingThreshold;
        /// <summary>
        /// no documentation available
        /// </summary>
        public readonly int? Threshold;
        /// <summary>
        /// Fallback threshold of an XHR action, defining a satisfied user experience, when the configured KPM is not available. Values between 0 and 60000 are allowed.
        /// </summary>
        public readonly int? ToleratedFallbackThreshold;
        /// <summary>
        /// Maximal value of apdex, which is considered as satisfied user experience. Values between 0 and 60000 are allowed.
        /// </summary>
        public readonly int? ToleratedThreshold;

        [OutputConstructor]
        private WebApplicationCustomActionApdexSettings(
            int? frustratingFallbackThreshold,

            int? frustratingThreshold,

            int? threshold,

            int? toleratedFallbackThreshold,

            int? toleratedThreshold)
        {
            FrustratingFallbackThreshold = frustratingFallbackThreshold;
            FrustratingThreshold = frustratingThreshold;
            Threshold = threshold;
            ToleratedFallbackThreshold = toleratedFallbackThreshold;
            ToleratedThreshold = toleratedThreshold;
        }
    }
}
