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
    public sealed class CustomServiceRuleMethod
    {
        /// <summary>
        /// Fully qualified types of argument the method expects
        /// </summary>
        public readonly ImmutableArray<string> Arguments;
        /// <summary>
        /// The ID of the method rule
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The modifiers of the method rule. Possible values are `ABSTRACT`, `EXTERN`, `FINAL`, `NATIVE` and `STATIC`
        /// </summary>
        public readonly ImmutableArray<string> Modifiers;
        /// <summary>
        /// The full name of the class / the name to match the class name with
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Fully qualified type the method returns
        /// </summary>
        public readonly string? Returns;
        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        public readonly string? Unknowns;
        /// <summary>
        /// The visibility of the method rule. Possible values are `INTERNAL`, `PACKAGE_PROTECTED`, `PRIVATE`, `PROTECTED` and `PUBLIC`
        /// </summary>
        public readonly string? Visibility;

        [OutputConstructor]
        private CustomServiceRuleMethod(
            ImmutableArray<string> arguments,

            string? id,

            ImmutableArray<string> modifiers,

            string name,

            string? returns,

            string? unknowns,

            string? visibility)
        {
            Arguments = arguments;
            Id = id;
            Modifiers = modifiers;
            Name = name;
            Returns = returns;
            Unknowns = unknowns;
            Visibility = visibility;
        }
    }
}
