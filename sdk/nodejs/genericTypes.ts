// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class GenericTypes extends pulumi.CustomResource {
    /**
     * Get an existing GenericTypes resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: GenericTypesState, opts?: pulumi.CustomResourceOptions): GenericTypes {
        return new GenericTypes(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/genericTypes:GenericTypes';

    /**
     * Returns true if the given object is an instance of GenericTypes.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is GenericTypes {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === GenericTypes.__pulumiType;
    }

    /**
     * The user or extension that created this type.
     */
    public readonly createdBy!: pulumi.Output<string>;
    /**
     * The human readable attribute name for this extraction rule. Leave blank to use the key as the display name.
     */
    public readonly displayName!: pulumi.Output<string>;
    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    public readonly enabled!: pulumi.Output<boolean>;
    /**
     * Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
     */
    public readonly insertAfter!: pulumi.Output<string>;
    /**
     * The entity type name. This type name must be unique and must not be changed after creation.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Specify a list of rules which are evaluated in order. When **any** rule matches, the entity defined according to that rule will be extracted. Subsequent rules will not be evaluated.
     */
    public readonly rules!: pulumi.Output<outputs.GenericTypesRules>;

    /**
     * Create a GenericTypes resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: GenericTypesArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: GenericTypesArgs | GenericTypesState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as GenericTypesState | undefined;
            resourceInputs["createdBy"] = state ? state.createdBy : undefined;
            resourceInputs["displayName"] = state ? state.displayName : undefined;
            resourceInputs["enabled"] = state ? state.enabled : undefined;
            resourceInputs["insertAfter"] = state ? state.insertAfter : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["rules"] = state ? state.rules : undefined;
        } else {
            const args = argsOrState as GenericTypesArgs | undefined;
            if ((!args || args.createdBy === undefined) && !opts.urn) {
                throw new Error("Missing required property 'createdBy'");
            }
            if ((!args || args.displayName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'displayName'");
            }
            if ((!args || args.enabled === undefined) && !opts.urn) {
                throw new Error("Missing required property 'enabled'");
            }
            if ((!args || args.rules === undefined) && !opts.urn) {
                throw new Error("Missing required property 'rules'");
            }
            resourceInputs["createdBy"] = args ? args.createdBy : undefined;
            resourceInputs["displayName"] = args ? args.displayName : undefined;
            resourceInputs["enabled"] = args ? args.enabled : undefined;
            resourceInputs["insertAfter"] = args ? args.insertAfter : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["rules"] = args ? args.rules : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(GenericTypes.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering GenericTypes resources.
 */
export interface GenericTypesState {
    /**
     * The user or extension that created this type.
     */
    createdBy?: pulumi.Input<string>;
    /**
     * The human readable attribute name for this extraction rule. Leave blank to use the key as the display name.
     */
    displayName?: pulumi.Input<string>;
    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    enabled?: pulumi.Input<boolean>;
    /**
     * Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
     */
    insertAfter?: pulumi.Input<string>;
    /**
     * The entity type name. This type name must be unique and must not be changed after creation.
     */
    name?: pulumi.Input<string>;
    /**
     * Specify a list of rules which are evaluated in order. When **any** rule matches, the entity defined according to that rule will be extracted. Subsequent rules will not be evaluated.
     */
    rules?: pulumi.Input<inputs.GenericTypesRules>;
}

/**
 * The set of arguments for constructing a GenericTypes resource.
 */
export interface GenericTypesArgs {
    /**
     * The user or extension that created this type.
     */
    createdBy: pulumi.Input<string>;
    /**
     * The human readable attribute name for this extraction rule. Leave blank to use the key as the display name.
     */
    displayName: pulumi.Input<string>;
    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    enabled: pulumi.Input<boolean>;
    /**
     * Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
     */
    insertAfter?: pulumi.Input<string>;
    /**
     * The entity type name. This type name must be unique and must not be changed after creation.
     */
    name?: pulumi.Input<string>;
    /**
     * Specify a list of rules which are evaluated in order. When **any** rule matches, the entity defined according to that rule will be extracted. Subsequent rules will not be evaluated.
     */
    rules: pulumi.Input<inputs.GenericTypesRules>;
}
