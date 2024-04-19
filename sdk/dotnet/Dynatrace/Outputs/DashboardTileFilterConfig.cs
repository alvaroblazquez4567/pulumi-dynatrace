// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Lbrlabs.PulumiPackage.Dynatrace.Outputs
{

    [OutputType]
    public sealed class DashboardTileFilterConfig
    {
        /// <summary>
        /// Configuration of a custom chart
        /// </summary>
        public readonly Outputs.DashboardTileFilterConfigChartConfig? ChartConfig;
        /// <summary>
        /// The name of the tile, set by user
        /// </summary>
        public readonly string CustomName;
        /// <summary>
        /// The default name of the tile
        /// </summary>
        public readonly string DefaultName;
        /// <summary>
        /// A set of all possible global dashboard filters that can be applied to a dashboard
        /// </summary>
        public readonly Outputs.DashboardTileFilterConfigFilters? Filters;
        /// <summary>
        /// The visualization of the timeseries chart. Possible values are `AREA`, `BAR` and `LINE`.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        public readonly string? Unknowns;

        [OutputConstructor]
        private DashboardTileFilterConfig(
            Outputs.DashboardTileFilterConfigChartConfig? chartConfig,

            string customName,

            string defaultName,

            Outputs.DashboardTileFilterConfigFilters? filters,

            string type,

            string? unknowns)
        {
            ChartConfig = chartConfig;
            CustomName = customName;
            DefaultName = defaultName;
            Filters = filters;
            Type = type;
            Unknowns = unknowns;
        }
    }
}
