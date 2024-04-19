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

    public sealed class CustomAnomaliesDimensionGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("dimensions")]
        private InputList<Inputs.CustomAnomaliesDimensionDimensionGetArgs>? _dimensions;

        /// <summary>
        /// A generic definition for a filter
        /// </summary>
        public InputList<Inputs.CustomAnomaliesDimensionDimensionGetArgs> Dimensions
        {
            get => _dimensions ?? (_dimensions = new InputList<Inputs.CustomAnomaliesDimensionDimensionGetArgs>());
            set => _dimensions = value;
        }

        [Input("entities")]
        private InputList<Inputs.CustomAnomaliesDimensionEntityGetArgs>? _entities;

        /// <summary>
        /// A filter for the metrics entity dimensions
        /// </summary>
        public InputList<Inputs.CustomAnomaliesDimensionEntityGetArgs> Entities
        {
            get => _entities ?? (_entities = new InputList<Inputs.CustomAnomaliesDimensionEntityGetArgs>());
            set => _entities = value;
        }

        [Input("strings")]
        private InputList<Inputs.CustomAnomaliesDimensionStringGetArgs>? _strings;

        /// <summary>
        /// A filter for the metrics string dimensions
        /// </summary>
        public InputList<Inputs.CustomAnomaliesDimensionStringGetArgs> Strings
        {
            get => _strings ?? (_strings = new InputList<Inputs.CustomAnomaliesDimensionStringGetArgs>());
            set => _strings = value;
        }

        public CustomAnomaliesDimensionGetArgs()
        {
        }
        public static new CustomAnomaliesDimensionGetArgs Empty => new CustomAnomaliesDimensionGetArgs();
    }
}
