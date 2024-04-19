// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class FailureDetectionRules extends pulumi.CustomResource {
    /**
     * Get an existing FailureDetectionRules resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: FailureDetectionRulesState, opts?: pulumi.CustomResourceOptions): FailureDetectionRules {
        return new FailureDetectionRules(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/failureDetectionRules:FailureDetectionRules';

    /**
     * Returns true if the given object is an instance of FailureDetectionRules.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is FailureDetectionRules {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === FailureDetectionRules.__pulumiType;
    }

    /**
     * Conditions
     */
    public readonly conditions!: pulumi.Output<outputs.FailureDetectionRulesConditions>;
    /**
     * Rule description
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    public readonly enabled!: pulumi.Output<boolean>;
    /**
     * Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
     */
    public readonly insertAfter!: pulumi.Output<string>;
    /**
     * Rule name
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Failure detection parameters
     */
    public readonly parameterId!: pulumi.Output<string>;

    /**
     * Create a FailureDetectionRules resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: FailureDetectionRulesArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: FailureDetectionRulesArgs | FailureDetectionRulesState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as FailureDetectionRulesState | undefined;
            resourceInputs["conditions"] = state ? state.conditions : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["enabled"] = state ? state.enabled : undefined;
            resourceInputs["insertAfter"] = state ? state.insertAfter : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["parameterId"] = state ? state.parameterId : undefined;
        } else {
            const args = argsOrState as FailureDetectionRulesArgs | undefined;
            if ((!args || args.conditions === undefined) && !opts.urn) {
                throw new Error("Missing required property 'conditions'");
            }
            if ((!args || args.enabled === undefined) && !opts.urn) {
                throw new Error("Missing required property 'enabled'");
            }
            if ((!args || args.parameterId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'parameterId'");
            }
            resourceInputs["conditions"] = args ? args.conditions : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["enabled"] = args ? args.enabled : undefined;
            resourceInputs["insertAfter"] = args ? args.insertAfter : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["parameterId"] = args ? args.parameterId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(FailureDetectionRules.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering FailureDetectionRules resources.
 */
export interface FailureDetectionRulesState {
    /**
     * Conditions
     */
    conditions?: pulumi.Input<inputs.FailureDetectionRulesConditions>;
    /**
     * Rule description
     */
    description?: pulumi.Input<string>;
    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    enabled?: pulumi.Input<boolean>;
    /**
     * Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
     */
    insertAfter?: pulumi.Input<string>;
    /**
     * Rule name
     */
    name?: pulumi.Input<string>;
    /**
     * Failure detection parameters
     */
    parameterId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a FailureDetectionRules resource.
 */
export interface FailureDetectionRulesArgs {
    /**
     * Conditions
     */
    conditions: pulumi.Input<inputs.FailureDetectionRulesConditions>;
    /**
     * Rule description
     */
    description?: pulumi.Input<string>;
    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    enabled: pulumi.Input<boolean>;
    /**
     * Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
     */
    insertAfter?: pulumi.Input<string>;
    /**
     * Rule name
     */
    name?: pulumi.Input<string>;
    /**
     * Failure detection parameters
     */
    parameterId: pulumi.Input<string>;
}