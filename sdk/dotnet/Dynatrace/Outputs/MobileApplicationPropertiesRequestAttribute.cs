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
    public sealed class MobileApplicationPropertiesRequestAttribute
    {
        /// <summary>
        /// The aggregation type of the property. It defines how multiple values of the property are aggregated. Possible values are `SUM`, `MIN`, `MAX`, `FIRST` and `LAST`
        /// </summary>
        public readonly string? Aggregation;
        /// <summary>
        /// The cleanup rule of the property. Defines how to extract the data you need from a string value. Specify the [regular expression](https://dt-url.net/k9e0iaq) for the data you need there
        /// </summary>
        public readonly string? CleanupRule;
        /// <summary>
        /// The display name of the property
        /// </summary>
        public readonly string? DisplayName;
        /// <summary>
        /// The ID of the request attribute
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The unique key of the mobile session or user action property
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// If `true`, the property is stored as a session property
        /// </summary>
        public readonly bool? StoreAsSessionProperty;
        /// <summary>
        /// If `true`, the property is stored as a user action property
        /// </summary>
        public readonly bool? StoreAsUserActionProperty;
        /// <summary>
        /// The data type of the property. Possible values are `DOUBLE`, `LONG` and `STRING`
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private MobileApplicationPropertiesRequestAttribute(
            string? aggregation,

            string? cleanupRule,

            string? displayName,

            string id,

            string key,

            bool? storeAsSessionProperty,

            bool? storeAsUserActionProperty,

            string type)
        {
            Aggregation = aggregation;
            CleanupRule = cleanupRule;
            DisplayName = displayName;
            Id = id;
            Key = key;
            StoreAsSessionProperty = storeAsSessionProperty;
            StoreAsUserActionProperty = storeAsUserActionProperty;
            Type = type;
        }
    }
}