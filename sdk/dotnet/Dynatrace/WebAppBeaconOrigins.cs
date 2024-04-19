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
    [DynatraceResourceType("dynatrace:index/webAppBeaconOrigins:WebAppBeaconOrigins")]
    public partial class WebAppBeaconOrigins : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Possible Values: `CONTAINS`, `ENDS_WITH`, `EQUALS`, `STARTS_WITH`
        /// </summary>
        [Output("matcher")]
        public Output<string> Matcher { get; private set; } = null!;

        /// <summary>
        /// Pattern
        /// </summary>
        [Output("pattern")]
        public Output<string> Pattern { get; private set; } = null!;


        /// <summary>
        /// Create a WebAppBeaconOrigins resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public WebAppBeaconOrigins(string name, WebAppBeaconOriginsArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/webAppBeaconOrigins:WebAppBeaconOrigins", name, args ?? new WebAppBeaconOriginsArgs(), MakeResourceOptions(options, ""))
        {
        }

        private WebAppBeaconOrigins(string name, Input<string> id, WebAppBeaconOriginsState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/webAppBeaconOrigins:WebAppBeaconOrigins", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing WebAppBeaconOrigins resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static WebAppBeaconOrigins Get(string name, Input<string> id, WebAppBeaconOriginsState? state = null, CustomResourceOptions? options = null)
        {
            return new WebAppBeaconOrigins(name, id, state, options);
        }
    }

    public sealed class WebAppBeaconOriginsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Possible Values: `CONTAINS`, `ENDS_WITH`, `EQUALS`, `STARTS_WITH`
        /// </summary>
        [Input("matcher", required: true)]
        public Input<string> Matcher { get; set; } = null!;

        /// <summary>
        /// Pattern
        /// </summary>
        [Input("pattern", required: true)]
        public Input<string> Pattern { get; set; } = null!;

        public WebAppBeaconOriginsArgs()
        {
        }
        public static new WebAppBeaconOriginsArgs Empty => new WebAppBeaconOriginsArgs();
    }

    public sealed class WebAppBeaconOriginsState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Possible Values: `CONTAINS`, `ENDS_WITH`, `EQUALS`, `STARTS_WITH`
        /// </summary>
        [Input("matcher")]
        public Input<string>? Matcher { get; set; }

        /// <summary>
        /// Pattern
        /// </summary>
        [Input("pattern")]
        public Input<string>? Pattern { get; set; }

        public WebAppBeaconOriginsState()
        {
        }
        public static new WebAppBeaconOriginsState Empty => new WebAppBeaconOriginsState();
    }
}