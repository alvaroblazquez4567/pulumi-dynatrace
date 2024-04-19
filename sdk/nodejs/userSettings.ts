// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class UserSettings extends pulumi.CustomResource {
    /**
     * Get an existing UserSettings resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: UserSettingsState, opts?: pulumi.CustomResourceOptions): UserSettings {
        return new UserSettings(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/userSettings:UserSettings';

    /**
     * Returns true if the given object is an instance of UserSettings.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is UserSettings {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === UserSettings.__pulumiType;
    }

    /**
     * Language - use browser default
     */
    public readonly autoLanguage!: pulumi.Output<boolean>;
    /**
     * Region - use browser default
     */
    public readonly autoRegion!: pulumi.Output<boolean>;
    /**
     * Theme - use browser default
     */
    public readonly autoTheme!: pulumi.Output<boolean>;
    /**
     * Timezone - use browser default
     */
    public readonly autoTimezone!: pulumi.Output<boolean>;
    /**
     * Possible Values: `En`, `Ja`
     */
    public readonly language!: pulumi.Output<string | undefined>;
    /**
     * Region
     */
    public readonly region!: pulumi.Output<string | undefined>;
    /**
     * The scope of this setting (user, userdefaults)
     */
    public readonly scope!: pulumi.Output<string>;
    /**
     * Possible Values: `Dark`, `Light`
     */
    public readonly theme!: pulumi.Output<string | undefined>;
    /**
     * Timezone
     */
    public readonly timezone!: pulumi.Output<string | undefined>;

    /**
     * Create a UserSettings resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: UserSettingsArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: UserSettingsArgs | UserSettingsState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as UserSettingsState | undefined;
            resourceInputs["autoLanguage"] = state ? state.autoLanguage : undefined;
            resourceInputs["autoRegion"] = state ? state.autoRegion : undefined;
            resourceInputs["autoTheme"] = state ? state.autoTheme : undefined;
            resourceInputs["autoTimezone"] = state ? state.autoTimezone : undefined;
            resourceInputs["language"] = state ? state.language : undefined;
            resourceInputs["region"] = state ? state.region : undefined;
            resourceInputs["scope"] = state ? state.scope : undefined;
            resourceInputs["theme"] = state ? state.theme : undefined;
            resourceInputs["timezone"] = state ? state.timezone : undefined;
        } else {
            const args = argsOrState as UserSettingsArgs | undefined;
            if ((!args || args.autoLanguage === undefined) && !opts.urn) {
                throw new Error("Missing required property 'autoLanguage'");
            }
            if ((!args || args.autoRegion === undefined) && !opts.urn) {
                throw new Error("Missing required property 'autoRegion'");
            }
            if ((!args || args.autoTheme === undefined) && !opts.urn) {
                throw new Error("Missing required property 'autoTheme'");
            }
            if ((!args || args.autoTimezone === undefined) && !opts.urn) {
                throw new Error("Missing required property 'autoTimezone'");
            }
            if ((!args || args.scope === undefined) && !opts.urn) {
                throw new Error("Missing required property 'scope'");
            }
            resourceInputs["autoLanguage"] = args ? args.autoLanguage : undefined;
            resourceInputs["autoRegion"] = args ? args.autoRegion : undefined;
            resourceInputs["autoTheme"] = args ? args.autoTheme : undefined;
            resourceInputs["autoTimezone"] = args ? args.autoTimezone : undefined;
            resourceInputs["language"] = args ? args.language : undefined;
            resourceInputs["region"] = args ? args.region : undefined;
            resourceInputs["scope"] = args ? args.scope : undefined;
            resourceInputs["theme"] = args ? args.theme : undefined;
            resourceInputs["timezone"] = args ? args.timezone : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(UserSettings.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering UserSettings resources.
 */
export interface UserSettingsState {
    /**
     * Language - use browser default
     */
    autoLanguage?: pulumi.Input<boolean>;
    /**
     * Region - use browser default
     */
    autoRegion?: pulumi.Input<boolean>;
    /**
     * Theme - use browser default
     */
    autoTheme?: pulumi.Input<boolean>;
    /**
     * Timezone - use browser default
     */
    autoTimezone?: pulumi.Input<boolean>;
    /**
     * Possible Values: `En`, `Ja`
     */
    language?: pulumi.Input<string>;
    /**
     * Region
     */
    region?: pulumi.Input<string>;
    /**
     * The scope of this setting (user, userdefaults)
     */
    scope?: pulumi.Input<string>;
    /**
     * Possible Values: `Dark`, `Light`
     */
    theme?: pulumi.Input<string>;
    /**
     * Timezone
     */
    timezone?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a UserSettings resource.
 */
export interface UserSettingsArgs {
    /**
     * Language - use browser default
     */
    autoLanguage: pulumi.Input<boolean>;
    /**
     * Region - use browser default
     */
    autoRegion: pulumi.Input<boolean>;
    /**
     * Theme - use browser default
     */
    autoTheme: pulumi.Input<boolean>;
    /**
     * Timezone - use browser default
     */
    autoTimezone: pulumi.Input<boolean>;
    /**
     * Possible Values: `En`, `Ja`
     */
    language?: pulumi.Input<string>;
    /**
     * Region
     */
    region?: pulumi.Input<string>;
    /**
     * The scope of this setting (user, userdefaults)
     */
    scope: pulumi.Input<string>;
    /**
     * Possible Values: `Dark`, `Light`
     */
    theme?: pulumi.Input<string>;
    /**
     * Timezone
     */
    timezone?: pulumi.Input<string>;
}
