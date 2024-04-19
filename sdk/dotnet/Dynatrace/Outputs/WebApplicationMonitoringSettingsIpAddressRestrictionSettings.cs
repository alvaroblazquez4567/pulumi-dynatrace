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
    public sealed class WebApplicationMonitoringSettingsIpAddressRestrictionSettings
    {
        /// <summary>
        /// The mode of the list of browser restrictions. Possible values area `EXCLUDE` and `INCLUDE`.
        /// </summary>
        public readonly string Mode;
        /// <summary>
        /// A list of browser restrictions
        /// </summary>
        public readonly Outputs.WebApplicationMonitoringSettingsIpAddressRestrictionSettingsRestrictions? Restrictions;

        [OutputConstructor]
        private WebApplicationMonitoringSettingsIpAddressRestrictionSettings(
            string mode,

            Outputs.WebApplicationMonitoringSettingsIpAddressRestrictionSettingsRestrictions? restrictions)
        {
            Mode = mode;
            Restrictions = restrictions;
        }
    }
}
