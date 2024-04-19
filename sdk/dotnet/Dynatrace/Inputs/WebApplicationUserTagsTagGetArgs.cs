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

    public sealed class WebApplicationUserTagsTagGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Cleanup rule expression of the userTag
        /// </summary>
        [Input("cleanupRule")]
        public Input<string>? CleanupRule { get; set; }

        /// <summary>
        /// The ID of conversion goal.
        /// </summary>
        [Input("id")]
        public Input<int>? Id { get; set; }

        /// <summary>
        /// Case insensitive naming
        /// </summary>
        [Input("ignoreCase")]
        public Input<bool>? IgnoreCase { get; set; }

        /// <summary>
        /// The ID of the metadata
        /// </summary>
        [Input("metadataId")]
        public Input<int>? MetadataId { get; set; }

        /// <summary>
        /// The ID of the RrequestAttribute for the userTag
        /// </summary>
        [Input("serverSideRequestAttribute")]
        public Input<string>? ServerSideRequestAttribute { get; set; }

        /// <summary>
        /// The unique ID of the meta data to capture
        /// </summary>
        [Input("uniqueId")]
        public Input<int>? UniqueId { get; set; }

        public WebApplicationUserTagsTagGetArgs()
        {
        }
        public static new WebApplicationUserTagsTagGetArgs Empty => new WebApplicationUserTagsTagGetArgs();
    }
}