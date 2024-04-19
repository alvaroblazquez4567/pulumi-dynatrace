// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class AutomationWorkflowSlack extends pulumi.CustomResource {
    /**
     * Get an existing AutomationWorkflowSlack resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AutomationWorkflowSlackState, opts?: pulumi.CustomResourceOptions): AutomationWorkflowSlack {
        return new AutomationWorkflowSlack(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/automationWorkflowSlack:AutomationWorkflowSlack';

    /**
     * Returns true if the given object is an instance of AutomationWorkflowSlack.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AutomationWorkflowSlack {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AutomationWorkflowSlack.__pulumiType;
    }

    /**
     * Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
     */
    public readonly insertAfter!: pulumi.Output<string>;
    /**
     * The name of the Slack connection
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The bot token obtained from the Slack App Management UI
     */
    public readonly token!: pulumi.Output<string>;

    /**
     * Create a AutomationWorkflowSlack resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AutomationWorkflowSlackArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: AutomationWorkflowSlackArgs | AutomationWorkflowSlackState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as AutomationWorkflowSlackState | undefined;
            resourceInputs["insertAfter"] = state ? state.insertAfter : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["token"] = state ? state.token : undefined;
        } else {
            const args = argsOrState as AutomationWorkflowSlackArgs | undefined;
            if ((!args || args.token === undefined) && !opts.urn) {
                throw new Error("Missing required property 'token'");
            }
            resourceInputs["insertAfter"] = args ? args.insertAfter : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["token"] = args?.token ? pulumi.secret(args.token) : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const secretOpts = { additionalSecretOutputs: ["token"] };
        opts = pulumi.mergeOptions(opts, secretOpts);
        super(AutomationWorkflowSlack.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering AutomationWorkflowSlack resources.
 */
export interface AutomationWorkflowSlackState {
    /**
     * Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
     */
    insertAfter?: pulumi.Input<string>;
    /**
     * The name of the Slack connection
     */
    name?: pulumi.Input<string>;
    /**
     * The bot token obtained from the Slack App Management UI
     */
    token?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a AutomationWorkflowSlack resource.
 */
export interface AutomationWorkflowSlackArgs {
    /**
     * Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
     */
    insertAfter?: pulumi.Input<string>;
    /**
     * The name of the Slack connection
     */
    name?: pulumi.Input<string>;
    /**
     * The bot token obtained from the Slack App Management UI
     */
    token: pulumi.Input<string>;
}