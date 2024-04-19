// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class DataPrivacy extends pulumi.CustomResource {
    /**
     * Get an existing DataPrivacy resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DataPrivacyState, opts?: pulumi.CustomResourceOptions): DataPrivacy {
        return new DataPrivacy(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/dataPrivacy:DataPrivacy';

    /**
     * Returns true if the given object is an instance of DataPrivacy.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DataPrivacy {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DataPrivacy.__pulumiType;
    }

    /**
     * The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
     */
    public readonly applicationId!: pulumi.Output<string | undefined>;
    /**
     * To provide your end users with the ability to decide for themselves if their activities should be tracked to measure
     * application performance and usage, enable opt-in mode.
     */
    public readonly dataCollection!: pulumi.Output<outputs.DataPrivacyDataCollection>;
    /**
     * Most modern web browsers have a privacy feature called ["Do Not Track"](https://dt-url.net/sb3n0pnl) that individual
     * users may have enabled on their devices. Customize how Dynatrace should behave when it encounters this setting.
     */
    public readonly doNotTrack!: pulumi.Output<outputs.DataPrivacyDoNotTrack>;
    /**
     * no documentation available
     */
    public readonly masking!: pulumi.Output<outputs.DataPrivacyMasking>;
    /**
     * User tracking
     */
    public readonly userTracking!: pulumi.Output<outputs.DataPrivacyUserTracking>;

    /**
     * Create a DataPrivacy resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DataPrivacyArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DataPrivacyArgs | DataPrivacyState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as DataPrivacyState | undefined;
            resourceInputs["applicationId"] = state ? state.applicationId : undefined;
            resourceInputs["dataCollection"] = state ? state.dataCollection : undefined;
            resourceInputs["doNotTrack"] = state ? state.doNotTrack : undefined;
            resourceInputs["masking"] = state ? state.masking : undefined;
            resourceInputs["userTracking"] = state ? state.userTracking : undefined;
        } else {
            const args = argsOrState as DataPrivacyArgs | undefined;
            if ((!args || args.dataCollection === undefined) && !opts.urn) {
                throw new Error("Missing required property 'dataCollection'");
            }
            if ((!args || args.doNotTrack === undefined) && !opts.urn) {
                throw new Error("Missing required property 'doNotTrack'");
            }
            if ((!args || args.masking === undefined) && !opts.urn) {
                throw new Error("Missing required property 'masking'");
            }
            if ((!args || args.userTracking === undefined) && !opts.urn) {
                throw new Error("Missing required property 'userTracking'");
            }
            resourceInputs["applicationId"] = args ? args.applicationId : undefined;
            resourceInputs["dataCollection"] = args ? args.dataCollection : undefined;
            resourceInputs["doNotTrack"] = args ? args.doNotTrack : undefined;
            resourceInputs["masking"] = args ? args.masking : undefined;
            resourceInputs["userTracking"] = args ? args.userTracking : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(DataPrivacy.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering DataPrivacy resources.
 */
export interface DataPrivacyState {
    /**
     * The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
     */
    applicationId?: pulumi.Input<string>;
    /**
     * To provide your end users with the ability to decide for themselves if their activities should be tracked to measure
     * application performance and usage, enable opt-in mode.
     */
    dataCollection?: pulumi.Input<inputs.DataPrivacyDataCollection>;
    /**
     * Most modern web browsers have a privacy feature called ["Do Not Track"](https://dt-url.net/sb3n0pnl) that individual
     * users may have enabled on their devices. Customize how Dynatrace should behave when it encounters this setting.
     */
    doNotTrack?: pulumi.Input<inputs.DataPrivacyDoNotTrack>;
    /**
     * no documentation available
     */
    masking?: pulumi.Input<inputs.DataPrivacyMasking>;
    /**
     * User tracking
     */
    userTracking?: pulumi.Input<inputs.DataPrivacyUserTracking>;
}

/**
 * The set of arguments for constructing a DataPrivacy resource.
 */
export interface DataPrivacyArgs {
    /**
     * The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
     */
    applicationId?: pulumi.Input<string>;
    /**
     * To provide your end users with the ability to decide for themselves if their activities should be tracked to measure
     * application performance and usage, enable opt-in mode.
     */
    dataCollection: pulumi.Input<inputs.DataPrivacyDataCollection>;
    /**
     * Most modern web browsers have a privacy feature called ["Do Not Track"](https://dt-url.net/sb3n0pnl) that individual
     * users may have enabled on their devices. Customize how Dynatrace should behave when it encounters this setting.
     */
    doNotTrack: pulumi.Input<inputs.DataPrivacyDoNotTrack>;
    /**
     * no documentation available
     */
    masking: pulumi.Input<inputs.DataPrivacyMasking>;
    /**
     * User tracking
     */
    userTracking: pulumi.Input<inputs.DataPrivacyUserTracking>;
}
