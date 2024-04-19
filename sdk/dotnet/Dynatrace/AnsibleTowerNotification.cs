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
    [DynatraceResourceType("dynatrace:index/ansibleTowerNotification:AnsibleTowerNotification")]
    public partial class AnsibleTowerNotification : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The notification is active (`true`) or inactive (`false`). Default is `false`.
        /// </summary>
        [Output("active")]
        public Output<bool?> Active { get; private set; } = null!;

        /// <summary>
        /// The custom message of the notification. This message will be displayed in the extra variables **Message** field of your job template. You can use the following placeholders:  * `{ImpactedEntities}`: Details about the entities impacted by the problem in form of a JSON array.  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{PID}`: The ID of the reported problem.  * `{ProblemDetailsText}`: All problem event details, including root cause, as a text-formatted string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`.  * `{Tags}`: The list of tags that are defined for all impacted entities, separated by commas
        /// </summary>
        [Output("customMessage")]
        public Output<string> CustomMessage { get; private set; } = null!;

        /// <summary>
        /// Accept any, including self-signed and invalid, SSL certificate (`true`) or only trusted (`false`) certificates. Default is `false`.
        /// </summary>
        [Output("insecure")]
        public Output<bool?> Insecure { get; private set; } = null!;

        /// <summary>
        /// The URL of the target Ansible Tower job template
        /// </summary>
        [Output("jobTemplateUrl")]
        public Output<string> JobTemplateUrl { get; private set; } = null!;

        /// <summary>
        /// The ID of these settings when referred to from resources requiring the REST API V1 keys
        /// </summary>
        [Output("legacyId")]
        public Output<string> LegacyId { get; private set; } = null!;

        /// <summary>
        /// The display name within the Dynatrace WebUI.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The password for the Ansible Tower account
        /// </summary>
        [Output("password")]
        public Output<string?> Password { get; private set; } = null!;

        /// <summary>
        /// The ID of the associated alerting profile.
        /// </summary>
        [Output("profile")]
        public Output<string> Profile { get; private set; } = null!;

        /// <summary>
        /// The username of the Ansible Tower account
        /// </summary>
        [Output("username")]
        public Output<string> Username { get; private set; } = null!;


        /// <summary>
        /// Create a AnsibleTowerNotification resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AnsibleTowerNotification(string name, AnsibleTowerNotificationArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/ansibleTowerNotification:AnsibleTowerNotification", name, args ?? new AnsibleTowerNotificationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AnsibleTowerNotification(string name, Input<string> id, AnsibleTowerNotificationState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/ansibleTowerNotification:AnsibleTowerNotification", name, state, MakeResourceOptions(options, id))
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
                    "password",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing AnsibleTowerNotification resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AnsibleTowerNotification Get(string name, Input<string> id, AnsibleTowerNotificationState? state = null, CustomResourceOptions? options = null)
        {
            return new AnsibleTowerNotification(name, id, state, options);
        }
    }

    public sealed class AnsibleTowerNotificationArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The notification is active (`true`) or inactive (`false`). Default is `false`.
        /// </summary>
        [Input("active")]
        public Input<bool>? Active { get; set; }

        /// <summary>
        /// The custom message of the notification. This message will be displayed in the extra variables **Message** field of your job template. You can use the following placeholders:  * `{ImpactedEntities}`: Details about the entities impacted by the problem in form of a JSON array.  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{PID}`: The ID of the reported problem.  * `{ProblemDetailsText}`: All problem event details, including root cause, as a text-formatted string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`.  * `{Tags}`: The list of tags that are defined for all impacted entities, separated by commas
        /// </summary>
        [Input("customMessage", required: true)]
        public Input<string> CustomMessage { get; set; } = null!;

        /// <summary>
        /// Accept any, including self-signed and invalid, SSL certificate (`true`) or only trusted (`false`) certificates. Default is `false`.
        /// </summary>
        [Input("insecure")]
        public Input<bool>? Insecure { get; set; }

        /// <summary>
        /// The URL of the target Ansible Tower job template
        /// </summary>
        [Input("jobTemplateUrl", required: true)]
        public Input<string> JobTemplateUrl { get; set; } = null!;

        /// <summary>
        /// The ID of these settings when referred to from resources requiring the REST API V1 keys
        /// </summary>
        [Input("legacyId")]
        public Input<string>? LegacyId { get; set; }

        /// <summary>
        /// The display name within the Dynatrace WebUI.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("password")]
        private Input<string>? _password;

        /// <summary>
        /// The password for the Ansible Tower account
        /// </summary>
        public Input<string>? Password
        {
            get => _password;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _password = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// The ID of the associated alerting profile.
        /// </summary>
        [Input("profile", required: true)]
        public Input<string> Profile { get; set; } = null!;

        /// <summary>
        /// The username of the Ansible Tower account
        /// </summary>
        [Input("username", required: true)]
        public Input<string> Username { get; set; } = null!;

        public AnsibleTowerNotificationArgs()
        {
        }
        public static new AnsibleTowerNotificationArgs Empty => new AnsibleTowerNotificationArgs();
    }

    public sealed class AnsibleTowerNotificationState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The notification is active (`true`) or inactive (`false`). Default is `false`.
        /// </summary>
        [Input("active")]
        public Input<bool>? Active { get; set; }

        /// <summary>
        /// The custom message of the notification. This message will be displayed in the extra variables **Message** field of your job template. You can use the following placeholders:  * `{ImpactedEntities}`: Details about the entities impacted by the problem in form of a JSON array.  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{PID}`: The ID of the reported problem.  * `{ProblemDetailsText}`: All problem event details, including root cause, as a text-formatted string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`.  * `{Tags}`: The list of tags that are defined for all impacted entities, separated by commas
        /// </summary>
        [Input("customMessage")]
        public Input<string>? CustomMessage { get; set; }

        /// <summary>
        /// Accept any, including self-signed and invalid, SSL certificate (`true`) or only trusted (`false`) certificates. Default is `false`.
        /// </summary>
        [Input("insecure")]
        public Input<bool>? Insecure { get; set; }

        /// <summary>
        /// The URL of the target Ansible Tower job template
        /// </summary>
        [Input("jobTemplateUrl")]
        public Input<string>? JobTemplateUrl { get; set; }

        /// <summary>
        /// The ID of these settings when referred to from resources requiring the REST API V1 keys
        /// </summary>
        [Input("legacyId")]
        public Input<string>? LegacyId { get; set; }

        /// <summary>
        /// The display name within the Dynatrace WebUI.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("password")]
        private Input<string>? _password;

        /// <summary>
        /// The password for the Ansible Tower account
        /// </summary>
        public Input<string>? Password
        {
            get => _password;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _password = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// The ID of the associated alerting profile.
        /// </summary>
        [Input("profile")]
        public Input<string>? Profile { get; set; }

        /// <summary>
        /// The username of the Ansible Tower account
        /// </summary>
        [Input("username")]
        public Input<string>? Username { get; set; }

        public AnsibleTowerNotificationState()
        {
        }
        public static new AnsibleTowerNotificationState Empty => new AnsibleTowerNotificationState();
    }
}
