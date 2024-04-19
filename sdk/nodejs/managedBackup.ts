// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class ManagedBackup extends pulumi.CustomResource {
    /**
     * Get an existing ManagedBackup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ManagedBackupState, opts?: pulumi.CustomResourceOptions): ManagedBackup {
        return new ManagedBackup(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/managedBackup:ManagedBackup';

    /**
     * Returns true if the given object is an instance of ManagedBackup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ManagedBackup {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ManagedBackup.__pulumiType;
    }

    /**
     * Cassandra backup bandwidth limit in Mbps
     */
    public readonly bandwidthLimitMbits!: pulumi.Output<number | undefined>;
    /**
     * Hour to start Cassandra backups each day.
     */
    public readonly cassandraScheduledTime!: pulumi.Output<number>;
    /**
     * For internal use: current state of rules in JSON format
     */
    public readonly currentState!: pulumi.Output<string>;
    /**
     * Datacenter which will create backups
     */
    public readonly datacenter!: pulumi.Output<string | undefined>;
    /**
     * Backups are enabled (true) or disabled (false).
     */
    public readonly enabled!: pulumi.Output<boolean | undefined>;
    /**
     * Include (true) or exclude (false) Log Monitoring v2 data
     */
    public readonly includeLm20Data!: pulumi.Output<boolean | undefined>;
    /**
     * Include user sessions (true) or GDPR compliance (false)
     */
    public readonly includeRumData!: pulumi.Output<boolean | undefined>;
    /**
     * Include time series metric-data (true) or retain configuration data only (false))
     */
    public readonly includeTsMetricData!: pulumi.Output<boolean | undefined>;
    /**
     * Max number of Elasticsearch snapshots to clean. Elasticsearch snapshots won't be created anymore if there will be more backups to clean than this value.
     */
    public readonly maxEsSnapshotsToClean!: pulumi.Output<number | undefined>;
    /**
     * Pauses Elasticsearch and Cassandra backups. In comparison to enable/disable backup, this option does not modify any configuration like Elasticsearch properties.
     */
    public readonly pauseBackups!: pulumi.Output<boolean | undefined>;
    /**
     * A full path to the backup archive
     */
    public readonly storagePath!: pulumi.Output<string | undefined>;

    /**
     * Create a ManagedBackup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ManagedBackupArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ManagedBackupArgs | ManagedBackupState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ManagedBackupState | undefined;
            resourceInputs["bandwidthLimitMbits"] = state ? state.bandwidthLimitMbits : undefined;
            resourceInputs["cassandraScheduledTime"] = state ? state.cassandraScheduledTime : undefined;
            resourceInputs["currentState"] = state ? state.currentState : undefined;
            resourceInputs["datacenter"] = state ? state.datacenter : undefined;
            resourceInputs["enabled"] = state ? state.enabled : undefined;
            resourceInputs["includeLm20Data"] = state ? state.includeLm20Data : undefined;
            resourceInputs["includeRumData"] = state ? state.includeRumData : undefined;
            resourceInputs["includeTsMetricData"] = state ? state.includeTsMetricData : undefined;
            resourceInputs["maxEsSnapshotsToClean"] = state ? state.maxEsSnapshotsToClean : undefined;
            resourceInputs["pauseBackups"] = state ? state.pauseBackups : undefined;
            resourceInputs["storagePath"] = state ? state.storagePath : undefined;
        } else {
            const args = argsOrState as ManagedBackupArgs | undefined;
            if ((!args || args.cassandraScheduledTime === undefined) && !opts.urn) {
                throw new Error("Missing required property 'cassandraScheduledTime'");
            }
            resourceInputs["bandwidthLimitMbits"] = args ? args.bandwidthLimitMbits : undefined;
            resourceInputs["cassandraScheduledTime"] = args ? args.cassandraScheduledTime : undefined;
            resourceInputs["currentState"] = args ? args.currentState : undefined;
            resourceInputs["datacenter"] = args ? args.datacenter : undefined;
            resourceInputs["enabled"] = args ? args.enabled : undefined;
            resourceInputs["includeLm20Data"] = args ? args.includeLm20Data : undefined;
            resourceInputs["includeRumData"] = args ? args.includeRumData : undefined;
            resourceInputs["includeTsMetricData"] = args ? args.includeTsMetricData : undefined;
            resourceInputs["maxEsSnapshotsToClean"] = args ? args.maxEsSnapshotsToClean : undefined;
            resourceInputs["pauseBackups"] = args ? args.pauseBackups : undefined;
            resourceInputs["storagePath"] = args ? args.storagePath : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ManagedBackup.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ManagedBackup resources.
 */
export interface ManagedBackupState {
    /**
     * Cassandra backup bandwidth limit in Mbps
     */
    bandwidthLimitMbits?: pulumi.Input<number>;
    /**
     * Hour to start Cassandra backups each day.
     */
    cassandraScheduledTime?: pulumi.Input<number>;
    /**
     * For internal use: current state of rules in JSON format
     */
    currentState?: pulumi.Input<string>;
    /**
     * Datacenter which will create backups
     */
    datacenter?: pulumi.Input<string>;
    /**
     * Backups are enabled (true) or disabled (false).
     */
    enabled?: pulumi.Input<boolean>;
    /**
     * Include (true) or exclude (false) Log Monitoring v2 data
     */
    includeLm20Data?: pulumi.Input<boolean>;
    /**
     * Include user sessions (true) or GDPR compliance (false)
     */
    includeRumData?: pulumi.Input<boolean>;
    /**
     * Include time series metric-data (true) or retain configuration data only (false))
     */
    includeTsMetricData?: pulumi.Input<boolean>;
    /**
     * Max number of Elasticsearch snapshots to clean. Elasticsearch snapshots won't be created anymore if there will be more backups to clean than this value.
     */
    maxEsSnapshotsToClean?: pulumi.Input<number>;
    /**
     * Pauses Elasticsearch and Cassandra backups. In comparison to enable/disable backup, this option does not modify any configuration like Elasticsearch properties.
     */
    pauseBackups?: pulumi.Input<boolean>;
    /**
     * A full path to the backup archive
     */
    storagePath?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ManagedBackup resource.
 */
export interface ManagedBackupArgs {
    /**
     * Cassandra backup bandwidth limit in Mbps
     */
    bandwidthLimitMbits?: pulumi.Input<number>;
    /**
     * Hour to start Cassandra backups each day.
     */
    cassandraScheduledTime: pulumi.Input<number>;
    /**
     * For internal use: current state of rules in JSON format
     */
    currentState?: pulumi.Input<string>;
    /**
     * Datacenter which will create backups
     */
    datacenter?: pulumi.Input<string>;
    /**
     * Backups are enabled (true) or disabled (false).
     */
    enabled?: pulumi.Input<boolean>;
    /**
     * Include (true) or exclude (false) Log Monitoring v2 data
     */
    includeLm20Data?: pulumi.Input<boolean>;
    /**
     * Include user sessions (true) or GDPR compliance (false)
     */
    includeRumData?: pulumi.Input<boolean>;
    /**
     * Include time series metric-data (true) or retain configuration data only (false))
     */
    includeTsMetricData?: pulumi.Input<boolean>;
    /**
     * Max number of Elasticsearch snapshots to clean. Elasticsearch snapshots won't be created anymore if there will be more backups to clean than this value.
     */
    maxEsSnapshotsToClean?: pulumi.Input<number>;
    /**
     * Pauses Elasticsearch and Cassandra backups. In comparison to enable/disable backup, this option does not modify any configuration like Elasticsearch properties.
     */
    pauseBackups?: pulumi.Input<boolean>;
    /**
     * A full path to the backup archive
     */
    storagePath?: pulumi.Input<string>;
}