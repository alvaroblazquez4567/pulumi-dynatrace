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
    [DynatraceResourceType("dynatrace:index/serviceExternalWebService:ServiceExternalWebService")]
    public partial class ServiceExternalWebService : global::Pulumi.CustomResource
    {
        /// <summary>
        /// A list of conditions necessary for the rule to take effect. If multiple conditions are specified, they must **all** match a Request for the rule to apply. If there is no condition at all, the rule is always applied. Conditions are evaluated against attributes, but do not modify them.
        /// </summary>
        [Output("conditions")]
        public Output<Outputs.ServiceExternalWebServiceConditions?> Conditions { get; private set; } = null!;

        /// <summary>
        /// Description
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Output("enabled")]
        public Output<bool> Enabled { get; private set; } = null!;

        /// <summary>
        /// Contributors to the Service Identifier calculation. URL path is always applied as an Id Contributor. You can exclude the port contribution by disabling the switch.
        /// </summary>
        [Output("idContributors")]
        public Output<Outputs.ServiceExternalWebServiceIdContributors> IdContributors { get; private set; } = null!;

        /// <summary>
        /// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        /// </summary>
        [Output("insertAfter")]
        public Output<string> InsertAfter { get; private set; } = null!;

        /// <summary>
        /// Define a management zone of the process group for which this service detection rule should be created.  Note: in case of external requests/services the PG might not always be known. See [here](https://dt-url.net/9i03b79)
        /// </summary>
        [Output("managementZones")]
        public Output<ImmutableArray<string>> ManagementZones { get; private set; } = null!;

        /// <summary>
        /// Rule name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;


        /// <summary>
        /// Create a ServiceExternalWebService resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ServiceExternalWebService(string name, ServiceExternalWebServiceArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/serviceExternalWebService:ServiceExternalWebService", name, args ?? new ServiceExternalWebServiceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ServiceExternalWebService(string name, Input<string> id, ServiceExternalWebServiceState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/serviceExternalWebService:ServiceExternalWebService", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ServiceExternalWebService resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ServiceExternalWebService Get(string name, Input<string> id, ServiceExternalWebServiceState? state = null, CustomResourceOptions? options = null)
        {
            return new ServiceExternalWebService(name, id, state, options);
        }
    }

    public sealed class ServiceExternalWebServiceArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// A list of conditions necessary for the rule to take effect. If multiple conditions are specified, they must **all** match a Request for the rule to apply. If there is no condition at all, the rule is always applied. Conditions are evaluated against attributes, but do not modify them.
        /// </summary>
        [Input("conditions")]
        public Input<Inputs.ServiceExternalWebServiceConditionsArgs>? Conditions { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// Contributors to the Service Identifier calculation. URL path is always applied as an Id Contributor. You can exclude the port contribution by disabling the switch.
        /// </summary>
        [Input("idContributors", required: true)]
        public Input<Inputs.ServiceExternalWebServiceIdContributorsArgs> IdContributors { get; set; } = null!;

        /// <summary>
        /// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        /// </summary>
        [Input("insertAfter")]
        public Input<string>? InsertAfter { get; set; }

        [Input("managementZones")]
        private InputList<string>? _managementZones;

        /// <summary>
        /// Define a management zone of the process group for which this service detection rule should be created.  Note: in case of external requests/services the PG might not always be known. See [here](https://dt-url.net/9i03b79)
        /// </summary>
        public InputList<string> ManagementZones
        {
            get => _managementZones ?? (_managementZones = new InputList<string>());
            set => _managementZones = value;
        }

        /// <summary>
        /// Rule name
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public ServiceExternalWebServiceArgs()
        {
        }
        public static new ServiceExternalWebServiceArgs Empty => new ServiceExternalWebServiceArgs();
    }

    public sealed class ServiceExternalWebServiceState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// A list of conditions necessary for the rule to take effect. If multiple conditions are specified, they must **all** match a Request for the rule to apply. If there is no condition at all, the rule is always applied. Conditions are evaluated against attributes, but do not modify them.
        /// </summary>
        [Input("conditions")]
        public Input<Inputs.ServiceExternalWebServiceConditionsGetArgs>? Conditions { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// Contributors to the Service Identifier calculation. URL path is always applied as an Id Contributor. You can exclude the port contribution by disabling the switch.
        /// </summary>
        [Input("idContributors")]
        public Input<Inputs.ServiceExternalWebServiceIdContributorsGetArgs>? IdContributors { get; set; }

        /// <summary>
        /// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        /// </summary>
        [Input("insertAfter")]
        public Input<string>? InsertAfter { get; set; }

        [Input("managementZones")]
        private InputList<string>? _managementZones;

        /// <summary>
        /// Define a management zone of the process group for which this service detection rule should be created.  Note: in case of external requests/services the PG might not always be known. See [here](https://dt-url.net/9i03b79)
        /// </summary>
        public InputList<string> ManagementZones
        {
            get => _managementZones ?? (_managementZones = new InputList<string>());
            set => _managementZones = value;
        }

        /// <summary>
        /// Rule name
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public ServiceExternalWebServiceState()
        {
        }
        public static new ServiceExternalWebServiceState Empty => new ServiceExternalWebServiceState();
    }
}
