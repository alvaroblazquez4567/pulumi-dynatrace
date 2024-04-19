// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dynatrace

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi-dynatrace/sdk/go/dynatrace/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// The `AzureCredentials` data source allows the Azure credential ID to be retrieved by its label.
//
// - `label` (String) - The label/name of the Azure credential
func LookupAzureCredentials(ctx *pulumi.Context, args *LookupAzureCredentialsArgs, opts ...pulumi.InvokeOption) (*LookupAzureCredentialsResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupAzureCredentialsResult
	err := ctx.Invoke("dynatrace:index/getAzureCredentials:getAzureCredentials", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getAzureCredentials.
type LookupAzureCredentialsArgs struct {
	Label string `pulumi:"label"`
}

// A collection of values returned by getAzureCredentials.
type LookupAzureCredentialsResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id    string `pulumi:"id"`
	Label string `pulumi:"label"`
}

func LookupAzureCredentialsOutput(ctx *pulumi.Context, args LookupAzureCredentialsOutputArgs, opts ...pulumi.InvokeOption) LookupAzureCredentialsResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupAzureCredentialsResult, error) {
			args := v.(LookupAzureCredentialsArgs)
			r, err := LookupAzureCredentials(ctx, &args, opts...)
			var s LookupAzureCredentialsResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupAzureCredentialsResultOutput)
}

// A collection of arguments for invoking getAzureCredentials.
type LookupAzureCredentialsOutputArgs struct {
	Label pulumi.StringInput `pulumi:"label"`
}

func (LookupAzureCredentialsOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupAzureCredentialsArgs)(nil)).Elem()
}

// A collection of values returned by getAzureCredentials.
type LookupAzureCredentialsResultOutput struct{ *pulumi.OutputState }

func (LookupAzureCredentialsResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupAzureCredentialsResult)(nil)).Elem()
}

func (o LookupAzureCredentialsResultOutput) ToLookupAzureCredentialsResultOutput() LookupAzureCredentialsResultOutput {
	return o
}

func (o LookupAzureCredentialsResultOutput) ToLookupAzureCredentialsResultOutputWithContext(ctx context.Context) LookupAzureCredentialsResultOutput {
	return o
}

// The provider-assigned unique ID for this managed resource.
func (o LookupAzureCredentialsResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAzureCredentialsResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupAzureCredentialsResultOutput) Label() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAzureCredentialsResult) string { return v.Label }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupAzureCredentialsResultOutput{})
}
