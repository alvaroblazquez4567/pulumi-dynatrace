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
    [DynatraceResourceType("dynatrace:index/webAppEnablement:WebAppEnablement")]
    public partial class WebAppEnablement : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        /// </summary>
        [Output("applicationId")]
        public Output<string?> ApplicationId { get; private set; } = null!;

        /// <summary>
        /// Capture and analyze all user actions within your application. Enable [Real User Monitoring (RUM)](https://dt-url.net/1n2b0prq) to monitor and improve your application's performance, identify errors, and gain insight into your user's behavior and experience.
        /// </summary>
        [Output("rum")]
        public Output<Outputs.WebAppEnablementRum> Rum { get; private set; } = null!;

        /// <summary>
        /// [Session Replay](https://dt-url.net/session-replay) captures all user interactions within your application and replays them in a movie-like experience while providing [best-in-class security and data protection](https://dt-url.net/b303zxj).
        /// </summary>
        [Output("sessionReplay")]
        public Output<Outputs.WebAppEnablementSessionReplay> SessionReplay { get; private set; } = null!;


        /// <summary>
        /// Create a WebAppEnablement resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public WebAppEnablement(string name, WebAppEnablementArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/webAppEnablement:WebAppEnablement", name, args ?? new WebAppEnablementArgs(), MakeResourceOptions(options, ""))
        {
        }

        private WebAppEnablement(string name, Input<string> id, WebAppEnablementState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/webAppEnablement:WebAppEnablement", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing WebAppEnablement resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static WebAppEnablement Get(string name, Input<string> id, WebAppEnablementState? state = null, CustomResourceOptions? options = null)
        {
            return new WebAppEnablement(name, id, state, options);
        }
    }

    public sealed class WebAppEnablementArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        /// </summary>
        [Input("applicationId")]
        public Input<string>? ApplicationId { get; set; }

        /// <summary>
        /// Capture and analyze all user actions within your application. Enable [Real User Monitoring (RUM)](https://dt-url.net/1n2b0prq) to monitor and improve your application's performance, identify errors, and gain insight into your user's behavior and experience.
        /// </summary>
        [Input("rum", required: true)]
        public Input<Inputs.WebAppEnablementRumArgs> Rum { get; set; } = null!;

        /// <summary>
        /// [Session Replay](https://dt-url.net/session-replay) captures all user interactions within your application and replays them in a movie-like experience while providing [best-in-class security and data protection](https://dt-url.net/b303zxj).
        /// </summary>
        [Input("sessionReplay", required: true)]
        public Input<Inputs.WebAppEnablementSessionReplayArgs> SessionReplay { get; set; } = null!;

        public WebAppEnablementArgs()
        {
        }
        public static new WebAppEnablementArgs Empty => new WebAppEnablementArgs();
    }

    public sealed class WebAppEnablementState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        /// </summary>
        [Input("applicationId")]
        public Input<string>? ApplicationId { get; set; }

        /// <summary>
        /// Capture and analyze all user actions within your application. Enable [Real User Monitoring (RUM)](https://dt-url.net/1n2b0prq) to monitor and improve your application's performance, identify errors, and gain insight into your user's behavior and experience.
        /// </summary>
        [Input("rum")]
        public Input<Inputs.WebAppEnablementRumGetArgs>? Rum { get; set; }

        /// <summary>
        /// [Session Replay](https://dt-url.net/session-replay) captures all user interactions within your application and replays them in a movie-like experience while providing [best-in-class security and data protection](https://dt-url.net/b303zxj).
        /// </summary>
        [Input("sessionReplay")]
        public Input<Inputs.WebAppEnablementSessionReplayGetArgs>? SessionReplay { get; set; }

        public WebAppEnablementState()
        {
        }
        public static new WebAppEnablementState Empty => new WebAppEnablementState();
    }
}