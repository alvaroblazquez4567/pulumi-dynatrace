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

type TrelloNotification struct {
	pulumi.CustomResourceState

	// The configuration is enabled (`true`) or disabled (`false`)
	Active pulumi.BoolOutput `pulumi:"active"`
	// The application key for the Trello account
	ApplicationKey pulumi.StringOutput `pulumi:"applicationKey"`
	// The application token for the Trello account
	AuthorizationToken pulumi.StringPtrOutput `pulumi:"authorizationToken"`
	// The Trello board to which the card should be assigned
	BoardId pulumi.StringOutput `pulumi:"boardId"`
	// The description of the Trello card.   You can use same placeholders as in card text
	Description pulumi.StringOutput `pulumi:"description"`
	// The ID of these settings when referred to from resources requiring the REST API V1 keys
	LegacyId pulumi.StringOutput `pulumi:"legacyId"`
	// The Trello list to which the card should be assigned
	ListId pulumi.StringOutput `pulumi:"listId"`
	// The name of the notification configuration
	Name pulumi.StringOutput `pulumi:"name"`
	// The ID of the associated alerting profile
	Profile pulumi.StringOutput `pulumi:"profile"`
	// The Trello list to which the card of the resolved problem should be assigned
	ResolvedListId pulumi.StringOutput `pulumi:"resolvedListId"`
	// The text of the generated Trello card.  You can use the following placeholders:  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{PID}`: The ID of the reported problem.  * `{ProblemDetailsMarkdown}`: All problem event details, including root cause, as a [Markdown-formatted](https://www.markdownguide.org/cheat-sheet/) string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`.  * `{Tags}`: The list of tags that are defined for all impacted entities, separated by commas
	Text pulumi.StringOutput `pulumi:"text"`
}

// NewTrelloNotification registers a new resource with the given unique name, arguments, and options.
func NewTrelloNotification(ctx *pulumi.Context,
	name string, args *TrelloNotificationArgs, opts ...pulumi.ResourceOption) (*TrelloNotification, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Active == nil {
		return nil, errors.New("invalid value for required argument 'Active'")
	}
	if args.ApplicationKey == nil {
		return nil, errors.New("invalid value for required argument 'ApplicationKey'")
	}
	if args.BoardId == nil {
		return nil, errors.New("invalid value for required argument 'BoardId'")
	}
	if args.Description == nil {
		return nil, errors.New("invalid value for required argument 'Description'")
	}
	if args.ListId == nil {
		return nil, errors.New("invalid value for required argument 'ListId'")
	}
	if args.Profile == nil {
		return nil, errors.New("invalid value for required argument 'Profile'")
	}
	if args.ResolvedListId == nil {
		return nil, errors.New("invalid value for required argument 'ResolvedListId'")
	}
	if args.Text == nil {
		return nil, errors.New("invalid value for required argument 'Text'")
	}
	if args.AuthorizationToken != nil {
		args.AuthorizationToken = pulumi.ToSecret(args.AuthorizationToken).(pulumi.StringPtrInput)
	}
	secrets := pulumi.AdditionalSecretOutputs([]string{
		"authorizationToken",
	})
	opts = append(opts, secrets)
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource TrelloNotification
	err := ctx.RegisterResource("dynatrace:index/trelloNotification:TrelloNotification", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTrelloNotification gets an existing TrelloNotification resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTrelloNotification(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TrelloNotificationState, opts ...pulumi.ResourceOption) (*TrelloNotification, error) {
	var resource TrelloNotification
	err := ctx.ReadResource("dynatrace:index/trelloNotification:TrelloNotification", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering TrelloNotification resources.
type trelloNotificationState struct {
	// The configuration is enabled (`true`) or disabled (`false`)
	Active *bool `pulumi:"active"`
	// The application key for the Trello account
	ApplicationKey *string `pulumi:"applicationKey"`
	// The application token for the Trello account
	AuthorizationToken *string `pulumi:"authorizationToken"`
	// The Trello board to which the card should be assigned
	BoardId *string `pulumi:"boardId"`
	// The description of the Trello card.   You can use same placeholders as in card text
	Description *string `pulumi:"description"`
	// The ID of these settings when referred to from resources requiring the REST API V1 keys
	LegacyId *string `pulumi:"legacyId"`
	// The Trello list to which the card should be assigned
	ListId *string `pulumi:"listId"`
	// The name of the notification configuration
	Name *string `pulumi:"name"`
	// The ID of the associated alerting profile
	Profile *string `pulumi:"profile"`
	// The Trello list to which the card of the resolved problem should be assigned
	ResolvedListId *string `pulumi:"resolvedListId"`
	// The text of the generated Trello card.  You can use the following placeholders:  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{PID}`: The ID of the reported problem.  * `{ProblemDetailsMarkdown}`: All problem event details, including root cause, as a [Markdown-formatted](https://www.markdownguide.org/cheat-sheet/) string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`.  * `{Tags}`: The list of tags that are defined for all impacted entities, separated by commas
	Text *string `pulumi:"text"`
}

type TrelloNotificationState struct {
	// The configuration is enabled (`true`) or disabled (`false`)
	Active pulumi.BoolPtrInput
	// The application key for the Trello account
	ApplicationKey pulumi.StringPtrInput
	// The application token for the Trello account
	AuthorizationToken pulumi.StringPtrInput
	// The Trello board to which the card should be assigned
	BoardId pulumi.StringPtrInput
	// The description of the Trello card.   You can use same placeholders as in card text
	Description pulumi.StringPtrInput
	// The ID of these settings when referred to from resources requiring the REST API V1 keys
	LegacyId pulumi.StringPtrInput
	// The Trello list to which the card should be assigned
	ListId pulumi.StringPtrInput
	// The name of the notification configuration
	Name pulumi.StringPtrInput
	// The ID of the associated alerting profile
	Profile pulumi.StringPtrInput
	// The Trello list to which the card of the resolved problem should be assigned
	ResolvedListId pulumi.StringPtrInput
	// The text of the generated Trello card.  You can use the following placeholders:  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{PID}`: The ID of the reported problem.  * `{ProblemDetailsMarkdown}`: All problem event details, including root cause, as a [Markdown-formatted](https://www.markdownguide.org/cheat-sheet/) string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`.  * `{Tags}`: The list of tags that are defined for all impacted entities, separated by commas
	Text pulumi.StringPtrInput
}

func (TrelloNotificationState) ElementType() reflect.Type {
	return reflect.TypeOf((*trelloNotificationState)(nil)).Elem()
}

type trelloNotificationArgs struct {
	// The configuration is enabled (`true`) or disabled (`false`)
	Active bool `pulumi:"active"`
	// The application key for the Trello account
	ApplicationKey string `pulumi:"applicationKey"`
	// The application token for the Trello account
	AuthorizationToken *string `pulumi:"authorizationToken"`
	// The Trello board to which the card should be assigned
	BoardId string `pulumi:"boardId"`
	// The description of the Trello card.   You can use same placeholders as in card text
	Description string `pulumi:"description"`
	// The ID of these settings when referred to from resources requiring the REST API V1 keys
	LegacyId *string `pulumi:"legacyId"`
	// The Trello list to which the card should be assigned
	ListId string `pulumi:"listId"`
	// The name of the notification configuration
	Name *string `pulumi:"name"`
	// The ID of the associated alerting profile
	Profile string `pulumi:"profile"`
	// The Trello list to which the card of the resolved problem should be assigned
	ResolvedListId string `pulumi:"resolvedListId"`
	// The text of the generated Trello card.  You can use the following placeholders:  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{PID}`: The ID of the reported problem.  * `{ProblemDetailsMarkdown}`: All problem event details, including root cause, as a [Markdown-formatted](https://www.markdownguide.org/cheat-sheet/) string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`.  * `{Tags}`: The list of tags that are defined for all impacted entities, separated by commas
	Text string `pulumi:"text"`
}

// The set of arguments for constructing a TrelloNotification resource.
type TrelloNotificationArgs struct {
	// The configuration is enabled (`true`) or disabled (`false`)
	Active pulumi.BoolInput
	// The application key for the Trello account
	ApplicationKey pulumi.StringInput
	// The application token for the Trello account
	AuthorizationToken pulumi.StringPtrInput
	// The Trello board to which the card should be assigned
	BoardId pulumi.StringInput
	// The description of the Trello card.   You can use same placeholders as in card text
	Description pulumi.StringInput
	// The ID of these settings when referred to from resources requiring the REST API V1 keys
	LegacyId pulumi.StringPtrInput
	// The Trello list to which the card should be assigned
	ListId pulumi.StringInput
	// The name of the notification configuration
	Name pulumi.StringPtrInput
	// The ID of the associated alerting profile
	Profile pulumi.StringInput
	// The Trello list to which the card of the resolved problem should be assigned
	ResolvedListId pulumi.StringInput
	// The text of the generated Trello card.  You can use the following placeholders:  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{PID}`: The ID of the reported problem.  * `{ProblemDetailsMarkdown}`: All problem event details, including root cause, as a [Markdown-formatted](https://www.markdownguide.org/cheat-sheet/) string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`.  * `{Tags}`: The list of tags that are defined for all impacted entities, separated by commas
	Text pulumi.StringInput
}

func (TrelloNotificationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*trelloNotificationArgs)(nil)).Elem()
}

type TrelloNotificationInput interface {
	pulumi.Input

	ToTrelloNotificationOutput() TrelloNotificationOutput
	ToTrelloNotificationOutputWithContext(ctx context.Context) TrelloNotificationOutput
}

func (*TrelloNotification) ElementType() reflect.Type {
	return reflect.TypeOf((**TrelloNotification)(nil)).Elem()
}

func (i *TrelloNotification) ToTrelloNotificationOutput() TrelloNotificationOutput {
	return i.ToTrelloNotificationOutputWithContext(context.Background())
}

func (i *TrelloNotification) ToTrelloNotificationOutputWithContext(ctx context.Context) TrelloNotificationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TrelloNotificationOutput)
}

// TrelloNotificationArrayInput is an input type that accepts TrelloNotificationArray and TrelloNotificationArrayOutput values.
// You can construct a concrete instance of `TrelloNotificationArrayInput` via:
//
//	TrelloNotificationArray{ TrelloNotificationArgs{...} }
type TrelloNotificationArrayInput interface {
	pulumi.Input

	ToTrelloNotificationArrayOutput() TrelloNotificationArrayOutput
	ToTrelloNotificationArrayOutputWithContext(context.Context) TrelloNotificationArrayOutput
}

type TrelloNotificationArray []TrelloNotificationInput

func (TrelloNotificationArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*TrelloNotification)(nil)).Elem()
}

func (i TrelloNotificationArray) ToTrelloNotificationArrayOutput() TrelloNotificationArrayOutput {
	return i.ToTrelloNotificationArrayOutputWithContext(context.Background())
}

func (i TrelloNotificationArray) ToTrelloNotificationArrayOutputWithContext(ctx context.Context) TrelloNotificationArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TrelloNotificationArrayOutput)
}

// TrelloNotificationMapInput is an input type that accepts TrelloNotificationMap and TrelloNotificationMapOutput values.
// You can construct a concrete instance of `TrelloNotificationMapInput` via:
//
//	TrelloNotificationMap{ "key": TrelloNotificationArgs{...} }
type TrelloNotificationMapInput interface {
	pulumi.Input

	ToTrelloNotificationMapOutput() TrelloNotificationMapOutput
	ToTrelloNotificationMapOutputWithContext(context.Context) TrelloNotificationMapOutput
}

type TrelloNotificationMap map[string]TrelloNotificationInput

func (TrelloNotificationMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*TrelloNotification)(nil)).Elem()
}

func (i TrelloNotificationMap) ToTrelloNotificationMapOutput() TrelloNotificationMapOutput {
	return i.ToTrelloNotificationMapOutputWithContext(context.Background())
}

func (i TrelloNotificationMap) ToTrelloNotificationMapOutputWithContext(ctx context.Context) TrelloNotificationMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TrelloNotificationMapOutput)
}

type TrelloNotificationOutput struct{ *pulumi.OutputState }

func (TrelloNotificationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**TrelloNotification)(nil)).Elem()
}

func (o TrelloNotificationOutput) ToTrelloNotificationOutput() TrelloNotificationOutput {
	return o
}

func (o TrelloNotificationOutput) ToTrelloNotificationOutputWithContext(ctx context.Context) TrelloNotificationOutput {
	return o
}

// The configuration is enabled (`true`) or disabled (`false`)
func (o TrelloNotificationOutput) Active() pulumi.BoolOutput {
	return o.ApplyT(func(v *TrelloNotification) pulumi.BoolOutput { return v.Active }).(pulumi.BoolOutput)
}

// The application key for the Trello account
func (o TrelloNotificationOutput) ApplicationKey() pulumi.StringOutput {
	return o.ApplyT(func(v *TrelloNotification) pulumi.StringOutput { return v.ApplicationKey }).(pulumi.StringOutput)
}

// The application token for the Trello account
func (o TrelloNotificationOutput) AuthorizationToken() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *TrelloNotification) pulumi.StringPtrOutput { return v.AuthorizationToken }).(pulumi.StringPtrOutput)
}

// The Trello board to which the card should be assigned
func (o TrelloNotificationOutput) BoardId() pulumi.StringOutput {
	return o.ApplyT(func(v *TrelloNotification) pulumi.StringOutput { return v.BoardId }).(pulumi.StringOutput)
}

// The description of the Trello card.   You can use same placeholders as in card text
func (o TrelloNotificationOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v *TrelloNotification) pulumi.StringOutput { return v.Description }).(pulumi.StringOutput)
}

// The ID of these settings when referred to from resources requiring the REST API V1 keys
func (o TrelloNotificationOutput) LegacyId() pulumi.StringOutput {
	return o.ApplyT(func(v *TrelloNotification) pulumi.StringOutput { return v.LegacyId }).(pulumi.StringOutput)
}

// The Trello list to which the card should be assigned
func (o TrelloNotificationOutput) ListId() pulumi.StringOutput {
	return o.ApplyT(func(v *TrelloNotification) pulumi.StringOutput { return v.ListId }).(pulumi.StringOutput)
}

// The name of the notification configuration
func (o TrelloNotificationOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *TrelloNotification) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// The ID of the associated alerting profile
func (o TrelloNotificationOutput) Profile() pulumi.StringOutput {
	return o.ApplyT(func(v *TrelloNotification) pulumi.StringOutput { return v.Profile }).(pulumi.StringOutput)
}

// The Trello list to which the card of the resolved problem should be assigned
func (o TrelloNotificationOutput) ResolvedListId() pulumi.StringOutput {
	return o.ApplyT(func(v *TrelloNotification) pulumi.StringOutput { return v.ResolvedListId }).(pulumi.StringOutput)
}

// The text of the generated Trello card.  You can use the following placeholders:  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{PID}`: The ID of the reported problem.  * `{ProblemDetailsMarkdown}`: All problem event details, including root cause, as a [Markdown-formatted](https://www.markdownguide.org/cheat-sheet/) string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`.  * `{Tags}`: The list of tags that are defined for all impacted entities, separated by commas
func (o TrelloNotificationOutput) Text() pulumi.StringOutput {
	return o.ApplyT(func(v *TrelloNotification) pulumi.StringOutput { return v.Text }).(pulumi.StringOutput)
}

type TrelloNotificationArrayOutput struct{ *pulumi.OutputState }

func (TrelloNotificationArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*TrelloNotification)(nil)).Elem()
}

func (o TrelloNotificationArrayOutput) ToTrelloNotificationArrayOutput() TrelloNotificationArrayOutput {
	return o
}

func (o TrelloNotificationArrayOutput) ToTrelloNotificationArrayOutputWithContext(ctx context.Context) TrelloNotificationArrayOutput {
	return o
}

func (o TrelloNotificationArrayOutput) Index(i pulumi.IntInput) TrelloNotificationOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *TrelloNotification {
		return vs[0].([]*TrelloNotification)[vs[1].(int)]
	}).(TrelloNotificationOutput)
}

type TrelloNotificationMapOutput struct{ *pulumi.OutputState }

func (TrelloNotificationMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*TrelloNotification)(nil)).Elem()
}

func (o TrelloNotificationMapOutput) ToTrelloNotificationMapOutput() TrelloNotificationMapOutput {
	return o
}

func (o TrelloNotificationMapOutput) ToTrelloNotificationMapOutputWithContext(ctx context.Context) TrelloNotificationMapOutput {
	return o
}

func (o TrelloNotificationMapOutput) MapIndex(k pulumi.StringInput) TrelloNotificationOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *TrelloNotification {
		return vs[0].(map[string]*TrelloNotification)[vs[1].(string)]
	}).(TrelloNotificationOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*TrelloNotificationInput)(nil)).Elem(), &TrelloNotification{})
	pulumi.RegisterInputType(reflect.TypeOf((*TrelloNotificationArrayInput)(nil)).Elem(), TrelloNotificationArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*TrelloNotificationMapInput)(nil)).Elem(), TrelloNotificationMap{})
	pulumi.RegisterOutputType(TrelloNotificationOutput{})
	pulumi.RegisterOutputType(TrelloNotificationArrayOutput{})
	pulumi.RegisterOutputType(TrelloNotificationMapOutput{})
}
