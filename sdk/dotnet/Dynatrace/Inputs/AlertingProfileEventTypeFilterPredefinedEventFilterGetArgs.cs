// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Lbrlabs.PulumiPackage.Dynatrace.Inputs
{

    public sealed class AlertingProfileEventTypeFilterPredefinedEventFilterGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The type of the predefined event. Possible values are `APPLICATION_ERROR_RATE_INCREASED`, `APPLICATION_SLOWDOWN`, `APPLICATION_UNEXPECTED_HIGH_LOAD`, `APPLICATION_UNEXPECTED_LOW_LOAD`, `AWS_LAMBDA_HIGH_ERROR_RATE`, `CUSTOM_APPLICATION_ERROR_RATE_INCREASED`, `CUSTOM_APPLICATION_SLOWDOWN`, `CUSTOM_APPLICATION_UNEXPECTED_HIGH_LOAD`, `CUSTOM_APPLICATION_UNEXPECTED_LOW_LOAD`, `CUSTOM_APP_CRASH_RATE_INCREASED`, `DATABASE_CONNECTION_FAILURE`, `DATA_CENTER_SERVICE_PERFORMANCE_DEGRADATION`, `DATA_CENTER_SERVICE_UNAVAILABLE`, `EBS_VOLUME_HIGH_LATENCY`, `EC2_HIGH_CPU`, `ELB_HIGH_BACKEND_ERROR_RATE`, `ENTERPRICE_APPLICATION_PERFORMANCE_DEGRADATION`, `ENTERPRISE_APPLICATION_UNAVAILABLE`, `ESXI_GUEST_ACTIVE_SWAP_WAIT`, `ESXI_GUEST_CPU_LIMIT_REACHED`, `ESXI_HOST_CPU_SATURATION`, `ESXI_HOST_DATASTORE_LOW_DISK_SPACE`, `ESXI_HOST_DISK_QUEUE_SLOW`, `ESXI_HOST_DISK_SLOW`, `ESXI_HOST_MEMORY_SATURATION`, `ESXI_HOST_NETWORK_PROBLEMS`, `ESXI_HOST_OVERLOADED_STORAGE`, `ESXI_VM_IMPACT_HOST_CPU_SATURATION`, `ESXI_VM_IMPACT_HOST_MEMORY_SATURATION`, `EXTERNAL_SYNTHETIC_TEST_OUTAGE`, `EXTERNAL_SYNTHETIC_TEST_SLOWDOWN`, `HOST_OF_SERVICE_UNAVAILABLE`, `HTTP_CHECK_GLOBAL_OUTAGE`, `HTTP_CHECK_LOCAL_OUTAGE`, `HTTP_CHECK_TEST_LOCATION_SLOWDOWN`, `MOBILE_APPLICATION_ERROR_RATE_INCREASED`, `MOBILE_APPLICATION_SLOWDOWN`, `MOBILE_APPLICATION_UNEXPECTED_HIGH_LOAD`, `MOBILE_APPLICATION_UNEXPECTED_LOW_LOAD`, `MOBILE_APP_CRASH_RATE_INCREASED`, `MONITORING_UNAVAILABLE`, `OSI_DISK_LOW_INODES`, `OSI_GRACEFULLY_SHUTDOWN`, `OSI_HIGH_CPU`, `OSI_HIGH_MEMORY`, `OSI_LOW_DISK_SPACE`, `OSI_NIC_DROPPED_PACKETS_HIGH`, `OSI_NIC_ERRORS_HIGH`, `OSI_NIC_UTILIZATION_HIGH`, `OSI_SLOW_DISK`, `OSI_UNEXPECTEDLY_UNAVAILABLE`, `PGI_OF_SERVICE_UNAVAILABLE`, `PGI_UNAVAILABLE`, `PG_LOW_INSTANCE_COUNT`, `PROCESS_CRASHED`, `PROCESS_HIGH_GC_ACTIVITY`, `PROCESS_MEMORY_RESOURCE_EXHAUSTED`, `PROCESS_NA_HIGH_CONN_FAIL_RATE`, `PROCESS_NA_HIGH_LOSS_RATE`, `PROCESS_THREADS_RESOURCE_EXHAUSTED`, `RDS_HIGH_CPU`, `RDS_HIGH_LATENCY`, `RDS_LOW_MEMORY`, `RDS_LOW_STORAGE_SPACE`, `RDS_OF_SERVICE_UNAVAILABLE`, `RDS_RESTART_SEQUENCE`, `SERVICE_ERROR_RATE_INCREASED`, `SERVICE_SLOWDOWN`, `SERVICE_UNEXPECTED_HIGH_LOAD`, `SERVICE_UNEXPECTED_LOW_LOAD`, `SYNTHETIC_GLOBAL_OUTAGE`, `SYNTHETIC_LOCAL_OUTAGE`, `SYNTHETIC_NODE_OUTAGE`, `SYNTHETIC_PRIVATE_LOCATION_OUTAGE` and `SYNTHETIC_TEST_LOCATION_SLOWDOWN`
        /// </summary>
        [Input("eventType", required: true)]
        public Input<string> EventType { get; set; } = null!;

        /// <summary>
        /// Reverses the comparison **operator**. For example it turns the **begins with** into **does not begin with**
        /// </summary>
        [Input("negate")]
        public Input<bool>? Negate { get; set; }

        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        public AlertingProfileEventTypeFilterPredefinedEventFilterGetArgs()
        {
        }
        public static new AlertingProfileEventTypeFilterPredefinedEventFilterGetArgs Empty => new AlertingProfileEventTypeFilterPredefinedEventFilterGetArgs();
    }
}
