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

type MobileApplication struct {
	pulumi.CustomResourceState

	// Apdex configuration of a mobile application. A duration less than the **tolerable** threshold is considered satisfied
	Apdex MobileApplicationApdexOutput `pulumi:"apdex"`
	// The UUID of the application.
	ApplicationId pulumi.StringPtrOutput `pulumi:"applicationId"`
	// The type of the application. Either `CUSTOM_APPLICATION` or `MOBILE_APPLICATION`.
	ApplicationType pulumi.StringPtrOutput `pulumi:"applicationType"`
	// The type of the beacon endpoint. Possible values are `CLUSTER_ACTIVE_GATE`, `ENVIRONMENT_ACTIVE_GATE` and `INSTRUMENTED_WEB_SERVER`.
	BeaconEndpointType pulumi.StringOutput `pulumi:"beaconEndpointType"`
	// The URL of the beacon endpoint. Only applicable when the **beacon_endpoint_type** is set to `ENVIRONMENT_ACTIVE_GATE` or
	// `INSTRUMENTED_WEB_SERVER`
	BeaconEndpointUrl pulumi.StringPtrOutput `pulumi:"beaconEndpointUrl"`
	// Custom application icon. Mobile apps always use the mobile device icon, so this icon can only be set for custom apps.
	IconType pulumi.StringPtrOutput `pulumi:"iconType"`
	// User Action names to be flagged as Key User Actions
	KeyUserActions pulumi.StringArrayOutput `pulumi:"keyUserActions"`
	// The name of the reported value
	Name pulumi.StringOutput `pulumi:"name"`
	// The opt-in mode is enabled (`true`) or disabled (`false`)
	OptInMode pulumi.BoolPtrOutput `pulumi:"optInMode"`
	// User Action and Session Properties
	Properties MobileApplicationPropertiesPtrOutput `pulumi:"properties"`
	// (Field has overlap with `dynatrace_mobile_app_enablement`) The session replay is enabled (`true`) or disabled (`false`).
	SessionReplay pulumi.BoolPtrOutput `pulumi:"sessionReplay"`
	// The session replay on crash is enabled (`true`) or disabled (`false`). Enabling requires both **sessionReplayEnabled**
	// and **optInModeEnabled** values set to `true`.
	SessionReplayOnCrash pulumi.BoolPtrOutput `pulumi:"sessionReplayOnCrash"`
	// (Field has overlap with `dynatrace_mobile_app_enablement` for mobile and `dynatrace_custom_app_enablement` for custom
	// apps) The percentage of user sessions to be analyzed
	UserSessionPercentage pulumi.IntPtrOutput `pulumi:"userSessionPercentage"`
}

// NewMobileApplication registers a new resource with the given unique name, arguments, and options.
func NewMobileApplication(ctx *pulumi.Context,
	name string, args *MobileApplicationArgs, opts ...pulumi.ResourceOption) (*MobileApplication, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Apdex == nil {
		return nil, errors.New("invalid value for required argument 'Apdex'")
	}
	if args.BeaconEndpointType == nil {
		return nil, errors.New("invalid value for required argument 'BeaconEndpointType'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource MobileApplication
	err := ctx.RegisterResource("dynatrace:index/mobileApplication:MobileApplication", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMobileApplication gets an existing MobileApplication resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMobileApplication(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MobileApplicationState, opts ...pulumi.ResourceOption) (*MobileApplication, error) {
	var resource MobileApplication
	err := ctx.ReadResource("dynatrace:index/mobileApplication:MobileApplication", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering MobileApplication resources.
type mobileApplicationState struct {
	// Apdex configuration of a mobile application. A duration less than the **tolerable** threshold is considered satisfied
	Apdex *MobileApplicationApdex `pulumi:"apdex"`
	// The UUID of the application.
	ApplicationId *string `pulumi:"applicationId"`
	// The type of the application. Either `CUSTOM_APPLICATION` or `MOBILE_APPLICATION`.
	ApplicationType *string `pulumi:"applicationType"`
	// The type of the beacon endpoint. Possible values are `CLUSTER_ACTIVE_GATE`, `ENVIRONMENT_ACTIVE_GATE` and `INSTRUMENTED_WEB_SERVER`.
	BeaconEndpointType *string `pulumi:"beaconEndpointType"`
	// The URL of the beacon endpoint. Only applicable when the **beacon_endpoint_type** is set to `ENVIRONMENT_ACTIVE_GATE` or
	// `INSTRUMENTED_WEB_SERVER`
	BeaconEndpointUrl *string `pulumi:"beaconEndpointUrl"`
	// Custom application icon. Mobile apps always use the mobile device icon, so this icon can only be set for custom apps.
	IconType *string `pulumi:"iconType"`
	// User Action names to be flagged as Key User Actions
	KeyUserActions []string `pulumi:"keyUserActions"`
	// The name of the reported value
	Name *string `pulumi:"name"`
	// The opt-in mode is enabled (`true`) or disabled (`false`)
	OptInMode *bool `pulumi:"optInMode"`
	// User Action and Session Properties
	Properties *MobileApplicationProperties `pulumi:"properties"`
	// (Field has overlap with `dynatrace_mobile_app_enablement`) The session replay is enabled (`true`) or disabled (`false`).
	SessionReplay *bool `pulumi:"sessionReplay"`
	// The session replay on crash is enabled (`true`) or disabled (`false`). Enabling requires both **sessionReplayEnabled**
	// and **optInModeEnabled** values set to `true`.
	SessionReplayOnCrash *bool `pulumi:"sessionReplayOnCrash"`
	// (Field has overlap with `dynatrace_mobile_app_enablement` for mobile and `dynatrace_custom_app_enablement` for custom
	// apps) The percentage of user sessions to be analyzed
	UserSessionPercentage *int `pulumi:"userSessionPercentage"`
}

type MobileApplicationState struct {
	// Apdex configuration of a mobile application. A duration less than the **tolerable** threshold is considered satisfied
	Apdex MobileApplicationApdexPtrInput
	// The UUID of the application.
	ApplicationId pulumi.StringPtrInput
	// The type of the application. Either `CUSTOM_APPLICATION` or `MOBILE_APPLICATION`.
	ApplicationType pulumi.StringPtrInput
	// The type of the beacon endpoint. Possible values are `CLUSTER_ACTIVE_GATE`, `ENVIRONMENT_ACTIVE_GATE` and `INSTRUMENTED_WEB_SERVER`.
	BeaconEndpointType pulumi.StringPtrInput
	// The URL of the beacon endpoint. Only applicable when the **beacon_endpoint_type** is set to `ENVIRONMENT_ACTIVE_GATE` or
	// `INSTRUMENTED_WEB_SERVER`
	BeaconEndpointUrl pulumi.StringPtrInput
	// Custom application icon. Mobile apps always use the mobile device icon, so this icon can only be set for custom apps.
	IconType pulumi.StringPtrInput
	// User Action names to be flagged as Key User Actions
	KeyUserActions pulumi.StringArrayInput
	// The name of the reported value
	Name pulumi.StringPtrInput
	// The opt-in mode is enabled (`true`) or disabled (`false`)
	OptInMode pulumi.BoolPtrInput
	// User Action and Session Properties
	Properties MobileApplicationPropertiesPtrInput
	// (Field has overlap with `dynatrace_mobile_app_enablement`) The session replay is enabled (`true`) or disabled (`false`).
	SessionReplay pulumi.BoolPtrInput
	// The session replay on crash is enabled (`true`) or disabled (`false`). Enabling requires both **sessionReplayEnabled**
	// and **optInModeEnabled** values set to `true`.
	SessionReplayOnCrash pulumi.BoolPtrInput
	// (Field has overlap with `dynatrace_mobile_app_enablement` for mobile and `dynatrace_custom_app_enablement` for custom
	// apps) The percentage of user sessions to be analyzed
	UserSessionPercentage pulumi.IntPtrInput
}

func (MobileApplicationState) ElementType() reflect.Type {
	return reflect.TypeOf((*mobileApplicationState)(nil)).Elem()
}

type mobileApplicationArgs struct {
	// Apdex configuration of a mobile application. A duration less than the **tolerable** threshold is considered satisfied
	Apdex MobileApplicationApdex `pulumi:"apdex"`
	// The UUID of the application.
	ApplicationId *string `pulumi:"applicationId"`
	// The type of the application. Either `CUSTOM_APPLICATION` or `MOBILE_APPLICATION`.
	ApplicationType *string `pulumi:"applicationType"`
	// The type of the beacon endpoint. Possible values are `CLUSTER_ACTIVE_GATE`, `ENVIRONMENT_ACTIVE_GATE` and `INSTRUMENTED_WEB_SERVER`.
	BeaconEndpointType string `pulumi:"beaconEndpointType"`
	// The URL of the beacon endpoint. Only applicable when the **beacon_endpoint_type** is set to `ENVIRONMENT_ACTIVE_GATE` or
	// `INSTRUMENTED_WEB_SERVER`
	BeaconEndpointUrl *string `pulumi:"beaconEndpointUrl"`
	// Custom application icon. Mobile apps always use the mobile device icon, so this icon can only be set for custom apps.
	IconType *string `pulumi:"iconType"`
	// User Action names to be flagged as Key User Actions
	KeyUserActions []string `pulumi:"keyUserActions"`
	// The name of the reported value
	Name *string `pulumi:"name"`
	// The opt-in mode is enabled (`true`) or disabled (`false`)
	OptInMode *bool `pulumi:"optInMode"`
	// User Action and Session Properties
	Properties *MobileApplicationProperties `pulumi:"properties"`
	// (Field has overlap with `dynatrace_mobile_app_enablement`) The session replay is enabled (`true`) or disabled (`false`).
	SessionReplay *bool `pulumi:"sessionReplay"`
	// The session replay on crash is enabled (`true`) or disabled (`false`). Enabling requires both **sessionReplayEnabled**
	// and **optInModeEnabled** values set to `true`.
	SessionReplayOnCrash *bool `pulumi:"sessionReplayOnCrash"`
	// (Field has overlap with `dynatrace_mobile_app_enablement` for mobile and `dynatrace_custom_app_enablement` for custom
	// apps) The percentage of user sessions to be analyzed
	UserSessionPercentage *int `pulumi:"userSessionPercentage"`
}

// The set of arguments for constructing a MobileApplication resource.
type MobileApplicationArgs struct {
	// Apdex configuration of a mobile application. A duration less than the **tolerable** threshold is considered satisfied
	Apdex MobileApplicationApdexInput
	// The UUID of the application.
	ApplicationId pulumi.StringPtrInput
	// The type of the application. Either `CUSTOM_APPLICATION` or `MOBILE_APPLICATION`.
	ApplicationType pulumi.StringPtrInput
	// The type of the beacon endpoint. Possible values are `CLUSTER_ACTIVE_GATE`, `ENVIRONMENT_ACTIVE_GATE` and `INSTRUMENTED_WEB_SERVER`.
	BeaconEndpointType pulumi.StringInput
	// The URL of the beacon endpoint. Only applicable when the **beacon_endpoint_type** is set to `ENVIRONMENT_ACTIVE_GATE` or
	// `INSTRUMENTED_WEB_SERVER`
	BeaconEndpointUrl pulumi.StringPtrInput
	// Custom application icon. Mobile apps always use the mobile device icon, so this icon can only be set for custom apps.
	IconType pulumi.StringPtrInput
	// User Action names to be flagged as Key User Actions
	KeyUserActions pulumi.StringArrayInput
	// The name of the reported value
	Name pulumi.StringPtrInput
	// The opt-in mode is enabled (`true`) or disabled (`false`)
	OptInMode pulumi.BoolPtrInput
	// User Action and Session Properties
	Properties MobileApplicationPropertiesPtrInput
	// (Field has overlap with `dynatrace_mobile_app_enablement`) The session replay is enabled (`true`) or disabled (`false`).
	SessionReplay pulumi.BoolPtrInput
	// The session replay on crash is enabled (`true`) or disabled (`false`). Enabling requires both **sessionReplayEnabled**
	// and **optInModeEnabled** values set to `true`.
	SessionReplayOnCrash pulumi.BoolPtrInput
	// (Field has overlap with `dynatrace_mobile_app_enablement` for mobile and `dynatrace_custom_app_enablement` for custom
	// apps) The percentage of user sessions to be analyzed
	UserSessionPercentage pulumi.IntPtrInput
}

func (MobileApplicationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*mobileApplicationArgs)(nil)).Elem()
}

type MobileApplicationInput interface {
	pulumi.Input

	ToMobileApplicationOutput() MobileApplicationOutput
	ToMobileApplicationOutputWithContext(ctx context.Context) MobileApplicationOutput
}

func (*MobileApplication) ElementType() reflect.Type {
	return reflect.TypeOf((**MobileApplication)(nil)).Elem()
}

func (i *MobileApplication) ToMobileApplicationOutput() MobileApplicationOutput {
	return i.ToMobileApplicationOutputWithContext(context.Background())
}

func (i *MobileApplication) ToMobileApplicationOutputWithContext(ctx context.Context) MobileApplicationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MobileApplicationOutput)
}

// MobileApplicationArrayInput is an input type that accepts MobileApplicationArray and MobileApplicationArrayOutput values.
// You can construct a concrete instance of `MobileApplicationArrayInput` via:
//
//	MobileApplicationArray{ MobileApplicationArgs{...} }
type MobileApplicationArrayInput interface {
	pulumi.Input

	ToMobileApplicationArrayOutput() MobileApplicationArrayOutput
	ToMobileApplicationArrayOutputWithContext(context.Context) MobileApplicationArrayOutput
}

type MobileApplicationArray []MobileApplicationInput

func (MobileApplicationArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*MobileApplication)(nil)).Elem()
}

func (i MobileApplicationArray) ToMobileApplicationArrayOutput() MobileApplicationArrayOutput {
	return i.ToMobileApplicationArrayOutputWithContext(context.Background())
}

func (i MobileApplicationArray) ToMobileApplicationArrayOutputWithContext(ctx context.Context) MobileApplicationArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MobileApplicationArrayOutput)
}

// MobileApplicationMapInput is an input type that accepts MobileApplicationMap and MobileApplicationMapOutput values.
// You can construct a concrete instance of `MobileApplicationMapInput` via:
//
//	MobileApplicationMap{ "key": MobileApplicationArgs{...} }
type MobileApplicationMapInput interface {
	pulumi.Input

	ToMobileApplicationMapOutput() MobileApplicationMapOutput
	ToMobileApplicationMapOutputWithContext(context.Context) MobileApplicationMapOutput
}

type MobileApplicationMap map[string]MobileApplicationInput

func (MobileApplicationMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*MobileApplication)(nil)).Elem()
}

func (i MobileApplicationMap) ToMobileApplicationMapOutput() MobileApplicationMapOutput {
	return i.ToMobileApplicationMapOutputWithContext(context.Background())
}

func (i MobileApplicationMap) ToMobileApplicationMapOutputWithContext(ctx context.Context) MobileApplicationMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MobileApplicationMapOutput)
}

type MobileApplicationOutput struct{ *pulumi.OutputState }

func (MobileApplicationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**MobileApplication)(nil)).Elem()
}

func (o MobileApplicationOutput) ToMobileApplicationOutput() MobileApplicationOutput {
	return o
}

func (o MobileApplicationOutput) ToMobileApplicationOutputWithContext(ctx context.Context) MobileApplicationOutput {
	return o
}

// Apdex configuration of a mobile application. A duration less than the **tolerable** threshold is considered satisfied
func (o MobileApplicationOutput) Apdex() MobileApplicationApdexOutput {
	return o.ApplyT(func(v *MobileApplication) MobileApplicationApdexOutput { return v.Apdex }).(MobileApplicationApdexOutput)
}

// The UUID of the application.
func (o MobileApplicationOutput) ApplicationId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *MobileApplication) pulumi.StringPtrOutput { return v.ApplicationId }).(pulumi.StringPtrOutput)
}

// The type of the application. Either `CUSTOM_APPLICATION` or `MOBILE_APPLICATION`.
func (o MobileApplicationOutput) ApplicationType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *MobileApplication) pulumi.StringPtrOutput { return v.ApplicationType }).(pulumi.StringPtrOutput)
}

// The type of the beacon endpoint. Possible values are `CLUSTER_ACTIVE_GATE`, `ENVIRONMENT_ACTIVE_GATE` and `INSTRUMENTED_WEB_SERVER`.
func (o MobileApplicationOutput) BeaconEndpointType() pulumi.StringOutput {
	return o.ApplyT(func(v *MobileApplication) pulumi.StringOutput { return v.BeaconEndpointType }).(pulumi.StringOutput)
}

// The URL of the beacon endpoint. Only applicable when the **beacon_endpoint_type** is set to `ENVIRONMENT_ACTIVE_GATE` or
// `INSTRUMENTED_WEB_SERVER`
func (o MobileApplicationOutput) BeaconEndpointUrl() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *MobileApplication) pulumi.StringPtrOutput { return v.BeaconEndpointUrl }).(pulumi.StringPtrOutput)
}

// Custom application icon. Mobile apps always use the mobile device icon, so this icon can only be set for custom apps.
func (o MobileApplicationOutput) IconType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *MobileApplication) pulumi.StringPtrOutput { return v.IconType }).(pulumi.StringPtrOutput)
}

// User Action names to be flagged as Key User Actions
func (o MobileApplicationOutput) KeyUserActions() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *MobileApplication) pulumi.StringArrayOutput { return v.KeyUserActions }).(pulumi.StringArrayOutput)
}

// The name of the reported value
func (o MobileApplicationOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *MobileApplication) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// The opt-in mode is enabled (`true`) or disabled (`false`)
func (o MobileApplicationOutput) OptInMode() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *MobileApplication) pulumi.BoolPtrOutput { return v.OptInMode }).(pulumi.BoolPtrOutput)
}

// User Action and Session Properties
func (o MobileApplicationOutput) Properties() MobileApplicationPropertiesPtrOutput {
	return o.ApplyT(func(v *MobileApplication) MobileApplicationPropertiesPtrOutput { return v.Properties }).(MobileApplicationPropertiesPtrOutput)
}

// (Field has overlap with `dynatrace_mobile_app_enablement`) The session replay is enabled (`true`) or disabled (`false`).
func (o MobileApplicationOutput) SessionReplay() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *MobileApplication) pulumi.BoolPtrOutput { return v.SessionReplay }).(pulumi.BoolPtrOutput)
}

// The session replay on crash is enabled (`true`) or disabled (`false`). Enabling requires both **sessionReplayEnabled**
// and **optInModeEnabled** values set to `true`.
func (o MobileApplicationOutput) SessionReplayOnCrash() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *MobileApplication) pulumi.BoolPtrOutput { return v.SessionReplayOnCrash }).(pulumi.BoolPtrOutput)
}

// (Field has overlap with `dynatrace_mobile_app_enablement` for mobile and `dynatrace_custom_app_enablement` for custom
// apps) The percentage of user sessions to be analyzed
func (o MobileApplicationOutput) UserSessionPercentage() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *MobileApplication) pulumi.IntPtrOutput { return v.UserSessionPercentage }).(pulumi.IntPtrOutput)
}

type MobileApplicationArrayOutput struct{ *pulumi.OutputState }

func (MobileApplicationArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*MobileApplication)(nil)).Elem()
}

func (o MobileApplicationArrayOutput) ToMobileApplicationArrayOutput() MobileApplicationArrayOutput {
	return o
}

func (o MobileApplicationArrayOutput) ToMobileApplicationArrayOutputWithContext(ctx context.Context) MobileApplicationArrayOutput {
	return o
}

func (o MobileApplicationArrayOutput) Index(i pulumi.IntInput) MobileApplicationOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *MobileApplication {
		return vs[0].([]*MobileApplication)[vs[1].(int)]
	}).(MobileApplicationOutput)
}

type MobileApplicationMapOutput struct{ *pulumi.OutputState }

func (MobileApplicationMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*MobileApplication)(nil)).Elem()
}

func (o MobileApplicationMapOutput) ToMobileApplicationMapOutput() MobileApplicationMapOutput {
	return o
}

func (o MobileApplicationMapOutput) ToMobileApplicationMapOutputWithContext(ctx context.Context) MobileApplicationMapOutput {
	return o
}

func (o MobileApplicationMapOutput) MapIndex(k pulumi.StringInput) MobileApplicationOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *MobileApplication {
		return vs[0].(map[string]*MobileApplication)[vs[1].(string)]
	}).(MobileApplicationOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*MobileApplicationInput)(nil)).Elem(), &MobileApplication{})
	pulumi.RegisterInputType(reflect.TypeOf((*MobileApplicationArrayInput)(nil)).Elem(), MobileApplicationArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*MobileApplicationMapInput)(nil)).Elem(), MobileApplicationMap{})
	pulumi.RegisterOutputType(MobileApplicationOutput{})
	pulumi.RegisterOutputType(MobileApplicationArrayOutput{})
	pulumi.RegisterOutputType(MobileApplicationMapOutput{})
}