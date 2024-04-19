// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Lbrlabs.PulumiPackage.Dynatrace
{
    [DynatraceResourceType("dynatrace:index/vmwareAnomalies:VmwareAnomalies")]
    public partial class VmwareAnomalies : global::Pulumi.CustomResource
    {
        /// <summary>
        /// no documentation available
        /// </summary>
        [Output("droppedPacketsDetection")]
        public Output<Outputs.VmwareAnomaliesDroppedPacketsDetection> DroppedPacketsDetection { get; private set; } = null!;

        /// <summary>
        /// no documentation available
        /// </summary>
        [Output("esxiHighCpuDetection")]
        public Output<Outputs.VmwareAnomaliesEsxiHighCpuDetection> EsxiHighCpuDetection { get; private set; } = null!;

        /// <summary>
        /// no documentation available
        /// </summary>
        [Output("esxiHighMemoryDetection")]
        public Output<Outputs.VmwareAnomaliesEsxiHighMemoryDetection> EsxiHighMemoryDetection { get; private set; } = null!;

        /// <summary>
        /// no documentation available
        /// </summary>
        [Output("guestCpuLimitDetection")]
        public Output<Outputs.VmwareAnomaliesGuestCpuLimitDetection> GuestCpuLimitDetection { get; private set; } = null!;

        /// <summary>
        /// no documentation available
        /// </summary>
        [Output("lowDatastoreSpaceDetection")]
        public Output<Outputs.VmwareAnomaliesLowDatastoreSpaceDetection> LowDatastoreSpaceDetection { get; private set; } = null!;

        /// <summary>
        /// no documentation available
        /// </summary>
        [Output("overloadedStorageDetection")]
        public Output<Outputs.VmwareAnomaliesOverloadedStorageDetection> OverloadedStorageDetection { get; private set; } = null!;

        /// <summary>
        /// no documentation available
        /// </summary>
        [Output("slowPhysicalStorageDetection")]
        public Output<Outputs.VmwareAnomaliesSlowPhysicalStorageDetection> SlowPhysicalStorageDetection { get; private set; } = null!;

        /// <summary>
        /// no documentation available
        /// </summary>
        [Output("undersizedStorageDetection")]
        public Output<Outputs.VmwareAnomaliesUndersizedStorageDetection> UndersizedStorageDetection { get; private set; } = null!;


        /// <summary>
        /// Create a VmwareAnomalies resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public VmwareAnomalies(string name, VmwareAnomaliesArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/vmwareAnomalies:VmwareAnomalies", name, args ?? new VmwareAnomaliesArgs(), MakeResourceOptions(options, ""))
        {
        }

        private VmwareAnomalies(string name, Input<string> id, VmwareAnomaliesState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/vmwareAnomalies:VmwareAnomalies", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/alvaroblazquez4567",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing VmwareAnomalies resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static VmwareAnomalies Get(string name, Input<string> id, VmwareAnomaliesState? state = null, CustomResourceOptions? options = null)
        {
            return new VmwareAnomalies(name, id, state, options);
        }
    }

    public sealed class VmwareAnomaliesArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("droppedPacketsDetection", required: true)]
        public Input<Inputs.VmwareAnomaliesDroppedPacketsDetectionArgs> DroppedPacketsDetection { get; set; } = null!;

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("esxiHighCpuDetection", required: true)]
        public Input<Inputs.VmwareAnomaliesEsxiHighCpuDetectionArgs> EsxiHighCpuDetection { get; set; } = null!;

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("esxiHighMemoryDetection", required: true)]
        public Input<Inputs.VmwareAnomaliesEsxiHighMemoryDetectionArgs> EsxiHighMemoryDetection { get; set; } = null!;

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("guestCpuLimitDetection", required: true)]
        public Input<Inputs.VmwareAnomaliesGuestCpuLimitDetectionArgs> GuestCpuLimitDetection { get; set; } = null!;

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("lowDatastoreSpaceDetection", required: true)]
        public Input<Inputs.VmwareAnomaliesLowDatastoreSpaceDetectionArgs> LowDatastoreSpaceDetection { get; set; } = null!;

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("overloadedStorageDetection", required: true)]
        public Input<Inputs.VmwareAnomaliesOverloadedStorageDetectionArgs> OverloadedStorageDetection { get; set; } = null!;

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("slowPhysicalStorageDetection", required: true)]
        public Input<Inputs.VmwareAnomaliesSlowPhysicalStorageDetectionArgs> SlowPhysicalStorageDetection { get; set; } = null!;

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("undersizedStorageDetection", required: true)]
        public Input<Inputs.VmwareAnomaliesUndersizedStorageDetectionArgs> UndersizedStorageDetection { get; set; } = null!;

        public VmwareAnomaliesArgs()
        {
        }
        public static new VmwareAnomaliesArgs Empty => new VmwareAnomaliesArgs();
    }

    public sealed class VmwareAnomaliesState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("droppedPacketsDetection")]
        public Input<Inputs.VmwareAnomaliesDroppedPacketsDetectionGetArgs>? DroppedPacketsDetection { get; set; }

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("esxiHighCpuDetection")]
        public Input<Inputs.VmwareAnomaliesEsxiHighCpuDetectionGetArgs>? EsxiHighCpuDetection { get; set; }

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("esxiHighMemoryDetection")]
        public Input<Inputs.VmwareAnomaliesEsxiHighMemoryDetectionGetArgs>? EsxiHighMemoryDetection { get; set; }

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("guestCpuLimitDetection")]
        public Input<Inputs.VmwareAnomaliesGuestCpuLimitDetectionGetArgs>? GuestCpuLimitDetection { get; set; }

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("lowDatastoreSpaceDetection")]
        public Input<Inputs.VmwareAnomaliesLowDatastoreSpaceDetectionGetArgs>? LowDatastoreSpaceDetection { get; set; }

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("overloadedStorageDetection")]
        public Input<Inputs.VmwareAnomaliesOverloadedStorageDetectionGetArgs>? OverloadedStorageDetection { get; set; }

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("slowPhysicalStorageDetection")]
        public Input<Inputs.VmwareAnomaliesSlowPhysicalStorageDetectionGetArgs>? SlowPhysicalStorageDetection { get; set; }

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("undersizedStorageDetection")]
        public Input<Inputs.VmwareAnomaliesUndersizedStorageDetectionGetArgs>? UndersizedStorageDetection { get; set; }

        public VmwareAnomaliesState()
        {
        }
        public static new VmwareAnomaliesState Empty => new VmwareAnomaliesState();
    }
}
