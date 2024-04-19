// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class CalculatedServiceMetric extends pulumi.CustomResource {
    /**
     * Get an existing CalculatedServiceMetric resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: CalculatedServiceMetricState, opts?: pulumi.CustomResourceOptions): CalculatedServiceMetric {
        return new CalculatedServiceMetric(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/calculatedServiceMetric:CalculatedServiceMetric';

    /**
     * Returns true if the given object is an instance of CalculatedServiceMetric.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is CalculatedServiceMetric {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === CalculatedServiceMetric.__pulumiType;
    }

    /**
     * The set of conditions for the metric usage. **All** the specified conditions must be fulfilled to use the metric
     */
    public readonly conditions!: pulumi.Output<outputs.CalculatedServiceMetricCondition[] | undefined>;
    /**
     * The displayed description of the metric
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Parameters of a definition of a calculated service metric
     */
    public readonly dimensionDefinition!: pulumi.Output<outputs.CalculatedServiceMetricDimensionDefinition | undefined>;
    /**
     * The metric is enabled (`true`) or disabled (`false`)
     */
    public readonly enabled!: pulumi.Output<boolean | undefined>;
    /**
     * Restricts the metric usage to the specified service. This field is mutually exclusive with the `management_zones` field
     */
    public readonly entityId!: pulumi.Output<string | undefined>;
    /**
     * Metric should (true) or not (false) ignore muted requests.
     */
    public readonly ignoreMutedRequests!: pulumi.Output<boolean | undefined>;
    /**
     * Restricts the metric usage to specified management zones. This field is mutually exclusive with the `entity_id` field
     */
    public readonly managementZones!: pulumi.Output<string[] | undefined>;
    /**
     * The definition of a calculated service metric
     */
    public readonly metricDefinition!: pulumi.Output<outputs.CalculatedServiceMetricMetricDefinition | undefined>;
    /**
     * The key of the calculated service metric
     */
    public readonly metricKey!: pulumi.Output<string>;
    /**
     * The displayed name of the metric
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The unit of the metric. Possible values are `BIT`, `BIT_PER_HOUR`, `BIT_PER_MINUTE`, `BIT_PER_SECOND`, `BYTE`,
     * `BYTE_PER_HOUR`, `BYTE_PER_MINUTE`, `BYTE_PER_SECOND`, `CORES`, `COUNT`, `DAY`, `DECIBEL_MILLI_WATT`, `GIBI_BYTE`,
     * `GIGA`, `GIGA_BYTE`, `HOUR`, `KIBI_BYTE`, `KIBI_BYTE_PER_HOUR`, `KIBI_BYTE_PER_MINUTE`, `KIBI_BYTE_PER_SECOND`, `KILO`,
     * `KILO_BYTE`, `KILO_BYTE_PER_HOUR`, `KILO_BYTE_PER_MINUTE`, `KILO_BYTE_PER_SECOND`, `MEBI_BYTE`, `MEBI_BYTE_PER_HOUR`,
     * `MEBI_BYTE_PER_MINUTE`, `MEBI_BYTE_PER_SECOND`, `MEGA`, `MEGA_BYTE`, `MEGA_BYTE_PER_HOUR`, `MEGA_BYTE_PER_MINUTE`,
     * `MEGA_BYTE_PER_SECOND`, `MICRO_SECOND`, `MILLI_CORES`, `MILLI_SECOND`, `MILLI_SECOND_PER_MINUTE`, `MINUTE`, `MONTH`,
     * `MSU`, `NANO_SECOND`, `NANO_SECOND_PER_MINUTE`, `NOT_APPLICABLE`, `PERCENT`, `PER_HOUR`, `PER_MINUTE`, `PER_SECOND`,
     * `PIXEL`, `PROMILLE`, `RATIO`, `SECOND`, `STATE`, `UNSPECIFIED`, `WEEK` and `YEAR`
     */
    public readonly unit!: pulumi.Output<string>;
    /**
     * The display name of the metric's unit. Only applicable when the **unit** parameter is set to `UNSPECIFIED`
     */
    public readonly unitDisplayName!: pulumi.Output<string | undefined>;
    /**
     * allows for configuring properties that are not explicitly supported by the current version of this provider
     */
    public readonly unknowns!: pulumi.Output<string | undefined>;

    /**
     * Create a CalculatedServiceMetric resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: CalculatedServiceMetricArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: CalculatedServiceMetricArgs | CalculatedServiceMetricState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as CalculatedServiceMetricState | undefined;
            resourceInputs["conditions"] = state ? state.conditions : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["dimensionDefinition"] = state ? state.dimensionDefinition : undefined;
            resourceInputs["enabled"] = state ? state.enabled : undefined;
            resourceInputs["entityId"] = state ? state.entityId : undefined;
            resourceInputs["ignoreMutedRequests"] = state ? state.ignoreMutedRequests : undefined;
            resourceInputs["managementZones"] = state ? state.managementZones : undefined;
            resourceInputs["metricDefinition"] = state ? state.metricDefinition : undefined;
            resourceInputs["metricKey"] = state ? state.metricKey : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["unit"] = state ? state.unit : undefined;
            resourceInputs["unitDisplayName"] = state ? state.unitDisplayName : undefined;
            resourceInputs["unknowns"] = state ? state.unknowns : undefined;
        } else {
            const args = argsOrState as CalculatedServiceMetricArgs | undefined;
            if ((!args || args.metricKey === undefined) && !opts.urn) {
                throw new Error("Missing required property 'metricKey'");
            }
            if ((!args || args.unit === undefined) && !opts.urn) {
                throw new Error("Missing required property 'unit'");
            }
            resourceInputs["conditions"] = args ? args.conditions : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["dimensionDefinition"] = args ? args.dimensionDefinition : undefined;
            resourceInputs["enabled"] = args ? args.enabled : undefined;
            resourceInputs["entityId"] = args ? args.entityId : undefined;
            resourceInputs["ignoreMutedRequests"] = args ? args.ignoreMutedRequests : undefined;
            resourceInputs["managementZones"] = args ? args.managementZones : undefined;
            resourceInputs["metricDefinition"] = args ? args.metricDefinition : undefined;
            resourceInputs["metricKey"] = args ? args.metricKey : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["unit"] = args ? args.unit : undefined;
            resourceInputs["unitDisplayName"] = args ? args.unitDisplayName : undefined;
            resourceInputs["unknowns"] = args ? args.unknowns : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(CalculatedServiceMetric.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering CalculatedServiceMetric resources.
 */
export interface CalculatedServiceMetricState {
    /**
     * The set of conditions for the metric usage. **All** the specified conditions must be fulfilled to use the metric
     */
    conditions?: pulumi.Input<pulumi.Input<inputs.CalculatedServiceMetricCondition>[]>;
    /**
     * The displayed description of the metric
     */
    description?: pulumi.Input<string>;
    /**
     * Parameters of a definition of a calculated service metric
     */
    dimensionDefinition?: pulumi.Input<inputs.CalculatedServiceMetricDimensionDefinition>;
    /**
     * The metric is enabled (`true`) or disabled (`false`)
     */
    enabled?: pulumi.Input<boolean>;
    /**
     * Restricts the metric usage to the specified service. This field is mutually exclusive with the `management_zones` field
     */
    entityId?: pulumi.Input<string>;
    /**
     * Metric should (true) or not (false) ignore muted requests.
     */
    ignoreMutedRequests?: pulumi.Input<boolean>;
    /**
     * Restricts the metric usage to specified management zones. This field is mutually exclusive with the `entity_id` field
     */
    managementZones?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The definition of a calculated service metric
     */
    metricDefinition?: pulumi.Input<inputs.CalculatedServiceMetricMetricDefinition>;
    /**
     * The key of the calculated service metric
     */
    metricKey?: pulumi.Input<string>;
    /**
     * The displayed name of the metric
     */
    name?: pulumi.Input<string>;
    /**
     * The unit of the metric. Possible values are `BIT`, `BIT_PER_HOUR`, `BIT_PER_MINUTE`, `BIT_PER_SECOND`, `BYTE`,
     * `BYTE_PER_HOUR`, `BYTE_PER_MINUTE`, `BYTE_PER_SECOND`, `CORES`, `COUNT`, `DAY`, `DECIBEL_MILLI_WATT`, `GIBI_BYTE`,
     * `GIGA`, `GIGA_BYTE`, `HOUR`, `KIBI_BYTE`, `KIBI_BYTE_PER_HOUR`, `KIBI_BYTE_PER_MINUTE`, `KIBI_BYTE_PER_SECOND`, `KILO`,
     * `KILO_BYTE`, `KILO_BYTE_PER_HOUR`, `KILO_BYTE_PER_MINUTE`, `KILO_BYTE_PER_SECOND`, `MEBI_BYTE`, `MEBI_BYTE_PER_HOUR`,
     * `MEBI_BYTE_PER_MINUTE`, `MEBI_BYTE_PER_SECOND`, `MEGA`, `MEGA_BYTE`, `MEGA_BYTE_PER_HOUR`, `MEGA_BYTE_PER_MINUTE`,
     * `MEGA_BYTE_PER_SECOND`, `MICRO_SECOND`, `MILLI_CORES`, `MILLI_SECOND`, `MILLI_SECOND_PER_MINUTE`, `MINUTE`, `MONTH`,
     * `MSU`, `NANO_SECOND`, `NANO_SECOND_PER_MINUTE`, `NOT_APPLICABLE`, `PERCENT`, `PER_HOUR`, `PER_MINUTE`, `PER_SECOND`,
     * `PIXEL`, `PROMILLE`, `RATIO`, `SECOND`, `STATE`, `UNSPECIFIED`, `WEEK` and `YEAR`
     */
    unit?: pulumi.Input<string>;
    /**
     * The display name of the metric's unit. Only applicable when the **unit** parameter is set to `UNSPECIFIED`
     */
    unitDisplayName?: pulumi.Input<string>;
    /**
     * allows for configuring properties that are not explicitly supported by the current version of this provider
     */
    unknowns?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a CalculatedServiceMetric resource.
 */
export interface CalculatedServiceMetricArgs {
    /**
     * The set of conditions for the metric usage. **All** the specified conditions must be fulfilled to use the metric
     */
    conditions?: pulumi.Input<pulumi.Input<inputs.CalculatedServiceMetricCondition>[]>;
    /**
     * The displayed description of the metric
     */
    description?: pulumi.Input<string>;
    /**
     * Parameters of a definition of a calculated service metric
     */
    dimensionDefinition?: pulumi.Input<inputs.CalculatedServiceMetricDimensionDefinition>;
    /**
     * The metric is enabled (`true`) or disabled (`false`)
     */
    enabled?: pulumi.Input<boolean>;
    /**
     * Restricts the metric usage to the specified service. This field is mutually exclusive with the `management_zones` field
     */
    entityId?: pulumi.Input<string>;
    /**
     * Metric should (true) or not (false) ignore muted requests.
     */
    ignoreMutedRequests?: pulumi.Input<boolean>;
    /**
     * Restricts the metric usage to specified management zones. This field is mutually exclusive with the `entity_id` field
     */
    managementZones?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The definition of a calculated service metric
     */
    metricDefinition?: pulumi.Input<inputs.CalculatedServiceMetricMetricDefinition>;
    /**
     * The key of the calculated service metric
     */
    metricKey: pulumi.Input<string>;
    /**
     * The displayed name of the metric
     */
    name?: pulumi.Input<string>;
    /**
     * The unit of the metric. Possible values are `BIT`, `BIT_PER_HOUR`, `BIT_PER_MINUTE`, `BIT_PER_SECOND`, `BYTE`,
     * `BYTE_PER_HOUR`, `BYTE_PER_MINUTE`, `BYTE_PER_SECOND`, `CORES`, `COUNT`, `DAY`, `DECIBEL_MILLI_WATT`, `GIBI_BYTE`,
     * `GIGA`, `GIGA_BYTE`, `HOUR`, `KIBI_BYTE`, `KIBI_BYTE_PER_HOUR`, `KIBI_BYTE_PER_MINUTE`, `KIBI_BYTE_PER_SECOND`, `KILO`,
     * `KILO_BYTE`, `KILO_BYTE_PER_HOUR`, `KILO_BYTE_PER_MINUTE`, `KILO_BYTE_PER_SECOND`, `MEBI_BYTE`, `MEBI_BYTE_PER_HOUR`,
     * `MEBI_BYTE_PER_MINUTE`, `MEBI_BYTE_PER_SECOND`, `MEGA`, `MEGA_BYTE`, `MEGA_BYTE_PER_HOUR`, `MEGA_BYTE_PER_MINUTE`,
     * `MEGA_BYTE_PER_SECOND`, `MICRO_SECOND`, `MILLI_CORES`, `MILLI_SECOND`, `MILLI_SECOND_PER_MINUTE`, `MINUTE`, `MONTH`,
     * `MSU`, `NANO_SECOND`, `NANO_SECOND_PER_MINUTE`, `NOT_APPLICABLE`, `PERCENT`, `PER_HOUR`, `PER_MINUTE`, `PER_SECOND`,
     * `PIXEL`, `PROMILLE`, `RATIO`, `SECOND`, `STATE`, `UNSPECIFIED`, `WEEK` and `YEAR`
     */
    unit: pulumi.Input<string>;
    /**
     * The display name of the metric's unit. Only applicable when the **unit** parameter is set to `UNSPECIFIED`
     */
    unitDisplayName?: pulumi.Input<string>;
    /**
     * allows for configuring properties that are not explicitly supported by the current version of this provider
     */
    unknowns?: pulumi.Input<string>;
}
