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

    public sealed class RequestAttributeDataSourceScopeGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Only applies to this host group
        /// </summary>
        [Input("hostGroup")]
        public Input<string>? HostGroup { get; set; }

        /// <summary>
        /// Only applies to this process group. Note that this can't be transferred between different clusters or environments
        /// </summary>
        [Input("processGroup")]
        public Input<string>? ProcessGroup { get; set; }

        /// <summary>
        /// Only applies to this service technology
        /// </summary>
        [Input("serviceTechnology")]
        public Input<string>? ServiceTechnology { get; set; }

        /// <summary>
        /// Only apply to process groups matching this tag
        /// </summary>
        [Input("tagOfProcessGroup")]
        public Input<string>? TagOfProcessGroup { get; set; }

        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        public RequestAttributeDataSourceScopeGetArgs()
        {
        }
        public static new RequestAttributeDataSourceScopeGetArgs Empty => new RequestAttributeDataSourceScopeGetArgs();
    }
}
