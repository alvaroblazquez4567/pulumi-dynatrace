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
    public sealed class BrowserMonitorScriptConfigurationHeadersHeader
    {
        /// <summary>
        /// The name of the cookie. The following cookie names are now allowed: `dtCookie`, `dtLatC`, `dtPC`, `rxVisitor`, `rxlatency`, `rxpc`, `rxsession` and `rxvt`
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The value of the cookie. The following symbols are not allowed: `;`, `,`, `\` and `"`.
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private BrowserMonitorScriptConfigurationHeadersHeader(
            string name,

            string value)
        {
            Name = name;
            Value = value;
        }
    }
}
