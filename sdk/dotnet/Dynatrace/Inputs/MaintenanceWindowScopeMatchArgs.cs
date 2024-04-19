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

    public sealed class MaintenanceWindowScopeMatchArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of a management zone to which the matched entities must belong
        /// </summary>
        [Input("mzId")]
        public Input<string>? MzId { get; set; }

        /// <summary>
        /// The logic that applies when several tags are specified: AND/OR.  If not set, the OR logic is used
        /// </summary>
        [Input("tagCombination")]
        public Input<string>? TagCombination { get; set; }

        [Input("tags")]
        private InputList<Inputs.MaintenanceWindowScopeMatchTagArgs>? _tags;

        /// <summary>
        /// The tag you want to use for matching.  You can use custom tags from the UI, AWS tags, Cloud Foundry tags, OpenShift/Kubernetes, and tags based on environment variables
        /// </summary>
        public InputList<Inputs.MaintenanceWindowScopeMatchTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.MaintenanceWindowScopeMatchTagArgs>());
            set => _tags = value;
        }

        /// <summary>
        /// The type of the Dynatrace entities (for example, hosts or services) you want to pick up by matching
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        public MaintenanceWindowScopeMatchArgs()
        {
        }
        public static new MaintenanceWindowScopeMatchArgs Empty => new MaintenanceWindowScopeMatchArgs();
    }
}
