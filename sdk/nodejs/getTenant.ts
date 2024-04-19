// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * The data source `dynatrace.getTenant` evalutes the configured Environment URL (either the environment variable `DYNATRACE_ENV_URL` or the configuration attribute `dtEnvUrl`) and extracts out the name/id of the environment this provider addresses.
 * Main purpose is for migrating settings from one environment to another, but it can be used to in general to avoid hard coding the environment ID like in the example below.
 */
export function getTenant(opts?: pulumi.InvokeOptions): Promise<GetTenantResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("dynatrace:index/getTenant:getTenant", {
    }, opts);
}

/**
 * A collection of values returned by getTenant.
 */
export interface GetTenantResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly name: string;
}
/**
 * The data source `dynatrace.getTenant` evalutes the configured Environment URL (either the environment variable `DYNATRACE_ENV_URL` or the configuration attribute `dtEnvUrl`) and extracts out the name/id of the environment this provider addresses.
 * Main purpose is for migrating settings from one environment to another, but it can be used to in general to avoid hard coding the environment ID like in the example below.
 */
export function getTenantOutput(opts?: pulumi.InvokeOptions): pulumi.Output<GetTenantResult> {
    return pulumi.output(getTenant(opts))
}