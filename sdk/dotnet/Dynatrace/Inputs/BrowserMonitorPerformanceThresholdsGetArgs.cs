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

    public sealed class BrowserMonitorPerformanceThresholdsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("thresholds", required: true)]
        private InputList<Inputs.BrowserMonitorPerformanceThresholdsThresholdGetArgs>? _thresholds;
        public InputList<Inputs.BrowserMonitorPerformanceThresholdsThresholdGetArgs> Thresholds
        {
            get => _thresholds ?? (_thresholds = new InputList<Inputs.BrowserMonitorPerformanceThresholdsThresholdGetArgs>());
            set => _thresholds = value;
        }

        public BrowserMonitorPerformanceThresholdsGetArgs()
        {
        }
        public static new BrowserMonitorPerformanceThresholdsGetArgs Empty => new BrowserMonitorPerformanceThresholdsGetArgs();
    }
}
