// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dynatrace

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi-dynatrace/sdk/go/dynatrace/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// The `Credentials` data source queries for Credentials stored within the Credentials Vault using the properties `name`, `scope` and `type`. At least one of `name`, `scope` or `type` needs to be specified as a non empty value. Combinations of the three properties are also possible.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi-dynatrace/sdk/go/dynatrace"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			creds, err := dynatrace.LookupCredentials(ctx, &dynatrace.LookupCredentialsArgs{
//				Name: pulumi.StringRef("Office365 Access Token"),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			_, err = dynatrace.NewHttpMonitor(ctx, "#name#", &dynatrace.HttpMonitorArgs{
//				Enabled:   pulumi.Bool(true),
//				Frequency: pulumi.Int(60),
//				Locations: pulumi.StringArray{
//					pulumi.String("SYNTHETIC_LOCATION-781752216580B1BC"),
//				},
//				AnomalyDetections: dynatrace.HttpMonitorAnomalyDetectionArray{
//					&dynatrace.HttpMonitorAnomalyDetectionArgs{
//						LoadingTimeThresholds: dynatrace.HttpMonitorAnomalyDetectionLoadingTimeThresholdArray{
//							&dynatrace.HttpMonitorAnomalyDetectionLoadingTimeThresholdArgs{
//								Enabled: pulumi.Bool(true),
//							},
//						},
//						OutageHandlings: dynatrace.HttpMonitorAnomalyDetectionOutageHandlingArray{
//							&dynatrace.HttpMonitorAnomalyDetectionOutageHandlingArgs{
//								GlobalOutage: pulumi.Bool(true),
//								LocalOutage:  pulumi.Bool(false),
//								RetryOnError: pulumi.Bool(false),
//							},
//						},
//					},
//				},
//				Script: &dynatrace.HttpMonitorScriptTypeArgs{
//					Requests: dynatrace.HttpMonitorScriptRequestArray{
//						&dynatrace.HttpMonitorScriptRequestArgs{
//							Description: pulumi.String("google.com"),
//							Method:      pulumi.String("GET"),
//							Url:         pulumi.String("https://www.google.com"),
//							Authentication: &dynatrace.HttpMonitorScriptRequestAuthenticationArgs{
//								Type:        pulumi.String("BASIC_AUTHENTICATION"),
//								Credentials: *pulumi.String(creds.Id),
//							},
//							Configuration: &dynatrace.HttpMonitorScriptRequestConfigurationArgs{
//								AcceptAnyCertificate: pulumi.Bool(true),
//								FollowRedirects:      pulumi.Bool(true),
//							},
//							Validation: &dynatrace.HttpMonitorScriptRequestValidationArgs{
//								Rules: dynatrace.HttpMonitorScriptRequestValidationRuleArray{
//									&dynatrace.HttpMonitorScriptRequestValidationRuleArgs{
//										Type:        pulumi.String("httpStatusesList"),
//										PassIfFound: pulumi.Bool(false),
//										Value:       pulumi.String(">=400"),
//									},
//								},
//							},
//						},
//					},
//				},
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func LookupCredentials(ctx *pulumi.Context, args *LookupCredentialsArgs, opts ...pulumi.InvokeOption) (*LookupCredentialsResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupCredentialsResult
	err := ctx.Invoke("dynatrace:index/getCredentials:getCredentials", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getCredentials.
type LookupCredentialsArgs struct {
	// The name of the credential as shown within the Dynatrace WebUI. If not specified all names will match
	Name *string `pulumi:"name"`
	// The scope of the credential. Possible values are `ALL`, `EXTENSION` and `SYNTHETIC`. If not specified all scopes will match.
	Scope *string `pulumi:"scope"`
	// The type of the credential. Possible values are `CERTIFICATE`, `PUBLIC_CERTIFICATE`, `TOKEN`, `USERNAME_PASSWORD` and `UNKNOWN`. If not specified all credential types will match
	Type *string `pulumi:"type"`
}

// A collection of values returned by getCredentials.
type LookupCredentialsResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// The name of the credential as shown within the Dynatrace WebUI. If not specified all names will match
	Name *string `pulumi:"name"`
	// The scope of the credential. Possible values are `ALL`, `EXTENSION` and `SYNTHETIC`. If not specified all scopes will match.
	Scope *string `pulumi:"scope"`
	// The type of the credential. Possible values are `CERTIFICATE`, `PUBLIC_CERTIFICATE`, `TOKEN`, `USERNAME_PASSWORD` and `UNKNOWN`. If not specified all credential types will match
	Type *string `pulumi:"type"`
}

func LookupCredentialsOutput(ctx *pulumi.Context, args LookupCredentialsOutputArgs, opts ...pulumi.InvokeOption) LookupCredentialsResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupCredentialsResult, error) {
			args := v.(LookupCredentialsArgs)
			r, err := LookupCredentials(ctx, &args, opts...)
			var s LookupCredentialsResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupCredentialsResultOutput)
}

// A collection of arguments for invoking getCredentials.
type LookupCredentialsOutputArgs struct {
	// The name of the credential as shown within the Dynatrace WebUI. If not specified all names will match
	Name pulumi.StringPtrInput `pulumi:"name"`
	// The scope of the credential. Possible values are `ALL`, `EXTENSION` and `SYNTHETIC`. If not specified all scopes will match.
	Scope pulumi.StringPtrInput `pulumi:"scope"`
	// The type of the credential. Possible values are `CERTIFICATE`, `PUBLIC_CERTIFICATE`, `TOKEN`, `USERNAME_PASSWORD` and `UNKNOWN`. If not specified all credential types will match
	Type pulumi.StringPtrInput `pulumi:"type"`
}

func (LookupCredentialsOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupCredentialsArgs)(nil)).Elem()
}

// A collection of values returned by getCredentials.
type LookupCredentialsResultOutput struct{ *pulumi.OutputState }

func (LookupCredentialsResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupCredentialsResult)(nil)).Elem()
}

func (o LookupCredentialsResultOutput) ToLookupCredentialsResultOutput() LookupCredentialsResultOutput {
	return o
}

func (o LookupCredentialsResultOutput) ToLookupCredentialsResultOutputWithContext(ctx context.Context) LookupCredentialsResultOutput {
	return o
}

// The provider-assigned unique ID for this managed resource.
func (o LookupCredentialsResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupCredentialsResult) string { return v.Id }).(pulumi.StringOutput)
}

// The name of the credential as shown within the Dynatrace WebUI. If not specified all names will match
func (o LookupCredentialsResultOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupCredentialsResult) *string { return v.Name }).(pulumi.StringPtrOutput)
}

// The scope of the credential. Possible values are `ALL`, `EXTENSION` and `SYNTHETIC`. If not specified all scopes will match.
func (o LookupCredentialsResultOutput) Scope() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupCredentialsResult) *string { return v.Scope }).(pulumi.StringPtrOutput)
}

// The type of the credential. Possible values are `CERTIFICATE`, `PUBLIC_CERTIFICATE`, `TOKEN`, `USERNAME_PASSWORD` and `UNKNOWN`. If not specified all credential types will match
func (o LookupCredentialsResultOutput) Type() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupCredentialsResult) *string { return v.Type }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupCredentialsResultOutput{})
}