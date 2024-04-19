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
    [DynatraceResourceType("dynatrace:index/ibmMqFilters:IbmMqFilters")]
    public partial class IbmMqFilters : global::Pulumi.CustomResource
    {
        /// <summary>
        /// CICS: Excluded MQ queues
        /// </summary>
        [Output("cicsMqQueueIdExcludes")]
        public Output<ImmutableArray<string>> CicsMqQueueIdExcludes { get; private set; } = null!;

        /// <summary>
        /// CICS: Included MQ queues
        /// </summary>
        [Output("cicsMqQueueIdIncludes")]
        public Output<ImmutableArray<string>> CicsMqQueueIdIncludes { get; private set; } = null!;

        /// <summary>
        /// When you add a transaction ID to the exclude list remaining transactions are still monitored.
        /// </summary>
        [Output("imsCrTrnIdExcludes")]
        public Output<ImmutableArray<string>> ImsCrTrnIdExcludes { get; private set; } = null!;

        /// <summary>
        /// When you add a transaction ID to the include list, all the remaining transactions are ignored.
        /// </summary>
        [Output("imsCrTrnIdIncludes")]
        public Output<ImmutableArray<string>> ImsCrTrnIdIncludes { get; private set; } = null!;

        /// <summary>
        /// IMS: Excluded MQ queues
        /// </summary>
        [Output("imsMqQueueIdExcludes")]
        public Output<ImmutableArray<string>> ImsMqQueueIdExcludes { get; private set; } = null!;

        /// <summary>
        /// IMS: Included MQ queues
        /// </summary>
        [Output("imsMqQueueIdIncludes")]
        public Output<ImmutableArray<string>> ImsMqQueueIdIncludes { get; private set; } = null!;


        /// <summary>
        /// Create a IbmMqFilters resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public IbmMqFilters(string name, IbmMqFiltersArgs? args = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/ibmMqFilters:IbmMqFilters", name, args ?? new IbmMqFiltersArgs(), MakeResourceOptions(options, ""))
        {
        }

        private IbmMqFilters(string name, Input<string> id, IbmMqFiltersState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/ibmMqFilters:IbmMqFilters", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing IbmMqFilters resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static IbmMqFilters Get(string name, Input<string> id, IbmMqFiltersState? state = null, CustomResourceOptions? options = null)
        {
            return new IbmMqFilters(name, id, state, options);
        }
    }

    public sealed class IbmMqFiltersArgs : global::Pulumi.ResourceArgs
    {
        [Input("cicsMqQueueIdExcludes")]
        private InputList<string>? _cicsMqQueueIdExcludes;

        /// <summary>
        /// CICS: Excluded MQ queues
        /// </summary>
        public InputList<string> CicsMqQueueIdExcludes
        {
            get => _cicsMqQueueIdExcludes ?? (_cicsMqQueueIdExcludes = new InputList<string>());
            set => _cicsMqQueueIdExcludes = value;
        }

        [Input("cicsMqQueueIdIncludes")]
        private InputList<string>? _cicsMqQueueIdIncludes;

        /// <summary>
        /// CICS: Included MQ queues
        /// </summary>
        public InputList<string> CicsMqQueueIdIncludes
        {
            get => _cicsMqQueueIdIncludes ?? (_cicsMqQueueIdIncludes = new InputList<string>());
            set => _cicsMqQueueIdIncludes = value;
        }

        [Input("imsCrTrnIdExcludes")]
        private InputList<string>? _imsCrTrnIdExcludes;

        /// <summary>
        /// When you add a transaction ID to the exclude list remaining transactions are still monitored.
        /// </summary>
        public InputList<string> ImsCrTrnIdExcludes
        {
            get => _imsCrTrnIdExcludes ?? (_imsCrTrnIdExcludes = new InputList<string>());
            set => _imsCrTrnIdExcludes = value;
        }

        [Input("imsCrTrnIdIncludes")]
        private InputList<string>? _imsCrTrnIdIncludes;

        /// <summary>
        /// When you add a transaction ID to the include list, all the remaining transactions are ignored.
        /// </summary>
        public InputList<string> ImsCrTrnIdIncludes
        {
            get => _imsCrTrnIdIncludes ?? (_imsCrTrnIdIncludes = new InputList<string>());
            set => _imsCrTrnIdIncludes = value;
        }

        [Input("imsMqQueueIdExcludes")]
        private InputList<string>? _imsMqQueueIdExcludes;

        /// <summary>
        /// IMS: Excluded MQ queues
        /// </summary>
        public InputList<string> ImsMqQueueIdExcludes
        {
            get => _imsMqQueueIdExcludes ?? (_imsMqQueueIdExcludes = new InputList<string>());
            set => _imsMqQueueIdExcludes = value;
        }

        [Input("imsMqQueueIdIncludes")]
        private InputList<string>? _imsMqQueueIdIncludes;

        /// <summary>
        /// IMS: Included MQ queues
        /// </summary>
        public InputList<string> ImsMqQueueIdIncludes
        {
            get => _imsMqQueueIdIncludes ?? (_imsMqQueueIdIncludes = new InputList<string>());
            set => _imsMqQueueIdIncludes = value;
        }

        public IbmMqFiltersArgs()
        {
        }
        public static new IbmMqFiltersArgs Empty => new IbmMqFiltersArgs();
    }

    public sealed class IbmMqFiltersState : global::Pulumi.ResourceArgs
    {
        [Input("cicsMqQueueIdExcludes")]
        private InputList<string>? _cicsMqQueueIdExcludes;

        /// <summary>
        /// CICS: Excluded MQ queues
        /// </summary>
        public InputList<string> CicsMqQueueIdExcludes
        {
            get => _cicsMqQueueIdExcludes ?? (_cicsMqQueueIdExcludes = new InputList<string>());
            set => _cicsMqQueueIdExcludes = value;
        }

        [Input("cicsMqQueueIdIncludes")]
        private InputList<string>? _cicsMqQueueIdIncludes;

        /// <summary>
        /// CICS: Included MQ queues
        /// </summary>
        public InputList<string> CicsMqQueueIdIncludes
        {
            get => _cicsMqQueueIdIncludes ?? (_cicsMqQueueIdIncludes = new InputList<string>());
            set => _cicsMqQueueIdIncludes = value;
        }

        [Input("imsCrTrnIdExcludes")]
        private InputList<string>? _imsCrTrnIdExcludes;

        /// <summary>
        /// When you add a transaction ID to the exclude list remaining transactions are still monitored.
        /// </summary>
        public InputList<string> ImsCrTrnIdExcludes
        {
            get => _imsCrTrnIdExcludes ?? (_imsCrTrnIdExcludes = new InputList<string>());
            set => _imsCrTrnIdExcludes = value;
        }

        [Input("imsCrTrnIdIncludes")]
        private InputList<string>? _imsCrTrnIdIncludes;

        /// <summary>
        /// When you add a transaction ID to the include list, all the remaining transactions are ignored.
        /// </summary>
        public InputList<string> ImsCrTrnIdIncludes
        {
            get => _imsCrTrnIdIncludes ?? (_imsCrTrnIdIncludes = new InputList<string>());
            set => _imsCrTrnIdIncludes = value;
        }

        [Input("imsMqQueueIdExcludes")]
        private InputList<string>? _imsMqQueueIdExcludes;

        /// <summary>
        /// IMS: Excluded MQ queues
        /// </summary>
        public InputList<string> ImsMqQueueIdExcludes
        {
            get => _imsMqQueueIdExcludes ?? (_imsMqQueueIdExcludes = new InputList<string>());
            set => _imsMqQueueIdExcludes = value;
        }

        [Input("imsMqQueueIdIncludes")]
        private InputList<string>? _imsMqQueueIdIncludes;

        /// <summary>
        /// IMS: Included MQ queues
        /// </summary>
        public InputList<string> ImsMqQueueIdIncludes
        {
            get => _imsMqQueueIdIncludes ?? (_imsMqQueueIdIncludes = new InputList<string>());
            set => _imsMqQueueIdIncludes = value;
        }

        public IbmMqFiltersState()
        {
        }
        public static new IbmMqFiltersState Empty => new IbmMqFiltersState();
    }
}