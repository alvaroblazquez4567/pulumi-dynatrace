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
    public sealed class LogEventsEventTemplateMetadataItem
    {
        /// <summary>
        /// Type 'dt.' for key hints.
        /// </summary>
        public readonly string MetadataKey;
        /// <summary>
        /// no documentation available
        /// </summary>
        public readonly string MetadataValue;

        [OutputConstructor]
        private LogEventsEventTemplateMetadataItem(
            string metadataKey,

            string metadataValue)
        {
            MetadataKey = metadataKey;
            MetadataValue = metadataValue;
        }
    }
}
