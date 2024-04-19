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

    public sealed class NotificationXmattersHeaderGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the notification configuration
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The value of the HTTP header. May contain an empty value.   Required when creating a new notification.  For the **Authorization** header, GET requests return the `null` value.  If you want update a notification configuration with an **Authorization** header which you want to remain intact, set the **Authorization** header with the `null` value
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public NotificationXmattersHeaderGetArgs()
        {
        }
        public static new NotificationXmattersHeaderGetArgs Empty => new NotificationXmattersHeaderGetArgs();
    }
}
