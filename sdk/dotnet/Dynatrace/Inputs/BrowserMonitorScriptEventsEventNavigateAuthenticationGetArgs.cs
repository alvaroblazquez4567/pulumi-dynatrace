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

    public sealed class BrowserMonitorScriptEventsEventNavigateAuthenticationGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// A reference to the entry within the credential vault
        /// </summary>
        [Input("creds", required: true)]
        public Input<string> Creds { get; set; } = null!;

        /// <summary>
        /// The type of the threshold: `TOTAL` (total loading time) or `ACTION` (action loading time)
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public BrowserMonitorScriptEventsEventNavigateAuthenticationGetArgs()
        {
        }
        public static new BrowserMonitorScriptEventsEventNavigateAuthenticationGetArgs Empty => new BrowserMonitorScriptEventsEventNavigateAuthenticationGetArgs();
    }
}
