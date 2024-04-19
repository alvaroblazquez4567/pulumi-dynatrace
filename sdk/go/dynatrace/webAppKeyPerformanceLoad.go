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

type WebAppKeyPerformanceLoad struct {
	pulumi.CustomResourceState

	// If the selected key performance metric is not detected, the **User action duration** metric is used instead.
	FallbackThresholds WebAppKeyPerformanceLoadFallbackThresholdsPtrOutput `pulumi:"fallbackThresholds"`
	// Possible Values: `CUMULATIVE_LAYOUT_SHIFT`, `DOM_INTERACTIVE`, `FIRST_INPUT_DELAY`, `LARGEST_CONTENTFUL_PAINT`, `LOAD_EVENT_END`, `LOAD_EVENT_START`, `RESPONSE_END`, `RESPONSE_START`, `SPEED_INDEX`, `USER_ACTION_DURATION`, `VISUALLY_COMPLETE`
	Kpm pulumi.StringOutput `pulumi:"kpm"`
	// The scope of this setting (APPLICATION_METHOD, APPLICATION)
	Scope pulumi.StringOutput `pulumi:"scope"`
	// Set the Tolerating and Frustrated performance thresholds for this action type.
	Thresholds WebAppKeyPerformanceLoadThresholdsOutput `pulumi:"thresholds"`
}

// NewWebAppKeyPerformanceLoad registers a new resource with the given unique name, arguments, and options.
func NewWebAppKeyPerformanceLoad(ctx *pulumi.Context,
	name string, args *WebAppKeyPerformanceLoadArgs, opts ...pulumi.ResourceOption) (*WebAppKeyPerformanceLoad, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Kpm == nil {
		return nil, errors.New("invalid value for required argument 'Kpm'")
	}
	if args.Scope == nil {
		return nil, errors.New("invalid value for required argument 'Scope'")
	}
	if args.Thresholds == nil {
		return nil, errors.New("invalid value for required argument 'Thresholds'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource WebAppKeyPerformanceLoad
	err := ctx.RegisterResource("dynatrace:index/webAppKeyPerformanceLoad:WebAppKeyPerformanceLoad", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWebAppKeyPerformanceLoad gets an existing WebAppKeyPerformanceLoad resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWebAppKeyPerformanceLoad(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WebAppKeyPerformanceLoadState, opts ...pulumi.ResourceOption) (*WebAppKeyPerformanceLoad, error) {
	var resource WebAppKeyPerformanceLoad
	err := ctx.ReadResource("dynatrace:index/webAppKeyPerformanceLoad:WebAppKeyPerformanceLoad", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WebAppKeyPerformanceLoad resources.
type webAppKeyPerformanceLoadState struct {
	// If the selected key performance metric is not detected, the **User action duration** metric is used instead.
	FallbackThresholds *WebAppKeyPerformanceLoadFallbackThresholds `pulumi:"fallbackThresholds"`
	// Possible Values: `CUMULATIVE_LAYOUT_SHIFT`, `DOM_INTERACTIVE`, `FIRST_INPUT_DELAY`, `LARGEST_CONTENTFUL_PAINT`, `LOAD_EVENT_END`, `LOAD_EVENT_START`, `RESPONSE_END`, `RESPONSE_START`, `SPEED_INDEX`, `USER_ACTION_DURATION`, `VISUALLY_COMPLETE`
	Kpm *string `pulumi:"kpm"`
	// The scope of this setting (APPLICATION_METHOD, APPLICATION)
	Scope *string `pulumi:"scope"`
	// Set the Tolerating and Frustrated performance thresholds for this action type.
	Thresholds *WebAppKeyPerformanceLoadThresholds `pulumi:"thresholds"`
}

type WebAppKeyPerformanceLoadState struct {
	// If the selected key performance metric is not detected, the **User action duration** metric is used instead.
	FallbackThresholds WebAppKeyPerformanceLoadFallbackThresholdsPtrInput
	// Possible Values: `CUMULATIVE_LAYOUT_SHIFT`, `DOM_INTERACTIVE`, `FIRST_INPUT_DELAY`, `LARGEST_CONTENTFUL_PAINT`, `LOAD_EVENT_END`, `LOAD_EVENT_START`, `RESPONSE_END`, `RESPONSE_START`, `SPEED_INDEX`, `USER_ACTION_DURATION`, `VISUALLY_COMPLETE`
	Kpm pulumi.StringPtrInput
	// The scope of this setting (APPLICATION_METHOD, APPLICATION)
	Scope pulumi.StringPtrInput
	// Set the Tolerating and Frustrated performance thresholds for this action type.
	Thresholds WebAppKeyPerformanceLoadThresholdsPtrInput
}

func (WebAppKeyPerformanceLoadState) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppKeyPerformanceLoadState)(nil)).Elem()
}

type webAppKeyPerformanceLoadArgs struct {
	// If the selected key performance metric is not detected, the **User action duration** metric is used instead.
	FallbackThresholds *WebAppKeyPerformanceLoadFallbackThresholds `pulumi:"fallbackThresholds"`
	// Possible Values: `CUMULATIVE_LAYOUT_SHIFT`, `DOM_INTERACTIVE`, `FIRST_INPUT_DELAY`, `LARGEST_CONTENTFUL_PAINT`, `LOAD_EVENT_END`, `LOAD_EVENT_START`, `RESPONSE_END`, `RESPONSE_START`, `SPEED_INDEX`, `USER_ACTION_DURATION`, `VISUALLY_COMPLETE`
	Kpm string `pulumi:"kpm"`
	// The scope of this setting (APPLICATION_METHOD, APPLICATION)
	Scope string `pulumi:"scope"`
	// Set the Tolerating and Frustrated performance thresholds for this action type.
	Thresholds WebAppKeyPerformanceLoadThresholds `pulumi:"thresholds"`
}

// The set of arguments for constructing a WebAppKeyPerformanceLoad resource.
type WebAppKeyPerformanceLoadArgs struct {
	// If the selected key performance metric is not detected, the **User action duration** metric is used instead.
	FallbackThresholds WebAppKeyPerformanceLoadFallbackThresholdsPtrInput
	// Possible Values: `CUMULATIVE_LAYOUT_SHIFT`, `DOM_INTERACTIVE`, `FIRST_INPUT_DELAY`, `LARGEST_CONTENTFUL_PAINT`, `LOAD_EVENT_END`, `LOAD_EVENT_START`, `RESPONSE_END`, `RESPONSE_START`, `SPEED_INDEX`, `USER_ACTION_DURATION`, `VISUALLY_COMPLETE`
	Kpm pulumi.StringInput
	// The scope of this setting (APPLICATION_METHOD, APPLICATION)
	Scope pulumi.StringInput
	// Set the Tolerating and Frustrated performance thresholds for this action type.
	Thresholds WebAppKeyPerformanceLoadThresholdsInput
}

func (WebAppKeyPerformanceLoadArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppKeyPerformanceLoadArgs)(nil)).Elem()
}

type WebAppKeyPerformanceLoadInput interface {
	pulumi.Input

	ToWebAppKeyPerformanceLoadOutput() WebAppKeyPerformanceLoadOutput
	ToWebAppKeyPerformanceLoadOutputWithContext(ctx context.Context) WebAppKeyPerformanceLoadOutput
}

func (*WebAppKeyPerformanceLoad) ElementType() reflect.Type {
	return reflect.TypeOf((**WebAppKeyPerformanceLoad)(nil)).Elem()
}

func (i *WebAppKeyPerformanceLoad) ToWebAppKeyPerformanceLoadOutput() WebAppKeyPerformanceLoadOutput {
	return i.ToWebAppKeyPerformanceLoadOutputWithContext(context.Background())
}

func (i *WebAppKeyPerformanceLoad) ToWebAppKeyPerformanceLoadOutputWithContext(ctx context.Context) WebAppKeyPerformanceLoadOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebAppKeyPerformanceLoadOutput)
}

// WebAppKeyPerformanceLoadArrayInput is an input type that accepts WebAppKeyPerformanceLoadArray and WebAppKeyPerformanceLoadArrayOutput values.
// You can construct a concrete instance of `WebAppKeyPerformanceLoadArrayInput` via:
//
//	WebAppKeyPerformanceLoadArray{ WebAppKeyPerformanceLoadArgs{...} }
type WebAppKeyPerformanceLoadArrayInput interface {
	pulumi.Input

	ToWebAppKeyPerformanceLoadArrayOutput() WebAppKeyPerformanceLoadArrayOutput
	ToWebAppKeyPerformanceLoadArrayOutputWithContext(context.Context) WebAppKeyPerformanceLoadArrayOutput
}

type WebAppKeyPerformanceLoadArray []WebAppKeyPerformanceLoadInput

func (WebAppKeyPerformanceLoadArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*WebAppKeyPerformanceLoad)(nil)).Elem()
}

func (i WebAppKeyPerformanceLoadArray) ToWebAppKeyPerformanceLoadArrayOutput() WebAppKeyPerformanceLoadArrayOutput {
	return i.ToWebAppKeyPerformanceLoadArrayOutputWithContext(context.Background())
}

func (i WebAppKeyPerformanceLoadArray) ToWebAppKeyPerformanceLoadArrayOutputWithContext(ctx context.Context) WebAppKeyPerformanceLoadArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebAppKeyPerformanceLoadArrayOutput)
}

// WebAppKeyPerformanceLoadMapInput is an input type that accepts WebAppKeyPerformanceLoadMap and WebAppKeyPerformanceLoadMapOutput values.
// You can construct a concrete instance of `WebAppKeyPerformanceLoadMapInput` via:
//
//	WebAppKeyPerformanceLoadMap{ "key": WebAppKeyPerformanceLoadArgs{...} }
type WebAppKeyPerformanceLoadMapInput interface {
	pulumi.Input

	ToWebAppKeyPerformanceLoadMapOutput() WebAppKeyPerformanceLoadMapOutput
	ToWebAppKeyPerformanceLoadMapOutputWithContext(context.Context) WebAppKeyPerformanceLoadMapOutput
}

type WebAppKeyPerformanceLoadMap map[string]WebAppKeyPerformanceLoadInput

func (WebAppKeyPerformanceLoadMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*WebAppKeyPerformanceLoad)(nil)).Elem()
}

func (i WebAppKeyPerformanceLoadMap) ToWebAppKeyPerformanceLoadMapOutput() WebAppKeyPerformanceLoadMapOutput {
	return i.ToWebAppKeyPerformanceLoadMapOutputWithContext(context.Background())
}

func (i WebAppKeyPerformanceLoadMap) ToWebAppKeyPerformanceLoadMapOutputWithContext(ctx context.Context) WebAppKeyPerformanceLoadMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebAppKeyPerformanceLoadMapOutput)
}

type WebAppKeyPerformanceLoadOutput struct{ *pulumi.OutputState }

func (WebAppKeyPerformanceLoadOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**WebAppKeyPerformanceLoad)(nil)).Elem()
}

func (o WebAppKeyPerformanceLoadOutput) ToWebAppKeyPerformanceLoadOutput() WebAppKeyPerformanceLoadOutput {
	return o
}

func (o WebAppKeyPerformanceLoadOutput) ToWebAppKeyPerformanceLoadOutputWithContext(ctx context.Context) WebAppKeyPerformanceLoadOutput {
	return o
}

// If the selected key performance metric is not detected, the **User action duration** metric is used instead.
func (o WebAppKeyPerformanceLoadOutput) FallbackThresholds() WebAppKeyPerformanceLoadFallbackThresholdsPtrOutput {
	return o.ApplyT(func(v *WebAppKeyPerformanceLoad) WebAppKeyPerformanceLoadFallbackThresholdsPtrOutput {
		return v.FallbackThresholds
	}).(WebAppKeyPerformanceLoadFallbackThresholdsPtrOutput)
}

// Possible Values: `CUMULATIVE_LAYOUT_SHIFT`, `DOM_INTERACTIVE`, `FIRST_INPUT_DELAY`, `LARGEST_CONTENTFUL_PAINT`, `LOAD_EVENT_END`, `LOAD_EVENT_START`, `RESPONSE_END`, `RESPONSE_START`, `SPEED_INDEX`, `USER_ACTION_DURATION`, `VISUALLY_COMPLETE`
func (o WebAppKeyPerformanceLoadOutput) Kpm() pulumi.StringOutput {
	return o.ApplyT(func(v *WebAppKeyPerformanceLoad) pulumi.StringOutput { return v.Kpm }).(pulumi.StringOutput)
}

// The scope of this setting (APPLICATION_METHOD, APPLICATION)
func (o WebAppKeyPerformanceLoadOutput) Scope() pulumi.StringOutput {
	return o.ApplyT(func(v *WebAppKeyPerformanceLoad) pulumi.StringOutput { return v.Scope }).(pulumi.StringOutput)
}

// Set the Tolerating and Frustrated performance thresholds for this action type.
func (o WebAppKeyPerformanceLoadOutput) Thresholds() WebAppKeyPerformanceLoadThresholdsOutput {
	return o.ApplyT(func(v *WebAppKeyPerformanceLoad) WebAppKeyPerformanceLoadThresholdsOutput { return v.Thresholds }).(WebAppKeyPerformanceLoadThresholdsOutput)
}

type WebAppKeyPerformanceLoadArrayOutput struct{ *pulumi.OutputState }

func (WebAppKeyPerformanceLoadArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*WebAppKeyPerformanceLoad)(nil)).Elem()
}

func (o WebAppKeyPerformanceLoadArrayOutput) ToWebAppKeyPerformanceLoadArrayOutput() WebAppKeyPerformanceLoadArrayOutput {
	return o
}

func (o WebAppKeyPerformanceLoadArrayOutput) ToWebAppKeyPerformanceLoadArrayOutputWithContext(ctx context.Context) WebAppKeyPerformanceLoadArrayOutput {
	return o
}

func (o WebAppKeyPerformanceLoadArrayOutput) Index(i pulumi.IntInput) WebAppKeyPerformanceLoadOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *WebAppKeyPerformanceLoad {
		return vs[0].([]*WebAppKeyPerformanceLoad)[vs[1].(int)]
	}).(WebAppKeyPerformanceLoadOutput)
}

type WebAppKeyPerformanceLoadMapOutput struct{ *pulumi.OutputState }

func (WebAppKeyPerformanceLoadMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*WebAppKeyPerformanceLoad)(nil)).Elem()
}

func (o WebAppKeyPerformanceLoadMapOutput) ToWebAppKeyPerformanceLoadMapOutput() WebAppKeyPerformanceLoadMapOutput {
	return o
}

func (o WebAppKeyPerformanceLoadMapOutput) ToWebAppKeyPerformanceLoadMapOutputWithContext(ctx context.Context) WebAppKeyPerformanceLoadMapOutput {
	return o
}

func (o WebAppKeyPerformanceLoadMapOutput) MapIndex(k pulumi.StringInput) WebAppKeyPerformanceLoadOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *WebAppKeyPerformanceLoad {
		return vs[0].(map[string]*WebAppKeyPerformanceLoad)[vs[1].(string)]
	}).(WebAppKeyPerformanceLoadOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*WebAppKeyPerformanceLoadInput)(nil)).Elem(), &WebAppKeyPerformanceLoad{})
	pulumi.RegisterInputType(reflect.TypeOf((*WebAppKeyPerformanceLoadArrayInput)(nil)).Elem(), WebAppKeyPerformanceLoadArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*WebAppKeyPerformanceLoadMapInput)(nil)).Elem(), WebAppKeyPerformanceLoadMap{})
	pulumi.RegisterOutputType(WebAppKeyPerformanceLoadOutput{})
	pulumi.RegisterOutputType(WebAppKeyPerformanceLoadArrayOutput{})
	pulumi.RegisterOutputType(WebAppKeyPerformanceLoadMapOutput{})
}
