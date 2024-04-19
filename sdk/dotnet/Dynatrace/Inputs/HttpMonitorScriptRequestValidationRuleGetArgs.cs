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

    public sealed class HttpMonitorScriptRequestValidationRuleGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The validation condition. `true` means validation succeeds if the specified content/element is found. `false` means validation fails if the specified content/element is found. Always specify `false` for `certificateExpiryDateConstraint` to fail the monitor if SSL certificate expiry is within the specified number of days
        /// </summary>
        [Input("passIfFound")]
        public Input<bool>? PassIfFound { get; set; }

        /// <summary>
        /// The type of the threshold: `TOTAL` (total loading time) or `ACTION` (action loading time)
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// The value of the header
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public HttpMonitorScriptRequestValidationRuleGetArgs()
        {
        }
        public static new HttpMonitorScriptRequestValidationRuleGetArgs Empty => new HttpMonitorScriptRequestValidationRuleGetArgs();
    }
}