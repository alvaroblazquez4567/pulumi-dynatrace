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

    public sealed class WebAppCustomErrorsErrorRulesArgs : global::Pulumi.ResourceArgs
    {
        [Input("errorRules", required: true)]
        private InputList<Inputs.WebAppCustomErrorsErrorRulesErrorRuleArgs>? _errorRules;
        public InputList<Inputs.WebAppCustomErrorsErrorRulesErrorRuleArgs> ErrorRules
        {
            get => _errorRules ?? (_errorRules = new InputList<Inputs.WebAppCustomErrorsErrorRulesErrorRuleArgs>());
            set => _errorRules = value;
        }

        public WebAppCustomErrorsErrorRulesArgs()
        {
        }
        public static new WebAppCustomErrorsErrorRulesArgs Empty => new WebAppCustomErrorsErrorRulesArgs();
    }
}
