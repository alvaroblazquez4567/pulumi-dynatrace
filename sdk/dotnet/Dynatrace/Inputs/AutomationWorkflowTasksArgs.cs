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

    public sealed class AutomationWorkflowTasksArgs : global::Pulumi.ResourceArgs
    {
        [Input("tasks")]
        private InputList<Inputs.AutomationWorkflowTasksTaskArgs>? _tasks;

        /// <summary>
        /// TODO: No documentation available
        /// </summary>
        public InputList<Inputs.AutomationWorkflowTasksTaskArgs> Tasks
        {
            get => _tasks ?? (_tasks = new InputList<Inputs.AutomationWorkflowTasksTaskArgs>());
            set => _tasks = value;
        }

        public AutomationWorkflowTasksArgs()
        {
        }
        public static new AutomationWorkflowTasksArgs Empty => new AutomationWorkflowTasksArgs();
    }
}