// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class AttackRules extends pulumi.CustomResource {
    /**
     * Get an existing AttackRules resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AttackRulesState, opts?: pulumi.CustomResourceOptions): AttackRules {
        return new AttackRules(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/attackRules:AttackRules';

    /**
     * Returns true if the given object is an instance of AttackRules.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AttackRules {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AttackRules.__pulumiType;
    }

    /**
     * Step 2: Define attack control for chosen criteria
     */
    public readonly attackHandling!: pulumi.Output<outputs.AttackRulesAttackHandling>;
    /**
     * Step 1: Define criteria
     */
    public readonly criteria!: pulumi.Output<outputs.AttackRulesCriteria>;
    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    public readonly enabled!: pulumi.Output<boolean>;
    /**
     * Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
     */
    public readonly insertAfter!: pulumi.Output<string>;
    /**
     * Step 3: Leave comment
     */
    public readonly metadata!: pulumi.Output<outputs.AttackRulesMetadata>;

    /**
     * Create a AttackRules resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AttackRulesArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: AttackRulesArgs | AttackRulesState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as AttackRulesState | undefined;
            resourceInputs["attackHandling"] = state ? state.attackHandling : undefined;
            resourceInputs["criteria"] = state ? state.criteria : undefined;
            resourceInputs["enabled"] = state ? state.enabled : undefined;
            resourceInputs["insertAfter"] = state ? state.insertAfter : undefined;
            resourceInputs["metadata"] = state ? state.metadata : undefined;
        } else {
            const args = argsOrState as AttackRulesArgs | undefined;
            if ((!args || args.attackHandling === undefined) && !opts.urn) {
                throw new Error("Missing required property 'attackHandling'");
            }
            if ((!args || args.criteria === undefined) && !opts.urn) {
                throw new Error("Missing required property 'criteria'");
            }
            if ((!args || args.enabled === undefined) && !opts.urn) {
                throw new Error("Missing required property 'enabled'");
            }
            if ((!args || args.metadata === undefined) && !opts.urn) {
                throw new Error("Missing required property 'metadata'");
            }
            resourceInputs["attackHandling"] = args ? args.attackHandling : undefined;
            resourceInputs["criteria"] = args ? args.criteria : undefined;
            resourceInputs["enabled"] = args ? args.enabled : undefined;
            resourceInputs["insertAfter"] = args ? args.insertAfter : undefined;
            resourceInputs["metadata"] = args ? args.metadata : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(AttackRules.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering AttackRules resources.
 */
export interface AttackRulesState {
    /**
     * Step 2: Define attack control for chosen criteria
     */
    attackHandling?: pulumi.Input<inputs.AttackRulesAttackHandling>;
    /**
     * Step 1: Define criteria
     */
    criteria?: pulumi.Input<inputs.AttackRulesCriteria>;
    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    enabled?: pulumi.Input<boolean>;
    /**
     * Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
     */
    insertAfter?: pulumi.Input<string>;
    /**
     * Step 3: Leave comment
     */
    metadata?: pulumi.Input<inputs.AttackRulesMetadata>;
}

/**
 * The set of arguments for constructing a AttackRules resource.
 */
export interface AttackRulesArgs {
    /**
     * Step 2: Define attack control for chosen criteria
     */
    attackHandling: pulumi.Input<inputs.AttackRulesAttackHandling>;
    /**
     * Step 1: Define criteria
     */
    criteria: pulumi.Input<inputs.AttackRulesCriteria>;
    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    enabled: pulumi.Input<boolean>;
    /**
     * Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
     */
    insertAfter?: pulumi.Input<string>;
    /**
     * Step 3: Leave comment
     */
    metadata: pulumi.Input<inputs.AttackRulesMetadata>;
}
