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

    public sealed class AlertingFiltersFilterCustomGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Configuration of a matching filter
        /// </summary>
        [Input("description")]
        public Input<Inputs.AlertingFiltersFilterCustomDescriptionGetArgs>? Description { get; set; }

        /// <summary>
        /// Configuration of a matching filter
        /// </summary>
        [Input("metadata")]
        public Input<Inputs.AlertingFiltersFilterCustomMetadataGetArgs>? Metadata { get; set; }

        /// <summary>
        /// Configuration of a matching filter
        /// </summary>
        [Input("title")]
        public Input<Inputs.AlertingFiltersFilterCustomTitleGetArgs>? Title { get; set; }

        public AlertingFiltersFilterCustomGetArgs()
        {
        }
        public static new AlertingFiltersFilterCustomGetArgs Empty => new AlertingFiltersFilterCustomGetArgs();
    }
}
