// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * > This resource is excluded by default in the export utility.
 *
 * > This resource requires the API token scopes **Read configuration** (`ReadConfig`) and **Write configuration** (`WriteConfig`)
 *
 * ## Dynatrace Documentation
 *
 * - Microsoft Azure monitoring - https://www.dynatrace.com/support/help/how-to-use-dynatrace/infrastructure-monitoring/cloud-platform-monitoring/microsoft-azure-services-monitoring
 *
 * - Azure credentials API - https://www.dynatrace.com/support/help/dynatrace-api/configuration-api/azure-credentials-api
 *
 * ## Resource Example Usage
 *
 * This example utilizes the data source `dynatrace.getAzureSupportedServices` in order to query for a full list of all supported services.
 * The `forEach` loop within the resource `dynatrace.AzureService` configures each of these services to get utilized with the default metrics recommended by Dynatrace (`useRecommendedMetrics`).
 *
 * If you want to configure a different set of metrics for a specific service, a separate resource `dynatrace.AzureService` will be necessary for that. That allows you to configure the `metric` blocks according to your wishes.
 * Just be aware of the fact, that Dynatrace enforces for most services a recommended set of metrics. All of them need to be part of your configuration in order to end up with a non-empty plan.
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as dynatrace from "@alvaroblazquez4567/pulumi-dynatrace";
 * import * as dynatrace from "@pulumi/dynatrace";
 *
 * export = async () => {
 *     const tERRAFORMSAMPLE = new dynatrace.AzureCredentials("tERRAFORMSAMPLE", {
 *         active: false,
 *         appId: "ABCDE",
 *         autoTagging: true,
 *         directoryId: "ABCDE",
 *         label: "TERRAFORM_SAMPLE",
 *         key: "aaaa",
 *         monitorOnlyTaggedEntities: true,
 *         monitorOnlyTagPairs: [{
 *             name: "string",
 *             value: "string",
 *         }],
 *     });
 *     const supportedServices = await dynatrace.getAzureSupportedServices({
 *         excepts: ["AZURE_STORAGE_ACCOUNT"],
 *     });
 *     const tERRAFORMSAMPLEServices: dynatrace.AzureService[] = [];
 *     for (const range of Object.entries(supportedServices.services).map(([k, v]) => ({key: k, value: v}))) {
 *         tERRAFORMSAMPLEServices.push(new dynatrace.AzureService(`tERRAFORMSAMPLEServices-${range.key}`, {
 *             credentialsId: tERRAFORMSAMPLE.id,
 *             useRecommendedMetrics: true,
 *         }));
 *     }
 * }
 * ```
 */
export class AzureService extends pulumi.CustomResource {
    /**
     * Get an existing AzureService resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AzureServiceState, opts?: pulumi.CustomResourceOptions): AzureService {
        return new AzureService(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/azureService:AzureService';

    /**
     * Returns true if the given object is an instance of AzureService.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AzureService {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AzureService.__pulumiType;
    }

    /**
     * This attribute is automatically set to `true` if Dynatrace considers the supporting service with the given name to be a built-in service
     */
    public /*out*/ readonly builtIn!: pulumi.Output<boolean>;
    /**
     * the ID of the azure credentials this supported service belongs to
     */
    public readonly credentialsId!: pulumi.Output<string>;
    /**
     * A list of metrics to be monitored for this service. Depending on the service Dynatrace insists on a set of recommended
     * metrics to be configured for that service. If any of these recommended metrics is missing here, the Terraform Provider
     * will automatically add them during `terraform apply`. This usually results in a non-empty plan, until all of the
     * recommended metrics are present within your configuration. For services considered `built-in` by Dynatrace any metrics
     * specified here will be ignored - Dynatrace enforces a fixed set of metrics for these services.
     */
    public readonly metrics!: pulumi.Output<outputs.AzureServiceMetric[] | undefined>;
    /**
     * the name of the metric of the supporting service
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Used internally by the Terraform Provider in order to remember the metrics enforced by Dynatrace
     */
    public /*out*/ readonly requiredMetrics!: pulumi.Output<string>;
    /**
     * If `true` Terraform will negotiate with the Dynatrace API about the recommended/enforced metrics to be applied. Any
     * `metric` specified will be therefore ignored.
     */
    public readonly useRecommendedMetrics!: pulumi.Output<boolean | undefined>;

    /**
     * Create a AzureService resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AzureServiceArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: AzureServiceArgs | AzureServiceState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as AzureServiceState | undefined;
            resourceInputs["builtIn"] = state ? state.builtIn : undefined;
            resourceInputs["credentialsId"] = state ? state.credentialsId : undefined;
            resourceInputs["metrics"] = state ? state.metrics : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["requiredMetrics"] = state ? state.requiredMetrics : undefined;
            resourceInputs["useRecommendedMetrics"] = state ? state.useRecommendedMetrics : undefined;
        } else {
            const args = argsOrState as AzureServiceArgs | undefined;
            if ((!args || args.credentialsId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'credentialsId'");
            }
            resourceInputs["credentialsId"] = args ? args.credentialsId : undefined;
            resourceInputs["metrics"] = args ? args.metrics : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["useRecommendedMetrics"] = args ? args.useRecommendedMetrics : undefined;
            resourceInputs["builtIn"] = undefined /*out*/;
            resourceInputs["requiredMetrics"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(AzureService.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering AzureService resources.
 */
export interface AzureServiceState {
    /**
     * This attribute is automatically set to `true` if Dynatrace considers the supporting service with the given name to be a built-in service
     */
    builtIn?: pulumi.Input<boolean>;
    /**
     * the ID of the azure credentials this supported service belongs to
     */
    credentialsId?: pulumi.Input<string>;
    /**
     * A list of metrics to be monitored for this service. Depending on the service Dynatrace insists on a set of recommended
     * metrics to be configured for that service. If any of these recommended metrics is missing here, the Terraform Provider
     * will automatically add them during `terraform apply`. This usually results in a non-empty plan, until all of the
     * recommended metrics are present within your configuration. For services considered `built-in` by Dynatrace any metrics
     * specified here will be ignored - Dynatrace enforces a fixed set of metrics for these services.
     */
    metrics?: pulumi.Input<pulumi.Input<inputs.AzureServiceMetric>[]>;
    /**
     * the name of the metric of the supporting service
     */
    name?: pulumi.Input<string>;
    /**
     * Used internally by the Terraform Provider in order to remember the metrics enforced by Dynatrace
     */
    requiredMetrics?: pulumi.Input<string>;
    /**
     * If `true` Terraform will negotiate with the Dynatrace API about the recommended/enforced metrics to be applied. Any
     * `metric` specified will be therefore ignored.
     */
    useRecommendedMetrics?: pulumi.Input<boolean>;
}

/**
 * The set of arguments for constructing a AzureService resource.
 */
export interface AzureServiceArgs {
    /**
     * the ID of the azure credentials this supported service belongs to
     */
    credentialsId: pulumi.Input<string>;
    /**
     * A list of metrics to be monitored for this service. Depending on the service Dynatrace insists on a set of recommended
     * metrics to be configured for that service. If any of these recommended metrics is missing here, the Terraform Provider
     * will automatically add them during `terraform apply`. This usually results in a non-empty plan, until all of the
     * recommended metrics are present within your configuration. For services considered `built-in` by Dynatrace any metrics
     * specified here will be ignored - Dynatrace enforces a fixed set of metrics for these services.
     */
    metrics?: pulumi.Input<pulumi.Input<inputs.AzureServiceMetric>[]>;
    /**
     * the name of the metric of the supporting service
     */
    name?: pulumi.Input<string>;
    /**
     * If `true` Terraform will negotiate with the Dynatrace API about the recommended/enforced metrics to be applied. Any
     * `metric` specified will be therefore ignored.
     */
    useRecommendedMetrics?: pulumi.Input<boolean>;
}