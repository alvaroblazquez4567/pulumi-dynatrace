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
    [DynatraceResourceType("dynatrace:index/osServices:OsServices")]
    public partial class OsServices : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The number of **10-second measurement cycles** before alerting is triggered
        /// </summary>
        [Output("alertActivationDuration")]
        public Output<int?> AlertActivationDuration { get; private set; } = null!;

        /// <summary>
        /// Toggle the switch in order to enable or disable alerting for this policy
        /// </summary>
        [Output("alerting")]
        public Output<bool> Alerting { get; private set; } = null!;

        /// <summary>
        /// Detection rules
        /// </summary>
        [Output("detectionConditionsLinux")]
        public Output<Outputs.OsServicesDetectionConditionsLinux?> DetectionConditionsLinux { get; private set; } = null!;

        /// <summary>
        /// Detection rules
        /// </summary>
        [Output("detectionConditionsWindows")]
        public Output<Outputs.OsServicesDetectionConditionsWindows?> DetectionConditionsWindows { get; private set; } = null!;

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
        /// Set of additional key-value properties to be attached to the triggered event.
        /// </summary>
        [Output("metadata")]
        public Output<Outputs.OsServicesMetadata?> Metadata { get; private set; } = null!;

        /// <summary>
        /// Toggle the switch in order to enable or disable availability metric monitoring for this policy. Availability metrics produce custom metrics. Refer to [documentation](https://dt-url.net/vl03xzk) for consumption examples. Each monitored service consumes one custom metric.
        /// </summary>
        [Output("monitoring")]
        public Output<bool> Monitoring { get; private set; } = null!;

        /// <summary>
        /// Rule name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// By default, Dynatrace does not alert if the service is not installed. Toggle the switch to enable or disable this feature
        /// </summary>
        [Output("notInstalledAlerting")]
        public Output<bool?> NotInstalledAlerting { get; private set; } = null!;

        /// <summary>
        /// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Output("scope")]
        public Output<string?> Scope { get; private set; } = null!;

        /// <summary>
        /// This string has to match a required format. See [OS services monitoring](https://dt-url.net/vl03xzk).
        /// </summary>
        [Output("statusConditionLinux")]
        public Output<string?> StatusConditionLinux { get; private set; } = null!;

        /// <summary>
        /// This string has to match a required format. See [OS services monitoring](https://dt-url.net/vl03xzk). - `$eq(paused)`
        /// – Matches services that are in paused state. Available logic operations: - `$not($eq(paused))` – Matches services
        /// that are in state different from paused. - `$or($eq(paused),$eq(running))` – Matches services that are either in
        /// paused or running state. Use one of the following values as a parameter for this condition: - `running` - `stopped` -
        /// `start_pending` - `stop_pending` - `continue_pending` - `pause_pending` - `paused`
        /// </summary>
        [Output("statusConditionWindows")]
        public Output<string?> StatusConditionWindows { get; private set; } = null!;

        /// <summary>
        /// Possible Values: `LINUX`, `WINDOWS`
        /// </summary>
        [Output("system")]
        public Output<string> System { get; private set; } = null!;


        /// <summary>
        /// Create a OsServices resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public OsServices(string name, OsServicesArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/osServices:OsServices", name, args ?? new OsServicesArgs(), MakeResourceOptions(options, ""))
        {
        }

        private OsServices(string name, Input<string> id, OsServicesState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/osServices:OsServices", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing OsServices resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static OsServices Get(string name, Input<string> id, OsServicesState? state = null, CustomResourceOptions? options = null)
        {
            return new OsServices(name, id, state, options);
        }
    }

    public sealed class OsServicesArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The number of **10-second measurement cycles** before alerting is triggered
        /// </summary>
        [Input("alertActivationDuration")]
        public Input<int>? AlertActivationDuration { get; set; }

        /// <summary>
        /// Toggle the switch in order to enable or disable alerting for this policy
        /// </summary>
        [Input("alerting", required: true)]
        public Input<bool> Alerting { get; set; } = null!;

        /// <summary>
        /// Detection rules
        /// </summary>
        [Input("detectionConditionsLinux")]
        public Input<Inputs.OsServicesDetectionConditionsLinuxArgs>? DetectionConditionsLinux { get; set; }

        /// <summary>
        /// Detection rules
        /// </summary>
        [Input("detectionConditionsWindows")]
        public Input<Inputs.OsServicesDetectionConditionsWindowsArgs>? DetectionConditionsWindows { get; set; }

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
        /// Set of additional key-value properties to be attached to the triggered event.
        /// </summary>
        [Input("metadata")]
        public Input<Inputs.OsServicesMetadataArgs>? Metadata { get; set; }

        /// <summary>
        /// Toggle the switch in order to enable or disable availability metric monitoring for this policy. Availability metrics produce custom metrics. Refer to [documentation](https://dt-url.net/vl03xzk) for consumption examples. Each monitored service consumes one custom metric.
        /// </summary>
        [Input("monitoring", required: true)]
        public Input<bool> Monitoring { get; set; } = null!;

        /// <summary>
        /// Rule name
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// By default, Dynatrace does not alert if the service is not installed. Toggle the switch to enable or disable this feature
        /// </summary>
        [Input("notInstalledAlerting")]
        public Input<bool>? NotInstalledAlerting { get; set; }

        /// <summary>
        /// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        /// <summary>
        /// This string has to match a required format. See [OS services monitoring](https://dt-url.net/vl03xzk).
        /// </summary>
        [Input("statusConditionLinux")]
        public Input<string>? StatusConditionLinux { get; set; }

        /// <summary>
        /// This string has to match a required format. See [OS services monitoring](https://dt-url.net/vl03xzk). - `$eq(paused)`
        /// – Matches services that are in paused state. Available logic operations: - `$not($eq(paused))` – Matches services
        /// that are in state different from paused. - `$or($eq(paused),$eq(running))` – Matches services that are either in
        /// paused or running state. Use one of the following values as a parameter for this condition: - `running` - `stopped` -
        /// `start_pending` - `stop_pending` - `continue_pending` - `pause_pending` - `paused`
        /// </summary>
        [Input("statusConditionWindows")]
        public Input<string>? StatusConditionWindows { get; set; }

        /// <summary>
        /// Possible Values: `LINUX`, `WINDOWS`
        /// </summary>
        [Input("system", required: true)]
        public Input<string> System { get; set; } = null!;

        public OsServicesArgs()
        {
        }
        public static new OsServicesArgs Empty => new OsServicesArgs();
    }

    public sealed class OsServicesState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The number of **10-second measurement cycles** before alerting is triggered
        /// </summary>
        [Input("alertActivationDuration")]
        public Input<int>? AlertActivationDuration { get; set; }

        /// <summary>
        /// Toggle the switch in order to enable or disable alerting for this policy
        /// </summary>
        [Input("alerting")]
        public Input<bool>? Alerting { get; set; }

        /// <summary>
        /// Detection rules
        /// </summary>
        [Input("detectionConditionsLinux")]
        public Input<Inputs.OsServicesDetectionConditionsLinuxGetArgs>? DetectionConditionsLinux { get; set; }

        /// <summary>
        /// Detection rules
        /// </summary>
        [Input("detectionConditionsWindows")]
        public Input<Inputs.OsServicesDetectionConditionsWindowsGetArgs>? DetectionConditionsWindows { get; set; }

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
        /// Set of additional key-value properties to be attached to the triggered event.
        /// </summary>
        [Input("metadata")]
        public Input<Inputs.OsServicesMetadataGetArgs>? Metadata { get; set; }

        /// <summary>
        /// Toggle the switch in order to enable or disable availability metric monitoring for this policy. Availability metrics produce custom metrics. Refer to [documentation](https://dt-url.net/vl03xzk) for consumption examples. Each monitored service consumes one custom metric.
        /// </summary>
        [Input("monitoring")]
        public Input<bool>? Monitoring { get; set; }

        /// <summary>
        /// Rule name
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// By default, Dynatrace does not alert if the service is not installed. Toggle the switch to enable or disable this feature
        /// </summary>
        [Input("notInstalledAlerting")]
        public Input<bool>? NotInstalledAlerting { get; set; }

        /// <summary>
        /// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        /// <summary>
        /// This string has to match a required format. See [OS services monitoring](https://dt-url.net/vl03xzk).
        /// </summary>
        [Input("statusConditionLinux")]
        public Input<string>? StatusConditionLinux { get; set; }

        /// <summary>
        /// This string has to match a required format. See [OS services monitoring](https://dt-url.net/vl03xzk). - `$eq(paused)`
        /// – Matches services that are in paused state. Available logic operations: - `$not($eq(paused))` – Matches services
        /// that are in state different from paused. - `$or($eq(paused),$eq(running))` – Matches services that are either in
        /// paused or running state. Use one of the following values as a parameter for this condition: - `running` - `stopped` -
        /// `start_pending` - `stop_pending` - `continue_pending` - `pause_pending` - `paused`
        /// </summary>
        [Input("statusConditionWindows")]
        public Input<string>? StatusConditionWindows { get; set; }

        /// <summary>
        /// Possible Values: `LINUX`, `WINDOWS`
        /// </summary>
        [Input("system")]
        public Input<string>? System { get; set; }

        public OsServicesState()
        {
        }
        public static new OsServicesState Empty => new OsServicesState();
    }
}
