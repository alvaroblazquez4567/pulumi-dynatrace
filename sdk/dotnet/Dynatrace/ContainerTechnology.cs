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
    [DynatraceResourceType("dynatrace:index/containerTechnology:ContainerTechnology")]
    public partial class ContainerTechnology : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Platform: Cloud Foundry
        /// </summary>
        [Output("boshProcessManager")]
        public Output<bool> BoshProcessManager { get; private set; } = null!;

        /// <summary>
        /// Platform: Kubernetes Status: Released Operating system: Linux Min agent version: 1.169
        /// </summary>
        [Output("containerd")]
        public Output<bool> Containerd { get; private set; } = null!;

        /// <summary>
        /// Platform: Kubernetes Status: Released Operating system: Linux Min agent version: 1.163
        /// </summary>
        [Output("crio")]
        public Output<bool> Crio { get; private set; } = null!;

        /// <summary>
        /// Platform: Docker and Kubernetes Status: Released Operating system: Linux
        /// </summary>
        [Output("docker")]
        public Output<bool> Docker { get; private set; } = null!;

        /// <summary>
        /// Platform: Docker Status: Early adopter Operating system: Windows Min agent version: 1.149
        /// </summary>
        [Output("dockerWindows")]
        public Output<bool> DockerWindows { get; private set; } = null!;

        /// <summary>
        /// Platform: Cloud Foundry Status: Released Operating system: Linux Min agent version: 1.133
        /// </summary>
        [Output("garden")]
        public Output<bool> Garden { get; private set; } = null!;

        /// <summary>
        /// Platform: Podman Status: Released Operating system: Linux Min agent version: 1.267
        /// </summary>
        [Output("podman")]
        public Output<bool> Podman { get; private set; } = null!;

        /// <summary>
        /// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Output("scope")]
        public Output<string?> Scope { get; private set; } = null!;

        /// <summary>
        /// Platform: Cloud Foundry Status: Early adopter Operating system: Windows Min agent version: 1.175
        /// </summary>
        [Output("winc")]
        public Output<bool> Winc { get; private set; } = null!;


        /// <summary>
        /// Create a ContainerTechnology resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ContainerTechnology(string name, ContainerTechnologyArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/containerTechnology:ContainerTechnology", name, args ?? new ContainerTechnologyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ContainerTechnology(string name, Input<string> id, ContainerTechnologyState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/containerTechnology:ContainerTechnology", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ContainerTechnology resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ContainerTechnology Get(string name, Input<string> id, ContainerTechnologyState? state = null, CustomResourceOptions? options = null)
        {
            return new ContainerTechnology(name, id, state, options);
        }
    }

    public sealed class ContainerTechnologyArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Platform: Cloud Foundry
        /// </summary>
        [Input("boshProcessManager", required: true)]
        public Input<bool> BoshProcessManager { get; set; } = null!;

        /// <summary>
        /// Platform: Kubernetes Status: Released Operating system: Linux Min agent version: 1.169
        /// </summary>
        [Input("containerd", required: true)]
        public Input<bool> Containerd { get; set; } = null!;

        /// <summary>
        /// Platform: Kubernetes Status: Released Operating system: Linux Min agent version: 1.163
        /// </summary>
        [Input("crio", required: true)]
        public Input<bool> Crio { get; set; } = null!;

        /// <summary>
        /// Platform: Docker and Kubernetes Status: Released Operating system: Linux
        /// </summary>
        [Input("docker", required: true)]
        public Input<bool> Docker { get; set; } = null!;

        /// <summary>
        /// Platform: Docker Status: Early adopter Operating system: Windows Min agent version: 1.149
        /// </summary>
        [Input("dockerWindows", required: true)]
        public Input<bool> DockerWindows { get; set; } = null!;

        /// <summary>
        /// Platform: Cloud Foundry Status: Released Operating system: Linux Min agent version: 1.133
        /// </summary>
        [Input("garden", required: true)]
        public Input<bool> Garden { get; set; } = null!;

        /// <summary>
        /// Platform: Podman Status: Released Operating system: Linux Min agent version: 1.267
        /// </summary>
        [Input("podman", required: true)]
        public Input<bool> Podman { get; set; } = null!;

        /// <summary>
        /// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        /// <summary>
        /// Platform: Cloud Foundry Status: Early adopter Operating system: Windows Min agent version: 1.175
        /// </summary>
        [Input("winc", required: true)]
        public Input<bool> Winc { get; set; } = null!;

        public ContainerTechnologyArgs()
        {
        }
        public static new ContainerTechnologyArgs Empty => new ContainerTechnologyArgs();
    }

    public sealed class ContainerTechnologyState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Platform: Cloud Foundry
        /// </summary>
        [Input("boshProcessManager")]
        public Input<bool>? BoshProcessManager { get; set; }

        /// <summary>
        /// Platform: Kubernetes Status: Released Operating system: Linux Min agent version: 1.169
        /// </summary>
        [Input("containerd")]
        public Input<bool>? Containerd { get; set; }

        /// <summary>
        /// Platform: Kubernetes Status: Released Operating system: Linux Min agent version: 1.163
        /// </summary>
        [Input("crio")]
        public Input<bool>? Crio { get; set; }

        /// <summary>
        /// Platform: Docker and Kubernetes Status: Released Operating system: Linux
        /// </summary>
        [Input("docker")]
        public Input<bool>? Docker { get; set; }

        /// <summary>
        /// Platform: Docker Status: Early adopter Operating system: Windows Min agent version: 1.149
        /// </summary>
        [Input("dockerWindows")]
        public Input<bool>? DockerWindows { get; set; }

        /// <summary>
        /// Platform: Cloud Foundry Status: Released Operating system: Linux Min agent version: 1.133
        /// </summary>
        [Input("garden")]
        public Input<bool>? Garden { get; set; }

        /// <summary>
        /// Platform: Podman Status: Released Operating system: Linux Min agent version: 1.267
        /// </summary>
        [Input("podman")]
        public Input<bool>? Podman { get; set; }

        /// <summary>
        /// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        /// <summary>
        /// Platform: Cloud Foundry Status: Early adopter Operating system: Windows Min agent version: 1.175
        /// </summary>
        [Input("winc")]
        public Input<bool>? Winc { get; set; }

        public ContainerTechnologyState()
        {
        }
        public static new ContainerTechnologyState Empty => new ContainerTechnologyState();
    }
}