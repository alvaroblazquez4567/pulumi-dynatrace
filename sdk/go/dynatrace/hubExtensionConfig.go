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

type HubExtensionConfig struct {
	pulumi.CustomResourceState

	// The name of the Active Gate Group this monitoring configuration will be defined for
	ActiveGateGroup pulumi.StringPtrOutput `pulumi:"activeGateGroup"`
	// The ID of the host this monitoring configuration will be defined for
	Host pulumi.StringPtrOutput `pulumi:"host"`
	// The ID of the host group this monitoring configuration will be defined for
	HostGroup pulumi.StringPtrOutput `pulumi:"hostGroup"`
	// The name of the Management Zone this monitoring configuration will be defined for
	ManagementZone pulumi.StringPtrOutput `pulumi:"managementZone"`
	// The fully qualified name of the extension, such as `com.dynatrace.extension.jmx-liberty-cp`. You can query for these names using the data source `getHubItems`
	Name pulumi.StringOutput `pulumi:"name"`
	// The JSON encoded value for this monitoring configuration
	Value pulumi.StringOutput `pulumi:"value"`
}

// NewHubExtensionConfig registers a new resource with the given unique name, arguments, and options.
func NewHubExtensionConfig(ctx *pulumi.Context,
	name string, args *HubExtensionConfigArgs, opts ...pulumi.ResourceOption) (*HubExtensionConfig, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Value == nil {
		return nil, errors.New("invalid value for required argument 'Value'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource HubExtensionConfig
	err := ctx.RegisterResource("dynatrace:index/hubExtensionConfig:HubExtensionConfig", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetHubExtensionConfig gets an existing HubExtensionConfig resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetHubExtensionConfig(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *HubExtensionConfigState, opts ...pulumi.ResourceOption) (*HubExtensionConfig, error) {
	var resource HubExtensionConfig
	err := ctx.ReadResource("dynatrace:index/hubExtensionConfig:HubExtensionConfig", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering HubExtensionConfig resources.
type hubExtensionConfigState struct {
	// The name of the Active Gate Group this monitoring configuration will be defined for
	ActiveGateGroup *string `pulumi:"activeGateGroup"`
	// The ID of the host this monitoring configuration will be defined for
	Host *string `pulumi:"host"`
	// The ID of the host group this monitoring configuration will be defined for
	HostGroup *string `pulumi:"hostGroup"`
	// The name of the Management Zone this monitoring configuration will be defined for
	ManagementZone *string `pulumi:"managementZone"`
	// The fully qualified name of the extension, such as `com.dynatrace.extension.jmx-liberty-cp`. You can query for these names using the data source `getHubItems`
	Name *string `pulumi:"name"`
	// The JSON encoded value for this monitoring configuration
	Value *string `pulumi:"value"`
}

type HubExtensionConfigState struct {
	// The name of the Active Gate Group this monitoring configuration will be defined for
	ActiveGateGroup pulumi.StringPtrInput
	// The ID of the host this monitoring configuration will be defined for
	Host pulumi.StringPtrInput
	// The ID of the host group this monitoring configuration will be defined for
	HostGroup pulumi.StringPtrInput
	// The name of the Management Zone this monitoring configuration will be defined for
	ManagementZone pulumi.StringPtrInput
	// The fully qualified name of the extension, such as `com.dynatrace.extension.jmx-liberty-cp`. You can query for these names using the data source `getHubItems`
	Name pulumi.StringPtrInput
	// The JSON encoded value for this monitoring configuration
	Value pulumi.StringPtrInput
}

func (HubExtensionConfigState) ElementType() reflect.Type {
	return reflect.TypeOf((*hubExtensionConfigState)(nil)).Elem()
}

type hubExtensionConfigArgs struct {
	// The name of the Active Gate Group this monitoring configuration will be defined for
	ActiveGateGroup *string `pulumi:"activeGateGroup"`
	// The ID of the host this monitoring configuration will be defined for
	Host *string `pulumi:"host"`
	// The ID of the host group this monitoring configuration will be defined for
	HostGroup *string `pulumi:"hostGroup"`
	// The name of the Management Zone this monitoring configuration will be defined for
	ManagementZone *string `pulumi:"managementZone"`
	// The fully qualified name of the extension, such as `com.dynatrace.extension.jmx-liberty-cp`. You can query for these names using the data source `getHubItems`
	Name *string `pulumi:"name"`
	// The JSON encoded value for this monitoring configuration
	Value string `pulumi:"value"`
}

// The set of arguments for constructing a HubExtensionConfig resource.
type HubExtensionConfigArgs struct {
	// The name of the Active Gate Group this monitoring configuration will be defined for
	ActiveGateGroup pulumi.StringPtrInput
	// The ID of the host this monitoring configuration will be defined for
	Host pulumi.StringPtrInput
	// The ID of the host group this monitoring configuration will be defined for
	HostGroup pulumi.StringPtrInput
	// The name of the Management Zone this monitoring configuration will be defined for
	ManagementZone pulumi.StringPtrInput
	// The fully qualified name of the extension, such as `com.dynatrace.extension.jmx-liberty-cp`. You can query for these names using the data source `getHubItems`
	Name pulumi.StringPtrInput
	// The JSON encoded value for this monitoring configuration
	Value pulumi.StringInput
}

func (HubExtensionConfigArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*hubExtensionConfigArgs)(nil)).Elem()
}

type HubExtensionConfigInput interface {
	pulumi.Input

	ToHubExtensionConfigOutput() HubExtensionConfigOutput
	ToHubExtensionConfigOutputWithContext(ctx context.Context) HubExtensionConfigOutput
}

func (*HubExtensionConfig) ElementType() reflect.Type {
	return reflect.TypeOf((**HubExtensionConfig)(nil)).Elem()
}

func (i *HubExtensionConfig) ToHubExtensionConfigOutput() HubExtensionConfigOutput {
	return i.ToHubExtensionConfigOutputWithContext(context.Background())
}

func (i *HubExtensionConfig) ToHubExtensionConfigOutputWithContext(ctx context.Context) HubExtensionConfigOutput {
	return pulumi.ToOutputWithContext(ctx, i).(HubExtensionConfigOutput)
}

// HubExtensionConfigArrayInput is an input type that accepts HubExtensionConfigArray and HubExtensionConfigArrayOutput values.
// You can construct a concrete instance of `HubExtensionConfigArrayInput` via:
//
//	HubExtensionConfigArray{ HubExtensionConfigArgs{...} }
type HubExtensionConfigArrayInput interface {
	pulumi.Input

	ToHubExtensionConfigArrayOutput() HubExtensionConfigArrayOutput
	ToHubExtensionConfigArrayOutputWithContext(context.Context) HubExtensionConfigArrayOutput
}

type HubExtensionConfigArray []HubExtensionConfigInput

func (HubExtensionConfigArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*HubExtensionConfig)(nil)).Elem()
}

func (i HubExtensionConfigArray) ToHubExtensionConfigArrayOutput() HubExtensionConfigArrayOutput {
	return i.ToHubExtensionConfigArrayOutputWithContext(context.Background())
}

func (i HubExtensionConfigArray) ToHubExtensionConfigArrayOutputWithContext(ctx context.Context) HubExtensionConfigArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(HubExtensionConfigArrayOutput)
}

// HubExtensionConfigMapInput is an input type that accepts HubExtensionConfigMap and HubExtensionConfigMapOutput values.
// You can construct a concrete instance of `HubExtensionConfigMapInput` via:
//
//	HubExtensionConfigMap{ "key": HubExtensionConfigArgs{...} }
type HubExtensionConfigMapInput interface {
	pulumi.Input

	ToHubExtensionConfigMapOutput() HubExtensionConfigMapOutput
	ToHubExtensionConfigMapOutputWithContext(context.Context) HubExtensionConfigMapOutput
}

type HubExtensionConfigMap map[string]HubExtensionConfigInput

func (HubExtensionConfigMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*HubExtensionConfig)(nil)).Elem()
}

func (i HubExtensionConfigMap) ToHubExtensionConfigMapOutput() HubExtensionConfigMapOutput {
	return i.ToHubExtensionConfigMapOutputWithContext(context.Background())
}

func (i HubExtensionConfigMap) ToHubExtensionConfigMapOutputWithContext(ctx context.Context) HubExtensionConfigMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(HubExtensionConfigMapOutput)
}

type HubExtensionConfigOutput struct{ *pulumi.OutputState }

func (HubExtensionConfigOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**HubExtensionConfig)(nil)).Elem()
}

func (o HubExtensionConfigOutput) ToHubExtensionConfigOutput() HubExtensionConfigOutput {
	return o
}

func (o HubExtensionConfigOutput) ToHubExtensionConfigOutputWithContext(ctx context.Context) HubExtensionConfigOutput {
	return o
}

// The name of the Active Gate Group this monitoring configuration will be defined for
func (o HubExtensionConfigOutput) ActiveGateGroup() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *HubExtensionConfig) pulumi.StringPtrOutput { return v.ActiveGateGroup }).(pulumi.StringPtrOutput)
}

// The ID of the host this monitoring configuration will be defined for
func (o HubExtensionConfigOutput) Host() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *HubExtensionConfig) pulumi.StringPtrOutput { return v.Host }).(pulumi.StringPtrOutput)
}

// The ID of the host group this monitoring configuration will be defined for
func (o HubExtensionConfigOutput) HostGroup() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *HubExtensionConfig) pulumi.StringPtrOutput { return v.HostGroup }).(pulumi.StringPtrOutput)
}

// The name of the Management Zone this monitoring configuration will be defined for
func (o HubExtensionConfigOutput) ManagementZone() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *HubExtensionConfig) pulumi.StringPtrOutput { return v.ManagementZone }).(pulumi.StringPtrOutput)
}

// The fully qualified name of the extension, such as `com.dynatrace.extension.jmx-liberty-cp`. You can query for these names using the data source `getHubItems`
func (o HubExtensionConfigOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *HubExtensionConfig) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// The JSON encoded value for this monitoring configuration
func (o HubExtensionConfigOutput) Value() pulumi.StringOutput {
	return o.ApplyT(func(v *HubExtensionConfig) pulumi.StringOutput { return v.Value }).(pulumi.StringOutput)
}

type HubExtensionConfigArrayOutput struct{ *pulumi.OutputState }

func (HubExtensionConfigArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*HubExtensionConfig)(nil)).Elem()
}

func (o HubExtensionConfigArrayOutput) ToHubExtensionConfigArrayOutput() HubExtensionConfigArrayOutput {
	return o
}

func (o HubExtensionConfigArrayOutput) ToHubExtensionConfigArrayOutputWithContext(ctx context.Context) HubExtensionConfigArrayOutput {
	return o
}

func (o HubExtensionConfigArrayOutput) Index(i pulumi.IntInput) HubExtensionConfigOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *HubExtensionConfig {
		return vs[0].([]*HubExtensionConfig)[vs[1].(int)]
	}).(HubExtensionConfigOutput)
}

type HubExtensionConfigMapOutput struct{ *pulumi.OutputState }

func (HubExtensionConfigMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*HubExtensionConfig)(nil)).Elem()
}

func (o HubExtensionConfigMapOutput) ToHubExtensionConfigMapOutput() HubExtensionConfigMapOutput {
	return o
}

func (o HubExtensionConfigMapOutput) ToHubExtensionConfigMapOutputWithContext(ctx context.Context) HubExtensionConfigMapOutput {
	return o
}

func (o HubExtensionConfigMapOutput) MapIndex(k pulumi.StringInput) HubExtensionConfigOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *HubExtensionConfig {
		return vs[0].(map[string]*HubExtensionConfig)[vs[1].(string)]
	}).(HubExtensionConfigOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*HubExtensionConfigInput)(nil)).Elem(), &HubExtensionConfig{})
	pulumi.RegisterInputType(reflect.TypeOf((*HubExtensionConfigArrayInput)(nil)).Elem(), HubExtensionConfigArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*HubExtensionConfigMapInput)(nil)).Elem(), HubExtensionConfigMap{})
	pulumi.RegisterOutputType(HubExtensionConfigOutput{})
	pulumi.RegisterOutputType(HubExtensionConfigArrayOutput{})
	pulumi.RegisterOutputType(HubExtensionConfigMapOutput{})
}
