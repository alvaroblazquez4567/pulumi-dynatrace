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

    public sealed class MobileApplicationPropertiesGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("apiValues")]
        private InputList<Inputs.MobileApplicationPropertiesApiValueGetArgs>? _apiValues;

        /// <summary>
        /// A User Action / Session Property based on a value reported by the API
        /// </summary>
        public InputList<Inputs.MobileApplicationPropertiesApiValueGetArgs> ApiValues
        {
            get => _apiValues ?? (_apiValues = new InputList<Inputs.MobileApplicationPropertiesApiValueGetArgs>());
            set => _apiValues = value;
        }

        [Input("requestAttributes")]
        private InputList<Inputs.MobileApplicationPropertiesRequestAttributeGetArgs>? _requestAttributes;

        /// <summary>
        /// A User Action / Session Property based on a Server Side Request Attribute
        /// </summary>
        public InputList<Inputs.MobileApplicationPropertiesRequestAttributeGetArgs> RequestAttributes
        {
            get => _requestAttributes ?? (_requestAttributes = new InputList<Inputs.MobileApplicationPropertiesRequestAttributeGetArgs>());
            set => _requestAttributes = value;
        }

        public MobileApplicationPropertiesGetArgs()
        {
        }
        public static new MobileApplicationPropertiesGetArgs Empty => new MobileApplicationPropertiesGetArgs();
    }
}
