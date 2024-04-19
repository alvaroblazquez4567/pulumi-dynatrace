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

type BrowserMonitor struct {
	pulumi.CustomResourceState

	// The anomaly detection configuration.
	AnomalyDetection BrowserMonitorAnomalyDetectionPtrOutput `pulumi:"anomalyDetection"`
	// Performance threshold is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolPtrOutput `pulumi:"enabled"`
	// The frequency of the monitor, in minutes.
	Frequency pulumi.IntOutput `pulumi:"frequency"`
	// The key performance metrics configuration
	KeyPerformanceMetrics BrowserMonitorKeyPerformanceMetricsOutput `pulumi:"keyPerformanceMetrics"`
	// A list of locations from which the monitor is executed. To specify a location, use its entity ID.
	Locations pulumi.StringArrayOutput `pulumi:"locations"`
	// A set of manually assigned applications.
	ManuallyAssignedApps pulumi.StringArrayOutput `pulumi:"manuallyAssignedApps"`
	// The name of the cookie. The following cookie names are now allowed: `dtCookie`, `dtLatC`, `dtPC`, `rxVisitor`, `rxlatency`, `rxpc`, `rxsession` and `rxvt`
	Name pulumi.StringOutput `pulumi:"name"`
	// The Browser Script
	Script BrowserMonitorScriptPtrOutput `pulumi:"script"`
	// A set of tags assigned to the monitor. You can specify only the value of the tag here and the `CONTEXTLESS` context and
	// source 'USER' will be added automatically.
	Tags BrowserMonitorTagArrayOutput `pulumi:"tags"`
}

// NewBrowserMonitor registers a new resource with the given unique name, arguments, and options.
func NewBrowserMonitor(ctx *pulumi.Context,
	name string, args *BrowserMonitorArgs, opts ...pulumi.ResourceOption) (*BrowserMonitor, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Frequency == nil {
		return nil, errors.New("invalid value for required argument 'Frequency'")
	}
	if args.KeyPerformanceMetrics == nil {
		return nil, errors.New("invalid value for required argument 'KeyPerformanceMetrics'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource BrowserMonitor
	err := ctx.RegisterResource("dynatrace:index/browserMonitor:BrowserMonitor", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetBrowserMonitor gets an existing BrowserMonitor resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBrowserMonitor(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *BrowserMonitorState, opts ...pulumi.ResourceOption) (*BrowserMonitor, error) {
	var resource BrowserMonitor
	err := ctx.ReadResource("dynatrace:index/browserMonitor:BrowserMonitor", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering BrowserMonitor resources.
type browserMonitorState struct {
	// The anomaly detection configuration.
	AnomalyDetection *BrowserMonitorAnomalyDetection `pulumi:"anomalyDetection"`
	// Performance threshold is enabled (`true`) or disabled (`false`)
	Enabled *bool `pulumi:"enabled"`
	// The frequency of the monitor, in minutes.
	Frequency *int `pulumi:"frequency"`
	// The key performance metrics configuration
	KeyPerformanceMetrics *BrowserMonitorKeyPerformanceMetrics `pulumi:"keyPerformanceMetrics"`
	// A list of locations from which the monitor is executed. To specify a location, use its entity ID.
	Locations []string `pulumi:"locations"`
	// A set of manually assigned applications.
	ManuallyAssignedApps []string `pulumi:"manuallyAssignedApps"`
	// The name of the cookie. The following cookie names are now allowed: `dtCookie`, `dtLatC`, `dtPC`, `rxVisitor`, `rxlatency`, `rxpc`, `rxsession` and `rxvt`
	Name *string `pulumi:"name"`
	// The Browser Script
	Script *BrowserMonitorScript `pulumi:"script"`
	// A set of tags assigned to the monitor. You can specify only the value of the tag here and the `CONTEXTLESS` context and
	// source 'USER' will be added automatically.
	Tags []BrowserMonitorTag `pulumi:"tags"`
}

type BrowserMonitorState struct {
	// The anomaly detection configuration.
	AnomalyDetection BrowserMonitorAnomalyDetectionPtrInput
	// Performance threshold is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolPtrInput
	// The frequency of the monitor, in minutes.
	Frequency pulumi.IntPtrInput
	// The key performance metrics configuration
	KeyPerformanceMetrics BrowserMonitorKeyPerformanceMetricsPtrInput
	// A list of locations from which the monitor is executed. To specify a location, use its entity ID.
	Locations pulumi.StringArrayInput
	// A set of manually assigned applications.
	ManuallyAssignedApps pulumi.StringArrayInput
	// The name of the cookie. The following cookie names are now allowed: `dtCookie`, `dtLatC`, `dtPC`, `rxVisitor`, `rxlatency`, `rxpc`, `rxsession` and `rxvt`
	Name pulumi.StringPtrInput
	// The Browser Script
	Script BrowserMonitorScriptPtrInput
	// A set of tags assigned to the monitor. You can specify only the value of the tag here and the `CONTEXTLESS` context and
	// source 'USER' will be added automatically.
	Tags BrowserMonitorTagArrayInput
}

func (BrowserMonitorState) ElementType() reflect.Type {
	return reflect.TypeOf((*browserMonitorState)(nil)).Elem()
}

type browserMonitorArgs struct {
	// The anomaly detection configuration.
	AnomalyDetection *BrowserMonitorAnomalyDetection `pulumi:"anomalyDetection"`
	// Performance threshold is enabled (`true`) or disabled (`false`)
	Enabled *bool `pulumi:"enabled"`
	// The frequency of the monitor, in minutes.
	Frequency int `pulumi:"frequency"`
	// The key performance metrics configuration
	KeyPerformanceMetrics BrowserMonitorKeyPerformanceMetrics `pulumi:"keyPerformanceMetrics"`
	// A list of locations from which the monitor is executed. To specify a location, use its entity ID.
	Locations []string `pulumi:"locations"`
	// A set of manually assigned applications.
	ManuallyAssignedApps []string `pulumi:"manuallyAssignedApps"`
	// The name of the cookie. The following cookie names are now allowed: `dtCookie`, `dtLatC`, `dtPC`, `rxVisitor`, `rxlatency`, `rxpc`, `rxsession` and `rxvt`
	Name *string `pulumi:"name"`
	// The Browser Script
	Script *BrowserMonitorScript `pulumi:"script"`
	// A set of tags assigned to the monitor. You can specify only the value of the tag here and the `CONTEXTLESS` context and
	// source 'USER' will be added automatically.
	Tags []BrowserMonitorTag `pulumi:"tags"`
}

// The set of arguments for constructing a BrowserMonitor resource.
type BrowserMonitorArgs struct {
	// The anomaly detection configuration.
	AnomalyDetection BrowserMonitorAnomalyDetectionPtrInput
	// Performance threshold is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolPtrInput
	// The frequency of the monitor, in minutes.
	Frequency pulumi.IntInput
	// The key performance metrics configuration
	KeyPerformanceMetrics BrowserMonitorKeyPerformanceMetricsInput
	// A list of locations from which the monitor is executed. To specify a location, use its entity ID.
	Locations pulumi.StringArrayInput
	// A set of manually assigned applications.
	ManuallyAssignedApps pulumi.StringArrayInput
	// The name of the cookie. The following cookie names are now allowed: `dtCookie`, `dtLatC`, `dtPC`, `rxVisitor`, `rxlatency`, `rxpc`, `rxsession` and `rxvt`
	Name pulumi.StringPtrInput
	// The Browser Script
	Script BrowserMonitorScriptPtrInput
	// A set of tags assigned to the monitor. You can specify only the value of the tag here and the `CONTEXTLESS` context and
	// source 'USER' will be added automatically.
	Tags BrowserMonitorTagArrayInput
}

func (BrowserMonitorArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*browserMonitorArgs)(nil)).Elem()
}

type BrowserMonitorInput interface {
	pulumi.Input

	ToBrowserMonitorOutput() BrowserMonitorOutput
	ToBrowserMonitorOutputWithContext(ctx context.Context) BrowserMonitorOutput
}

func (*BrowserMonitor) ElementType() reflect.Type {
	return reflect.TypeOf((**BrowserMonitor)(nil)).Elem()
}

func (i *BrowserMonitor) ToBrowserMonitorOutput() BrowserMonitorOutput {
	return i.ToBrowserMonitorOutputWithContext(context.Background())
}

func (i *BrowserMonitor) ToBrowserMonitorOutputWithContext(ctx context.Context) BrowserMonitorOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BrowserMonitorOutput)
}

// BrowserMonitorArrayInput is an input type that accepts BrowserMonitorArray and BrowserMonitorArrayOutput values.
// You can construct a concrete instance of `BrowserMonitorArrayInput` via:
//
//	BrowserMonitorArray{ BrowserMonitorArgs{...} }
type BrowserMonitorArrayInput interface {
	pulumi.Input

	ToBrowserMonitorArrayOutput() BrowserMonitorArrayOutput
	ToBrowserMonitorArrayOutputWithContext(context.Context) BrowserMonitorArrayOutput
}

type BrowserMonitorArray []BrowserMonitorInput

func (BrowserMonitorArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*BrowserMonitor)(nil)).Elem()
}

func (i BrowserMonitorArray) ToBrowserMonitorArrayOutput() BrowserMonitorArrayOutput {
	return i.ToBrowserMonitorArrayOutputWithContext(context.Background())
}

func (i BrowserMonitorArray) ToBrowserMonitorArrayOutputWithContext(ctx context.Context) BrowserMonitorArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BrowserMonitorArrayOutput)
}

// BrowserMonitorMapInput is an input type that accepts BrowserMonitorMap and BrowserMonitorMapOutput values.
// You can construct a concrete instance of `BrowserMonitorMapInput` via:
//
//	BrowserMonitorMap{ "key": BrowserMonitorArgs{...} }
type BrowserMonitorMapInput interface {
	pulumi.Input

	ToBrowserMonitorMapOutput() BrowserMonitorMapOutput
	ToBrowserMonitorMapOutputWithContext(context.Context) BrowserMonitorMapOutput
}

type BrowserMonitorMap map[string]BrowserMonitorInput

func (BrowserMonitorMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*BrowserMonitor)(nil)).Elem()
}

func (i BrowserMonitorMap) ToBrowserMonitorMapOutput() BrowserMonitorMapOutput {
	return i.ToBrowserMonitorMapOutputWithContext(context.Background())
}

func (i BrowserMonitorMap) ToBrowserMonitorMapOutputWithContext(ctx context.Context) BrowserMonitorMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BrowserMonitorMapOutput)
}

type BrowserMonitorOutput struct{ *pulumi.OutputState }

func (BrowserMonitorOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**BrowserMonitor)(nil)).Elem()
}

func (o BrowserMonitorOutput) ToBrowserMonitorOutput() BrowserMonitorOutput {
	return o
}

func (o BrowserMonitorOutput) ToBrowserMonitorOutputWithContext(ctx context.Context) BrowserMonitorOutput {
	return o
}

// The anomaly detection configuration.
func (o BrowserMonitorOutput) AnomalyDetection() BrowserMonitorAnomalyDetectionPtrOutput {
	return o.ApplyT(func(v *BrowserMonitor) BrowserMonitorAnomalyDetectionPtrOutput { return v.AnomalyDetection }).(BrowserMonitorAnomalyDetectionPtrOutput)
}

// Performance threshold is enabled (`true`) or disabled (`false`)
func (o BrowserMonitorOutput) Enabled() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *BrowserMonitor) pulumi.BoolPtrOutput { return v.Enabled }).(pulumi.BoolPtrOutput)
}

// The frequency of the monitor, in minutes.
func (o BrowserMonitorOutput) Frequency() pulumi.IntOutput {
	return o.ApplyT(func(v *BrowserMonitor) pulumi.IntOutput { return v.Frequency }).(pulumi.IntOutput)
}

// The key performance metrics configuration
func (o BrowserMonitorOutput) KeyPerformanceMetrics() BrowserMonitorKeyPerformanceMetricsOutput {
	return o.ApplyT(func(v *BrowserMonitor) BrowserMonitorKeyPerformanceMetricsOutput { return v.KeyPerformanceMetrics }).(BrowserMonitorKeyPerformanceMetricsOutput)
}

// A list of locations from which the monitor is executed. To specify a location, use its entity ID.
func (o BrowserMonitorOutput) Locations() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *BrowserMonitor) pulumi.StringArrayOutput { return v.Locations }).(pulumi.StringArrayOutput)
}

// A set of manually assigned applications.
func (o BrowserMonitorOutput) ManuallyAssignedApps() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *BrowserMonitor) pulumi.StringArrayOutput { return v.ManuallyAssignedApps }).(pulumi.StringArrayOutput)
}

// The name of the cookie. The following cookie names are now allowed: `dtCookie`, `dtLatC`, `dtPC`, `rxVisitor`, `rxlatency`, `rxpc`, `rxsession` and `rxvt`
func (o BrowserMonitorOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *BrowserMonitor) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// The Browser Script
func (o BrowserMonitorOutput) Script() BrowserMonitorScriptPtrOutput {
	return o.ApplyT(func(v *BrowserMonitor) BrowserMonitorScriptPtrOutput { return v.Script }).(BrowserMonitorScriptPtrOutput)
}

// A set of tags assigned to the monitor. You can specify only the value of the tag here and the `CONTEXTLESS` context and
// source 'USER' will be added automatically.
func (o BrowserMonitorOutput) Tags() BrowserMonitorTagArrayOutput {
	return o.ApplyT(func(v *BrowserMonitor) BrowserMonitorTagArrayOutput { return v.Tags }).(BrowserMonitorTagArrayOutput)
}

type BrowserMonitorArrayOutput struct{ *pulumi.OutputState }

func (BrowserMonitorArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*BrowserMonitor)(nil)).Elem()
}

func (o BrowserMonitorArrayOutput) ToBrowserMonitorArrayOutput() BrowserMonitorArrayOutput {
	return o
}

func (o BrowserMonitorArrayOutput) ToBrowserMonitorArrayOutputWithContext(ctx context.Context) BrowserMonitorArrayOutput {
	return o
}

func (o BrowserMonitorArrayOutput) Index(i pulumi.IntInput) BrowserMonitorOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *BrowserMonitor {
		return vs[0].([]*BrowserMonitor)[vs[1].(int)]
	}).(BrowserMonitorOutput)
}

type BrowserMonitorMapOutput struct{ *pulumi.OutputState }

func (BrowserMonitorMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*BrowserMonitor)(nil)).Elem()
}

func (o BrowserMonitorMapOutput) ToBrowserMonitorMapOutput() BrowserMonitorMapOutput {
	return o
}

func (o BrowserMonitorMapOutput) ToBrowserMonitorMapOutputWithContext(ctx context.Context) BrowserMonitorMapOutput {
	return o
}

func (o BrowserMonitorMapOutput) MapIndex(k pulumi.StringInput) BrowserMonitorOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *BrowserMonitor {
		return vs[0].(map[string]*BrowserMonitor)[vs[1].(string)]
	}).(BrowserMonitorOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*BrowserMonitorInput)(nil)).Elem(), &BrowserMonitor{})
	pulumi.RegisterInputType(reflect.TypeOf((*BrowserMonitorArrayInput)(nil)).Elem(), BrowserMonitorArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*BrowserMonitorMapInput)(nil)).Elem(), BrowserMonitorMap{})
	pulumi.RegisterOutputType(BrowserMonitorOutput{})
	pulumi.RegisterOutputType(BrowserMonitorArrayOutput{})
	pulumi.RegisterOutputType(BrowserMonitorMapOutput{})
}