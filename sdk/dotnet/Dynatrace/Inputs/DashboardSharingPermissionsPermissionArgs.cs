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

    public sealed class DashboardSharingPermissionsPermissionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of the user or group to whom the permission is granted.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// The level of the permission:
        /// </summary>
        [Input("level", required: true)]
        public Input<string> Level { get; set; } = null!;

        /// <summary>
        /// The type of the permission:
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public DashboardSharingPermissionsPermissionArgs()
        {
        }
        public static new DashboardSharingPermissionsPermissionArgs Empty => new DashboardSharingPermissionsPermissionArgs();
    }
}
