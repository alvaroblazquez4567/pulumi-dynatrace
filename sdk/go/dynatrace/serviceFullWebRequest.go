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

type ServiceFullWebRequest struct {
	pulumi.CustomResourceState

	// A list of conditions necessary for the rule to take effect. If multiple conditions are specified, they must **all** match a Request for the rule to apply. If there is no condition at all, the rule is always applied. Conditions are evaluated against attributes, but do not modify them.
	Conditions ServiceFullWebRequestConditionsPtrOutput `pulumi:"conditions"`
	// Description
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolOutput `pulumi:"enabled"`
	// Contributors to the Service Identifier calculation. All of the Contributors are always applied.
	IdContributors ServiceFullWebRequestIdContributorsOutput `pulumi:"idContributors"`
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter pulumi.StringOutput `pulumi:"insertAfter"`
	// Define a management zone of the process group for which this service detection rule should be created.
	ManagementZones pulumi.StringArrayOutput `pulumi:"managementZones"`
	// Rule name
	Name pulumi.StringOutput `pulumi:"name"`
}

// NewServiceFullWebRequest registers a new resource with the given unique name, arguments, and options.
func NewServiceFullWebRequest(ctx *pulumi.Context,
	name string, args *ServiceFullWebRequestArgs, opts ...pulumi.ResourceOption) (*ServiceFullWebRequest, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Enabled == nil {
		return nil, errors.New("invalid value for required argument 'Enabled'")
	}
	if args.IdContributors == nil {
		return nil, errors.New("invalid value for required argument 'IdContributors'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource ServiceFullWebRequest
	err := ctx.RegisterResource("dynatrace:index/serviceFullWebRequest:ServiceFullWebRequest", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetServiceFullWebRequest gets an existing ServiceFullWebRequest resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetServiceFullWebRequest(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ServiceFullWebRequestState, opts ...pulumi.ResourceOption) (*ServiceFullWebRequest, error) {
	var resource ServiceFullWebRequest
	err := ctx.ReadResource("dynatrace:index/serviceFullWebRequest:ServiceFullWebRequest", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ServiceFullWebRequest resources.
type serviceFullWebRequestState struct {
	// A list of conditions necessary for the rule to take effect. If multiple conditions are specified, they must **all** match a Request for the rule to apply. If there is no condition at all, the rule is always applied. Conditions are evaluated against attributes, but do not modify them.
	Conditions *ServiceFullWebRequestConditions `pulumi:"conditions"`
	// Description
	Description *string `pulumi:"description"`
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled *bool `pulumi:"enabled"`
	// Contributors to the Service Identifier calculation. All of the Contributors are always applied.
	IdContributors *ServiceFullWebRequestIdContributors `pulumi:"idContributors"`
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter *string `pulumi:"insertAfter"`
	// Define a management zone of the process group for which this service detection rule should be created.
	ManagementZones []string `pulumi:"managementZones"`
	// Rule name
	Name *string `pulumi:"name"`
}

type ServiceFullWebRequestState struct {
	// A list of conditions necessary for the rule to take effect. If multiple conditions are specified, they must **all** match a Request for the rule to apply. If there is no condition at all, the rule is always applied. Conditions are evaluated against attributes, but do not modify them.
	Conditions ServiceFullWebRequestConditionsPtrInput
	// Description
	Description pulumi.StringPtrInput
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolPtrInput
	// Contributors to the Service Identifier calculation. All of the Contributors are always applied.
	IdContributors ServiceFullWebRequestIdContributorsPtrInput
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter pulumi.StringPtrInput
	// Define a management zone of the process group for which this service detection rule should be created.
	ManagementZones pulumi.StringArrayInput
	// Rule name
	Name pulumi.StringPtrInput
}

func (ServiceFullWebRequestState) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceFullWebRequestState)(nil)).Elem()
}

type serviceFullWebRequestArgs struct {
	// A list of conditions necessary for the rule to take effect. If multiple conditions are specified, they must **all** match a Request for the rule to apply. If there is no condition at all, the rule is always applied. Conditions are evaluated against attributes, but do not modify them.
	Conditions *ServiceFullWebRequestConditions `pulumi:"conditions"`
	// Description
	Description *string `pulumi:"description"`
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled bool `pulumi:"enabled"`
	// Contributors to the Service Identifier calculation. All of the Contributors are always applied.
	IdContributors ServiceFullWebRequestIdContributors `pulumi:"idContributors"`
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter *string `pulumi:"insertAfter"`
	// Define a management zone of the process group for which this service detection rule should be created.
	ManagementZones []string `pulumi:"managementZones"`
	// Rule name
	Name *string `pulumi:"name"`
}

// The set of arguments for constructing a ServiceFullWebRequest resource.
type ServiceFullWebRequestArgs struct {
	// A list of conditions necessary for the rule to take effect. If multiple conditions are specified, they must **all** match a Request for the rule to apply. If there is no condition at all, the rule is always applied. Conditions are evaluated against attributes, but do not modify them.
	Conditions ServiceFullWebRequestConditionsPtrInput
	// Description
	Description pulumi.StringPtrInput
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolInput
	// Contributors to the Service Identifier calculation. All of the Contributors are always applied.
	IdContributors ServiceFullWebRequestIdContributorsInput
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter pulumi.StringPtrInput
	// Define a management zone of the process group for which this service detection rule should be created.
	ManagementZones pulumi.StringArrayInput
	// Rule name
	Name pulumi.StringPtrInput
}

func (ServiceFullWebRequestArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceFullWebRequestArgs)(nil)).Elem()
}

type ServiceFullWebRequestInput interface {
	pulumi.Input

	ToServiceFullWebRequestOutput() ServiceFullWebRequestOutput
	ToServiceFullWebRequestOutputWithContext(ctx context.Context) ServiceFullWebRequestOutput
}

func (*ServiceFullWebRequest) ElementType() reflect.Type {
	return reflect.TypeOf((**ServiceFullWebRequest)(nil)).Elem()
}

func (i *ServiceFullWebRequest) ToServiceFullWebRequestOutput() ServiceFullWebRequestOutput {
	return i.ToServiceFullWebRequestOutputWithContext(context.Background())
}

func (i *ServiceFullWebRequest) ToServiceFullWebRequestOutputWithContext(ctx context.Context) ServiceFullWebRequestOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceFullWebRequestOutput)
}

// ServiceFullWebRequestArrayInput is an input type that accepts ServiceFullWebRequestArray and ServiceFullWebRequestArrayOutput values.
// You can construct a concrete instance of `ServiceFullWebRequestArrayInput` via:
//
//	ServiceFullWebRequestArray{ ServiceFullWebRequestArgs{...} }
type ServiceFullWebRequestArrayInput interface {
	pulumi.Input

	ToServiceFullWebRequestArrayOutput() ServiceFullWebRequestArrayOutput
	ToServiceFullWebRequestArrayOutputWithContext(context.Context) ServiceFullWebRequestArrayOutput
}

type ServiceFullWebRequestArray []ServiceFullWebRequestInput

func (ServiceFullWebRequestArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ServiceFullWebRequest)(nil)).Elem()
}

func (i ServiceFullWebRequestArray) ToServiceFullWebRequestArrayOutput() ServiceFullWebRequestArrayOutput {
	return i.ToServiceFullWebRequestArrayOutputWithContext(context.Background())
}

func (i ServiceFullWebRequestArray) ToServiceFullWebRequestArrayOutputWithContext(ctx context.Context) ServiceFullWebRequestArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceFullWebRequestArrayOutput)
}

// ServiceFullWebRequestMapInput is an input type that accepts ServiceFullWebRequestMap and ServiceFullWebRequestMapOutput values.
// You can construct a concrete instance of `ServiceFullWebRequestMapInput` via:
//
//	ServiceFullWebRequestMap{ "key": ServiceFullWebRequestArgs{...} }
type ServiceFullWebRequestMapInput interface {
	pulumi.Input

	ToServiceFullWebRequestMapOutput() ServiceFullWebRequestMapOutput
	ToServiceFullWebRequestMapOutputWithContext(context.Context) ServiceFullWebRequestMapOutput
}

type ServiceFullWebRequestMap map[string]ServiceFullWebRequestInput

func (ServiceFullWebRequestMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ServiceFullWebRequest)(nil)).Elem()
}

func (i ServiceFullWebRequestMap) ToServiceFullWebRequestMapOutput() ServiceFullWebRequestMapOutput {
	return i.ToServiceFullWebRequestMapOutputWithContext(context.Background())
}

func (i ServiceFullWebRequestMap) ToServiceFullWebRequestMapOutputWithContext(ctx context.Context) ServiceFullWebRequestMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceFullWebRequestMapOutput)
}

type ServiceFullWebRequestOutput struct{ *pulumi.OutputState }

func (ServiceFullWebRequestOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ServiceFullWebRequest)(nil)).Elem()
}

func (o ServiceFullWebRequestOutput) ToServiceFullWebRequestOutput() ServiceFullWebRequestOutput {
	return o
}

func (o ServiceFullWebRequestOutput) ToServiceFullWebRequestOutputWithContext(ctx context.Context) ServiceFullWebRequestOutput {
	return o
}

// A list of conditions necessary for the rule to take effect. If multiple conditions are specified, they must **all** match a Request for the rule to apply. If there is no condition at all, the rule is always applied. Conditions are evaluated against attributes, but do not modify them.
func (o ServiceFullWebRequestOutput) Conditions() ServiceFullWebRequestConditionsPtrOutput {
	return o.ApplyT(func(v *ServiceFullWebRequest) ServiceFullWebRequestConditionsPtrOutput { return v.Conditions }).(ServiceFullWebRequestConditionsPtrOutput)
}

// Description
func (o ServiceFullWebRequestOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ServiceFullWebRequest) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// This setting is enabled (`true`) or disabled (`false`)
func (o ServiceFullWebRequestOutput) Enabled() pulumi.BoolOutput {
	return o.ApplyT(func(v *ServiceFullWebRequest) pulumi.BoolOutput { return v.Enabled }).(pulumi.BoolOutput)
}

// Contributors to the Service Identifier calculation. All of the Contributors are always applied.
func (o ServiceFullWebRequestOutput) IdContributors() ServiceFullWebRequestIdContributorsOutput {
	return o.ApplyT(func(v *ServiceFullWebRequest) ServiceFullWebRequestIdContributorsOutput { return v.IdContributors }).(ServiceFullWebRequestIdContributorsOutput)
}

// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
func (o ServiceFullWebRequestOutput) InsertAfter() pulumi.StringOutput {
	return o.ApplyT(func(v *ServiceFullWebRequest) pulumi.StringOutput { return v.InsertAfter }).(pulumi.StringOutput)
}

// Define a management zone of the process group for which this service detection rule should be created.
func (o ServiceFullWebRequestOutput) ManagementZones() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *ServiceFullWebRequest) pulumi.StringArrayOutput { return v.ManagementZones }).(pulumi.StringArrayOutput)
}

// Rule name
func (o ServiceFullWebRequestOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *ServiceFullWebRequest) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

type ServiceFullWebRequestArrayOutput struct{ *pulumi.OutputState }

func (ServiceFullWebRequestArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ServiceFullWebRequest)(nil)).Elem()
}

func (o ServiceFullWebRequestArrayOutput) ToServiceFullWebRequestArrayOutput() ServiceFullWebRequestArrayOutput {
	return o
}

func (o ServiceFullWebRequestArrayOutput) ToServiceFullWebRequestArrayOutputWithContext(ctx context.Context) ServiceFullWebRequestArrayOutput {
	return o
}

func (o ServiceFullWebRequestArrayOutput) Index(i pulumi.IntInput) ServiceFullWebRequestOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ServiceFullWebRequest {
		return vs[0].([]*ServiceFullWebRequest)[vs[1].(int)]
	}).(ServiceFullWebRequestOutput)
}

type ServiceFullWebRequestMapOutput struct{ *pulumi.OutputState }

func (ServiceFullWebRequestMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ServiceFullWebRequest)(nil)).Elem()
}

func (o ServiceFullWebRequestMapOutput) ToServiceFullWebRequestMapOutput() ServiceFullWebRequestMapOutput {
	return o
}

func (o ServiceFullWebRequestMapOutput) ToServiceFullWebRequestMapOutputWithContext(ctx context.Context) ServiceFullWebRequestMapOutput {
	return o
}

func (o ServiceFullWebRequestMapOutput) MapIndex(k pulumi.StringInput) ServiceFullWebRequestOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ServiceFullWebRequest {
		return vs[0].(map[string]*ServiceFullWebRequest)[vs[1].(string)]
	}).(ServiceFullWebRequestOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ServiceFullWebRequestInput)(nil)).Elem(), &ServiceFullWebRequest{})
	pulumi.RegisterInputType(reflect.TypeOf((*ServiceFullWebRequestArrayInput)(nil)).Elem(), ServiceFullWebRequestArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ServiceFullWebRequestMapInput)(nil)).Elem(), ServiceFullWebRequestMap{})
	pulumi.RegisterOutputType(ServiceFullWebRequestOutput{})
	pulumi.RegisterOutputType(ServiceFullWebRequestArrayOutput{})
	pulumi.RegisterOutputType(ServiceFullWebRequestMapOutput{})
}
