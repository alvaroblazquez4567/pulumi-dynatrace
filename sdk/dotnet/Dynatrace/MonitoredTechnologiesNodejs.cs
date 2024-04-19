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
    [DynatraceResourceType("dynatrace:index/monitoredTechnologiesNodejs:MonitoredTechnologiesNodejs")]
    public partial class MonitoredTechnologiesNodejs : global::Pulumi.CustomResource
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Output("enabled")]
        public Output<bool> Enabled { get; private set; } = null!;

        /// <summary>
        /// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        /// </summary>
        [Output("hostId")]
        public Output<string?> HostId { get; private set; } = null!;


        /// <summary>
        /// Create a MonitoredTechnologiesNodejs resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public MonitoredTechnologiesNodejs(string name, MonitoredTechnologiesNodejsArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/monitoredTechnologiesNodejs:MonitoredTechnologiesNodejs", name, args ?? new MonitoredTechnologiesNodejsArgs(), MakeResourceOptions(options, ""))
        {
        }

        private MonitoredTechnologiesNodejs(string name, Input<string> id, MonitoredTechnologiesNodejsState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/monitoredTechnologiesNodejs:MonitoredTechnologiesNodejs", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing MonitoredTechnologiesNodejs resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static MonitoredTechnologiesNodejs Get(string name, Input<string> id, MonitoredTechnologiesNodejsState? state = null, CustomResourceOptions? options = null)
        {
            return new MonitoredTechnologiesNodejs(name, id, state, options);
        }
    }

    public sealed class MonitoredTechnologiesNodejsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        /// </summary>
        [Input("hostId")]
        public Input<string>? HostId { get; set; }

        public MonitoredTechnologiesNodejsArgs()
        {
        }
        public static new MonitoredTechnologiesNodejsArgs Empty => new MonitoredTechnologiesNodejsArgs();
    }

    public sealed class MonitoredTechnologiesNodejsState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        /// </summary>
        [Input("hostId")]
        public Input<string>? HostId { get; set; }

        public MonitoredTechnologiesNodejsState()
        {
        }
        public static new MonitoredTechnologiesNodejsState Empty => new MonitoredTechnologiesNodejsState();
    }
}
