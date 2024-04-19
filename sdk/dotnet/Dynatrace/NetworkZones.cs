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
    [DynatraceResourceType("dynatrace:index/networkZones:NetworkZones")]
    public partial class NetworkZones : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Network Zones are enabled (`true`) or disabled (`false`)
        /// </summary>
        [Output("enabled")]
        public Output<bool> Enabled { get; private set; } = null!;


        /// <summary>
        /// Create a NetworkZones resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public NetworkZones(string name, NetworkZonesArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/networkZones:NetworkZones", name, args ?? new NetworkZonesArgs(), MakeResourceOptions(options, ""))
        {
        }

        private NetworkZones(string name, Input<string> id, NetworkZonesState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/networkZones:NetworkZones", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing NetworkZones resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static NetworkZones Get(string name, Input<string> id, NetworkZonesState? state = null, CustomResourceOptions? options = null)
        {
            return new NetworkZones(name, id, state, options);
        }
    }

    public sealed class NetworkZonesArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Network Zones are enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        public NetworkZonesArgs()
        {
        }
        public static new NetworkZonesArgs Empty => new NetworkZonesArgs();
    }

    public sealed class NetworkZonesState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Network Zones are enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        public NetworkZonesState()
        {
        }
        public static new NetworkZonesState Empty => new NetworkZonesState();
    }
}
