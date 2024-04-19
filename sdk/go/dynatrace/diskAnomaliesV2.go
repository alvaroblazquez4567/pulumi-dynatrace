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

type DiskAnomaliesV2 struct {
	pulumi.CustomResourceState

	// Disk
	Disk DiskAnomaliesV2DiskOutput `pulumi:"disk"`
	// The scope for the disk anomaly detection
	Scope pulumi.StringOutput `pulumi:"scope"`
}

// NewDiskAnomaliesV2 registers a new resource with the given unique name, arguments, and options.
func NewDiskAnomaliesV2(ctx *pulumi.Context,
	name string, args *DiskAnomaliesV2Args, opts ...pulumi.ResourceOption) (*DiskAnomaliesV2, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Disk == nil {
		return nil, errors.New("invalid value for required argument 'Disk'")
	}
	if args.Scope == nil {
		return nil, errors.New("invalid value for required argument 'Scope'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource DiskAnomaliesV2
	err := ctx.RegisterResource("dynatrace:index/diskAnomaliesV2:DiskAnomaliesV2", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDiskAnomaliesV2 gets an existing DiskAnomaliesV2 resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDiskAnomaliesV2(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DiskAnomaliesV2State, opts ...pulumi.ResourceOption) (*DiskAnomaliesV2, error) {
	var resource DiskAnomaliesV2
	err := ctx.ReadResource("dynatrace:index/diskAnomaliesV2:DiskAnomaliesV2", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DiskAnomaliesV2 resources.
type diskAnomaliesV2State struct {
	// Disk
	Disk *DiskAnomaliesV2Disk `pulumi:"disk"`
	// The scope for the disk anomaly detection
	Scope *string `pulumi:"scope"`
}

type DiskAnomaliesV2State struct {
	// Disk
	Disk DiskAnomaliesV2DiskPtrInput
	// The scope for the disk anomaly detection
	Scope pulumi.StringPtrInput
}

func (DiskAnomaliesV2State) ElementType() reflect.Type {
	return reflect.TypeOf((*diskAnomaliesV2State)(nil)).Elem()
}

type diskAnomaliesV2Args struct {
	// Disk
	Disk DiskAnomaliesV2Disk `pulumi:"disk"`
	// The scope for the disk anomaly detection
	Scope string `pulumi:"scope"`
}

// The set of arguments for constructing a DiskAnomaliesV2 resource.
type DiskAnomaliesV2Args struct {
	// Disk
	Disk DiskAnomaliesV2DiskInput
	// The scope for the disk anomaly detection
	Scope pulumi.StringInput
}

func (DiskAnomaliesV2Args) ElementType() reflect.Type {
	return reflect.TypeOf((*diskAnomaliesV2Args)(nil)).Elem()
}

type DiskAnomaliesV2Input interface {
	pulumi.Input

	ToDiskAnomaliesV2Output() DiskAnomaliesV2Output
	ToDiskAnomaliesV2OutputWithContext(ctx context.Context) DiskAnomaliesV2Output
}

func (*DiskAnomaliesV2) ElementType() reflect.Type {
	return reflect.TypeOf((**DiskAnomaliesV2)(nil)).Elem()
}

func (i *DiskAnomaliesV2) ToDiskAnomaliesV2Output() DiskAnomaliesV2Output {
	return i.ToDiskAnomaliesV2OutputWithContext(context.Background())
}

func (i *DiskAnomaliesV2) ToDiskAnomaliesV2OutputWithContext(ctx context.Context) DiskAnomaliesV2Output {
	return pulumi.ToOutputWithContext(ctx, i).(DiskAnomaliesV2Output)
}

// DiskAnomaliesV2ArrayInput is an input type that accepts DiskAnomaliesV2Array and DiskAnomaliesV2ArrayOutput values.
// You can construct a concrete instance of `DiskAnomaliesV2ArrayInput` via:
//
//	DiskAnomaliesV2Array{ DiskAnomaliesV2Args{...} }
type DiskAnomaliesV2ArrayInput interface {
	pulumi.Input

	ToDiskAnomaliesV2ArrayOutput() DiskAnomaliesV2ArrayOutput
	ToDiskAnomaliesV2ArrayOutputWithContext(context.Context) DiskAnomaliesV2ArrayOutput
}

type DiskAnomaliesV2Array []DiskAnomaliesV2Input

func (DiskAnomaliesV2Array) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DiskAnomaliesV2)(nil)).Elem()
}

func (i DiskAnomaliesV2Array) ToDiskAnomaliesV2ArrayOutput() DiskAnomaliesV2ArrayOutput {
	return i.ToDiskAnomaliesV2ArrayOutputWithContext(context.Background())
}

func (i DiskAnomaliesV2Array) ToDiskAnomaliesV2ArrayOutputWithContext(ctx context.Context) DiskAnomaliesV2ArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DiskAnomaliesV2ArrayOutput)
}

// DiskAnomaliesV2MapInput is an input type that accepts DiskAnomaliesV2Map and DiskAnomaliesV2MapOutput values.
// You can construct a concrete instance of `DiskAnomaliesV2MapInput` via:
//
//	DiskAnomaliesV2Map{ "key": DiskAnomaliesV2Args{...} }
type DiskAnomaliesV2MapInput interface {
	pulumi.Input

	ToDiskAnomaliesV2MapOutput() DiskAnomaliesV2MapOutput
	ToDiskAnomaliesV2MapOutputWithContext(context.Context) DiskAnomaliesV2MapOutput
}

type DiskAnomaliesV2Map map[string]DiskAnomaliesV2Input

func (DiskAnomaliesV2Map) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DiskAnomaliesV2)(nil)).Elem()
}

func (i DiskAnomaliesV2Map) ToDiskAnomaliesV2MapOutput() DiskAnomaliesV2MapOutput {
	return i.ToDiskAnomaliesV2MapOutputWithContext(context.Background())
}

func (i DiskAnomaliesV2Map) ToDiskAnomaliesV2MapOutputWithContext(ctx context.Context) DiskAnomaliesV2MapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DiskAnomaliesV2MapOutput)
}

type DiskAnomaliesV2Output struct{ *pulumi.OutputState }

func (DiskAnomaliesV2Output) ElementType() reflect.Type {
	return reflect.TypeOf((**DiskAnomaliesV2)(nil)).Elem()
}

func (o DiskAnomaliesV2Output) ToDiskAnomaliesV2Output() DiskAnomaliesV2Output {
	return o
}

func (o DiskAnomaliesV2Output) ToDiskAnomaliesV2OutputWithContext(ctx context.Context) DiskAnomaliesV2Output {
	return o
}

// Disk
func (o DiskAnomaliesV2Output) Disk() DiskAnomaliesV2DiskOutput {
	return o.ApplyT(func(v *DiskAnomaliesV2) DiskAnomaliesV2DiskOutput { return v.Disk }).(DiskAnomaliesV2DiskOutput)
}

// The scope for the disk anomaly detection
func (o DiskAnomaliesV2Output) Scope() pulumi.StringOutput {
	return o.ApplyT(func(v *DiskAnomaliesV2) pulumi.StringOutput { return v.Scope }).(pulumi.StringOutput)
}

type DiskAnomaliesV2ArrayOutput struct{ *pulumi.OutputState }

func (DiskAnomaliesV2ArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DiskAnomaliesV2)(nil)).Elem()
}

func (o DiskAnomaliesV2ArrayOutput) ToDiskAnomaliesV2ArrayOutput() DiskAnomaliesV2ArrayOutput {
	return o
}

func (o DiskAnomaliesV2ArrayOutput) ToDiskAnomaliesV2ArrayOutputWithContext(ctx context.Context) DiskAnomaliesV2ArrayOutput {
	return o
}

func (o DiskAnomaliesV2ArrayOutput) Index(i pulumi.IntInput) DiskAnomaliesV2Output {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *DiskAnomaliesV2 {
		return vs[0].([]*DiskAnomaliesV2)[vs[1].(int)]
	}).(DiskAnomaliesV2Output)
}

type DiskAnomaliesV2MapOutput struct{ *pulumi.OutputState }

func (DiskAnomaliesV2MapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DiskAnomaliesV2)(nil)).Elem()
}

func (o DiskAnomaliesV2MapOutput) ToDiskAnomaliesV2MapOutput() DiskAnomaliesV2MapOutput {
	return o
}

func (o DiskAnomaliesV2MapOutput) ToDiskAnomaliesV2MapOutputWithContext(ctx context.Context) DiskAnomaliesV2MapOutput {
	return o
}

func (o DiskAnomaliesV2MapOutput) MapIndex(k pulumi.StringInput) DiskAnomaliesV2Output {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *DiskAnomaliesV2 {
		return vs[0].(map[string]*DiskAnomaliesV2)[vs[1].(string)]
	}).(DiskAnomaliesV2Output)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*DiskAnomaliesV2Input)(nil)).Elem(), &DiskAnomaliesV2{})
	pulumi.RegisterInputType(reflect.TypeOf((*DiskAnomaliesV2ArrayInput)(nil)).Elem(), DiskAnomaliesV2Array{})
	pulumi.RegisterInputType(reflect.TypeOf((*DiskAnomaliesV2MapInput)(nil)).Elem(), DiskAnomaliesV2Map{})
	pulumi.RegisterOutputType(DiskAnomaliesV2Output{})
	pulumi.RegisterOutputType(DiskAnomaliesV2ArrayOutput{})
	pulumi.RegisterOutputType(DiskAnomaliesV2MapOutput{})
}