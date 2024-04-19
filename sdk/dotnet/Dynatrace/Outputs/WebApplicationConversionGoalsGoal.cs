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
    public sealed class WebApplicationConversionGoalsGoal
    {
        /// <summary>
        /// Configuration of a destination-based conversion goal
        /// </summary>
        public readonly Outputs.WebApplicationConversionGoalsGoalDestination? Destination;
        /// <summary>
        /// The ID of conversion goal.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The name of the conversion goal. Valid length within 1 and 50 characters.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The type of the action. Possible values are `Custom`, `Load` and `Xhr`.
        /// </summary>
        public readonly string? Type;
        public readonly Outputs.WebApplicationConversionGoalsGoalUserAction? UserAction;
        public readonly Outputs.WebApplicationConversionGoalsGoalVisitDuration? VisitDuration;
        public readonly Outputs.WebApplicationConversionGoalsGoalVisitNumAction? VisitNumAction;

        [OutputConstructor]
        private WebApplicationConversionGoalsGoal(
            Outputs.WebApplicationConversionGoalsGoalDestination? destination,

            string? id,

            string name,

            string? type,

            Outputs.WebApplicationConversionGoalsGoalUserAction? userAction,

            Outputs.WebApplicationConversionGoalsGoalVisitDuration? visitDuration,

            Outputs.WebApplicationConversionGoalsGoalVisitNumAction? visitNumAction)
        {
            Destination = destination;
            Id = id;
            Name = name;
            Type = type;
            UserAction = userAction;
            VisitDuration = visitDuration;
            VisitNumAction = visitNumAction;
        }
    }
}
