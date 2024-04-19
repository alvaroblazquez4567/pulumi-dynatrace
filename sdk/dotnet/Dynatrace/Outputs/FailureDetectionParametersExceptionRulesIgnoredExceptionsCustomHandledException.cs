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
    public sealed class FailureDetectionParametersExceptionRulesIgnoredExceptionsCustomHandledException
    {
        /// <summary>
        /// The pattern will match if it is contained within the actual class name.
        /// </summary>
        public readonly string? ClassPattern;
        /// <summary>
        /// Optionally, define an exception message pattern. The pattern will match if the actual exception message contains the pattern.
        /// </summary>
        public readonly string? MessagePattern;

        [OutputConstructor]
        private FailureDetectionParametersExceptionRulesIgnoredExceptionsCustomHandledException(
            string? classPattern,

            string? messagePattern)
        {
            ClassPattern = classPattern;
            MessagePattern = messagePattern;
        }
    }
}
