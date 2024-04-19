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
    [DynatraceResourceType("dynatrace:index/managedSmtp:ManagedSmtp")]
    public partial class ManagedSmtp : global::Pulumi.CustomResource
    {
        /// <summary>
        /// If true, we will send e-mails via Mission Control in case of problems with SMTP server.
        /// </summary>
        [Output("allowFallbackViaMissionControl")]
        public Output<bool?> AllowFallbackViaMissionControl { get; private set; } = null!;

        /// <summary>
        /// Connection security, possible values: `NO_ENCRYPTION`, `OPTIONAL_STARTTLS`, `REQUIRE_STARTTLS`, `TLS`. Default: `NO_ENCRYPTION`
        /// </summary>
        [Output("connectionSecurity")]
        public Output<string?> ConnectionSecurity { get; private set; } = null!;

        /// <summary>
        /// Host Name
        /// </summary>
        [Output("hostName")]
        public Output<string> HostName { get; private set; } = null!;

        /// <summary>
        /// If true, a password has been configured. Default: `false`.
        /// </summary>
        [Output("isPasswordConfigured")]
        public Output<bool?> IsPasswordConfigured { get; private set; } = null!;

        /// <summary>
        /// Password
        /// </summary>
        [Output("password")]
        public Output<string> Password { get; private set; } = null!;

        /// <summary>
        /// Integer value of port. Default: `25`
        /// </summary>
        [Output("port")]
        public Output<int?> Port { get; private set; } = null!;

        /// <summary>
        /// Sender email address
        /// </summary>
        [Output("senderEmailAddress")]
        public Output<string> SenderEmailAddress { get; private set; } = null!;

        /// <summary>
        /// If true, we will send e-mails via SMTP server.
        /// </summary>
        [Output("useSmtpServer")]
        public Output<bool?> UseSmtpServer { get; private set; } = null!;

        /// <summary>
        /// User Name
        /// </summary>
        [Output("userName")]
        public Output<string> UserName { get; private set; } = null!;


        /// <summary>
        /// Create a ManagedSmtp resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ManagedSmtp(string name, ManagedSmtpArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/managedSmtp:ManagedSmtp", name, args ?? new ManagedSmtpArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ManagedSmtp(string name, Input<string> id, ManagedSmtpState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/managedSmtp:ManagedSmtp", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/alvaroblazquez4567",
                AdditionalSecretOutputs =
                {
                    "password",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ManagedSmtp resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ManagedSmtp Get(string name, Input<string> id, ManagedSmtpState? state = null, CustomResourceOptions? options = null)
        {
            return new ManagedSmtp(name, id, state, options);
        }
    }

    public sealed class ManagedSmtpArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// If true, we will send e-mails via Mission Control in case of problems with SMTP server.
        /// </summary>
        [Input("allowFallbackViaMissionControl")]
        public Input<bool>? AllowFallbackViaMissionControl { get; set; }

        /// <summary>
        /// Connection security, possible values: `NO_ENCRYPTION`, `OPTIONAL_STARTTLS`, `REQUIRE_STARTTLS`, `TLS`. Default: `NO_ENCRYPTION`
        /// </summary>
        [Input("connectionSecurity")]
        public Input<string>? ConnectionSecurity { get; set; }

        /// <summary>
        /// Host Name
        /// </summary>
        [Input("hostName", required: true)]
        public Input<string> HostName { get; set; } = null!;

        /// <summary>
        /// If true, a password has been configured. Default: `false`.
        /// </summary>
        [Input("isPasswordConfigured")]
        public Input<bool>? IsPasswordConfigured { get; set; }

        [Input("password", required: true)]
        private Input<string>? _password;

        /// <summary>
        /// Password
        /// </summary>
        public Input<string>? Password
        {
            get => _password;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _password = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// Integer value of port. Default: `25`
        /// </summary>
        [Input("port")]
        public Input<int>? Port { get; set; }

        /// <summary>
        /// Sender email address
        /// </summary>
        [Input("senderEmailAddress", required: true)]
        public Input<string> SenderEmailAddress { get; set; } = null!;

        /// <summary>
        /// If true, we will send e-mails via SMTP server.
        /// </summary>
        [Input("useSmtpServer")]
        public Input<bool>? UseSmtpServer { get; set; }

        /// <summary>
        /// User Name
        /// </summary>
        [Input("userName", required: true)]
        public Input<string> UserName { get; set; } = null!;

        public ManagedSmtpArgs()
        {
        }
        public static new ManagedSmtpArgs Empty => new ManagedSmtpArgs();
    }

    public sealed class ManagedSmtpState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// If true, we will send e-mails via Mission Control in case of problems with SMTP server.
        /// </summary>
        [Input("allowFallbackViaMissionControl")]
        public Input<bool>? AllowFallbackViaMissionControl { get; set; }

        /// <summary>
        /// Connection security, possible values: `NO_ENCRYPTION`, `OPTIONAL_STARTTLS`, `REQUIRE_STARTTLS`, `TLS`. Default: `NO_ENCRYPTION`
        /// </summary>
        [Input("connectionSecurity")]
        public Input<string>? ConnectionSecurity { get; set; }

        /// <summary>
        /// Host Name
        /// </summary>
        [Input("hostName")]
        public Input<string>? HostName { get; set; }

        /// <summary>
        /// If true, a password has been configured. Default: `false`.
        /// </summary>
        [Input("isPasswordConfigured")]
        public Input<bool>? IsPasswordConfigured { get; set; }

        [Input("password")]
        private Input<string>? _password;

        /// <summary>
        /// Password
        /// </summary>
        public Input<string>? Password
        {
            get => _password;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _password = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// Integer value of port. Default: `25`
        /// </summary>
        [Input("port")]
        public Input<int>? Port { get; set; }

        /// <summary>
        /// Sender email address
        /// </summary>
        [Input("senderEmailAddress")]
        public Input<string>? SenderEmailAddress { get; set; }

        /// <summary>
        /// If true, we will send e-mails via SMTP server.
        /// </summary>
        [Input("useSmtpServer")]
        public Input<bool>? UseSmtpServer { get; set; }

        /// <summary>
        /// User Name
        /// </summary>
        [Input("userName")]
        public Input<string>? UserName { get; set; }

        public ManagedSmtpState()
        {
        }
        public static new ManagedSmtpState Empty => new ManagedSmtpState();
    }
}