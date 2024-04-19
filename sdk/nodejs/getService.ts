// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * !> The data source API endpoint has been deprecated, please use dynatrace.getEntity with entity type `SERVICE` instead.
 *
 * The service data source allows the service ID to be retrieved by its name and optionally tags / tag-value pairs.
 *
 * - `name` queries for all services with the specified name
 * - `tags` (optional) refers to the tags that need to be present for the service (inclusive)
 *
 * If multiple services match the given criteria, the first result will be retrieved.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as dynatrace from "@alvaroblazquez4567/pulumi-dynatrace";
 * import * as dynatrace from "@pulumi/dynatrace";
 *
 * const test = dynatrace.getService({
 *     name: "Example",
 *     tags: [
 *         "TerraformKeyTest",
 *         "TerraformKeyValueTest=TestValue",
 *     ],
 * });
 * const _name_ = new dynatrace.KeyRequests("#name#", {service: test.then(test => test.id)});
 * ```
 */
export function getService(args: GetServiceArgs, opts?: pulumi.InvokeOptions): Promise<GetServiceResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("dynatrace:index/getService:getService", {
        "name": args.name,
        "operator": args.operator,
        "tags": args.tags,
    }, opts);
}

/**
 * A collection of arguments for invoking getService.
 */
export interface GetServiceArgs {
    name: string;
    operator?: string;
    /**
     * Required tags of the service to find
     */
    tags?: string[];
}

/**
 * A collection of values returned by getService.
 */
export interface GetServiceResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly name: string;
    readonly operator?: string;
    /**
     * Required tags of the service to find
     */
    readonly tags?: string[];
}
/**
 * !> The data source API endpoint has been deprecated, please use dynatrace.getEntity with entity type `SERVICE` instead.
 *
 * The service data source allows the service ID to be retrieved by its name and optionally tags / tag-value pairs.
 *
 * - `name` queries for all services with the specified name
 * - `tags` (optional) refers to the tags that need to be present for the service (inclusive)
 *
 * If multiple services match the given criteria, the first result will be retrieved.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as dynatrace from "@alvaroblazquez4567/pulumi-dynatrace";
 * import * as dynatrace from "@pulumi/dynatrace";
 *
 * const test = dynatrace.getService({
 *     name: "Example",
 *     tags: [
 *         "TerraformKeyTest",
 *         "TerraformKeyValueTest=TestValue",
 *     ],
 * });
 * const _name_ = new dynatrace.KeyRequests("#name#", {service: test.then(test => test.id)});
 * ```
 */
export function getServiceOutput(args: GetServiceOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetServiceResult> {
    return pulumi.output(args).apply((a: any) => getService(a, opts))
}

/**
 * A collection of arguments for invoking getService.
 */
export interface GetServiceOutputArgs {
    name: pulumi.Input<string>;
    operator?: pulumi.Input<string>;
    /**
     * Required tags of the service to find
     */
    tags?: pulumi.Input<pulumi.Input<string>[]>;
}
