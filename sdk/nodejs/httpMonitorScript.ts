// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class HttpMonitorScript extends pulumi.CustomResource {
    /**
     * Get an existing HttpMonitorScript resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: HttpMonitorScriptState, opts?: pulumi.CustomResourceOptions): HttpMonitorScript {
        return new HttpMonitorScript(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/httpMonitorScript:HttpMonitorScript';

    /**
     * Returns true if the given object is an instance of HttpMonitorScript.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is HttpMonitorScript {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === HttpMonitorScript.__pulumiType;
    }

    /**
     * The ID of the HTTP monitor
     */
    public readonly httpId!: pulumi.Output<string>;
    /**
     * The HTTP Script
     */
    public readonly script!: pulumi.Output<outputs.HttpMonitorScriptScript>;

    /**
     * Create a HttpMonitorScript resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: HttpMonitorScriptArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: HttpMonitorScriptArgs | HttpMonitorScriptState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as HttpMonitorScriptState | undefined;
            resourceInputs["httpId"] = state ? state.httpId : undefined;
            resourceInputs["script"] = state ? state.script : undefined;
        } else {
            const args = argsOrState as HttpMonitorScriptArgs | undefined;
            if ((!args || args.httpId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'httpId'");
            }
            if ((!args || args.script === undefined) && !opts.urn) {
                throw new Error("Missing required property 'script'");
            }
            resourceInputs["httpId"] = args ? args.httpId : undefined;
            resourceInputs["script"] = args ? args.script : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(HttpMonitorScript.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering HttpMonitorScript resources.
 */
export interface HttpMonitorScriptState {
    /**
     * The ID of the HTTP monitor
     */
    httpId?: pulumi.Input<string>;
    /**
     * The HTTP Script
     */
    script?: pulumi.Input<inputs.HttpMonitorScriptScript>;
}

/**
 * The set of arguments for constructing a HttpMonitorScript resource.
 */
export interface HttpMonitorScriptArgs {
    /**
     * The ID of the HTTP monitor
     */
    httpId: pulumi.Input<string>;
    /**
     * The HTTP Script
     */
    script: pulumi.Input<inputs.HttpMonitorScriptScript>;
}
