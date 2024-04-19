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
    [DynatraceResourceType("dynatrace:index/customService:CustomService")]
    public partial class CustomService : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Rule enabled/disabled
        /// </summary>
        [Output("enabled")]
        public Output<bool> Enabled { get; private set; } = null!;

        /// <summary>
        /// The full name of the class / the name to match the class name with
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The list of process groups the custom service should belong to
        /// </summary>
        [Output("processGroups")]
        public Output<ImmutableArray<string>> ProcessGroups { get; private set; } = null!;

        /// <summary>
        /// The queue entry point flag. Set to `true` for custom messaging services
        /// </summary>
        [Output("queueEntryPoint")]
        public Output<bool?> QueueEntryPoint { get; private set; } = null!;

        /// <summary>
        /// The queue entry point type (IBM*MQ, JMS, KAFKA, MSMQ or RABBIT*MQ)
        /// </summary>
        [Output("queueEntryPointType")]
        public Output<string?> QueueEntryPointType { get; private set; } = null!;

        /// <summary>
        /// The list of rules defining the custom service
        /// </summary>
        [Output("rules")]
        public Output<ImmutableArray<Outputs.CustomServiceRule>> Rules { get; private set; } = null!;

        /// <summary>
        /// Matcher applying to the file name (ENDS*WITH, EQUALS or STARTS*WITH). Default value is ENDS_WITH (if applicable)
        /// </summary>
        [Output("technology")]
        public Output<string> Technology { get; private set; } = null!;

        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        [Output("unknowns")]
        public Output<string?> Unknowns { get; private set; } = null!;


        /// <summary>
        /// Create a CustomService resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CustomService(string name, CustomServiceArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/customService:CustomService", name, args ?? new CustomServiceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private CustomService(string name, Input<string> id, CustomServiceState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/customService:CustomService", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing CustomService resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CustomService Get(string name, Input<string> id, CustomServiceState? state = null, CustomResourceOptions? options = null)
        {
            return new CustomService(name, id, state, options);
        }
    }

    public sealed class CustomServiceArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Rule enabled/disabled
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// The full name of the class / the name to match the class name with
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("processGroups")]
        private InputList<string>? _processGroups;

        /// <summary>
        /// The list of process groups the custom service should belong to
        /// </summary>
        public InputList<string> ProcessGroups
        {
            get => _processGroups ?? (_processGroups = new InputList<string>());
            set => _processGroups = value;
        }

        /// <summary>
        /// The queue entry point flag. Set to `true` for custom messaging services
        /// </summary>
        [Input("queueEntryPoint")]
        public Input<bool>? QueueEntryPoint { get; set; }

        /// <summary>
        /// The queue entry point type (IBM*MQ, JMS, KAFKA, MSMQ or RABBIT*MQ)
        /// </summary>
        [Input("queueEntryPointType")]
        public Input<string>? QueueEntryPointType { get; set; }

        [Input("rules")]
        private InputList<Inputs.CustomServiceRuleArgs>? _rules;

        /// <summary>
        /// The list of rules defining the custom service
        /// </summary>
        public InputList<Inputs.CustomServiceRuleArgs> Rules
        {
            get => _rules ?? (_rules = new InputList<Inputs.CustomServiceRuleArgs>());
            set => _rules = value;
        }

        /// <summary>
        /// Matcher applying to the file name (ENDS*WITH, EQUALS or STARTS*WITH). Default value is ENDS_WITH (if applicable)
        /// </summary>
        [Input("technology", required: true)]
        public Input<string> Technology { get; set; } = null!;

        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        public CustomServiceArgs()
        {
        }
        public static new CustomServiceArgs Empty => new CustomServiceArgs();
    }

    public sealed class CustomServiceState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Rule enabled/disabled
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The full name of the class / the name to match the class name with
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("processGroups")]
        private InputList<string>? _processGroups;

        /// <summary>
        /// The list of process groups the custom service should belong to
        /// </summary>
        public InputList<string> ProcessGroups
        {
            get => _processGroups ?? (_processGroups = new InputList<string>());
            set => _processGroups = value;
        }

        /// <summary>
        /// The queue entry point flag. Set to `true` for custom messaging services
        /// </summary>
        [Input("queueEntryPoint")]
        public Input<bool>? QueueEntryPoint { get; set; }

        /// <summary>
        /// The queue entry point type (IBM*MQ, JMS, KAFKA, MSMQ or RABBIT*MQ)
        /// </summary>
        [Input("queueEntryPointType")]
        public Input<string>? QueueEntryPointType { get; set; }

        [Input("rules")]
        private InputList<Inputs.CustomServiceRuleGetArgs>? _rules;

        /// <summary>
        /// The list of rules defining the custom service
        /// </summary>
        public InputList<Inputs.CustomServiceRuleGetArgs> Rules
        {
            get => _rules ?? (_rules = new InputList<Inputs.CustomServiceRuleGetArgs>());
            set => _rules = value;
        }

        /// <summary>
        /// Matcher applying to the file name (ENDS*WITH, EQUALS or STARTS*WITH). Default value is ENDS_WITH (if applicable)
        /// </summary>
        [Input("technology")]
        public Input<string>? Technology { get; set; }

        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        public CustomServiceState()
        {
        }
        public static new CustomServiceState Empty => new CustomServiceState();
    }
}
