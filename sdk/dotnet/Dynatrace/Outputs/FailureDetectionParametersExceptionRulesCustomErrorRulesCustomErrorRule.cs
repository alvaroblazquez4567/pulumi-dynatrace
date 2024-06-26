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
    public sealed class FailureDetectionParametersExceptionRulesCustomErrorRulesCustomErrorRule
    {
        /// <summary>
        /// Request attribute condition
        /// </summary>
        public readonly Outputs.FailureDetectionParametersExceptionRulesCustomErrorRulesCustomErrorRuleCondition Condition;
        /// <summary>
        /// Request attribute
        /// </summary>
        public readonly string RequestAttribute;

        [OutputConstructor]
        private FailureDetectionParametersExceptionRulesCustomErrorRulesCustomErrorRule(
            Outputs.FailureDetectionParametersExceptionRulesCustomErrorRulesCustomErrorRuleCondition condition,

            string requestAttribute)
        {
            Condition = condition;
            RequestAttribute = requestAttribute;
        }
    }
}
