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

type GenericSetting struct {
	pulumi.CustomResourceState

	LocalStorage pulumi.StringOutput `pulumi:"localStorage"`
	Schema       pulumi.StringOutput `pulumi:"schema"`
	Scope        pulumi.StringOutput `pulumi:"scope"`
	Value        pulumi.StringOutput `pulumi:"value"`
}

// NewGenericSetting registers a new resource with the given unique name, arguments, and options.
func NewGenericSetting(ctx *pulumi.Context,
	name string, args *GenericSettingArgs, opts ...pulumi.ResourceOption) (*GenericSetting, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Schema == nil {
		return nil, errors.New("invalid value for required argument 'Schema'")
	}
	if args.Value == nil {
		return nil, errors.New("invalid value for required argument 'Value'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource GenericSetting
	err := ctx.RegisterResource("dynatrace:index/genericSetting:GenericSetting", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetGenericSetting gets an existing GenericSetting resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetGenericSetting(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *GenericSettingState, opts ...pulumi.ResourceOption) (*GenericSetting, error) {
	var resource GenericSetting
	err := ctx.ReadResource("dynatrace:index/genericSetting:GenericSetting", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering GenericSetting resources.
type genericSettingState struct {
	LocalStorage *string `pulumi:"localStorage"`
	Schema       *string `pulumi:"schema"`
	Scope        *string `pulumi:"scope"`
	Value        *string `pulumi:"value"`
}

type GenericSettingState struct {
	LocalStorage pulumi.StringPtrInput
	Schema       pulumi.StringPtrInput
	Scope        pulumi.StringPtrInput
	Value        pulumi.StringPtrInput
}

func (GenericSettingState) ElementType() reflect.Type {
	return reflect.TypeOf((*genericSettingState)(nil)).Elem()
}

type genericSettingArgs struct {
	Schema string  `pulumi:"schema"`
	Scope  *string `pulumi:"scope"`
	Value  string  `pulumi:"value"`
}

// The set of arguments for constructing a GenericSetting resource.
type GenericSettingArgs struct {
	Schema pulumi.StringInput
	Scope  pulumi.StringPtrInput
	Value  pulumi.StringInput
}

func (GenericSettingArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*genericSettingArgs)(nil)).Elem()
}

type GenericSettingInput interface {
	pulumi.Input

	ToGenericSettingOutput() GenericSettingOutput
	ToGenericSettingOutputWithContext(ctx context.Context) GenericSettingOutput
}

func (*GenericSetting) ElementType() reflect.Type {
	return reflect.TypeOf((**GenericSetting)(nil)).Elem()
}

func (i *GenericSetting) ToGenericSettingOutput() GenericSettingOutput {
	return i.ToGenericSettingOutputWithContext(context.Background())
}

func (i *GenericSetting) ToGenericSettingOutputWithContext(ctx context.Context) GenericSettingOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GenericSettingOutput)
}

// GenericSettingArrayInput is an input type that accepts GenericSettingArray and GenericSettingArrayOutput values.
// You can construct a concrete instance of `GenericSettingArrayInput` via:
//
//	GenericSettingArray{ GenericSettingArgs{...} }
type GenericSettingArrayInput interface {
	pulumi.Input

	ToGenericSettingArrayOutput() GenericSettingArrayOutput
	ToGenericSettingArrayOutputWithContext(context.Context) GenericSettingArrayOutput
}

type GenericSettingArray []GenericSettingInput

func (GenericSettingArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*GenericSetting)(nil)).Elem()
}

func (i GenericSettingArray) ToGenericSettingArrayOutput() GenericSettingArrayOutput {
	return i.ToGenericSettingArrayOutputWithContext(context.Background())
}

func (i GenericSettingArray) ToGenericSettingArrayOutputWithContext(ctx context.Context) GenericSettingArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GenericSettingArrayOutput)
}

// GenericSettingMapInput is an input type that accepts GenericSettingMap and GenericSettingMapOutput values.
// You can construct a concrete instance of `GenericSettingMapInput` via:
//
//	GenericSettingMap{ "key": GenericSettingArgs{...} }
type GenericSettingMapInput interface {
	pulumi.Input

	ToGenericSettingMapOutput() GenericSettingMapOutput
	ToGenericSettingMapOutputWithContext(context.Context) GenericSettingMapOutput
}

type GenericSettingMap map[string]GenericSettingInput

func (GenericSettingMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*GenericSetting)(nil)).Elem()
}

func (i GenericSettingMap) ToGenericSettingMapOutput() GenericSettingMapOutput {
	return i.ToGenericSettingMapOutputWithContext(context.Background())
}

func (i GenericSettingMap) ToGenericSettingMapOutputWithContext(ctx context.Context) GenericSettingMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GenericSettingMapOutput)
}

type GenericSettingOutput struct{ *pulumi.OutputState }

func (GenericSettingOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**GenericSetting)(nil)).Elem()
}

func (o GenericSettingOutput) ToGenericSettingOutput() GenericSettingOutput {
	return o
}

func (o GenericSettingOutput) ToGenericSettingOutputWithContext(ctx context.Context) GenericSettingOutput {
	return o
}

func (o GenericSettingOutput) LocalStorage() pulumi.StringOutput {
	return o.ApplyT(func(v *GenericSetting) pulumi.StringOutput { return v.LocalStorage }).(pulumi.StringOutput)
}

func (o GenericSettingOutput) Schema() pulumi.StringOutput {
	return o.ApplyT(func(v *GenericSetting) pulumi.StringOutput { return v.Schema }).(pulumi.StringOutput)
}

func (o GenericSettingOutput) Scope() pulumi.StringOutput {
	return o.ApplyT(func(v *GenericSetting) pulumi.StringOutput { return v.Scope }).(pulumi.StringOutput)
}

func (o GenericSettingOutput) Value() pulumi.StringOutput {
	return o.ApplyT(func(v *GenericSetting) pulumi.StringOutput { return v.Value }).(pulumi.StringOutput)
}

type GenericSettingArrayOutput struct{ *pulumi.OutputState }

func (GenericSettingArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*GenericSetting)(nil)).Elem()
}

func (o GenericSettingArrayOutput) ToGenericSettingArrayOutput() GenericSettingArrayOutput {
	return o
}

func (o GenericSettingArrayOutput) ToGenericSettingArrayOutputWithContext(ctx context.Context) GenericSettingArrayOutput {
	return o
}

func (o GenericSettingArrayOutput) Index(i pulumi.IntInput) GenericSettingOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *GenericSetting {
		return vs[0].([]*GenericSetting)[vs[1].(int)]
	}).(GenericSettingOutput)
}

type GenericSettingMapOutput struct{ *pulumi.OutputState }

func (GenericSettingMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*GenericSetting)(nil)).Elem()
}

func (o GenericSettingMapOutput) ToGenericSettingMapOutput() GenericSettingMapOutput {
	return o
}

func (o GenericSettingMapOutput) ToGenericSettingMapOutputWithContext(ctx context.Context) GenericSettingMapOutput {
	return o
}

func (o GenericSettingMapOutput) MapIndex(k pulumi.StringInput) GenericSettingOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *GenericSetting {
		return vs[0].(map[string]*GenericSetting)[vs[1].(string)]
	}).(GenericSettingOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*GenericSettingInput)(nil)).Elem(), &GenericSetting{})
	pulumi.RegisterInputType(reflect.TypeOf((*GenericSettingArrayInput)(nil)).Elem(), GenericSettingArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*GenericSettingMapInput)(nil)).Elem(), GenericSettingMap{})
	pulumi.RegisterOutputType(GenericSettingOutput{})
	pulumi.RegisterOutputType(GenericSettingArrayOutput{})
	pulumi.RegisterOutputType(GenericSettingMapOutput{})
}