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

type Nettracer struct {
	pulumi.CustomResourceState

	// When disabled, OneAgent won't use NetTracer to collect network data from containers. Disabled by default. Applies only to Linux hosts. Requires OneAgent 1.231+.
	NetTracer pulumi.BoolOutput `pulumi:"netTracer"`
	// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
	Scope pulumi.StringPtrOutput `pulumi:"scope"`
}

// NewNettracer registers a new resource with the given unique name, arguments, and options.
func NewNettracer(ctx *pulumi.Context,
	name string, args *NettracerArgs, opts ...pulumi.ResourceOption) (*Nettracer, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.NetTracer == nil {
		return nil, errors.New("invalid value for required argument 'NetTracer'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource Nettracer
	err := ctx.RegisterResource("dynatrace:index/nettracer:Nettracer", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetNettracer gets an existing Nettracer resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNettracer(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *NettracerState, opts ...pulumi.ResourceOption) (*Nettracer, error) {
	var resource Nettracer
	err := ctx.ReadResource("dynatrace:index/nettracer:Nettracer", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Nettracer resources.
type nettracerState struct {
	// When disabled, OneAgent won't use NetTracer to collect network data from containers. Disabled by default. Applies only to Linux hosts. Requires OneAgent 1.231+.
	NetTracer *bool `pulumi:"netTracer"`
	// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
	Scope *string `pulumi:"scope"`
}

type NettracerState struct {
	// When disabled, OneAgent won't use NetTracer to collect network data from containers. Disabled by default. Applies only to Linux hosts. Requires OneAgent 1.231+.
	NetTracer pulumi.BoolPtrInput
	// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
	Scope pulumi.StringPtrInput
}

func (NettracerState) ElementType() reflect.Type {
	return reflect.TypeOf((*nettracerState)(nil)).Elem()
}

type nettracerArgs struct {
	// When disabled, OneAgent won't use NetTracer to collect network data from containers. Disabled by default. Applies only to Linux hosts. Requires OneAgent 1.231+.
	NetTracer bool `pulumi:"netTracer"`
	// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
	Scope *string `pulumi:"scope"`
}

// The set of arguments for constructing a Nettracer resource.
type NettracerArgs struct {
	// When disabled, OneAgent won't use NetTracer to collect network data from containers. Disabled by default. Applies only to Linux hosts. Requires OneAgent 1.231+.
	NetTracer pulumi.BoolInput
	// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
	Scope pulumi.StringPtrInput
}

func (NettracerArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*nettracerArgs)(nil)).Elem()
}

type NettracerInput interface {
	pulumi.Input

	ToNettracerOutput() NettracerOutput
	ToNettracerOutputWithContext(ctx context.Context) NettracerOutput
}

func (*Nettracer) ElementType() reflect.Type {
	return reflect.TypeOf((**Nettracer)(nil)).Elem()
}

func (i *Nettracer) ToNettracerOutput() NettracerOutput {
	return i.ToNettracerOutputWithContext(context.Background())
}

func (i *Nettracer) ToNettracerOutputWithContext(ctx context.Context) NettracerOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NettracerOutput)
}

// NettracerArrayInput is an input type that accepts NettracerArray and NettracerArrayOutput values.
// You can construct a concrete instance of `NettracerArrayInput` via:
//
//	NettracerArray{ NettracerArgs{...} }
type NettracerArrayInput interface {
	pulumi.Input

	ToNettracerArrayOutput() NettracerArrayOutput
	ToNettracerArrayOutputWithContext(context.Context) NettracerArrayOutput
}

type NettracerArray []NettracerInput

func (NettracerArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Nettracer)(nil)).Elem()
}

func (i NettracerArray) ToNettracerArrayOutput() NettracerArrayOutput {
	return i.ToNettracerArrayOutputWithContext(context.Background())
}

func (i NettracerArray) ToNettracerArrayOutputWithContext(ctx context.Context) NettracerArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NettracerArrayOutput)
}

// NettracerMapInput is an input type that accepts NettracerMap and NettracerMapOutput values.
// You can construct a concrete instance of `NettracerMapInput` via:
//
//	NettracerMap{ "key": NettracerArgs{...} }
type NettracerMapInput interface {
	pulumi.Input

	ToNettracerMapOutput() NettracerMapOutput
	ToNettracerMapOutputWithContext(context.Context) NettracerMapOutput
}

type NettracerMap map[string]NettracerInput

func (NettracerMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Nettracer)(nil)).Elem()
}

func (i NettracerMap) ToNettracerMapOutput() NettracerMapOutput {
	return i.ToNettracerMapOutputWithContext(context.Background())
}

func (i NettracerMap) ToNettracerMapOutputWithContext(ctx context.Context) NettracerMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NettracerMapOutput)
}

type NettracerOutput struct{ *pulumi.OutputState }

func (NettracerOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Nettracer)(nil)).Elem()
}

func (o NettracerOutput) ToNettracerOutput() NettracerOutput {
	return o
}

func (o NettracerOutput) ToNettracerOutputWithContext(ctx context.Context) NettracerOutput {
	return o
}

// When disabled, OneAgent won't use NetTracer to collect network data from containers. Disabled by default. Applies only to Linux hosts. Requires OneAgent 1.231+.
func (o NettracerOutput) NetTracer() pulumi.BoolOutput {
	return o.ApplyT(func(v *Nettracer) pulumi.BoolOutput { return v.NetTracer }).(pulumi.BoolOutput)
}

// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
func (o NettracerOutput) Scope() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Nettracer) pulumi.StringPtrOutput { return v.Scope }).(pulumi.StringPtrOutput)
}

type NettracerArrayOutput struct{ *pulumi.OutputState }

func (NettracerArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Nettracer)(nil)).Elem()
}

func (o NettracerArrayOutput) ToNettracerArrayOutput() NettracerArrayOutput {
	return o
}

func (o NettracerArrayOutput) ToNettracerArrayOutputWithContext(ctx context.Context) NettracerArrayOutput {
	return o
}

func (o NettracerArrayOutput) Index(i pulumi.IntInput) NettracerOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Nettracer {
		return vs[0].([]*Nettracer)[vs[1].(int)]
	}).(NettracerOutput)
}

type NettracerMapOutput struct{ *pulumi.OutputState }

func (NettracerMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Nettracer)(nil)).Elem()
}

func (o NettracerMapOutput) ToNettracerMapOutput() NettracerMapOutput {
	return o
}

func (o NettracerMapOutput) ToNettracerMapOutputWithContext(ctx context.Context) NettracerMapOutput {
	return o
}

func (o NettracerMapOutput) MapIndex(k pulumi.StringInput) NettracerOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Nettracer {
		return vs[0].(map[string]*Nettracer)[vs[1].(string)]
	}).(NettracerOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*NettracerInput)(nil)).Elem(), &Nettracer{})
	pulumi.RegisterInputType(reflect.TypeOf((*NettracerArrayInput)(nil)).Elem(), NettracerArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*NettracerMapInput)(nil)).Elem(), NettracerMap{})
	pulumi.RegisterOutputType(NettracerOutput{})
	pulumi.RegisterOutputType(NettracerArrayOutput{})
	pulumi.RegisterOutputType(NettracerMapOutput{})
}
