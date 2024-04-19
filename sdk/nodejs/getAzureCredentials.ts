// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * The `dynatrace.AzureCredentials` data source allows the Azure credential ID to be retrieved by its label.
 *
 * - `label` (String) - The label/name of the Azure credential
 */
export function getAzureCredentials(args: GetAzureCredentialsArgs, opts?: pulumi.InvokeOptions): Promise<GetAzureCredentialsResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("dynatrace:index/getAzureCredentials:getAzureCredentials", {
        "label": args.label,
    }, opts);
}

/**
 * A collection of arguments for invoking getAzureCredentials.
 */
export interface GetAzureCredentialsArgs {
    label: string;
}

/**
 * A collection of values returned by getAzureCredentials.
 */
export interface GetAzureCredentialsResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly label: string;
}
/**
 * The `dynatrace.AzureCredentials` data source allows the Azure credential ID to be retrieved by its label.
 *
 * - `label` (String) - The label/name of the Azure credential
 */
export function getAzureCredentialsOutput(args: GetAzureCredentialsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetAzureCredentialsResult> {
    return pulumi.output(args).apply((a: any) => getAzureCredentials(a, opts))
}

/**
 * A collection of arguments for invoking getAzureCredentials.
 */
export interface GetAzureCredentialsOutputArgs {
    label: pulumi.Input<string>;
}
