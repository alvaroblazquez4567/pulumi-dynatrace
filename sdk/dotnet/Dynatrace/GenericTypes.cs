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
    [DynatraceResourceType("dynatrace:index/genericTypes:GenericTypes")]
    public partial class GenericTypes : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The user or extension that created this type.
        /// </summary>
        [Output("createdBy")]
        public Output<string> CreatedBy { get; private set; } = null!;

        /// <summary>
        /// The human readable attribute name for this extraction rule. Leave blank to use the key as the display name.
        /// </summary>
        [Output("displayName")]
        public Output<string> DisplayName { get; private set; } = null!;

        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Output("enabled")]
        public Output<bool> Enabled { get; private set; } = null!;

        /// <summary>
        /// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        /// </summary>
        [Output("insertAfter")]
        public Output<string> InsertAfter { get; private set; } = null!;

        /// <summary>
        /// The entity type name. This type name must be unique and must not be changed after creation.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Specify a list of rules which are evaluated in order. When **any** rule matches, the entity defined according to that rule will be extracted. Subsequent rules will not be evaluated.
        /// </summary>
        [Output("rules")]
        public Output<Outputs.GenericTypesRules> Rules { get; private set; } = null!;


        /// <summary>
        /// Create a GenericTypes resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public GenericTypes(string name, GenericTypesArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/genericTypes:GenericTypes", name, args ?? new GenericTypesArgs(), MakeResourceOptions(options, ""))
        {
        }

        private GenericTypes(string name, Input<string> id, GenericTypesState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/genericTypes:GenericTypes", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing GenericTypes resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static GenericTypes Get(string name, Input<string> id, GenericTypesState? state = null, CustomResourceOptions? options = null)
        {
            return new GenericTypes(name, id, state, options);
        }
    }

    public sealed class GenericTypesArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The user or extension that created this type.
        /// </summary>
        [Input("createdBy", required: true)]
        public Input<string> CreatedBy { get; set; } = null!;

        /// <summary>
        /// The human readable attribute name for this extraction rule. Leave blank to use the key as the display name.
        /// </summary>
        [Input("displayName", required: true)]
        public Input<string> DisplayName { get; set; } = null!;

        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        /// </summary>
        [Input("insertAfter")]
        public Input<string>? InsertAfter { get; set; }

        /// <summary>
        /// The entity type name. This type name must be unique and must not be changed after creation.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Specify a list of rules which are evaluated in order. When **any** rule matches, the entity defined according to that rule will be extracted. Subsequent rules will not be evaluated.
        /// </summary>
        [Input("rules", required: true)]
        public Input<Inputs.GenericTypesRulesArgs> Rules { get; set; } = null!;

        public GenericTypesArgs()
        {
        }
        public static new GenericTypesArgs Empty => new GenericTypesArgs();
    }

    public sealed class GenericTypesState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The user or extension that created this type.
        /// </summary>
        [Input("createdBy")]
        public Input<string>? CreatedBy { get; set; }

        /// <summary>
        /// The human readable attribute name for this extraction rule. Leave blank to use the key as the display name.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        /// </summary>
        [Input("insertAfter")]
        public Input<string>? InsertAfter { get; set; }

        /// <summary>
        /// The entity type name. This type name must be unique and must not be changed after creation.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Specify a list of rules which are evaluated in order. When **any** rule matches, the entity defined according to that rule will be extracted. Subsequent rules will not be evaluated.
        /// </summary>
        [Input("rules")]
        public Input<Inputs.GenericTypesRulesGetArgs>? Rules { get; set; }

        public GenericTypesState()
        {
        }
        public static new GenericTypesState Empty => new GenericTypesState();
    }
}
