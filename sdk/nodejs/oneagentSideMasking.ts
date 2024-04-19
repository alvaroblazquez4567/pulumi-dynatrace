// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class OneagentSideMasking extends pulumi.CustomResource {
    /**
     * Get an existing OneagentSideMasking resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: OneagentSideMaskingState, opts?: pulumi.CustomResourceOptions): OneagentSideMasking {
        return new OneagentSideMasking(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/oneagentSideMasking:OneagentSideMasking';

    /**
     * Returns true if the given object is an instance of OneagentSideMasking.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is OneagentSideMasking {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === OneagentSideMasking.__pulumiType;
    }

    /**
     * Exclude email addresses from URLs
     */
    public readonly isEmailMaskingEnabled!: pulumi.Output<boolean>;
    /**
     * Exclude IBANs and payment card numbers from URLs
     */
    public readonly isFinancialMaskingEnabled!: pulumi.Output<boolean>;
    /**
     * Exclude hexadecimal IDs and consecutive numbers above 5 digits from URLs
     */
    public readonly isNumbersMaskingEnabled!: pulumi.Output<boolean>;
    /**
     * Exclude query parameters from URLs and web requests
     */
    public readonly isQueryMaskingEnabled!: pulumi.Output<boolean>;
    /**
     * The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
     */
    public readonly processGroupId!: pulumi.Output<string | undefined>;

    /**
     * Create a OneagentSideMasking resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: OneagentSideMaskingArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: OneagentSideMaskingArgs | OneagentSideMaskingState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as OneagentSideMaskingState | undefined;
            resourceInputs["isEmailMaskingEnabled"] = state ? state.isEmailMaskingEnabled : undefined;
            resourceInputs["isFinancialMaskingEnabled"] = state ? state.isFinancialMaskingEnabled : undefined;
            resourceInputs["isNumbersMaskingEnabled"] = state ? state.isNumbersMaskingEnabled : undefined;
            resourceInputs["isQueryMaskingEnabled"] = state ? state.isQueryMaskingEnabled : undefined;
            resourceInputs["processGroupId"] = state ? state.processGroupId : undefined;
        } else {
            const args = argsOrState as OneagentSideMaskingArgs | undefined;
            if ((!args || args.isEmailMaskingEnabled === undefined) && !opts.urn) {
                throw new Error("Missing required property 'isEmailMaskingEnabled'");
            }
            if ((!args || args.isFinancialMaskingEnabled === undefined) && !opts.urn) {
                throw new Error("Missing required property 'isFinancialMaskingEnabled'");
            }
            if ((!args || args.isNumbersMaskingEnabled === undefined) && !opts.urn) {
                throw new Error("Missing required property 'isNumbersMaskingEnabled'");
            }
            if ((!args || args.isQueryMaskingEnabled === undefined) && !opts.urn) {
                throw new Error("Missing required property 'isQueryMaskingEnabled'");
            }
            resourceInputs["isEmailMaskingEnabled"] = args ? args.isEmailMaskingEnabled : undefined;
            resourceInputs["isFinancialMaskingEnabled"] = args ? args.isFinancialMaskingEnabled : undefined;
            resourceInputs["isNumbersMaskingEnabled"] = args ? args.isNumbersMaskingEnabled : undefined;
            resourceInputs["isQueryMaskingEnabled"] = args ? args.isQueryMaskingEnabled : undefined;
            resourceInputs["processGroupId"] = args ? args.processGroupId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(OneagentSideMasking.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering OneagentSideMasking resources.
 */
export interface OneagentSideMaskingState {
    /**
     * Exclude email addresses from URLs
     */
    isEmailMaskingEnabled?: pulumi.Input<boolean>;
    /**
     * Exclude IBANs and payment card numbers from URLs
     */
    isFinancialMaskingEnabled?: pulumi.Input<boolean>;
    /**
     * Exclude hexadecimal IDs and consecutive numbers above 5 digits from URLs
     */
    isNumbersMaskingEnabled?: pulumi.Input<boolean>;
    /**
     * Exclude query parameters from URLs and web requests
     */
    isQueryMaskingEnabled?: pulumi.Input<boolean>;
    /**
     * The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
     */
    processGroupId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a OneagentSideMasking resource.
 */
export interface OneagentSideMaskingArgs {
    /**
     * Exclude email addresses from URLs
     */
    isEmailMaskingEnabled: pulumi.Input<boolean>;
    /**
     * Exclude IBANs and payment card numbers from URLs
     */
    isFinancialMaskingEnabled: pulumi.Input<boolean>;
    /**
     * Exclude hexadecimal IDs and consecutive numbers above 5 digits from URLs
     */
    isNumbersMaskingEnabled: pulumi.Input<boolean>;
    /**
     * Exclude query parameters from URLs and web requests
     */
    isQueryMaskingEnabled: pulumi.Input<boolean>;
    /**
     * The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
     */
    processGroupId?: pulumi.Input<string>;
}