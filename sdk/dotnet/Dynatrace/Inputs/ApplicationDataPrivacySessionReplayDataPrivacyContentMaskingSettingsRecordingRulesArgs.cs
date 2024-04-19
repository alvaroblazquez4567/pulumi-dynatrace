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

    public sealed class ApplicationDataPrivacySessionReplayDataPrivacyContentMaskingSettingsRecordingRulesArgs : global::Pulumi.ResourceArgs
    {
        [Input("rules", required: true)]
        private InputList<Inputs.ApplicationDataPrivacySessionReplayDataPrivacyContentMaskingSettingsRecordingRulesRuleArgs>? _rules;

        /// <summary>
        /// The masking rule defining how data is hidden
        /// </summary>
        public InputList<Inputs.ApplicationDataPrivacySessionReplayDataPrivacyContentMaskingSettingsRecordingRulesRuleArgs> Rules
        {
            get => _rules ?? (_rules = new InputList<Inputs.ApplicationDataPrivacySessionReplayDataPrivacyContentMaskingSettingsRecordingRulesRuleArgs>());
            set => _rules = value;
        }

        public ApplicationDataPrivacySessionReplayDataPrivacyContentMaskingSettingsRecordingRulesArgs()
        {
        }
        public static new ApplicationDataPrivacySessionReplayDataPrivacyContentMaskingSettingsRecordingRulesArgs Empty => new ApplicationDataPrivacySessionReplayDataPrivacyContentMaskingSettingsRecordingRulesArgs();
    }
}
