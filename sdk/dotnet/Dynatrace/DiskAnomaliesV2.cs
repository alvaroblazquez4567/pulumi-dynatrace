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
    [DynatraceResourceType("dynatrace:index/diskAnomaliesV2:DiskAnomaliesV2")]
    public partial class DiskAnomaliesV2 : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Disk
        /// </summary>
        [Output("disk")]
        public Output<Outputs.DiskAnomaliesV2Disk> Disk { get; private set; } = null!;

        /// <summary>
        /// The scope for the disk anomaly detection
        /// </summary>
        [Output("scope")]
        public Output<string> Scope { get; private set; } = null!;


        /// <summary>
        /// Create a DiskAnomaliesV2 resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DiskAnomaliesV2(string name, DiskAnomaliesV2Args args, CustomResourceOptions? options = null)
            : base("dynatrace:index/diskAnomaliesV2:DiskAnomaliesV2", name, args ?? new DiskAnomaliesV2Args(), MakeResourceOptions(options, ""))
        {
        }

        private DiskAnomaliesV2(string name, Input<string> id, DiskAnomaliesV2State? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/diskAnomaliesV2:DiskAnomaliesV2", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing DiskAnomaliesV2 resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DiskAnomaliesV2 Get(string name, Input<string> id, DiskAnomaliesV2State? state = null, CustomResourceOptions? options = null)
        {
            return new DiskAnomaliesV2(name, id, state, options);
        }
    }

    public sealed class DiskAnomaliesV2Args : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Disk
        /// </summary>
        [Input("disk", required: true)]
        public Input<Inputs.DiskAnomaliesV2DiskArgs> Disk { get; set; } = null!;

        /// <summary>
        /// The scope for the disk anomaly detection
        /// </summary>
        [Input("scope", required: true)]
        public Input<string> Scope { get; set; } = null!;

        public DiskAnomaliesV2Args()
        {
        }
        public static new DiskAnomaliesV2Args Empty => new DiskAnomaliesV2Args();
    }

    public sealed class DiskAnomaliesV2State : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Disk
        /// </summary>
        [Input("disk")]
        public Input<Inputs.DiskAnomaliesV2DiskGetArgs>? Disk { get; set; }

        /// <summary>
        /// The scope for the disk anomaly detection
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        public DiskAnomaliesV2State()
        {
        }
        public static new DiskAnomaliesV2State Empty => new DiskAnomaliesV2State();
    }
}
