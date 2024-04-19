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

    public sealed class ServiceExternalWebServiceConditionsConditionGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Take the value of this attribute
        /// </summary>
        [Input("attribute", required: true)]
        public Input<string> Attribute { get; set; } = null!;

        /// <summary>
        /// Apply this operation
        /// </summary>
        [Input("compareOperationType", required: true)]
        public Input<string> CompareOperationType { get; set; } = null!;

        [Input("frameworks")]
        private InputList<string>? _frameworks;

        /// <summary>
        /// Technology
        /// </summary>
        public InputList<string> Frameworks
        {
            get => _frameworks ?? (_frameworks = new InputList<string>());
            set => _frameworks = value;
        }

        /// <summary>
        /// Ignore case sensitivity for texts.
        /// </summary>
        [Input("ignoreCase")]
        public Input<bool>? IgnoreCase { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        [Input("intValue")]
        public Input<int>? IntValue { get; set; }

        [Input("intValues")]
        private InputList<int>? _intValues;

        /// <summary>
        /// Values
        /// </summary>
        public InputList<int> IntValues
        {
            get => _intValues ?? (_intValues = new InputList<int>());
            set => _intValues = value;
        }

        /// <summary>
        /// From
        /// </summary>
        [Input("ipRangeFrom")]
        public Input<string>? IpRangeFrom { get; set; }

        /// <summary>
        /// To
        /// </summary>
        [Input("ipRangeTo")]
        public Input<string>? IpRangeTo { get; set; }

        [Input("tagValues")]
        private InputList<string>? _tagValues;

        /// <summary>
        /// If multiple values are specified, at least one of them must match for the condition to match
        /// </summary>
        public InputList<string> TagValues
        {
            get => _tagValues ?? (_tagValues = new InputList<string>());
            set => _tagValues = value;
        }

        [Input("textValues")]
        private InputList<string>? _textValues;

        /// <summary>
        /// If multiple values are specified, at least one of them must match for the condition to match
        /// </summary>
        public InputList<string> TextValues
        {
            get => _textValues ?? (_textValues = new InputList<string>());
            set => _textValues = value;
        }

        public ServiceExternalWebServiceConditionsConditionGetArgs()
        {
        }
        public static new ServiceExternalWebServiceConditionsConditionGetArgs Empty => new ServiceExternalWebServiceConditionsConditionGetArgs();
    }
}
