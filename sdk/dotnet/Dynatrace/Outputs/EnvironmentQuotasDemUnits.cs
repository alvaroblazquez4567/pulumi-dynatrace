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
    public sealed class EnvironmentQuotasDemUnits
    {
        /// <summary>
        /// Annual environment quota. Not set if unlimited
        /// </summary>
        public readonly int? Annual;
        /// <summary>
        /// Monthly environment quota. Not set if unlimited
        /// </summary>
        public readonly int? Monthly;

        [OutputConstructor]
        private EnvironmentQuotasDemUnits(
            int? annual,

            int? monthly)
        {
            Annual = annual;
            Monthly = monthly;
        }
    }
}
