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

    public sealed class BrowserMonitorTagTagArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The origin of the tag. Supported values are `AWS`, `AWS_GENERIC`, `AZURE`, `CLOUD_FOUNDRY`, `CONTEXTLESS`, `ENVIRONMENT`, `GOOGLE_CLOUD` and `KUBERNETES`.
        /// </summary>
        [Input("context", required: true)]
        public Input<string> Context { get; set; } = null!;

        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        [Input("source")]
        public Input<string>? Source { get; set; }

        /// <summary>
        /// The value of the cookie. The following symbols are not allowed: `;`, `,`, `\` and `"`.
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public BrowserMonitorTagTagArgs()
        {
        }
        public static new BrowserMonitorTagTagArgs Empty => new BrowserMonitorTagTagArgs();
    }
}
