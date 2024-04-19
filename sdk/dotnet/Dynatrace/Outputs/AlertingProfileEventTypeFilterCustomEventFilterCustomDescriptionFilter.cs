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
    public sealed class AlertingProfileEventTypeFilterCustomEventFilterCustomDescriptionFilter
    {
        /// <summary>
        /// The condition is case sensitive (`false`) or case insensitive (`true`).   If not set, then `false` is used, making the condition case sensitive
        /// </summary>
        public readonly bool? CaseInsensitive;
        /// <summary>
        /// The filter is enabled (`true`) or disabled (`false`)
        /// </summary>
        public readonly bool? Enabled;
        /// <summary>
        /// Reverses the comparison **operator**. For example it turns the **begins with** into **does not begin with**
        /// </summary>
        public readonly bool? Negate;
        /// <summary>
        /// Operator of the comparison.   You can reverse it by setting **negate** to `true`. Possible values are `BEGINS_WITH`, `CONTAINS`, `CONTAINS_REGEX`, `ENDS_WITH` and `EQUALS`
        /// </summary>
        public readonly string Operator;
        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        public readonly string? Unknowns;
        /// <summary>
        /// The value to compare to
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private AlertingProfileEventTypeFilterCustomEventFilterCustomDescriptionFilter(
            bool? caseInsensitive,

            bool? enabled,

            bool? negate,

            string @operator,

            string? unknowns,

            string value)
        {
            CaseInsensitive = caseInsensitive;
            Enabled = enabled;
            Negate = negate;
            Operator = @operator;
            Unknowns = unknowns;
            Value = value;
        }
    }
}
