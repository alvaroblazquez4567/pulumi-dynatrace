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
    public sealed class NetworkTrafficExcludeNicNicForm
    {
        /// <summary>
        /// Network interface
        /// </summary>
        public readonly string Interface;
        /// <summary>
        /// Possible Values: `OS_TYPE_AIX`, `OS_TYPE_DARWIN`, `OS_TYPE_HPUX`, `OS_TYPE_LINUX`, `OS_TYPE_SOLARIS`, `OS_TYPE_UNKNOWN`, `OS_TYPE_WINDOWS`, `OS_TYPE_ZOS`
        /// </summary>
        public readonly string Os;

        [OutputConstructor]
        private NetworkTrafficExcludeNicNicForm(
            string @interface,

            string os)
        {
            Interface = @interface;
            Os = os;
        }
    }
}
