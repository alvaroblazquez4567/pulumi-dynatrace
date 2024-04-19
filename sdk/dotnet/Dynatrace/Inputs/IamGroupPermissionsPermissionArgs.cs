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

    public sealed class IamGroupPermissionsPermissionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Possible values: `account-company-info`, `account-user-management`, `account-viewer`, `account-saml-flexible-federation`, `tenant-viewer`, `tenant-manage-settings`, `tenant-agent-install`, `tenant-logviewer`, `tenant-view-sensitive-request-data`, `tenant-configure-request-capture-data`, `tenant-replay-sessions-with-masking`, `tenant-replay-sessions-without-masking`, `tenant-manage-security-problems`, `tenant-view-security-problems`, `tenant-manage-support-tickets`
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// If `type` is `account` this attribute should hold the UUID of the account. If `type` is 'tenant`this attribute should hold the ID of the environment (`https://\n\n.live.dynatrace.com`). If`type`is`management-zone`this attribute should hold a value like`\n\n:\n\n. You need to use the attribute `legacy_id` when referring to a resource `dynatrace.ManagementZoneV2` or a data source `dynatrace.ManagementZone`.
        /// </summary>
        [Input("scope", required: true)]
        public Input<string> Scope { get; set; } = null!;

        /// <summary>
        /// The type of this permission. Possible values are `account`, `tenant`, `management-zone`
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public IamGroupPermissionsPermissionArgs()
        {
        }
        public static new IamGroupPermissionsPermissionArgs Empty => new IamGroupPermissionsPermissionArgs();
    }
}
