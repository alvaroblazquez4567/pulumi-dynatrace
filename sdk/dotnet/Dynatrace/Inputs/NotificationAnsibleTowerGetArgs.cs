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

    public sealed class NotificationAnsibleTowerGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Accept any, including self-signed and invalid, SSL certificate (`true`) or only trusted (`false`) certificates
        /// </summary>
        [Input("acceptAnyCertificate", required: true)]
        public Input<bool> AcceptAnyCertificate { get; set; } = null!;

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
        /// The custom message of the notification.   This message will be displayed in the extra variables **Message** field of your job template.  You can use the following placeholders:  * `{ImpactedEntities}`: Details about the entities impacted by the problem in form of a JSON array.  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{PID}`: The ID of the reported problem.  * `{ProblemDetailsText}`: All problem event details, including root cause, as a text-formatted string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`.  * `{Tags}`: The list of tags that are defined for all impacted entities, separated by commas
        /// </summary>
        [Input("customMessage", required: true)]
        public Input<string> CustomMessage { get; set; } = null!;

        /// <summary>
        /// The ID of the target Ansible Tower job template
        /// </summary>
        [Input("jobTemplateId", required: true)]
        public Input<int> JobTemplateId { get; set; } = null!;

        /// <summary>
        /// The URL of the target Ansible Tower job template
        /// </summary>
        [Input("jobTemplateUrl", required: true)]
        public Input<string> JobTemplateUrl { get; set; } = null!;

        /// <summary>
        /// The name of the notification configuration
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The password for the Ansible Tower account
        /// </summary>
        [Input("password")]
        public Input<string>? Password { get; set; }

        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        /// <summary>
        /// The username of the Ansible Tower account
        /// </summary>
        [Input("username", required: true)]
        public Input<string> Username { get; set; } = null!;

        public NotificationAnsibleTowerGetArgs()
        {
        }
        public static new NotificationAnsibleTowerGetArgs Empty => new NotificationAnsibleTowerGetArgs();
    }
}