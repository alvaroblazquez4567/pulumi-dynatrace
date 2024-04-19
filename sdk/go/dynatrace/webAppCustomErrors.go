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

type WebAppCustomErrors struct {
	pulumi.CustomResourceState

	// (Field has overlap with `ApplicationErrorRules`)
	ErrorRules WebAppCustomErrorsErrorRulesPtrOutput `pulumi:"errorRules"`
	// (Field has overlap with `ApplicationErrorRules`) This setting overrides Apdex settings for individual rules listed below
	IgnoreCustomErrorsInApdexCalculation pulumi.BoolOutput `pulumi:"ignoreCustomErrorsInApdexCalculation"`
	// The scope of this setting (APPLICATION)
	Scope pulumi.StringOutput `pulumi:"scope"`
}

// NewWebAppCustomErrors registers a new resource with the given unique name, arguments, and options.
func NewWebAppCustomErrors(ctx *pulumi.Context,
	name string, args *WebAppCustomErrorsArgs, opts ...pulumi.ResourceOption) (*WebAppCustomErrors, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.IgnoreCustomErrorsInApdexCalculation == nil {
		return nil, errors.New("invalid value for required argument 'IgnoreCustomErrorsInApdexCalculation'")
	}
	if args.Scope == nil {
		return nil, errors.New("invalid value for required argument 'Scope'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource WebAppCustomErrors
	err := ctx.RegisterResource("dynatrace:index/webAppCustomErrors:WebAppCustomErrors", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWebAppCustomErrors gets an existing WebAppCustomErrors resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWebAppCustomErrors(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WebAppCustomErrorsState, opts ...pulumi.ResourceOption) (*WebAppCustomErrors, error) {
	var resource WebAppCustomErrors
	err := ctx.ReadResource("dynatrace:index/webAppCustomErrors:WebAppCustomErrors", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WebAppCustomErrors resources.
type webAppCustomErrorsState struct {
	// (Field has overlap with `ApplicationErrorRules`)
	ErrorRules *WebAppCustomErrorsErrorRules `pulumi:"errorRules"`
	// (Field has overlap with `ApplicationErrorRules`) This setting overrides Apdex settings for individual rules listed below
	IgnoreCustomErrorsInApdexCalculation *bool `pulumi:"ignoreCustomErrorsInApdexCalculation"`
	// The scope of this setting (APPLICATION)
	Scope *string `pulumi:"scope"`
}

type WebAppCustomErrorsState struct {
	// (Field has overlap with `ApplicationErrorRules`)
	ErrorRules WebAppCustomErrorsErrorRulesPtrInput
	// (Field has overlap with `ApplicationErrorRules`) This setting overrides Apdex settings for individual rules listed below
	IgnoreCustomErrorsInApdexCalculation pulumi.BoolPtrInput
	// The scope of this setting (APPLICATION)
	Scope pulumi.StringPtrInput
}

func (WebAppCustomErrorsState) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppCustomErrorsState)(nil)).Elem()
}

type webAppCustomErrorsArgs struct {
	// (Field has overlap with `ApplicationErrorRules`)
	ErrorRules *WebAppCustomErrorsErrorRules `pulumi:"errorRules"`
	// (Field has overlap with `ApplicationErrorRules`) This setting overrides Apdex settings for individual rules listed below
	IgnoreCustomErrorsInApdexCalculation bool `pulumi:"ignoreCustomErrorsInApdexCalculation"`
	// The scope of this setting (APPLICATION)
	Scope string `pulumi:"scope"`
}

// The set of arguments for constructing a WebAppCustomErrors resource.
type WebAppCustomErrorsArgs struct {
	// (Field has overlap with `ApplicationErrorRules`)
	ErrorRules WebAppCustomErrorsErrorRulesPtrInput
	// (Field has overlap with `ApplicationErrorRules`) This setting overrides Apdex settings for individual rules listed below
	IgnoreCustomErrorsInApdexCalculation pulumi.BoolInput
	// The scope of this setting (APPLICATION)
	Scope pulumi.StringInput
}

func (WebAppCustomErrorsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppCustomErrorsArgs)(nil)).Elem()
}

type WebAppCustomErrorsInput interface {
	pulumi.Input

	ToWebAppCustomErrorsOutput() WebAppCustomErrorsOutput
	ToWebAppCustomErrorsOutputWithContext(ctx context.Context) WebAppCustomErrorsOutput
}

func (*WebAppCustomErrors) ElementType() reflect.Type {
	return reflect.TypeOf((**WebAppCustomErrors)(nil)).Elem()
}

func (i *WebAppCustomErrors) ToWebAppCustomErrorsOutput() WebAppCustomErrorsOutput {
	return i.ToWebAppCustomErrorsOutputWithContext(context.Background())
}

func (i *WebAppCustomErrors) ToWebAppCustomErrorsOutputWithContext(ctx context.Context) WebAppCustomErrorsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebAppCustomErrorsOutput)
}

// WebAppCustomErrorsArrayInput is an input type that accepts WebAppCustomErrorsArray and WebAppCustomErrorsArrayOutput values.
// You can construct a concrete instance of `WebAppCustomErrorsArrayInput` via:
//
//	WebAppCustomErrorsArray{ WebAppCustomErrorsArgs{...} }
type WebAppCustomErrorsArrayInput interface {
	pulumi.Input

	ToWebAppCustomErrorsArrayOutput() WebAppCustomErrorsArrayOutput
	ToWebAppCustomErrorsArrayOutputWithContext(context.Context) WebAppCustomErrorsArrayOutput
}

type WebAppCustomErrorsArray []WebAppCustomErrorsInput

func (WebAppCustomErrorsArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*WebAppCustomErrors)(nil)).Elem()
}

func (i WebAppCustomErrorsArray) ToWebAppCustomErrorsArrayOutput() WebAppCustomErrorsArrayOutput {
	return i.ToWebAppCustomErrorsArrayOutputWithContext(context.Background())
}

func (i WebAppCustomErrorsArray) ToWebAppCustomErrorsArrayOutputWithContext(ctx context.Context) WebAppCustomErrorsArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebAppCustomErrorsArrayOutput)
}

// WebAppCustomErrorsMapInput is an input type that accepts WebAppCustomErrorsMap and WebAppCustomErrorsMapOutput values.
// You can construct a concrete instance of `WebAppCustomErrorsMapInput` via:
//
//	WebAppCustomErrorsMap{ "key": WebAppCustomErrorsArgs{...} }
type WebAppCustomErrorsMapInput interface {
	pulumi.Input

	ToWebAppCustomErrorsMapOutput() WebAppCustomErrorsMapOutput
	ToWebAppCustomErrorsMapOutputWithContext(context.Context) WebAppCustomErrorsMapOutput
}

type WebAppCustomErrorsMap map[string]WebAppCustomErrorsInput

func (WebAppCustomErrorsMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*WebAppCustomErrors)(nil)).Elem()
}

func (i WebAppCustomErrorsMap) ToWebAppCustomErrorsMapOutput() WebAppCustomErrorsMapOutput {
	return i.ToWebAppCustomErrorsMapOutputWithContext(context.Background())
}

func (i WebAppCustomErrorsMap) ToWebAppCustomErrorsMapOutputWithContext(ctx context.Context) WebAppCustomErrorsMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebAppCustomErrorsMapOutput)
}

type WebAppCustomErrorsOutput struct{ *pulumi.OutputState }

func (WebAppCustomErrorsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**WebAppCustomErrors)(nil)).Elem()
}

func (o WebAppCustomErrorsOutput) ToWebAppCustomErrorsOutput() WebAppCustomErrorsOutput {
	return o
}

func (o WebAppCustomErrorsOutput) ToWebAppCustomErrorsOutputWithContext(ctx context.Context) WebAppCustomErrorsOutput {
	return o
}

// (Field has overlap with `ApplicationErrorRules`)
func (o WebAppCustomErrorsOutput) ErrorRules() WebAppCustomErrorsErrorRulesPtrOutput {
	return o.ApplyT(func(v *WebAppCustomErrors) WebAppCustomErrorsErrorRulesPtrOutput { return v.ErrorRules }).(WebAppCustomErrorsErrorRulesPtrOutput)
}

// (Field has overlap with `ApplicationErrorRules`) This setting overrides Apdex settings for individual rules listed below
func (o WebAppCustomErrorsOutput) IgnoreCustomErrorsInApdexCalculation() pulumi.BoolOutput {
	return o.ApplyT(func(v *WebAppCustomErrors) pulumi.BoolOutput { return v.IgnoreCustomErrorsInApdexCalculation }).(pulumi.BoolOutput)
}

// The scope of this setting (APPLICATION)
func (o WebAppCustomErrorsOutput) Scope() pulumi.StringOutput {
	return o.ApplyT(func(v *WebAppCustomErrors) pulumi.StringOutput { return v.Scope }).(pulumi.StringOutput)
}

type WebAppCustomErrorsArrayOutput struct{ *pulumi.OutputState }

func (WebAppCustomErrorsArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*WebAppCustomErrors)(nil)).Elem()
}

func (o WebAppCustomErrorsArrayOutput) ToWebAppCustomErrorsArrayOutput() WebAppCustomErrorsArrayOutput {
	return o
}

func (o WebAppCustomErrorsArrayOutput) ToWebAppCustomErrorsArrayOutputWithContext(ctx context.Context) WebAppCustomErrorsArrayOutput {
	return o
}

func (o WebAppCustomErrorsArrayOutput) Index(i pulumi.IntInput) WebAppCustomErrorsOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *WebAppCustomErrors {
		return vs[0].([]*WebAppCustomErrors)[vs[1].(int)]
	}).(WebAppCustomErrorsOutput)
}

type WebAppCustomErrorsMapOutput struct{ *pulumi.OutputState }

func (WebAppCustomErrorsMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*WebAppCustomErrors)(nil)).Elem()
}

func (o WebAppCustomErrorsMapOutput) ToWebAppCustomErrorsMapOutput() WebAppCustomErrorsMapOutput {
	return o
}

func (o WebAppCustomErrorsMapOutput) ToWebAppCustomErrorsMapOutputWithContext(ctx context.Context) WebAppCustomErrorsMapOutput {
	return o
}

func (o WebAppCustomErrorsMapOutput) MapIndex(k pulumi.StringInput) WebAppCustomErrorsOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *WebAppCustomErrors {
		return vs[0].(map[string]*WebAppCustomErrors)[vs[1].(string)]
	}).(WebAppCustomErrorsOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*WebAppCustomErrorsInput)(nil)).Elem(), &WebAppCustomErrors{})
	pulumi.RegisterInputType(reflect.TypeOf((*WebAppCustomErrorsArrayInput)(nil)).Elem(), WebAppCustomErrorsArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*WebAppCustomErrorsMapInput)(nil)).Elem(), WebAppCustomErrorsMap{})
	pulumi.RegisterOutputType(WebAppCustomErrorsOutput{})
	pulumi.RegisterOutputType(WebAppCustomErrorsArrayOutput{})
	pulumi.RegisterOutputType(WebAppCustomErrorsMapOutput{})
}
