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

    public sealed class DashboardTileFilterConfigChartConfigSeriesDimensionGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("entityDimension")]
        public Input<bool>? EntityDimension { get; set; }

        /// <summary>
        /// the ID of the Dynatrace entity
        /// </summary>
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        /// <summary>
        /// The display name used to identify this generic filter
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        [Input("values")]
        private InputList<string>? _values;

        /// <summary>
        /// The splitting value
        /// </summary>
        public InputList<string> Values
        {
            get => _values ?? (_values = new InputList<string>());
            set => _values = value;
        }

        public DashboardTileFilterConfigChartConfigSeriesDimensionGetArgs()
        {
        }
        public static new DashboardTileFilterConfigChartConfigSeriesDimensionGetArgs Empty => new DashboardTileFilterConfigChartConfigSeriesDimensionGetArgs();
    }
}
