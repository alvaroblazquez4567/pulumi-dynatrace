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
    [DynatraceResourceType("dynatrace:index/rumIpLocations:RumIpLocations")]
    public partial class RumIpLocations : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The city name of the location.
        /// </summary>
        [Output("city")]
        public Output<string?> City { get; private set; } = null!;

        /// <summary>
        /// The country code of the location.
        /// </summary>
        [Output("countryCode")]
        public Output<string> CountryCode { get; private set; } = null!;

        /// <summary>
        /// Single IP or IP range start address
        /// </summary>
        [Output("ip")]
        public Output<string> Ip { get; private set; } = null!;

        /// <summary>
        /// IP range end
        /// </summary>
        [Output("ipTo")]
        public Output<string?> IpTo { get; private set; } = null!;

        /// <summary>
        /// Latitude
        /// </summary>
        [Output("latitude")]
        public Output<double?> Latitude { get; private set; } = null!;

        /// <summary>
        /// Longitude
        /// </summary>
        [Output("longitude")]
        public Output<double?> Longitude { get; private set; } = null!;

        /// <summary>
        /// The region code of the location. For the [USA](https://dt-url.net/iso3166us) or [Canada](https://dt-url.net/iso3166ca)
        /// use ISO 3166-2 state codes without `US-` or `CA-` prefix. For the rest of the world use [FIPS 10-4
        /// codes](https://dt-url.net/fipscodes) without country prefix.
        /// </summary>
        [Output("regionCode")]
        public Output<string?> RegionCode { get; private set; } = null!;


        /// <summary>
        /// Create a RumIpLocations resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public RumIpLocations(string name, RumIpLocationsArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/rumIpLocations:RumIpLocations", name, args ?? new RumIpLocationsArgs(), MakeResourceOptions(options, ""))
        {
        }

        private RumIpLocations(string name, Input<string> id, RumIpLocationsState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/rumIpLocations:RumIpLocations", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing RumIpLocations resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static RumIpLocations Get(string name, Input<string> id, RumIpLocationsState? state = null, CustomResourceOptions? options = null)
        {
            return new RumIpLocations(name, id, state, options);
        }
    }

    public sealed class RumIpLocationsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The city name of the location.
        /// </summary>
        [Input("city")]
        public Input<string>? City { get; set; }

        /// <summary>
        /// The country code of the location.
        /// </summary>
        [Input("countryCode", required: true)]
        public Input<string> CountryCode { get; set; } = null!;

        /// <summary>
        /// Single IP or IP range start address
        /// </summary>
        [Input("ip", required: true)]
        public Input<string> Ip { get; set; } = null!;

        /// <summary>
        /// IP range end
        /// </summary>
        [Input("ipTo")]
        public Input<string>? IpTo { get; set; }

        /// <summary>
        /// Latitude
        /// </summary>
        [Input("latitude")]
        public Input<double>? Latitude { get; set; }

        /// <summary>
        /// Longitude
        /// </summary>
        [Input("longitude")]
        public Input<double>? Longitude { get; set; }

        /// <summary>
        /// The region code of the location. For the [USA](https://dt-url.net/iso3166us) or [Canada](https://dt-url.net/iso3166ca)
        /// use ISO 3166-2 state codes without `US-` or `CA-` prefix. For the rest of the world use [FIPS 10-4
        /// codes](https://dt-url.net/fipscodes) without country prefix.
        /// </summary>
        [Input("regionCode")]
        public Input<string>? RegionCode { get; set; }

        public RumIpLocationsArgs()
        {
        }
        public static new RumIpLocationsArgs Empty => new RumIpLocationsArgs();
    }

    public sealed class RumIpLocationsState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The city name of the location.
        /// </summary>
        [Input("city")]
        public Input<string>? City { get; set; }

        /// <summary>
        /// The country code of the location.
        /// </summary>
        [Input("countryCode")]
        public Input<string>? CountryCode { get; set; }

        /// <summary>
        /// Single IP or IP range start address
        /// </summary>
        [Input("ip")]
        public Input<string>? Ip { get; set; }

        /// <summary>
        /// IP range end
        /// </summary>
        [Input("ipTo")]
        public Input<string>? IpTo { get; set; }

        /// <summary>
        /// Latitude
        /// </summary>
        [Input("latitude")]
        public Input<double>? Latitude { get; set; }

        /// <summary>
        /// Longitude
        /// </summary>
        [Input("longitude")]
        public Input<double>? Longitude { get; set; }

        /// <summary>
        /// The region code of the location. For the [USA](https://dt-url.net/iso3166us) or [Canada](https://dt-url.net/iso3166ca)
        /// use ISO 3166-2 state codes without `US-` or `CA-` prefix. For the rest of the world use [FIPS 10-4
        /// codes](https://dt-url.net/fipscodes) without country prefix.
        /// </summary>
        [Input("regionCode")]
        public Input<string>? RegionCode { get; set; }

        public RumIpLocationsState()
        {
        }
        public static new RumIpLocationsState Empty => new RumIpLocationsState();
    }
}
