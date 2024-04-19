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

    public sealed class EnvironmentQuotasUserSessionsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Annual environment quota. Not set if unlimited
        /// </summary>
        [Input("annual")]
        public Input<int>? Annual { get; set; }

        /// <summary>
        /// Monthly environment quota. Not set if unlimited
        /// </summary>
        [Input("monthly")]
        public Input<int>? Monthly { get; set; }

        public EnvironmentQuotasUserSessionsArgs()
        {
        }
        public static new EnvironmentQuotasUserSessionsArgs Empty => new EnvironmentQuotasUserSessionsArgs();
    }
}
