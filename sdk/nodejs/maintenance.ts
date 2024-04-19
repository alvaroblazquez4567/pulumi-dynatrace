// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class Maintenance extends pulumi.CustomResource {
    /**
     * Get an existing Maintenance resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: MaintenanceState, opts?: pulumi.CustomResourceOptions): Maintenance {
        return new Maintenance(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/maintenance:Maintenance';

    /**
     * Returns true if the given object is an instance of Maintenance.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Maintenance {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Maintenance.__pulumiType;
    }

    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    public readonly enabled!: pulumi.Output<boolean>;
    /**
     * ## Filters
     * Add filters to limit the scope of maintenance to only select matching entities. If no filter is defined, the maintenance window is valid for the whole environment. Each filter is evaluated separately (**OR**).
     */
    public readonly filters!: pulumi.Output<outputs.MaintenanceFilters | undefined>;
    /**
     * The general properties of the maintenance window
     */
    public readonly generalProperties!: pulumi.Output<outputs.MaintenanceGeneralProperties>;
    /**
     * The ID of this setting when referred to by the Config REST API V1
     */
    public readonly legacyId!: pulumi.Output<string>;
    /**
     * The schedule of the maintenance window
     */
    public readonly schedule!: pulumi.Output<outputs.MaintenanceSchedule>;

    /**
     * Create a Maintenance resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: MaintenanceArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: MaintenanceArgs | MaintenanceState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as MaintenanceState | undefined;
            resourceInputs["enabled"] = state ? state.enabled : undefined;
            resourceInputs["filters"] = state ? state.filters : undefined;
            resourceInputs["generalProperties"] = state ? state.generalProperties : undefined;
            resourceInputs["legacyId"] = state ? state.legacyId : undefined;
            resourceInputs["schedule"] = state ? state.schedule : undefined;
        } else {
            const args = argsOrState as MaintenanceArgs | undefined;
            if ((!args || args.enabled === undefined) && !opts.urn) {
                throw new Error("Missing required property 'enabled'");
            }
            if ((!args || args.generalProperties === undefined) && !opts.urn) {
                throw new Error("Missing required property 'generalProperties'");
            }
            if ((!args || args.schedule === undefined) && !opts.urn) {
                throw new Error("Missing required property 'schedule'");
            }
            resourceInputs["enabled"] = args ? args.enabled : undefined;
            resourceInputs["filters"] = args ? args.filters : undefined;
            resourceInputs["generalProperties"] = args ? args.generalProperties : undefined;
            resourceInputs["legacyId"] = args ? args.legacyId : undefined;
            resourceInputs["schedule"] = args ? args.schedule : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Maintenance.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Maintenance resources.
 */
export interface MaintenanceState {
    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    enabled?: pulumi.Input<boolean>;
    /**
     * ## Filters
     * Add filters to limit the scope of maintenance to only select matching entities. If no filter is defined, the maintenance window is valid for the whole environment. Each filter is evaluated separately (**OR**).
     */
    filters?: pulumi.Input<inputs.MaintenanceFilters>;
    /**
     * The general properties of the maintenance window
     */
    generalProperties?: pulumi.Input<inputs.MaintenanceGeneralProperties>;
    /**
     * The ID of this setting when referred to by the Config REST API V1
     */
    legacyId?: pulumi.Input<string>;
    /**
     * The schedule of the maintenance window
     */
    schedule?: pulumi.Input<inputs.MaintenanceSchedule>;
}

/**
 * The set of arguments for constructing a Maintenance resource.
 */
export interface MaintenanceArgs {
    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    enabled: pulumi.Input<boolean>;
    /**
     * ## Filters
     * Add filters to limit the scope of maintenance to only select matching entities. If no filter is defined, the maintenance window is valid for the whole environment. Each filter is evaluated separately (**OR**).
     */
    filters?: pulumi.Input<inputs.MaintenanceFilters>;
    /**
     * The general properties of the maintenance window
     */
    generalProperties: pulumi.Input<inputs.MaintenanceGeneralProperties>;
    /**
     * The ID of this setting when referred to by the Config REST API V1
     */
    legacyId?: pulumi.Input<string>;
    /**
     * The schedule of the maintenance window
     */
    schedule: pulumi.Input<inputs.MaintenanceSchedule>;
}