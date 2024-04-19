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

    public sealed class BrowserMonitorAnomalyDetectionArgs : global::Pulumi.ResourceArgs
    {
        [Input("loadingTimeThresholds")]
        private InputList<Inputs.BrowserMonitorAnomalyDetectionLoadingTimeThresholdArgs>? _loadingTimeThresholds;

        /// <summary>
        /// Thresholds for loading times
        /// </summary>
        public InputList<Inputs.BrowserMonitorAnomalyDetectionLoadingTimeThresholdArgs> LoadingTimeThresholds
        {
            get => _loadingTimeThresholds ?? (_loadingTimeThresholds = new InputList<Inputs.BrowserMonitorAnomalyDetectionLoadingTimeThresholdArgs>());
            set => _loadingTimeThresholds = value;
        }

        [Input("outageHandlings")]
        private InputList<Inputs.BrowserMonitorAnomalyDetectionOutageHandlingArgs>? _outageHandlings;

        /// <summary>
        /// Outage handling configuration
        /// </summary>
        public InputList<Inputs.BrowserMonitorAnomalyDetectionOutageHandlingArgs> OutageHandlings
        {
            get => _outageHandlings ?? (_outageHandlings = new InputList<Inputs.BrowserMonitorAnomalyDetectionOutageHandlingArgs>());
            set => _outageHandlings = value;
        }

        public BrowserMonitorAnomalyDetectionArgs()
        {
        }
        public static new BrowserMonitorAnomalyDetectionArgs Empty => new BrowserMonitorAnomalyDetectionArgs();
    }
}
