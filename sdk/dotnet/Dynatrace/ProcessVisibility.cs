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
    [DynatraceResourceType("dynatrace:index/processVisibility:ProcessVisibility")]
    public partial class ProcessVisibility : global::Pulumi.CustomResource
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Output("enabled")]
        public Output<bool> Enabled { get; private set; } = null!;

        /// <summary>
        /// The maximum amount of processes that host may report is **100**
        /// </summary>
        [Output("maxProcesses")]
        public Output<int> MaxProcesses { get; private set; } = null!;

        /// <summary>
        /// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Output("scope")]
        public Output<string?> Scope { get; private set; } = null!;


        /// <summary>
        /// Create a ProcessVisibility resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ProcessVisibility(string name, ProcessVisibilityArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/processVisibility:ProcessVisibility", name, args ?? new ProcessVisibilityArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ProcessVisibility(string name, Input<string> id, ProcessVisibilityState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/processVisibility:ProcessVisibility", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ProcessVisibility resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ProcessVisibility Get(string name, Input<string> id, ProcessVisibilityState? state = null, CustomResourceOptions? options = null)
        {
            return new ProcessVisibility(name, id, state, options);
        }
    }

    public sealed class ProcessVisibilityArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// The maximum amount of processes that host may report is **100**
        /// </summary>
        [Input("maxProcesses", required: true)]
        public Input<int> MaxProcesses { get; set; } = null!;

        /// <summary>
        /// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        public ProcessVisibilityArgs()
        {
        }
        public static new ProcessVisibilityArgs Empty => new ProcessVisibilityArgs();
    }

    public sealed class ProcessVisibilityState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The maximum amount of processes that host may report is **100**
        /// </summary>
        [Input("maxProcesses")]
        public Input<int>? MaxProcesses { get; set; }

        /// <summary>
        /// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        public ProcessVisibilityState()
        {
        }
        public static new ProcessVisibilityState Empty => new ProcessVisibilityState();
    }
}
