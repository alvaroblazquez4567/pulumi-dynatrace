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

    public sealed class BrowserMonitorScriptConfigurationHeadersGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("headers", required: true)]
        private InputList<Inputs.BrowserMonitorScriptConfigurationHeadersHeaderGetArgs>? _headers;

        /// <summary>
        /// contains an HTTP header of the request
        /// </summary>
        public InputList<Inputs.BrowserMonitorScriptConfigurationHeadersHeaderGetArgs> Headers
        {
            get => _headers ?? (_headers = new InputList<Inputs.BrowserMonitorScriptConfigurationHeadersHeaderGetArgs>());
            set => _headers = value;
        }

        [Input("restrictions")]
        private InputList<string>? _restrictions;

        /// <summary>
        /// Restrict applying headers to a set of URLs
        /// </summary>
        public InputList<string> Restrictions
        {
            get => _restrictions ?? (_restrictions = new InputList<string>());
            set => _restrictions = value;
        }

        public BrowserMonitorScriptConfigurationHeadersGetArgs()
        {
        }
        public static new BrowserMonitorScriptConfigurationHeadersGetArgs Empty => new BrowserMonitorScriptConfigurationHeadersGetArgs();
    }
}
