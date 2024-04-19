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
    [DynatraceResourceType("dynatrace:index/opsGenieNotification:OpsGenieNotification")]
    public partial class OpsGenieNotification : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The configuration is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Output("active")]
        public Output<bool> Active { get; private set; } = null!;

        /// <summary>
        /// The API key to access OpsGenie
        /// </summary>
        [Output("apiKey")]
        public Output<string?> ApiKey { get; private set; } = null!;

        /// <summary>
        /// The region domain of the OpsGenie
        /// </summary>
        [Output("domain")]
        public Output<string> Domain { get; private set; } = null!;

        /// <summary>
        /// The ID of these settings when referred to from resources requiring the REST API V1 keys
        /// </summary>
        [Output("legacyId")]
        public Output<string> LegacyId { get; private set; } = null!;

        /// <summary>
        /// The content of the message.  You can use the following placeholders:  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem
        /// </summary>
        [Output("message")]
        public Output<string> Message { get; private set; } = null!;

        /// <summary>
        /// The name of the notification configuration
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The ID of the associated alerting profile
        /// </summary>
        [Output("profile")]
        public Output<string> Profile { get; private set; } = null!;


        /// <summary>
        /// Create a OpsGenieNotification resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public OpsGenieNotification(string name, OpsGenieNotificationArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/opsGenieNotification:OpsGenieNotification", name, args ?? new OpsGenieNotificationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private OpsGenieNotification(string name, Input<string> id, OpsGenieNotificationState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/opsGenieNotification:OpsGenieNotification", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/alvaroblazquez4567",
                AdditionalSecretOutputs =
                {
                    "apiKey",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing OpsGenieNotification resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static OpsGenieNotification Get(string name, Input<string> id, OpsGenieNotificationState? state = null, CustomResourceOptions? options = null)
        {
            return new OpsGenieNotification(name, id, state, options);
        }
    }

    public sealed class OpsGenieNotificationArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The configuration is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("active", required: true)]
        public Input<bool> Active { get; set; } = null!;

        [Input("apiKey")]
        private Input<string>? _apiKey;

        /// <summary>
        /// The API key to access OpsGenie
        /// </summary>
        public Input<string>? ApiKey
        {
            get => _apiKey;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _apiKey = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// The region domain of the OpsGenie
        /// </summary>
        [Input("domain", required: true)]
        public Input<string> Domain { get; set; } = null!;

        /// <summary>
        /// The ID of these settings when referred to from resources requiring the REST API V1 keys
        /// </summary>
        [Input("legacyId")]
        public Input<string>? LegacyId { get; set; }

        /// <summary>
        /// The content of the message.  You can use the following placeholders:  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem
        /// </summary>
        [Input("message", required: true)]
        public Input<string> Message { get; set; } = null!;

        /// <summary>
        /// The name of the notification configuration
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The ID of the associated alerting profile
        /// </summary>
        [Input("profile", required: true)]
        public Input<string> Profile { get; set; } = null!;

        public OpsGenieNotificationArgs()
        {
        }
        public static new OpsGenieNotificationArgs Empty => new OpsGenieNotificationArgs();
    }

    public sealed class OpsGenieNotificationState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The configuration is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("active")]
        public Input<bool>? Active { get; set; }

        [Input("apiKey")]
        private Input<string>? _apiKey;

        /// <summary>
        /// The API key to access OpsGenie
        /// </summary>
        public Input<string>? ApiKey
        {
            get => _apiKey;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _apiKey = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// The region domain of the OpsGenie
        /// </summary>
        [Input("domain")]
        public Input<string>? Domain { get; set; }

        /// <summary>
        /// The ID of these settings when referred to from resources requiring the REST API V1 keys
        /// </summary>
        [Input("legacyId")]
        public Input<string>? LegacyId { get; set; }

        /// <summary>
        /// The content of the message.  You can use the following placeholders:  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem
        /// </summary>
        [Input("message")]
        public Input<string>? Message { get; set; }

        /// <summary>
        /// The name of the notification configuration
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The ID of the associated alerting profile
        /// </summary>
        [Input("profile")]
        public Input<string>? Profile { get; set; }

        public OpsGenieNotificationState()
        {
        }
        public static new OpsGenieNotificationState Empty => new OpsGenieNotificationState();
    }
}
