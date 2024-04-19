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

    public sealed class AutomationWorkflowTasksTaskRetryArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies a maximum number of times that a task can be repeated in case it fails on execution. You can specify either a number between 1 and 99 here or use an expression (`{{}}`). Default: 1
        /// </summary>
        [Input("count")]
        public Input<string>? Count { get; set; }

        /// <summary>
        /// Specifies a delay in seconds between subsequent task retries. You can specify either a number between 1 and 3600 here or an expression (`{{...}}`). Default: 1
        /// </summary>
        [Input("delay")]
        public Input<string>? Delay { get; set; }

        /// <summary>
        /// Specifies whether retrying the failed iterations or the whole loop. Default: true
        /// </summary>
        [Input("failedLoopIterationsOnly")]
        public Input<bool>? FailedLoopIterationsOnly { get; set; }

        public AutomationWorkflowTasksTaskRetryArgs()
        {
        }
        public static new AutomationWorkflowTasksTaskRetryArgs Empty => new AutomationWorkflowTasksTaskRetryArgs();
    }
}
