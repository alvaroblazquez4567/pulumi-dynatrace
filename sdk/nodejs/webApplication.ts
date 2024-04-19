// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class WebApplication extends pulumi.CustomResource {
    /**
     * Get an existing WebApplication resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: WebApplicationState, opts?: pulumi.CustomResourceOptions): WebApplication {
        return new WebApplication(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/webApplication:WebApplication';

    /**
     * Returns true if the given object is an instance of WebApplication.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is WebApplication {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === WebApplication.__pulumiType;
    }

    /**
     * A list of conversion goals of the application
     */
    public readonly conversionGoals!: pulumi.Output<outputs.WebApplicationConversionGoals | undefined>;
    /**
     * (Field has overlap with `dynatrace.WebAppEnablement`) Analize *X*% of user sessions
     */
    public readonly costControlUserSessionPercentage!: pulumi.Output<number>;
    /**
     * Defines the Custom Action Apdex settings of an application
     */
    public readonly customActionApdexSettings!: pulumi.Output<outputs.WebApplicationCustomActionApdexSettings>;
    /**
     * User Action names to be flagged as Key User Actions
     *
     * @deprecated Configuring Key User Actions within `dynatrace_web_application` is discouraged. Use the dedicated resource `dynatrace_key_user_action` instead.
     */
    public readonly keyUserActions!: pulumi.Output<outputs.WebApplicationKeyUserAction[] | undefined>;
    /**
     * Defines the Load Action Apdex settings of an application
     */
    public readonly loadActionApdexSettings!: pulumi.Output<outputs.WebApplicationLoadActionApdexSettings>;
    /**
     * The key performance metric of load actions. Possible values are `ACTION_DURATION`, `CUMULATIVE_LAYOUT_SHIFT`, `DOM_INTERACTIVE`, `FIRST_INPUT_DELAY`, `LARGEST_CONTENTFUL_PAINT`, `LOAD_EVENT_END`, `LOAD_EVENT_START`, `RESPONSE_END`, `RESPONSE_START`, `SPEED_INDEX` and `VISUALLY_COMPLETE`
     */
    public readonly loadActionKeyPerformanceMetric!: pulumi.Output<string>;
    /**
     * Java script agent meta data capture settings
     */
    public readonly metaDataCaptureSettings!: pulumi.Output<outputs.WebApplicationMetaDataCaptureSettings | undefined>;
    /**
     * Real user monitoring settings
     */
    public readonly monitoringSettings!: pulumi.Output<outputs.WebApplicationMonitoringSettings>;
    /**
     * The name of the conversion goal. Valid length within 1 and 50 characters.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * (Field has overlap with `dynatrace.WebAppEnablement`) Real user monitoring enabled/disabled
     */
    public readonly realUserMonitoringEnabled!: pulumi.Output<boolean | undefined>;
    /**
     * Settings regarding Session Replay
     */
    public readonly sessionReplayConfig!: pulumi.Output<outputs.WebApplicationSessionReplayConfig>;
    /**
     * The type of the action. Possible values are `Custom`, `Load` and `Xhr`.
     */
    public readonly type!: pulumi.Output<string>;
    /**
     * URL injection pattern for manual web application
     */
    public readonly urlInjectionPattern!: pulumi.Output<string | undefined>;
    /**
     * User action and session properties settings
     */
    public readonly userActionAndSessionProperties!: pulumi.Output<outputs.WebApplicationUserActionAndSessionProperties | undefined>;
    /**
     * The settings of user action naming
     */
    public readonly userActionNamingSettings!: pulumi.Output<outputs.WebApplicationUserActionNamingSettings | undefined>;
    /**
     * User tags settings
     */
    public readonly userTags!: pulumi.Output<outputs.WebApplicationUserTags | undefined>;
    /**
     * These settings influence the monitoring data you receive for 3rd party, CDN, and 1st party resources
     */
    public readonly waterfallSettings!: pulumi.Output<outputs.WebApplicationWaterfallSettings>;
    /**
     * Defines the XHR Action Apdex settings of an application
     */
    public readonly xhrActionApdexSettings!: pulumi.Output<outputs.WebApplicationXhrActionApdexSettings>;
    /**
     * The key performance metric of XHR actions. Possible values are `ACTION_DURATION`, `RESPONSE_END`, `RESPONSE_START` and `VISUALLY_COMPLETE`.
     */
    public readonly xhrActionKeyPerformanceMetric!: pulumi.Output<string>;

    /**
     * Create a WebApplication resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: WebApplicationArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: WebApplicationArgs | WebApplicationState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as WebApplicationState | undefined;
            resourceInputs["conversionGoals"] = state ? state.conversionGoals : undefined;
            resourceInputs["costControlUserSessionPercentage"] = state ? state.costControlUserSessionPercentage : undefined;
            resourceInputs["customActionApdexSettings"] = state ? state.customActionApdexSettings : undefined;
            resourceInputs["keyUserActions"] = state ? state.keyUserActions : undefined;
            resourceInputs["loadActionApdexSettings"] = state ? state.loadActionApdexSettings : undefined;
            resourceInputs["loadActionKeyPerformanceMetric"] = state ? state.loadActionKeyPerformanceMetric : undefined;
            resourceInputs["metaDataCaptureSettings"] = state ? state.metaDataCaptureSettings : undefined;
            resourceInputs["monitoringSettings"] = state ? state.monitoringSettings : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["realUserMonitoringEnabled"] = state ? state.realUserMonitoringEnabled : undefined;
            resourceInputs["sessionReplayConfig"] = state ? state.sessionReplayConfig : undefined;
            resourceInputs["type"] = state ? state.type : undefined;
            resourceInputs["urlInjectionPattern"] = state ? state.urlInjectionPattern : undefined;
            resourceInputs["userActionAndSessionProperties"] = state ? state.userActionAndSessionProperties : undefined;
            resourceInputs["userActionNamingSettings"] = state ? state.userActionNamingSettings : undefined;
            resourceInputs["userTags"] = state ? state.userTags : undefined;
            resourceInputs["waterfallSettings"] = state ? state.waterfallSettings : undefined;
            resourceInputs["xhrActionApdexSettings"] = state ? state.xhrActionApdexSettings : undefined;
            resourceInputs["xhrActionKeyPerformanceMetric"] = state ? state.xhrActionKeyPerformanceMetric : undefined;
        } else {
            const args = argsOrState as WebApplicationArgs | undefined;
            if ((!args || args.costControlUserSessionPercentage === undefined) && !opts.urn) {
                throw new Error("Missing required property 'costControlUserSessionPercentage'");
            }
            if ((!args || args.customActionApdexSettings === undefined) && !opts.urn) {
                throw new Error("Missing required property 'customActionApdexSettings'");
            }
            if ((!args || args.loadActionApdexSettings === undefined) && !opts.urn) {
                throw new Error("Missing required property 'loadActionApdexSettings'");
            }
            if ((!args || args.loadActionKeyPerformanceMetric === undefined) && !opts.urn) {
                throw new Error("Missing required property 'loadActionKeyPerformanceMetric'");
            }
            if ((!args || args.monitoringSettings === undefined) && !opts.urn) {
                throw new Error("Missing required property 'monitoringSettings'");
            }
            if ((!args || args.type === undefined) && !opts.urn) {
                throw new Error("Missing required property 'type'");
            }
            if ((!args || args.waterfallSettings === undefined) && !opts.urn) {
                throw new Error("Missing required property 'waterfallSettings'");
            }
            if ((!args || args.xhrActionApdexSettings === undefined) && !opts.urn) {
                throw new Error("Missing required property 'xhrActionApdexSettings'");
            }
            if ((!args || args.xhrActionKeyPerformanceMetric === undefined) && !opts.urn) {
                throw new Error("Missing required property 'xhrActionKeyPerformanceMetric'");
            }
            resourceInputs["conversionGoals"] = args ? args.conversionGoals : undefined;
            resourceInputs["costControlUserSessionPercentage"] = args ? args.costControlUserSessionPercentage : undefined;
            resourceInputs["customActionApdexSettings"] = args ? args.customActionApdexSettings : undefined;
            resourceInputs["keyUserActions"] = args ? args.keyUserActions : undefined;
            resourceInputs["loadActionApdexSettings"] = args ? args.loadActionApdexSettings : undefined;
            resourceInputs["loadActionKeyPerformanceMetric"] = args ? args.loadActionKeyPerformanceMetric : undefined;
            resourceInputs["metaDataCaptureSettings"] = args ? args.metaDataCaptureSettings : undefined;
            resourceInputs["monitoringSettings"] = args ? args.monitoringSettings : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["realUserMonitoringEnabled"] = args ? args.realUserMonitoringEnabled : undefined;
            resourceInputs["sessionReplayConfig"] = args ? args.sessionReplayConfig : undefined;
            resourceInputs["type"] = args ? args.type : undefined;
            resourceInputs["urlInjectionPattern"] = args ? args.urlInjectionPattern : undefined;
            resourceInputs["userActionAndSessionProperties"] = args ? args.userActionAndSessionProperties : undefined;
            resourceInputs["userActionNamingSettings"] = args ? args.userActionNamingSettings : undefined;
            resourceInputs["userTags"] = args ? args.userTags : undefined;
            resourceInputs["waterfallSettings"] = args ? args.waterfallSettings : undefined;
            resourceInputs["xhrActionApdexSettings"] = args ? args.xhrActionApdexSettings : undefined;
            resourceInputs["xhrActionKeyPerformanceMetric"] = args ? args.xhrActionKeyPerformanceMetric : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(WebApplication.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering WebApplication resources.
 */
export interface WebApplicationState {
    /**
     * A list of conversion goals of the application
     */
    conversionGoals?: pulumi.Input<inputs.WebApplicationConversionGoals>;
    /**
     * (Field has overlap with `dynatrace.WebAppEnablement`) Analize *X*% of user sessions
     */
    costControlUserSessionPercentage?: pulumi.Input<number>;
    /**
     * Defines the Custom Action Apdex settings of an application
     */
    customActionApdexSettings?: pulumi.Input<inputs.WebApplicationCustomActionApdexSettings>;
    /**
     * User Action names to be flagged as Key User Actions
     *
     * @deprecated Configuring Key User Actions within `dynatrace_web_application` is discouraged. Use the dedicated resource `dynatrace_key_user_action` instead.
     */
    keyUserActions?: pulumi.Input<pulumi.Input<inputs.WebApplicationKeyUserAction>[]>;
    /**
     * Defines the Load Action Apdex settings of an application
     */
    loadActionApdexSettings?: pulumi.Input<inputs.WebApplicationLoadActionApdexSettings>;
    /**
     * The key performance metric of load actions. Possible values are `ACTION_DURATION`, `CUMULATIVE_LAYOUT_SHIFT`, `DOM_INTERACTIVE`, `FIRST_INPUT_DELAY`, `LARGEST_CONTENTFUL_PAINT`, `LOAD_EVENT_END`, `LOAD_EVENT_START`, `RESPONSE_END`, `RESPONSE_START`, `SPEED_INDEX` and `VISUALLY_COMPLETE`
     */
    loadActionKeyPerformanceMetric?: pulumi.Input<string>;
    /**
     * Java script agent meta data capture settings
     */
    metaDataCaptureSettings?: pulumi.Input<inputs.WebApplicationMetaDataCaptureSettings>;
    /**
     * Real user monitoring settings
     */
    monitoringSettings?: pulumi.Input<inputs.WebApplicationMonitoringSettings>;
    /**
     * The name of the conversion goal. Valid length within 1 and 50 characters.
     */
    name?: pulumi.Input<string>;
    /**
     * (Field has overlap with `dynatrace.WebAppEnablement`) Real user monitoring enabled/disabled
     */
    realUserMonitoringEnabled?: pulumi.Input<boolean>;
    /**
     * Settings regarding Session Replay
     */
    sessionReplayConfig?: pulumi.Input<inputs.WebApplicationSessionReplayConfig>;
    /**
     * The type of the action. Possible values are `Custom`, `Load` and `Xhr`.
     */
    type?: pulumi.Input<string>;
    /**
     * URL injection pattern for manual web application
     */
    urlInjectionPattern?: pulumi.Input<string>;
    /**
     * User action and session properties settings
     */
    userActionAndSessionProperties?: pulumi.Input<inputs.WebApplicationUserActionAndSessionProperties>;
    /**
     * The settings of user action naming
     */
    userActionNamingSettings?: pulumi.Input<inputs.WebApplicationUserActionNamingSettings>;
    /**
     * User tags settings
     */
    userTags?: pulumi.Input<inputs.WebApplicationUserTags>;
    /**
     * These settings influence the monitoring data you receive for 3rd party, CDN, and 1st party resources
     */
    waterfallSettings?: pulumi.Input<inputs.WebApplicationWaterfallSettings>;
    /**
     * Defines the XHR Action Apdex settings of an application
     */
    xhrActionApdexSettings?: pulumi.Input<inputs.WebApplicationXhrActionApdexSettings>;
    /**
     * The key performance metric of XHR actions. Possible values are `ACTION_DURATION`, `RESPONSE_END`, `RESPONSE_START` and `VISUALLY_COMPLETE`.
     */
    xhrActionKeyPerformanceMetric?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a WebApplication resource.
 */
export interface WebApplicationArgs {
    /**
     * A list of conversion goals of the application
     */
    conversionGoals?: pulumi.Input<inputs.WebApplicationConversionGoals>;
    /**
     * (Field has overlap with `dynatrace.WebAppEnablement`) Analize *X*% of user sessions
     */
    costControlUserSessionPercentage: pulumi.Input<number>;
    /**
     * Defines the Custom Action Apdex settings of an application
     */
    customActionApdexSettings: pulumi.Input<inputs.WebApplicationCustomActionApdexSettings>;
    /**
     * User Action names to be flagged as Key User Actions
     *
     * @deprecated Configuring Key User Actions within `dynatrace_web_application` is discouraged. Use the dedicated resource `dynatrace_key_user_action` instead.
     */
    keyUserActions?: pulumi.Input<pulumi.Input<inputs.WebApplicationKeyUserAction>[]>;
    /**
     * Defines the Load Action Apdex settings of an application
     */
    loadActionApdexSettings: pulumi.Input<inputs.WebApplicationLoadActionApdexSettings>;
    /**
     * The key performance metric of load actions. Possible values are `ACTION_DURATION`, `CUMULATIVE_LAYOUT_SHIFT`, `DOM_INTERACTIVE`, `FIRST_INPUT_DELAY`, `LARGEST_CONTENTFUL_PAINT`, `LOAD_EVENT_END`, `LOAD_EVENT_START`, `RESPONSE_END`, `RESPONSE_START`, `SPEED_INDEX` and `VISUALLY_COMPLETE`
     */
    loadActionKeyPerformanceMetric: pulumi.Input<string>;
    /**
     * Java script agent meta data capture settings
     */
    metaDataCaptureSettings?: pulumi.Input<inputs.WebApplicationMetaDataCaptureSettings>;
    /**
     * Real user monitoring settings
     */
    monitoringSettings: pulumi.Input<inputs.WebApplicationMonitoringSettings>;
    /**
     * The name of the conversion goal. Valid length within 1 and 50 characters.
     */
    name?: pulumi.Input<string>;
    /**
     * (Field has overlap with `dynatrace.WebAppEnablement`) Real user monitoring enabled/disabled
     */
    realUserMonitoringEnabled?: pulumi.Input<boolean>;
    /**
     * Settings regarding Session Replay
     */
    sessionReplayConfig?: pulumi.Input<inputs.WebApplicationSessionReplayConfig>;
    /**
     * The type of the action. Possible values are `Custom`, `Load` and `Xhr`.
     */
    type: pulumi.Input<string>;
    /**
     * URL injection pattern for manual web application
     */
    urlInjectionPattern?: pulumi.Input<string>;
    /**
     * User action and session properties settings
     */
    userActionAndSessionProperties?: pulumi.Input<inputs.WebApplicationUserActionAndSessionProperties>;
    /**
     * The settings of user action naming
     */
    userActionNamingSettings?: pulumi.Input<inputs.WebApplicationUserActionNamingSettings>;
    /**
     * User tags settings
     */
    userTags?: pulumi.Input<inputs.WebApplicationUserTags>;
    /**
     * These settings influence the monitoring data you receive for 3rd party, CDN, and 1st party resources
     */
    waterfallSettings: pulumi.Input<inputs.WebApplicationWaterfallSettings>;
    /**
     * Defines the XHR Action Apdex settings of an application
     */
    xhrActionApdexSettings: pulumi.Input<inputs.WebApplicationXhrActionApdexSettings>;
    /**
     * The key performance metric of XHR actions. Possible values are `ACTION_DURATION`, `RESPONSE_END`, `RESPONSE_START` and `VISUALLY_COMPLETE`.
     */
    xhrActionKeyPerformanceMetric: pulumi.Input<string>;
}
