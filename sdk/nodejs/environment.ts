// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * > This resource requires the cluster API token scope **Service Provider API** (`ServiceProviderAPI`)
 *
 * ## Dynatrace Documentation
 *
 * - Manage your monitoring environments - https://www.dynatrace.com/support/help/setup-and-configuration/dynatrace-managed/operation/manage-your-monitoring-environments
 *
 * - Cluster API v2 - Environments - https://www.dynatrace.com/support/help/shortlink/cluster-api#environments
 */
export class Environment extends pulumi.CustomResource {
    /**
     * Get an existing Environment resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: EnvironmentState, opts?: pulumi.CustomResourceOptions): Environment {
        return new Environment(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/environment:Environment';

    /**
     * Returns true if the given object is an instance of Environment.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Environment {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Environment.__pulumiType;
    }

    /**
     * The display name of the environment
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Environment level consumption and quotas information
     */
    public readonly quotas!: pulumi.Output<outputs.EnvironmentQuotas | undefined>;
    /**
     * Indicates whether the environment is enabled or disabled. Possible values are `ENABLED` and `DISABLED`. The default value is ENABLED
     */
    public readonly state!: pulumi.Output<string>;
    /**
     * Environment level storage usage and limit information
     */
    public readonly storage!: pulumi.Output<outputs.EnvironmentStorage>;
    /**
     * A set of tags that are assigned to this environment. Every tag can have a maximum length of 100 characters
     */
    public readonly tags!: pulumi.Output<string[] | undefined>;
    /**
     * Specifies whether the environment is a trial environment or a non-trial environment. Creating a trial environment is only possible if your license allows that. The default value is false (non-trial)
     */
    public readonly trial!: pulumi.Output<boolean | undefined>;

    /**
     * Create a Environment resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: EnvironmentArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: EnvironmentArgs | EnvironmentState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as EnvironmentState | undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["quotas"] = state ? state.quotas : undefined;
            resourceInputs["state"] = state ? state.state : undefined;
            resourceInputs["storage"] = state ? state.storage : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
            resourceInputs["trial"] = state ? state.trial : undefined;
        } else {
            const args = argsOrState as EnvironmentArgs | undefined;
            if ((!args || args.state === undefined) && !opts.urn) {
                throw new Error("Missing required property 'state'");
            }
            if ((!args || args.storage === undefined) && !opts.urn) {
                throw new Error("Missing required property 'storage'");
            }
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["quotas"] = args ? args.quotas : undefined;
            resourceInputs["state"] = args ? args.state : undefined;
            resourceInputs["storage"] = args ? args.storage : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["trial"] = args ? args.trial : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Environment.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Environment resources.
 */
export interface EnvironmentState {
    /**
     * The display name of the environment
     */
    name?: pulumi.Input<string>;
    /**
     * Environment level consumption and quotas information
     */
    quotas?: pulumi.Input<inputs.EnvironmentQuotas>;
    /**
     * Indicates whether the environment is enabled or disabled. Possible values are `ENABLED` and `DISABLED`. The default value is ENABLED
     */
    state?: pulumi.Input<string>;
    /**
     * Environment level storage usage and limit information
     */
    storage?: pulumi.Input<inputs.EnvironmentStorage>;
    /**
     * A set of tags that are assigned to this environment. Every tag can have a maximum length of 100 characters
     */
    tags?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Specifies whether the environment is a trial environment or a non-trial environment. Creating a trial environment is only possible if your license allows that. The default value is false (non-trial)
     */
    trial?: pulumi.Input<boolean>;
}

/**
 * The set of arguments for constructing a Environment resource.
 */
export interface EnvironmentArgs {
    /**
     * The display name of the environment
     */
    name?: pulumi.Input<string>;
    /**
     * Environment level consumption and quotas information
     */
    quotas?: pulumi.Input<inputs.EnvironmentQuotas>;
    /**
     * Indicates whether the environment is enabled or disabled. Possible values are `ENABLED` and `DISABLED`. The default value is ENABLED
     */
    state: pulumi.Input<string>;
    /**
     * Environment level storage usage and limit information
     */
    storage: pulumi.Input<inputs.EnvironmentStorage>;
    /**
     * A set of tags that are assigned to this environment. Every tag can have a maximum length of 100 characters
     */
    tags?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Specifies whether the environment is a trial environment or a non-trial environment. Creating a trial environment is only possible if your license allows that. The default value is false (non-trial)
     */
    trial?: pulumi.Input<boolean>;
}
