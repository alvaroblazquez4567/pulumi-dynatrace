// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * > This resource is excluded by default in the export utility since it is part of the account management API. You can, of course, specify that resource explicitly in order to export it. In that case, don't forget to specify the environment variables `DT_CLIENT_ID`, `DT_ACCOUNT_ID` and `DT_CLIENT_SECRET` for authentication.
 *
 * > This resource requires the API token scope **Allow IAM policy configuration for environments** (`iam-policies-management`)
 *
 * ## Dynatrace Documentation
 *
 * - Dynatrace IAM Group Permissions - https://www.dynatrace.com/support/help/manage/access-control/user-management-and-sso/manage-groups-and-permissions/iam/iam-group-mgt
 *
 * - Settings API - https://www.dynatrace.com/support/help/how-to-use-dynatrace/user-management-and-sso/manage-groups-and-permissions/iam/iam-getting-started
 *
 * ## Prerequisites
 *
 * Using this resource requires an OAuth client to be configured within your account settings.
 * The scopes of the OAuth Client need to include `account-idm-read`, `account-idm-write`, `account-env-read`, `account-env-write`, `iam-policies-management`, `iam:policies:write`, `iam:policies:read`, `iam:bindings:write`, `iam:bindings:read` and `iam:effective-permissions:read`.
 *
 * Finally the provider configuration requires the credentials for that OAuth Client.
 * The configuration section of your provider needs to look like this.
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * ```
 */
export class IamPolicyBindingsV2 extends pulumi.CustomResource {
    /**
     * Get an existing IamPolicyBindingsV2 resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: IamPolicyBindingsV2State, opts?: pulumi.CustomResourceOptions): IamPolicyBindingsV2 {
        return new IamPolicyBindingsV2(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/iamPolicyBindingsV2:IamPolicyBindingsV2';

    /**
     * Returns true if the given object is an instance of IamPolicyBindingsV2.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is IamPolicyBindingsV2 {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === IamPolicyBindingsV2.__pulumiType;
    }

    /**
     * The UUID of the account (`urn:dtaccount:<account-uuid>`). The attribute `policies` must contain ONLY policies defined for that account. The prefix `urn:dtaccount:` MUST be omitted here.
     */
    public readonly account!: pulumi.Output<string | undefined>;
    /**
     * The ID of the environment (https://\n\n.live.dynatrace.com). The attribute `policies` must contain ONLY policies defined for that environment.
     */
    public readonly environment!: pulumi.Output<string | undefined>;
    /**
     * The name of the policy
     */
    public readonly group!: pulumi.Output<string>;
    /**
     * A list of Policies (ID and parameters/metadata) referring to policies bound to that group. It's not possible to mix policies here that are defined for different scopes (different accounts or environments) than specified via attributes `account` or `environment`.
     */
    public readonly policies!: pulumi.Output<outputs.IamPolicyBindingsV2Policy[] | undefined>;

    /**
     * Create a IamPolicyBindingsV2 resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: IamPolicyBindingsV2Args, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: IamPolicyBindingsV2Args | IamPolicyBindingsV2State, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as IamPolicyBindingsV2State | undefined;
            resourceInputs["account"] = state ? state.account : undefined;
            resourceInputs["environment"] = state ? state.environment : undefined;
            resourceInputs["group"] = state ? state.group : undefined;
            resourceInputs["policies"] = state ? state.policies : undefined;
        } else {
            const args = argsOrState as IamPolicyBindingsV2Args | undefined;
            if ((!args || args.group === undefined) && !opts.urn) {
                throw new Error("Missing required property 'group'");
            }
            resourceInputs["account"] = args ? args.account : undefined;
            resourceInputs["environment"] = args ? args.environment : undefined;
            resourceInputs["group"] = args ? args.group : undefined;
            resourceInputs["policies"] = args ? args.policies : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(IamPolicyBindingsV2.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering IamPolicyBindingsV2 resources.
 */
export interface IamPolicyBindingsV2State {
    /**
     * The UUID of the account (`urn:dtaccount:<account-uuid>`). The attribute `policies` must contain ONLY policies defined for that account. The prefix `urn:dtaccount:` MUST be omitted here.
     */
    account?: pulumi.Input<string>;
    /**
     * The ID of the environment (https://\n\n.live.dynatrace.com). The attribute `policies` must contain ONLY policies defined for that environment.
     */
    environment?: pulumi.Input<string>;
    /**
     * The name of the policy
     */
    group?: pulumi.Input<string>;
    /**
     * A list of Policies (ID and parameters/metadata) referring to policies bound to that group. It's not possible to mix policies here that are defined for different scopes (different accounts or environments) than specified via attributes `account` or `environment`.
     */
    policies?: pulumi.Input<pulumi.Input<inputs.IamPolicyBindingsV2Policy>[]>;
}

/**
 * The set of arguments for constructing a IamPolicyBindingsV2 resource.
 */
export interface IamPolicyBindingsV2Args {
    /**
     * The UUID of the account (`urn:dtaccount:<account-uuid>`). The attribute `policies` must contain ONLY policies defined for that account. The prefix `urn:dtaccount:` MUST be omitted here.
     */
    account?: pulumi.Input<string>;
    /**
     * The ID of the environment (https://\n\n.live.dynatrace.com). The attribute `policies` must contain ONLY policies defined for that environment.
     */
    environment?: pulumi.Input<string>;
    /**
     * The name of the policy
     */
    group: pulumi.Input<string>;
    /**
     * A list of Policies (ID and parameters/metadata) referring to policies bound to that group. It's not possible to mix policies here that are defined for different scopes (different accounts or environments) than specified via attributes `account` or `environment`.
     */
    policies?: pulumi.Input<pulumi.Input<inputs.IamPolicyBindingsV2Policy>[]>;
}
