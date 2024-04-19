// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class PgAlerting extends pulumi.CustomResource {
    /**
     * Get an existing PgAlerting resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: PgAlertingState, opts?: pulumi.CustomResourceOptions): PgAlerting {
        return new PgAlerting(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/pgAlerting:PgAlerting';

    /**
     * Returns true if the given object is an instance of PgAlerting.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is PgAlerting {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === PgAlerting.__pulumiType;
    }

    /**
     * Possible Values: `ON_INSTANCE_COUNT_VIOLATION`, `ON_PGI_UNAVAILABILITY`
     */
    public readonly alertingMode!: pulumi.Output<string | undefined>;
    /**
     * Enable (`true`) or disable (`false`) process group availability monitoring
     */
    public readonly enabled!: pulumi.Output<boolean>;
    /**
     * Open a new problem if the number of active process instances in the group is fewer than X
     */
    public readonly minimumInstanceThreshold!: pulumi.Output<number | undefined>;
    /**
     * The process group ID for availability monitoring
     */
    public readonly processGroup!: pulumi.Output<string>;

    /**
     * Create a PgAlerting resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: PgAlertingArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: PgAlertingArgs | PgAlertingState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as PgAlertingState | undefined;
            resourceInputs["alertingMode"] = state ? state.alertingMode : undefined;
            resourceInputs["enabled"] = state ? state.enabled : undefined;
            resourceInputs["minimumInstanceThreshold"] = state ? state.minimumInstanceThreshold : undefined;
            resourceInputs["processGroup"] = state ? state.processGroup : undefined;
        } else {
            const args = argsOrState as PgAlertingArgs | undefined;
            if ((!args || args.enabled === undefined) && !opts.urn) {
                throw new Error("Missing required property 'enabled'");
            }
            if ((!args || args.processGroup === undefined) && !opts.urn) {
                throw new Error("Missing required property 'processGroup'");
            }
            resourceInputs["alertingMode"] = args ? args.alertingMode : undefined;
            resourceInputs["enabled"] = args ? args.enabled : undefined;
            resourceInputs["minimumInstanceThreshold"] = args ? args.minimumInstanceThreshold : undefined;
            resourceInputs["processGroup"] = args ? args.processGroup : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(PgAlerting.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering PgAlerting resources.
 */
export interface PgAlertingState {
    /**
     * Possible Values: `ON_INSTANCE_COUNT_VIOLATION`, `ON_PGI_UNAVAILABILITY`
     */
    alertingMode?: pulumi.Input<string>;
    /**
     * Enable (`true`) or disable (`false`) process group availability monitoring
     */
    enabled?: pulumi.Input<boolean>;
    /**
     * Open a new problem if the number of active process instances in the group is fewer than X
     */
    minimumInstanceThreshold?: pulumi.Input<number>;
    /**
     * The process group ID for availability monitoring
     */
    processGroup?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a PgAlerting resource.
 */
export interface PgAlertingArgs {
    /**
     * Possible Values: `ON_INSTANCE_COUNT_VIOLATION`, `ON_PGI_UNAVAILABILITY`
     */
    alertingMode?: pulumi.Input<string>;
    /**
     * Enable (`true`) or disable (`false`) process group availability monitoring
     */
    enabled: pulumi.Input<boolean>;
    /**
     * Open a new problem if the number of active process instances in the group is fewer than X
     */
    minimumInstanceThreshold?: pulumi.Input<number>;
    /**
     * The process group ID for availability monitoring
     */
    processGroup: pulumi.Input<string>;
}
