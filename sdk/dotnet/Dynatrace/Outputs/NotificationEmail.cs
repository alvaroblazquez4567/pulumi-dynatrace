// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Lbrlabs.PulumiPackage.Dynatrace.Outputs
{

    [OutputType]
    public sealed class NotificationEmail
    {
        /// <summary>
        /// The configuration is enabled (`true`) or disabled (`false`)
        /// </summary>
        public readonly bool Active;
        /// <summary>
        /// The ID of the associated alerting profile
        /// </summary>
        public readonly string AlertingProfile;
        /// <summary>
        /// The list of the email BCC-recipients
        /// </summary>
        public readonly ImmutableArray<string> BccReceivers;
        /// <summary>
        /// The template of the email notification.  You can use the following placeholders:  * `{ImpactedEntities}`: Details about the entities impacted by the problem in form of a JSON array.  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{PID}`: The ID of the reported problem.  * `{ProblemDetailsHTML}`: All problem event details, including root cause, as an HTML-formatted string.  * `{ProblemDetailsJSON}`: All problem event details, including root cause, as a JSON object.  * `{ProblemDetailsMarkdown}`: All problem event details, including root cause, as a [Markdown-formatted](https://www.markdownguide.org/cheat-sheet/) string.  * `{ProblemDetailsText}`: All problem event details, including root cause, as a text-formatted string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`.  * `{Tags}`: The list of tags that are defined for all impacted entities, separated by commas
        /// </summary>
        public readonly string Body;
        /// <summary>
        /// The list of the email CC-recipients
        /// </summary>
        public readonly ImmutableArray<string> CcReceivers;
        /// <summary>
        /// The name of the notification configuration
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The list of the email recipients
        /// </summary>
        public readonly ImmutableArray<string> Receivers;
        /// <summary>
        /// The subject of the email notifications
        /// </summary>
        public readonly string Subject;
        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        public readonly string? Unknowns;

        [OutputConstructor]
        private NotificationEmail(
            bool active,

            string alertingProfile,

            ImmutableArray<string> bccReceivers,

            string body,

            ImmutableArray<string> ccReceivers,

            string name,

            ImmutableArray<string> receivers,

            string subject,

            string? unknowns)
        {
            Active = active;
            AlertingProfile = alertingProfile;
            BccReceivers = bccReceivers;
            Body = body;
            CcReceivers = ccReceivers;
            Name = name;
            Receivers = receivers;
            Subject = subject;
            Unknowns = unknowns;
        }
    }
}
