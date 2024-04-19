// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dynatrace

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi-dynatrace/sdk/go/dynatrace/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type Notification struct {
	pulumi.CustomResourceState

	// Configuration for Ansible Tower Notification
	AnsibleTower NotificationAnsibleTowerPtrOutput `pulumi:"ansibleTower"`
	// Configuration for Generic Notification
	Config NotificationConfigPtrOutput `pulumi:"config"`
	// Configuration for Email Notification
	Email NotificationEmailPtrOutput `pulumi:"email"`
	// Configuration for Jira Notification
	Jira NotificationJiraPtrOutput `pulumi:"jira"`
	// Configuration for OpsGenie Notification
	OpsGenie NotificationOpsGeniePtrOutput `pulumi:"opsGenie"`
	// Configuration for PagerDuty Notification
	PagerDuty NotificationPagerDutyPtrOutput `pulumi:"pagerDuty"`
	// Configuration for ServiceNow Notification
	ServiceNow NotificationServiceNowPtrOutput `pulumi:"serviceNow"`
	// Configuration for Slack Notification
	Slack NotificationSlackPtrOutput `pulumi:"slack"`
	// Configuration for Trello Notification
	Trello NotificationTrelloPtrOutput `pulumi:"trello"`
	// Configuration for VictorOps Notification
	VictorOps NotificationVictorOpsPtrOutput `pulumi:"victorOps"`
	// Configuration for WebHook Notification
	WebHook NotificationWebHookPtrOutput `pulumi:"webHook"`
	// Configuration for XMatters Notification
	Xmatters NotificationXmattersPtrOutput `pulumi:"xmatters"`
}

// NewNotification registers a new resource with the given unique name, arguments, and options.
func NewNotification(ctx *pulumi.Context,
	name string, args *NotificationArgs, opts ...pulumi.ResourceOption) (*Notification, error) {
	if args == nil {
		args = &NotificationArgs{}
	}

	opts = internal.PkgResourceDefaultOpts(opts)
	var resource Notification
	err := ctx.RegisterResource("dynatrace:index/notification:Notification", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetNotification gets an existing Notification resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNotification(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *NotificationState, opts ...pulumi.ResourceOption) (*Notification, error) {
	var resource Notification
	err := ctx.ReadResource("dynatrace:index/notification:Notification", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Notification resources.
type notificationState struct {
	// Configuration for Ansible Tower Notification
	AnsibleTower *NotificationAnsibleTower `pulumi:"ansibleTower"`
	// Configuration for Generic Notification
	Config *NotificationConfig `pulumi:"config"`
	// Configuration for Email Notification
	Email *NotificationEmail `pulumi:"email"`
	// Configuration for Jira Notification
	Jira *NotificationJira `pulumi:"jira"`
	// Configuration for OpsGenie Notification
	OpsGenie *NotificationOpsGenie `pulumi:"opsGenie"`
	// Configuration for PagerDuty Notification
	PagerDuty *NotificationPagerDuty `pulumi:"pagerDuty"`
	// Configuration for ServiceNow Notification
	ServiceNow *NotificationServiceNow `pulumi:"serviceNow"`
	// Configuration for Slack Notification
	Slack *NotificationSlack `pulumi:"slack"`
	// Configuration for Trello Notification
	Trello *NotificationTrello `pulumi:"trello"`
	// Configuration for VictorOps Notification
	VictorOps *NotificationVictorOps `pulumi:"victorOps"`
	// Configuration for WebHook Notification
	WebHook *NotificationWebHook `pulumi:"webHook"`
	// Configuration for XMatters Notification
	Xmatters *NotificationXmatters `pulumi:"xmatters"`
}

type NotificationState struct {
	// Configuration for Ansible Tower Notification
	AnsibleTower NotificationAnsibleTowerPtrInput
	// Configuration for Generic Notification
	Config NotificationConfigPtrInput
	// Configuration for Email Notification
	Email NotificationEmailPtrInput
	// Configuration for Jira Notification
	Jira NotificationJiraPtrInput
	// Configuration for OpsGenie Notification
	OpsGenie NotificationOpsGeniePtrInput
	// Configuration for PagerDuty Notification
	PagerDuty NotificationPagerDutyPtrInput
	// Configuration for ServiceNow Notification
	ServiceNow NotificationServiceNowPtrInput
	// Configuration for Slack Notification
	Slack NotificationSlackPtrInput
	// Configuration for Trello Notification
	Trello NotificationTrelloPtrInput
	// Configuration for VictorOps Notification
	VictorOps NotificationVictorOpsPtrInput
	// Configuration for WebHook Notification
	WebHook NotificationWebHookPtrInput
	// Configuration for XMatters Notification
	Xmatters NotificationXmattersPtrInput
}

func (NotificationState) ElementType() reflect.Type {
	return reflect.TypeOf((*notificationState)(nil)).Elem()
}

type notificationArgs struct {
	// Configuration for Ansible Tower Notification
	AnsibleTower *NotificationAnsibleTower `pulumi:"ansibleTower"`
	// Configuration for Generic Notification
	Config *NotificationConfig `pulumi:"config"`
	// Configuration for Email Notification
	Email *NotificationEmail `pulumi:"email"`
	// Configuration for Jira Notification
	Jira *NotificationJira `pulumi:"jira"`
	// Configuration for OpsGenie Notification
	OpsGenie *NotificationOpsGenie `pulumi:"opsGenie"`
	// Configuration for PagerDuty Notification
	PagerDuty *NotificationPagerDuty `pulumi:"pagerDuty"`
	// Configuration for ServiceNow Notification
	ServiceNow *NotificationServiceNow `pulumi:"serviceNow"`
	// Configuration for Slack Notification
	Slack *NotificationSlack `pulumi:"slack"`
	// Configuration for Trello Notification
	Trello *NotificationTrello `pulumi:"trello"`
	// Configuration for VictorOps Notification
	VictorOps *NotificationVictorOps `pulumi:"victorOps"`
	// Configuration for WebHook Notification
	WebHook *NotificationWebHook `pulumi:"webHook"`
	// Configuration for XMatters Notification
	Xmatters *NotificationXmatters `pulumi:"xmatters"`
}

// The set of arguments for constructing a Notification resource.
type NotificationArgs struct {
	// Configuration for Ansible Tower Notification
	AnsibleTower NotificationAnsibleTowerPtrInput
	// Configuration for Generic Notification
	Config NotificationConfigPtrInput
	// Configuration for Email Notification
	Email NotificationEmailPtrInput
	// Configuration for Jira Notification
	Jira NotificationJiraPtrInput
	// Configuration for OpsGenie Notification
	OpsGenie NotificationOpsGeniePtrInput
	// Configuration for PagerDuty Notification
	PagerDuty NotificationPagerDutyPtrInput
	// Configuration for ServiceNow Notification
	ServiceNow NotificationServiceNowPtrInput
	// Configuration for Slack Notification
	Slack NotificationSlackPtrInput
	// Configuration for Trello Notification
	Trello NotificationTrelloPtrInput
	// Configuration for VictorOps Notification
	VictorOps NotificationVictorOpsPtrInput
	// Configuration for WebHook Notification
	WebHook NotificationWebHookPtrInput
	// Configuration for XMatters Notification
	Xmatters NotificationXmattersPtrInput
}

func (NotificationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*notificationArgs)(nil)).Elem()
}

type NotificationInput interface {
	pulumi.Input

	ToNotificationOutput() NotificationOutput
	ToNotificationOutputWithContext(ctx context.Context) NotificationOutput
}

func (*Notification) ElementType() reflect.Type {
	return reflect.TypeOf((**Notification)(nil)).Elem()
}

func (i *Notification) ToNotificationOutput() NotificationOutput {
	return i.ToNotificationOutputWithContext(context.Background())
}

func (i *Notification) ToNotificationOutputWithContext(ctx context.Context) NotificationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NotificationOutput)
}

// NotificationArrayInput is an input type that accepts NotificationArray and NotificationArrayOutput values.
// You can construct a concrete instance of `NotificationArrayInput` via:
//
//	NotificationArray{ NotificationArgs{...} }
type NotificationArrayInput interface {
	pulumi.Input

	ToNotificationArrayOutput() NotificationArrayOutput
	ToNotificationArrayOutputWithContext(context.Context) NotificationArrayOutput
}

type NotificationArray []NotificationInput

func (NotificationArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Notification)(nil)).Elem()
}

func (i NotificationArray) ToNotificationArrayOutput() NotificationArrayOutput {
	return i.ToNotificationArrayOutputWithContext(context.Background())
}

func (i NotificationArray) ToNotificationArrayOutputWithContext(ctx context.Context) NotificationArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NotificationArrayOutput)
}

// NotificationMapInput is an input type that accepts NotificationMap and NotificationMapOutput values.
// You can construct a concrete instance of `NotificationMapInput` via:
//
//	NotificationMap{ "key": NotificationArgs{...} }
type NotificationMapInput interface {
	pulumi.Input

	ToNotificationMapOutput() NotificationMapOutput
	ToNotificationMapOutputWithContext(context.Context) NotificationMapOutput
}

type NotificationMap map[string]NotificationInput

func (NotificationMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Notification)(nil)).Elem()
}

func (i NotificationMap) ToNotificationMapOutput() NotificationMapOutput {
	return i.ToNotificationMapOutputWithContext(context.Background())
}

func (i NotificationMap) ToNotificationMapOutputWithContext(ctx context.Context) NotificationMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NotificationMapOutput)
}

type NotificationOutput struct{ *pulumi.OutputState }

func (NotificationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Notification)(nil)).Elem()
}

func (o NotificationOutput) ToNotificationOutput() NotificationOutput {
	return o
}

func (o NotificationOutput) ToNotificationOutputWithContext(ctx context.Context) NotificationOutput {
	return o
}

// Configuration for Ansible Tower Notification
func (o NotificationOutput) AnsibleTower() NotificationAnsibleTowerPtrOutput {
	return o.ApplyT(func(v *Notification) NotificationAnsibleTowerPtrOutput { return v.AnsibleTower }).(NotificationAnsibleTowerPtrOutput)
}

// Configuration for Generic Notification
func (o NotificationOutput) Config() NotificationConfigPtrOutput {
	return o.ApplyT(func(v *Notification) NotificationConfigPtrOutput { return v.Config }).(NotificationConfigPtrOutput)
}

// Configuration for Email Notification
func (o NotificationOutput) Email() NotificationEmailPtrOutput {
	return o.ApplyT(func(v *Notification) NotificationEmailPtrOutput { return v.Email }).(NotificationEmailPtrOutput)
}

// Configuration for Jira Notification
func (o NotificationOutput) Jira() NotificationJiraPtrOutput {
	return o.ApplyT(func(v *Notification) NotificationJiraPtrOutput { return v.Jira }).(NotificationJiraPtrOutput)
}

// Configuration for OpsGenie Notification
func (o NotificationOutput) OpsGenie() NotificationOpsGeniePtrOutput {
	return o.ApplyT(func(v *Notification) NotificationOpsGeniePtrOutput { return v.OpsGenie }).(NotificationOpsGeniePtrOutput)
}

// Configuration for PagerDuty Notification
func (o NotificationOutput) PagerDuty() NotificationPagerDutyPtrOutput {
	return o.ApplyT(func(v *Notification) NotificationPagerDutyPtrOutput { return v.PagerDuty }).(NotificationPagerDutyPtrOutput)
}

// Configuration for ServiceNow Notification
func (o NotificationOutput) ServiceNow() NotificationServiceNowPtrOutput {
	return o.ApplyT(func(v *Notification) NotificationServiceNowPtrOutput { return v.ServiceNow }).(NotificationServiceNowPtrOutput)
}

// Configuration for Slack Notification
func (o NotificationOutput) Slack() NotificationSlackPtrOutput {
	return o.ApplyT(func(v *Notification) NotificationSlackPtrOutput { return v.Slack }).(NotificationSlackPtrOutput)
}

// Configuration for Trello Notification
func (o NotificationOutput) Trello() NotificationTrelloPtrOutput {
	return o.ApplyT(func(v *Notification) NotificationTrelloPtrOutput { return v.Trello }).(NotificationTrelloPtrOutput)
}

// Configuration for VictorOps Notification
func (o NotificationOutput) VictorOps() NotificationVictorOpsPtrOutput {
	return o.ApplyT(func(v *Notification) NotificationVictorOpsPtrOutput { return v.VictorOps }).(NotificationVictorOpsPtrOutput)
}

// Configuration for WebHook Notification
func (o NotificationOutput) WebHook() NotificationWebHookPtrOutput {
	return o.ApplyT(func(v *Notification) NotificationWebHookPtrOutput { return v.WebHook }).(NotificationWebHookPtrOutput)
}

// Configuration for XMatters Notification
func (o NotificationOutput) Xmatters() NotificationXmattersPtrOutput {
	return o.ApplyT(func(v *Notification) NotificationXmattersPtrOutput { return v.Xmatters }).(NotificationXmattersPtrOutput)
}

type NotificationArrayOutput struct{ *pulumi.OutputState }

func (NotificationArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Notification)(nil)).Elem()
}

func (o NotificationArrayOutput) ToNotificationArrayOutput() NotificationArrayOutput {
	return o
}

func (o NotificationArrayOutput) ToNotificationArrayOutputWithContext(ctx context.Context) NotificationArrayOutput {
	return o
}

func (o NotificationArrayOutput) Index(i pulumi.IntInput) NotificationOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Notification {
		return vs[0].([]*Notification)[vs[1].(int)]
	}).(NotificationOutput)
}

type NotificationMapOutput struct{ *pulumi.OutputState }

func (NotificationMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Notification)(nil)).Elem()
}

func (o NotificationMapOutput) ToNotificationMapOutput() NotificationMapOutput {
	return o
}

func (o NotificationMapOutput) ToNotificationMapOutputWithContext(ctx context.Context) NotificationMapOutput {
	return o
}

func (o NotificationMapOutput) MapIndex(k pulumi.StringInput) NotificationOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Notification {
		return vs[0].(map[string]*Notification)[vs[1].(string)]
	}).(NotificationOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*NotificationInput)(nil)).Elem(), &Notification{})
	pulumi.RegisterInputType(reflect.TypeOf((*NotificationArrayInput)(nil)).Elem(), NotificationArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*NotificationMapInput)(nil)).Elem(), NotificationMap{})
	pulumi.RegisterOutputType(NotificationOutput{})
	pulumi.RegisterOutputType(NotificationArrayOutput{})
	pulumi.RegisterOutputType(NotificationMapOutput{})
}
