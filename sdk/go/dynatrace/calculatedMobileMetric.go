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

type CalculatedMobileMetric struct {
	pulumi.CustomResourceState

	// The Dynatrace entity ID of the application to which the metric belongs.
	AppIdentifier pulumi.StringOutput `pulumi:"appIdentifier"`
	// Descriptor of a calculated mobile/custom app metric.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Parameters of a definition of a calculated mobile/custom app metric.
	Dimensions CalculatedMobileMetricDimensionArrayOutput `pulumi:"dimensions"`
	// The metric is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolOutput `pulumi:"enabled"`
	// The unique key of the calculated mobile/custom app metric.
	MetricKey pulumi.StringOutput `pulumi:"metricKey"`
	// The type of the metric. Possible values: [ REPORTED*ERROR*COUNT, USER*ACTION*DURATION, WEB*REQUEST*COUNT, WEB*REQUEST*ERROR_COUNT ]
	MetricType pulumi.StringOutput `pulumi:"metricType"`
	// The displayed name of the metric.
	Name pulumi.StringOutput `pulumi:"name"`
	// Parameters of a definition of a calculated mobile/custom app metric.
	UserActionFilter CalculatedMobileMetricUserActionFilterPtrOutput `pulumi:"userActionFilter"`
}

// NewCalculatedMobileMetric registers a new resource with the given unique name, arguments, and options.
func NewCalculatedMobileMetric(ctx *pulumi.Context,
	name string, args *CalculatedMobileMetricArgs, opts ...pulumi.ResourceOption) (*CalculatedMobileMetric, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AppIdentifier == nil {
		return nil, errors.New("invalid value for required argument 'AppIdentifier'")
	}
	if args.Enabled == nil {
		return nil, errors.New("invalid value for required argument 'Enabled'")
	}
	if args.MetricKey == nil {
		return nil, errors.New("invalid value for required argument 'MetricKey'")
	}
	if args.MetricType == nil {
		return nil, errors.New("invalid value for required argument 'MetricType'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource CalculatedMobileMetric
	err := ctx.RegisterResource("dynatrace:index/calculatedMobileMetric:CalculatedMobileMetric", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCalculatedMobileMetric gets an existing CalculatedMobileMetric resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCalculatedMobileMetric(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CalculatedMobileMetricState, opts ...pulumi.ResourceOption) (*CalculatedMobileMetric, error) {
	var resource CalculatedMobileMetric
	err := ctx.ReadResource("dynatrace:index/calculatedMobileMetric:CalculatedMobileMetric", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering CalculatedMobileMetric resources.
type calculatedMobileMetricState struct {
	// The Dynatrace entity ID of the application to which the metric belongs.
	AppIdentifier *string `pulumi:"appIdentifier"`
	// Descriptor of a calculated mobile/custom app metric.
	Description *string `pulumi:"description"`
	// Parameters of a definition of a calculated mobile/custom app metric.
	Dimensions []CalculatedMobileMetricDimension `pulumi:"dimensions"`
	// The metric is enabled (`true`) or disabled (`false`)
	Enabled *bool `pulumi:"enabled"`
	// The unique key of the calculated mobile/custom app metric.
	MetricKey *string `pulumi:"metricKey"`
	// The type of the metric. Possible values: [ REPORTED*ERROR*COUNT, USER*ACTION*DURATION, WEB*REQUEST*COUNT, WEB*REQUEST*ERROR_COUNT ]
	MetricType *string `pulumi:"metricType"`
	// The displayed name of the metric.
	Name *string `pulumi:"name"`
	// Parameters of a definition of a calculated mobile/custom app metric.
	UserActionFilter *CalculatedMobileMetricUserActionFilter `pulumi:"userActionFilter"`
}

type CalculatedMobileMetricState struct {
	// The Dynatrace entity ID of the application to which the metric belongs.
	AppIdentifier pulumi.StringPtrInput
	// Descriptor of a calculated mobile/custom app metric.
	Description pulumi.StringPtrInput
	// Parameters of a definition of a calculated mobile/custom app metric.
	Dimensions CalculatedMobileMetricDimensionArrayInput
	// The metric is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolPtrInput
	// The unique key of the calculated mobile/custom app metric.
	MetricKey pulumi.StringPtrInput
	// The type of the metric. Possible values: [ REPORTED*ERROR*COUNT, USER*ACTION*DURATION, WEB*REQUEST*COUNT, WEB*REQUEST*ERROR_COUNT ]
	MetricType pulumi.StringPtrInput
	// The displayed name of the metric.
	Name pulumi.StringPtrInput
	// Parameters of a definition of a calculated mobile/custom app metric.
	UserActionFilter CalculatedMobileMetricUserActionFilterPtrInput
}

func (CalculatedMobileMetricState) ElementType() reflect.Type {
	return reflect.TypeOf((*calculatedMobileMetricState)(nil)).Elem()
}

type calculatedMobileMetricArgs struct {
	// The Dynatrace entity ID of the application to which the metric belongs.
	AppIdentifier string `pulumi:"appIdentifier"`
	// Descriptor of a calculated mobile/custom app metric.
	Description *string `pulumi:"description"`
	// Parameters of a definition of a calculated mobile/custom app metric.
	Dimensions []CalculatedMobileMetricDimension `pulumi:"dimensions"`
	// The metric is enabled (`true`) or disabled (`false`)
	Enabled bool `pulumi:"enabled"`
	// The unique key of the calculated mobile/custom app metric.
	MetricKey string `pulumi:"metricKey"`
	// The type of the metric. Possible values: [ REPORTED*ERROR*COUNT, USER*ACTION*DURATION, WEB*REQUEST*COUNT, WEB*REQUEST*ERROR_COUNT ]
	MetricType string `pulumi:"metricType"`
	// The displayed name of the metric.
	Name *string `pulumi:"name"`
	// Parameters of a definition of a calculated mobile/custom app metric.
	UserActionFilter *CalculatedMobileMetricUserActionFilter `pulumi:"userActionFilter"`
}

// The set of arguments for constructing a CalculatedMobileMetric resource.
type CalculatedMobileMetricArgs struct {
	// The Dynatrace entity ID of the application to which the metric belongs.
	AppIdentifier pulumi.StringInput
	// Descriptor of a calculated mobile/custom app metric.
	Description pulumi.StringPtrInput
	// Parameters of a definition of a calculated mobile/custom app metric.
	Dimensions CalculatedMobileMetricDimensionArrayInput
	// The metric is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolInput
	// The unique key of the calculated mobile/custom app metric.
	MetricKey pulumi.StringInput
	// The type of the metric. Possible values: [ REPORTED*ERROR*COUNT, USER*ACTION*DURATION, WEB*REQUEST*COUNT, WEB*REQUEST*ERROR_COUNT ]
	MetricType pulumi.StringInput
	// The displayed name of the metric.
	Name pulumi.StringPtrInput
	// Parameters of a definition of a calculated mobile/custom app metric.
	UserActionFilter CalculatedMobileMetricUserActionFilterPtrInput
}

func (CalculatedMobileMetricArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*calculatedMobileMetricArgs)(nil)).Elem()
}

type CalculatedMobileMetricInput interface {
	pulumi.Input

	ToCalculatedMobileMetricOutput() CalculatedMobileMetricOutput
	ToCalculatedMobileMetricOutputWithContext(ctx context.Context) CalculatedMobileMetricOutput
}

func (*CalculatedMobileMetric) ElementType() reflect.Type {
	return reflect.TypeOf((**CalculatedMobileMetric)(nil)).Elem()
}

func (i *CalculatedMobileMetric) ToCalculatedMobileMetricOutput() CalculatedMobileMetricOutput {
	return i.ToCalculatedMobileMetricOutputWithContext(context.Background())
}

func (i *CalculatedMobileMetric) ToCalculatedMobileMetricOutputWithContext(ctx context.Context) CalculatedMobileMetricOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CalculatedMobileMetricOutput)
}

// CalculatedMobileMetricArrayInput is an input type that accepts CalculatedMobileMetricArray and CalculatedMobileMetricArrayOutput values.
// You can construct a concrete instance of `CalculatedMobileMetricArrayInput` via:
//
//	CalculatedMobileMetricArray{ CalculatedMobileMetricArgs{...} }
type CalculatedMobileMetricArrayInput interface {
	pulumi.Input

	ToCalculatedMobileMetricArrayOutput() CalculatedMobileMetricArrayOutput
	ToCalculatedMobileMetricArrayOutputWithContext(context.Context) CalculatedMobileMetricArrayOutput
}

type CalculatedMobileMetricArray []CalculatedMobileMetricInput

func (CalculatedMobileMetricArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*CalculatedMobileMetric)(nil)).Elem()
}

func (i CalculatedMobileMetricArray) ToCalculatedMobileMetricArrayOutput() CalculatedMobileMetricArrayOutput {
	return i.ToCalculatedMobileMetricArrayOutputWithContext(context.Background())
}

func (i CalculatedMobileMetricArray) ToCalculatedMobileMetricArrayOutputWithContext(ctx context.Context) CalculatedMobileMetricArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CalculatedMobileMetricArrayOutput)
}

// CalculatedMobileMetricMapInput is an input type that accepts CalculatedMobileMetricMap and CalculatedMobileMetricMapOutput values.
// You can construct a concrete instance of `CalculatedMobileMetricMapInput` via:
//
//	CalculatedMobileMetricMap{ "key": CalculatedMobileMetricArgs{...} }
type CalculatedMobileMetricMapInput interface {
	pulumi.Input

	ToCalculatedMobileMetricMapOutput() CalculatedMobileMetricMapOutput
	ToCalculatedMobileMetricMapOutputWithContext(context.Context) CalculatedMobileMetricMapOutput
}

type CalculatedMobileMetricMap map[string]CalculatedMobileMetricInput

func (CalculatedMobileMetricMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*CalculatedMobileMetric)(nil)).Elem()
}

func (i CalculatedMobileMetricMap) ToCalculatedMobileMetricMapOutput() CalculatedMobileMetricMapOutput {
	return i.ToCalculatedMobileMetricMapOutputWithContext(context.Background())
}

func (i CalculatedMobileMetricMap) ToCalculatedMobileMetricMapOutputWithContext(ctx context.Context) CalculatedMobileMetricMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CalculatedMobileMetricMapOutput)
}

type CalculatedMobileMetricOutput struct{ *pulumi.OutputState }

func (CalculatedMobileMetricOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**CalculatedMobileMetric)(nil)).Elem()
}

func (o CalculatedMobileMetricOutput) ToCalculatedMobileMetricOutput() CalculatedMobileMetricOutput {
	return o
}

func (o CalculatedMobileMetricOutput) ToCalculatedMobileMetricOutputWithContext(ctx context.Context) CalculatedMobileMetricOutput {
	return o
}

// The Dynatrace entity ID of the application to which the metric belongs.
func (o CalculatedMobileMetricOutput) AppIdentifier() pulumi.StringOutput {
	return o.ApplyT(func(v *CalculatedMobileMetric) pulumi.StringOutput { return v.AppIdentifier }).(pulumi.StringOutput)
}

// Descriptor of a calculated mobile/custom app metric.
func (o CalculatedMobileMetricOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *CalculatedMobileMetric) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// Parameters of a definition of a calculated mobile/custom app metric.
func (o CalculatedMobileMetricOutput) Dimensions() CalculatedMobileMetricDimensionArrayOutput {
	return o.ApplyT(func(v *CalculatedMobileMetric) CalculatedMobileMetricDimensionArrayOutput { return v.Dimensions }).(CalculatedMobileMetricDimensionArrayOutput)
}

// The metric is enabled (`true`) or disabled (`false`)
func (o CalculatedMobileMetricOutput) Enabled() pulumi.BoolOutput {
	return o.ApplyT(func(v *CalculatedMobileMetric) pulumi.BoolOutput { return v.Enabled }).(pulumi.BoolOutput)
}

// The unique key of the calculated mobile/custom app metric.
func (o CalculatedMobileMetricOutput) MetricKey() pulumi.StringOutput {
	return o.ApplyT(func(v *CalculatedMobileMetric) pulumi.StringOutput { return v.MetricKey }).(pulumi.StringOutput)
}

// The type of the metric. Possible values: [ REPORTED*ERROR*COUNT, USER*ACTION*DURATION, WEB*REQUEST*COUNT, WEB*REQUEST*ERROR_COUNT ]
func (o CalculatedMobileMetricOutput) MetricType() pulumi.StringOutput {
	return o.ApplyT(func(v *CalculatedMobileMetric) pulumi.StringOutput { return v.MetricType }).(pulumi.StringOutput)
}

// The displayed name of the metric.
func (o CalculatedMobileMetricOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *CalculatedMobileMetric) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Parameters of a definition of a calculated mobile/custom app metric.
func (o CalculatedMobileMetricOutput) UserActionFilter() CalculatedMobileMetricUserActionFilterPtrOutput {
	return o.ApplyT(func(v *CalculatedMobileMetric) CalculatedMobileMetricUserActionFilterPtrOutput {
		return v.UserActionFilter
	}).(CalculatedMobileMetricUserActionFilterPtrOutput)
}

type CalculatedMobileMetricArrayOutput struct{ *pulumi.OutputState }

func (CalculatedMobileMetricArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*CalculatedMobileMetric)(nil)).Elem()
}

func (o CalculatedMobileMetricArrayOutput) ToCalculatedMobileMetricArrayOutput() CalculatedMobileMetricArrayOutput {
	return o
}

func (o CalculatedMobileMetricArrayOutput) ToCalculatedMobileMetricArrayOutputWithContext(ctx context.Context) CalculatedMobileMetricArrayOutput {
	return o
}

func (o CalculatedMobileMetricArrayOutput) Index(i pulumi.IntInput) CalculatedMobileMetricOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *CalculatedMobileMetric {
		return vs[0].([]*CalculatedMobileMetric)[vs[1].(int)]
	}).(CalculatedMobileMetricOutput)
}

type CalculatedMobileMetricMapOutput struct{ *pulumi.OutputState }

func (CalculatedMobileMetricMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*CalculatedMobileMetric)(nil)).Elem()
}

func (o CalculatedMobileMetricMapOutput) ToCalculatedMobileMetricMapOutput() CalculatedMobileMetricMapOutput {
	return o
}

func (o CalculatedMobileMetricMapOutput) ToCalculatedMobileMetricMapOutputWithContext(ctx context.Context) CalculatedMobileMetricMapOutput {
	return o
}

func (o CalculatedMobileMetricMapOutput) MapIndex(k pulumi.StringInput) CalculatedMobileMetricOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *CalculatedMobileMetric {
		return vs[0].(map[string]*CalculatedMobileMetric)[vs[1].(string)]
	}).(CalculatedMobileMetricOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*CalculatedMobileMetricInput)(nil)).Elem(), &CalculatedMobileMetric{})
	pulumi.RegisterInputType(reflect.TypeOf((*CalculatedMobileMetricArrayInput)(nil)).Elem(), CalculatedMobileMetricArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*CalculatedMobileMetricMapInput)(nil)).Elem(), CalculatedMobileMetricMap{})
	pulumi.RegisterOutputType(CalculatedMobileMetricOutput{})
	pulumi.RegisterOutputType(CalculatedMobileMetricArrayOutput{})
	pulumi.RegisterOutputType(CalculatedMobileMetricMapOutput{})
}
