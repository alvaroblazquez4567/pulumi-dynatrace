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
    [DynatraceResourceType("dynatrace:index/pagerDutyNotification:PagerDutyNotification")]
    public partial class PagerDutyNotification : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The name of the PagerDuty account
        /// </summary>
        [Output("account")]
        public Output<string> Account { get; private set; } = null!;

        /// <summary>
        /// The configuration is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Output("active")]
        public Output<bool> Active { get; private set; } = null!;

        /// <summary>
        /// The API key to access PagerDuty
        /// </summary>
        [Output("apiKey")]
        public Output<string?> ApiKey { get; private set; } = null!;

        /// <summary>
        /// The ID of these settings when referred to from resources requiring the REST API V1 keys
        /// </summary>
        [Output("legacyId")]
        public Output<string> LegacyId { get; private set; } = null!;

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
        /// The name of the PagerDuty Service
        /// </summary>
        [Output("service")]
        public Output<string> Service { get; private set; } = null!;


        /// <summary>
        /// Create a PagerDutyNotification resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public PagerDutyNotification(string name, PagerDutyNotificationArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/pagerDutyNotification:PagerDutyNotification", name, args ?? new PagerDutyNotificationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private PagerDutyNotification(string name, Input<string> id, PagerDutyNotificationState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/pagerDutyNotification:PagerDutyNotification", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing PagerDutyNotification resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static PagerDutyNotification Get(string name, Input<string> id, PagerDutyNotificationState? state = null, CustomResourceOptions? options = null)
        {
            return new PagerDutyNotification(name, id, state, options);
        }
    }

    public sealed class PagerDutyNotificationArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the PagerDuty account
        /// </summary>
        [Input("account", required: true)]
        public Input<string> Account { get; set; } = null!;

        /// <summary>
        /// The configuration is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("active", required: true)]
        public Input<bool> Active { get; set; } = null!;

        [Input("apiKey")]
        private Input<string>? _apiKey;

        /// <summary>
        /// The API key to access PagerDuty
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
        /// The ID of these settings when referred to from resources requiring the REST API V1 keys
        /// </summary>
        [Input("legacyId")]
        public Input<string>? LegacyId { get; set; }

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

        /// <summary>
        /// The name of the PagerDuty Service
        /// </summary>
        [Input("service", required: true)]
        public Input<string> Service { get; set; } = null!;

        public PagerDutyNotificationArgs()
        {
        }
        public static new PagerDutyNotificationArgs Empty => new PagerDutyNotificationArgs();
    }

    public sealed class PagerDutyNotificationState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the PagerDuty account
        /// </summary>
        [Input("account")]
        public Input<string>? Account { get; set; }

        /// <summary>
        /// The configuration is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("active")]
        public Input<bool>? Active { get; set; }

        [Input("apiKey")]
        private Input<string>? _apiKey;

        /// <summary>
        /// The API key to access PagerDuty
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
        /// The ID of these settings when referred to from resources requiring the REST API V1 keys
        /// </summary>
        [Input("legacyId")]
        public Input<string>? LegacyId { get; set; }

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

        /// <summary>
        /// The name of the PagerDuty Service
        /// </summary>
        [Input("service")]
        public Input<string>? Service { get; set; }

        public PagerDutyNotificationState()
        {
        }
        public static new PagerDutyNotificationState Empty => new PagerDutyNotificationState();
    }
}
