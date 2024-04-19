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
    [DynatraceResourceType("dynatrace:index/failureDetectionParameters:FailureDetectionParameters")]
    public partial class FailureDetectionParameters : global::Pulumi.CustomResource
    {
        /// <summary>
        /// HTTP 404 response codes are thrown when a web server can't find a certain page. 404s are classified as broken links on the client side and therefore aren't considered to be service failures. By enabling this setting, you can have 404s treated as server-side service failures.
        /// </summary>
        [Output("brokenLinks")]
        public Output<Outputs.FailureDetectionParametersBrokenLinks> BrokenLinks { get; private set; } = null!;

        /// <summary>
        /// Description
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Customize failure detection for specific exceptions and errors
        /// </summary>
        [Output("exceptionRules")]
        public Output<Outputs.FailureDetectionParametersExceptionRules> ExceptionRules { get; private set; } = null!;

        /// <summary>
        /// HTTP response codes
        /// </summary>
        [Output("httpResponseCodes")]
        public Output<Outputs.FailureDetectionParametersHttpResponseCodes> HttpResponseCodes { get; private set; } = null!;

        /// <summary>
        /// Name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;


        /// <summary>
        /// Create a FailureDetectionParameters resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public FailureDetectionParameters(string name, FailureDetectionParametersArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/failureDetectionParameters:FailureDetectionParameters", name, args ?? new FailureDetectionParametersArgs(), MakeResourceOptions(options, ""))
        {
        }

        private FailureDetectionParameters(string name, Input<string> id, FailureDetectionParametersState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/failureDetectionParameters:FailureDetectionParameters", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing FailureDetectionParameters resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static FailureDetectionParameters Get(string name, Input<string> id, FailureDetectionParametersState? state = null, CustomResourceOptions? options = null)
        {
            return new FailureDetectionParameters(name, id, state, options);
        }
    }

    public sealed class FailureDetectionParametersArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// HTTP 404 response codes are thrown when a web server can't find a certain page. 404s are classified as broken links on the client side and therefore aren't considered to be service failures. By enabling this setting, you can have 404s treated as server-side service failures.
        /// </summary>
        [Input("brokenLinks", required: true)]
        public Input<Inputs.FailureDetectionParametersBrokenLinksArgs> BrokenLinks { get; set; } = null!;

        /// <summary>
        /// Description
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Customize failure detection for specific exceptions and errors
        /// </summary>
        [Input("exceptionRules", required: true)]
        public Input<Inputs.FailureDetectionParametersExceptionRulesArgs> ExceptionRules { get; set; } = null!;

        /// <summary>
        /// HTTP response codes
        /// </summary>
        [Input("httpResponseCodes", required: true)]
        public Input<Inputs.FailureDetectionParametersHttpResponseCodesArgs> HttpResponseCodes { get; set; } = null!;

        /// <summary>
        /// Name
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public FailureDetectionParametersArgs()
        {
        }
        public static new FailureDetectionParametersArgs Empty => new FailureDetectionParametersArgs();
    }

    public sealed class FailureDetectionParametersState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// HTTP 404 response codes are thrown when a web server can't find a certain page. 404s are classified as broken links on the client side and therefore aren't considered to be service failures. By enabling this setting, you can have 404s treated as server-side service failures.
        /// </summary>
        [Input("brokenLinks")]
        public Input<Inputs.FailureDetectionParametersBrokenLinksGetArgs>? BrokenLinks { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Customize failure detection for specific exceptions and errors
        /// </summary>
        [Input("exceptionRules")]
        public Input<Inputs.FailureDetectionParametersExceptionRulesGetArgs>? ExceptionRules { get; set; }

        /// <summary>
        /// HTTP response codes
        /// </summary>
        [Input("httpResponseCodes")]
        public Input<Inputs.FailureDetectionParametersHttpResponseCodesGetArgs>? HttpResponseCodes { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public FailureDetectionParametersState()
        {
        }
        public static new FailureDetectionParametersState Empty => new FailureDetectionParametersState();
    }
}
