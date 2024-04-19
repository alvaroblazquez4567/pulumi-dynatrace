// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class MonitoredTechnologiesOpentracing extends pulumi.CustomResource {
    /**
     * Get an existing MonitoredTechnologiesOpentracing resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: MonitoredTechnologiesOpentracingState, opts?: pulumi.CustomResourceOptions): MonitoredTechnologiesOpentracing {
        return new MonitoredTechnologiesOpentracing(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/monitoredTechnologiesOpentracing:MonitoredTechnologiesOpentracing';

    /**
     * Returns true if the given object is an instance of MonitoredTechnologiesOpentracing.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is MonitoredTechnologiesOpentracing {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === MonitoredTechnologiesOpentracing.__pulumiType;
    }

    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    public readonly enabled!: pulumi.Output<boolean>;
    /**
     * The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
     */
    public readonly hostId!: pulumi.Output<string | undefined>;

    /**
     * Create a MonitoredTechnologiesOpentracing resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: MonitoredTechnologiesOpentracingArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: MonitoredTechnologiesOpentracingArgs | MonitoredTechnologiesOpentracingState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as MonitoredTechnologiesOpentracingState | undefined;
            resourceInputs["enabled"] = state ? state.enabled : undefined;
            resourceInputs["hostId"] = state ? state.hostId : undefined;
        } else {
            const args = argsOrState as MonitoredTechnologiesOpentracingArgs | undefined;
            if ((!args || args.enabled === undefined) && !opts.urn) {
                throw new Error("Missing required property 'enabled'");
            }
            resourceInputs["enabled"] = args ? args.enabled : undefined;
            resourceInputs["hostId"] = args ? args.hostId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(MonitoredTechnologiesOpentracing.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering MonitoredTechnologiesOpentracing resources.
 */
export interface MonitoredTechnologiesOpentracingState {
    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    enabled?: pulumi.Input<boolean>;
    /**
     * The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
     */
    hostId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a MonitoredTechnologiesOpentracing resource.
 */
export interface MonitoredTechnologiesOpentracingArgs {
    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    enabled: pulumi.Input<boolean>;
    /**
     * The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
     */
    hostId?: pulumi.Input<string>;
}
