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

type ConnectivityAlerts struct {
	pulumi.CustomResourceState

	// TCP connectivity problems
	ConnectivityAlerts pulumi.BoolOutput `pulumi:"connectivityAlerts"`
	// The scope of this settings
	ProcessGroupId pulumi.StringOutput `pulumi:"processGroupId"`
}

// NewConnectivityAlerts registers a new resource with the given unique name, arguments, and options.
func NewConnectivityAlerts(ctx *pulumi.Context,
	name string, args *ConnectivityAlertsArgs, opts ...pulumi.ResourceOption) (*ConnectivityAlerts, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ConnectivityAlerts == nil {
		return nil, errors.New("invalid value for required argument 'ConnectivityAlerts'")
	}
	if args.ProcessGroupId == nil {
		return nil, errors.New("invalid value for required argument 'ProcessGroupId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource ConnectivityAlerts
	err := ctx.RegisterResource("dynatrace:index/connectivityAlerts:ConnectivityAlerts", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetConnectivityAlerts gets an existing ConnectivityAlerts resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetConnectivityAlerts(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ConnectivityAlertsState, opts ...pulumi.ResourceOption) (*ConnectivityAlerts, error) {
	var resource ConnectivityAlerts
	err := ctx.ReadResource("dynatrace:index/connectivityAlerts:ConnectivityAlerts", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ConnectivityAlerts resources.
type connectivityAlertsState struct {
	// TCP connectivity problems
	ConnectivityAlerts *bool `pulumi:"connectivityAlerts"`
	// The scope of this settings
	ProcessGroupId *string `pulumi:"processGroupId"`
}

type ConnectivityAlertsState struct {
	// TCP connectivity problems
	ConnectivityAlerts pulumi.BoolPtrInput
	// The scope of this settings
	ProcessGroupId pulumi.StringPtrInput
}

func (ConnectivityAlertsState) ElementType() reflect.Type {
	return reflect.TypeOf((*connectivityAlertsState)(nil)).Elem()
}

type connectivityAlertsArgs struct {
	// TCP connectivity problems
	ConnectivityAlerts bool `pulumi:"connectivityAlerts"`
	// The scope of this settings
	ProcessGroupId string `pulumi:"processGroupId"`
}

// The set of arguments for constructing a ConnectivityAlerts resource.
type ConnectivityAlertsArgs struct {
	// TCP connectivity problems
	ConnectivityAlerts pulumi.BoolInput
	// The scope of this settings
	ProcessGroupId pulumi.StringInput
}

func (ConnectivityAlertsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*connectivityAlertsArgs)(nil)).Elem()
}

type ConnectivityAlertsInput interface {
	pulumi.Input

	ToConnectivityAlertsOutput() ConnectivityAlertsOutput
	ToConnectivityAlertsOutputWithContext(ctx context.Context) ConnectivityAlertsOutput
}

func (*ConnectivityAlerts) ElementType() reflect.Type {
	return reflect.TypeOf((**ConnectivityAlerts)(nil)).Elem()
}

func (i *ConnectivityAlerts) ToConnectivityAlertsOutput() ConnectivityAlertsOutput {
	return i.ToConnectivityAlertsOutputWithContext(context.Background())
}

func (i *ConnectivityAlerts) ToConnectivityAlertsOutputWithContext(ctx context.Context) ConnectivityAlertsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ConnectivityAlertsOutput)
}

// ConnectivityAlertsArrayInput is an input type that accepts ConnectivityAlertsArray and ConnectivityAlertsArrayOutput values.
// You can construct a concrete instance of `ConnectivityAlertsArrayInput` via:
//
//	ConnectivityAlertsArray{ ConnectivityAlertsArgs{...} }
type ConnectivityAlertsArrayInput interface {
	pulumi.Input

	ToConnectivityAlertsArrayOutput() ConnectivityAlertsArrayOutput
	ToConnectivityAlertsArrayOutputWithContext(context.Context) ConnectivityAlertsArrayOutput
}

type ConnectivityAlertsArray []ConnectivityAlertsInput

func (ConnectivityAlertsArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ConnectivityAlerts)(nil)).Elem()
}

func (i ConnectivityAlertsArray) ToConnectivityAlertsArrayOutput() ConnectivityAlertsArrayOutput {
	return i.ToConnectivityAlertsArrayOutputWithContext(context.Background())
}

func (i ConnectivityAlertsArray) ToConnectivityAlertsArrayOutputWithContext(ctx context.Context) ConnectivityAlertsArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ConnectivityAlertsArrayOutput)
}

// ConnectivityAlertsMapInput is an input type that accepts ConnectivityAlertsMap and ConnectivityAlertsMapOutput values.
// You can construct a concrete instance of `ConnectivityAlertsMapInput` via:
//
//	ConnectivityAlertsMap{ "key": ConnectivityAlertsArgs{...} }
type ConnectivityAlertsMapInput interface {
	pulumi.Input

	ToConnectivityAlertsMapOutput() ConnectivityAlertsMapOutput
	ToConnectivityAlertsMapOutputWithContext(context.Context) ConnectivityAlertsMapOutput
}

type ConnectivityAlertsMap map[string]ConnectivityAlertsInput

func (ConnectivityAlertsMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ConnectivityAlerts)(nil)).Elem()
}

func (i ConnectivityAlertsMap) ToConnectivityAlertsMapOutput() ConnectivityAlertsMapOutput {
	return i.ToConnectivityAlertsMapOutputWithContext(context.Background())
}

func (i ConnectivityAlertsMap) ToConnectivityAlertsMapOutputWithContext(ctx context.Context) ConnectivityAlertsMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ConnectivityAlertsMapOutput)
}

type ConnectivityAlertsOutput struct{ *pulumi.OutputState }

func (ConnectivityAlertsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ConnectivityAlerts)(nil)).Elem()
}

func (o ConnectivityAlertsOutput) ToConnectivityAlertsOutput() ConnectivityAlertsOutput {
	return o
}

func (o ConnectivityAlertsOutput) ToConnectivityAlertsOutputWithContext(ctx context.Context) ConnectivityAlertsOutput {
	return o
}

// TCP connectivity problems
func (o ConnectivityAlertsOutput) ConnectivityAlerts() pulumi.BoolOutput {
	return o.ApplyT(func(v *ConnectivityAlerts) pulumi.BoolOutput { return v.ConnectivityAlerts }).(pulumi.BoolOutput)
}

// The scope of this settings
func (o ConnectivityAlertsOutput) ProcessGroupId() pulumi.StringOutput {
	return o.ApplyT(func(v *ConnectivityAlerts) pulumi.StringOutput { return v.ProcessGroupId }).(pulumi.StringOutput)
}

type ConnectivityAlertsArrayOutput struct{ *pulumi.OutputState }

func (ConnectivityAlertsArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ConnectivityAlerts)(nil)).Elem()
}

func (o ConnectivityAlertsArrayOutput) ToConnectivityAlertsArrayOutput() ConnectivityAlertsArrayOutput {
	return o
}

func (o ConnectivityAlertsArrayOutput) ToConnectivityAlertsArrayOutputWithContext(ctx context.Context) ConnectivityAlertsArrayOutput {
	return o
}

func (o ConnectivityAlertsArrayOutput) Index(i pulumi.IntInput) ConnectivityAlertsOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ConnectivityAlerts {
		return vs[0].([]*ConnectivityAlerts)[vs[1].(int)]
	}).(ConnectivityAlertsOutput)
}

type ConnectivityAlertsMapOutput struct{ *pulumi.OutputState }

func (ConnectivityAlertsMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ConnectivityAlerts)(nil)).Elem()
}

func (o ConnectivityAlertsMapOutput) ToConnectivityAlertsMapOutput() ConnectivityAlertsMapOutput {
	return o
}

func (o ConnectivityAlertsMapOutput) ToConnectivityAlertsMapOutputWithContext(ctx context.Context) ConnectivityAlertsMapOutput {
	return o
}

func (o ConnectivityAlertsMapOutput) MapIndex(k pulumi.StringInput) ConnectivityAlertsOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ConnectivityAlerts {
		return vs[0].(map[string]*ConnectivityAlerts)[vs[1].(string)]
	}).(ConnectivityAlertsOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ConnectivityAlertsInput)(nil)).Elem(), &ConnectivityAlerts{})
	pulumi.RegisterInputType(reflect.TypeOf((*ConnectivityAlertsArrayInput)(nil)).Elem(), ConnectivityAlertsArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ConnectivityAlertsMapInput)(nil)).Elem(), ConnectivityAlertsMap{})
	pulumi.RegisterOutputType(ConnectivityAlertsOutput{})
	pulumi.RegisterOutputType(ConnectivityAlertsArrayOutput{})
	pulumi.RegisterOutputType(ConnectivityAlertsMapOutput{})
}
