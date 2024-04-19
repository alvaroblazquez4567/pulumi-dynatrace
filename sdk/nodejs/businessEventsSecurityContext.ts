// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class BusinessEventsSecurityContext extends pulumi.CustomResource {
    /**
     * Get an existing BusinessEventsSecurityContext resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: BusinessEventsSecurityContextState, opts?: pulumi.CustomResourceOptions): BusinessEventsSecurityContext {
        return new BusinessEventsSecurityContext(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/businessEventsSecurityContext:BusinessEventsSecurityContext';

    /**
     * Returns true if the given object is an instance of BusinessEventsSecurityContext.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is BusinessEventsSecurityContext {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === BusinessEventsSecurityContext.__pulumiType;
    }

    /**
     * Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
     */
    public readonly insertAfter!: pulumi.Output<string>;
    /**
     * no documentation available
     */
    public readonly securityContextRule!: pulumi.Output<outputs.BusinessEventsSecurityContextSecurityContextRule>;

    /**
     * Create a BusinessEventsSecurityContext resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: BusinessEventsSecurityContextArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: BusinessEventsSecurityContextArgs | BusinessEventsSecurityContextState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as BusinessEventsSecurityContextState | undefined;
            resourceInputs["insertAfter"] = state ? state.insertAfter : undefined;
            resourceInputs["securityContextRule"] = state ? state.securityContextRule : undefined;
        } else {
            const args = argsOrState as BusinessEventsSecurityContextArgs | undefined;
            if ((!args || args.securityContextRule === undefined) && !opts.urn) {
                throw new Error("Missing required property 'securityContextRule'");
            }
            resourceInputs["insertAfter"] = args ? args.insertAfter : undefined;
            resourceInputs["securityContextRule"] = args ? args.securityContextRule : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(BusinessEventsSecurityContext.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering BusinessEventsSecurityContext resources.
 */
export interface BusinessEventsSecurityContextState {
    /**
     * Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
     */
    insertAfter?: pulumi.Input<string>;
    /**
     * no documentation available
     */
    securityContextRule?: pulumi.Input<inputs.BusinessEventsSecurityContextSecurityContextRule>;
}

/**
 * The set of arguments for constructing a BusinessEventsSecurityContext resource.
 */
export interface BusinessEventsSecurityContextArgs {
    /**
     * Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
     */
    insertAfter?: pulumi.Input<string>;
    /**
     * no documentation available
     */
    securityContextRule: pulumi.Input<inputs.BusinessEventsSecurityContextSecurityContextRule>;
}
