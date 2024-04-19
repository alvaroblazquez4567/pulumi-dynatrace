// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * The application data source allows the application ID to be retrieved by its name.
 *
 * - `name` queries for all applications with the specified name
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as dynatrace from "@alvaroblazquez4567/pulumi-dynatrace";
 * import * as dynatrace from "@pulumi/dynatrace";
 *
 * const test = dynatrace.getApplication({
 *     name: "Example",
 * });
 * const _name_ = new dynatrace.ApplicationDetectionRule("#name#", {
 *     applicationIdentifier: test.then(test => test.id),
 *     filterConfig: {
 *         applicationMatchTarget: "DOMAIN",
 *         applicationMatchType: "MATCHES",
 *         pattern: "www.google.com",
 *     },
 * });
 * ```
 */
export function getApplication(args: GetApplicationArgs, opts?: pulumi.InvokeOptions): Promise<GetApplicationResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("dynatrace:index/getApplication:getApplication", {
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getApplication.
 */
export interface GetApplicationArgs {
    name: string;
}

/**
 * A collection of values returned by getApplication.
 */
export interface GetApplicationResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly name: string;
}
/**
 * The application data source allows the application ID to be retrieved by its name.
 *
 * - `name` queries for all applications with the specified name
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as dynatrace from "@alvaroblazquez4567/pulumi-dynatrace";
 * import * as dynatrace from "@pulumi/dynatrace";
 *
 * const test = dynatrace.getApplication({
 *     name: "Example",
 * });
 * const _name_ = new dynatrace.ApplicationDetectionRule("#name#", {
 *     applicationIdentifier: test.then(test => test.id),
 *     filterConfig: {
 *         applicationMatchTarget: "DOMAIN",
 *         applicationMatchType: "MATCHES",
 *         pattern: "www.google.com",
 *     },
 * });
 * ```
 */
export function getApplicationOutput(args: GetApplicationOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetApplicationResult> {
    return pulumi.output(args).apply((a: any) => getApplication(a, opts))
}

/**
 * A collection of arguments for invoking getApplication.
 */
export interface GetApplicationOutputArgs {
    name: pulumi.Input<string>;
}