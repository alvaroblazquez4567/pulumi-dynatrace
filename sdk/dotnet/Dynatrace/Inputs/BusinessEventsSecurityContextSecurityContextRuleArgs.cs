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

    public sealed class BusinessEventsSecurityContextSecurityContextRuleArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Matcher
        /// </summary>
        [Input("query", required: true)]
        public Input<string> Query { get; set; } = null!;

        /// <summary>
        /// Rule name
        /// </summary>
        [Input("ruleName", required: true)]
        public Input<string> RuleName { get; set; } = null!;

        /// <summary>
        /// Literal value to be set
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        /// <summary>
        /// Possible Values: `FIELD`, `LITERAL`
        /// </summary>
        [Input("valueSource", required: true)]
        public Input<string> ValueSource { get; set; } = null!;

        /// <summary>
        /// Name of field used to copy value
        /// </summary>
        [Input("valueSourceField")]
        public Input<string>? ValueSourceField { get; set; }

        public BusinessEventsSecurityContextSecurityContextRuleArgs()
        {
        }
        public static new BusinessEventsSecurityContextSecurityContextRuleArgs Empty => new BusinessEventsSecurityContextSecurityContextRuleArgs();
    }
}
