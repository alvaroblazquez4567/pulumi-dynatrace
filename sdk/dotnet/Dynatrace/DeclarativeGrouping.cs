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
    [DynatraceResourceType("dynatrace:index/declarativeGrouping:DeclarativeGrouping")]
    public partial class DeclarativeGrouping : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Enter a descriptive process group display name and a unique identifier that Dynatrace can use to recognize this process
        /// group.
        /// </summary>
        [Output("detection")]
        public Output<Outputs.DeclarativeGroupingDetection?> Detection { get; private set; } = null!;

        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Output("enabled")]
        public Output<bool> Enabled { get; private set; } = null!;

        /// <summary>
        /// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this
        /// instance regarding order. If not specified when creating the setting will be added to the end of the list. If not
        /// specified during update the order will remain untouched
        /// </summary>
        [Output("insertAfter")]
        public Output<string> InsertAfter { get; private set; } = null!;

        /// <summary>
        /// Monitored technology name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Output("scope")]
        public Output<string?> Scope { get; private set; } = null!;


        /// <summary>
        /// Create a DeclarativeGrouping resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DeclarativeGrouping(string name, DeclarativeGroupingArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/declarativeGrouping:DeclarativeGrouping", name, args ?? new DeclarativeGroupingArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DeclarativeGrouping(string name, Input<string> id, DeclarativeGroupingState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/declarativeGrouping:DeclarativeGrouping", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing DeclarativeGrouping resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DeclarativeGrouping Get(string name, Input<string> id, DeclarativeGroupingState? state = null, CustomResourceOptions? options = null)
        {
            return new DeclarativeGrouping(name, id, state, options);
        }
    }

    public sealed class DeclarativeGroupingArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Enter a descriptive process group display name and a unique identifier that Dynatrace can use to recognize this process
        /// group.
        /// </summary>
        [Input("detection")]
        public Input<Inputs.DeclarativeGroupingDetectionArgs>? Detection { get; set; }

        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this
        /// instance regarding order. If not specified when creating the setting will be added to the end of the list. If not
        /// specified during update the order will remain untouched
        /// </summary>
        [Input("insertAfter")]
        public Input<string>? InsertAfter { get; set; }

        /// <summary>
        /// Monitored technology name
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        public DeclarativeGroupingArgs()
        {
        }
        public static new DeclarativeGroupingArgs Empty => new DeclarativeGroupingArgs();
    }

    public sealed class DeclarativeGroupingState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Enter a descriptive process group display name and a unique identifier that Dynatrace can use to recognize this process
        /// group.
        /// </summary>
        [Input("detection")]
        public Input<Inputs.DeclarativeGroupingDetectionGetArgs>? Detection { get; set; }

        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this
        /// instance regarding order. If not specified when creating the setting will be added to the end of the list. If not
        /// specified during update the order will remain untouched
        /// </summary>
        [Input("insertAfter")]
        public Input<string>? InsertAfter { get; set; }

        /// <summary>
        /// Monitored technology name
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        public DeclarativeGroupingState()
        {
        }
        public static new DeclarativeGroupingState Empty => new DeclarativeGroupingState();
    }
}
