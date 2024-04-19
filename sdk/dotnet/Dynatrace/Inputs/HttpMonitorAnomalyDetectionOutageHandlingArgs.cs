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

    public sealed class HttpMonitorAnomalyDetectionOutageHandlingArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// (Field has overlap with `dynatrace.BrowserMonitorOutage` and `dynatrace.HttpMonitorOutage`) When enabled (`true`), generate a problem and send an alert when the monitor is unavailable at all configured locations
        /// </summary>
        [Input("globalOutage")]
        public Input<bool>? GlobalOutage { get; set; }

        [Input("globalOutagePolicies")]
        private InputList<Inputs.HttpMonitorAnomalyDetectionOutageHandlingGlobalOutagePolicyArgs>? _globalOutagePolicies;

        /// <summary>
        /// (Field has overlap with `dynatrace.BrowserMonitorOutage` and `dynatrace.HttpMonitorOutage`) Global outage handling configuration.
        /// </summary>
        public InputList<Inputs.HttpMonitorAnomalyDetectionOutageHandlingGlobalOutagePolicyArgs> GlobalOutagePolicies
        {
            get => _globalOutagePolicies ?? (_globalOutagePolicies = new InputList<Inputs.HttpMonitorAnomalyDetectionOutageHandlingGlobalOutagePolicyArgs>());
            set => _globalOutagePolicies = value;
        }

        [Input("localOutage")]
        public Input<bool>? LocalOutage { get; set; }

        [Input("localOutagePolicies")]
        private InputList<Inputs.HttpMonitorAnomalyDetectionOutageHandlingLocalOutagePolicyArgs>? _localOutagePolicies;
        public InputList<Inputs.HttpMonitorAnomalyDetectionOutageHandlingLocalOutagePolicyArgs> LocalOutagePolicies
        {
            get => _localOutagePolicies ?? (_localOutagePolicies = new InputList<Inputs.HttpMonitorAnomalyDetectionOutageHandlingLocalOutagePolicyArgs>());
            set => _localOutagePolicies = value;
        }

        [Input("retryOnError")]
        public Input<bool>? RetryOnError { get; set; }

        public HttpMonitorAnomalyDetectionOutageHandlingArgs()
        {
        }
        public static new HttpMonitorAnomalyDetectionOutageHandlingArgs Empty => new HttpMonitorAnomalyDetectionOutageHandlingArgs();
    }
}