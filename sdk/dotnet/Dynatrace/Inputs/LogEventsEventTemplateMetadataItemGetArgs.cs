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

    public sealed class LogEventsEventTemplateMetadataItemGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Type 'dt.' for key hints.
        /// </summary>
        [Input("metadataKey", required: true)]
        public Input<string> MetadataKey { get; set; } = null!;

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("metadataValue", required: true)]
        public Input<string> MetadataValue { get; set; } = null!;

        public LogEventsEventTemplateMetadataItemGetArgs()
        {
        }
        public static new LogEventsEventTemplateMetadataItemGetArgs Empty => new LogEventsEventTemplateMetadataItemGetArgs();
    }
}
