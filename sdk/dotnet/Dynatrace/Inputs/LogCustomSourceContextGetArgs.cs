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

    public sealed class LogCustomSourceContextGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("contexts", required: true)]
        private InputList<Inputs.LogCustomSourceContextContextGetArgs>? _contexts;
        public InputList<Inputs.LogCustomSourceContextContextGetArgs> Contexts
        {
            get => _contexts ?? (_contexts = new InputList<Inputs.LogCustomSourceContextContextGetArgs>());
            set => _contexts = value;
        }

        public LogCustomSourceContextGetArgs()
        {
        }
        public static new LogCustomSourceContextGetArgs Empty => new LogCustomSourceContextGetArgs();
    }
}
