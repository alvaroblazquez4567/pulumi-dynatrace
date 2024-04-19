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
    public sealed class ApplicationAnomaliesTrafficSpikes
    {
        /// <summary>
        /// The detection is enabled (`true`) or disabled (`false`)
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// Alert if the response time degrades by more than *X* %
        /// </summary>
        public readonly int? Percent;

        [OutputConstructor]
        private ApplicationAnomaliesTrafficSpikes(
            bool enabled,

            int? percent)
        {
            Enabled = enabled;
            Percent = percent;
        }
    }
}
