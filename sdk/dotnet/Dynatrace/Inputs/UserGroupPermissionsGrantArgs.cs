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

    public sealed class UserGroupPermissionsGrantArgs : global::Pulumi.ResourceArgs
    {
        [Input("environments")]
        private InputList<string>? _environments;

        /// <summary>
        /// The ids of the environments this permission grants the user access to.
        /// </summary>
        public InputList<string> Environments
        {
            get => _environments ?? (_environments = new InputList<string>());
            set => _environments = value;
        }

        /// <summary>
        /// The permission. Possible values are `VIEWER`, `MANAGE_SETTINGS`, `AGENT_INSTALL`, `LOG_VIEWER`, `VIEW_SENSITIVE_REQUEST_DATA`, `CONFIGURE_REQUEST_CAPTURE_DATA`, `REPLAY_SESSION_DATA`, `REPLAY_SESSION_DATA_WITHOUT_MASKING`, `MANAGE_SECURITY_PROBLEMS` and `MANAGE_SUPPORT_TICKETS`.
        /// </summary>
        [Input("permission", required: true)]
        public Input<string> Permission { get; set; } = null!;

        public UserGroupPermissionsGrantArgs()
        {
        }
        public static new UserGroupPermissionsGrantArgs Empty => new UserGroupPermissionsGrantArgs();
    }
}
