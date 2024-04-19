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

    public sealed class WebhookNotificationHeadersArgs : global::Pulumi.ResourceArgs
    {
        [Input("headers", required: true)]
        private InputList<Inputs.WebhookNotificationHeadersHeaderArgs>? _headers;

        /// <summary>
        /// An additional HTTP Header to include when sending requests
        /// </summary>
        public InputList<Inputs.WebhookNotificationHeadersHeaderArgs> Headers
        {
            get => _headers ?? (_headers = new InputList<Inputs.WebhookNotificationHeadersHeaderArgs>());
            set => _headers = value;
        }

        public WebhookNotificationHeadersArgs()
        {
        }
        public static new WebhookNotificationHeadersArgs Empty => new WebhookNotificationHeadersArgs();
    }
}
