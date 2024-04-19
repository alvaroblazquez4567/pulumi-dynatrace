// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class SpanAttributed extends pulumi.CustomResource {
    /**
     * Get an existing SpanAttributed resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: SpanAttributedState, opts?: pulumi.CustomResourceOptions): SpanAttributed {
        return new SpanAttributed(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/spanAttributed:SpanAttributed';

    /**
     * Returns true if the given object is an instance of SpanAttributed.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SpanAttributed {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SpanAttributed.__pulumiType;
    }

    /**
     * Key of the span attribute to store
     */
    public readonly key!: pulumi.Output<string>;
    /**
     * Possible Values: `MASK_ENTIRE_VALUE`, `MASK_ONLY_CONFIDENTIAL_DATA`, `NOT_MASKED`
     */
    public readonly masking!: pulumi.Output<string>;
    /**
     * Prevents the Span Attribute from getting deleted when running `terraform destroy` - to be used for Span Attributes that
     * are defined by default on every Dynatrace environment.
     */
    public readonly persistent!: pulumi.Output<boolean>;

    /**
     * Create a SpanAttributed resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SpanAttributedArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: SpanAttributedArgs | SpanAttributedState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as SpanAttributedState | undefined;
            resourceInputs["key"] = state ? state.key : undefined;
            resourceInputs["masking"] = state ? state.masking : undefined;
            resourceInputs["persistent"] = state ? state.persistent : undefined;
        } else {
            const args = argsOrState as SpanAttributedArgs | undefined;
            if ((!args || args.key === undefined) && !opts.urn) {
                throw new Error("Missing required property 'key'");
            }
            if ((!args || args.masking === undefined) && !opts.urn) {
                throw new Error("Missing required property 'masking'");
            }
            resourceInputs["key"] = args ? args.key : undefined;
            resourceInputs["masking"] = args ? args.masking : undefined;
            resourceInputs["persistent"] = args ? args.persistent : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(SpanAttributed.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering SpanAttributed resources.
 */
export interface SpanAttributedState {
    /**
     * Key of the span attribute to store
     */
    key?: pulumi.Input<string>;
    /**
     * Possible Values: `MASK_ENTIRE_VALUE`, `MASK_ONLY_CONFIDENTIAL_DATA`, `NOT_MASKED`
     */
    masking?: pulumi.Input<string>;
    /**
     * Prevents the Span Attribute from getting deleted when running `terraform destroy` - to be used for Span Attributes that
     * are defined by default on every Dynatrace environment.
     */
    persistent?: pulumi.Input<boolean>;
}

/**
 * The set of arguments for constructing a SpanAttributed resource.
 */
export interface SpanAttributedArgs {
    /**
     * Key of the span attribute to store
     */
    key: pulumi.Input<string>;
    /**
     * Possible Values: `MASK_ENTIRE_VALUE`, `MASK_ONLY_CONFIDENTIAL_DATA`, `NOT_MASKED`
     */
    masking: pulumi.Input<string>;
    /**
     * Prevents the Span Attribute from getting deleted when running `terraform destroy` - to be used for Span Attributes that
     * are defined by default on every Dynatrace environment.
     */
    persistent?: pulumi.Input<boolean>;
}
