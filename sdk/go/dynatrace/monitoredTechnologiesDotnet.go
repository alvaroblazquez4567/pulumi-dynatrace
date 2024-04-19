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

type MonitoredTechnologiesDotnet struct {
	pulumi.CustomResourceState

	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolOutput `pulumi:"enabled"`
	// Requires Dynatrace OneAgent version 1.117 or later on Windows and version 1.127 or later on Linux and .NET monitoring enabled
	EnabledDotNetCore pulumi.BoolPtrOutput `pulumi:"enabledDotNetCore"`
	// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
	HostId pulumi.StringPtrOutput `pulumi:"hostId"`
}

// NewMonitoredTechnologiesDotnet registers a new resource with the given unique name, arguments, and options.
func NewMonitoredTechnologiesDotnet(ctx *pulumi.Context,
	name string, args *MonitoredTechnologiesDotnetArgs, opts ...pulumi.ResourceOption) (*MonitoredTechnologiesDotnet, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Enabled == nil {
		return nil, errors.New("invalid value for required argument 'Enabled'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource MonitoredTechnologiesDotnet
	err := ctx.RegisterResource("dynatrace:index/monitoredTechnologiesDotnet:MonitoredTechnologiesDotnet", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMonitoredTechnologiesDotnet gets an existing MonitoredTechnologiesDotnet resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMonitoredTechnologiesDotnet(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MonitoredTechnologiesDotnetState, opts ...pulumi.ResourceOption) (*MonitoredTechnologiesDotnet, error) {
	var resource MonitoredTechnologiesDotnet
	err := ctx.ReadResource("dynatrace:index/monitoredTechnologiesDotnet:MonitoredTechnologiesDotnet", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering MonitoredTechnologiesDotnet resources.
type monitoredTechnologiesDotnetState struct {
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled *bool `pulumi:"enabled"`
	// Requires Dynatrace OneAgent version 1.117 or later on Windows and version 1.127 or later on Linux and .NET monitoring enabled
	EnabledDotNetCore *bool `pulumi:"enabledDotNetCore"`
	// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
	HostId *string `pulumi:"hostId"`
}

type MonitoredTechnologiesDotnetState struct {
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolPtrInput
	// Requires Dynatrace OneAgent version 1.117 or later on Windows and version 1.127 or later on Linux and .NET monitoring enabled
	EnabledDotNetCore pulumi.BoolPtrInput
	// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
	HostId pulumi.StringPtrInput
}

func (MonitoredTechnologiesDotnetState) ElementType() reflect.Type {
	return reflect.TypeOf((*monitoredTechnologiesDotnetState)(nil)).Elem()
}

type monitoredTechnologiesDotnetArgs struct {
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled bool `pulumi:"enabled"`
	// Requires Dynatrace OneAgent version 1.117 or later on Windows and version 1.127 or later on Linux and .NET monitoring enabled
	EnabledDotNetCore *bool `pulumi:"enabledDotNetCore"`
	// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
	HostId *string `pulumi:"hostId"`
}

// The set of arguments for constructing a MonitoredTechnologiesDotnet resource.
type MonitoredTechnologiesDotnetArgs struct {
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolInput
	// Requires Dynatrace OneAgent version 1.117 or later on Windows and version 1.127 or later on Linux and .NET monitoring enabled
	EnabledDotNetCore pulumi.BoolPtrInput
	// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
	HostId pulumi.StringPtrInput
}

func (MonitoredTechnologiesDotnetArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*monitoredTechnologiesDotnetArgs)(nil)).Elem()
}

type MonitoredTechnologiesDotnetInput interface {
	pulumi.Input

	ToMonitoredTechnologiesDotnetOutput() MonitoredTechnologiesDotnetOutput
	ToMonitoredTechnologiesDotnetOutputWithContext(ctx context.Context) MonitoredTechnologiesDotnetOutput
}

func (*MonitoredTechnologiesDotnet) ElementType() reflect.Type {
	return reflect.TypeOf((**MonitoredTechnologiesDotnet)(nil)).Elem()
}

func (i *MonitoredTechnologiesDotnet) ToMonitoredTechnologiesDotnetOutput() MonitoredTechnologiesDotnetOutput {
	return i.ToMonitoredTechnologiesDotnetOutputWithContext(context.Background())
}

func (i *MonitoredTechnologiesDotnet) ToMonitoredTechnologiesDotnetOutputWithContext(ctx context.Context) MonitoredTechnologiesDotnetOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MonitoredTechnologiesDotnetOutput)
}

// MonitoredTechnologiesDotnetArrayInput is an input type that accepts MonitoredTechnologiesDotnetArray and MonitoredTechnologiesDotnetArrayOutput values.
// You can construct a concrete instance of `MonitoredTechnologiesDotnetArrayInput` via:
//
//	MonitoredTechnologiesDotnetArray{ MonitoredTechnologiesDotnetArgs{...} }
type MonitoredTechnologiesDotnetArrayInput interface {
	pulumi.Input

	ToMonitoredTechnologiesDotnetArrayOutput() MonitoredTechnologiesDotnetArrayOutput
	ToMonitoredTechnologiesDotnetArrayOutputWithContext(context.Context) MonitoredTechnologiesDotnetArrayOutput
}

type MonitoredTechnologiesDotnetArray []MonitoredTechnologiesDotnetInput

func (MonitoredTechnologiesDotnetArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*MonitoredTechnologiesDotnet)(nil)).Elem()
}

func (i MonitoredTechnologiesDotnetArray) ToMonitoredTechnologiesDotnetArrayOutput() MonitoredTechnologiesDotnetArrayOutput {
	return i.ToMonitoredTechnologiesDotnetArrayOutputWithContext(context.Background())
}

func (i MonitoredTechnologiesDotnetArray) ToMonitoredTechnologiesDotnetArrayOutputWithContext(ctx context.Context) MonitoredTechnologiesDotnetArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MonitoredTechnologiesDotnetArrayOutput)
}

// MonitoredTechnologiesDotnetMapInput is an input type that accepts MonitoredTechnologiesDotnetMap and MonitoredTechnologiesDotnetMapOutput values.
// You can construct a concrete instance of `MonitoredTechnologiesDotnetMapInput` via:
//
//	MonitoredTechnologiesDotnetMap{ "key": MonitoredTechnologiesDotnetArgs{...} }
type MonitoredTechnologiesDotnetMapInput interface {
	pulumi.Input

	ToMonitoredTechnologiesDotnetMapOutput() MonitoredTechnologiesDotnetMapOutput
	ToMonitoredTechnologiesDotnetMapOutputWithContext(context.Context) MonitoredTechnologiesDotnetMapOutput
}

type MonitoredTechnologiesDotnetMap map[string]MonitoredTechnologiesDotnetInput

func (MonitoredTechnologiesDotnetMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*MonitoredTechnologiesDotnet)(nil)).Elem()
}

func (i MonitoredTechnologiesDotnetMap) ToMonitoredTechnologiesDotnetMapOutput() MonitoredTechnologiesDotnetMapOutput {
	return i.ToMonitoredTechnologiesDotnetMapOutputWithContext(context.Background())
}

func (i MonitoredTechnologiesDotnetMap) ToMonitoredTechnologiesDotnetMapOutputWithContext(ctx context.Context) MonitoredTechnologiesDotnetMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MonitoredTechnologiesDotnetMapOutput)
}

type MonitoredTechnologiesDotnetOutput struct{ *pulumi.OutputState }

func (MonitoredTechnologiesDotnetOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**MonitoredTechnologiesDotnet)(nil)).Elem()
}

func (o MonitoredTechnologiesDotnetOutput) ToMonitoredTechnologiesDotnetOutput() MonitoredTechnologiesDotnetOutput {
	return o
}

func (o MonitoredTechnologiesDotnetOutput) ToMonitoredTechnologiesDotnetOutputWithContext(ctx context.Context) MonitoredTechnologiesDotnetOutput {
	return o
}

// This setting is enabled (`true`) or disabled (`false`)
func (o MonitoredTechnologiesDotnetOutput) Enabled() pulumi.BoolOutput {
	return o.ApplyT(func(v *MonitoredTechnologiesDotnet) pulumi.BoolOutput { return v.Enabled }).(pulumi.BoolOutput)
}

// Requires Dynatrace OneAgent version 1.117 or later on Windows and version 1.127 or later on Linux and .NET monitoring enabled
func (o MonitoredTechnologiesDotnetOutput) EnabledDotNetCore() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *MonitoredTechnologiesDotnet) pulumi.BoolPtrOutput { return v.EnabledDotNetCore }).(pulumi.BoolPtrOutput)
}

// The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
func (o MonitoredTechnologiesDotnetOutput) HostId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *MonitoredTechnologiesDotnet) pulumi.StringPtrOutput { return v.HostId }).(pulumi.StringPtrOutput)
}

type MonitoredTechnologiesDotnetArrayOutput struct{ *pulumi.OutputState }

func (MonitoredTechnologiesDotnetArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*MonitoredTechnologiesDotnet)(nil)).Elem()
}

func (o MonitoredTechnologiesDotnetArrayOutput) ToMonitoredTechnologiesDotnetArrayOutput() MonitoredTechnologiesDotnetArrayOutput {
	return o
}

func (o MonitoredTechnologiesDotnetArrayOutput) ToMonitoredTechnologiesDotnetArrayOutputWithContext(ctx context.Context) MonitoredTechnologiesDotnetArrayOutput {
	return o
}

func (o MonitoredTechnologiesDotnetArrayOutput) Index(i pulumi.IntInput) MonitoredTechnologiesDotnetOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *MonitoredTechnologiesDotnet {
		return vs[0].([]*MonitoredTechnologiesDotnet)[vs[1].(int)]
	}).(MonitoredTechnologiesDotnetOutput)
}

type MonitoredTechnologiesDotnetMapOutput struct{ *pulumi.OutputState }

func (MonitoredTechnologiesDotnetMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*MonitoredTechnologiesDotnet)(nil)).Elem()
}

func (o MonitoredTechnologiesDotnetMapOutput) ToMonitoredTechnologiesDotnetMapOutput() MonitoredTechnologiesDotnetMapOutput {
	return o
}

func (o MonitoredTechnologiesDotnetMapOutput) ToMonitoredTechnologiesDotnetMapOutputWithContext(ctx context.Context) MonitoredTechnologiesDotnetMapOutput {
	return o
}

func (o MonitoredTechnologiesDotnetMapOutput) MapIndex(k pulumi.StringInput) MonitoredTechnologiesDotnetOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *MonitoredTechnologiesDotnet {
		return vs[0].(map[string]*MonitoredTechnologiesDotnet)[vs[1].(string)]
	}).(MonitoredTechnologiesDotnetOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*MonitoredTechnologiesDotnetInput)(nil)).Elem(), &MonitoredTechnologiesDotnet{})
	pulumi.RegisterInputType(reflect.TypeOf((*MonitoredTechnologiesDotnetArrayInput)(nil)).Elem(), MonitoredTechnologiesDotnetArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*MonitoredTechnologiesDotnetMapInput)(nil)).Elem(), MonitoredTechnologiesDotnetMap{})
	pulumi.RegisterOutputType(MonitoredTechnologiesDotnetOutput{})
	pulumi.RegisterOutputType(MonitoredTechnologiesDotnetArrayOutput{})
	pulumi.RegisterOutputType(MonitoredTechnologiesDotnetMapOutput{})
}