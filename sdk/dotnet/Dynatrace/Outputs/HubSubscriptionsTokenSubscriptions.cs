// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Lbrlabs.PulumiPackage.Dynatrace.Outputs
{

    [OutputType]
    public sealed class HubSubscriptionsTokenSubscriptions
    {
        public readonly ImmutableArray<Outputs.HubSubscriptionsTokenSubscriptionsTokenSubscription> TokenSubscriptions;

        [OutputConstructor]
        private HubSubscriptionsTokenSubscriptions(ImmutableArray<Outputs.HubSubscriptionsTokenSubscriptionsTokenSubscription> tokenSubscriptions)
        {
            TokenSubscriptions = tokenSubscriptions;
        }
    }
}