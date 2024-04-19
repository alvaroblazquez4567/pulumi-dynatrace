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

    public sealed class HttpMonitorScriptRequestGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Authentication options for this request
        /// </summary>
        [Input("authentication")]
        public Input<Inputs.HttpMonitorScriptRequestAuthenticationGetArgs>? Authentication { get; set; }

        /// <summary>
        /// The body of the HTTP request.
        /// </summary>
        [Input("body")]
        public Input<string>? Body { get; set; }

        /// <summary>
        /// The setup of the monitor
        /// </summary>
        [Input("configuration")]
        public Input<Inputs.HttpMonitorScriptRequestConfigurationGetArgs>? Configuration { get; set; }

        /// <summary>
        /// A short description of the event to appear in the web UI.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The HTTP method of the request.
        /// </summary>
        [Input("method", required: true)]
        public Input<string> Method { get; set; } = null!;

        /// <summary>
        /// Javascript code to execute after sending the request.
        /// </summary>
        [Input("postProcessing")]
        public Input<string>? PostProcessing { get; set; }

        /// <summary>
        /// Javascript code to execute before sending the request.
        /// </summary>
        [Input("preProcessing")]
        public Input<string>? PreProcessing { get; set; }

        /// <summary>
        /// Adapt request timeout option - the maximum time this request is allowed to consume. Keep in mind the maximum timeout of the complete monitor is 60 seconds
        /// </summary>
        [Input("requestTimeout")]
        public Input<int>? RequestTimeout { get; set; }

        /// <summary>
        /// The URL to check.
        /// </summary>
        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        /// <summary>
        /// Validation helps you verify that your HTTP monitor loads the expected content
        /// </summary>
        [Input("validation")]
        public Input<Inputs.HttpMonitorScriptRequestValidationGetArgs>? Validation { get; set; }

        public HttpMonitorScriptRequestGetArgs()
        {
        }
        public static new HttpMonitorScriptRequestGetArgs Empty => new HttpMonitorScriptRequestGetArgs();
    }
}
