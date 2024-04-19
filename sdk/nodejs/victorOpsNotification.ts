// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class VictorOpsNotification extends pulumi.CustomResource {
    /**
     * Get an existing VictorOpsNotification resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: VictorOpsNotificationState, opts?: pulumi.CustomResourceOptions): VictorOpsNotification {
        return new VictorOpsNotification(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/victorOpsNotification:VictorOpsNotification';

    /**
     * Returns true if the given object is an instance of VictorOpsNotification.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is VictorOpsNotification {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === VictorOpsNotification.__pulumiType;
    }

    /**
     * The configuration is enabled (`true`) or disabled (`false`)
     */
    public readonly active!: pulumi.Output<boolean>;
    /**
     * The API key for the target VictorOps account
     */
    public readonly apiKey!: pulumi.Output<string | undefined>;
    /**
     * The ID of these settings when referred to from resources requiring the REST API V1 keys
     */
    public readonly legacyId!: pulumi.Output<string>;
    /**
     * The content of the message.  You can use the following placeholders:  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{ProblemDetailsText}`: All problem event details, including root cause, as a text-formatted string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`
     */
    public readonly message!: pulumi.Output<string>;
    /**
     * The name of the notification configuration
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The ID of the associated alerting profile
     */
    public readonly profile!: pulumi.Output<string>;
    /**
     * The routing key, defining the group to be notified
     */
    public readonly routingKey!: pulumi.Output<string>;

    /**
     * Create a VictorOpsNotification resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: VictorOpsNotificationArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: VictorOpsNotificationArgs | VictorOpsNotificationState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as VictorOpsNotificationState | undefined;
            resourceInputs["active"] = state ? state.active : undefined;
            resourceInputs["apiKey"] = state ? state.apiKey : undefined;
            resourceInputs["legacyId"] = state ? state.legacyId : undefined;
            resourceInputs["message"] = state ? state.message : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["profile"] = state ? state.profile : undefined;
            resourceInputs["routingKey"] = state ? state.routingKey : undefined;
        } else {
            const args = argsOrState as VictorOpsNotificationArgs | undefined;
            if ((!args || args.active === undefined) && !opts.urn) {
                throw new Error("Missing required property 'active'");
            }
            if ((!args || args.message === undefined) && !opts.urn) {
                throw new Error("Missing required property 'message'");
            }
            if ((!args || args.profile === undefined) && !opts.urn) {
                throw new Error("Missing required property 'profile'");
            }
            if ((!args || args.routingKey === undefined) && !opts.urn) {
                throw new Error("Missing required property 'routingKey'");
            }
            resourceInputs["active"] = args ? args.active : undefined;
            resourceInputs["apiKey"] = args?.apiKey ? pulumi.secret(args.apiKey) : undefined;
            resourceInputs["legacyId"] = args ? args.legacyId : undefined;
            resourceInputs["message"] = args ? args.message : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["profile"] = args ? args.profile : undefined;
            resourceInputs["routingKey"] = args ? args.routingKey : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const secretOpts = { additionalSecretOutputs: ["apiKey"] };
        opts = pulumi.mergeOptions(opts, secretOpts);
        super(VictorOpsNotification.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering VictorOpsNotification resources.
 */
export interface VictorOpsNotificationState {
    /**
     * The configuration is enabled (`true`) or disabled (`false`)
     */
    active?: pulumi.Input<boolean>;
    /**
     * The API key for the target VictorOps account
     */
    apiKey?: pulumi.Input<string>;
    /**
     * The ID of these settings when referred to from resources requiring the REST API V1 keys
     */
    legacyId?: pulumi.Input<string>;
    /**
     * The content of the message.  You can use the following placeholders:  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{ProblemDetailsText}`: All problem event details, including root cause, as a text-formatted string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`
     */
    message?: pulumi.Input<string>;
    /**
     * The name of the notification configuration
     */
    name?: pulumi.Input<string>;
    /**
     * The ID of the associated alerting profile
     */
    profile?: pulumi.Input<string>;
    /**
     * The routing key, defining the group to be notified
     */
    routingKey?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a VictorOpsNotification resource.
 */
export interface VictorOpsNotificationArgs {
    /**
     * The configuration is enabled (`true`) or disabled (`false`)
     */
    active: pulumi.Input<boolean>;
    /**
     * The API key for the target VictorOps account
     */
    apiKey?: pulumi.Input<string>;
    /**
     * The ID of these settings when referred to from resources requiring the REST API V1 keys
     */
    legacyId?: pulumi.Input<string>;
    /**
     * The content of the message.  You can use the following placeholders:  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{ProblemDetailsText}`: All problem event details, including root cause, as a text-formatted string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`
     */
    message: pulumi.Input<string>;
    /**
     * The name of the notification configuration
     */
    name?: pulumi.Input<string>;
    /**
     * The ID of the associated alerting profile
     */
    profile: pulumi.Input<string>;
    /**
     * The routing key, defining the group to be notified
     */
    routingKey: pulumi.Input<string>;
}
