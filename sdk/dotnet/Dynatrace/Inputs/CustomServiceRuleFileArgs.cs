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

    public sealed class CustomServiceRuleFileArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Matcher applying to the class name (ENDS*WITH, EQUALS or STARTS*WITH). STARTS_WITH can only be used if there is at least one annotation defined. Default value is EQUALS
        /// </summary>
        [Input("match")]
        public Input<string>? Match { get; set; }

        /// <summary>
        /// The full name of the class / the name to match the class name with
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public CustomServiceRuleFileArgs()
        {
        }
        public static new CustomServiceRuleFileArgs Empty => new CustomServiceRuleFileArgs();
    }
}
