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

    public sealed class BusinessEventsOneagentTriggersArgs : global::Pulumi.ResourceArgs
    {
        [Input("triggers", required: true)]
        private InputList<Inputs.BusinessEventsOneagentTriggersTriggerArgs>? _triggers;
        public InputList<Inputs.BusinessEventsOneagentTriggersTriggerArgs> Triggers
        {
            get => _triggers ?? (_triggers = new InputList<Inputs.BusinessEventsOneagentTriggersTriggerArgs>());
            set => _triggers = value;
        }

        public BusinessEventsOneagentTriggersArgs()
        {
        }
        public static new BusinessEventsOneagentTriggersArgs Empty => new BusinessEventsOneagentTriggersArgs();
    }
}
