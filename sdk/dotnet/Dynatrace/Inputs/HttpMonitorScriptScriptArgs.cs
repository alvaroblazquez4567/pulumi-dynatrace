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

    public sealed class HttpMonitorScriptScriptArgs : global::Pulumi.ResourceArgs
    {
        [Input("requests", required: true)]
        private InputList<Inputs.HttpMonitorScriptScriptRequestArgs>? _requests;

        /// <summary>
        /// A HTTP request to be performed by the monitor.
        /// </summary>
        public InputList<Inputs.HttpMonitorScriptScriptRequestArgs> Requests
        {
            get => _requests ?? (_requests = new InputList<Inputs.HttpMonitorScriptScriptRequestArgs>());
            set => _requests = value;
        }

        public HttpMonitorScriptScriptArgs()
        {
        }
        public static new HttpMonitorScriptScriptArgs Empty => new HttpMonitorScriptScriptArgs();
    }
}
