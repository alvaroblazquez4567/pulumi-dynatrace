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

    public sealed class AppsecNotificationWebhookConfigurationArgs : global::Pulumi.ResourceArgs
    {
        [Input("acceptAnyCertificate", required: true)]
        public Input<bool> AcceptAnyCertificate { get; set; } = null!;

        [Input("headers")]
        public Input<Inputs.AppsecNotificationWebhookConfigurationHeadersArgs>? Headers { get; set; }

        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        public AppsecNotificationWebhookConfigurationArgs()
        {
        }
        public static new AppsecNotificationWebhookConfigurationArgs Empty => new AppsecNotificationWebhookConfigurationArgs();
    }
}
