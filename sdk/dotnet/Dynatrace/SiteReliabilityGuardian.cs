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
    [DynatraceResourceType("dynatrace:index/siteReliabilityGuardian:SiteReliabilityGuardian")]
    public partial class SiteReliabilityGuardian : global::Pulumi.CustomResource
    {
        /// <summary>
        /// no documentation available
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Objective name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Objectives
        /// </summary>
        [Output("objectives")]
        public Output<Outputs.SiteReliabilityGuardianObjectives> Objectives { get; private set; } = null!;

        /// <summary>
        /// Define key/value pairs that further describe this guardian.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<string>> Tags { get; private set; } = null!;

        /// <summary>
        /// Define variables for dynamically defining DQL queries
        /// </summary>
        [Output("variables")]
        public Output<Outputs.SiteReliabilityGuardianVariables?> Variables { get; private set; } = null!;


        /// <summary>
        /// Create a SiteReliabilityGuardian resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SiteReliabilityGuardian(string name, SiteReliabilityGuardianArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/siteReliabilityGuardian:SiteReliabilityGuardian", name, args ?? new SiteReliabilityGuardianArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SiteReliabilityGuardian(string name, Input<string> id, SiteReliabilityGuardianState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/siteReliabilityGuardian:SiteReliabilityGuardian", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing SiteReliabilityGuardian resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SiteReliabilityGuardian Get(string name, Input<string> id, SiteReliabilityGuardianState? state = null, CustomResourceOptions? options = null)
        {
            return new SiteReliabilityGuardian(name, id, state, options);
        }
    }

    public sealed class SiteReliabilityGuardianArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Objective name
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Objectives
        /// </summary>
        [Input("objectives", required: true)]
        public Input<Inputs.SiteReliabilityGuardianObjectivesArgs> Objectives { get; set; } = null!;

        [Input("tags")]
        private InputList<string>? _tags;

        /// <summary>
        /// Define key/value pairs that further describe this guardian.
        /// </summary>
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        /// <summary>
        /// Define variables for dynamically defining DQL queries
        /// </summary>
        [Input("variables")]
        public Input<Inputs.SiteReliabilityGuardianVariablesArgs>? Variables { get; set; }

        public SiteReliabilityGuardianArgs()
        {
        }
        public static new SiteReliabilityGuardianArgs Empty => new SiteReliabilityGuardianArgs();
    }

    public sealed class SiteReliabilityGuardianState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Objective name
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Objectives
        /// </summary>
        [Input("objectives")]
        public Input<Inputs.SiteReliabilityGuardianObjectivesGetArgs>? Objectives { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;

        /// <summary>
        /// Define key/value pairs that further describe this guardian.
        /// </summary>
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        /// <summary>
        /// Define variables for dynamically defining DQL queries
        /// </summary>
        [Input("variables")]
        public Input<Inputs.SiteReliabilityGuardianVariablesGetArgs>? Variables { get; set; }

        public SiteReliabilityGuardianState()
        {
        }
        public static new SiteReliabilityGuardianState Empty => new SiteReliabilityGuardianState();
    }
}
