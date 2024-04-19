// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class CrashdumpAnalytics extends pulumi.CustomResource {
    /**
     * Get an existing CrashdumpAnalytics resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: CrashdumpAnalyticsState, opts?: pulumi.CustomResourceOptions): CrashdumpAnalytics {
        return new CrashdumpAnalytics(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/crashdumpAnalytics:CrashdumpAnalytics';

    /**
     * Returns true if the given object is an instance of CrashdumpAnalytics.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is CrashdumpAnalytics {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === CrashdumpAnalytics.__pulumiType;
    }

    /**
     * Control the automatic crash dump analytics feature. It's strongly recommended to keep this option enabled. Disabling this feature will stop receiving information about potential problems
     */
    public readonly enableCrashDumpAnalytics!: pulumi.Output<boolean>;
    /**
     * The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
     */
    public readonly hostId!: pulumi.Output<string>;

    /**
     * Create a CrashdumpAnalytics resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: CrashdumpAnalyticsArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: CrashdumpAnalyticsArgs | CrashdumpAnalyticsState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as CrashdumpAnalyticsState | undefined;
            resourceInputs["enableCrashDumpAnalytics"] = state ? state.enableCrashDumpAnalytics : undefined;
            resourceInputs["hostId"] = state ? state.hostId : undefined;
        } else {
            const args = argsOrState as CrashdumpAnalyticsArgs | undefined;
            if ((!args || args.enableCrashDumpAnalytics === undefined) && !opts.urn) {
                throw new Error("Missing required property 'enableCrashDumpAnalytics'");
            }
            if ((!args || args.hostId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'hostId'");
            }
            resourceInputs["enableCrashDumpAnalytics"] = args ? args.enableCrashDumpAnalytics : undefined;
            resourceInputs["hostId"] = args ? args.hostId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(CrashdumpAnalytics.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering CrashdumpAnalytics resources.
 */
export interface CrashdumpAnalyticsState {
    /**
     * Control the automatic crash dump analytics feature. It's strongly recommended to keep this option enabled. Disabling this feature will stop receiving information about potential problems
     */
    enableCrashDumpAnalytics?: pulumi.Input<boolean>;
    /**
     * The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
     */
    hostId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a CrashdumpAnalytics resource.
 */
export interface CrashdumpAnalyticsArgs {
    /**
     * Control the automatic crash dump analytics feature. It's strongly recommended to keep this option enabled. Disabling this feature will stop receiving information about potential problems
     */
    enableCrashDumpAnalytics: pulumi.Input<boolean>;
    /**
     * The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
     */
    hostId: pulumi.Input<string>;
}
