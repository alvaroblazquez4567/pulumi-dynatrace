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

type AgToken struct {
	pulumi.CustomResourceState

	// The expiration date of the token. You can use one of the following formats: * Timestamp in UTC milliseconds. *
	// Human-readable format of 2021-01-25T05:57:01.123+01:00. If no time zone is specified, UTC is used. You can use a space
	// character instead of the T. Seconds and fractions of a second are optional. * Relative timeframe, back from now. The
	// format is now-NU/A, where N is the amount of time, U is the unit of time, and A is an alignment. The alignment rounds
	// all the smaller values to the nearest zero in the past. For example, now-1y/w is one year back, aligned by a week. You
	// can also specify relative timeframe without an alignment: now-NU. Supported time units for the relative timeframe are: -
	// m: minutes - h: hours - d: days - w: weeks - M: months - y: years
	ExpirationDate pulumi.StringPtrOutput `pulumi:"expirationDate"`
	// The name of the token.
	Name pulumi.StringOutput `pulumi:"name"`
	// The token is a seed token (true) or an individual token (false). We recommend the individual token option (false)
	Seed pulumi.BoolPtrOutput `pulumi:"seed"`
	// The tenant token. This information isn't directly related to the Active Gate Token. It's included for convenience. You
	// require the permission `InstallerDownload` for that attribute to get populated
	TenantToken pulumi.StringOutput `pulumi:"tenantToken"`
	// The secret of the token.
	Token pulumi.StringOutput `pulumi:"token"`
	// The type of the ActiveGate for which the token is valid. Possible values are `ENVIRONMENT` or `CLUSTER`
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewAgToken registers a new resource with the given unique name, arguments, and options.
func NewAgToken(ctx *pulumi.Context,
	name string, args *AgTokenArgs, opts ...pulumi.ResourceOption) (*AgToken, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Type == nil {
		return nil, errors.New("invalid value for required argument 'Type'")
	}
	secrets := pulumi.AdditionalSecretOutputs([]string{
		"tenantToken",
		"token",
	})
	opts = append(opts, secrets)
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource AgToken
	err := ctx.RegisterResource("dynatrace:index/agToken:AgToken", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAgToken gets an existing AgToken resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAgToken(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AgTokenState, opts ...pulumi.ResourceOption) (*AgToken, error) {
	var resource AgToken
	err := ctx.ReadResource("dynatrace:index/agToken:AgToken", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AgToken resources.
type agTokenState struct {
	// The expiration date of the token. You can use one of the following formats: * Timestamp in UTC milliseconds. *
	// Human-readable format of 2021-01-25T05:57:01.123+01:00. If no time zone is specified, UTC is used. You can use a space
	// character instead of the T. Seconds and fractions of a second are optional. * Relative timeframe, back from now. The
	// format is now-NU/A, where N is the amount of time, U is the unit of time, and A is an alignment. The alignment rounds
	// all the smaller values to the nearest zero in the past. For example, now-1y/w is one year back, aligned by a week. You
	// can also specify relative timeframe without an alignment: now-NU. Supported time units for the relative timeframe are: -
	// m: minutes - h: hours - d: days - w: weeks - M: months - y: years
	ExpirationDate *string `pulumi:"expirationDate"`
	// The name of the token.
	Name *string `pulumi:"name"`
	// The token is a seed token (true) or an individual token (false). We recommend the individual token option (false)
	Seed *bool `pulumi:"seed"`
	// The tenant token. This information isn't directly related to the Active Gate Token. It's included for convenience. You
	// require the permission `InstallerDownload` for that attribute to get populated
	TenantToken *string `pulumi:"tenantToken"`
	// The secret of the token.
	Token *string `pulumi:"token"`
	// The type of the ActiveGate for which the token is valid. Possible values are `ENVIRONMENT` or `CLUSTER`
	Type *string `pulumi:"type"`
}

type AgTokenState struct {
	// The expiration date of the token. You can use one of the following formats: * Timestamp in UTC milliseconds. *
	// Human-readable format of 2021-01-25T05:57:01.123+01:00. If no time zone is specified, UTC is used. You can use a space
	// character instead of the T. Seconds and fractions of a second are optional. * Relative timeframe, back from now. The
	// format is now-NU/A, where N is the amount of time, U is the unit of time, and A is an alignment. The alignment rounds
	// all the smaller values to the nearest zero in the past. For example, now-1y/w is one year back, aligned by a week. You
	// can also specify relative timeframe without an alignment: now-NU. Supported time units for the relative timeframe are: -
	// m: minutes - h: hours - d: days - w: weeks - M: months - y: years
	ExpirationDate pulumi.StringPtrInput
	// The name of the token.
	Name pulumi.StringPtrInput
	// The token is a seed token (true) or an individual token (false). We recommend the individual token option (false)
	Seed pulumi.BoolPtrInput
	// The tenant token. This information isn't directly related to the Active Gate Token. It's included for convenience. You
	// require the permission `InstallerDownload` for that attribute to get populated
	TenantToken pulumi.StringPtrInput
	// The secret of the token.
	Token pulumi.StringPtrInput
	// The type of the ActiveGate for which the token is valid. Possible values are `ENVIRONMENT` or `CLUSTER`
	Type pulumi.StringPtrInput
}

func (AgTokenState) ElementType() reflect.Type {
	return reflect.TypeOf((*agTokenState)(nil)).Elem()
}

type agTokenArgs struct {
	// The expiration date of the token. You can use one of the following formats: * Timestamp in UTC milliseconds. *
	// Human-readable format of 2021-01-25T05:57:01.123+01:00. If no time zone is specified, UTC is used. You can use a space
	// character instead of the T. Seconds and fractions of a second are optional. * Relative timeframe, back from now. The
	// format is now-NU/A, where N is the amount of time, U is the unit of time, and A is an alignment. The alignment rounds
	// all the smaller values to the nearest zero in the past. For example, now-1y/w is one year back, aligned by a week. You
	// can also specify relative timeframe without an alignment: now-NU. Supported time units for the relative timeframe are: -
	// m: minutes - h: hours - d: days - w: weeks - M: months - y: years
	ExpirationDate *string `pulumi:"expirationDate"`
	// The name of the token.
	Name *string `pulumi:"name"`
	// The token is a seed token (true) or an individual token (false). We recommend the individual token option (false)
	Seed *bool `pulumi:"seed"`
	// The type of the ActiveGate for which the token is valid. Possible values are `ENVIRONMENT` or `CLUSTER`
	Type string `pulumi:"type"`
}

// The set of arguments for constructing a AgToken resource.
type AgTokenArgs struct {
	// The expiration date of the token. You can use one of the following formats: * Timestamp in UTC milliseconds. *
	// Human-readable format of 2021-01-25T05:57:01.123+01:00. If no time zone is specified, UTC is used. You can use a space
	// character instead of the T. Seconds and fractions of a second are optional. * Relative timeframe, back from now. The
	// format is now-NU/A, where N is the amount of time, U is the unit of time, and A is an alignment. The alignment rounds
	// all the smaller values to the nearest zero in the past. For example, now-1y/w is one year back, aligned by a week. You
	// can also specify relative timeframe without an alignment: now-NU. Supported time units for the relative timeframe are: -
	// m: minutes - h: hours - d: days - w: weeks - M: months - y: years
	ExpirationDate pulumi.StringPtrInput
	// The name of the token.
	Name pulumi.StringPtrInput
	// The token is a seed token (true) or an individual token (false). We recommend the individual token option (false)
	Seed pulumi.BoolPtrInput
	// The type of the ActiveGate for which the token is valid. Possible values are `ENVIRONMENT` or `CLUSTER`
	Type pulumi.StringInput
}

func (AgTokenArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*agTokenArgs)(nil)).Elem()
}

type AgTokenInput interface {
	pulumi.Input

	ToAgTokenOutput() AgTokenOutput
	ToAgTokenOutputWithContext(ctx context.Context) AgTokenOutput
}

func (*AgToken) ElementType() reflect.Type {
	return reflect.TypeOf((**AgToken)(nil)).Elem()
}

func (i *AgToken) ToAgTokenOutput() AgTokenOutput {
	return i.ToAgTokenOutputWithContext(context.Background())
}

func (i *AgToken) ToAgTokenOutputWithContext(ctx context.Context) AgTokenOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AgTokenOutput)
}

// AgTokenArrayInput is an input type that accepts AgTokenArray and AgTokenArrayOutput values.
// You can construct a concrete instance of `AgTokenArrayInput` via:
//
//	AgTokenArray{ AgTokenArgs{...} }
type AgTokenArrayInput interface {
	pulumi.Input

	ToAgTokenArrayOutput() AgTokenArrayOutput
	ToAgTokenArrayOutputWithContext(context.Context) AgTokenArrayOutput
}

type AgTokenArray []AgTokenInput

func (AgTokenArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AgToken)(nil)).Elem()
}

func (i AgTokenArray) ToAgTokenArrayOutput() AgTokenArrayOutput {
	return i.ToAgTokenArrayOutputWithContext(context.Background())
}

func (i AgTokenArray) ToAgTokenArrayOutputWithContext(ctx context.Context) AgTokenArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AgTokenArrayOutput)
}

// AgTokenMapInput is an input type that accepts AgTokenMap and AgTokenMapOutput values.
// You can construct a concrete instance of `AgTokenMapInput` via:
//
//	AgTokenMap{ "key": AgTokenArgs{...} }
type AgTokenMapInput interface {
	pulumi.Input

	ToAgTokenMapOutput() AgTokenMapOutput
	ToAgTokenMapOutputWithContext(context.Context) AgTokenMapOutput
}

type AgTokenMap map[string]AgTokenInput

func (AgTokenMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AgToken)(nil)).Elem()
}

func (i AgTokenMap) ToAgTokenMapOutput() AgTokenMapOutput {
	return i.ToAgTokenMapOutputWithContext(context.Background())
}

func (i AgTokenMap) ToAgTokenMapOutputWithContext(ctx context.Context) AgTokenMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AgTokenMapOutput)
}

type AgTokenOutput struct{ *pulumi.OutputState }

func (AgTokenOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AgToken)(nil)).Elem()
}

func (o AgTokenOutput) ToAgTokenOutput() AgTokenOutput {
	return o
}

func (o AgTokenOutput) ToAgTokenOutputWithContext(ctx context.Context) AgTokenOutput {
	return o
}

// The expiration date of the token. You can use one of the following formats: * Timestamp in UTC milliseconds. *
// Human-readable format of 2021-01-25T05:57:01.123+01:00. If no time zone is specified, UTC is used. You can use a space
// character instead of the T. Seconds and fractions of a second are optional. * Relative timeframe, back from now. The
// format is now-NU/A, where N is the amount of time, U is the unit of time, and A is an alignment. The alignment rounds
// all the smaller values to the nearest zero in the past. For example, now-1y/w is one year back, aligned by a week. You
// can also specify relative timeframe without an alignment: now-NU. Supported time units for the relative timeframe are: -
// m: minutes - h: hours - d: days - w: weeks - M: months - y: years
func (o AgTokenOutput) ExpirationDate() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AgToken) pulumi.StringPtrOutput { return v.ExpirationDate }).(pulumi.StringPtrOutput)
}

// The name of the token.
func (o AgTokenOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *AgToken) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// The token is a seed token (true) or an individual token (false). We recommend the individual token option (false)
func (o AgTokenOutput) Seed() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *AgToken) pulumi.BoolPtrOutput { return v.Seed }).(pulumi.BoolPtrOutput)
}

// The tenant token. This information isn't directly related to the Active Gate Token. It's included for convenience. You
// require the permission `InstallerDownload` for that attribute to get populated
func (o AgTokenOutput) TenantToken() pulumi.StringOutput {
	return o.ApplyT(func(v *AgToken) pulumi.StringOutput { return v.TenantToken }).(pulumi.StringOutput)
}

// The secret of the token.
func (o AgTokenOutput) Token() pulumi.StringOutput {
	return o.ApplyT(func(v *AgToken) pulumi.StringOutput { return v.Token }).(pulumi.StringOutput)
}

// The type of the ActiveGate for which the token is valid. Possible values are `ENVIRONMENT` or `CLUSTER`
func (o AgTokenOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v *AgToken) pulumi.StringOutput { return v.Type }).(pulumi.StringOutput)
}

type AgTokenArrayOutput struct{ *pulumi.OutputState }

func (AgTokenArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AgToken)(nil)).Elem()
}

func (o AgTokenArrayOutput) ToAgTokenArrayOutput() AgTokenArrayOutput {
	return o
}

func (o AgTokenArrayOutput) ToAgTokenArrayOutputWithContext(ctx context.Context) AgTokenArrayOutput {
	return o
}

func (o AgTokenArrayOutput) Index(i pulumi.IntInput) AgTokenOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *AgToken {
		return vs[0].([]*AgToken)[vs[1].(int)]
	}).(AgTokenOutput)
}

type AgTokenMapOutput struct{ *pulumi.OutputState }

func (AgTokenMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AgToken)(nil)).Elem()
}

func (o AgTokenMapOutput) ToAgTokenMapOutput() AgTokenMapOutput {
	return o
}

func (o AgTokenMapOutput) ToAgTokenMapOutputWithContext(ctx context.Context) AgTokenMapOutput {
	return o
}

func (o AgTokenMapOutput) MapIndex(k pulumi.StringInput) AgTokenOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *AgToken {
		return vs[0].(map[string]*AgToken)[vs[1].(string)]
	}).(AgTokenOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*AgTokenInput)(nil)).Elem(), &AgToken{})
	pulumi.RegisterInputType(reflect.TypeOf((*AgTokenArrayInput)(nil)).Elem(), AgTokenArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*AgTokenMapInput)(nil)).Elem(), AgTokenMap{})
	pulumi.RegisterOutputType(AgTokenOutput{})
	pulumi.RegisterOutputType(AgTokenArrayOutput{})
	pulumi.RegisterOutputType(AgTokenMapOutput{})
}