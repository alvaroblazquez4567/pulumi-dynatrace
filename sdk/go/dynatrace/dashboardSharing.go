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

// > This is a child resource of dynatrace_json_dashboard, therefore it is automatically retrieved with the dashboard.
//
// > This resource requires the API token scopes **Read configuration** (`ReadConfig`) and **Write configuration** (`WriteConfig`)
//
// ## Dynatrace Documentation
//
// - Share Dynatrace dashboards - https://www.dynatrace.com/support/help/how-to-use-dynatrace/dashboards-and-charts/dashboards/share-dashboards
//
// - Dashboards API - https://www.dynatrace.com/support/help/dynatrace-api/configuration-api/dashboards-api
type DashboardSharing struct {
	pulumi.CustomResourceState

	// The Dynatrace entity ID of the dashboard
	DashboardId pulumi.StringOutput `pulumi:"dashboardId"`
	// The dashboard is shared (`true`) or private (`false`). Make sure that this value is aligned with the attribute `shared` of the resources `Dashboard` and `JsonDashboard`. Otherwise you will encounter non-empty plans.
	Enabled pulumi.BoolPtrOutput `pulumi:"enabled"`
	// Reserved for internal use by the provider
	Muted pulumi.BoolOutput `pulumi:"muted"`
	// Access permissions of the dashboard
	Permissions DashboardSharingPermissionsPtrOutput `pulumi:"permissions"`
	// If `true` the dashboard will be marked as preset. Setting this attribute to `true` will automatically enforce a specific set of permissions - Dashboards flagged as Preset are shared by default. Make sure that this value is aligned with the attribute `preset` of the resources `Dashboard` and `JsonDashboard`. Otherwise you will encounter non-empty plans.
	Preset pulumi.BoolPtrOutput `pulumi:"preset"`
	// Configuration of the [anonymous access](https://dt-url.net/ov03sf1) to the dashboard
	Public DashboardSharingPublicPtrOutput `pulumi:"public"`
}

// NewDashboardSharing registers a new resource with the given unique name, arguments, and options.
func NewDashboardSharing(ctx *pulumi.Context,
	name string, args *DashboardSharingArgs, opts ...pulumi.ResourceOption) (*DashboardSharing, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DashboardId == nil {
		return nil, errors.New("invalid value for required argument 'DashboardId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource DashboardSharing
	err := ctx.RegisterResource("dynatrace:index/dashboardSharing:DashboardSharing", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDashboardSharing gets an existing DashboardSharing resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDashboardSharing(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DashboardSharingState, opts ...pulumi.ResourceOption) (*DashboardSharing, error) {
	var resource DashboardSharing
	err := ctx.ReadResource("dynatrace:index/dashboardSharing:DashboardSharing", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DashboardSharing resources.
type dashboardSharingState struct {
	// The Dynatrace entity ID of the dashboard
	DashboardId *string `pulumi:"dashboardId"`
	// The dashboard is shared (`true`) or private (`false`). Make sure that this value is aligned with the attribute `shared` of the resources `Dashboard` and `JsonDashboard`. Otherwise you will encounter non-empty plans.
	Enabled *bool `pulumi:"enabled"`
	// Reserved for internal use by the provider
	Muted *bool `pulumi:"muted"`
	// Access permissions of the dashboard
	Permissions *DashboardSharingPermissions `pulumi:"permissions"`
	// If `true` the dashboard will be marked as preset. Setting this attribute to `true` will automatically enforce a specific set of permissions - Dashboards flagged as Preset are shared by default. Make sure that this value is aligned with the attribute `preset` of the resources `Dashboard` and `JsonDashboard`. Otherwise you will encounter non-empty plans.
	Preset *bool `pulumi:"preset"`
	// Configuration of the [anonymous access](https://dt-url.net/ov03sf1) to the dashboard
	Public *DashboardSharingPublic `pulumi:"public"`
}

type DashboardSharingState struct {
	// The Dynatrace entity ID of the dashboard
	DashboardId pulumi.StringPtrInput
	// The dashboard is shared (`true`) or private (`false`). Make sure that this value is aligned with the attribute `shared` of the resources `Dashboard` and `JsonDashboard`. Otherwise you will encounter non-empty plans.
	Enabled pulumi.BoolPtrInput
	// Reserved for internal use by the provider
	Muted pulumi.BoolPtrInput
	// Access permissions of the dashboard
	Permissions DashboardSharingPermissionsPtrInput
	// If `true` the dashboard will be marked as preset. Setting this attribute to `true` will automatically enforce a specific set of permissions - Dashboards flagged as Preset are shared by default. Make sure that this value is aligned with the attribute `preset` of the resources `Dashboard` and `JsonDashboard`. Otherwise you will encounter non-empty plans.
	Preset pulumi.BoolPtrInput
	// Configuration of the [anonymous access](https://dt-url.net/ov03sf1) to the dashboard
	Public DashboardSharingPublicPtrInput
}

func (DashboardSharingState) ElementType() reflect.Type {
	return reflect.TypeOf((*dashboardSharingState)(nil)).Elem()
}

type dashboardSharingArgs struct {
	// The Dynatrace entity ID of the dashboard
	DashboardId string `pulumi:"dashboardId"`
	// The dashboard is shared (`true`) or private (`false`). Make sure that this value is aligned with the attribute `shared` of the resources `Dashboard` and `JsonDashboard`. Otherwise you will encounter non-empty plans.
	Enabled *bool `pulumi:"enabled"`
	// Access permissions of the dashboard
	Permissions *DashboardSharingPermissions `pulumi:"permissions"`
	// If `true` the dashboard will be marked as preset. Setting this attribute to `true` will automatically enforce a specific set of permissions - Dashboards flagged as Preset are shared by default. Make sure that this value is aligned with the attribute `preset` of the resources `Dashboard` and `JsonDashboard`. Otherwise you will encounter non-empty plans.
	Preset *bool `pulumi:"preset"`
	// Configuration of the [anonymous access](https://dt-url.net/ov03sf1) to the dashboard
	Public *DashboardSharingPublic `pulumi:"public"`
}

// The set of arguments for constructing a DashboardSharing resource.
type DashboardSharingArgs struct {
	// The Dynatrace entity ID of the dashboard
	DashboardId pulumi.StringInput
	// The dashboard is shared (`true`) or private (`false`). Make sure that this value is aligned with the attribute `shared` of the resources `Dashboard` and `JsonDashboard`. Otherwise you will encounter non-empty plans.
	Enabled pulumi.BoolPtrInput
	// Access permissions of the dashboard
	Permissions DashboardSharingPermissionsPtrInput
	// If `true` the dashboard will be marked as preset. Setting this attribute to `true` will automatically enforce a specific set of permissions - Dashboards flagged as Preset are shared by default. Make sure that this value is aligned with the attribute `preset` of the resources `Dashboard` and `JsonDashboard`. Otherwise you will encounter non-empty plans.
	Preset pulumi.BoolPtrInput
	// Configuration of the [anonymous access](https://dt-url.net/ov03sf1) to the dashboard
	Public DashboardSharingPublicPtrInput
}

func (DashboardSharingArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*dashboardSharingArgs)(nil)).Elem()
}

type DashboardSharingInput interface {
	pulumi.Input

	ToDashboardSharingOutput() DashboardSharingOutput
	ToDashboardSharingOutputWithContext(ctx context.Context) DashboardSharingOutput
}

func (*DashboardSharing) ElementType() reflect.Type {
	return reflect.TypeOf((**DashboardSharing)(nil)).Elem()
}

func (i *DashboardSharing) ToDashboardSharingOutput() DashboardSharingOutput {
	return i.ToDashboardSharingOutputWithContext(context.Background())
}

func (i *DashboardSharing) ToDashboardSharingOutputWithContext(ctx context.Context) DashboardSharingOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DashboardSharingOutput)
}

// DashboardSharingArrayInput is an input type that accepts DashboardSharingArray and DashboardSharingArrayOutput values.
// You can construct a concrete instance of `DashboardSharingArrayInput` via:
//
//	DashboardSharingArray{ DashboardSharingArgs{...} }
type DashboardSharingArrayInput interface {
	pulumi.Input

	ToDashboardSharingArrayOutput() DashboardSharingArrayOutput
	ToDashboardSharingArrayOutputWithContext(context.Context) DashboardSharingArrayOutput
}

type DashboardSharingArray []DashboardSharingInput

func (DashboardSharingArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DashboardSharing)(nil)).Elem()
}

func (i DashboardSharingArray) ToDashboardSharingArrayOutput() DashboardSharingArrayOutput {
	return i.ToDashboardSharingArrayOutputWithContext(context.Background())
}

func (i DashboardSharingArray) ToDashboardSharingArrayOutputWithContext(ctx context.Context) DashboardSharingArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DashboardSharingArrayOutput)
}

// DashboardSharingMapInput is an input type that accepts DashboardSharingMap and DashboardSharingMapOutput values.
// You can construct a concrete instance of `DashboardSharingMapInput` via:
//
//	DashboardSharingMap{ "key": DashboardSharingArgs{...} }
type DashboardSharingMapInput interface {
	pulumi.Input

	ToDashboardSharingMapOutput() DashboardSharingMapOutput
	ToDashboardSharingMapOutputWithContext(context.Context) DashboardSharingMapOutput
}

type DashboardSharingMap map[string]DashboardSharingInput

func (DashboardSharingMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DashboardSharing)(nil)).Elem()
}

func (i DashboardSharingMap) ToDashboardSharingMapOutput() DashboardSharingMapOutput {
	return i.ToDashboardSharingMapOutputWithContext(context.Background())
}

func (i DashboardSharingMap) ToDashboardSharingMapOutputWithContext(ctx context.Context) DashboardSharingMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DashboardSharingMapOutput)
}

type DashboardSharingOutput struct{ *pulumi.OutputState }

func (DashboardSharingOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**DashboardSharing)(nil)).Elem()
}

func (o DashboardSharingOutput) ToDashboardSharingOutput() DashboardSharingOutput {
	return o
}

func (o DashboardSharingOutput) ToDashboardSharingOutputWithContext(ctx context.Context) DashboardSharingOutput {
	return o
}

// The Dynatrace entity ID of the dashboard
func (o DashboardSharingOutput) DashboardId() pulumi.StringOutput {
	return o.ApplyT(func(v *DashboardSharing) pulumi.StringOutput { return v.DashboardId }).(pulumi.StringOutput)
}

// The dashboard is shared (`true`) or private (`false`). Make sure that this value is aligned with the attribute `shared` of the resources `Dashboard` and `JsonDashboard`. Otherwise you will encounter non-empty plans.
func (o DashboardSharingOutput) Enabled() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *DashboardSharing) pulumi.BoolPtrOutput { return v.Enabled }).(pulumi.BoolPtrOutput)
}

// Reserved for internal use by the provider
func (o DashboardSharingOutput) Muted() pulumi.BoolOutput {
	return o.ApplyT(func(v *DashboardSharing) pulumi.BoolOutput { return v.Muted }).(pulumi.BoolOutput)
}

// Access permissions of the dashboard
func (o DashboardSharingOutput) Permissions() DashboardSharingPermissionsPtrOutput {
	return o.ApplyT(func(v *DashboardSharing) DashboardSharingPermissionsPtrOutput { return v.Permissions }).(DashboardSharingPermissionsPtrOutput)
}

// If `true` the dashboard will be marked as preset. Setting this attribute to `true` will automatically enforce a specific set of permissions - Dashboards flagged as Preset are shared by default. Make sure that this value is aligned with the attribute `preset` of the resources `Dashboard` and `JsonDashboard`. Otherwise you will encounter non-empty plans.
func (o DashboardSharingOutput) Preset() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *DashboardSharing) pulumi.BoolPtrOutput { return v.Preset }).(pulumi.BoolPtrOutput)
}

// Configuration of the [anonymous access](https://dt-url.net/ov03sf1) to the dashboard
func (o DashboardSharingOutput) Public() DashboardSharingPublicPtrOutput {
	return o.ApplyT(func(v *DashboardSharing) DashboardSharingPublicPtrOutput { return v.Public }).(DashboardSharingPublicPtrOutput)
}

type DashboardSharingArrayOutput struct{ *pulumi.OutputState }

func (DashboardSharingArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DashboardSharing)(nil)).Elem()
}

func (o DashboardSharingArrayOutput) ToDashboardSharingArrayOutput() DashboardSharingArrayOutput {
	return o
}

func (o DashboardSharingArrayOutput) ToDashboardSharingArrayOutputWithContext(ctx context.Context) DashboardSharingArrayOutput {
	return o
}

func (o DashboardSharingArrayOutput) Index(i pulumi.IntInput) DashboardSharingOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *DashboardSharing {
		return vs[0].([]*DashboardSharing)[vs[1].(int)]
	}).(DashboardSharingOutput)
}

type DashboardSharingMapOutput struct{ *pulumi.OutputState }

func (DashboardSharingMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DashboardSharing)(nil)).Elem()
}

func (o DashboardSharingMapOutput) ToDashboardSharingMapOutput() DashboardSharingMapOutput {
	return o
}

func (o DashboardSharingMapOutput) ToDashboardSharingMapOutputWithContext(ctx context.Context) DashboardSharingMapOutput {
	return o
}

func (o DashboardSharingMapOutput) MapIndex(k pulumi.StringInput) DashboardSharingOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *DashboardSharing {
		return vs[0].(map[string]*DashboardSharing)[vs[1].(string)]
	}).(DashboardSharingOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*DashboardSharingInput)(nil)).Elem(), &DashboardSharing{})
	pulumi.RegisterInputType(reflect.TypeOf((*DashboardSharingArrayInput)(nil)).Elem(), DashboardSharingArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*DashboardSharingMapInput)(nil)).Elem(), DashboardSharingMap{})
	pulumi.RegisterOutputType(DashboardSharingOutput{})
	pulumi.RegisterOutputType(DashboardSharingArrayOutput{})
	pulumi.RegisterOutputType(DashboardSharingMapOutput{})
}
