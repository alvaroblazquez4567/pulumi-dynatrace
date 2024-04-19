// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Lbrlabs.PulumiPackage.Dynatrace.Outputs
{

    [OutputType]
    public sealed class AutotagRulesRulesRuleAttributeRuleConditionsCondition
    {
        /// <summary>
        /// Case sensitive
        /// </summary>
        public readonly bool? CaseSensitive;
        /// <summary>
        /// Dynamic key
        /// </summary>
        public readonly string? DynamicKey;
        /// <summary>
        /// Key source
        /// </summary>
        public readonly string? DynamicKeySource;
        /// <summary>
        /// Value
        /// </summary>
        public readonly string? EntityId;
        /// <summary>
        /// Value
        /// </summary>
        public readonly string? EnumValue;
        /// <summary>
        /// Value
        /// </summary>
        public readonly int? IntegerValue;
        /// <summary>
        /// Possible Values: `APPMON_SERVER_NAME`, `APPMON_SYSTEM_PROFILE_NAME`, `AWS_ACCOUNT_ID`, `AWS_ACCOUNT_NAME`, `AWS_APPLICATION_LOAD_BALANCER_NAME`, `AWS_APPLICATION_LOAD_BALANCER_TAGS`, `AWS_AUTO_SCALING_GROUP_NAME`, `AWS_AUTO_SCALING_GROUP_TAGS`, `AWS_AVAILABILITY_ZONE_NAME`, `AWS_CLASSIC_LOAD_BALANCER_FRONTEND_PORTS`, `AWS_CLASSIC_LOAD_BALANCER_NAME`, `AWS_CLASSIC_LOAD_BALANCER_TAGS`, `AWS_NETWORK_LOAD_BALANCER_NAME`, `AWS_NETWORK_LOAD_BALANCER_TAGS`, `AWS_RELATIONAL_DATABASE_SERVICE_DB_NAME`, `AWS_RELATIONAL_DATABASE_SERVICE_ENDPOINT`, `AWS_RELATIONAL_DATABASE_SERVICE_ENGINE`, `AWS_RELATIONAL_DATABASE_SERVICE_INSTANCE_CLASS`, `AWS_RELATIONAL_DATABASE_SERVICE_NAME`, `AWS_RELATIONAL_DATABASE_SERVICE_PORT`, `AWS_RELATIONAL_DATABASE_SERVICE_TAGS`, `AZURE_ENTITY_NAME`, `AZURE_ENTITY_TAGS`, `AZURE_MGMT_GROUP_NAME`, `AZURE_MGMT_GROUP_UUID`, `AZURE_REGION_NAME`, `AZURE_SCALE_SET_NAME`, `AZURE_SUBSCRIPTION_NAME`, `AZURE_SUBSCRIPTION_UUID`, `AZURE_TENANT_NAME`, `AZURE_TENANT_UUID`, `AZURE_VM_NAME`, `BROWSER_MONITOR_NAME`, `BROWSER_MONITOR_TAGS`, `CLOUD_APPLICATION_LABELS`, `CLOUD_APPLICATION_NAME`, `CLOUD_APPLICATION_NAMESPACE_LABELS`, `CLOUD_APPLICATION_NAMESPACE_NAME`, `CLOUD_FOUNDRY_FOUNDATION_NAME`, `CLOUD_FOUNDRY_ORG_NAME`, `CUSTOM_APPLICATION_NAME`, `CUSTOM_APPLICATION_PLATFORM`, `CUSTOM_APPLICATION_TAGS`, `CUSTOM_APPLICATION_TYPE`, `CUSTOM_DEVICE_DNS_ADDRESS`, `CUSTOM_DEVICE_GROUP_NAME`, `CUSTOM_DEVICE_GROUP_TAGS`, `CUSTOM_DEVICE_IP_ADDRESS`, `CUSTOM_DEVICE_METADATA`, `CUSTOM_DEVICE_NAME`, `CUSTOM_DEVICE_PORT`, `CUSTOM_DEVICE_TAGS`, `CUSTOM_DEVICE_TECHNOLOGY`, `DATA_CENTER_SERVICE_DECODER_TYPE`, `DATA_CENTER_SERVICE_IP_ADDRESS`, `DATA_CENTER_SERVICE_METADATA`, `DATA_CENTER_SERVICE_NAME`, `DATA_CENTER_SERVICE_PORT`, `DATA_CENTER_SERVICE_TAGS`, `DOCKER_CONTAINER_NAME`, `DOCKER_FULL_IMAGE_NAME`, `DOCKER_IMAGE_VERSION`, `EC2_INSTANCE_AMI_ID`, `EC2_INSTANCE_AWS_INSTANCE_TYPE`, `EC2_INSTANCE_AWS_SECURITY_GROUP`, `EC2_INSTANCE_BEANSTALK_ENV_NAME`, `EC2_INSTANCE_ID`, `EC2_INSTANCE_NAME`, `EC2_INSTANCE_PRIVATE_HOST_NAME`, `EC2_INSTANCE_PUBLIC_HOST_NAME`, `EC2_INSTANCE_TAGS`, `ENTERPRISE_APPLICATION_DECODER_TYPE`, `ENTERPRISE_APPLICATION_IP_ADDRESS`, `ENTERPRISE_APPLICATION_METADATA`, `ENTERPRISE_APPLICATION_NAME`, `ENTERPRISE_APPLICATION_PORT`, `ENTERPRISE_APPLICATION_TAGS`, `ESXI_HOST_CLUSTER_NAME`, `ESXI_HOST_HARDWARE_MODEL`, `ESXI_HOST_HARDWARE_VENDOR`, `ESXI_HOST_NAME`, `ESXI_HOST_PRODUCT_NAME`, `ESXI_HOST_PRODUCT_VERSION`, `ESXI_HOST_TAGS`, `EXTERNAL_MONITOR_ENGINE_DESCRIPTION`, `EXTERNAL_MONITOR_ENGINE_NAME`, `EXTERNAL_MONITOR_ENGINE_TYPE`, `EXTERNAL_MONITOR_NAME`, `EXTERNAL_MONITOR_TAGS`, `GEOLOCATION_SITE_NAME`, `GOOGLE_CLOUD_PLATFORM_ZONE_NAME`, `GOOGLE_COMPUTE_INSTANCE_ID`, `GOOGLE_COMPUTE_INSTANCE_MACHINE_TYPE`, `GOOGLE_COMPUTE_INSTANCE_NAME`, `GOOGLE_COMPUTE_INSTANCE_PROJECT`, `GOOGLE_COMPUTE_INSTANCE_PROJECT_ID`, `GOOGLE_COMPUTE_INSTANCE_PUBLIC_IP_ADDRESSES`, `HOST_AIX_LOGICAL_CPU_COUNT`, `HOST_AIX_SIMULTANEOUS_THREADS`, `HOST_AIX_VIRTUAL_CPU_COUNT`, `HOST_ARCHITECTURE`, `HOST_AWS_NAME_TAG`, `HOST_AZURE_COMPUTE_MODE`, `HOST_AZURE_SKU`, `HOST_AZURE_WEB_APPLICATION_HOST_NAMES`, `HOST_AZURE_WEB_APPLICATION_SITE_NAMES`, `HOST_BITNESS`, `HOST_BOSH_AVAILABILITY_ZONE`, `HOST_BOSH_DEPLOYMENT_ID`, `HOST_BOSH_INSTANCE_ID`, `HOST_BOSH_INSTANCE_NAME`, `HOST_BOSH_NAME`, `HOST_BOSH_STEMCELL_VERSION`, `HOST_CLOUD_TYPE`, `HOST_CPU_CORES`, `HOST_CUSTOM_METADATA`, `HOST_DETECTED_NAME`, `HOST_GROUP_ID`, `HOST_GROUP_NAME`, `HOST_HYPERVISOR_TYPE`, `HOST_IP_ADDRESS`, `HOST_KUBERNETES_LABELS`, `HOST_LOGICAL_CPU_CORES`, `HOST_NAME`, `HOST_ONEAGENT_CUSTOM_HOST_NAME`, `HOST_OS_TYPE`, `HOST_OS_VERSION`, `HOST_PAAS_MEMORY_LIMIT`, `HOST_PAAS_TYPE`, `HOST_TAGS`, `HOST_TECHNOLOGY`, `HTTP_MONITOR_NAME`, `HTTP_MONITOR_TAGS`, `KUBERNETES_CLUSTER_NAME`, `KUBERNETES_NODE_NAME`, `KUBERNETES_SERVICE_NAME`, `MOBILE_APPLICATION_NAME`, `MOBILE_APPLICATION_PLATFORM`, `MOBILE_APPLICATION_TAGS`, `NAME_OF_COMPUTE_NODE`, `OPENSTACK_ACCOUNT_NAME`, `OPENSTACK_ACCOUNT_PROJECT_NAME`, `OPENSTACK_AVAILABILITY_ZONE_NAME`, `OPENSTACK_PROJECT_NAME`, `OPENSTACK_REGION_NAME`, `OPENSTACK_VM_INSTANCE_TYPE`, `OPENSTACK_VM_NAME`, `OPENSTACK_VM_SECURITY_GROUP`, `PROCESS_GROUP_AZURE_HOST_NAME`, `PROCESS_GROUP_AZURE_SITE_NAME`, `PROCESS_GROUP_CUSTOM_METADATA`, `PROCESS_GROUP_DETECTED_NAME`, `PROCESS_GROUP_ID`, `PROCESS_GROUP_LISTEN_PORT`, `PROCESS_GROUP_NAME`, `PROCESS_GROUP_PREDEFINED_METADATA`, `PROCESS_GROUP_TAGS`, `PROCESS_GROUP_TECHNOLOGY`, `PROCESS_GROUP_TECHNOLOGY_EDITION`, `PROCESS_GROUP_TECHNOLOGY_VERSION`, `QUEUE_NAME`, `QUEUE_TECHNOLOGY`, `QUEUE_VENDOR`, `SERVICE_AKKA_ACTOR_SYSTEM`, `SERVICE_CTG_SERVICE_NAME`, `SERVICE_DATABASE_HOST_NAME`, `SERVICE_DATABASE_NAME`, `SERVICE_DATABASE_TOPOLOGY`, `SERVICE_DATABASE_VENDOR`, `SERVICE_DETECTED_NAME`, `SERVICE_ESB_APPLICATION_NAME`, `SERVICE_IBM_CTG_GATEWAY_URL`, `SERVICE_MESSAGING_LISTENER_CLASS_NAME`, `SERVICE_NAME`, `SERVICE_PORT`, `SERVICE_PUBLIC_DOMAIN_NAME`, `SERVICE_REMOTE_ENDPOINT`, `SERVICE_REMOTE_SERVICE_NAME`, `SERVICE_TAGS`, `SERVICE_TECHNOLOGY`, `SERVICE_TECHNOLOGY_EDITION`, `SERVICE_TECHNOLOGY_VERSION`, `SERVICE_TOPOLOGY`, `SERVICE_TYPE`, `SERVICE_WEB_APPLICATION_ID`, `SERVICE_WEB_CONTEXT_ROOT`, `SERVICE_WEB_SERVER_ENDPOINT`, `SERVICE_WEB_SERVER_NAME`, `SERVICE_WEB_SERVICE_NAME`, `SERVICE_WEB_SERVICE_NAMESPACE`, `VMWARE_DATACENTER_NAME`, `VMWARE_VM_NAME`, `WEB_APPLICATION_NAME`, `WEB_APPLICATION_NAME_PATTERN`, `WEB_APPLICATION_TAGS`, `WEB_APPLICATION_TYPE`
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// Possible Values: `BEGINS_WITH`, `CONTAINS`, `ENDS_WITH`, `EQUALS`, `EXISTS`, `GREATER_THAN`, `GREATER_THAN_OR_EQUAL`, `IS_IP_IN_RANGE`, `LOWER_THAN`, `LOWER_THAN_OR_EQUAL`, `NOT_BEGINS_WITH`, `NOT_CONTAINS`, `NOT_ENDS_WITH`, `NOT_EQUALS`, `NOT_EXISTS`, `NOT_GREATER_THAN`, `NOT_GREATER_THAN_OR_EQUAL`, `NOT_IS_IP_IN_RANGE`, `NOT_LOWER_THAN`, `NOT_LOWER_THAN_OR_EQUAL`, `NOT_REGEX_MATCHES`, `NOT_TAG_KEY_EQUALS`, `REGEX_MATCHES`, `TAG_KEY_EQUALS`
        /// </summary>
        public readonly string Operator;
        /// <summary>
        /// Value
        /// </summary>
        public readonly string? StringValue;
        /// <summary>
        /// Format: `[CONTEXT]tagKey:tagValue`
        /// </summary>
        public readonly string? Tag;

        [OutputConstructor]
        private AutotagRulesRulesRuleAttributeRuleConditionsCondition(
            bool? caseSensitive,

            string? dynamicKey,

            string? dynamicKeySource,

            string? entityId,

            string? enumValue,

            int? integerValue,

            string key,

            string @operator,

            string? stringValue,

            string? tag)
        {
            CaseSensitive = caseSensitive;
            DynamicKey = dynamicKey;
            DynamicKeySource = dynamicKeySource;
            EntityId = entityId;
            EnumValue = enumValue;
            IntegerValue = integerValue;
            Key = key;
            Operator = @operator;
            StringValue = stringValue;
            Tag = tag;
        }
    }
}
