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

    public sealed class FailureDetectionParametersBrokenLinksArgs : global::Pulumi.ResourceArgs
    {
        [Input("brokenLinkDomains")]
        private InputList<string>? _brokenLinkDomains;

        /// <summary>
        /// If your application relies on other hosts at other domains, add the associated domain names here. Once configured, Dynatrace will consider 404s thrown by hosts at these domains to be service failures related to your application.
        /// </summary>
        public InputList<string> BrokenLinkDomains
        {
            get => _brokenLinkDomains ?? (_brokenLinkDomains = new InputList<string>());
            set => _brokenLinkDomains = value;
        }

        /// <summary>
        /// Consider 404 HTTP response codes as failures
        /// </summary>
        [Input("http404NotFoundFailures", required: true)]
        public Input<bool> Http404NotFoundFailures { get; set; } = null!;

        public FailureDetectionParametersBrokenLinksArgs()
        {
        }
        public static new FailureDetectionParametersBrokenLinksArgs Empty => new FailureDetectionParametersBrokenLinksArgs();
    }
}
