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

    public sealed class ServiceFailureExceptionRulesIgnoredExceptionsCustomHandledExceptionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The pattern will match if it is contained within the actual class name.
        /// </summary>
        [Input("classPattern")]
        public Input<string>? ClassPattern { get; set; }

        /// <summary>
        /// Optionally, define an exception message pattern. The pattern will match if the actual exception message contains the pattern.
        /// </summary>
        [Input("messagePattern")]
        public Input<string>? MessagePattern { get; set; }

        public ServiceFailureExceptionRulesIgnoredExceptionsCustomHandledExceptionArgs()
        {
        }
        public static new ServiceFailureExceptionRulesIgnoredExceptionsCustomHandledExceptionArgs Empty => new ServiceFailureExceptionRulesIgnoredExceptionsCustomHandledExceptionArgs();
    }
}
