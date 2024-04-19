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
    [DynatraceResourceType("dynatrace:index/managedPublicEndpoints:ManagedPublicEndpoints")]
    public partial class ManagedPublicEndpoints : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Additional web UI addresses
        /// </summary>
        [Output("additionalWebUiAddresses")]
        public Output<ImmutableArray<string>> AdditionalWebUiAddresses { get; private set; } = null!;

        /// <summary>
        /// Beacon forwarder address
        /// </summary>
        [Output("beaconForwarderAddress")]
        public Output<string?> BeaconForwarderAddress { get; private set; } = null!;

        /// <summary>
        /// CDN address
        /// </summary>
        [Output("cdnAddress")]
        public Output<string?> CdnAddress { get; private set; } = null!;

        /// <summary>
        /// Web UI address
        /// </summary>
        [Output("webUiAddress")]
        public Output<string?> WebUiAddress { get; private set; } = null!;


        /// <summary>
        /// Create a ManagedPublicEndpoints resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ManagedPublicEndpoints(string name, ManagedPublicEndpointsArgs? args = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/managedPublicEndpoints:ManagedPublicEndpoints", name, args ?? new ManagedPublicEndpointsArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ManagedPublicEndpoints(string name, Input<string> id, ManagedPublicEndpointsState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/managedPublicEndpoints:ManagedPublicEndpoints", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ManagedPublicEndpoints resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ManagedPublicEndpoints Get(string name, Input<string> id, ManagedPublicEndpointsState? state = null, CustomResourceOptions? options = null)
        {
            return new ManagedPublicEndpoints(name, id, state, options);
        }
    }

    public sealed class ManagedPublicEndpointsArgs : global::Pulumi.ResourceArgs
    {
        [Input("additionalWebUiAddresses")]
        private InputList<string>? _additionalWebUiAddresses;

        /// <summary>
        /// Additional web UI addresses
        /// </summary>
        public InputList<string> AdditionalWebUiAddresses
        {
            get => _additionalWebUiAddresses ?? (_additionalWebUiAddresses = new InputList<string>());
            set => _additionalWebUiAddresses = value;
        }

        /// <summary>
        /// Beacon forwarder address
        /// </summary>
        [Input("beaconForwarderAddress")]
        public Input<string>? BeaconForwarderAddress { get; set; }

        /// <summary>
        /// CDN address
        /// </summary>
        [Input("cdnAddress")]
        public Input<string>? CdnAddress { get; set; }

        /// <summary>
        /// Web UI address
        /// </summary>
        [Input("webUiAddress")]
        public Input<string>? WebUiAddress { get; set; }

        public ManagedPublicEndpointsArgs()
        {
        }
        public static new ManagedPublicEndpointsArgs Empty => new ManagedPublicEndpointsArgs();
    }

    public sealed class ManagedPublicEndpointsState : global::Pulumi.ResourceArgs
    {
        [Input("additionalWebUiAddresses")]
        private InputList<string>? _additionalWebUiAddresses;

        /// <summary>
        /// Additional web UI addresses
        /// </summary>
        public InputList<string> AdditionalWebUiAddresses
        {
            get => _additionalWebUiAddresses ?? (_additionalWebUiAddresses = new InputList<string>());
            set => _additionalWebUiAddresses = value;
        }

        /// <summary>
        /// Beacon forwarder address
        /// </summary>
        [Input("beaconForwarderAddress")]
        public Input<string>? BeaconForwarderAddress { get; set; }

        /// <summary>
        /// CDN address
        /// </summary>
        [Input("cdnAddress")]
        public Input<string>? CdnAddress { get; set; }

        /// <summary>
        /// Web UI address
        /// </summary>
        [Input("webUiAddress")]
        public Input<string>? WebUiAddress { get; set; }

        public ManagedPublicEndpointsState()
        {
        }
        public static new ManagedPublicEndpointsState Empty => new ManagedPublicEndpointsState();
    }
}
