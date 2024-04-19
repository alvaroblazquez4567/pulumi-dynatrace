// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Lbrlabs.PulumiPackage.Dynatrace
{
    /// <summary>
    /// &gt; This resource is excluded by default in the export utility.
    /// 
    /// &gt; This resource requires the API token scopes **Read configuration** (`ReadConfig`) and **Write configuration** (`WriteConfig`)
    /// 
    /// ## Dynatrace Documentation
    /// 
    /// - Microsoft Azure monitoring - https://www.dynatrace.com/support/help/how-to-use-dynatrace/infrastructure-monitoring/cloud-platform-monitoring/microsoft-azure-services-monitoring
    /// 
    /// - Azure credentials API - https://www.dynatrace.com/support/help/dynatrace-api/configuration-api/azure-credentials-api
    /// 
    /// ## Resource Example Usage
    /// 
    /// This example utilizes the data source `dynatrace.getAzureSupportedServices` in order to query for a full list of all supported services.
    /// The `for_each` loop within the resource `dynatrace.AzureService` configures each of these services to get utilized with the default metrics recommended by Dynatrace (`use_recommended_metrics`).
    /// 
    /// If you want to configure a different set of metrics for a specific service, a separate resource `dynatrace.AzureService` will be necessary for that. That allows you to configure the `metric` blocks according to your wishes.
    /// Just be aware of the fact, that Dynatrace enforces for most services a recommended set of metrics. All of them need to be part of your configuration in order to end up with a non-empty plan.
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using System.Threading.Tasks;
    /// using Pulumi;
    /// using Dynatrace = Lbrlabs.PulumiPackage.Dynatrace;
    /// using Dynatrace = Pulumi.Dynatrace;
    /// 
    /// return await Deployment.RunAsync(async() =&gt; 
    /// {
    ///     var tERRAFORMSAMPLE = new Dynatrace.AzureCredentials("tERRAFORMSAMPLE", new()
    ///     {
    ///         Active = false,
    ///         AppId = "ABCDE",
    ///         AutoTagging = true,
    ///         DirectoryId = "ABCDE",
    ///         Label = "TERRAFORM_SAMPLE",
    ///         Key = "aaaa",
    ///         MonitorOnlyTaggedEntities = true,
    ///         MonitorOnlyTagPairs = new[]
    ///         {
    ///             new Dynatrace.Inputs.AzureCredentialsMonitorOnlyTagPairArgs
    ///             {
    ///                 Name = "string",
    ///                 Value = "string",
    ///             },
    ///         },
    ///     });
    /// 
    ///     var supportedServices = await Dynatrace.GetAzureSupportedServices.InvokeAsync(new()
    ///     {
    ///         Excepts = new[]
    ///         {
    ///             "AZURE_STORAGE_ACCOUNT",
    ///         },
    ///     });
    /// 
    ///     var tERRAFORMSAMPLEServices = new List&lt;Dynatrace.AzureService&gt;();
    ///     foreach (var range in )
    ///     {
    ///         tERRAFORMSAMPLEServices.Add(new Dynatrace.AzureService($"tERRAFORMSAMPLEServices-{range.Key}", new()
    ///         {
    ///             CredentialsId = tERRAFORMSAMPLE.Id,
    ///             UseRecommendedMetrics = true,
    ///         }));
    ///     }
    /// });
    /// ```
    /// </summary>
    [DynatraceResourceType("dynatrace:index/azureService:AzureService")]
    public partial class AzureService : global::Pulumi.CustomResource
    {
        /// <summary>
        /// This attribute is automatically set to `true` if Dynatrace considers the supporting service with the given name to be a built-in service
        /// </summary>
        [Output("builtIn")]
        public Output<bool> BuiltIn { get; private set; } = null!;

        /// <summary>
        /// the ID of the azure credentials this supported service belongs to
        /// </summary>
        [Output("credentialsId")]
        public Output<string> CredentialsId { get; private set; } = null!;

        /// <summary>
        /// A list of metrics to be monitored for this service. Depending on the service Dynatrace insists on a set of recommended
        /// metrics to be configured for that service. If any of these recommended metrics is missing here, the Terraform Provider
        /// will automatically add them during `terraform apply`. This usually results in a non-empty plan, until all of the
        /// recommended metrics are present within your configuration. For services considered `built-in` by Dynatrace any metrics
        /// specified here will be ignored - Dynatrace enforces a fixed set of metrics for these services.
        /// </summary>
        [Output("metrics")]
        public Output<ImmutableArray<Outputs.AzureServiceMetric>> Metrics { get; private set; } = null!;

        /// <summary>
        /// the name of the metric of the supporting service
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Used internally by the Terraform Provider in order to remember the metrics enforced by Dynatrace
        /// </summary>
        [Output("requiredMetrics")]
        public Output<string> RequiredMetrics { get; private set; } = null!;

        /// <summary>
        /// If `true` Terraform will negotiate with the Dynatrace API about the recommended/enforced metrics to be applied. Any
        /// `metric` specified will be therefore ignored.
        /// </summary>
        [Output("useRecommendedMetrics")]
        public Output<bool?> UseRecommendedMetrics { get; private set; } = null!;


        /// <summary>
        /// Create a AzureService resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AzureService(string name, AzureServiceArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/azureService:AzureService", name, args ?? new AzureServiceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AzureService(string name, Input<string> id, AzureServiceState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/azureService:AzureService", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/alvaroblazquez4567",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing AzureService resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AzureService Get(string name, Input<string> id, AzureServiceState? state = null, CustomResourceOptions? options = null)
        {
            return new AzureService(name, id, state, options);
        }
    }

    public sealed class AzureServiceArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// the ID of the azure credentials this supported service belongs to
        /// </summary>
        [Input("credentialsId", required: true)]
        public Input<string> CredentialsId { get; set; } = null!;

        [Input("metrics")]
        private InputList<Inputs.AzureServiceMetricArgs>? _metrics;

        /// <summary>
        /// A list of metrics to be monitored for this service. Depending on the service Dynatrace insists on a set of recommended
        /// metrics to be configured for that service. If any of these recommended metrics is missing here, the Terraform Provider
        /// will automatically add them during `terraform apply`. This usually results in a non-empty plan, until all of the
        /// recommended metrics are present within your configuration. For services considered `built-in` by Dynatrace any metrics
        /// specified here will be ignored - Dynatrace enforces a fixed set of metrics for these services.
        /// </summary>
        public InputList<Inputs.AzureServiceMetricArgs> Metrics
        {
            get => _metrics ?? (_metrics = new InputList<Inputs.AzureServiceMetricArgs>());
            set => _metrics = value;
        }

        /// <summary>
        /// the name of the metric of the supporting service
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// If `true` Terraform will negotiate with the Dynatrace API about the recommended/enforced metrics to be applied. Any
        /// `metric` specified will be therefore ignored.
        /// </summary>
        [Input("useRecommendedMetrics")]
        public Input<bool>? UseRecommendedMetrics { get; set; }

        public AzureServiceArgs()
        {
        }
        public static new AzureServiceArgs Empty => new AzureServiceArgs();
    }

    public sealed class AzureServiceState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// This attribute is automatically set to `true` if Dynatrace considers the supporting service with the given name to be a built-in service
        /// </summary>
        [Input("builtIn")]
        public Input<bool>? BuiltIn { get; set; }

        /// <summary>
        /// the ID of the azure credentials this supported service belongs to
        /// </summary>
        [Input("credentialsId")]
        public Input<string>? CredentialsId { get; set; }

        [Input("metrics")]
        private InputList<Inputs.AzureServiceMetricGetArgs>? _metrics;

        /// <summary>
        /// A list of metrics to be monitored for this service. Depending on the service Dynatrace insists on a set of recommended
        /// metrics to be configured for that service. If any of these recommended metrics is missing here, the Terraform Provider
        /// will automatically add them during `terraform apply`. This usually results in a non-empty plan, until all of the
        /// recommended metrics are present within your configuration. For services considered `built-in` by Dynatrace any metrics
        /// specified here will be ignored - Dynatrace enforces a fixed set of metrics for these services.
        /// </summary>
        public InputList<Inputs.AzureServiceMetricGetArgs> Metrics
        {
            get => _metrics ?? (_metrics = new InputList<Inputs.AzureServiceMetricGetArgs>());
            set => _metrics = value;
        }

        /// <summary>
        /// the name of the metric of the supporting service
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Used internally by the Terraform Provider in order to remember the metrics enforced by Dynatrace
        /// </summary>
        [Input("requiredMetrics")]
        public Input<string>? RequiredMetrics { get; set; }

        /// <summary>
        /// If `true` Terraform will negotiate with the Dynatrace API about the recommended/enforced metrics to be applied. Any
        /// `metric` specified will be therefore ignored.
        /// </summary>
        [Input("useRecommendedMetrics")]
        public Input<bool>? UseRecommendedMetrics { get; set; }

        public AzureServiceState()
        {
        }
        public static new AzureServiceState Empty => new AzureServiceState();
    }
}