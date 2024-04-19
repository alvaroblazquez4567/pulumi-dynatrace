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
    [DynatraceResourceType("dynatrace:index/serviceFailure:ServiceFailure")]
    public partial class ServiceFailure : global::Pulumi.CustomResource
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Output("enabled")]
        public Output<bool> Enabled { get; private set; } = null!;

        /// <summary>
        /// Customize failure detection for specific exceptions and errors
        /// </summary>
        [Output("exceptionRules")]
        public Output<Outputs.ServiceFailureExceptionRules?> ExceptionRules { get; private set; } = null!;

        /// <summary>
        /// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        /// </summary>
        [Output("serviceId")]
        public Output<string> ServiceId { get; private set; } = null!;


        /// <summary>
        /// Create a ServiceFailure resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ServiceFailure(string name, ServiceFailureArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/serviceFailure:ServiceFailure", name, args ?? new ServiceFailureArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ServiceFailure(string name, Input<string> id, ServiceFailureState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/serviceFailure:ServiceFailure", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ServiceFailure resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ServiceFailure Get(string name, Input<string> id, ServiceFailureState? state = null, CustomResourceOptions? options = null)
        {
            return new ServiceFailure(name, id, state, options);
        }
    }

    public sealed class ServiceFailureArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// Customize failure detection for specific exceptions and errors
        /// </summary>
        [Input("exceptionRules")]
        public Input<Inputs.ServiceFailureExceptionRulesArgs>? ExceptionRules { get; set; }

        /// <summary>
        /// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        /// </summary>
        [Input("serviceId", required: true)]
        public Input<string> ServiceId { get; set; } = null!;

        public ServiceFailureArgs()
        {
        }
        public static new ServiceFailureArgs Empty => new ServiceFailureArgs();
    }

    public sealed class ServiceFailureState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// Customize failure detection for specific exceptions and errors
        /// </summary>
        [Input("exceptionRules")]
        public Input<Inputs.ServiceFailureExceptionRulesGetArgs>? ExceptionRules { get; set; }

        /// <summary>
        /// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        /// </summary>
        [Input("serviceId")]
        public Input<string>? ServiceId { get; set; }

        public ServiceFailureState()
        {
        }
        public static new ServiceFailureState Empty => new ServiceFailureState();
    }
}
