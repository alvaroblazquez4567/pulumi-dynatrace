// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * The IAM group data source allows the group ID to be retrieved by its name.
 *
 * - `name` (String) - The name of the IAM group
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as dynatrace from "@pulumi/dynatrace";
 *
 * const example = dynatrace.getIamGroup({
 *     name: "Terraform Example",
 * });
 * export const groups = example.then(example => example.id);
 * ```
 */
export function getIamGroup(args: GetIamGroupArgs, opts?: pulumi.InvokeOptions): Promise<GetIamGroupResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("dynatrace:index/getIamGroup:getIamGroup", {
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getIamGroup.
 */
export interface GetIamGroupArgs {
    name: string;
}

/**
 * A collection of values returned by getIamGroup.
 */
export interface GetIamGroupResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly name: string;
}
/**
 * The IAM group data source allows the group ID to be retrieved by its name.
 *
 * - `name` (String) - The name of the IAM group
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as dynatrace from "@pulumi/dynatrace";
 *
 * const example = dynatrace.getIamGroup({
 *     name: "Terraform Example",
 * });
 * export const groups = example.then(example => example.id);
 * ```
 */
export function getIamGroupOutput(args: GetIamGroupOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetIamGroupResult> {
    return pulumi.output(args).apply((a: any) => getIamGroup(a, opts))
}

/**
 * A collection of arguments for invoking getIamGroup.
 */
export interface GetIamGroupOutputArgs {
    name: pulumi.Input<string>;
}