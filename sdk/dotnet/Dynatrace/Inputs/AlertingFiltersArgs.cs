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

    public sealed class AlertingFiltersArgs : global::Pulumi.ResourceArgs
    {
        [Input("filters")]
        private InputList<Inputs.AlertingFiltersFilterArgs>? _filters;

        /// <summary>
        /// A conditions for the metric usage
        /// </summary>
        public InputList<Inputs.AlertingFiltersFilterArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.AlertingFiltersFilterArgs>());
            set => _filters = value;
        }

        public AlertingFiltersArgs()
        {
        }
        public static new AlertingFiltersArgs Empty => new AlertingFiltersArgs();
    }
}