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

type LogTimestamp struct {
	pulumi.CustomResourceState

	// Name
	ConfigItemTitle pulumi.StringOutput `pulumi:"configItemTitle"`
	// (v1.275) Defines the number of characters in every log line (starting from the first character in the line) where the timestamp is searched.
	DateSearchLimit pulumi.IntPtrOutput `pulumi:"dateSearchLimit"`
	// Date-time pattern
	DateTimePattern pulumi.StringOutput `pulumi:"dateTimePattern"`
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolOutput `pulumi:"enabled"`
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter pulumi.StringOutput `pulumi:"insertAfter"`
	// no documentation available
	Matchers LogTimestampMatchersPtrOutput `pulumi:"matchers"`
	// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
	Scope pulumi.StringPtrOutput `pulumi:"scope"`
	// Timezone
	Timezone pulumi.StringOutput `pulumi:"timezone"`
}

// NewLogTimestamp registers a new resource with the given unique name, arguments, and options.
func NewLogTimestamp(ctx *pulumi.Context,
	name string, args *LogTimestampArgs, opts ...pulumi.ResourceOption) (*LogTimestamp, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ConfigItemTitle == nil {
		return nil, errors.New("invalid value for required argument 'ConfigItemTitle'")
	}
	if args.DateTimePattern == nil {
		return nil, errors.New("invalid value for required argument 'DateTimePattern'")
	}
	if args.Enabled == nil {
		return nil, errors.New("invalid value for required argument 'Enabled'")
	}
	if args.Timezone == nil {
		return nil, errors.New("invalid value for required argument 'Timezone'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource LogTimestamp
	err := ctx.RegisterResource("dynatrace:index/logTimestamp:LogTimestamp", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetLogTimestamp gets an existing LogTimestamp resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetLogTimestamp(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *LogTimestampState, opts ...pulumi.ResourceOption) (*LogTimestamp, error) {
	var resource LogTimestamp
	err := ctx.ReadResource("dynatrace:index/logTimestamp:LogTimestamp", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering LogTimestamp resources.
type logTimestampState struct {
	// Name
	ConfigItemTitle *string `pulumi:"configItemTitle"`
	// (v1.275) Defines the number of characters in every log line (starting from the first character in the line) where the timestamp is searched.
	DateSearchLimit *int `pulumi:"dateSearchLimit"`
	// Date-time pattern
	DateTimePattern *string `pulumi:"dateTimePattern"`
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled *bool `pulumi:"enabled"`
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter *string `pulumi:"insertAfter"`
	// no documentation available
	Matchers *LogTimestampMatchers `pulumi:"matchers"`
	// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
	Scope *string `pulumi:"scope"`
	// Timezone
	Timezone *string `pulumi:"timezone"`
}

type LogTimestampState struct {
	// Name
	ConfigItemTitle pulumi.StringPtrInput
	// (v1.275) Defines the number of characters in every log line (starting from the first character in the line) where the timestamp is searched.
	DateSearchLimit pulumi.IntPtrInput
	// Date-time pattern
	DateTimePattern pulumi.StringPtrInput
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolPtrInput
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter pulumi.StringPtrInput
	// no documentation available
	Matchers LogTimestampMatchersPtrInput
	// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
	Scope pulumi.StringPtrInput
	// Timezone
	Timezone pulumi.StringPtrInput
}

func (LogTimestampState) ElementType() reflect.Type {
	return reflect.TypeOf((*logTimestampState)(nil)).Elem()
}

type logTimestampArgs struct {
	// Name
	ConfigItemTitle string `pulumi:"configItemTitle"`
	// (v1.275) Defines the number of characters in every log line (starting from the first character in the line) where the timestamp is searched.
	DateSearchLimit *int `pulumi:"dateSearchLimit"`
	// Date-time pattern
	DateTimePattern string `pulumi:"dateTimePattern"`
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled bool `pulumi:"enabled"`
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter *string `pulumi:"insertAfter"`
	// no documentation available
	Matchers *LogTimestampMatchers `pulumi:"matchers"`
	// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
	Scope *string `pulumi:"scope"`
	// Timezone
	Timezone string `pulumi:"timezone"`
}

// The set of arguments for constructing a LogTimestamp resource.
type LogTimestampArgs struct {
	// Name
	ConfigItemTitle pulumi.StringInput
	// (v1.275) Defines the number of characters in every log line (starting from the first character in the line) where the timestamp is searched.
	DateSearchLimit pulumi.IntPtrInput
	// Date-time pattern
	DateTimePattern pulumi.StringInput
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolInput
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter pulumi.StringPtrInput
	// no documentation available
	Matchers LogTimestampMatchersPtrInput
	// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
	Scope pulumi.StringPtrInput
	// Timezone
	Timezone pulumi.StringInput
}

func (LogTimestampArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*logTimestampArgs)(nil)).Elem()
}

type LogTimestampInput interface {
	pulumi.Input

	ToLogTimestampOutput() LogTimestampOutput
	ToLogTimestampOutputWithContext(ctx context.Context) LogTimestampOutput
}

func (*LogTimestamp) ElementType() reflect.Type {
	return reflect.TypeOf((**LogTimestamp)(nil)).Elem()
}

func (i *LogTimestamp) ToLogTimestampOutput() LogTimestampOutput {
	return i.ToLogTimestampOutputWithContext(context.Background())
}

func (i *LogTimestamp) ToLogTimestampOutputWithContext(ctx context.Context) LogTimestampOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LogTimestampOutput)
}

// LogTimestampArrayInput is an input type that accepts LogTimestampArray and LogTimestampArrayOutput values.
// You can construct a concrete instance of `LogTimestampArrayInput` via:
//
//	LogTimestampArray{ LogTimestampArgs{...} }
type LogTimestampArrayInput interface {
	pulumi.Input

	ToLogTimestampArrayOutput() LogTimestampArrayOutput
	ToLogTimestampArrayOutputWithContext(context.Context) LogTimestampArrayOutput
}

type LogTimestampArray []LogTimestampInput

func (LogTimestampArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*LogTimestamp)(nil)).Elem()
}

func (i LogTimestampArray) ToLogTimestampArrayOutput() LogTimestampArrayOutput {
	return i.ToLogTimestampArrayOutputWithContext(context.Background())
}

func (i LogTimestampArray) ToLogTimestampArrayOutputWithContext(ctx context.Context) LogTimestampArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LogTimestampArrayOutput)
}

// LogTimestampMapInput is an input type that accepts LogTimestampMap and LogTimestampMapOutput values.
// You can construct a concrete instance of `LogTimestampMapInput` via:
//
//	LogTimestampMap{ "key": LogTimestampArgs{...} }
type LogTimestampMapInput interface {
	pulumi.Input

	ToLogTimestampMapOutput() LogTimestampMapOutput
	ToLogTimestampMapOutputWithContext(context.Context) LogTimestampMapOutput
}

type LogTimestampMap map[string]LogTimestampInput

func (LogTimestampMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*LogTimestamp)(nil)).Elem()
}

func (i LogTimestampMap) ToLogTimestampMapOutput() LogTimestampMapOutput {
	return i.ToLogTimestampMapOutputWithContext(context.Background())
}

func (i LogTimestampMap) ToLogTimestampMapOutputWithContext(ctx context.Context) LogTimestampMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LogTimestampMapOutput)
}

type LogTimestampOutput struct{ *pulumi.OutputState }

func (LogTimestampOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**LogTimestamp)(nil)).Elem()
}

func (o LogTimestampOutput) ToLogTimestampOutput() LogTimestampOutput {
	return o
}

func (o LogTimestampOutput) ToLogTimestampOutputWithContext(ctx context.Context) LogTimestampOutput {
	return o
}

// Name
func (o LogTimestampOutput) ConfigItemTitle() pulumi.StringOutput {
	return o.ApplyT(func(v *LogTimestamp) pulumi.StringOutput { return v.ConfigItemTitle }).(pulumi.StringOutput)
}

// (v1.275) Defines the number of characters in every log line (starting from the first character in the line) where the timestamp is searched.
func (o LogTimestampOutput) DateSearchLimit() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *LogTimestamp) pulumi.IntPtrOutput { return v.DateSearchLimit }).(pulumi.IntPtrOutput)
}

// Date-time pattern
func (o LogTimestampOutput) DateTimePattern() pulumi.StringOutput {
	return o.ApplyT(func(v *LogTimestamp) pulumi.StringOutput { return v.DateTimePattern }).(pulumi.StringOutput)
}

// This setting is enabled (`true`) or disabled (`false`)
func (o LogTimestampOutput) Enabled() pulumi.BoolOutput {
	return o.ApplyT(func(v *LogTimestamp) pulumi.BoolOutput { return v.Enabled }).(pulumi.BoolOutput)
}

// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
func (o LogTimestampOutput) InsertAfter() pulumi.StringOutput {
	return o.ApplyT(func(v *LogTimestamp) pulumi.StringOutput { return v.InsertAfter }).(pulumi.StringOutput)
}

// no documentation available
func (o LogTimestampOutput) Matchers() LogTimestampMatchersPtrOutput {
	return o.ApplyT(func(v *LogTimestamp) LogTimestampMatchersPtrOutput { return v.Matchers }).(LogTimestampMatchersPtrOutput)
}

// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
func (o LogTimestampOutput) Scope() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *LogTimestamp) pulumi.StringPtrOutput { return v.Scope }).(pulumi.StringPtrOutput)
}

// Timezone
func (o LogTimestampOutput) Timezone() pulumi.StringOutput {
	return o.ApplyT(func(v *LogTimestamp) pulumi.StringOutput { return v.Timezone }).(pulumi.StringOutput)
}

type LogTimestampArrayOutput struct{ *pulumi.OutputState }

func (LogTimestampArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*LogTimestamp)(nil)).Elem()
}

func (o LogTimestampArrayOutput) ToLogTimestampArrayOutput() LogTimestampArrayOutput {
	return o
}

func (o LogTimestampArrayOutput) ToLogTimestampArrayOutputWithContext(ctx context.Context) LogTimestampArrayOutput {
	return o
}

func (o LogTimestampArrayOutput) Index(i pulumi.IntInput) LogTimestampOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *LogTimestamp {
		return vs[0].([]*LogTimestamp)[vs[1].(int)]
	}).(LogTimestampOutput)
}

type LogTimestampMapOutput struct{ *pulumi.OutputState }

func (LogTimestampMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*LogTimestamp)(nil)).Elem()
}

func (o LogTimestampMapOutput) ToLogTimestampMapOutput() LogTimestampMapOutput {
	return o
}

func (o LogTimestampMapOutput) ToLogTimestampMapOutputWithContext(ctx context.Context) LogTimestampMapOutput {
	return o
}

func (o LogTimestampMapOutput) MapIndex(k pulumi.StringInput) LogTimestampOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *LogTimestamp {
		return vs[0].(map[string]*LogTimestamp)[vs[1].(string)]
	}).(LogTimestampOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*LogTimestampInput)(nil)).Elem(), &LogTimestamp{})
	pulumi.RegisterInputType(reflect.TypeOf((*LogTimestampArrayInput)(nil)).Elem(), LogTimestampArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*LogTimestampMapInput)(nil)).Elem(), LogTimestampMap{})
	pulumi.RegisterOutputType(LogTimestampOutput{})
	pulumi.RegisterOutputType(LogTimestampArrayOutput{})
	pulumi.RegisterOutputType(LogTimestampMapOutput{})
}
