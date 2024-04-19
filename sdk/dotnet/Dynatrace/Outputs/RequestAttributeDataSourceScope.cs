// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Lbrlabs.PulumiPackage.Dynatrace.Outputs
{

    [OutputType]
    public sealed class RequestAttributeDataSourceScope
    {
        /// <summary>
        /// Only applies to this host group
        /// </summary>
        public readonly string? HostGroup;
        /// <summary>
        /// Only applies to this process group. Note that this can't be transferred between different clusters or environments
        /// </summary>
        public readonly string? ProcessGroup;
        /// <summary>
        /// Only applies to this service technology
        /// </summary>
        public readonly string? ServiceTechnology;
        /// <summary>
        /// Only apply to process groups matching this tag
        /// </summary>
        public readonly string? TagOfProcessGroup;
        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        public readonly string? Unknowns;

        [OutputConstructor]
        private RequestAttributeDataSourceScope(
            string? hostGroup,

            string? processGroup,

            string? serviceTechnology,

            string? tagOfProcessGroup,

            string? unknowns)
        {
            HostGroup = hostGroup;
            ProcessGroup = processGroup;
            ServiceTechnology = serviceTechnology;
            TagOfProcessGroup = tagOfProcessGroup;
            Unknowns = unknowns;
        }
    }
}
