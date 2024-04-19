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

    public sealed class WebApplicationMonitoringSettingsJavascriptInjectionRulesRuleArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// `fetch()` request capture enabled/disabled
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The HTML pattern of the java script injection
        /// </summary>
        [Input("htmlPattern")]
        public Input<string>? HtmlPattern { get; set; }

        /// <summary>
        /// Java script injection rule
        /// </summary>
        [Input("rule", required: true)]
        public Input<string> Rule { get; set; } = null!;

        /// <summary>
        /// The target against which the rule of the java script injection should be matched. Possible values are `PAGE_QUERY` and `URL`.
        /// </summary>
        [Input("target")]
        public Input<string>? Target { get; set; }

        /// <summary>
        /// The url operator of the java script injection. Possible values are `ALL_PAGES`, `CONTAINS`, `ENDS_WITH`, `EQUALS` and `STARTS_WITH`.
        /// </summary>
        [Input("urlOperator", required: true)]
        public Input<string> UrlOperator { get; set; } = null!;

        /// <summary>
        /// The url pattern of the java script injection
        /// </summary>
        [Input("urlPattern")]
        public Input<string>? UrlPattern { get; set; }

        public WebApplicationMonitoringSettingsJavascriptInjectionRulesRuleArgs()
        {
        }
        public static new WebApplicationMonitoringSettingsJavascriptInjectionRulesRuleArgs Empty => new WebApplicationMonitoringSettingsJavascriptInjectionRulesRuleArgs();
    }
}
