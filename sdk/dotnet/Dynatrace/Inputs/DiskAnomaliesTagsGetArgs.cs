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

    public sealed class DiskAnomaliesTagsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("filters")]
        private InputList<Inputs.DiskAnomaliesTagsFilterGetArgs>? _filters;

        /// <summary>
        /// A Tag Filter
        /// </summary>
        public InputList<Inputs.DiskAnomaliesTagsFilterGetArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.DiskAnomaliesTagsFilterGetArgs>());
            set => _filters = value;
        }

        public DiskAnomaliesTagsGetArgs()
        {
        }
        public static new DiskAnomaliesTagsGetArgs Empty => new DiskAnomaliesTagsGetArgs();
    }
}
