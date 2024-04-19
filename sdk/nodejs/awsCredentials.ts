// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class AwsCredentials extends pulumi.CustomResource {
    /**
     * Get an existing AwsCredentials resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AwsCredentialsState, opts?: pulumi.CustomResourceOptions): AwsCredentials {
        return new AwsCredentials(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/awsCredentials:AwsCredentials';

    /**
     * Returns true if the given object is an instance of AwsCredentials.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AwsCredentials {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AwsCredentials.__pulumiType;
    }

    /**
     * credentials for the AWS authentication
     */
    public readonly authenticationData!: pulumi.Output<outputs.AwsCredentialsAuthenticationData>;
    /**
     * The name of the credentials
     */
    public readonly label!: pulumi.Output<string | undefined>;
    /**
     * The type of the AWS partition
     */
    public readonly partitionType!: pulumi.Output<string>;
    /**
     * Instructs the provider to remove the supporting services Dynatrace applies by default to newly created AWS Credentials. Supporting Services applied by via `dynatrace.AwsService` subsequently won't get touched.
     */
    public readonly removeDefaults!: pulumi.Output<boolean | undefined>;
    /**
     * If enabled (`true`) the attribute `supporting_services` will not get synchronized with Dynatrace. You will be able to
     * manage them via WebUI without interference by Terraform.
     *
     * @deprecated Supporting Services are no longer getting managed via this resource. Regardless of the value set here, this resource won't affect the supporting services during updates
     */
    public readonly supportingServicesManagedInDynatrace!: pulumi.Output<boolean | undefined>;
    /**
     * supporting services to be monitored
     *
     * @deprecated Managing supporting services directly within AWS Credentials has been deprecated within the REST API. This attribute just exists for backwards compatibility. It no longer has an effect. For managing services use the resource `dynatrace_aws_service`
     */
    public readonly supportingServicesToMonitors!: pulumi.Output<outputs.AwsCredentialsSupportingServicesToMonitor[] | undefined>;
    /**
     * Monitor only resources which have specified AWS tags (`true`) or all resources (`false`)
     */
    public readonly taggedOnly!: pulumi.Output<boolean>;
    /**
     * AWS tags to be monitored. You can specify up to 10 tags. Only applicable when the **tagged_only** parameter is set to `true`
     */
    public readonly tagsToMonitors!: pulumi.Output<outputs.AwsCredentialsTagsToMonitor[] | undefined>;
    /**
     * Any attributes that aren't yet supported by this provider
     */
    public readonly unknowns!: pulumi.Output<string | undefined>;

    /**
     * Create a AwsCredentials resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AwsCredentialsArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: AwsCredentialsArgs | AwsCredentialsState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as AwsCredentialsState | undefined;
            resourceInputs["authenticationData"] = state ? state.authenticationData : undefined;
            resourceInputs["label"] = state ? state.label : undefined;
            resourceInputs["partitionType"] = state ? state.partitionType : undefined;
            resourceInputs["removeDefaults"] = state ? state.removeDefaults : undefined;
            resourceInputs["supportingServicesManagedInDynatrace"] = state ? state.supportingServicesManagedInDynatrace : undefined;
            resourceInputs["supportingServicesToMonitors"] = state ? state.supportingServicesToMonitors : undefined;
            resourceInputs["taggedOnly"] = state ? state.taggedOnly : undefined;
            resourceInputs["tagsToMonitors"] = state ? state.tagsToMonitors : undefined;
            resourceInputs["unknowns"] = state ? state.unknowns : undefined;
        } else {
            const args = argsOrState as AwsCredentialsArgs | undefined;
            if ((!args || args.authenticationData === undefined) && !opts.urn) {
                throw new Error("Missing required property 'authenticationData'");
            }
            if ((!args || args.partitionType === undefined) && !opts.urn) {
                throw new Error("Missing required property 'partitionType'");
            }
            if ((!args || args.taggedOnly === undefined) && !opts.urn) {
                throw new Error("Missing required property 'taggedOnly'");
            }
            resourceInputs["authenticationData"] = args ? args.authenticationData : undefined;
            resourceInputs["label"] = args ? args.label : undefined;
            resourceInputs["partitionType"] = args ? args.partitionType : undefined;
            resourceInputs["removeDefaults"] = args ? args.removeDefaults : undefined;
            resourceInputs["supportingServicesManagedInDynatrace"] = args ? args.supportingServicesManagedInDynatrace : undefined;
            resourceInputs["supportingServicesToMonitors"] = args ? args.supportingServicesToMonitors : undefined;
            resourceInputs["taggedOnly"] = args ? args.taggedOnly : undefined;
            resourceInputs["tagsToMonitors"] = args ? args.tagsToMonitors : undefined;
            resourceInputs["unknowns"] = args ? args.unknowns : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(AwsCredentials.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering AwsCredentials resources.
 */
export interface AwsCredentialsState {
    /**
     * credentials for the AWS authentication
     */
    authenticationData?: pulumi.Input<inputs.AwsCredentialsAuthenticationData>;
    /**
     * The name of the credentials
     */
    label?: pulumi.Input<string>;
    /**
     * The type of the AWS partition
     */
    partitionType?: pulumi.Input<string>;
    /**
     * Instructs the provider to remove the supporting services Dynatrace applies by default to newly created AWS Credentials. Supporting Services applied by via `dynatrace.AwsService` subsequently won't get touched.
     */
    removeDefaults?: pulumi.Input<boolean>;
    /**
     * If enabled (`true`) the attribute `supporting_services` will not get synchronized with Dynatrace. You will be able to
     * manage them via WebUI without interference by Terraform.
     *
     * @deprecated Supporting Services are no longer getting managed via this resource. Regardless of the value set here, this resource won't affect the supporting services during updates
     */
    supportingServicesManagedInDynatrace?: pulumi.Input<boolean>;
    /**
     * supporting services to be monitored
     *
     * @deprecated Managing supporting services directly within AWS Credentials has been deprecated within the REST API. This attribute just exists for backwards compatibility. It no longer has an effect. For managing services use the resource `dynatrace_aws_service`
     */
    supportingServicesToMonitors?: pulumi.Input<pulumi.Input<inputs.AwsCredentialsSupportingServicesToMonitor>[]>;
    /**
     * Monitor only resources which have specified AWS tags (`true`) or all resources (`false`)
     */
    taggedOnly?: pulumi.Input<boolean>;
    /**
     * AWS tags to be monitored. You can specify up to 10 tags. Only applicable when the **tagged_only** parameter is set to `true`
     */
    tagsToMonitors?: pulumi.Input<pulumi.Input<inputs.AwsCredentialsTagsToMonitor>[]>;
    /**
     * Any attributes that aren't yet supported by this provider
     */
    unknowns?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a AwsCredentials resource.
 */
export interface AwsCredentialsArgs {
    /**
     * credentials for the AWS authentication
     */
    authenticationData: pulumi.Input<inputs.AwsCredentialsAuthenticationData>;
    /**
     * The name of the credentials
     */
    label?: pulumi.Input<string>;
    /**
     * The type of the AWS partition
     */
    partitionType: pulumi.Input<string>;
    /**
     * Instructs the provider to remove the supporting services Dynatrace applies by default to newly created AWS Credentials. Supporting Services applied by via `dynatrace.AwsService` subsequently won't get touched.
     */
    removeDefaults?: pulumi.Input<boolean>;
    /**
     * If enabled (`true`) the attribute `supporting_services` will not get synchronized with Dynatrace. You will be able to
     * manage them via WebUI without interference by Terraform.
     *
     * @deprecated Supporting Services are no longer getting managed via this resource. Regardless of the value set here, this resource won't affect the supporting services during updates
     */
    supportingServicesManagedInDynatrace?: pulumi.Input<boolean>;
    /**
     * supporting services to be monitored
     *
     * @deprecated Managing supporting services directly within AWS Credentials has been deprecated within the REST API. This attribute just exists for backwards compatibility. It no longer has an effect. For managing services use the resource `dynatrace_aws_service`
     */
    supportingServicesToMonitors?: pulumi.Input<pulumi.Input<inputs.AwsCredentialsSupportingServicesToMonitor>[]>;
    /**
     * Monitor only resources which have specified AWS tags (`true`) or all resources (`false`)
     */
    taggedOnly: pulumi.Input<boolean>;
    /**
     * AWS tags to be monitored. You can specify up to 10 tags. Only applicable when the **tagged_only** parameter is set to `true`
     */
    tagsToMonitors?: pulumi.Input<pulumi.Input<inputs.AwsCredentialsTagsToMonitor>[]>;
    /**
     * Any attributes that aren't yet supported by this provider
     */
    unknowns?: pulumi.Input<string>;
}