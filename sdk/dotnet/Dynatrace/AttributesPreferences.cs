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
    [DynatraceResourceType("dynatrace:index/attributesPreferences:AttributesPreferences")]
    public partial class AttributesPreferences : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Possible Values: `ALLOW_ALL_ATTRIBUTES`, `BLOCK_ALL_ATTRIBUTES`
        /// </summary>
        [Output("persistenceMode")]
        public Output<string> PersistenceMode { get; private set; } = null!;


        /// <summary>
        /// Create a AttributesPreferences resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AttributesPreferences(string name, AttributesPreferencesArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/attributesPreferences:AttributesPreferences", name, args ?? new AttributesPreferencesArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AttributesPreferences(string name, Input<string> id, AttributesPreferencesState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/attributesPreferences:AttributesPreferences", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing AttributesPreferences resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AttributesPreferences Get(string name, Input<string> id, AttributesPreferencesState? state = null, CustomResourceOptions? options = null)
        {
            return new AttributesPreferences(name, id, state, options);
        }
    }

    public sealed class AttributesPreferencesArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Possible Values: `ALLOW_ALL_ATTRIBUTES`, `BLOCK_ALL_ATTRIBUTES`
        /// </summary>
        [Input("persistenceMode", required: true)]
        public Input<string> PersistenceMode { get; set; } = null!;

        public AttributesPreferencesArgs()
        {
        }
        public static new AttributesPreferencesArgs Empty => new AttributesPreferencesArgs();
    }

    public sealed class AttributesPreferencesState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Possible Values: `ALLOW_ALL_ATTRIBUTES`, `BLOCK_ALL_ATTRIBUTES`
        /// </summary>
        [Input("persistenceMode")]
        public Input<string>? PersistenceMode { get; set; }

        public AttributesPreferencesState()
        {
        }
        public static new AttributesPreferencesState Empty => new AttributesPreferencesState();
    }
}
