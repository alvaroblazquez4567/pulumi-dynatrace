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

    public sealed class DataPrivacyUserTrackingArgs : global::Pulumi.ResourceArgs
    {
        [Input("persistentCookieEnabled", required: true)]
        public Input<bool> PersistentCookieEnabled { get; set; } = null!;

        public DataPrivacyUserTrackingArgs()
        {
        }
        public static new DataPrivacyUserTrackingArgs Empty => new DataPrivacyUserTrackingArgs();
    }
}
