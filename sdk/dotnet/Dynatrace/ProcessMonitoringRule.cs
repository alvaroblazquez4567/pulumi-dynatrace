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
    [DynatraceResourceType("dynatrace:index/processMonitoringRule:ProcessMonitoringRule")]
    public partial class ProcessMonitoringRule : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Condition
        /// </summary>
        [Output("condition")]
        public Output<Outputs.ProcessMonitoringRuleCondition> Condition { get; private set; } = null!;

        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Output("enabled")]
        public Output<bool> Enabled { get; private set; } = null!;

        /// <summary>
        /// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope
        /// </summary>
        [Output("hostGroupId")]
        public Output<string?> HostGroupId { get; private set; } = null!;

        /// <summary>
        /// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        /// </summary>
        [Output("insertAfter")]
        public Output<string> InsertAfter { get; private set; } = null!;

        /// <summary>
        /// Possible Values: `MONITORING_ON`, `MONITORING_OFF`
        /// </summary>
        [Output("mode")]
        public Output<string> Mode { get; private set; } = null!;


        /// <summary>
        /// Create a ProcessMonitoringRule resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ProcessMonitoringRule(string name, ProcessMonitoringRuleArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/processMonitoringRule:ProcessMonitoringRule", name, args ?? new ProcessMonitoringRuleArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ProcessMonitoringRule(string name, Input<string> id, ProcessMonitoringRuleState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/processMonitoringRule:ProcessMonitoringRule", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ProcessMonitoringRule resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ProcessMonitoringRule Get(string name, Input<string> id, ProcessMonitoringRuleState? state = null, CustomResourceOptions? options = null)
        {
            return new ProcessMonitoringRule(name, id, state, options);
        }
    }

    public sealed class ProcessMonitoringRuleArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Condition
        /// </summary>
        [Input("condition", required: true)]
        public Input<Inputs.ProcessMonitoringRuleConditionArgs> Condition { get; set; } = null!;

        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope
        /// </summary>
        [Input("hostGroupId")]
        public Input<string>? HostGroupId { get; set; }

        /// <summary>
        /// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        /// </summary>
        [Input("insertAfter")]
        public Input<string>? InsertAfter { get; set; }

        /// <summary>
        /// Possible Values: `MONITORING_ON`, `MONITORING_OFF`
        /// </summary>
        [Input("mode", required: true)]
        public Input<string> Mode { get; set; } = null!;

        public ProcessMonitoringRuleArgs()
        {
        }
        public static new ProcessMonitoringRuleArgs Empty => new ProcessMonitoringRuleArgs();
    }

    public sealed class ProcessMonitoringRuleState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Condition
        /// </summary>
        [Input("condition")]
        public Input<Inputs.ProcessMonitoringRuleConditionGetArgs>? Condition { get; set; }

        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope
        /// </summary>
        [Input("hostGroupId")]
        public Input<string>? HostGroupId { get; set; }

        /// <summary>
        /// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        /// </summary>
        [Input("insertAfter")]
        public Input<string>? InsertAfter { get; set; }

        /// <summary>
        /// Possible Values: `MONITORING_ON`, `MONITORING_OFF`
        /// </summary>
        [Input("mode")]
        public Input<string>? Mode { get; set; }

        public ProcessMonitoringRuleState()
        {
        }
        public static new ProcessMonitoringRuleState Empty => new ProcessMonitoringRuleState();
    }
}
