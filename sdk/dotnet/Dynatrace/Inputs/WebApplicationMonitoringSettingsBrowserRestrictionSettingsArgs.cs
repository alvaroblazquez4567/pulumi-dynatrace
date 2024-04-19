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

    public sealed class WebApplicationMonitoringSettingsBrowserRestrictionSettingsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The mode of the list of browser restrictions. Possible values area `EXCLUDE` and `INCLUDE`.
        /// </summary>
        [Input("mode", required: true)]
        public Input<string> Mode { get; set; } = null!;

        /// <summary>
        /// A list of browser restrictions
        /// </summary>
        [Input("restrictions")]
        public Input<Inputs.WebApplicationMonitoringSettingsBrowserRestrictionSettingsRestrictionsArgs>? Restrictions { get; set; }

        public WebApplicationMonitoringSettingsBrowserRestrictionSettingsArgs()
        {
        }
        public static new WebApplicationMonitoringSettingsBrowserRestrictionSettingsArgs Empty => new WebApplicationMonitoringSettingsBrowserRestrictionSettingsArgs();
    }
}