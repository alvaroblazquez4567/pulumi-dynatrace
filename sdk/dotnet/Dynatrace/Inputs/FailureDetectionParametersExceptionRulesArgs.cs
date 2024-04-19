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

    public sealed class FailureDetectionParametersExceptionRulesArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Some custom error situations are only detectable via a return value or other means. To support such cases, [define a request attribute](https://dt-url.net/ys5k0p4y) that captures the required data. Then define a custom error rule that determines if the request has failed based on the value of the request attribute.
        /// </summary>
        [Input("customErrorRules")]
        public Input<Inputs.FailureDetectionParametersExceptionRulesCustomErrorRulesArgs>? CustomErrorRules { get; set; }

        /// <summary>
        /// There may be situations where your application code handles exceptions gracefully in a manner that these failures aren't detected by Dynatrace. Use this setting to define specific gracefully-handled exceptions that should be treated as service failures.
        /// </summary>
        [Input("customHandledExceptions")]
        public Input<Inputs.FailureDetectionParametersExceptionRulesCustomHandledExceptionsArgs>? CustomHandledExceptions { get; set; }

        /// <summary>
        /// Ignore all exceptions
        /// </summary>
        [Input("ignoreAllExceptions", required: true)]
        public Input<bool> IgnoreAllExceptions { get; set; } = null!;

        /// <summary>
        /// Ignore span failure detection
        /// </summary>
        [Input("ignoreSpanFailureDetection", required: true)]
        public Input<bool> IgnoreSpanFailureDetection { get; set; } = null!;

        /// <summary>
        /// Some exceptions that are thrown by legacy or 3rd-party code indicate a specific response, not an error. Use this setting to instruct Dynatrace to treat such exceptions as non-failed requests.. If an exception matching any of the defined patterns occurs in a request, it will not be considered as a failure. Other exceptions occurring at the same request might still mark the request as failed.
        /// </summary>
        [Input("ignoredExceptions")]
        public Input<Inputs.FailureDetectionParametersExceptionRulesIgnoredExceptionsArgs>? IgnoredExceptions { get; set; }

        /// <summary>
        /// Define exceptions which indicate that a service call should not be considered as failed. E.g. an exception indicating that the client aborted the operation.. If an exception matching any of the defined patterns occurs on the entry node of the service, it will be considered successful. Compared to ignored exceptions, the request will be considered successful even if other exceptions occur in the same request.
        /// </summary>
        [Input("successForcingExceptions")]
        public Input<Inputs.FailureDetectionParametersExceptionRulesSuccessForcingExceptionsArgs>? SuccessForcingExceptions { get; set; }

        public FailureDetectionParametersExceptionRulesArgs()
        {
        }
        public static new FailureDetectionParametersExceptionRulesArgs Empty => new FailureDetectionParametersExceptionRulesArgs();
    }
}
