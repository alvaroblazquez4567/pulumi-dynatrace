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
    public sealed class CustomAnomaliesDimensionStringFilter
    {
        /// <summary>
        /// The operator to match on
        /// </summary>
        public readonly string Operator;
        /// <summary>
        /// The value to match on
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private CustomAnomaliesDimensionStringFilter(
            string @operator,

            string value)
        {
            Operator = @operator;
            Value = value;
        }
    }
}
