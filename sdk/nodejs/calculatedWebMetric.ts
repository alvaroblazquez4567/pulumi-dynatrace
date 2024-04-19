// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class CalculatedWebMetric extends pulumi.CustomResource {
    /**
     * Get an existing CalculatedWebMetric resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: CalculatedWebMetricState, opts?: pulumi.CustomResourceOptions): CalculatedWebMetric {
        return new CalculatedWebMetric(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/calculatedWebMetric:CalculatedWebMetric';

    /**
     * Returns true if the given object is an instance of CalculatedWebMetric.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is CalculatedWebMetric {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === CalculatedWebMetric.__pulumiType;
    }

    /**
     * The Dynatrace entity ID of the application to which the metric belongs.
     */
    public readonly appIdentifier!: pulumi.Output<string>;
    /**
     * Descriptor of a calculated web metric.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Parameters of a definition of a calculated web metric.
     */
    public readonly dimensions!: pulumi.Output<outputs.CalculatedWebMetricDimension[] | undefined>;
    /**
     * The metric is enabled (`true`) or disabled (`false`)
     */
    public readonly enabled!: pulumi.Output<boolean>;
    /**
     * The definition of a calculated web metric.
     */
    public readonly metricDefinition!: pulumi.Output<outputs.CalculatedWebMetricMetricDefinition>;
    /**
     * The unique key of the calculated web metric.
     */
    public readonly metricKey!: pulumi.Output<string>;
    /**
     * The displayed name of the metric.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Parameters of a definition of a calculated web metric.
     */
    public readonly userActionFilter!: pulumi.Output<outputs.CalculatedWebMetricUserActionFilter | undefined>;

    /**
     * Create a CalculatedWebMetric resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: CalculatedWebMetricArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: CalculatedWebMetricArgs | CalculatedWebMetricState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as CalculatedWebMetricState | undefined;
            resourceInputs["appIdentifier"] = state ? state.appIdentifier : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["dimensions"] = state ? state.dimensions : undefined;
            resourceInputs["enabled"] = state ? state.enabled : undefined;
            resourceInputs["metricDefinition"] = state ? state.metricDefinition : undefined;
            resourceInputs["metricKey"] = state ? state.metricKey : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["userActionFilter"] = state ? state.userActionFilter : undefined;
        } else {
            const args = argsOrState as CalculatedWebMetricArgs | undefined;
            if ((!args || args.appIdentifier === undefined) && !opts.urn) {
                throw new Error("Missing required property 'appIdentifier'");
            }
            if ((!args || args.enabled === undefined) && !opts.urn) {
                throw new Error("Missing required property 'enabled'");
            }
            if ((!args || args.metricDefinition === undefined) && !opts.urn) {
                throw new Error("Missing required property 'metricDefinition'");
            }
            if ((!args || args.metricKey === undefined) && !opts.urn) {
                throw new Error("Missing required property 'metricKey'");
            }
            resourceInputs["appIdentifier"] = args ? args.appIdentifier : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["dimensions"] = args ? args.dimensions : undefined;
            resourceInputs["enabled"] = args ? args.enabled : undefined;
            resourceInputs["metricDefinition"] = args ? args.metricDefinition : undefined;
            resourceInputs["metricKey"] = args ? args.metricKey : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["userActionFilter"] = args ? args.userActionFilter : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(CalculatedWebMetric.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering CalculatedWebMetric resources.
 */
export interface CalculatedWebMetricState {
    /**
     * The Dynatrace entity ID of the application to which the metric belongs.
     */
    appIdentifier?: pulumi.Input<string>;
    /**
     * Descriptor of a calculated web metric.
     */
    description?: pulumi.Input<string>;
    /**
     * Parameters of a definition of a calculated web metric.
     */
    dimensions?: pulumi.Input<pulumi.Input<inputs.CalculatedWebMetricDimension>[]>;
    /**
     * The metric is enabled (`true`) or disabled (`false`)
     */
    enabled?: pulumi.Input<boolean>;
    /**
     * The definition of a calculated web metric.
     */
    metricDefinition?: pulumi.Input<inputs.CalculatedWebMetricMetricDefinition>;
    /**
     * The unique key of the calculated web metric.
     */
    metricKey?: pulumi.Input<string>;
    /**
     * The displayed name of the metric.
     */
    name?: pulumi.Input<string>;
    /**
     * Parameters of a definition of a calculated web metric.
     */
    userActionFilter?: pulumi.Input<inputs.CalculatedWebMetricUserActionFilter>;
}

/**
 * The set of arguments for constructing a CalculatedWebMetric resource.
 */
export interface CalculatedWebMetricArgs {
    /**
     * The Dynatrace entity ID of the application to which the metric belongs.
     */
    appIdentifier: pulumi.Input<string>;
    /**
     * Descriptor of a calculated web metric.
     */
    description?: pulumi.Input<string>;
    /**
     * Parameters of a definition of a calculated web metric.
     */
    dimensions?: pulumi.Input<pulumi.Input<inputs.CalculatedWebMetricDimension>[]>;
    /**
     * The metric is enabled (`true`) or disabled (`false`)
     */
    enabled: pulumi.Input<boolean>;
    /**
     * The definition of a calculated web metric.
     */
    metricDefinition: pulumi.Input<inputs.CalculatedWebMetricMetricDefinition>;
    /**
     * The unique key of the calculated web metric.
     */
    metricKey: pulumi.Input<string>;
    /**
     * The displayed name of the metric.
     */
    name?: pulumi.Input<string>;
    /**
     * Parameters of a definition of a calculated web metric.
     */
    userActionFilter?: pulumi.Input<inputs.CalculatedWebMetricUserActionFilter>;
}
