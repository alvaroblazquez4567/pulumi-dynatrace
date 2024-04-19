// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class Credentials extends pulumi.CustomResource {
    /**
     * Get an existing Credentials resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: CredentialsState, opts?: pulumi.CustomResourceOptions): Credentials {
        return new Credentials(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/credentials:Credentials';

    /**
     * Returns true if the given object is an instance of Credentials.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Credentials {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Credentials.__pulumiType;
    }

    /**
     * Allow ad-hoc functions to access the credential details (requires the APP_ENGINE scope).
     */
    public readonly allowContextlessRequests!: pulumi.Output<boolean | undefined>;
    /**
     * Required for Hashicorp Certificate. The ID of Credentials within the Certificate Vault holding the certificate
     */
    public readonly certificate!: pulumi.Output<string | undefined>;
    /**
     * The list contains summary data related to the use of credentials
     *
     * @deprecated `credential_usage_summary` will be removed in future versions. It's not getting filled anymore, because it's runtime data
     */
    public readonly credentialUsageSummaries!: pulumi.Output<outputs.CredentialsCredentialUsageSummary[] | undefined>;
    /**
     * A short description of the credentials set
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * External Vault Configuration
     */
    public readonly external!: pulumi.Output<outputs.CredentialsExternal | undefined>;
    /**
     * The certificate format. Possible values are `PEM`, `PKCS12` and `UNKNOWN`.
     */
    public readonly format!: pulumi.Output<string | undefined>;
    /**
     * The name of the credentials set
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The credentials set is available to every user (`false`) or to owner only (`true`)
     */
    public readonly ownerAccessOnly!: pulumi.Output<boolean | undefined>;
    /**
     * The password of the credential. Note: Terraform treats an empty string for a value as if the attribute was absent. If
     * you want to set an empty password, use the value `--empty--`.
     */
    public readonly password!: pulumi.Output<string | undefined>;
    /**
     * For certificate authentication specifies whether it's public certificate auth (`true`) or not (`false`).
     */
    public readonly public!: pulumi.Output<boolean | undefined>;
    /**
     * The scope of the credentials set. Possible values are `ALL`, `EXTENSION` and `SYNTHETIC`
     *
     * @deprecated Deprecated(v279), please use `scopes` instead.
     */
    public readonly scope!: pulumi.Output<string | undefined>;
    /**
     * The set of scopes of the credentials set. Possible values are `ALL`, `EXTENSION` and `SYNTHETIC`
     */
    public readonly scopes!: pulumi.Output<string[] | undefined>;
    /**
     * Token in the string format. Specifying a token implies `Token Authentication`.
     */
    public readonly token!: pulumi.Output<string | undefined>;
    /**
     * The username of the credentials set.
     */
    public readonly username!: pulumi.Output<string | undefined>;

    /**
     * Create a Credentials resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: CredentialsArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: CredentialsArgs | CredentialsState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as CredentialsState | undefined;
            resourceInputs["allowContextlessRequests"] = state ? state.allowContextlessRequests : undefined;
            resourceInputs["certificate"] = state ? state.certificate : undefined;
            resourceInputs["credentialUsageSummaries"] = state ? state.credentialUsageSummaries : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["external"] = state ? state.external : undefined;
            resourceInputs["format"] = state ? state.format : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["ownerAccessOnly"] = state ? state.ownerAccessOnly : undefined;
            resourceInputs["password"] = state ? state.password : undefined;
            resourceInputs["public"] = state ? state.public : undefined;
            resourceInputs["scope"] = state ? state.scope : undefined;
            resourceInputs["scopes"] = state ? state.scopes : undefined;
            resourceInputs["token"] = state ? state.token : undefined;
            resourceInputs["username"] = state ? state.username : undefined;
        } else {
            const args = argsOrState as CredentialsArgs | undefined;
            resourceInputs["allowContextlessRequests"] = args ? args.allowContextlessRequests : undefined;
            resourceInputs["certificate"] = args ? args.certificate : undefined;
            resourceInputs["credentialUsageSummaries"] = args ? args.credentialUsageSummaries : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["external"] = args ? args.external : undefined;
            resourceInputs["format"] = args ? args.format : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["ownerAccessOnly"] = args ? args.ownerAccessOnly : undefined;
            resourceInputs["password"] = args?.password ? pulumi.secret(args.password) : undefined;
            resourceInputs["public"] = args ? args.public : undefined;
            resourceInputs["scope"] = args ? args.scope : undefined;
            resourceInputs["scopes"] = args ? args.scopes : undefined;
            resourceInputs["token"] = args?.token ? pulumi.secret(args.token) : undefined;
            resourceInputs["username"] = args?.username ? pulumi.secret(args.username) : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const secretOpts = { additionalSecretOutputs: ["password", "token", "username"] };
        opts = pulumi.mergeOptions(opts, secretOpts);
        super(Credentials.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Credentials resources.
 */
export interface CredentialsState {
    /**
     * Allow ad-hoc functions to access the credential details (requires the APP_ENGINE scope).
     */
    allowContextlessRequests?: pulumi.Input<boolean>;
    /**
     * Required for Hashicorp Certificate. The ID of Credentials within the Certificate Vault holding the certificate
     */
    certificate?: pulumi.Input<string>;
    /**
     * The list contains summary data related to the use of credentials
     *
     * @deprecated `credential_usage_summary` will be removed in future versions. It's not getting filled anymore, because it's runtime data
     */
    credentialUsageSummaries?: pulumi.Input<pulumi.Input<inputs.CredentialsCredentialUsageSummary>[]>;
    /**
     * A short description of the credentials set
     */
    description?: pulumi.Input<string>;
    /**
     * External Vault Configuration
     */
    external?: pulumi.Input<inputs.CredentialsExternal>;
    /**
     * The certificate format. Possible values are `PEM`, `PKCS12` and `UNKNOWN`.
     */
    format?: pulumi.Input<string>;
    /**
     * The name of the credentials set
     */
    name?: pulumi.Input<string>;
    /**
     * The credentials set is available to every user (`false`) or to owner only (`true`)
     */
    ownerAccessOnly?: pulumi.Input<boolean>;
    /**
     * The password of the credential. Note: Terraform treats an empty string for a value as if the attribute was absent. If
     * you want to set an empty password, use the value `--empty--`.
     */
    password?: pulumi.Input<string>;
    /**
     * For certificate authentication specifies whether it's public certificate auth (`true`) or not (`false`).
     */
    public?: pulumi.Input<boolean>;
    /**
     * The scope of the credentials set. Possible values are `ALL`, `EXTENSION` and `SYNTHETIC`
     *
     * @deprecated Deprecated(v279), please use `scopes` instead.
     */
    scope?: pulumi.Input<string>;
    /**
     * The set of scopes of the credentials set. Possible values are `ALL`, `EXTENSION` and `SYNTHETIC`
     */
    scopes?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Token in the string format. Specifying a token implies `Token Authentication`.
     */
    token?: pulumi.Input<string>;
    /**
     * The username of the credentials set.
     */
    username?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Credentials resource.
 */
export interface CredentialsArgs {
    /**
     * Allow ad-hoc functions to access the credential details (requires the APP_ENGINE scope).
     */
    allowContextlessRequests?: pulumi.Input<boolean>;
    /**
     * Required for Hashicorp Certificate. The ID of Credentials within the Certificate Vault holding the certificate
     */
    certificate?: pulumi.Input<string>;
    /**
     * The list contains summary data related to the use of credentials
     *
     * @deprecated `credential_usage_summary` will be removed in future versions. It's not getting filled anymore, because it's runtime data
     */
    credentialUsageSummaries?: pulumi.Input<pulumi.Input<inputs.CredentialsCredentialUsageSummary>[]>;
    /**
     * A short description of the credentials set
     */
    description?: pulumi.Input<string>;
    /**
     * External Vault Configuration
     */
    external?: pulumi.Input<inputs.CredentialsExternal>;
    /**
     * The certificate format. Possible values are `PEM`, `PKCS12` and `UNKNOWN`.
     */
    format?: pulumi.Input<string>;
    /**
     * The name of the credentials set
     */
    name?: pulumi.Input<string>;
    /**
     * The credentials set is available to every user (`false`) or to owner only (`true`)
     */
    ownerAccessOnly?: pulumi.Input<boolean>;
    /**
     * The password of the credential. Note: Terraform treats an empty string for a value as if the attribute was absent. If
     * you want to set an empty password, use the value `--empty--`.
     */
    password?: pulumi.Input<string>;
    /**
     * For certificate authentication specifies whether it's public certificate auth (`true`) or not (`false`).
     */
    public?: pulumi.Input<boolean>;
    /**
     * The scope of the credentials set. Possible values are `ALL`, `EXTENSION` and `SYNTHETIC`
     *
     * @deprecated Deprecated(v279), please use `scopes` instead.
     */
    scope?: pulumi.Input<string>;
    /**
     * The set of scopes of the credentials set. Possible values are `ALL`, `EXTENSION` and `SYNTHETIC`
     */
    scopes?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Token in the string format. Specifying a token implies `Token Authentication`.
     */
    token?: pulumi.Input<string>;
    /**
     * The username of the credentials set.
     */
    username?: pulumi.Input<string>;
}