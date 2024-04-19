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

    public sealed class MaintenanceWindowScopeArgs : global::Pulumi.ResourceArgs
    {
        [Input("entities")]
        private InputList<string>? _entities;

        /// <summary>
        /// A list of Dynatrace entities (for example, hosts or services) to be included in the scope.  Allowed values are Dynatrace entity IDs
        /// </summary>
        public InputList<string> Entities
        {
            get => _entities ?? (_entities = new InputList<string>());
            set => _entities = value;
        }

        [Input("matches")]
        private InputList<Inputs.MaintenanceWindowScopeMatchArgs>? _matches;

        /// <summary>
        /// A list of matching rules for dynamic scope formation.  If several rules are set, the OR logic applies
        /// </summary>
        public InputList<Inputs.MaintenanceWindowScopeMatchArgs> Matches
        {
            get => _matches ?? (_matches = new InputList<Inputs.MaintenanceWindowScopeMatchArgs>());
            set => _matches = value;
        }

        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        public MaintenanceWindowScopeArgs()
        {
        }
        public static new MaintenanceWindowScopeArgs Empty => new MaintenanceWindowScopeArgs();
    }
}
