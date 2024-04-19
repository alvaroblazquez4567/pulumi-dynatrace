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
    public sealed class CalculatedWebMetricUserActionFilter
    {
        /// <summary>
        /// Only actions with a duration more than or equal to this value (in milliseconds) are included in the metric calculation.
        /// </summary>
        public readonly int? ActionDurationFromMilliseconds;
        /// <summary>
        /// Only actions with a duration less than or equal to this value (in milliseconds) are included in the metric calculation.
        /// </summary>
        public readonly int? ActionDurationToMilliseconds;
        /// <summary>
        /// Only actions with the specified Apdex score are included in the metric calculation. Possible values: [ Frustrated, Satisfied, Tolerating, Unknown ]
        /// </summary>
        public readonly string? Apdex;
        /// <summary>
        /// Only user actions coming from the specified browser family are included in the metric calculation.
        /// </summary>
        public readonly string? BrowserFamily;
        /// <summary>
        /// Only user actions coming from the specified browser type are included in the metric calculation.
        /// </summary>
        public readonly string? BrowserType;
        /// <summary>
        /// Only user actions coming from the specified browser version are included in the metric calculation.
        /// </summary>
        public readonly string? BrowserVersion;
        /// <summary>
        /// Only actions of users from this city are included in the metric calculation. Specify geolocation ID here.
        /// </summary>
        public readonly string? City;
        /// <summary>
        /// Only actions of users from this continent are included in the metric calculation. Specify geolocation ID here.
        /// </summary>
        public readonly string? Continent;
        /// <summary>
        /// Only actions of users from this country are included in the metric calculation. Specify geolocation ID here.
        /// </summary>
        public readonly string? Country;
        /// <summary>
        /// The status of custom actions in the metric calculation: `true` or `false`
        /// </summary>
        public readonly bool? CustomAction;
        /// <summary>
        /// The custom error name of the actions to be included in the metric calculation.
        /// </summary>
        public readonly string? CustomErrorName;
        /// <summary>
        /// The custom error type of the actions to be included in the metric calculation.
        /// </summary>
        public readonly string? CustomErrorType;
        /// <summary>
        /// Only user actions coming from the specified domain are included in the metric calculation.
        /// </summary>
        public readonly string? Domain;
        /// <summary>
        /// The error status of the actions to be included in the metric calculation: `true` or `false`
        /// </summary>
        public readonly bool? HasAnyError;
        /// <summary>
        /// The custom error status of the actions to be included in the metric calculation: `true` or `false`
        /// </summary>
        public readonly bool? HasCustomErrors;
        /// <summary>
        /// The request error status of the actions to be included in the metric calculation: `true` or `false`
        /// </summary>
        public readonly bool? HasHttpErrors;
        /// <summary>
        /// The JavaScript error status of the actions to be included in the metric calculation: `true` or `false`
        /// </summary>
        public readonly bool? HasJavascriptErrors;
        /// <summary>
        /// The HTTP error status code of the actions to be included in the metric calculation.
        /// </summary>
        public readonly int? HttpErrorCode;
        /// <summary>
        /// Can be used in combination with httpErrorCode to define a range of error codes that will be included in the metric calculation.
        /// </summary>
        public readonly int? HttpErrorCodeTo;
        /// <summary>
        /// The request path that has been determined to be the origin of an HTTP error of the actions to be included in the metric calculation.
        /// </summary>
        public readonly string? HttpPath;
        /// <summary>
        /// Only actions coming from this IP address are included in the metric calculation.
        /// </summary>
        public readonly string? Ip;
        /// <summary>
        /// The IPv6 status of the actions to be included in the metric calculation: `true` or `false`
        /// </summary>
        public readonly bool? IpV6Traffic;
        /// <summary>
        /// The status of load actions in the metric calculation: `true` or `false`
        /// </summary>
        public readonly bool? LoadAction;
        /// <summary>
        /// Only actions coming from this OS family are included in the metric calculation.
        /// </summary>
        public readonly string? OsFamily;
        /// <summary>
        /// Only actions coming from this OS version are included in the metric calculation.
        /// </summary>
        public readonly string? OsVersion;
        /// <summary>
        /// The status of actions coming from real users in the metric calculation: `true` or `false`
        /// </summary>
        public readonly bool? RealUser;
        /// <summary>
        /// Only actions of users from this region are included in the metric calculation. Specify geolocation ID here.
        /// </summary>
        public readonly string? Region;
        /// <summary>
        /// The status of actions coming from robots in the metric calculation: `true` or `false`
        /// </summary>
        public readonly bool? Robot;
        /// <summary>
        /// The status of actions coming from synthetic monitors in the metric calculation: `true` or `false`
        /// </summary>
        public readonly bool? Synthetic;
        /// <summary>
        /// Only actions on the specified group of views are included in the metric calculation.
        /// </summary>
        public readonly string? TargetViewGroup;
        /// <summary>
        /// Specifies the match type of the view group filter, e.g. using Contains or Equals. Defaults to Equals.
        /// </summary>
        public readonly string? TargetViewGroupNameMatchType;
        /// <summary>
        /// Only actions on the specified view are included in the metric calculation.
        /// </summary>
        public readonly string? TargetViewName;
        /// <summary>
        /// Specifies the match type of the view name filter, e.g. using Contains or Equals. Defaults to Equals.
        /// </summary>
        public readonly string? TargetViewNameMatchType;
        /// <summary>
        /// Only actions with this name are included in the metric calculation.
        /// </summary>
        public readonly string? UserActionName;
        /// <summary>
        /// The definition of a calculated web metric.
        /// </summary>
        public readonly ImmutableArray<Outputs.CalculatedWebMetricUserActionFilterUserActionProperty> UserActionProperties;
        /// <summary>
        /// The status of xhr actions in the metric calculation: `true` or `false`
        /// </summary>
        public readonly bool? XhrAction;
        /// <summary>
        /// The status of route actions in the metric calculation: `true` or `false`
        /// </summary>
        public readonly bool? XhrRouteChangeAction;

        [OutputConstructor]
        private CalculatedWebMetricUserActionFilter(
            int? actionDurationFromMilliseconds,

            int? actionDurationToMilliseconds,

            string? apdex,

            string? browserFamily,

            string? browserType,

            string? browserVersion,

            string? city,

            string? continent,

            string? country,

            bool? customAction,

            string? customErrorName,

            string? customErrorType,

            string? domain,

            bool? hasAnyError,

            bool? hasCustomErrors,

            bool? hasHttpErrors,

            bool? hasJavascriptErrors,

            int? httpErrorCode,

            int? httpErrorCodeTo,

            string? httpPath,

            string? ip,

            bool? ipV6Traffic,

            bool? loadAction,

            string? osFamily,

            string? osVersion,

            bool? realUser,

            string? region,

            bool? robot,

            bool? synthetic,

            string? targetViewGroup,

            string? targetViewGroupNameMatchType,

            string? targetViewName,

            string? targetViewNameMatchType,

            string? userActionName,

            ImmutableArray<Outputs.CalculatedWebMetricUserActionFilterUserActionProperty> userActionProperties,

            bool? xhrAction,

            bool? xhrRouteChangeAction)
        {
            ActionDurationFromMilliseconds = actionDurationFromMilliseconds;
            ActionDurationToMilliseconds = actionDurationToMilliseconds;
            Apdex = apdex;
            BrowserFamily = browserFamily;
            BrowserType = browserType;
            BrowserVersion = browserVersion;
            City = city;
            Continent = continent;
            Country = country;
            CustomAction = customAction;
            CustomErrorName = customErrorName;
            CustomErrorType = customErrorType;
            Domain = domain;
            HasAnyError = hasAnyError;
            HasCustomErrors = hasCustomErrors;
            HasHttpErrors = hasHttpErrors;
            HasJavascriptErrors = hasJavascriptErrors;
            HttpErrorCode = httpErrorCode;
            HttpErrorCodeTo = httpErrorCodeTo;
            HttpPath = httpPath;
            Ip = ip;
            IpV6Traffic = ipV6Traffic;
            LoadAction = loadAction;
            OsFamily = osFamily;
            OsVersion = osVersion;
            RealUser = realUser;
            Region = region;
            Robot = robot;
            Synthetic = synthetic;
            TargetViewGroup = targetViewGroup;
            TargetViewGroupNameMatchType = targetViewGroupNameMatchType;
            TargetViewName = targetViewName;
            TargetViewNameMatchType = targetViewNameMatchType;
            UserActionName = userActionName;
            UserActionProperties = userActionProperties;
            XhrAction = xhrAction;
            XhrRouteChangeAction = xhrRouteChangeAction;
        }
    }
}
