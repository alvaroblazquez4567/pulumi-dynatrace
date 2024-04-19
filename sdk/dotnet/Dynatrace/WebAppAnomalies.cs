// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Lbrlabs.PulumiPackage.Dynatrace
{
    [DynatraceResourceType("dynatrace:index/webAppAnomalies:WebAppAnomalies")]
    public partial class WebAppAnomalies : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Error rate
        /// </summary>
        [Output("errorRate")]
        public Output<Outputs.WebAppAnomaliesErrorRate> ErrorRate { get; private set; } = null!;

        /// <summary>
        /// Response time
        /// </summary>
        [Output("responseTime")]
        public Output<Outputs.WebAppAnomaliesResponseTime> ResponseTime { get; private set; } = null!;

        /// <summary>
        /// The scope of this setting (APPLICATION_METHOD, APPLICATION). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Output("scope")]
        public Output<string?> Scope { get; private set; } = null!;

        /// <summary>
        /// Dynatrace learns your typical application traffic over an observation period of one week.
        /// </summary>
        [Output("trafficDrops")]
        public Output<Outputs.WebAppAnomaliesTrafficDrops> TrafficDrops { get; private set; } = null!;

        /// <summary>
        /// Dynatrace learns your typical application traffic over an observation period of one week.
        /// </summary>
        [Output("trafficSpikes")]
        public Output<Outputs.WebAppAnomaliesTrafficSpikes> TrafficSpikes { get; private set; } = null!;


        /// <summary>
        /// Create a WebAppAnomalies resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public WebAppAnomalies(string name, WebAppAnomaliesArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/webAppAnomalies:WebAppAnomalies", name, args ?? new WebAppAnomaliesArgs(), MakeResourceOptions(options, ""))
        {
        }

        private WebAppAnomalies(string name, Input<string> id, WebAppAnomaliesState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/webAppAnomalies:WebAppAnomalies", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/alvaroblazquez4567",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing WebAppAnomalies resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static WebAppAnomalies Get(string name, Input<string> id, WebAppAnomaliesState? state = null, CustomResourceOptions? options = null)
        {
            return new WebAppAnomalies(name, id, state, options);
        }
    }

    public sealed class WebAppAnomaliesArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Error rate
        /// </summary>
        [Input("errorRate", required: true)]
        public Input<Inputs.WebAppAnomaliesErrorRateArgs> ErrorRate { get; set; } = null!;

        /// <summary>
        /// Response time
        /// </summary>
        [Input("responseTime", required: true)]
        public Input<Inputs.WebAppAnomaliesResponseTimeArgs> ResponseTime { get; set; } = null!;

        /// <summary>
        /// The scope of this setting (APPLICATION_METHOD, APPLICATION). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        /// <summary>
        /// Dynatrace learns your typical application traffic over an observation period of one week.
        /// </summary>
        [Input("trafficDrops", required: true)]
        public Input<Inputs.WebAppAnomaliesTrafficDropsArgs> TrafficDrops { get; set; } = null!;

        /// <summary>
        /// Dynatrace learns your typical application traffic over an observation period of one week.
        /// </summary>
        [Input("trafficSpikes", required: true)]
        public Input<Inputs.WebAppAnomaliesTrafficSpikesArgs> TrafficSpikes { get; set; } = null!;

        public WebAppAnomaliesArgs()
        {
        }
        public static new WebAppAnomaliesArgs Empty => new WebAppAnomaliesArgs();
    }

    public sealed class WebAppAnomaliesState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Error rate
        /// </summary>
        [Input("errorRate")]
        public Input<Inputs.WebAppAnomaliesErrorRateGetArgs>? ErrorRate { get; set; }

        /// <summary>
        /// Response time
        /// </summary>
        [Input("responseTime")]
        public Input<Inputs.WebAppAnomaliesResponseTimeGetArgs>? ResponseTime { get; set; }

        /// <summary>
        /// The scope of this setting (APPLICATION_METHOD, APPLICATION). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        /// <summary>
        /// Dynatrace learns your typical application traffic over an observation period of one week.
        /// </summary>
        [Input("trafficDrops")]
        public Input<Inputs.WebAppAnomaliesTrafficDropsGetArgs>? TrafficDrops { get; set; }

        /// <summary>
        /// Dynatrace learns your typical application traffic over an observation period of one week.
        /// </summary>
        [Input("trafficSpikes")]
        public Input<Inputs.WebAppAnomaliesTrafficSpikesGetArgs>? TrafficSpikes { get; set; }

        public WebAppAnomaliesState()
        {
        }
        public static new WebAppAnomaliesState Empty => new WebAppAnomaliesState();
    }
}
