// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class KeyUserAction extends pulumi.CustomResource {
    /**
     * Get an existing KeyUserAction resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: KeyUserActionState, opts?: pulumi.CustomResourceOptions): KeyUserAction {
        return new KeyUserAction(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/keyUserAction:KeyUserAction';

    /**
     * Returns true if the given object is an instance of KeyUserAction.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is KeyUserAction {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === KeyUserAction.__pulumiType;
    }

    /**
     * The ID of the WebApplication
     */
    public readonly applicationId!: pulumi.Output<string>;
    /**
     * The domain where the action is performed
     */
    public readonly domain!: pulumi.Output<string | undefined>;
    /**
     * The name of the action
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The type of the action. Possible values are `Custom`, `Load` and `Xhr`
     */
    public readonly type!: pulumi.Output<string>;

    /**
     * Create a KeyUserAction resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: KeyUserActionArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: KeyUserActionArgs | KeyUserActionState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as KeyUserActionState | undefined;
            resourceInputs["applicationId"] = state ? state.applicationId : undefined;
            resourceInputs["domain"] = state ? state.domain : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["type"] = state ? state.type : undefined;
        } else {
            const args = argsOrState as KeyUserActionArgs | undefined;
            if ((!args || args.applicationId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'applicationId'");
            }
            if ((!args || args.type === undefined) && !opts.urn) {
                throw new Error("Missing required property 'type'");
            }
            resourceInputs["applicationId"] = args ? args.applicationId : undefined;
            resourceInputs["domain"] = args ? args.domain : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["type"] = args ? args.type : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(KeyUserAction.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering KeyUserAction resources.
 */
export interface KeyUserActionState {
    /**
     * The ID of the WebApplication
     */
    applicationId?: pulumi.Input<string>;
    /**
     * The domain where the action is performed
     */
    domain?: pulumi.Input<string>;
    /**
     * The name of the action
     */
    name?: pulumi.Input<string>;
    /**
     * The type of the action. Possible values are `Custom`, `Load` and `Xhr`
     */
    type?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a KeyUserAction resource.
 */
export interface KeyUserActionArgs {
    /**
     * The ID of the WebApplication
     */
    applicationId: pulumi.Input<string>;
    /**
     * The domain where the action is performed
     */
    domain?: pulumi.Input<string>;
    /**
     * The name of the action
     */
    name?: pulumi.Input<string>;
    /**
     * The type of the action. Possible values are `Custom`, `Load` and `Xhr`
     */
    type: pulumi.Input<string>;
}
