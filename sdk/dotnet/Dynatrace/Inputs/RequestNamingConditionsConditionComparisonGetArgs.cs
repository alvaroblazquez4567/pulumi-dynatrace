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

    public sealed class RequestNamingConditionsConditionComparisonGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("boolean")]
        public Input<Inputs.RequestNamingConditionsConditionComparisonBooleanGetArgs>? Boolean { get; set; }

        [Input("esbInputNodeType")]
        public Input<Inputs.RequestNamingConditionsConditionComparisonEsbInputNodeTypeGetArgs>? EsbInputNodeType { get; set; }

        [Input("failedState")]
        public Input<Inputs.RequestNamingConditionsConditionComparisonFailedStateGetArgs>? FailedState { get; set; }

        [Input("failureReason")]
        public Input<Inputs.RequestNamingConditionsConditionComparisonFailureReasonGetArgs>? FailureReason { get; set; }

        [Input("fastString")]
        public Input<Inputs.RequestNamingConditionsConditionComparisonFastStringGetArgs>? FastString { get; set; }

        [Input("flawState")]
        public Input<Inputs.RequestNamingConditionsConditionComparisonFlawStateGetArgs>? FlawState { get; set; }

        [Input("generic")]
        public Input<Inputs.RequestNamingConditionsConditionComparisonGenericGetArgs>? Generic { get; set; }

        [Input("httpMethod")]
        public Input<Inputs.RequestNamingConditionsConditionComparisonHttpMethodGetArgs>? HttpMethod { get; set; }

        [Input("httpStatusClass")]
        public Input<Inputs.RequestNamingConditionsConditionComparisonHttpStatusClassGetArgs>? HttpStatusClass { get; set; }

        [Input("iibInputNodeType")]
        public Input<Inputs.RequestNamingConditionsConditionComparisonIibInputNodeTypeGetArgs>? IibInputNodeType { get; set; }

        [Input("negate")]
        public Input<bool>? Negate { get; set; }

        [Input("number")]
        public Input<Inputs.RequestNamingConditionsConditionComparisonNumberGetArgs>? Number { get; set; }

        [Input("numberRequestAttribute")]
        public Input<Inputs.RequestNamingConditionsConditionComparisonNumberRequestAttributeGetArgs>? NumberRequestAttribute { get; set; }

        [Input("serviceType")]
        public Input<Inputs.RequestNamingConditionsConditionComparisonServiceTypeGetArgs>? ServiceType { get; set; }

        [Input("string")]
        public Input<Inputs.RequestNamingConditionsConditionComparisonStringGetArgs>? String { get; set; }

        [Input("stringRequestAttribute")]
        public Input<Inputs.RequestNamingConditionsConditionComparisonStringRequestAttributeGetArgs>? StringRequestAttribute { get; set; }

        [Input("tag")]
        public Input<Inputs.RequestNamingConditionsConditionComparisonTagGetArgs>? Tag { get; set; }

        [Input("zosCallType")]
        public Input<Inputs.RequestNamingConditionsConditionComparisonZosCallTypeGetArgs>? ZosCallType { get; set; }

        public RequestNamingConditionsConditionComparisonGetArgs()
        {
        }
        public static new RequestNamingConditionsConditionComparisonGetArgs Empty => new RequestNamingConditionsConditionComparisonGetArgs();
    }
}
