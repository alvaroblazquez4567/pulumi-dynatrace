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
    [DynatraceResourceType("dynatrace:index/kubernetesApp:KubernetesApp")]
    public partial class KubernetesApp : global::Pulumi.CustomResource
    {
        /// <summary>
        /// no documentation available
        /// </summary>
        [Output("kubernetesAppOptions")]
        public Output<Outputs.KubernetesAppKubernetesAppOptions> KubernetesAppOptions { get; private set; } = null!;

        /// <summary>
        /// The scope of this setting (KUBERNETES_CLUSTER). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Output("scope")]
        public Output<string?> Scope { get; private set; } = null!;


        /// <summary>
        /// Create a KubernetesApp resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public KubernetesApp(string name, KubernetesAppArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/kubernetesApp:KubernetesApp", name, args ?? new KubernetesAppArgs(), MakeResourceOptions(options, ""))
        {
        }

        private KubernetesApp(string name, Input<string> id, KubernetesAppState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/kubernetesApp:KubernetesApp", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing KubernetesApp resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static KubernetesApp Get(string name, Input<string> id, KubernetesAppState? state = null, CustomResourceOptions? options = null)
        {
            return new KubernetesApp(name, id, state, options);
        }
    }

    public sealed class KubernetesAppArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("kubernetesAppOptions", required: true)]
        public Input<Inputs.KubernetesAppKubernetesAppOptionsArgs> KubernetesAppOptions { get; set; } = null!;

        /// <summary>
        /// The scope of this setting (KUBERNETES_CLUSTER). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        public KubernetesAppArgs()
        {
        }
        public static new KubernetesAppArgs Empty => new KubernetesAppArgs();
    }

    public sealed class KubernetesAppState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("kubernetesAppOptions")]
        public Input<Inputs.KubernetesAppKubernetesAppOptionsGetArgs>? KubernetesAppOptions { get; set; }

        /// <summary>
        /// The scope of this setting (KUBERNETES_CLUSTER). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        public KubernetesAppState()
        {
        }
        public static new KubernetesAppState Empty => new KubernetesAppState();
    }
}
