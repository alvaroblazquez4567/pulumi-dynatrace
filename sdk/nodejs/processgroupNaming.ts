// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class ProcessgroupNaming extends pulumi.CustomResource {
    /**
     * Get an existing ProcessgroupNaming resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ProcessgroupNamingState, opts?: pulumi.CustomResourceOptions): ProcessgroupNaming {
        return new ProcessgroupNaming(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/processgroupNaming:ProcessgroupNaming';

    /**
     * Returns true if the given object is an instance of ProcessgroupNaming.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ProcessgroupNaming {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ProcessgroupNaming.__pulumiType;
    }

    /**
     * A list of matching conditions of the rule. The rule applies only if **all** conditions are fulfilled
     */
    public readonly conditions!: pulumi.Output<outputs.ProcessgroupNamingCondition[] | undefined>;
    /**
     * The rule is enabled (`true`) or disabled (`false`)
     */
    public readonly enabled!: pulumi.Output<boolean>;
    /**
     * The name to be assigned to matching entities. You can use the following placeholders here: *
     * `{AwsAutoScalingGroup:Name}` * `{AwsAvailabilityZone:Name}` * `{AwsElasticLoadBalancer:Name}` *
     * `{AwsRelationalDatabaseService:DBName}` * `{AwsRelationalDatabaseService:Endpoint}` *
     * `{AwsRelationalDatabaseService:Engine}` * `{AwsRelationalDatabaseService:InstanceClass}` *
     * `{AwsRelationalDatabaseService:Name}` * `{AwsRelationalDatabaseService:Port}` * `{AzureRegion:Name}` *
     * `{AzureScaleSet:Name}` * `{AzureVm:Name}` * `{CloudFoundryOrganization:Name}` * `{CustomDevice:DetectedName}` *
     * `{CustomDevice:DnsName}` * `{CustomDevice:IpAddress}` * `{CustomDevice:Port}` *
     * `{DockerContainerGroupInstance:ContainerName}` * `{DockerContainerGroupInstance:FullImageName}` *
     * `{DockerContainerGroupInstance:ImageVersion}` * `{DockerContainerGroupInstance:StrippedImageName}` *
     * `{ESXIHost:HardwareModel}` * `{ESXIHost:HardwareVendor}` * `{ESXIHost:Name}` * `{ESXIHost:ProductName}` *
     * `{ESXIHost:ProductVersion}` * `{Ec2Instance:AmiId}` * `{Ec2Instance:BeanstalkEnvironmentName}` *
     * `{Ec2Instance:InstanceId}` * `{Ec2Instance:InstanceType}` * `{Ec2Instance:LocalHostName}` * `{Ec2Instance:Name}` *
     * `{Ec2Instance:PublicHostName}` * `{Ec2Instance:SecurityGroup}` * `{GoogleComputeInstance:Id}` *
     * `{GoogleComputeInstance:IpAddresses}` * `{GoogleComputeInstance:MachineType}` * `{GoogleComputeInstance:Name}` *
     * `{GoogleComputeInstance:ProjectId}` * `{GoogleComputeInstance:Project}` * `{Host:AWSNameTag}` *
     * `{Host:AixLogicalCpuCount}` * `{Host:AzureHostName}` * `{Host:AzureSiteName}` * `{Host:BoshDeploymentId}` *
     * `{Host:BoshInstanceId}` * `{Host:BoshInstanceName}` * `{Host:BoshName}` * `{Host:BoshStemcellVersion}` *
     * `{Host:CpuCores}` * `{Host:DetectedName}` * `{Host:Environment:AppName}` * `{Host:Environment:BoshReleaseVersion}` *
     * `{Host:Environment:Environment}` * `{Host:Environment:Link}` * `{Host:Environment:Organization}` *
     * `{Host:Environment:Owner}` * `{Host:Environment:Support}` * `{Host:IpAddress}` * `{Host:LogicalCpuCores}` *
     * `{Host:OneAgentCustomHostName}` * `{Host:OperatingSystemVersion}` * `{Host:PaasMemoryLimit}` * `{HostGroup:Name}` *
     * `{KubernetesCluster:Name}` * `{KubernetesNode:DetectedName}` * `{OpenstackAvailabilityZone:Name}` *
     * `{OpenstackZone:Name}` * `{OpenstackComputeNode:Name}` * `{OpenstackProject:Name}` * `{OpenstackVm:InstanceType}` *
     * `{OpenstackVm:Name}` * `{OpenstackVm:SecurityGroup}` * `{ProcessGroup:AmazonECRImageAccountId}` *
     * `{ProcessGroup:AmazonECRImageRegion}` * `{ProcessGroup:AmazonECSCluster}` * `{ProcessGroup:AmazonECSContainerName}` *
     * `{ProcessGroup:AmazonECSFamily}` * `{ProcessGroup:AmazonECSRevision}` * `{ProcessGroup:AmazonLambdaFunctionName}` *
     * `{ProcessGroup:AmazonRegion}` * `{ProcessGroup:ApacheConfigPath}` * `{ProcessGroup:ApacheSparkMasterIpAddress}` *
     * `{ProcessGroup:AspDotNetCoreApplicationPath}` * `{ProcessGroup:AspDotNetCoreApplicationPath}` *
     * `{ProcessGroup:AzureHostName}` * `{ProcessGroup:AzureSiteName}` * `{ProcessGroup:CassandraClusterName}` *
     * `{ProcessGroup:CatalinaBase}` * `{ProcessGroup:CatalinaHome}` * `{ProcessGroup:CloudFoundryAppId}` *
     * `{ProcessGroup:CloudFoundryAppName}` * `{ProcessGroup:CloudFoundryInstanceIndex}` * `{ProcessGroup:CloudFoundrySpaceId}`
     * * `{ProcessGroup:CloudFoundrySpaceName}` * `{ProcessGroup:ColdFusionJvmConfigFile}` *
     * `{ProcessGroup:ColdFusionServiceName}` * `{ProcessGroup:CommandLineArgs}` * `{ProcessGroup:DetectedName}` *
     * `{ProcessGroup:DotNetCommandPath}` * `{ProcessGroup:DotNetCommand}` * `{ProcessGroup:DotNetClusterId}` *
     * `{ProcessGroup:DotNetNodeId}` * `{ProcessGroup:ElasticsearchClusterName}` * `{ProcessGroup:ElasticsearchNodeName}` *
     * `{ProcessGroup:EquinoxConfigPath}` * `{ProcessGroup:ExeName}` * `{ProcessGroup:ExePath}` *
     * `{ProcessGroup:GlassFishDomainName}` * `{ProcessGroup:GlassFishInstanceName}` * `{ProcessGroup:GoogleAppEngineInstance}`
     * * `{ProcessGroup:GoogleAppEngineService}` * `{ProcessGroup:GoogleCloudProject}` * `{ProcessGroup:HybrisBinDirectory}` *
     * `{ProcessGroup:HybrisConfigDirectory}` * `{ProcessGroup:HybrisConfigDirectory}` * `{ProcessGroup:HybrisDataDirectory}` *
     * `{ProcessGroup:IBMCicsRegion}` * `{ProcessGroup:IBMCtgName}` * `{ProcessGroup:IBMImsConnectRegion}` *
     * `{ProcessGroup:IBMImsControlRegion}` * `{ProcessGroup:IBMImsMessageProcessingRegion}` *
     * `{ProcessGroup:IBMImsSoapGwName}` * `{ProcessGroup:IBMIntegrationNodeName}` * `{ProcessGroup:IBMIntegrationServerName}`
     * * `{ProcessGroup:IISAppPool}` * `{ProcessGroup:IISRoleName}` * `{ProcessGroup:JbossHome}` * `{ProcessGroup:JbossMode}` *
     * `{ProcessGroup:JbossServerName}` * `{ProcessGroup:JavaJarFile}` * `{ProcessGroup:JavaJarPath}` *
     * `{ProcessGroup:JavaMainCLass}` * `{ProcessGroup:KubernetesBasePodName}` * `{ProcessGroup:KubernetesContainerName}` *
     * `{ProcessGroup:KubernetesFullPodName}` * `{ProcessGroup:KubernetesNamespace}` * `{ProcessGroup:KubernetesPodUid}` *
     * `{ProcessGroup:MssqlInstanceName}` * `{ProcessGroup:NodeJsAppBaseDirectory}` * `{ProcessGroup:NodeJsAppName}` *
     * `{ProcessGroup:NodeJsScriptName}` * `{ProcessGroup:OracleSid}` * `{ProcessGroup:PHPScriptPath}` *
     * `{ProcessGroup:PHPWorkingDirectory}` * `{ProcessGroup:Ports}` * `{ProcessGroup:RubyAppRootPath}` *
     * `{ProcessGroup:RubyScriptPath}` * `{ProcessGroup:SoftwareAGInstallRoot}` *
     * `{ProcessGroup:SoftwareAGProductPropertyName}` * `{ProcessGroup:SpringBootAppName}` *
     * `{ProcessGroup:SpringBootProfileName}` * `{ProcessGroup:SpringBootStartupClass}` *
     * `{ProcessGroup:TIBCOBusinessWorksAppNodeName}` * `{ProcessGroup:TIBCOBusinessWorksAppSpaceName}` *
     * `{ProcessGroup:TIBCOBusinessWorksCeAppName}` * `{ProcessGroup:TIBCOBusinessWorksCeVersion}` *
     * `{ProcessGroup:TIBCOBusinessWorksDomainName}` * `{ProcessGroup:TIBCOBusinessWorksEnginePropertyFilePath}` *
     * `{ProcessGroup:TIBCOBusinessWorksEnginePropertyFile}` * `{ProcessGroup:TIBCOBusinessWorksHome}` *
     * `{ProcessGroup:VarnishInstanceName}` * `{ProcessGroup:WebLogicClusterName}` * `{ProcessGroup:WebLogicDomainName}` *
     * `{ProcessGroup:WebLogicHome}` * `{ProcessGroup:WebLogicName}` * `{ProcessGroup:WebSphereCellName}` *
     * `{ProcessGroup:WebSphereClusterName}` * `{ProcessGroup:WebSphereNodeName}` * `{ProcessGroup:WebSphereServerName}` *
     * `{ProcessGroup:ActorSystem}` * `{Service:STGServerName}` * `{Service:DatabaseHostName}` * `{Service:DatabaseName}` *
     * `{Service:DatabaseVendor}` * `{Service:DetectedName}` * `{Service:EndpointPath}` * `{Service:EndpointPathGatewayUrl}` *
     * `{Service:IIBApplicationName}` * `{Service:MessageListenerClassName}` * `{Service:Port}` * `{Service:PublicDomainName}`
     * * `{Service:RemoteEndpoint}` * `{Service:RemoteName}` * `{Service:WebApplicationId}` * `{Service:WebContextRoot}` *
     * `{Service:WebServerName}` * `{Service:WebServiceNamespace}` * `{Service:WebServiceName}` * `{VmwareDatacenter:Name}` *
     * `{VmwareVm:Name}
     */
    public readonly format!: pulumi.Output<string>;
    /**
     * The name of the rule
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * allows for configuring properties that are not explicitly supported by the current version of this provider
     */
    public readonly unknowns!: pulumi.Output<string | undefined>;

    /**
     * Create a ProcessgroupNaming resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ProcessgroupNamingArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ProcessgroupNamingArgs | ProcessgroupNamingState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ProcessgroupNamingState | undefined;
            resourceInputs["conditions"] = state ? state.conditions : undefined;
            resourceInputs["enabled"] = state ? state.enabled : undefined;
            resourceInputs["format"] = state ? state.format : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["unknowns"] = state ? state.unknowns : undefined;
        } else {
            const args = argsOrState as ProcessgroupNamingArgs | undefined;
            if ((!args || args.enabled === undefined) && !opts.urn) {
                throw new Error("Missing required property 'enabled'");
            }
            if ((!args || args.format === undefined) && !opts.urn) {
                throw new Error("Missing required property 'format'");
            }
            resourceInputs["conditions"] = args ? args.conditions : undefined;
            resourceInputs["enabled"] = args ? args.enabled : undefined;
            resourceInputs["format"] = args ? args.format : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["unknowns"] = args ? args.unknowns : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ProcessgroupNaming.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ProcessgroupNaming resources.
 */
export interface ProcessgroupNamingState {
    /**
     * A list of matching conditions of the rule. The rule applies only if **all** conditions are fulfilled
     */
    conditions?: pulumi.Input<pulumi.Input<inputs.ProcessgroupNamingCondition>[]>;
    /**
     * The rule is enabled (`true`) or disabled (`false`)
     */
    enabled?: pulumi.Input<boolean>;
    /**
     * The name to be assigned to matching entities. You can use the following placeholders here: *
     * `{AwsAutoScalingGroup:Name}` * `{AwsAvailabilityZone:Name}` * `{AwsElasticLoadBalancer:Name}` *
     * `{AwsRelationalDatabaseService:DBName}` * `{AwsRelationalDatabaseService:Endpoint}` *
     * `{AwsRelationalDatabaseService:Engine}` * `{AwsRelationalDatabaseService:InstanceClass}` *
     * `{AwsRelationalDatabaseService:Name}` * `{AwsRelationalDatabaseService:Port}` * `{AzureRegion:Name}` *
     * `{AzureScaleSet:Name}` * `{AzureVm:Name}` * `{CloudFoundryOrganization:Name}` * `{CustomDevice:DetectedName}` *
     * `{CustomDevice:DnsName}` * `{CustomDevice:IpAddress}` * `{CustomDevice:Port}` *
     * `{DockerContainerGroupInstance:ContainerName}` * `{DockerContainerGroupInstance:FullImageName}` *
     * `{DockerContainerGroupInstance:ImageVersion}` * `{DockerContainerGroupInstance:StrippedImageName}` *
     * `{ESXIHost:HardwareModel}` * `{ESXIHost:HardwareVendor}` * `{ESXIHost:Name}` * `{ESXIHost:ProductName}` *
     * `{ESXIHost:ProductVersion}` * `{Ec2Instance:AmiId}` * `{Ec2Instance:BeanstalkEnvironmentName}` *
     * `{Ec2Instance:InstanceId}` * `{Ec2Instance:InstanceType}` * `{Ec2Instance:LocalHostName}` * `{Ec2Instance:Name}` *
     * `{Ec2Instance:PublicHostName}` * `{Ec2Instance:SecurityGroup}` * `{GoogleComputeInstance:Id}` *
     * `{GoogleComputeInstance:IpAddresses}` * `{GoogleComputeInstance:MachineType}` * `{GoogleComputeInstance:Name}` *
     * `{GoogleComputeInstance:ProjectId}` * `{GoogleComputeInstance:Project}` * `{Host:AWSNameTag}` *
     * `{Host:AixLogicalCpuCount}` * `{Host:AzureHostName}` * `{Host:AzureSiteName}` * `{Host:BoshDeploymentId}` *
     * `{Host:BoshInstanceId}` * `{Host:BoshInstanceName}` * `{Host:BoshName}` * `{Host:BoshStemcellVersion}` *
     * `{Host:CpuCores}` * `{Host:DetectedName}` * `{Host:Environment:AppName}` * `{Host:Environment:BoshReleaseVersion}` *
     * `{Host:Environment:Environment}` * `{Host:Environment:Link}` * `{Host:Environment:Organization}` *
     * `{Host:Environment:Owner}` * `{Host:Environment:Support}` * `{Host:IpAddress}` * `{Host:LogicalCpuCores}` *
     * `{Host:OneAgentCustomHostName}` * `{Host:OperatingSystemVersion}` * `{Host:PaasMemoryLimit}` * `{HostGroup:Name}` *
     * `{KubernetesCluster:Name}` * `{KubernetesNode:DetectedName}` * `{OpenstackAvailabilityZone:Name}` *
     * `{OpenstackZone:Name}` * `{OpenstackComputeNode:Name}` * `{OpenstackProject:Name}` * `{OpenstackVm:InstanceType}` *
     * `{OpenstackVm:Name}` * `{OpenstackVm:SecurityGroup}` * `{ProcessGroup:AmazonECRImageAccountId}` *
     * `{ProcessGroup:AmazonECRImageRegion}` * `{ProcessGroup:AmazonECSCluster}` * `{ProcessGroup:AmazonECSContainerName}` *
     * `{ProcessGroup:AmazonECSFamily}` * `{ProcessGroup:AmazonECSRevision}` * `{ProcessGroup:AmazonLambdaFunctionName}` *
     * `{ProcessGroup:AmazonRegion}` * `{ProcessGroup:ApacheConfigPath}` * `{ProcessGroup:ApacheSparkMasterIpAddress}` *
     * `{ProcessGroup:AspDotNetCoreApplicationPath}` * `{ProcessGroup:AspDotNetCoreApplicationPath}` *
     * `{ProcessGroup:AzureHostName}` * `{ProcessGroup:AzureSiteName}` * `{ProcessGroup:CassandraClusterName}` *
     * `{ProcessGroup:CatalinaBase}` * `{ProcessGroup:CatalinaHome}` * `{ProcessGroup:CloudFoundryAppId}` *
     * `{ProcessGroup:CloudFoundryAppName}` * `{ProcessGroup:CloudFoundryInstanceIndex}` * `{ProcessGroup:CloudFoundrySpaceId}`
     * * `{ProcessGroup:CloudFoundrySpaceName}` * `{ProcessGroup:ColdFusionJvmConfigFile}` *
     * `{ProcessGroup:ColdFusionServiceName}` * `{ProcessGroup:CommandLineArgs}` * `{ProcessGroup:DetectedName}` *
     * `{ProcessGroup:DotNetCommandPath}` * `{ProcessGroup:DotNetCommand}` * `{ProcessGroup:DotNetClusterId}` *
     * `{ProcessGroup:DotNetNodeId}` * `{ProcessGroup:ElasticsearchClusterName}` * `{ProcessGroup:ElasticsearchNodeName}` *
     * `{ProcessGroup:EquinoxConfigPath}` * `{ProcessGroup:ExeName}` * `{ProcessGroup:ExePath}` *
     * `{ProcessGroup:GlassFishDomainName}` * `{ProcessGroup:GlassFishInstanceName}` * `{ProcessGroup:GoogleAppEngineInstance}`
     * * `{ProcessGroup:GoogleAppEngineService}` * `{ProcessGroup:GoogleCloudProject}` * `{ProcessGroup:HybrisBinDirectory}` *
     * `{ProcessGroup:HybrisConfigDirectory}` * `{ProcessGroup:HybrisConfigDirectory}` * `{ProcessGroup:HybrisDataDirectory}` *
     * `{ProcessGroup:IBMCicsRegion}` * `{ProcessGroup:IBMCtgName}` * `{ProcessGroup:IBMImsConnectRegion}` *
     * `{ProcessGroup:IBMImsControlRegion}` * `{ProcessGroup:IBMImsMessageProcessingRegion}` *
     * `{ProcessGroup:IBMImsSoapGwName}` * `{ProcessGroup:IBMIntegrationNodeName}` * `{ProcessGroup:IBMIntegrationServerName}`
     * * `{ProcessGroup:IISAppPool}` * `{ProcessGroup:IISRoleName}` * `{ProcessGroup:JbossHome}` * `{ProcessGroup:JbossMode}` *
     * `{ProcessGroup:JbossServerName}` * `{ProcessGroup:JavaJarFile}` * `{ProcessGroup:JavaJarPath}` *
     * `{ProcessGroup:JavaMainCLass}` * `{ProcessGroup:KubernetesBasePodName}` * `{ProcessGroup:KubernetesContainerName}` *
     * `{ProcessGroup:KubernetesFullPodName}` * `{ProcessGroup:KubernetesNamespace}` * `{ProcessGroup:KubernetesPodUid}` *
     * `{ProcessGroup:MssqlInstanceName}` * `{ProcessGroup:NodeJsAppBaseDirectory}` * `{ProcessGroup:NodeJsAppName}` *
     * `{ProcessGroup:NodeJsScriptName}` * `{ProcessGroup:OracleSid}` * `{ProcessGroup:PHPScriptPath}` *
     * `{ProcessGroup:PHPWorkingDirectory}` * `{ProcessGroup:Ports}` * `{ProcessGroup:RubyAppRootPath}` *
     * `{ProcessGroup:RubyScriptPath}` * `{ProcessGroup:SoftwareAGInstallRoot}` *
     * `{ProcessGroup:SoftwareAGProductPropertyName}` * `{ProcessGroup:SpringBootAppName}` *
     * `{ProcessGroup:SpringBootProfileName}` * `{ProcessGroup:SpringBootStartupClass}` *
     * `{ProcessGroup:TIBCOBusinessWorksAppNodeName}` * `{ProcessGroup:TIBCOBusinessWorksAppSpaceName}` *
     * `{ProcessGroup:TIBCOBusinessWorksCeAppName}` * `{ProcessGroup:TIBCOBusinessWorksCeVersion}` *
     * `{ProcessGroup:TIBCOBusinessWorksDomainName}` * `{ProcessGroup:TIBCOBusinessWorksEnginePropertyFilePath}` *
     * `{ProcessGroup:TIBCOBusinessWorksEnginePropertyFile}` * `{ProcessGroup:TIBCOBusinessWorksHome}` *
     * `{ProcessGroup:VarnishInstanceName}` * `{ProcessGroup:WebLogicClusterName}` * `{ProcessGroup:WebLogicDomainName}` *
     * `{ProcessGroup:WebLogicHome}` * `{ProcessGroup:WebLogicName}` * `{ProcessGroup:WebSphereCellName}` *
     * `{ProcessGroup:WebSphereClusterName}` * `{ProcessGroup:WebSphereNodeName}` * `{ProcessGroup:WebSphereServerName}` *
     * `{ProcessGroup:ActorSystem}` * `{Service:STGServerName}` * `{Service:DatabaseHostName}` * `{Service:DatabaseName}` *
     * `{Service:DatabaseVendor}` * `{Service:DetectedName}` * `{Service:EndpointPath}` * `{Service:EndpointPathGatewayUrl}` *
     * `{Service:IIBApplicationName}` * `{Service:MessageListenerClassName}` * `{Service:Port}` * `{Service:PublicDomainName}`
     * * `{Service:RemoteEndpoint}` * `{Service:RemoteName}` * `{Service:WebApplicationId}` * `{Service:WebContextRoot}` *
     * `{Service:WebServerName}` * `{Service:WebServiceNamespace}` * `{Service:WebServiceName}` * `{VmwareDatacenter:Name}` *
     * `{VmwareVm:Name}
     */
    format?: pulumi.Input<string>;
    /**
     * The name of the rule
     */
    name?: pulumi.Input<string>;
    /**
     * allows for configuring properties that are not explicitly supported by the current version of this provider
     */
    unknowns?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ProcessgroupNaming resource.
 */
export interface ProcessgroupNamingArgs {
    /**
     * A list of matching conditions of the rule. The rule applies only if **all** conditions are fulfilled
     */
    conditions?: pulumi.Input<pulumi.Input<inputs.ProcessgroupNamingCondition>[]>;
    /**
     * The rule is enabled (`true`) or disabled (`false`)
     */
    enabled: pulumi.Input<boolean>;
    /**
     * The name to be assigned to matching entities. You can use the following placeholders here: *
     * `{AwsAutoScalingGroup:Name}` * `{AwsAvailabilityZone:Name}` * `{AwsElasticLoadBalancer:Name}` *
     * `{AwsRelationalDatabaseService:DBName}` * `{AwsRelationalDatabaseService:Endpoint}` *
     * `{AwsRelationalDatabaseService:Engine}` * `{AwsRelationalDatabaseService:InstanceClass}` *
     * `{AwsRelationalDatabaseService:Name}` * `{AwsRelationalDatabaseService:Port}` * `{AzureRegion:Name}` *
     * `{AzureScaleSet:Name}` * `{AzureVm:Name}` * `{CloudFoundryOrganization:Name}` * `{CustomDevice:DetectedName}` *
     * `{CustomDevice:DnsName}` * `{CustomDevice:IpAddress}` * `{CustomDevice:Port}` *
     * `{DockerContainerGroupInstance:ContainerName}` * `{DockerContainerGroupInstance:FullImageName}` *
     * `{DockerContainerGroupInstance:ImageVersion}` * `{DockerContainerGroupInstance:StrippedImageName}` *
     * `{ESXIHost:HardwareModel}` * `{ESXIHost:HardwareVendor}` * `{ESXIHost:Name}` * `{ESXIHost:ProductName}` *
     * `{ESXIHost:ProductVersion}` * `{Ec2Instance:AmiId}` * `{Ec2Instance:BeanstalkEnvironmentName}` *
     * `{Ec2Instance:InstanceId}` * `{Ec2Instance:InstanceType}` * `{Ec2Instance:LocalHostName}` * `{Ec2Instance:Name}` *
     * `{Ec2Instance:PublicHostName}` * `{Ec2Instance:SecurityGroup}` * `{GoogleComputeInstance:Id}` *
     * `{GoogleComputeInstance:IpAddresses}` * `{GoogleComputeInstance:MachineType}` * `{GoogleComputeInstance:Name}` *
     * `{GoogleComputeInstance:ProjectId}` * `{GoogleComputeInstance:Project}` * `{Host:AWSNameTag}` *
     * `{Host:AixLogicalCpuCount}` * `{Host:AzureHostName}` * `{Host:AzureSiteName}` * `{Host:BoshDeploymentId}` *
     * `{Host:BoshInstanceId}` * `{Host:BoshInstanceName}` * `{Host:BoshName}` * `{Host:BoshStemcellVersion}` *
     * `{Host:CpuCores}` * `{Host:DetectedName}` * `{Host:Environment:AppName}` * `{Host:Environment:BoshReleaseVersion}` *
     * `{Host:Environment:Environment}` * `{Host:Environment:Link}` * `{Host:Environment:Organization}` *
     * `{Host:Environment:Owner}` * `{Host:Environment:Support}` * `{Host:IpAddress}` * `{Host:LogicalCpuCores}` *
     * `{Host:OneAgentCustomHostName}` * `{Host:OperatingSystemVersion}` * `{Host:PaasMemoryLimit}` * `{HostGroup:Name}` *
     * `{KubernetesCluster:Name}` * `{KubernetesNode:DetectedName}` * `{OpenstackAvailabilityZone:Name}` *
     * `{OpenstackZone:Name}` * `{OpenstackComputeNode:Name}` * `{OpenstackProject:Name}` * `{OpenstackVm:InstanceType}` *
     * `{OpenstackVm:Name}` * `{OpenstackVm:SecurityGroup}` * `{ProcessGroup:AmazonECRImageAccountId}` *
     * `{ProcessGroup:AmazonECRImageRegion}` * `{ProcessGroup:AmazonECSCluster}` * `{ProcessGroup:AmazonECSContainerName}` *
     * `{ProcessGroup:AmazonECSFamily}` * `{ProcessGroup:AmazonECSRevision}` * `{ProcessGroup:AmazonLambdaFunctionName}` *
     * `{ProcessGroup:AmazonRegion}` * `{ProcessGroup:ApacheConfigPath}` * `{ProcessGroup:ApacheSparkMasterIpAddress}` *
     * `{ProcessGroup:AspDotNetCoreApplicationPath}` * `{ProcessGroup:AspDotNetCoreApplicationPath}` *
     * `{ProcessGroup:AzureHostName}` * `{ProcessGroup:AzureSiteName}` * `{ProcessGroup:CassandraClusterName}` *
     * `{ProcessGroup:CatalinaBase}` * `{ProcessGroup:CatalinaHome}` * `{ProcessGroup:CloudFoundryAppId}` *
     * `{ProcessGroup:CloudFoundryAppName}` * `{ProcessGroup:CloudFoundryInstanceIndex}` * `{ProcessGroup:CloudFoundrySpaceId}`
     * * `{ProcessGroup:CloudFoundrySpaceName}` * `{ProcessGroup:ColdFusionJvmConfigFile}` *
     * `{ProcessGroup:ColdFusionServiceName}` * `{ProcessGroup:CommandLineArgs}` * `{ProcessGroup:DetectedName}` *
     * `{ProcessGroup:DotNetCommandPath}` * `{ProcessGroup:DotNetCommand}` * `{ProcessGroup:DotNetClusterId}` *
     * `{ProcessGroup:DotNetNodeId}` * `{ProcessGroup:ElasticsearchClusterName}` * `{ProcessGroup:ElasticsearchNodeName}` *
     * `{ProcessGroup:EquinoxConfigPath}` * `{ProcessGroup:ExeName}` * `{ProcessGroup:ExePath}` *
     * `{ProcessGroup:GlassFishDomainName}` * `{ProcessGroup:GlassFishInstanceName}` * `{ProcessGroup:GoogleAppEngineInstance}`
     * * `{ProcessGroup:GoogleAppEngineService}` * `{ProcessGroup:GoogleCloudProject}` * `{ProcessGroup:HybrisBinDirectory}` *
     * `{ProcessGroup:HybrisConfigDirectory}` * `{ProcessGroup:HybrisConfigDirectory}` * `{ProcessGroup:HybrisDataDirectory}` *
     * `{ProcessGroup:IBMCicsRegion}` * `{ProcessGroup:IBMCtgName}` * `{ProcessGroup:IBMImsConnectRegion}` *
     * `{ProcessGroup:IBMImsControlRegion}` * `{ProcessGroup:IBMImsMessageProcessingRegion}` *
     * `{ProcessGroup:IBMImsSoapGwName}` * `{ProcessGroup:IBMIntegrationNodeName}` * `{ProcessGroup:IBMIntegrationServerName}`
     * * `{ProcessGroup:IISAppPool}` * `{ProcessGroup:IISRoleName}` * `{ProcessGroup:JbossHome}` * `{ProcessGroup:JbossMode}` *
     * `{ProcessGroup:JbossServerName}` * `{ProcessGroup:JavaJarFile}` * `{ProcessGroup:JavaJarPath}` *
     * `{ProcessGroup:JavaMainCLass}` * `{ProcessGroup:KubernetesBasePodName}` * `{ProcessGroup:KubernetesContainerName}` *
     * `{ProcessGroup:KubernetesFullPodName}` * `{ProcessGroup:KubernetesNamespace}` * `{ProcessGroup:KubernetesPodUid}` *
     * `{ProcessGroup:MssqlInstanceName}` * `{ProcessGroup:NodeJsAppBaseDirectory}` * `{ProcessGroup:NodeJsAppName}` *
     * `{ProcessGroup:NodeJsScriptName}` * `{ProcessGroup:OracleSid}` * `{ProcessGroup:PHPScriptPath}` *
     * `{ProcessGroup:PHPWorkingDirectory}` * `{ProcessGroup:Ports}` * `{ProcessGroup:RubyAppRootPath}` *
     * `{ProcessGroup:RubyScriptPath}` * `{ProcessGroup:SoftwareAGInstallRoot}` *
     * `{ProcessGroup:SoftwareAGProductPropertyName}` * `{ProcessGroup:SpringBootAppName}` *
     * `{ProcessGroup:SpringBootProfileName}` * `{ProcessGroup:SpringBootStartupClass}` *
     * `{ProcessGroup:TIBCOBusinessWorksAppNodeName}` * `{ProcessGroup:TIBCOBusinessWorksAppSpaceName}` *
     * `{ProcessGroup:TIBCOBusinessWorksCeAppName}` * `{ProcessGroup:TIBCOBusinessWorksCeVersion}` *
     * `{ProcessGroup:TIBCOBusinessWorksDomainName}` * `{ProcessGroup:TIBCOBusinessWorksEnginePropertyFilePath}` *
     * `{ProcessGroup:TIBCOBusinessWorksEnginePropertyFile}` * `{ProcessGroup:TIBCOBusinessWorksHome}` *
     * `{ProcessGroup:VarnishInstanceName}` * `{ProcessGroup:WebLogicClusterName}` * `{ProcessGroup:WebLogicDomainName}` *
     * `{ProcessGroup:WebLogicHome}` * `{ProcessGroup:WebLogicName}` * `{ProcessGroup:WebSphereCellName}` *
     * `{ProcessGroup:WebSphereClusterName}` * `{ProcessGroup:WebSphereNodeName}` * `{ProcessGroup:WebSphereServerName}` *
     * `{ProcessGroup:ActorSystem}` * `{Service:STGServerName}` * `{Service:DatabaseHostName}` * `{Service:DatabaseName}` *
     * `{Service:DatabaseVendor}` * `{Service:DetectedName}` * `{Service:EndpointPath}` * `{Service:EndpointPathGatewayUrl}` *
     * `{Service:IIBApplicationName}` * `{Service:MessageListenerClassName}` * `{Service:Port}` * `{Service:PublicDomainName}`
     * * `{Service:RemoteEndpoint}` * `{Service:RemoteName}` * `{Service:WebApplicationId}` * `{Service:WebContextRoot}` *
     * `{Service:WebServerName}` * `{Service:WebServiceNamespace}` * `{Service:WebServiceName}` * `{VmwareDatacenter:Name}` *
     * `{VmwareVm:Name}
     */
    format: pulumi.Input<string>;
    /**
     * The name of the rule
     */
    name?: pulumi.Input<string>;
    /**
     * allows for configuring properties that are not explicitly supported by the current version of this provider
     */
    unknowns?: pulumi.Input<string>;
}
