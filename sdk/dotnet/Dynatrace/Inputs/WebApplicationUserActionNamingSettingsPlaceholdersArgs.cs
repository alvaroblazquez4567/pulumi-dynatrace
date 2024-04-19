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

    public sealed class WebApplicationUserActionNamingSettingsPlaceholdersArgs : global::Pulumi.ResourceArgs
    {
        [Input("placeholders", required: true)]
        private InputList<Inputs.WebApplicationUserActionNamingSettingsPlaceholdersPlaceholderArgs>? _placeholders;

        /// <summary>
        /// User action placeholders
        /// </summary>
        public InputList<Inputs.WebApplicationUserActionNamingSettingsPlaceholdersPlaceholderArgs> Placeholders
        {
            get => _placeholders ?? (_placeholders = new InputList<Inputs.WebApplicationUserActionNamingSettingsPlaceholdersPlaceholderArgs>());
            set => _placeholders = value;
        }

        public WebApplicationUserActionNamingSettingsPlaceholdersArgs()
        {
        }
        public static new WebApplicationUserActionNamingSettingsPlaceholdersArgs Empty => new WebApplicationUserActionNamingSettingsPlaceholdersArgs();
    }
}