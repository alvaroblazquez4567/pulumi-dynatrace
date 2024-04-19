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

// !> This resource API endpoint has been deprecated, please use Maintenance instead.
//
// > This resource requires the API token scopes **Read configuration** (`ReadConfig`) and **Write configuration** (`WriteConfig`)
//
// ## Dynatrace Documentation
//
// - Maintenance windows - https://www.dynatrace.com/support/help/how-to-use-dynatrace/problem-detection-and-analysis/notifications-and-alerting/maintenance-windows
//
// - Maintenance windows API - https://www.dynatrace.com/support/help/dynatrace-api/configuration-api/maintenance-windows-api
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
//			_, err := dynatrace.NewMaintenanceWindow(ctx, "#name#", &dynatrace.MaintenanceWindowArgs{
//				Schedule: &dynatrace.MaintenanceWindowScheduleArgs{
//					End:            pulumi.String("2021-05-11 14:41"),
//					RecurrenceType: pulumi.String("ONCE"),
//					Start:          pulumi.String("2021-05-11 13:41"),
//					ZoneId:         pulumi.String("Europe/Vienna"),
//				},
//				Scope: &dynatrace.MaintenanceWindowScopeArgs{
//					Matches: dynatrace.MaintenanceWindowScopeMatchArray{
//						&dynatrace.MaintenanceWindowScopeMatchArgs{
//							TagCombination: pulumi.String("AND"),
//							Tags: dynatrace.MaintenanceWindowScopeMatchTagArray{
//								&dynatrace.MaintenanceWindowScopeMatchTagArgs{
//									Context: pulumi.String("CONTEXTLESS"),
//									Key:     pulumi.String("bggtedgxen"),
//								},
//								&dynatrace.MaintenanceWindowScopeMatchTagArgs{
//									Context: pulumi.String("CONTEXTLESS"),
//									Key:     pulumi.String("deldel1"),
//								},
//							},
//						},
//					},
//				},
//				SuppressSynthMonExec: pulumi.Bool(true),
//				Suppression:          pulumi.String("DONT_DETECT_PROBLEMS"),
//				Type:                 pulumi.String("PLANNED"),
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
type MaintenanceWindow struct {
	pulumi.CustomResourceState

	// A short description of the maintenance purpose
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The Maintenance Window is enabled or disabled
	Enabled pulumi.BoolPtrOutput `pulumi:"enabled"`
	// The name of the maintenance window, displayed in the UI
	Name pulumi.StringOutput `pulumi:"name"`
	// The schedule of the maintenance window
	Schedule MaintenanceWindowSchedulePtrOutput `pulumi:"schedule"`
	// the tiles this Dashboard consist of
	Scope MaintenanceWindowScopePtrOutput `pulumi:"scope"`
	// Suppress execution of synthetic monitors during the maintenance
	SuppressSynthMonExec pulumi.BoolPtrOutput `pulumi:"suppressSynthMonExec"`
	// The type of suppression of alerting and problem detection during the maintenance
	Suppression pulumi.StringOutput `pulumi:"suppression"`
	// The type of the Dynatrace entities (for example, hosts or services) you want to pick up by matching
	Type pulumi.StringOutput `pulumi:"type"`
	// allows for configuring properties that are not explicitly supported by the current version of this provider
	Unknowns pulumi.StringPtrOutput `pulumi:"unknowns"`
}

// NewMaintenanceWindow registers a new resource with the given unique name, arguments, and options.
func NewMaintenanceWindow(ctx *pulumi.Context,
	name string, args *MaintenanceWindowArgs, opts ...pulumi.ResourceOption) (*MaintenanceWindow, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Suppression == nil {
		return nil, errors.New("invalid value for required argument 'Suppression'")
	}
	if args.Type == nil {
		return nil, errors.New("invalid value for required argument 'Type'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource MaintenanceWindow
	err := ctx.RegisterResource("dynatrace:index/maintenanceWindow:MaintenanceWindow", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMaintenanceWindow gets an existing MaintenanceWindow resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMaintenanceWindow(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MaintenanceWindowState, opts ...pulumi.ResourceOption) (*MaintenanceWindow, error) {
	var resource MaintenanceWindow
	err := ctx.ReadResource("dynatrace:index/maintenanceWindow:MaintenanceWindow", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering MaintenanceWindow resources.
type maintenanceWindowState struct {
	// A short description of the maintenance purpose
	Description *string `pulumi:"description"`
	// The Maintenance Window is enabled or disabled
	Enabled *bool `pulumi:"enabled"`
	// The name of the maintenance window, displayed in the UI
	Name *string `pulumi:"name"`
	// The schedule of the maintenance window
	Schedule *MaintenanceWindowSchedule `pulumi:"schedule"`
	// the tiles this Dashboard consist of
	Scope *MaintenanceWindowScope `pulumi:"scope"`
	// Suppress execution of synthetic monitors during the maintenance
	SuppressSynthMonExec *bool `pulumi:"suppressSynthMonExec"`
	// The type of suppression of alerting and problem detection during the maintenance
	Suppression *string `pulumi:"suppression"`
	// The type of the Dynatrace entities (for example, hosts or services) you want to pick up by matching
	Type *string `pulumi:"type"`
	// allows for configuring properties that are not explicitly supported by the current version of this provider
	Unknowns *string `pulumi:"unknowns"`
}

type MaintenanceWindowState struct {
	// A short description of the maintenance purpose
	Description pulumi.StringPtrInput
	// The Maintenance Window is enabled or disabled
	Enabled pulumi.BoolPtrInput
	// The name of the maintenance window, displayed in the UI
	Name pulumi.StringPtrInput
	// The schedule of the maintenance window
	Schedule MaintenanceWindowSchedulePtrInput
	// the tiles this Dashboard consist of
	Scope MaintenanceWindowScopePtrInput
	// Suppress execution of synthetic monitors during the maintenance
	SuppressSynthMonExec pulumi.BoolPtrInput
	// The type of suppression of alerting and problem detection during the maintenance
	Suppression pulumi.StringPtrInput
	// The type of the Dynatrace entities (for example, hosts or services) you want to pick up by matching
	Type pulumi.StringPtrInput
	// allows for configuring properties that are not explicitly supported by the current version of this provider
	Unknowns pulumi.StringPtrInput
}

func (MaintenanceWindowState) ElementType() reflect.Type {
	return reflect.TypeOf((*maintenanceWindowState)(nil)).Elem()
}

type maintenanceWindowArgs struct {
	// A short description of the maintenance purpose
	Description *string `pulumi:"description"`
	// The Maintenance Window is enabled or disabled
	Enabled *bool `pulumi:"enabled"`
	// The name of the maintenance window, displayed in the UI
	Name *string `pulumi:"name"`
	// The schedule of the maintenance window
	Schedule *MaintenanceWindowSchedule `pulumi:"schedule"`
	// the tiles this Dashboard consist of
	Scope *MaintenanceWindowScope `pulumi:"scope"`
	// Suppress execution of synthetic monitors during the maintenance
	SuppressSynthMonExec *bool `pulumi:"suppressSynthMonExec"`
	// The type of suppression of alerting and problem detection during the maintenance
	Suppression string `pulumi:"suppression"`
	// The type of the Dynatrace entities (for example, hosts or services) you want to pick up by matching
	Type string `pulumi:"type"`
	// allows for configuring properties that are not explicitly supported by the current version of this provider
	Unknowns *string `pulumi:"unknowns"`
}

// The set of arguments for constructing a MaintenanceWindow resource.
type MaintenanceWindowArgs struct {
	// A short description of the maintenance purpose
	Description pulumi.StringPtrInput
	// The Maintenance Window is enabled or disabled
	Enabled pulumi.BoolPtrInput
	// The name of the maintenance window, displayed in the UI
	Name pulumi.StringPtrInput
	// The schedule of the maintenance window
	Schedule MaintenanceWindowSchedulePtrInput
	// the tiles this Dashboard consist of
	Scope MaintenanceWindowScopePtrInput
	// Suppress execution of synthetic monitors during the maintenance
	SuppressSynthMonExec pulumi.BoolPtrInput
	// The type of suppression of alerting and problem detection during the maintenance
	Suppression pulumi.StringInput
	// The type of the Dynatrace entities (for example, hosts or services) you want to pick up by matching
	Type pulumi.StringInput
	// allows for configuring properties that are not explicitly supported by the current version of this provider
	Unknowns pulumi.StringPtrInput
}

func (MaintenanceWindowArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*maintenanceWindowArgs)(nil)).Elem()
}

type MaintenanceWindowInput interface {
	pulumi.Input

	ToMaintenanceWindowOutput() MaintenanceWindowOutput
	ToMaintenanceWindowOutputWithContext(ctx context.Context) MaintenanceWindowOutput
}

func (*MaintenanceWindow) ElementType() reflect.Type {
	return reflect.TypeOf((**MaintenanceWindow)(nil)).Elem()
}

func (i *MaintenanceWindow) ToMaintenanceWindowOutput() MaintenanceWindowOutput {
	return i.ToMaintenanceWindowOutputWithContext(context.Background())
}

func (i *MaintenanceWindow) ToMaintenanceWindowOutputWithContext(ctx context.Context) MaintenanceWindowOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MaintenanceWindowOutput)
}

// MaintenanceWindowArrayInput is an input type that accepts MaintenanceWindowArray and MaintenanceWindowArrayOutput values.
// You can construct a concrete instance of `MaintenanceWindowArrayInput` via:
//
//	MaintenanceWindowArray{ MaintenanceWindowArgs{...} }
type MaintenanceWindowArrayInput interface {
	pulumi.Input

	ToMaintenanceWindowArrayOutput() MaintenanceWindowArrayOutput
	ToMaintenanceWindowArrayOutputWithContext(context.Context) MaintenanceWindowArrayOutput
}

type MaintenanceWindowArray []MaintenanceWindowInput

func (MaintenanceWindowArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*MaintenanceWindow)(nil)).Elem()
}

func (i MaintenanceWindowArray) ToMaintenanceWindowArrayOutput() MaintenanceWindowArrayOutput {
	return i.ToMaintenanceWindowArrayOutputWithContext(context.Background())
}

func (i MaintenanceWindowArray) ToMaintenanceWindowArrayOutputWithContext(ctx context.Context) MaintenanceWindowArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MaintenanceWindowArrayOutput)
}

// MaintenanceWindowMapInput is an input type that accepts MaintenanceWindowMap and MaintenanceWindowMapOutput values.
// You can construct a concrete instance of `MaintenanceWindowMapInput` via:
//
//	MaintenanceWindowMap{ "key": MaintenanceWindowArgs{...} }
type MaintenanceWindowMapInput interface {
	pulumi.Input

	ToMaintenanceWindowMapOutput() MaintenanceWindowMapOutput
	ToMaintenanceWindowMapOutputWithContext(context.Context) MaintenanceWindowMapOutput
}

type MaintenanceWindowMap map[string]MaintenanceWindowInput

func (MaintenanceWindowMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*MaintenanceWindow)(nil)).Elem()
}

func (i MaintenanceWindowMap) ToMaintenanceWindowMapOutput() MaintenanceWindowMapOutput {
	return i.ToMaintenanceWindowMapOutputWithContext(context.Background())
}

func (i MaintenanceWindowMap) ToMaintenanceWindowMapOutputWithContext(ctx context.Context) MaintenanceWindowMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MaintenanceWindowMapOutput)
}

type MaintenanceWindowOutput struct{ *pulumi.OutputState }

func (MaintenanceWindowOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**MaintenanceWindow)(nil)).Elem()
}

func (o MaintenanceWindowOutput) ToMaintenanceWindowOutput() MaintenanceWindowOutput {
	return o
}

func (o MaintenanceWindowOutput) ToMaintenanceWindowOutputWithContext(ctx context.Context) MaintenanceWindowOutput {
	return o
}

// A short description of the maintenance purpose
func (o MaintenanceWindowOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *MaintenanceWindow) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// The Maintenance Window is enabled or disabled
func (o MaintenanceWindowOutput) Enabled() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *MaintenanceWindow) pulumi.BoolPtrOutput { return v.Enabled }).(pulumi.BoolPtrOutput)
}

// The name of the maintenance window, displayed in the UI
func (o MaintenanceWindowOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *MaintenanceWindow) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// The schedule of the maintenance window
func (o MaintenanceWindowOutput) Schedule() MaintenanceWindowSchedulePtrOutput {
	return o.ApplyT(func(v *MaintenanceWindow) MaintenanceWindowSchedulePtrOutput { return v.Schedule }).(MaintenanceWindowSchedulePtrOutput)
}

// the tiles this Dashboard consist of
func (o MaintenanceWindowOutput) Scope() MaintenanceWindowScopePtrOutput {
	return o.ApplyT(func(v *MaintenanceWindow) MaintenanceWindowScopePtrOutput { return v.Scope }).(MaintenanceWindowScopePtrOutput)
}

// Suppress execution of synthetic monitors during the maintenance
func (o MaintenanceWindowOutput) SuppressSynthMonExec() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *MaintenanceWindow) pulumi.BoolPtrOutput { return v.SuppressSynthMonExec }).(pulumi.BoolPtrOutput)
}

// The type of suppression of alerting and problem detection during the maintenance
func (o MaintenanceWindowOutput) Suppression() pulumi.StringOutput {
	return o.ApplyT(func(v *MaintenanceWindow) pulumi.StringOutput { return v.Suppression }).(pulumi.StringOutput)
}

// The type of the Dynatrace entities (for example, hosts or services) you want to pick up by matching
func (o MaintenanceWindowOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v *MaintenanceWindow) pulumi.StringOutput { return v.Type }).(pulumi.StringOutput)
}

// allows for configuring properties that are not explicitly supported by the current version of this provider
func (o MaintenanceWindowOutput) Unknowns() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *MaintenanceWindow) pulumi.StringPtrOutput { return v.Unknowns }).(pulumi.StringPtrOutput)
}

type MaintenanceWindowArrayOutput struct{ *pulumi.OutputState }

func (MaintenanceWindowArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*MaintenanceWindow)(nil)).Elem()
}

func (o MaintenanceWindowArrayOutput) ToMaintenanceWindowArrayOutput() MaintenanceWindowArrayOutput {
	return o
}

func (o MaintenanceWindowArrayOutput) ToMaintenanceWindowArrayOutputWithContext(ctx context.Context) MaintenanceWindowArrayOutput {
	return o
}

func (o MaintenanceWindowArrayOutput) Index(i pulumi.IntInput) MaintenanceWindowOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *MaintenanceWindow {
		return vs[0].([]*MaintenanceWindow)[vs[1].(int)]
	}).(MaintenanceWindowOutput)
}

type MaintenanceWindowMapOutput struct{ *pulumi.OutputState }

func (MaintenanceWindowMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*MaintenanceWindow)(nil)).Elem()
}

func (o MaintenanceWindowMapOutput) ToMaintenanceWindowMapOutput() MaintenanceWindowMapOutput {
	return o
}

func (o MaintenanceWindowMapOutput) ToMaintenanceWindowMapOutputWithContext(ctx context.Context) MaintenanceWindowMapOutput {
	return o
}

func (o MaintenanceWindowMapOutput) MapIndex(k pulumi.StringInput) MaintenanceWindowOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *MaintenanceWindow {
		return vs[0].(map[string]*MaintenanceWindow)[vs[1].(string)]
	}).(MaintenanceWindowOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*MaintenanceWindowInput)(nil)).Elem(), &MaintenanceWindow{})
	pulumi.RegisterInputType(reflect.TypeOf((*MaintenanceWindowArrayInput)(nil)).Elem(), MaintenanceWindowArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*MaintenanceWindowMapInput)(nil)).Elem(), MaintenanceWindowMap{})
	pulumi.RegisterOutputType(MaintenanceWindowOutput{})
	pulumi.RegisterOutputType(MaintenanceWindowArrayOutput{})
	pulumi.RegisterOutputType(MaintenanceWindowMapOutput{})
}
