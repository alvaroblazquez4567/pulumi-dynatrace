// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dynatrace

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi-dynatrace/sdk/go/dynatrace/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type ServiceHttpFailure struct {
	pulumi.CustomResourceState

	// HTTP 404 response codes are thrown when a web server can't find a certain page. 404s are classified as broken links on the client side and therefore aren't considered to be service failures. By enabling this setting, you can have 404s treated as server-side service failures.
	BrokenLinks ServiceHttpFailureBrokenLinksPtrOutput `pulumi:"brokenLinks"`
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolOutput `pulumi:"enabled"`
	// HTTP response codes
	HttpResponseCodes ServiceHttpFailureHttpResponseCodesPtrOutput `pulumi:"httpResponseCodes"`
	// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
	ServiceId pulumi.StringOutput `pulumi:"serviceId"`
}

// NewServiceHttpFailure registers a new resource with the given unique name, arguments, and options.
func NewServiceHttpFailure(ctx *pulumi.Context,
	name string, args *ServiceHttpFailureArgs, opts ...pulumi.ResourceOption) (*ServiceHttpFailure, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Enabled == nil {
		return nil, errors.New("invalid value for required argument 'Enabled'")
	}
	if args.ServiceId == nil {
		return nil, errors.New("invalid value for required argument 'ServiceId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource ServiceHttpFailure
	err := ctx.RegisterResource("dynatrace:index/serviceHttpFailure:ServiceHttpFailure", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetServiceHttpFailure gets an existing ServiceHttpFailure resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetServiceHttpFailure(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ServiceHttpFailureState, opts ...pulumi.ResourceOption) (*ServiceHttpFailure, error) {
	var resource ServiceHttpFailure
	err := ctx.ReadResource("dynatrace:index/serviceHttpFailure:ServiceHttpFailure", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ServiceHttpFailure resources.
type serviceHttpFailureState struct {
	// HTTP 404 response codes are thrown when a web server can't find a certain page. 404s are classified as broken links on the client side and therefore aren't considered to be service failures. By enabling this setting, you can have 404s treated as server-side service failures.
	BrokenLinks *ServiceHttpFailureBrokenLinks `pulumi:"brokenLinks"`
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled *bool `pulumi:"enabled"`
	// HTTP response codes
	HttpResponseCodes *ServiceHttpFailureHttpResponseCodes `pulumi:"httpResponseCodes"`
	// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
	ServiceId *string `pulumi:"serviceId"`
}

type ServiceHttpFailureState struct {
	// HTTP 404 response codes are thrown when a web server can't find a certain page. 404s are classified as broken links on the client side and therefore aren't considered to be service failures. By enabling this setting, you can have 404s treated as server-side service failures.
	BrokenLinks ServiceHttpFailureBrokenLinksPtrInput
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolPtrInput
	// HTTP response codes
	HttpResponseCodes ServiceHttpFailureHttpResponseCodesPtrInput
	// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
	ServiceId pulumi.StringPtrInput
}

func (ServiceHttpFailureState) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceHttpFailureState)(nil)).Elem()
}

type serviceHttpFailureArgs struct {
	// HTTP 404 response codes are thrown when a web server can't find a certain page. 404s are classified as broken links on the client side and therefore aren't considered to be service failures. By enabling this setting, you can have 404s treated as server-side service failures.
	BrokenLinks *ServiceHttpFailureBrokenLinks `pulumi:"brokenLinks"`
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled bool `pulumi:"enabled"`
	// HTTP response codes
	HttpResponseCodes *ServiceHttpFailureHttpResponseCodes `pulumi:"httpResponseCodes"`
	// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
	ServiceId string `pulumi:"serviceId"`
}

// The set of arguments for constructing a ServiceHttpFailure resource.
type ServiceHttpFailureArgs struct {
	// HTTP 404 response codes are thrown when a web server can't find a certain page. 404s are classified as broken links on the client side and therefore aren't considered to be service failures. By enabling this setting, you can have 404s treated as server-side service failures.
	BrokenLinks ServiceHttpFailureBrokenLinksPtrInput
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolInput
	// HTTP response codes
	HttpResponseCodes ServiceHttpFailureHttpResponseCodesPtrInput
	// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
	ServiceId pulumi.StringInput
}

func (ServiceHttpFailureArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceHttpFailureArgs)(nil)).Elem()
}

type ServiceHttpFailureInput interface {
	pulumi.Input

	ToServiceHttpFailureOutput() ServiceHttpFailureOutput
	ToServiceHttpFailureOutputWithContext(ctx context.Context) ServiceHttpFailureOutput
}

func (*ServiceHttpFailure) ElementType() reflect.Type {
	return reflect.TypeOf((**ServiceHttpFailure)(nil)).Elem()
}

func (i *ServiceHttpFailure) ToServiceHttpFailureOutput() ServiceHttpFailureOutput {
	return i.ToServiceHttpFailureOutputWithContext(context.Background())
}

func (i *ServiceHttpFailure) ToServiceHttpFailureOutputWithContext(ctx context.Context) ServiceHttpFailureOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceHttpFailureOutput)
}

// ServiceHttpFailureArrayInput is an input type that accepts ServiceHttpFailureArray and ServiceHttpFailureArrayOutput values.
// You can construct a concrete instance of `ServiceHttpFailureArrayInput` via:
//
//	ServiceHttpFailureArray{ ServiceHttpFailureArgs{...} }
type ServiceHttpFailureArrayInput interface {
	pulumi.Input

	ToServiceHttpFailureArrayOutput() ServiceHttpFailureArrayOutput
	ToServiceHttpFailureArrayOutputWithContext(context.Context) ServiceHttpFailureArrayOutput
}

type ServiceHttpFailureArray []ServiceHttpFailureInput

func (ServiceHttpFailureArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ServiceHttpFailure)(nil)).Elem()
}

func (i ServiceHttpFailureArray) ToServiceHttpFailureArrayOutput() ServiceHttpFailureArrayOutput {
	return i.ToServiceHttpFailureArrayOutputWithContext(context.Background())
}

func (i ServiceHttpFailureArray) ToServiceHttpFailureArrayOutputWithContext(ctx context.Context) ServiceHttpFailureArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceHttpFailureArrayOutput)
}

// ServiceHttpFailureMapInput is an input type that accepts ServiceHttpFailureMap and ServiceHttpFailureMapOutput values.
// You can construct a concrete instance of `ServiceHttpFailureMapInput` via:
//
//	ServiceHttpFailureMap{ "key": ServiceHttpFailureArgs{...} }
type ServiceHttpFailureMapInput interface {
	pulumi.Input

	ToServiceHttpFailureMapOutput() ServiceHttpFailureMapOutput
	ToServiceHttpFailureMapOutputWithContext(context.Context) ServiceHttpFailureMapOutput
}

type ServiceHttpFailureMap map[string]ServiceHttpFailureInput

func (ServiceHttpFailureMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ServiceHttpFailure)(nil)).Elem()
}

func (i ServiceHttpFailureMap) ToServiceHttpFailureMapOutput() ServiceHttpFailureMapOutput {
	return i.ToServiceHttpFailureMapOutputWithContext(context.Background())
}

func (i ServiceHttpFailureMap) ToServiceHttpFailureMapOutputWithContext(ctx context.Context) ServiceHttpFailureMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceHttpFailureMapOutput)
}

type ServiceHttpFailureOutput struct{ *pulumi.OutputState }

func (ServiceHttpFailureOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ServiceHttpFailure)(nil)).Elem()
}

func (o ServiceHttpFailureOutput) ToServiceHttpFailureOutput() ServiceHttpFailureOutput {
	return o
}

func (o ServiceHttpFailureOutput) ToServiceHttpFailureOutputWithContext(ctx context.Context) ServiceHttpFailureOutput {
	return o
}

// HTTP 404 response codes are thrown when a web server can't find a certain page. 404s are classified as broken links on the client side and therefore aren't considered to be service failures. By enabling this setting, you can have 404s treated as server-side service failures.
func (o ServiceHttpFailureOutput) BrokenLinks() ServiceHttpFailureBrokenLinksPtrOutput {
	return o.ApplyT(func(v *ServiceHttpFailure) ServiceHttpFailureBrokenLinksPtrOutput { return v.BrokenLinks }).(ServiceHttpFailureBrokenLinksPtrOutput)
}

// This setting is enabled (`true`) or disabled (`false`)
func (o ServiceHttpFailureOutput) Enabled() pulumi.BoolOutput {
	return o.ApplyT(func(v *ServiceHttpFailure) pulumi.BoolOutput { return v.Enabled }).(pulumi.BoolOutput)
}

// HTTP response codes
func (o ServiceHttpFailureOutput) HttpResponseCodes() ServiceHttpFailureHttpResponseCodesPtrOutput {
	return o.ApplyT(func(v *ServiceHttpFailure) ServiceHttpFailureHttpResponseCodesPtrOutput { return v.HttpResponseCodes }).(ServiceHttpFailureHttpResponseCodesPtrOutput)
}

// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
func (o ServiceHttpFailureOutput) ServiceId() pulumi.StringOutput {
	return o.ApplyT(func(v *ServiceHttpFailure) pulumi.StringOutput { return v.ServiceId }).(pulumi.StringOutput)
}

type ServiceHttpFailureArrayOutput struct{ *pulumi.OutputState }

func (ServiceHttpFailureArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ServiceHttpFailure)(nil)).Elem()
}

func (o ServiceHttpFailureArrayOutput) ToServiceHttpFailureArrayOutput() ServiceHttpFailureArrayOutput {
	return o
}

func (o ServiceHttpFailureArrayOutput) ToServiceHttpFailureArrayOutputWithContext(ctx context.Context) ServiceHttpFailureArrayOutput {
	return o
}

func (o ServiceHttpFailureArrayOutput) Index(i pulumi.IntInput) ServiceHttpFailureOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ServiceHttpFailure {
		return vs[0].([]*ServiceHttpFailure)[vs[1].(int)]
	}).(ServiceHttpFailureOutput)
}

type ServiceHttpFailureMapOutput struct{ *pulumi.OutputState }

func (ServiceHttpFailureMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ServiceHttpFailure)(nil)).Elem()
}

func (o ServiceHttpFailureMapOutput) ToServiceHttpFailureMapOutput() ServiceHttpFailureMapOutput {
	return o
}

func (o ServiceHttpFailureMapOutput) ToServiceHttpFailureMapOutputWithContext(ctx context.Context) ServiceHttpFailureMapOutput {
	return o
}

func (o ServiceHttpFailureMapOutput) MapIndex(k pulumi.StringInput) ServiceHttpFailureOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ServiceHttpFailure {
		return vs[0].(map[string]*ServiceHttpFailure)[vs[1].(string)]
	}).(ServiceHttpFailureOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ServiceHttpFailureInput)(nil)).Elem(), &ServiceHttpFailure{})
	pulumi.RegisterInputType(reflect.TypeOf((*ServiceHttpFailureArrayInput)(nil)).Elem(), ServiceHttpFailureArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ServiceHttpFailureMapInput)(nil)).Elem(), ServiceHttpFailureMap{})
	pulumi.RegisterOutputType(ServiceHttpFailureOutput{})
	pulumi.RegisterOutputType(ServiceHttpFailureArrayOutput{})
	pulumi.RegisterOutputType(ServiceHttpFailureMapOutput{})
}
