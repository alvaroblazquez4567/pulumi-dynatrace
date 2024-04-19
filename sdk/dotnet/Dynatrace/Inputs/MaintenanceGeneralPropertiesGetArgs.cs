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

    public sealed class MaintenanceGeneralPropertiesGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// A short description of the maintenance purpose.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Disables the execution of the synthetic monitors that are within [the scope of this maintenance window](https://dt-url.net/0e0341m).
        /// </summary>
        [Input("disableSynthetic", required: true)]
        public Input<bool> DisableSynthetic { get; set; } = null!;

        /// <summary>
        /// The name of the maintenance window, displayed in the UI
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The type of suppression of alerting and problem detection during the maintenance. Possible Values: `DETECT_PROBLEMS_AND_ALERT`, `DETECT_PROBLEMS_DONT_ALERT`, `DONT_DETECT_PROBLEMS`
        /// </summary>
        [Input("suppression", required: true)]
        public Input<string> Suppression { get; set; } = null!;

        /// <summary>
        /// The type of the maintenance, possible values: `PLANNED` or `UNPLANNED`
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public MaintenanceGeneralPropertiesGetArgs()
        {
        }
        public static new MaintenanceGeneralPropertiesGetArgs Empty => new MaintenanceGeneralPropertiesGetArgs();
    }
}
