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

    public sealed class SpanCaptureRuleMatchesGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("matches", required: true)]
        private InputList<Inputs.SpanCaptureRuleMatchesMatchGetArgs>? _matches;

        /// <summary>
        /// Matching strategies for the Span
        /// </summary>
        public InputList<Inputs.SpanCaptureRuleMatchesMatchGetArgs> Matches
        {
            get => _matches ?? (_matches = new InputList<Inputs.SpanCaptureRuleMatchesMatchGetArgs>());
            set => _matches = value;
        }

        public SpanCaptureRuleMatchesGetArgs()
        {
        }
        public static new SpanCaptureRuleMatchesGetArgs Empty => new SpanCaptureRuleMatchesGetArgs();
    }
}
