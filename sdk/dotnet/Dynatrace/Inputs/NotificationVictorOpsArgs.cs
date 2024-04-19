// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Lbrlabs.PulumiPackage.Dynatrace.Inputs
{

    public sealed class NotificationVictorOpsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The configuration is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("active", required: true)]
        public Input<bool> Active { get; set; } = null!;

        /// <summary>
        /// The ID of the associated alerting profile
        /// </summary>
        [Input("alertingProfile", required: true)]
        public Input<string> AlertingProfile { get; set; } = null!;

        /// <summary>
        /// The API key for the target VictorOps account
        /// </summary>
        [Input("apiKey")]
        public Input<string>? ApiKey { get; set; }

        /// <summary>
        /// The content of the message.  You can use the following placeholders:  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{ProblemDetailsText}`: All problem event details, including root cause, as a text-formatted string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`
        /// </summary>
        [Input("message", required: true)]
        public Input<string> Message { get; set; } = null!;

        /// <summary>
        /// The name of the notification configuration
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The routing key, defining the group to be notified
        /// </summary>
        [Input("routingKey", required: true)]
        public Input<string> RoutingKey { get; set; } = null!;

        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        public NotificationVictorOpsArgs()
        {
        }
        public static new NotificationVictorOpsArgs Empty => new NotificationVictorOpsArgs();
    }
}