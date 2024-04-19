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

    public sealed class BrowserMonitorAnomalyDetectionGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("loadingTimeThresholds")]
        private InputList<Inputs.BrowserMonitorAnomalyDetectionLoadingTimeThresholdGetArgs>? _loadingTimeThresholds;

        /// <summary>
        /// Thresholds for loading times
        /// </summary>
        public InputList<Inputs.BrowserMonitorAnomalyDetectionLoadingTimeThresholdGetArgs> LoadingTimeThresholds
        {
            get => _loadingTimeThresholds ?? (_loadingTimeThresholds = new InputList<Inputs.BrowserMonitorAnomalyDetectionLoadingTimeThresholdGetArgs>());
            set => _loadingTimeThresholds = value;
        }

        [Input("outageHandlings")]
        private InputList<Inputs.BrowserMonitorAnomalyDetectionOutageHandlingGetArgs>? _outageHandlings;

        /// <summary>
        /// Outage handling configuration
        /// </summary>
        public InputList<Inputs.BrowserMonitorAnomalyDetectionOutageHandlingGetArgs> OutageHandlings
        {
            get => _outageHandlings ?? (_outageHandlings = new InputList<Inputs.BrowserMonitorAnomalyDetectionOutageHandlingGetArgs>());
            set => _outageHandlings = value;
        }

        public BrowserMonitorAnomalyDetectionGetArgs()
        {
        }
        public static new BrowserMonitorAnomalyDetectionGetArgs Empty => new BrowserMonitorAnomalyDetectionGetArgs();
    }
}
