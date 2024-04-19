// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class AppsecNotification extends pulumi.CustomResource {
    /**
     * Get an existing AppsecNotification resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AppsecNotificationState, opts?: pulumi.CustomResourceOptions): AppsecNotification {
        return new AppsecNotification(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/appsecNotification:AppsecNotification';

    /**
     * Returns true if the given object is an instance of AppsecNotification.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AppsecNotification {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AppsecNotification.__pulumiType;
    }

    /**
     * For attack candidate alerts, select an [alerting
     * profile](/ui/settings/builtin:appsec.notification-attack-alerting-profile) to control the delivery of security
     * notifications related to this integration.
     */
    public readonly attackCandidateBasedAlertingProfile!: pulumi.Output<string | undefined>;
    /**
     * Attack candidate based email payload, required when `trigger` equals `ATTACK_CANDIDATE` and `type` equals `EMAIL`
     */
    public readonly attackCandidateBasedEmailPayload!: pulumi.Output<outputs.AppsecNotificationAttackCandidateBasedEmailPayload | undefined>;
    /**
     * Attack candidate based Jira payload, required when `trigger` equals `ATTACK_CANDIDATE` and `type` equals `JIRA`
     */
    public readonly attackCandidateBasedJiraPayload!: pulumi.Output<outputs.AppsecNotificationAttackCandidateBasedJiraPayload | undefined>;
    /**
     * Attack candidate based webhook payload, required when `trigger` equals `ATTACK_CANDIDATE` and `type` equals `WEBHOOK`
     */
    public readonly attackCandidateBasedWebhookPayload!: pulumi.Output<outputs.AppsecNotificationAttackCandidateBasedWebhookPayload | undefined>;
    /**
     * Display name of the security notification
     */
    public readonly displayName!: pulumi.Output<string>;
    /**
     * Email configuration, required when `type` equals `EMAIL`
     */
    public readonly emailConfiguration!: pulumi.Output<outputs.AppsecNotificationEmailConfiguration | undefined>;
    /**
     * Enable/Disable the security notification, enabled (`true`) or disabled (`false`)
     */
    public readonly enabled!: pulumi.Output<boolean>;
    /**
     * Jira configuration, required when `type` equals `JIRA`
     */
    public readonly jiraConfiguration!: pulumi.Output<outputs.AppsecNotificationJiraConfiguration | undefined>;
    /**
     * For security problem alerts, select an [alerting profile](/ui/settings/builtin:appsec.notification-alerting-profile) to
     * control the delivery of security notifications related to this integration.
     */
    public readonly securityProblemBasedAlertingProfile!: pulumi.Output<string | undefined>;
    /**
     * Security problem based email payload, required when `trigger` equals `SECURITY_PROBLEM` and `type` equals `EMAIL`
     */
    public readonly securityProblemBasedEmailPayload!: pulumi.Output<outputs.AppsecNotificationSecurityProblemBasedEmailPayload | undefined>;
    /**
     * Security problem based Jira payload, required when `trigger` equals `SECURITY_PROBLEM` and `type` equals `JIRA`
     */
    public readonly securityProblemBasedJiraPayload!: pulumi.Output<outputs.AppsecNotificationSecurityProblemBasedJiraPayload | undefined>;
    /**
     * Security problem based webhook payload, required when `trigger` equals `SECURITY_PROBLEM` and `type` equals `WEBHOOK`
     */
    public readonly securityProblemBasedWebhookPayload!: pulumi.Output<outputs.AppsecNotificationSecurityProblemBasedWebhookPayload | undefined>;
    /**
     * Security alert type, possible Values: `ATTACK_CANDIDATE`, `SECURITY_PROBLEM`
     */
    public readonly trigger!: pulumi.Output<string>;
    /**
     * Notification type, possible Values: `EMAIL`, `JIRA`, `WEBHOOK`
     */
    public readonly type!: pulumi.Output<string>;
    /**
     * Webhook configuration, required when `type` equals `WEBHOOK`
     */
    public readonly webhookConfiguration!: pulumi.Output<outputs.AppsecNotificationWebhookConfiguration | undefined>;

    /**
     * Create a AppsecNotification resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AppsecNotificationArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: AppsecNotificationArgs | AppsecNotificationState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as AppsecNotificationState | undefined;
            resourceInputs["attackCandidateBasedAlertingProfile"] = state ? state.attackCandidateBasedAlertingProfile : undefined;
            resourceInputs["attackCandidateBasedEmailPayload"] = state ? state.attackCandidateBasedEmailPayload : undefined;
            resourceInputs["attackCandidateBasedJiraPayload"] = state ? state.attackCandidateBasedJiraPayload : undefined;
            resourceInputs["attackCandidateBasedWebhookPayload"] = state ? state.attackCandidateBasedWebhookPayload : undefined;
            resourceInputs["displayName"] = state ? state.displayName : undefined;
            resourceInputs["emailConfiguration"] = state ? state.emailConfiguration : undefined;
            resourceInputs["enabled"] = state ? state.enabled : undefined;
            resourceInputs["jiraConfiguration"] = state ? state.jiraConfiguration : undefined;
            resourceInputs["securityProblemBasedAlertingProfile"] = state ? state.securityProblemBasedAlertingProfile : undefined;
            resourceInputs["securityProblemBasedEmailPayload"] = state ? state.securityProblemBasedEmailPayload : undefined;
            resourceInputs["securityProblemBasedJiraPayload"] = state ? state.securityProblemBasedJiraPayload : undefined;
            resourceInputs["securityProblemBasedWebhookPayload"] = state ? state.securityProblemBasedWebhookPayload : undefined;
            resourceInputs["trigger"] = state ? state.trigger : undefined;
            resourceInputs["type"] = state ? state.type : undefined;
            resourceInputs["webhookConfiguration"] = state ? state.webhookConfiguration : undefined;
        } else {
            const args = argsOrState as AppsecNotificationArgs | undefined;
            if ((!args || args.displayName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'displayName'");
            }
            if ((!args || args.enabled === undefined) && !opts.urn) {
                throw new Error("Missing required property 'enabled'");
            }
            if ((!args || args.trigger === undefined) && !opts.urn) {
                throw new Error("Missing required property 'trigger'");
            }
            if ((!args || args.type === undefined) && !opts.urn) {
                throw new Error("Missing required property 'type'");
            }
            resourceInputs["attackCandidateBasedAlertingProfile"] = args ? args.attackCandidateBasedAlertingProfile : undefined;
            resourceInputs["attackCandidateBasedEmailPayload"] = args ? args.attackCandidateBasedEmailPayload : undefined;
            resourceInputs["attackCandidateBasedJiraPayload"] = args ? args.attackCandidateBasedJiraPayload : undefined;
            resourceInputs["attackCandidateBasedWebhookPayload"] = args ? args.attackCandidateBasedWebhookPayload : undefined;
            resourceInputs["displayName"] = args ? args.displayName : undefined;
            resourceInputs["emailConfiguration"] = args ? args.emailConfiguration : undefined;
            resourceInputs["enabled"] = args ? args.enabled : undefined;
            resourceInputs["jiraConfiguration"] = args ? args.jiraConfiguration : undefined;
            resourceInputs["securityProblemBasedAlertingProfile"] = args ? args.securityProblemBasedAlertingProfile : undefined;
            resourceInputs["securityProblemBasedEmailPayload"] = args ? args.securityProblemBasedEmailPayload : undefined;
            resourceInputs["securityProblemBasedJiraPayload"] = args ? args.securityProblemBasedJiraPayload : undefined;
            resourceInputs["securityProblemBasedWebhookPayload"] = args ? args.securityProblemBasedWebhookPayload : undefined;
            resourceInputs["trigger"] = args ? args.trigger : undefined;
            resourceInputs["type"] = args ? args.type : undefined;
            resourceInputs["webhookConfiguration"] = args ? args.webhookConfiguration : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(AppsecNotification.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering AppsecNotification resources.
 */
export interface AppsecNotificationState {
    /**
     * For attack candidate alerts, select an [alerting
     * profile](/ui/settings/builtin:appsec.notification-attack-alerting-profile) to control the delivery of security
     * notifications related to this integration.
     */
    attackCandidateBasedAlertingProfile?: pulumi.Input<string>;
    /**
     * Attack candidate based email payload, required when `trigger` equals `ATTACK_CANDIDATE` and `type` equals `EMAIL`
     */
    attackCandidateBasedEmailPayload?: pulumi.Input<inputs.AppsecNotificationAttackCandidateBasedEmailPayload>;
    /**
     * Attack candidate based Jira payload, required when `trigger` equals `ATTACK_CANDIDATE` and `type` equals `JIRA`
     */
    attackCandidateBasedJiraPayload?: pulumi.Input<inputs.AppsecNotificationAttackCandidateBasedJiraPayload>;
    /**
     * Attack candidate based webhook payload, required when `trigger` equals `ATTACK_CANDIDATE` and `type` equals `WEBHOOK`
     */
    attackCandidateBasedWebhookPayload?: pulumi.Input<inputs.AppsecNotificationAttackCandidateBasedWebhookPayload>;
    /**
     * Display name of the security notification
     */
    displayName?: pulumi.Input<string>;
    /**
     * Email configuration, required when `type` equals `EMAIL`
     */
    emailConfiguration?: pulumi.Input<inputs.AppsecNotificationEmailConfiguration>;
    /**
     * Enable/Disable the security notification, enabled (`true`) or disabled (`false`)
     */
    enabled?: pulumi.Input<boolean>;
    /**
     * Jira configuration, required when `type` equals `JIRA`
     */
    jiraConfiguration?: pulumi.Input<inputs.AppsecNotificationJiraConfiguration>;
    /**
     * For security problem alerts, select an [alerting profile](/ui/settings/builtin:appsec.notification-alerting-profile) to
     * control the delivery of security notifications related to this integration.
     */
    securityProblemBasedAlertingProfile?: pulumi.Input<string>;
    /**
     * Security problem based email payload, required when `trigger` equals `SECURITY_PROBLEM` and `type` equals `EMAIL`
     */
    securityProblemBasedEmailPayload?: pulumi.Input<inputs.AppsecNotificationSecurityProblemBasedEmailPayload>;
    /**
     * Security problem based Jira payload, required when `trigger` equals `SECURITY_PROBLEM` and `type` equals `JIRA`
     */
    securityProblemBasedJiraPayload?: pulumi.Input<inputs.AppsecNotificationSecurityProblemBasedJiraPayload>;
    /**
     * Security problem based webhook payload, required when `trigger` equals `SECURITY_PROBLEM` and `type` equals `WEBHOOK`
     */
    securityProblemBasedWebhookPayload?: pulumi.Input<inputs.AppsecNotificationSecurityProblemBasedWebhookPayload>;
    /**
     * Security alert type, possible Values: `ATTACK_CANDIDATE`, `SECURITY_PROBLEM`
     */
    trigger?: pulumi.Input<string>;
    /**
     * Notification type, possible Values: `EMAIL`, `JIRA`, `WEBHOOK`
     */
    type?: pulumi.Input<string>;
    /**
     * Webhook configuration, required when `type` equals `WEBHOOK`
     */
    webhookConfiguration?: pulumi.Input<inputs.AppsecNotificationWebhookConfiguration>;
}

/**
 * The set of arguments for constructing a AppsecNotification resource.
 */
export interface AppsecNotificationArgs {
    /**
     * For attack candidate alerts, select an [alerting
     * profile](/ui/settings/builtin:appsec.notification-attack-alerting-profile) to control the delivery of security
     * notifications related to this integration.
     */
    attackCandidateBasedAlertingProfile?: pulumi.Input<string>;
    /**
     * Attack candidate based email payload, required when `trigger` equals `ATTACK_CANDIDATE` and `type` equals `EMAIL`
     */
    attackCandidateBasedEmailPayload?: pulumi.Input<inputs.AppsecNotificationAttackCandidateBasedEmailPayload>;
    /**
     * Attack candidate based Jira payload, required when `trigger` equals `ATTACK_CANDIDATE` and `type` equals `JIRA`
     */
    attackCandidateBasedJiraPayload?: pulumi.Input<inputs.AppsecNotificationAttackCandidateBasedJiraPayload>;
    /**
     * Attack candidate based webhook payload, required when `trigger` equals `ATTACK_CANDIDATE` and `type` equals `WEBHOOK`
     */
    attackCandidateBasedWebhookPayload?: pulumi.Input<inputs.AppsecNotificationAttackCandidateBasedWebhookPayload>;
    /**
     * Display name of the security notification
     */
    displayName: pulumi.Input<string>;
    /**
     * Email configuration, required when `type` equals `EMAIL`
     */
    emailConfiguration?: pulumi.Input<inputs.AppsecNotificationEmailConfiguration>;
    /**
     * Enable/Disable the security notification, enabled (`true`) or disabled (`false`)
     */
    enabled: pulumi.Input<boolean>;
    /**
     * Jira configuration, required when `type` equals `JIRA`
     */
    jiraConfiguration?: pulumi.Input<inputs.AppsecNotificationJiraConfiguration>;
    /**
     * For security problem alerts, select an [alerting profile](/ui/settings/builtin:appsec.notification-alerting-profile) to
     * control the delivery of security notifications related to this integration.
     */
    securityProblemBasedAlertingProfile?: pulumi.Input<string>;
    /**
     * Security problem based email payload, required when `trigger` equals `SECURITY_PROBLEM` and `type` equals `EMAIL`
     */
    securityProblemBasedEmailPayload?: pulumi.Input<inputs.AppsecNotificationSecurityProblemBasedEmailPayload>;
    /**
     * Security problem based Jira payload, required when `trigger` equals `SECURITY_PROBLEM` and `type` equals `JIRA`
     */
    securityProblemBasedJiraPayload?: pulumi.Input<inputs.AppsecNotificationSecurityProblemBasedJiraPayload>;
    /**
     * Security problem based webhook payload, required when `trigger` equals `SECURITY_PROBLEM` and `type` equals `WEBHOOK`
     */
    securityProblemBasedWebhookPayload?: pulumi.Input<inputs.AppsecNotificationSecurityProblemBasedWebhookPayload>;
    /**
     * Security alert type, possible Values: `ATTACK_CANDIDATE`, `SECURITY_PROBLEM`
     */
    trigger: pulumi.Input<string>;
    /**
     * Notification type, possible Values: `EMAIL`, `JIRA`, `WEBHOOK`
     */
    type: pulumi.Input<string>;
    /**
     * Webhook configuration, required when `type` equals `WEBHOOK`
     */
    webhookConfiguration?: pulumi.Input<inputs.AppsecNotificationWebhookConfiguration>;
}