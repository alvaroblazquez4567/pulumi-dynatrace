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

    public sealed class AttackRulesCriteriaGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Possible Values: `ANY`, `CMD_INJECTION`, `JNDI_INJECTION`, `SQL_INJECTION`, `SSRF`
        /// </summary>
        [Input("attackType", required: true)]
        public Input<string> AttackType { get; set; } = null!;

        /// <summary>
        /// Process group
        /// </summary>
        [Input("processGroup")]
        public Input<string>? ProcessGroup { get; set; }

        public AttackRulesCriteriaGetArgs()
        {
        }
        public static new AttackRulesCriteriaGetArgs Empty => new AttackRulesCriteriaGetArgs();
    }
}
