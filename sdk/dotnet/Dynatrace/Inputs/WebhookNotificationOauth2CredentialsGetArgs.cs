// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Lbrlabs.PulumiPackage.Dynatrace.Inputs
{

    public sealed class WebhookNotificationOauth2CredentialsGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Access token URL
        /// </summary>
        [Input("accessTokenUrl", required: true)]
        public Input<string> AccessTokenUrl { get; set; } = null!;

        /// <summary>
        /// Client ID
        /// </summary>
        [Input("clientId", required: true)]
        public Input<string> ClientId { get; set; } = null!;

        [Input("clientSecret", required: true)]
        private Input<string>? _clientSecret;

        /// <summary>
        /// Client secret
        /// </summary>
        public Input<string>? ClientSecret
        {
            get => _clientSecret;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _clientSecret = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// The scope of access you are requesting
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        public WebhookNotificationOauth2CredentialsGetArgs()
        {
        }
        public static new WebhookNotificationOauth2CredentialsGetArgs Empty => new WebhookNotificationOauth2CredentialsGetArgs();
    }
}
