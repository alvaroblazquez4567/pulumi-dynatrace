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

type AutomationWorkflowJira struct {
	pulumi.CustomResourceState

	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter pulumi.StringOutput `pulumi:"insertAfter"`
	// The name of the Jira connection
	Name pulumi.StringOutput `pulumi:"name"`
	// Password of the Jira user
	Password pulumi.StringPtrOutput `pulumi:"password"`
	// Token for the selected authentication type
	Token pulumi.StringPtrOutput `pulumi:"token"`
	// Possible Values: `Basic`, `Cloud_token`, `Pat`
	Type pulumi.StringOutput `pulumi:"type"`
	// URL of the Jira server
	Url pulumi.StringOutput `pulumi:"url"`
	// Username or E-Mail address
	User pulumi.StringPtrOutput `pulumi:"user"`
}

// NewAutomationWorkflowJira registers a new resource with the given unique name, arguments, and options.
func NewAutomationWorkflowJira(ctx *pulumi.Context,
	name string, args *AutomationWorkflowJiraArgs, opts ...pulumi.ResourceOption) (*AutomationWorkflowJira, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Type == nil {
		return nil, errors.New("invalid value for required argument 'Type'")
	}
	if args.Url == nil {
		return nil, errors.New("invalid value for required argument 'Url'")
	}
	if args.Password != nil {
		args.Password = pulumi.ToSecret(args.Password).(pulumi.StringPtrInput)
	}
	if args.Token != nil {
		args.Token = pulumi.ToSecret(args.Token).(pulumi.StringPtrInput)
	}
	secrets := pulumi.AdditionalSecretOutputs([]string{
		"password",
		"token",
	})
	opts = append(opts, secrets)
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource AutomationWorkflowJira
	err := ctx.RegisterResource("dynatrace:index/automationWorkflowJira:AutomationWorkflowJira", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAutomationWorkflowJira gets an existing AutomationWorkflowJira resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAutomationWorkflowJira(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AutomationWorkflowJiraState, opts ...pulumi.ResourceOption) (*AutomationWorkflowJira, error) {
	var resource AutomationWorkflowJira
	err := ctx.ReadResource("dynatrace:index/automationWorkflowJira:AutomationWorkflowJira", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AutomationWorkflowJira resources.
type automationWorkflowJiraState struct {
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter *string `pulumi:"insertAfter"`
	// The name of the Jira connection
	Name *string `pulumi:"name"`
	// Password of the Jira user
	Password *string `pulumi:"password"`
	// Token for the selected authentication type
	Token *string `pulumi:"token"`
	// Possible Values: `Basic`, `Cloud_token`, `Pat`
	Type *string `pulumi:"type"`
	// URL of the Jira server
	Url *string `pulumi:"url"`
	// Username or E-Mail address
	User *string `pulumi:"user"`
}

type AutomationWorkflowJiraState struct {
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter pulumi.StringPtrInput
	// The name of the Jira connection
	Name pulumi.StringPtrInput
	// Password of the Jira user
	Password pulumi.StringPtrInput
	// Token for the selected authentication type
	Token pulumi.StringPtrInput
	// Possible Values: `Basic`, `Cloud_token`, `Pat`
	Type pulumi.StringPtrInput
	// URL of the Jira server
	Url pulumi.StringPtrInput
	// Username or E-Mail address
	User pulumi.StringPtrInput
}

func (AutomationWorkflowJiraState) ElementType() reflect.Type {
	return reflect.TypeOf((*automationWorkflowJiraState)(nil)).Elem()
}

type automationWorkflowJiraArgs struct {
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter *string `pulumi:"insertAfter"`
	// The name of the Jira connection
	Name *string `pulumi:"name"`
	// Password of the Jira user
	Password *string `pulumi:"password"`
	// Token for the selected authentication type
	Token *string `pulumi:"token"`
	// Possible Values: `Basic`, `Cloud_token`, `Pat`
	Type string `pulumi:"type"`
	// URL of the Jira server
	Url string `pulumi:"url"`
	// Username or E-Mail address
	User *string `pulumi:"user"`
}

// The set of arguments for constructing a AutomationWorkflowJira resource.
type AutomationWorkflowJiraArgs struct {
	// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
	InsertAfter pulumi.StringPtrInput
	// The name of the Jira connection
	Name pulumi.StringPtrInput
	// Password of the Jira user
	Password pulumi.StringPtrInput
	// Token for the selected authentication type
	Token pulumi.StringPtrInput
	// Possible Values: `Basic`, `Cloud_token`, `Pat`
	Type pulumi.StringInput
	// URL of the Jira server
	Url pulumi.StringInput
	// Username or E-Mail address
	User pulumi.StringPtrInput
}

func (AutomationWorkflowJiraArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*automationWorkflowJiraArgs)(nil)).Elem()
}

type AutomationWorkflowJiraInput interface {
	pulumi.Input

	ToAutomationWorkflowJiraOutput() AutomationWorkflowJiraOutput
	ToAutomationWorkflowJiraOutputWithContext(ctx context.Context) AutomationWorkflowJiraOutput
}

func (*AutomationWorkflowJira) ElementType() reflect.Type {
	return reflect.TypeOf((**AutomationWorkflowJira)(nil)).Elem()
}

func (i *AutomationWorkflowJira) ToAutomationWorkflowJiraOutput() AutomationWorkflowJiraOutput {
	return i.ToAutomationWorkflowJiraOutputWithContext(context.Background())
}

func (i *AutomationWorkflowJira) ToAutomationWorkflowJiraOutputWithContext(ctx context.Context) AutomationWorkflowJiraOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AutomationWorkflowJiraOutput)
}

// AutomationWorkflowJiraArrayInput is an input type that accepts AutomationWorkflowJiraArray and AutomationWorkflowJiraArrayOutput values.
// You can construct a concrete instance of `AutomationWorkflowJiraArrayInput` via:
//
//	AutomationWorkflowJiraArray{ AutomationWorkflowJiraArgs{...} }
type AutomationWorkflowJiraArrayInput interface {
	pulumi.Input

	ToAutomationWorkflowJiraArrayOutput() AutomationWorkflowJiraArrayOutput
	ToAutomationWorkflowJiraArrayOutputWithContext(context.Context) AutomationWorkflowJiraArrayOutput
}

type AutomationWorkflowJiraArray []AutomationWorkflowJiraInput

func (AutomationWorkflowJiraArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AutomationWorkflowJira)(nil)).Elem()
}

func (i AutomationWorkflowJiraArray) ToAutomationWorkflowJiraArrayOutput() AutomationWorkflowJiraArrayOutput {
	return i.ToAutomationWorkflowJiraArrayOutputWithContext(context.Background())
}

func (i AutomationWorkflowJiraArray) ToAutomationWorkflowJiraArrayOutputWithContext(ctx context.Context) AutomationWorkflowJiraArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AutomationWorkflowJiraArrayOutput)
}

// AutomationWorkflowJiraMapInput is an input type that accepts AutomationWorkflowJiraMap and AutomationWorkflowJiraMapOutput values.
// You can construct a concrete instance of `AutomationWorkflowJiraMapInput` via:
//
//	AutomationWorkflowJiraMap{ "key": AutomationWorkflowJiraArgs{...} }
type AutomationWorkflowJiraMapInput interface {
	pulumi.Input

	ToAutomationWorkflowJiraMapOutput() AutomationWorkflowJiraMapOutput
	ToAutomationWorkflowJiraMapOutputWithContext(context.Context) AutomationWorkflowJiraMapOutput
}

type AutomationWorkflowJiraMap map[string]AutomationWorkflowJiraInput

func (AutomationWorkflowJiraMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AutomationWorkflowJira)(nil)).Elem()
}

func (i AutomationWorkflowJiraMap) ToAutomationWorkflowJiraMapOutput() AutomationWorkflowJiraMapOutput {
	return i.ToAutomationWorkflowJiraMapOutputWithContext(context.Background())
}

func (i AutomationWorkflowJiraMap) ToAutomationWorkflowJiraMapOutputWithContext(ctx context.Context) AutomationWorkflowJiraMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AutomationWorkflowJiraMapOutput)
}

type AutomationWorkflowJiraOutput struct{ *pulumi.OutputState }

func (AutomationWorkflowJiraOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AutomationWorkflowJira)(nil)).Elem()
}

func (o AutomationWorkflowJiraOutput) ToAutomationWorkflowJiraOutput() AutomationWorkflowJiraOutput {
	return o
}

func (o AutomationWorkflowJiraOutput) ToAutomationWorkflowJiraOutputWithContext(ctx context.Context) AutomationWorkflowJiraOutput {
	return o
}

// Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
func (o AutomationWorkflowJiraOutput) InsertAfter() pulumi.StringOutput {
	return o.ApplyT(func(v *AutomationWorkflowJira) pulumi.StringOutput { return v.InsertAfter }).(pulumi.StringOutput)
}

// The name of the Jira connection
func (o AutomationWorkflowJiraOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *AutomationWorkflowJira) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Password of the Jira user
func (o AutomationWorkflowJiraOutput) Password() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AutomationWorkflowJira) pulumi.StringPtrOutput { return v.Password }).(pulumi.StringPtrOutput)
}

// Token for the selected authentication type
func (o AutomationWorkflowJiraOutput) Token() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AutomationWorkflowJira) pulumi.StringPtrOutput { return v.Token }).(pulumi.StringPtrOutput)
}

// Possible Values: `Basic`, `Cloud_token`, `Pat`
func (o AutomationWorkflowJiraOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v *AutomationWorkflowJira) pulumi.StringOutput { return v.Type }).(pulumi.StringOutput)
}

// URL of the Jira server
func (o AutomationWorkflowJiraOutput) Url() pulumi.StringOutput {
	return o.ApplyT(func(v *AutomationWorkflowJira) pulumi.StringOutput { return v.Url }).(pulumi.StringOutput)
}

// Username or E-Mail address
func (o AutomationWorkflowJiraOutput) User() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AutomationWorkflowJira) pulumi.StringPtrOutput { return v.User }).(pulumi.StringPtrOutput)
}

type AutomationWorkflowJiraArrayOutput struct{ *pulumi.OutputState }

func (AutomationWorkflowJiraArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AutomationWorkflowJira)(nil)).Elem()
}

func (o AutomationWorkflowJiraArrayOutput) ToAutomationWorkflowJiraArrayOutput() AutomationWorkflowJiraArrayOutput {
	return o
}

func (o AutomationWorkflowJiraArrayOutput) ToAutomationWorkflowJiraArrayOutputWithContext(ctx context.Context) AutomationWorkflowJiraArrayOutput {
	return o
}

func (o AutomationWorkflowJiraArrayOutput) Index(i pulumi.IntInput) AutomationWorkflowJiraOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *AutomationWorkflowJira {
		return vs[0].([]*AutomationWorkflowJira)[vs[1].(int)]
	}).(AutomationWorkflowJiraOutput)
}

type AutomationWorkflowJiraMapOutput struct{ *pulumi.OutputState }

func (AutomationWorkflowJiraMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AutomationWorkflowJira)(nil)).Elem()
}

func (o AutomationWorkflowJiraMapOutput) ToAutomationWorkflowJiraMapOutput() AutomationWorkflowJiraMapOutput {
	return o
}

func (o AutomationWorkflowJiraMapOutput) ToAutomationWorkflowJiraMapOutputWithContext(ctx context.Context) AutomationWorkflowJiraMapOutput {
	return o
}

func (o AutomationWorkflowJiraMapOutput) MapIndex(k pulumi.StringInput) AutomationWorkflowJiraOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *AutomationWorkflowJira {
		return vs[0].(map[string]*AutomationWorkflowJira)[vs[1].(string)]
	}).(AutomationWorkflowJiraOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*AutomationWorkflowJiraInput)(nil)).Elem(), &AutomationWorkflowJira{})
	pulumi.RegisterInputType(reflect.TypeOf((*AutomationWorkflowJiraArrayInput)(nil)).Elem(), AutomationWorkflowJiraArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*AutomationWorkflowJiraMapInput)(nil)).Elem(), AutomationWorkflowJiraMap{})
	pulumi.RegisterOutputType(AutomationWorkflowJiraOutput{})
	pulumi.RegisterOutputType(AutomationWorkflowJiraArrayOutput{})
	pulumi.RegisterOutputType(AutomationWorkflowJiraMapOutput{})
}
