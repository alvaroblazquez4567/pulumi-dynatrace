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
    [DynatraceResourceType("dynatrace:index/extensionExecutionController:ExtensionExecutionController")]
    public partial class ExtensionExecutionController : global::Pulumi.CustomResource
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Output("enabled")]
        public Output<bool> Enabled { get; private set; } = null!;

        /// <summary>
        /// Enable local HTTP Metric, Log and Event Ingest API
        /// </summary>
        [Output("ingestActive")]
        public Output<bool?> IngestActive { get; private set; } = null!;

        /// <summary>
        /// Possible Values: `DEFAULT`, `HIGH`
        /// </summary>
        [Output("performanceProfile")]
        public Output<string?> PerformanceProfile { get; private set; } = null!;

        /// <summary>
        /// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Output("scope")]
        public Output<string?> Scope { get; private set; } = null!;

        /// <summary>
        /// Enable Dynatrace StatsD
        /// </summary>
        [Output("statsdActive")]
        public Output<bool?> StatsdActive { get; private set; } = null!;


        /// <summary>
        /// Create a ExtensionExecutionController resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ExtensionExecutionController(string name, ExtensionExecutionControllerArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/extensionExecutionController:ExtensionExecutionController", name, args ?? new ExtensionExecutionControllerArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ExtensionExecutionController(string name, Input<string> id, ExtensionExecutionControllerState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/extensionExecutionController:ExtensionExecutionController", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ExtensionExecutionController resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ExtensionExecutionController Get(string name, Input<string> id, ExtensionExecutionControllerState? state = null, CustomResourceOptions? options = null)
        {
            return new ExtensionExecutionController(name, id, state, options);
        }
    }

    public sealed class ExtensionExecutionControllerArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// Enable local HTTP Metric, Log and Event Ingest API
        /// </summary>
        [Input("ingestActive")]
        public Input<bool>? IngestActive { get; set; }

        /// <summary>
        /// Possible Values: `DEFAULT`, `HIGH`
        /// </summary>
        [Input("performanceProfile")]
        public Input<string>? PerformanceProfile { get; set; }

        /// <summary>
        /// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        /// <summary>
        /// Enable Dynatrace StatsD
        /// </summary>
        [Input("statsdActive")]
        public Input<bool>? StatsdActive { get; set; }

        public ExtensionExecutionControllerArgs()
        {
        }
        public static new ExtensionExecutionControllerArgs Empty => new ExtensionExecutionControllerArgs();
    }

    public sealed class ExtensionExecutionControllerState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// Enable local HTTP Metric, Log and Event Ingest API
        /// </summary>
        [Input("ingestActive")]
        public Input<bool>? IngestActive { get; set; }

        /// <summary>
        /// Possible Values: `DEFAULT`, `HIGH`
        /// </summary>
        [Input("performanceProfile")]
        public Input<string>? PerformanceProfile { get; set; }

        /// <summary>
        /// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        /// <summary>
        /// Enable Dynatrace StatsD
        /// </summary>
        [Input("statsdActive")]
        public Input<bool>? StatsdActive { get; set; }

        public ExtensionExecutionControllerState()
        {
        }
        public static new ExtensionExecutionControllerState Empty => new ExtensionExecutionControllerState();
    }
}
