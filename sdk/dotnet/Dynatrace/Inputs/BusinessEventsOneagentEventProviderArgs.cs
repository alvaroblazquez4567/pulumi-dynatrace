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

    public sealed class BusinessEventsOneagentEventProviderArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// [See our documentation](https://dt-url.net/ei034bx)
        /// </summary>
        [Input("path")]
        public Input<string>? Path { get; set; }

        /// <summary>
        /// Fixed value
        /// </summary>
        [Input("source")]
        public Input<string>? Source { get; set; }

        /// <summary>
        /// Possible Values: `Constant_string`, `Request_body`, `Request_headers`, `Request_method`, `Request_parameters`, `Request_path`, `Request_url`, `Response_body`, `Response_headers`, `Response_statusCode`
        /// </summary>
        [Input("sourceType", required: true)]
        public Input<string> SourceType { get; set; } = null!;

        public BusinessEventsOneagentEventProviderArgs()
        {
        }
        public static new BusinessEventsOneagentEventProviderArgs Empty => new BusinessEventsOneagentEventProviderArgs();
    }
}
