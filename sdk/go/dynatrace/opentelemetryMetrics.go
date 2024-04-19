// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dynatrace

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi-dynatrace/sdk/go/dynatrace/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type OpentelemetryMetrics struct {
	pulumi.CustomResourceState

	// When enabled, the attributes defined in the list below will be added as dimensions to ingested OTLP metrics if they are present in the OpenTelemetry resource or in the instrumentation scope.
	AdditionalAttributes OpentelemetryMetricsAdditionalAttributesPtrOutput `pulumi:"additionalAttributes"`
	// Add the resource and scope attributes configured below as dimensions
	AdditionalAttributesToDimensionEnabled pulumi.BoolOutput `pulumi:"additionalAttributesToDimensionEnabled"`
	// When enabled, the Meter name (also referred to as InstrumentationScope or InstrumentationLibrary in OpenTelemetry SDKs)
	// and version will be added as dimensions (`otel.scope.name` and `otel.scope.version`) to ingested OTLP metrics. **Note:**
	// Modifying this setting will cause the metric to change. This may have an impact on existing dashboards, events and
	// alerts that make use of these dimensions. In this case, they will need to be updated manually
	MeterNameToDimensionEnabled pulumi.BoolOutput `pulumi:"meterNameToDimensionEnabled"`
	// Specifies whether the given attributes to enable (`additional_attributes`) and the attributes to drop
	// (`to_drop_attributes`) will get applied explicitly (`EXPLICIT`) or additive (`ADDITIVE`). Default behavior is `EXPLICIT`
	// - in which case it is recommended to have just ONE instance of this resource With mode `ADDITIVE` you're able to have
	//   multiple instances of this resource within the same Terraform Module. **Note:** Using `ADDITIVE` and `EXPLICIT` at the
	//   same time within differnt resource instances will lead to unexpected results.
	Mode pulumi.StringPtrOutput `pulumi:"mode"`
	// The scope of this setting (environment-default). Omit this property if you want to cover the whole environment.
	Scope pulumi.StringPtrOutput `pulumi:"scope"`
	// The attributes defined in the list below will be dropped from all ingested OTLP metrics. Upon ingest, the *Allow list:
	// resource and scope attributes* above is applied first. Then, the *Deny list: all attributes* below is applied. The deny
	// list therefore applies to all attributes from all sources (data points, scope and resource). **Notes:** * Modifying this
	// setting (adding, renaming, disabling or removing attributes) will cause the metric to change. This may have an impact on
	// existing dashboards, events and alerts that make use of these dimensions. In this case, they will need to be updated
	// manually. * Dynatrace does not recommend including attributes starting with "dt." to the deny list. Dynatrace leverages
	// these attributes to [Enrich
	// metrics](https://www.dynatrace.com/support/help/extend-dynatrace/extend-metrics/reference/enrich-metrics).
	ToDropAttributes OpentelemetryMetricsToDropAttributesPtrOutput `pulumi:"toDropAttributes"`
}

// NewOpentelemetryMetrics registers a new resource with the given unique name, arguments, and options.
func NewOpentelemetryMetrics(ctx *pulumi.Context,
	name string, args *OpentelemetryMetricsArgs, opts ...pulumi.ResourceOption) (*OpentelemetryMetrics, error) {
	if args == nil {
		args = &OpentelemetryMetricsArgs{}
	}

	opts = internal.PkgResourceDefaultOpts(opts)
	var resource OpentelemetryMetrics
	err := ctx.RegisterResource("dynatrace:index/opentelemetryMetrics:OpentelemetryMetrics", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetOpentelemetryMetrics gets an existing OpentelemetryMetrics resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetOpentelemetryMetrics(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *OpentelemetryMetricsState, opts ...pulumi.ResourceOption) (*OpentelemetryMetrics, error) {
	var resource OpentelemetryMetrics
	err := ctx.ReadResource("dynatrace:index/opentelemetryMetrics:OpentelemetryMetrics", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering OpentelemetryMetrics resources.
type opentelemetryMetricsState struct {
	// When enabled, the attributes defined in the list below will be added as dimensions to ingested OTLP metrics if they are present in the OpenTelemetry resource or in the instrumentation scope.
	AdditionalAttributes *OpentelemetryMetricsAdditionalAttributes `pulumi:"additionalAttributes"`
	// Add the resource and scope attributes configured below as dimensions
	AdditionalAttributesToDimensionEnabled *bool `pulumi:"additionalAttributesToDimensionEnabled"`
	// When enabled, the Meter name (also referred to as InstrumentationScope or InstrumentationLibrary in OpenTelemetry SDKs)
	// and version will be added as dimensions (`otel.scope.name` and `otel.scope.version`) to ingested OTLP metrics. **Note:**
	// Modifying this setting will cause the metric to change. This may have an impact on existing dashboards, events and
	// alerts that make use of these dimensions. In this case, they will need to be updated manually
	MeterNameToDimensionEnabled *bool `pulumi:"meterNameToDimensionEnabled"`
	// Specifies whether the given attributes to enable (`additional_attributes`) and the attributes to drop
	// (`to_drop_attributes`) will get applied explicitly (`EXPLICIT`) or additive (`ADDITIVE`). Default behavior is `EXPLICIT`
	// - in which case it is recommended to have just ONE instance of this resource With mode `ADDITIVE` you're able to have
	//   multiple instances of this resource within the same Terraform Module. **Note:** Using `ADDITIVE` and `EXPLICIT` at the
	//   same time within differnt resource instances will lead to unexpected results.
	Mode *string `pulumi:"mode"`
	// The scope of this setting (environment-default). Omit this property if you want to cover the whole environment.
	Scope *string `pulumi:"scope"`
	// The attributes defined in the list below will be dropped from all ingested OTLP metrics. Upon ingest, the *Allow list:
	// resource and scope attributes* above is applied first. Then, the *Deny list: all attributes* below is applied. The deny
	// list therefore applies to all attributes from all sources (data points, scope and resource). **Notes:** * Modifying this
	// setting (adding, renaming, disabling or removing attributes) will cause the metric to change. This may have an impact on
	// existing dashboards, events and alerts that make use of these dimensions. In this case, they will need to be updated
	// manually. * Dynatrace does not recommend including attributes starting with "dt." to the deny list. Dynatrace leverages
	// these attributes to [Enrich
	// metrics](https://www.dynatrace.com/support/help/extend-dynatrace/extend-metrics/reference/enrich-metrics).
	ToDropAttributes *OpentelemetryMetricsToDropAttributes `pulumi:"toDropAttributes"`
}

type OpentelemetryMetricsState struct {
	// When enabled, the attributes defined in the list below will be added as dimensions to ingested OTLP metrics if they are present in the OpenTelemetry resource or in the instrumentation scope.
	AdditionalAttributes OpentelemetryMetricsAdditionalAttributesPtrInput
	// Add the resource and scope attributes configured below as dimensions
	AdditionalAttributesToDimensionEnabled pulumi.BoolPtrInput
	// When enabled, the Meter name (also referred to as InstrumentationScope or InstrumentationLibrary in OpenTelemetry SDKs)
	// and version will be added as dimensions (`otel.scope.name` and `otel.scope.version`) to ingested OTLP metrics. **Note:**
	// Modifying this setting will cause the metric to change. This may have an impact on existing dashboards, events and
	// alerts that make use of these dimensions. In this case, they will need to be updated manually
	MeterNameToDimensionEnabled pulumi.BoolPtrInput
	// Specifies whether the given attributes to enable (`additional_attributes`) and the attributes to drop
	// (`to_drop_attributes`) will get applied explicitly (`EXPLICIT`) or additive (`ADDITIVE`). Default behavior is `EXPLICIT`
	// - in which case it is recommended to have just ONE instance of this resource With mode `ADDITIVE` you're able to have
	//   multiple instances of this resource within the same Terraform Module. **Note:** Using `ADDITIVE` and `EXPLICIT` at the
	//   same time within differnt resource instances will lead to unexpected results.
	Mode pulumi.StringPtrInput
	// The scope of this setting (environment-default). Omit this property if you want to cover the whole environment.
	Scope pulumi.StringPtrInput
	// The attributes defined in the list below will be dropped from all ingested OTLP metrics. Upon ingest, the *Allow list:
	// resource and scope attributes* above is applied first. Then, the *Deny list: all attributes* below is applied. The deny
	// list therefore applies to all attributes from all sources (data points, scope and resource). **Notes:** * Modifying this
	// setting (adding, renaming, disabling or removing attributes) will cause the metric to change. This may have an impact on
	// existing dashboards, events and alerts that make use of these dimensions. In this case, they will need to be updated
	// manually. * Dynatrace does not recommend including attributes starting with "dt." to the deny list. Dynatrace leverages
	// these attributes to [Enrich
	// metrics](https://www.dynatrace.com/support/help/extend-dynatrace/extend-metrics/reference/enrich-metrics).
	ToDropAttributes OpentelemetryMetricsToDropAttributesPtrInput
}

func (OpentelemetryMetricsState) ElementType() reflect.Type {
	return reflect.TypeOf((*opentelemetryMetricsState)(nil)).Elem()
}

type opentelemetryMetricsArgs struct {
	// When enabled, the attributes defined in the list below will be added as dimensions to ingested OTLP metrics if they are present in the OpenTelemetry resource or in the instrumentation scope.
	AdditionalAttributes *OpentelemetryMetricsAdditionalAttributes `pulumi:"additionalAttributes"`
	// Add the resource and scope attributes configured below as dimensions
	AdditionalAttributesToDimensionEnabled *bool `pulumi:"additionalAttributesToDimensionEnabled"`
	// When enabled, the Meter name (also referred to as InstrumentationScope or InstrumentationLibrary in OpenTelemetry SDKs)
	// and version will be added as dimensions (`otel.scope.name` and `otel.scope.version`) to ingested OTLP metrics. **Note:**
	// Modifying this setting will cause the metric to change. This may have an impact on existing dashboards, events and
	// alerts that make use of these dimensions. In this case, they will need to be updated manually
	MeterNameToDimensionEnabled *bool `pulumi:"meterNameToDimensionEnabled"`
	// Specifies whether the given attributes to enable (`additional_attributes`) and the attributes to drop
	// (`to_drop_attributes`) will get applied explicitly (`EXPLICIT`) or additive (`ADDITIVE`). Default behavior is `EXPLICIT`
	// - in which case it is recommended to have just ONE instance of this resource With mode `ADDITIVE` you're able to have
	//   multiple instances of this resource within the same Terraform Module. **Note:** Using `ADDITIVE` and `EXPLICIT` at the
	//   same time within differnt resource instances will lead to unexpected results.
	Mode *string `pulumi:"mode"`
	// The scope of this setting (environment-default). Omit this property if you want to cover the whole environment.
	Scope *string `pulumi:"scope"`
	// The attributes defined in the list below will be dropped from all ingested OTLP metrics. Upon ingest, the *Allow list:
	// resource and scope attributes* above is applied first. Then, the *Deny list: all attributes* below is applied. The deny
	// list therefore applies to all attributes from all sources (data points, scope and resource). **Notes:** * Modifying this
	// setting (adding, renaming, disabling or removing attributes) will cause the metric to change. This may have an impact on
	// existing dashboards, events and alerts that make use of these dimensions. In this case, they will need to be updated
	// manually. * Dynatrace does not recommend including attributes starting with "dt." to the deny list. Dynatrace leverages
	// these attributes to [Enrich
	// metrics](https://www.dynatrace.com/support/help/extend-dynatrace/extend-metrics/reference/enrich-metrics).
	ToDropAttributes *OpentelemetryMetricsToDropAttributes `pulumi:"toDropAttributes"`
}

// The set of arguments for constructing a OpentelemetryMetrics resource.
type OpentelemetryMetricsArgs struct {
	// When enabled, the attributes defined in the list below will be added as dimensions to ingested OTLP metrics if they are present in the OpenTelemetry resource or in the instrumentation scope.
	AdditionalAttributes OpentelemetryMetricsAdditionalAttributesPtrInput
	// Add the resource and scope attributes configured below as dimensions
	AdditionalAttributesToDimensionEnabled pulumi.BoolPtrInput
	// When enabled, the Meter name (also referred to as InstrumentationScope or InstrumentationLibrary in OpenTelemetry SDKs)
	// and version will be added as dimensions (`otel.scope.name` and `otel.scope.version`) to ingested OTLP metrics. **Note:**
	// Modifying this setting will cause the metric to change. This may have an impact on existing dashboards, events and
	// alerts that make use of these dimensions. In this case, they will need to be updated manually
	MeterNameToDimensionEnabled pulumi.BoolPtrInput
	// Specifies whether the given attributes to enable (`additional_attributes`) and the attributes to drop
	// (`to_drop_attributes`) will get applied explicitly (`EXPLICIT`) or additive (`ADDITIVE`). Default behavior is `EXPLICIT`
	// - in which case it is recommended to have just ONE instance of this resource With mode `ADDITIVE` you're able to have
	//   multiple instances of this resource within the same Terraform Module. **Note:** Using `ADDITIVE` and `EXPLICIT` at the
	//   same time within differnt resource instances will lead to unexpected results.
	Mode pulumi.StringPtrInput
	// The scope of this setting (environment-default). Omit this property if you want to cover the whole environment.
	Scope pulumi.StringPtrInput
	// The attributes defined in the list below will be dropped from all ingested OTLP metrics. Upon ingest, the *Allow list:
	// resource and scope attributes* above is applied first. Then, the *Deny list: all attributes* below is applied. The deny
	// list therefore applies to all attributes from all sources (data points, scope and resource). **Notes:** * Modifying this
	// setting (adding, renaming, disabling or removing attributes) will cause the metric to change. This may have an impact on
	// existing dashboards, events and alerts that make use of these dimensions. In this case, they will need to be updated
	// manually. * Dynatrace does not recommend including attributes starting with "dt." to the deny list. Dynatrace leverages
	// these attributes to [Enrich
	// metrics](https://www.dynatrace.com/support/help/extend-dynatrace/extend-metrics/reference/enrich-metrics).
	ToDropAttributes OpentelemetryMetricsToDropAttributesPtrInput
}

func (OpentelemetryMetricsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*opentelemetryMetricsArgs)(nil)).Elem()
}

type OpentelemetryMetricsInput interface {
	pulumi.Input

	ToOpentelemetryMetricsOutput() OpentelemetryMetricsOutput
	ToOpentelemetryMetricsOutputWithContext(ctx context.Context) OpentelemetryMetricsOutput
}

func (*OpentelemetryMetrics) ElementType() reflect.Type {
	return reflect.TypeOf((**OpentelemetryMetrics)(nil)).Elem()
}

func (i *OpentelemetryMetrics) ToOpentelemetryMetricsOutput() OpentelemetryMetricsOutput {
	return i.ToOpentelemetryMetricsOutputWithContext(context.Background())
}

func (i *OpentelemetryMetrics) ToOpentelemetryMetricsOutputWithContext(ctx context.Context) OpentelemetryMetricsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OpentelemetryMetricsOutput)
}

// OpentelemetryMetricsArrayInput is an input type that accepts OpentelemetryMetricsArray and OpentelemetryMetricsArrayOutput values.
// You can construct a concrete instance of `OpentelemetryMetricsArrayInput` via:
//
//	OpentelemetryMetricsArray{ OpentelemetryMetricsArgs{...} }
type OpentelemetryMetricsArrayInput interface {
	pulumi.Input

	ToOpentelemetryMetricsArrayOutput() OpentelemetryMetricsArrayOutput
	ToOpentelemetryMetricsArrayOutputWithContext(context.Context) OpentelemetryMetricsArrayOutput
}

type OpentelemetryMetricsArray []OpentelemetryMetricsInput

func (OpentelemetryMetricsArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*OpentelemetryMetrics)(nil)).Elem()
}

func (i OpentelemetryMetricsArray) ToOpentelemetryMetricsArrayOutput() OpentelemetryMetricsArrayOutput {
	return i.ToOpentelemetryMetricsArrayOutputWithContext(context.Background())
}

func (i OpentelemetryMetricsArray) ToOpentelemetryMetricsArrayOutputWithContext(ctx context.Context) OpentelemetryMetricsArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OpentelemetryMetricsArrayOutput)
}

// OpentelemetryMetricsMapInput is an input type that accepts OpentelemetryMetricsMap and OpentelemetryMetricsMapOutput values.
// You can construct a concrete instance of `OpentelemetryMetricsMapInput` via:
//
//	OpentelemetryMetricsMap{ "key": OpentelemetryMetricsArgs{...} }
type OpentelemetryMetricsMapInput interface {
	pulumi.Input

	ToOpentelemetryMetricsMapOutput() OpentelemetryMetricsMapOutput
	ToOpentelemetryMetricsMapOutputWithContext(context.Context) OpentelemetryMetricsMapOutput
}

type OpentelemetryMetricsMap map[string]OpentelemetryMetricsInput

func (OpentelemetryMetricsMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*OpentelemetryMetrics)(nil)).Elem()
}

func (i OpentelemetryMetricsMap) ToOpentelemetryMetricsMapOutput() OpentelemetryMetricsMapOutput {
	return i.ToOpentelemetryMetricsMapOutputWithContext(context.Background())
}

func (i OpentelemetryMetricsMap) ToOpentelemetryMetricsMapOutputWithContext(ctx context.Context) OpentelemetryMetricsMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OpentelemetryMetricsMapOutput)
}

type OpentelemetryMetricsOutput struct{ *pulumi.OutputState }

func (OpentelemetryMetricsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**OpentelemetryMetrics)(nil)).Elem()
}

func (o OpentelemetryMetricsOutput) ToOpentelemetryMetricsOutput() OpentelemetryMetricsOutput {
	return o
}

func (o OpentelemetryMetricsOutput) ToOpentelemetryMetricsOutputWithContext(ctx context.Context) OpentelemetryMetricsOutput {
	return o
}

// When enabled, the attributes defined in the list below will be added as dimensions to ingested OTLP metrics if they are present in the OpenTelemetry resource or in the instrumentation scope.
func (o OpentelemetryMetricsOutput) AdditionalAttributes() OpentelemetryMetricsAdditionalAttributesPtrOutput {
	return o.ApplyT(func(v *OpentelemetryMetrics) OpentelemetryMetricsAdditionalAttributesPtrOutput {
		return v.AdditionalAttributes
	}).(OpentelemetryMetricsAdditionalAttributesPtrOutput)
}

// Add the resource and scope attributes configured below as dimensions
func (o OpentelemetryMetricsOutput) AdditionalAttributesToDimensionEnabled() pulumi.BoolOutput {
	return o.ApplyT(func(v *OpentelemetryMetrics) pulumi.BoolOutput { return v.AdditionalAttributesToDimensionEnabled }).(pulumi.BoolOutput)
}

// When enabled, the Meter name (also referred to as InstrumentationScope or InstrumentationLibrary in OpenTelemetry SDKs)
// and version will be added as dimensions (`otel.scope.name` and `otel.scope.version`) to ingested OTLP metrics. **Note:**
// Modifying this setting will cause the metric to change. This may have an impact on existing dashboards, events and
// alerts that make use of these dimensions. In this case, they will need to be updated manually
func (o OpentelemetryMetricsOutput) MeterNameToDimensionEnabled() pulumi.BoolOutput {
	return o.ApplyT(func(v *OpentelemetryMetrics) pulumi.BoolOutput { return v.MeterNameToDimensionEnabled }).(pulumi.BoolOutput)
}

// Specifies whether the given attributes to enable (`additional_attributes`) and the attributes to drop
// (`to_drop_attributes`) will get applied explicitly (`EXPLICIT`) or additive (`ADDITIVE`). Default behavior is `EXPLICIT`
//   - in which case it is recommended to have just ONE instance of this resource With mode `ADDITIVE` you're able to have
//     multiple instances of this resource within the same Terraform Module. **Note:** Using `ADDITIVE` and `EXPLICIT` at the
//     same time within differnt resource instances will lead to unexpected results.
func (o OpentelemetryMetricsOutput) Mode() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *OpentelemetryMetrics) pulumi.StringPtrOutput { return v.Mode }).(pulumi.StringPtrOutput)
}

// The scope of this setting (environment-default). Omit this property if you want to cover the whole environment.
func (o OpentelemetryMetricsOutput) Scope() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *OpentelemetryMetrics) pulumi.StringPtrOutput { return v.Scope }).(pulumi.StringPtrOutput)
}

// The attributes defined in the list below will be dropped from all ingested OTLP metrics. Upon ingest, the *Allow list:
// resource and scope attributes* above is applied first. Then, the *Deny list: all attributes* below is applied. The deny
// list therefore applies to all attributes from all sources (data points, scope and resource). **Notes:** * Modifying this
// setting (adding, renaming, disabling or removing attributes) will cause the metric to change. This may have an impact on
// existing dashboards, events and alerts that make use of these dimensions. In this case, they will need to be updated
// manually. * Dynatrace does not recommend including attributes starting with "dt." to the deny list. Dynatrace leverages
// these attributes to [Enrich
// metrics](https://www.dynatrace.com/support/help/extend-dynatrace/extend-metrics/reference/enrich-metrics).
func (o OpentelemetryMetricsOutput) ToDropAttributes() OpentelemetryMetricsToDropAttributesPtrOutput {
	return o.ApplyT(func(v *OpentelemetryMetrics) OpentelemetryMetricsToDropAttributesPtrOutput { return v.ToDropAttributes }).(OpentelemetryMetricsToDropAttributesPtrOutput)
}

type OpentelemetryMetricsArrayOutput struct{ *pulumi.OutputState }

func (OpentelemetryMetricsArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*OpentelemetryMetrics)(nil)).Elem()
}

func (o OpentelemetryMetricsArrayOutput) ToOpentelemetryMetricsArrayOutput() OpentelemetryMetricsArrayOutput {
	return o
}

func (o OpentelemetryMetricsArrayOutput) ToOpentelemetryMetricsArrayOutputWithContext(ctx context.Context) OpentelemetryMetricsArrayOutput {
	return o
}

func (o OpentelemetryMetricsArrayOutput) Index(i pulumi.IntInput) OpentelemetryMetricsOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *OpentelemetryMetrics {
		return vs[0].([]*OpentelemetryMetrics)[vs[1].(int)]
	}).(OpentelemetryMetricsOutput)
}

type OpentelemetryMetricsMapOutput struct{ *pulumi.OutputState }

func (OpentelemetryMetricsMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*OpentelemetryMetrics)(nil)).Elem()
}

func (o OpentelemetryMetricsMapOutput) ToOpentelemetryMetricsMapOutput() OpentelemetryMetricsMapOutput {
	return o
}

func (o OpentelemetryMetricsMapOutput) ToOpentelemetryMetricsMapOutputWithContext(ctx context.Context) OpentelemetryMetricsMapOutput {
	return o
}

func (o OpentelemetryMetricsMapOutput) MapIndex(k pulumi.StringInput) OpentelemetryMetricsOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *OpentelemetryMetrics {
		return vs[0].(map[string]*OpentelemetryMetrics)[vs[1].(string)]
	}).(OpentelemetryMetricsOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*OpentelemetryMetricsInput)(nil)).Elem(), &OpentelemetryMetrics{})
	pulumi.RegisterInputType(reflect.TypeOf((*OpentelemetryMetricsArrayInput)(nil)).Elem(), OpentelemetryMetricsArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*OpentelemetryMetricsMapInput)(nil)).Elem(), OpentelemetryMetricsMap{})
	pulumi.RegisterOutputType(OpentelemetryMetricsOutput{})
	pulumi.RegisterOutputType(OpentelemetryMetricsArrayOutput{})
	pulumi.RegisterOutputType(OpentelemetryMetricsMapOutput{})
}