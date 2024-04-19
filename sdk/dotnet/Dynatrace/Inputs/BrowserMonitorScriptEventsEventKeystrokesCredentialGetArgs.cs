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

    public sealed class BrowserMonitorScriptEventsEventKeystrokesCredentialGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Either `username` or `password`
        /// </summary>
        [Input("field", required: true)]
        public Input<string> Field { get; set; } = null!;

        /// <summary>
        /// The ID of the credential within the Credentials Vault
        /// </summary>
        [Input("vaultId", required: true)]
        public Input<string> VaultId { get; set; } = null!;

        public BrowserMonitorScriptEventsEventKeystrokesCredentialGetArgs()
        {
        }
        public static new BrowserMonitorScriptEventsEventKeystrokesCredentialGetArgs Empty => new BrowserMonitorScriptEventsEventKeystrokesCredentialGetArgs();
    }
}
