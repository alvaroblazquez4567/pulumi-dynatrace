// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dynatrace

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi-dynatrace/sdk/go/dynatrace/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// > This resource requires the cluster API token scope **Service Provider API** (`ServiceProviderAPI`)
//
// ## Dynatrace Documentation
//
// - Network zones - https://docs.dynatrace.com/docs/manage/network-zones
//
// - Cluster API v2 - https://www.dynatrace.com/support/help/managed-cluster/cluster-api/cluster-api-v2
//
// ## Resource Example Usage
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
//			_, err := dynatrace.NewManagedNetworkZones(ctx, "test", &dynatrace.ManagedNetworkZonesArgs{
//				AlternativeZones: pulumi.StringArray{
//					pulumi.String("alternativeexample"),
//				},
//				Description:  pulumi.String("This is an example network zone"),
//				FallbackMode: pulumi.String("ANY_ACTIVE_GATE"),
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
type ManagedNetworkZones struct {
	pulumi.CustomResourceState

	// A list of alternative network zones.
	AlternativeZones pulumi.StringArrayOutput `pulumi:"alternativeZones"`
	// A short description of the network zone
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The fallback mode of the network zone. Possible values: `ANY_ACTIVE_GATE`, `NONE`, `ONLY_DEFAULT_ZONE`
	FallbackMode pulumi.StringPtrOutput `pulumi:"fallbackMode"`
	// Name of the network zone cannot be modified once created. Dynatrace stores the field in lowercase, allowed characters: alphanumeric, hyphen, underscore, dot
	Name pulumi.StringOutput `pulumi:"name"`
	// The number of ActiveGates in the network zone.
	NumOfConfiguredActivegates pulumi.IntPtrOutput `pulumi:"numOfConfiguredActivegates"`
	// The number of OneAgents that are configured to use the network zone as primary.
	NumOfConfiguredOneagents pulumi.IntPtrOutput `pulumi:"numOfConfiguredOneagents"`
	// The number of OneAgents from other network zones that are using ActiveGates in the network zone.
	NumOfOneagentsFromOtherZones pulumi.IntPtrOutput `pulumi:"numOfOneagentsFromOtherZones"`
	// The number of OneAgents that are using ActiveGates in the network zone.
	NumOfOneagentsUsing pulumi.IntPtrOutput `pulumi:"numOfOneagentsUsing"`
}

// NewManagedNetworkZones registers a new resource with the given unique name, arguments, and options.
func NewManagedNetworkZones(ctx *pulumi.Context,
	name string, args *ManagedNetworkZonesArgs, opts ...pulumi.ResourceOption) (*ManagedNetworkZones, error) {
	if args == nil {
		args = &ManagedNetworkZonesArgs{}
	}

	opts = internal.PkgResourceDefaultOpts(opts)
	var resource ManagedNetworkZones
	err := ctx.RegisterResource("dynatrace:index/managedNetworkZones:ManagedNetworkZones", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetManagedNetworkZones gets an existing ManagedNetworkZones resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetManagedNetworkZones(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ManagedNetworkZonesState, opts ...pulumi.ResourceOption) (*ManagedNetworkZones, error) {
	var resource ManagedNetworkZones
	err := ctx.ReadResource("dynatrace:index/managedNetworkZones:ManagedNetworkZones", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ManagedNetworkZones resources.
type managedNetworkZonesState struct {
	// A list of alternative network zones.
	AlternativeZones []string `pulumi:"alternativeZones"`
	// A short description of the network zone
	Description *string `pulumi:"description"`
	// The fallback mode of the network zone. Possible values: `ANY_ACTIVE_GATE`, `NONE`, `ONLY_DEFAULT_ZONE`
	FallbackMode *string `pulumi:"fallbackMode"`
	// Name of the network zone cannot be modified once created. Dynatrace stores the field in lowercase, allowed characters: alphanumeric, hyphen, underscore, dot
	Name *string `pulumi:"name"`
	// The number of ActiveGates in the network zone.
	NumOfConfiguredActivegates *int `pulumi:"numOfConfiguredActivegates"`
	// The number of OneAgents that are configured to use the network zone as primary.
	NumOfConfiguredOneagents *int `pulumi:"numOfConfiguredOneagents"`
	// The number of OneAgents from other network zones that are using ActiveGates in the network zone.
	NumOfOneagentsFromOtherZones *int `pulumi:"numOfOneagentsFromOtherZones"`
	// The number of OneAgents that are using ActiveGates in the network zone.
	NumOfOneagentsUsing *int `pulumi:"numOfOneagentsUsing"`
}

type ManagedNetworkZonesState struct {
	// A list of alternative network zones.
	AlternativeZones pulumi.StringArrayInput
	// A short description of the network zone
	Description pulumi.StringPtrInput
	// The fallback mode of the network zone. Possible values: `ANY_ACTIVE_GATE`, `NONE`, `ONLY_DEFAULT_ZONE`
	FallbackMode pulumi.StringPtrInput
	// Name of the network zone cannot be modified once created. Dynatrace stores the field in lowercase, allowed characters: alphanumeric, hyphen, underscore, dot
	Name pulumi.StringPtrInput
	// The number of ActiveGates in the network zone.
	NumOfConfiguredActivegates pulumi.IntPtrInput
	// The number of OneAgents that are configured to use the network zone as primary.
	NumOfConfiguredOneagents pulumi.IntPtrInput
	// The number of OneAgents from other network zones that are using ActiveGates in the network zone.
	NumOfOneagentsFromOtherZones pulumi.IntPtrInput
	// The number of OneAgents that are using ActiveGates in the network zone.
	NumOfOneagentsUsing pulumi.IntPtrInput
}

func (ManagedNetworkZonesState) ElementType() reflect.Type {
	return reflect.TypeOf((*managedNetworkZonesState)(nil)).Elem()
}

type managedNetworkZonesArgs struct {
	// A list of alternative network zones.
	AlternativeZones []string `pulumi:"alternativeZones"`
	// A short description of the network zone
	Description *string `pulumi:"description"`
	// The fallback mode of the network zone. Possible values: `ANY_ACTIVE_GATE`, `NONE`, `ONLY_DEFAULT_ZONE`
	FallbackMode *string `pulumi:"fallbackMode"`
	// Name of the network zone cannot be modified once created. Dynatrace stores the field in lowercase, allowed characters: alphanumeric, hyphen, underscore, dot
	Name *string `pulumi:"name"`
	// The number of ActiveGates in the network zone.
	NumOfConfiguredActivegates *int `pulumi:"numOfConfiguredActivegates"`
	// The number of OneAgents that are configured to use the network zone as primary.
	NumOfConfiguredOneagents *int `pulumi:"numOfConfiguredOneagents"`
	// The number of OneAgents from other network zones that are using ActiveGates in the network zone.
	NumOfOneagentsFromOtherZones *int `pulumi:"numOfOneagentsFromOtherZones"`
	// The number of OneAgents that are using ActiveGates in the network zone.
	NumOfOneagentsUsing *int `pulumi:"numOfOneagentsUsing"`
}

// The set of arguments for constructing a ManagedNetworkZones resource.
type ManagedNetworkZonesArgs struct {
	// A list of alternative network zones.
	AlternativeZones pulumi.StringArrayInput
	// A short description of the network zone
	Description pulumi.StringPtrInput
	// The fallback mode of the network zone. Possible values: `ANY_ACTIVE_GATE`, `NONE`, `ONLY_DEFAULT_ZONE`
	FallbackMode pulumi.StringPtrInput
	// Name of the network zone cannot be modified once created. Dynatrace stores the field in lowercase, allowed characters: alphanumeric, hyphen, underscore, dot
	Name pulumi.StringPtrInput
	// The number of ActiveGates in the network zone.
	NumOfConfiguredActivegates pulumi.IntPtrInput
	// The number of OneAgents that are configured to use the network zone as primary.
	NumOfConfiguredOneagents pulumi.IntPtrInput
	// The number of OneAgents from other network zones that are using ActiveGates in the network zone.
	NumOfOneagentsFromOtherZones pulumi.IntPtrInput
	// The number of OneAgents that are using ActiveGates in the network zone.
	NumOfOneagentsUsing pulumi.IntPtrInput
}

func (ManagedNetworkZonesArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*managedNetworkZonesArgs)(nil)).Elem()
}

type ManagedNetworkZonesInput interface {
	pulumi.Input

	ToManagedNetworkZonesOutput() ManagedNetworkZonesOutput
	ToManagedNetworkZonesOutputWithContext(ctx context.Context) ManagedNetworkZonesOutput
}

func (*ManagedNetworkZones) ElementType() reflect.Type {
	return reflect.TypeOf((**ManagedNetworkZones)(nil)).Elem()
}

func (i *ManagedNetworkZones) ToManagedNetworkZonesOutput() ManagedNetworkZonesOutput {
	return i.ToManagedNetworkZonesOutputWithContext(context.Background())
}

func (i *ManagedNetworkZones) ToManagedNetworkZonesOutputWithContext(ctx context.Context) ManagedNetworkZonesOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ManagedNetworkZonesOutput)
}

// ManagedNetworkZonesArrayInput is an input type that accepts ManagedNetworkZonesArray and ManagedNetworkZonesArrayOutput values.
// You can construct a concrete instance of `ManagedNetworkZonesArrayInput` via:
//
//	ManagedNetworkZonesArray{ ManagedNetworkZonesArgs{...} }
type ManagedNetworkZonesArrayInput interface {
	pulumi.Input

	ToManagedNetworkZonesArrayOutput() ManagedNetworkZonesArrayOutput
	ToManagedNetworkZonesArrayOutputWithContext(context.Context) ManagedNetworkZonesArrayOutput
}

type ManagedNetworkZonesArray []ManagedNetworkZonesInput

func (ManagedNetworkZonesArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ManagedNetworkZones)(nil)).Elem()
}

func (i ManagedNetworkZonesArray) ToManagedNetworkZonesArrayOutput() ManagedNetworkZonesArrayOutput {
	return i.ToManagedNetworkZonesArrayOutputWithContext(context.Background())
}

func (i ManagedNetworkZonesArray) ToManagedNetworkZonesArrayOutputWithContext(ctx context.Context) ManagedNetworkZonesArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ManagedNetworkZonesArrayOutput)
}

// ManagedNetworkZonesMapInput is an input type that accepts ManagedNetworkZonesMap and ManagedNetworkZonesMapOutput values.
// You can construct a concrete instance of `ManagedNetworkZonesMapInput` via:
//
//	ManagedNetworkZonesMap{ "key": ManagedNetworkZonesArgs{...} }
type ManagedNetworkZonesMapInput interface {
	pulumi.Input

	ToManagedNetworkZonesMapOutput() ManagedNetworkZonesMapOutput
	ToManagedNetworkZonesMapOutputWithContext(context.Context) ManagedNetworkZonesMapOutput
}

type ManagedNetworkZonesMap map[string]ManagedNetworkZonesInput

func (ManagedNetworkZonesMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ManagedNetworkZones)(nil)).Elem()
}

func (i ManagedNetworkZonesMap) ToManagedNetworkZonesMapOutput() ManagedNetworkZonesMapOutput {
	return i.ToManagedNetworkZonesMapOutputWithContext(context.Background())
}

func (i ManagedNetworkZonesMap) ToManagedNetworkZonesMapOutputWithContext(ctx context.Context) ManagedNetworkZonesMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ManagedNetworkZonesMapOutput)
}

type ManagedNetworkZonesOutput struct{ *pulumi.OutputState }

func (ManagedNetworkZonesOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ManagedNetworkZones)(nil)).Elem()
}

func (o ManagedNetworkZonesOutput) ToManagedNetworkZonesOutput() ManagedNetworkZonesOutput {
	return o
}

func (o ManagedNetworkZonesOutput) ToManagedNetworkZonesOutputWithContext(ctx context.Context) ManagedNetworkZonesOutput {
	return o
}

// A list of alternative network zones.
func (o ManagedNetworkZonesOutput) AlternativeZones() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *ManagedNetworkZones) pulumi.StringArrayOutput { return v.AlternativeZones }).(pulumi.StringArrayOutput)
}

// A short description of the network zone
func (o ManagedNetworkZonesOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ManagedNetworkZones) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// The fallback mode of the network zone. Possible values: `ANY_ACTIVE_GATE`, `NONE`, `ONLY_DEFAULT_ZONE`
func (o ManagedNetworkZonesOutput) FallbackMode() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ManagedNetworkZones) pulumi.StringPtrOutput { return v.FallbackMode }).(pulumi.StringPtrOutput)
}

// Name of the network zone cannot be modified once created. Dynatrace stores the field in lowercase, allowed characters: alphanumeric, hyphen, underscore, dot
func (o ManagedNetworkZonesOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *ManagedNetworkZones) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// The number of ActiveGates in the network zone.
func (o ManagedNetworkZonesOutput) NumOfConfiguredActivegates() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *ManagedNetworkZones) pulumi.IntPtrOutput { return v.NumOfConfiguredActivegates }).(pulumi.IntPtrOutput)
}

// The number of OneAgents that are configured to use the network zone as primary.
func (o ManagedNetworkZonesOutput) NumOfConfiguredOneagents() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *ManagedNetworkZones) pulumi.IntPtrOutput { return v.NumOfConfiguredOneagents }).(pulumi.IntPtrOutput)
}

// The number of OneAgents from other network zones that are using ActiveGates in the network zone.
func (o ManagedNetworkZonesOutput) NumOfOneagentsFromOtherZones() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *ManagedNetworkZones) pulumi.IntPtrOutput { return v.NumOfOneagentsFromOtherZones }).(pulumi.IntPtrOutput)
}

// The number of OneAgents that are using ActiveGates in the network zone.
func (o ManagedNetworkZonesOutput) NumOfOneagentsUsing() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *ManagedNetworkZones) pulumi.IntPtrOutput { return v.NumOfOneagentsUsing }).(pulumi.IntPtrOutput)
}

type ManagedNetworkZonesArrayOutput struct{ *pulumi.OutputState }

func (ManagedNetworkZonesArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ManagedNetworkZones)(nil)).Elem()
}

func (o ManagedNetworkZonesArrayOutput) ToManagedNetworkZonesArrayOutput() ManagedNetworkZonesArrayOutput {
	return o
}

func (o ManagedNetworkZonesArrayOutput) ToManagedNetworkZonesArrayOutputWithContext(ctx context.Context) ManagedNetworkZonesArrayOutput {
	return o
}

func (o ManagedNetworkZonesArrayOutput) Index(i pulumi.IntInput) ManagedNetworkZonesOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ManagedNetworkZones {
		return vs[0].([]*ManagedNetworkZones)[vs[1].(int)]
	}).(ManagedNetworkZonesOutput)
}

type ManagedNetworkZonesMapOutput struct{ *pulumi.OutputState }

func (ManagedNetworkZonesMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ManagedNetworkZones)(nil)).Elem()
}

func (o ManagedNetworkZonesMapOutput) ToManagedNetworkZonesMapOutput() ManagedNetworkZonesMapOutput {
	return o
}

func (o ManagedNetworkZonesMapOutput) ToManagedNetworkZonesMapOutputWithContext(ctx context.Context) ManagedNetworkZonesMapOutput {
	return o
}

func (o ManagedNetworkZonesMapOutput) MapIndex(k pulumi.StringInput) ManagedNetworkZonesOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ManagedNetworkZones {
		return vs[0].(map[string]*ManagedNetworkZones)[vs[1].(string)]
	}).(ManagedNetworkZonesOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ManagedNetworkZonesInput)(nil)).Elem(), &ManagedNetworkZones{})
	pulumi.RegisterInputType(reflect.TypeOf((*ManagedNetworkZonesArrayInput)(nil)).Elem(), ManagedNetworkZonesArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ManagedNetworkZonesMapInput)(nil)).Elem(), ManagedNetworkZonesMap{})
	pulumi.RegisterOutputType(ManagedNetworkZonesOutput{})
	pulumi.RegisterOutputType(ManagedNetworkZonesArrayOutput{})
	pulumi.RegisterOutputType(ManagedNetworkZonesMapOutput{})
}
