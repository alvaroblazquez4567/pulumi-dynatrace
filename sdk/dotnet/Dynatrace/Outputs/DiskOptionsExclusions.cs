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
    public sealed class DiskOptionsExclusions
    {
        public readonly ImmutableArray<Outputs.DiskOptionsExclusionsExclusion> Exclusions;

        [OutputConstructor]
        private DiskOptionsExclusions(ImmutableArray<Outputs.DiskOptionsExclusionsExclusion> exclusions)
        {
            Exclusions = exclusions;
        }
    }
}
