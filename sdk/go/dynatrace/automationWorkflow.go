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

// > This resource is excluded by default in the export utility. You can, of course, specify that resource explicitly in order to export it. In that case, don't forget to specify the environment variables `DYNATRACE_AUTOMATION_CLIENT_ID` and `DYNATRACE_AUTOMATION_CLIENT_SECRET` for authentication.
//
// ## Dynatrace Documentation
//
// - Dynatrace Workflows - https://www.dynatrace.com/support/help/platform-modules/cloud-automation/workflows
//
// ## Prerequisites
//
// Using this resource requires an OAuth client to be configured within your account settings.
// The scopes of the OAuth Client need to include `View workflows (automation:workflows:read)` and `Create and edit workflows (automation:workflows:write)`.
//
// Finally the provider configuration requires the credentials for that OAuth Client.
// The configuration section of your provider needs to look like this.
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			return nil
//		})
//	}
//
// ```
// > In order to handle credentials in a secure manner we recommend to use the environment variables `DYNATRACE_AUTOMATION_CLIENT_ID` and `DYNATRACE_AUTOMATION_CLIENT_SECRET` as an alternative.
//
// ## Resource Example Usage
//
// ```go
// package main
//
// import (
//
//	"encoding/json"
//
//	"github.com/pulumi/pulumi-dynatrace/sdk/go/dynatrace"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			tmpJSON0, err := json.Marshal(map[string]interface{}{
//				"method": "GET",
//				"url":    "https://www.google.at/",
//			})
//			if err != nil {
//				return err
//			}
//			json0 := string(tmpJSON0)
//			tmpJSON1, err := json.Marshal(map[string]interface{}{
//				"method": "GET",
//				"url":    "https://www.second-task.com/",
//			})
//			if err != nil {
//				return err
//			}
//			json1 := string(tmpJSON1)
//			tmpJSON2, err := json.Marshal(map[string]interface{}{
//				"method": "GET",
//				"url":    "https://www.third-task.com",
//			})
//			if err != nil {
//				return err
//			}
//			json2 := string(tmpJSON2)
//			tmpJSON3, err := json.Marshal(map[string]interface{}{
//				"script": `// optional import of sdk modules
//
// import { execution } from '@dynatrace-sdk/automation-utils';
//
//	export default async function ({ execution_id }) {
//	  // your code goes here
//	  // e.g. get the current execution
//	  const ex = await execution(execution_id);
//	  console.log('Automated script execution on behalf of', ex.trigger);
//
//	  return { triggeredBy: ex.trigger };
//	}`,
//
//			})
//			if err != nil {
//				return err
//			}
//			json3 := string(tmpJSON3)
//			_, err = dynatrace.NewAutomationWorkflow(ctx, "sampleWorklowTF", &dynatrace.AutomationWorkflowArgs{
//				Description: pulumi.String("Desc"),
//				Actor:       pulumi.String("########-####-####-####-############"),
//				Title:       pulumi.String("Sample Worklow TF1"),
//				Owner:       pulumi.String("########-####-####-####-############"),
//				Private:     pulumi.Bool(true),
//				Tasks: &dynatrace.AutomationWorkflowTasksArgs{
//					Tasks: dynatrace.AutomationWorkflowTasksTaskArray{
//						&dynatrace.AutomationWorkflowTasksTaskArgs{
//							Name:        pulumi.String("http_request_1"),
//							Description: pulumi.String("Issue an HTTP request to any API"),
//							Action:      pulumi.String("dynatrace.automations:http-function"),
//							Active:      pulumi.Bool(true),
//							Input:       pulumi.String(json0),
//							Position: &dynatrace.AutomationWorkflowTasksTaskPositionArgs{
//								X: pulumi.Int(0),
//								Y: pulumi.Int(1),
//							},
//						},
//						&dynatrace.AutomationWorkflowTasksTaskArgs{
//							Name:        pulumi.String("http_request_2"),
//							Description: pulumi.String("Issue an HTTP request to any API"),
//							Action:      pulumi.String("dynatrace.automations:http-function"),
//							Active:      pulumi.Bool(false),
//							Input:       pulumi.String(json1),
//							Conditions: &dynatrace.AutomationWorkflowTasksTaskConditionsArgs{
//								States: pulumi.Map{
//									"http_request_1":   pulumi.Any("SUCCESS"),
//									"run_javascript_1": pulumi.Any("OK"),
//								},
//								Custom: pulumi.String(""),
//							},
//							Position: &dynatrace.AutomationWorkflowTasksTaskPositionArgs{
//								X: -1,
//								Y: pulumi.Int(2),
//							},
//							Timeout: pulumi.String("50000"),
//						},
//						&dynatrace.AutomationWorkflowTasksTaskArgs{
//							Name:        pulumi.String("http_request_3"),
//							Description: pulumi.String("Issue an HTTP request to any API"),
//							Action:      pulumi.String("dynatrace.automations:http-function"),
//							Active:      pulumi.Bool(false),
//							Input:       pulumi.String(json2),
//							Conditions: &dynatrace.AutomationWorkflowTasksTaskConditionsArgs{
//								States: pulumi.Map{
//									"http_request_2": pulumi.Any("OK"),
//								},
//								Custom: pulumi.String("{{http_request_1}}"),
//							},
//							Position: &dynatrace.AutomationWorkflowTasksTaskPositionArgs{
//								X: pulumi.Int(0),
//								Y: pulumi.Int(3),
//							},
//						},
//						&dynatrace.AutomationWorkflowTasksTaskArgs{
//							Name:        pulumi.String("run_javascript_1"),
//							Description: pulumi.String("Build a custom task running js Code"),
//							Action:      pulumi.String("dynatrace.automations:run-javascript"),
//							Active:      pulumi.Bool(false),
//							Input:       pulumi.String(json3),
//							Position: &dynatrace.AutomationWorkflowTasksTaskPositionArgs{
//								X: -2,
//								Y: pulumi.Int(1),
//							},
//						},
//					},
//				},
//				Trigger: &dynatrace.AutomationWorkflowTriggerArgs{
//					Event: &dynatrace.AutomationWorkflowTriggerEventArgs{
//						Active: pulumi.Bool(false),
//						Config: &dynatrace.AutomationWorkflowTriggerEventConfigArgs{
//							DavisEvent: &dynatrace.AutomationWorkflowTriggerEventConfigDavisEventArgs{
//								EntityTagsMatch: pulumi.String("all"),
//								EntityTags: pulumi.StringMap{
//									"asdf": pulumi.String(""),
//								},
//								OnProblemClose: pulumi.Bool(false),
//								Types: pulumi.StringArray{
//									pulumi.String("CUSTOM_ANNOTATION"),
//								},
//							},
//						},
//					},
//				},
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
type AutomationWorkflow struct {
	pulumi.CustomResourceState

	// The user context the executions of the workflow will happen with
	Actor pulumi.StringPtrOutput `pulumi:"actor"`
	// A description for this task
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The ID of the owner of this workflow
	Owner pulumi.StringPtrOutput `pulumi:"owner"`
	// Defines whether this workflow is private to the owner or not. Default is `true`
	Private pulumi.BoolPtrOutput `pulumi:"private"`
	// The tasks to run for every execution of this workflow
	Tasks AutomationWorkflowTasksOutput `pulumi:"tasks"`
	// The title / name of the workflow
	Title pulumi.StringOutput `pulumi:"title"`
	// Detailed configuration about the timing constraints that trigger the execution
	Trigger AutomationWorkflowTriggerPtrOutput `pulumi:"trigger"`
}

// NewAutomationWorkflow registers a new resource with the given unique name, arguments, and options.
func NewAutomationWorkflow(ctx *pulumi.Context,
	name string, args *AutomationWorkflowArgs, opts ...pulumi.ResourceOption) (*AutomationWorkflow, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Tasks == nil {
		return nil, errors.New("invalid value for required argument 'Tasks'")
	}
	if args.Title == nil {
		return nil, errors.New("invalid value for required argument 'Title'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource AutomationWorkflow
	err := ctx.RegisterResource("dynatrace:index/automationWorkflow:AutomationWorkflow", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAutomationWorkflow gets an existing AutomationWorkflow resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAutomationWorkflow(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AutomationWorkflowState, opts ...pulumi.ResourceOption) (*AutomationWorkflow, error) {
	var resource AutomationWorkflow
	err := ctx.ReadResource("dynatrace:index/automationWorkflow:AutomationWorkflow", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AutomationWorkflow resources.
type automationWorkflowState struct {
	// The user context the executions of the workflow will happen with
	Actor *string `pulumi:"actor"`
	// A description for this task
	Description *string `pulumi:"description"`
	// The ID of the owner of this workflow
	Owner *string `pulumi:"owner"`
	// Defines whether this workflow is private to the owner or not. Default is `true`
	Private *bool `pulumi:"private"`
	// The tasks to run for every execution of this workflow
	Tasks *AutomationWorkflowTasks `pulumi:"tasks"`
	// The title / name of the workflow
	Title *string `pulumi:"title"`
	// Detailed configuration about the timing constraints that trigger the execution
	Trigger *AutomationWorkflowTrigger `pulumi:"trigger"`
}

type AutomationWorkflowState struct {
	// The user context the executions of the workflow will happen with
	Actor pulumi.StringPtrInput
	// A description for this task
	Description pulumi.StringPtrInput
	// The ID of the owner of this workflow
	Owner pulumi.StringPtrInput
	// Defines whether this workflow is private to the owner or not. Default is `true`
	Private pulumi.BoolPtrInput
	// The tasks to run for every execution of this workflow
	Tasks AutomationWorkflowTasksPtrInput
	// The title / name of the workflow
	Title pulumi.StringPtrInput
	// Detailed configuration about the timing constraints that trigger the execution
	Trigger AutomationWorkflowTriggerPtrInput
}

func (AutomationWorkflowState) ElementType() reflect.Type {
	return reflect.TypeOf((*automationWorkflowState)(nil)).Elem()
}

type automationWorkflowArgs struct {
	// The user context the executions of the workflow will happen with
	Actor *string `pulumi:"actor"`
	// A description for this task
	Description *string `pulumi:"description"`
	// The ID of the owner of this workflow
	Owner *string `pulumi:"owner"`
	// Defines whether this workflow is private to the owner or not. Default is `true`
	Private *bool `pulumi:"private"`
	// The tasks to run for every execution of this workflow
	Tasks AutomationWorkflowTasks `pulumi:"tasks"`
	// The title / name of the workflow
	Title string `pulumi:"title"`
	// Detailed configuration about the timing constraints that trigger the execution
	Trigger *AutomationWorkflowTrigger `pulumi:"trigger"`
}

// The set of arguments for constructing a AutomationWorkflow resource.
type AutomationWorkflowArgs struct {
	// The user context the executions of the workflow will happen with
	Actor pulumi.StringPtrInput
	// A description for this task
	Description pulumi.StringPtrInput
	// The ID of the owner of this workflow
	Owner pulumi.StringPtrInput
	// Defines whether this workflow is private to the owner or not. Default is `true`
	Private pulumi.BoolPtrInput
	// The tasks to run for every execution of this workflow
	Tasks AutomationWorkflowTasksInput
	// The title / name of the workflow
	Title pulumi.StringInput
	// Detailed configuration about the timing constraints that trigger the execution
	Trigger AutomationWorkflowTriggerPtrInput
}

func (AutomationWorkflowArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*automationWorkflowArgs)(nil)).Elem()
}

type AutomationWorkflowInput interface {
	pulumi.Input

	ToAutomationWorkflowOutput() AutomationWorkflowOutput
	ToAutomationWorkflowOutputWithContext(ctx context.Context) AutomationWorkflowOutput
}

func (*AutomationWorkflow) ElementType() reflect.Type {
	return reflect.TypeOf((**AutomationWorkflow)(nil)).Elem()
}

func (i *AutomationWorkflow) ToAutomationWorkflowOutput() AutomationWorkflowOutput {
	return i.ToAutomationWorkflowOutputWithContext(context.Background())
}

func (i *AutomationWorkflow) ToAutomationWorkflowOutputWithContext(ctx context.Context) AutomationWorkflowOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AutomationWorkflowOutput)
}

// AutomationWorkflowArrayInput is an input type that accepts AutomationWorkflowArray and AutomationWorkflowArrayOutput values.
// You can construct a concrete instance of `AutomationWorkflowArrayInput` via:
//
//	AutomationWorkflowArray{ AutomationWorkflowArgs{...} }
type AutomationWorkflowArrayInput interface {
	pulumi.Input

	ToAutomationWorkflowArrayOutput() AutomationWorkflowArrayOutput
	ToAutomationWorkflowArrayOutputWithContext(context.Context) AutomationWorkflowArrayOutput
}

type AutomationWorkflowArray []AutomationWorkflowInput

func (AutomationWorkflowArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AutomationWorkflow)(nil)).Elem()
}

func (i AutomationWorkflowArray) ToAutomationWorkflowArrayOutput() AutomationWorkflowArrayOutput {
	return i.ToAutomationWorkflowArrayOutputWithContext(context.Background())
}

func (i AutomationWorkflowArray) ToAutomationWorkflowArrayOutputWithContext(ctx context.Context) AutomationWorkflowArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AutomationWorkflowArrayOutput)
}

// AutomationWorkflowMapInput is an input type that accepts AutomationWorkflowMap and AutomationWorkflowMapOutput values.
// You can construct a concrete instance of `AutomationWorkflowMapInput` via:
//
//	AutomationWorkflowMap{ "key": AutomationWorkflowArgs{...} }
type AutomationWorkflowMapInput interface {
	pulumi.Input

	ToAutomationWorkflowMapOutput() AutomationWorkflowMapOutput
	ToAutomationWorkflowMapOutputWithContext(context.Context) AutomationWorkflowMapOutput
}

type AutomationWorkflowMap map[string]AutomationWorkflowInput

func (AutomationWorkflowMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AutomationWorkflow)(nil)).Elem()
}

func (i AutomationWorkflowMap) ToAutomationWorkflowMapOutput() AutomationWorkflowMapOutput {
	return i.ToAutomationWorkflowMapOutputWithContext(context.Background())
}

func (i AutomationWorkflowMap) ToAutomationWorkflowMapOutputWithContext(ctx context.Context) AutomationWorkflowMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AutomationWorkflowMapOutput)
}

type AutomationWorkflowOutput struct{ *pulumi.OutputState }

func (AutomationWorkflowOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AutomationWorkflow)(nil)).Elem()
}

func (o AutomationWorkflowOutput) ToAutomationWorkflowOutput() AutomationWorkflowOutput {
	return o
}

func (o AutomationWorkflowOutput) ToAutomationWorkflowOutputWithContext(ctx context.Context) AutomationWorkflowOutput {
	return o
}

// The user context the executions of the workflow will happen with
func (o AutomationWorkflowOutput) Actor() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AutomationWorkflow) pulumi.StringPtrOutput { return v.Actor }).(pulumi.StringPtrOutput)
}

// A description for this task
func (o AutomationWorkflowOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AutomationWorkflow) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// The ID of the owner of this workflow
func (o AutomationWorkflowOutput) Owner() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AutomationWorkflow) pulumi.StringPtrOutput { return v.Owner }).(pulumi.StringPtrOutput)
}

// Defines whether this workflow is private to the owner or not. Default is `true`
func (o AutomationWorkflowOutput) Private() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *AutomationWorkflow) pulumi.BoolPtrOutput { return v.Private }).(pulumi.BoolPtrOutput)
}

// The tasks to run for every execution of this workflow
func (o AutomationWorkflowOutput) Tasks() AutomationWorkflowTasksOutput {
	return o.ApplyT(func(v *AutomationWorkflow) AutomationWorkflowTasksOutput { return v.Tasks }).(AutomationWorkflowTasksOutput)
}

// The title / name of the workflow
func (o AutomationWorkflowOutput) Title() pulumi.StringOutput {
	return o.ApplyT(func(v *AutomationWorkflow) pulumi.StringOutput { return v.Title }).(pulumi.StringOutput)
}

// Detailed configuration about the timing constraints that trigger the execution
func (o AutomationWorkflowOutput) Trigger() AutomationWorkflowTriggerPtrOutput {
	return o.ApplyT(func(v *AutomationWorkflow) AutomationWorkflowTriggerPtrOutput { return v.Trigger }).(AutomationWorkflowTriggerPtrOutput)
}

type AutomationWorkflowArrayOutput struct{ *pulumi.OutputState }

func (AutomationWorkflowArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AutomationWorkflow)(nil)).Elem()
}

func (o AutomationWorkflowArrayOutput) ToAutomationWorkflowArrayOutput() AutomationWorkflowArrayOutput {
	return o
}

func (o AutomationWorkflowArrayOutput) ToAutomationWorkflowArrayOutputWithContext(ctx context.Context) AutomationWorkflowArrayOutput {
	return o
}

func (o AutomationWorkflowArrayOutput) Index(i pulumi.IntInput) AutomationWorkflowOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *AutomationWorkflow {
		return vs[0].([]*AutomationWorkflow)[vs[1].(int)]
	}).(AutomationWorkflowOutput)
}

type AutomationWorkflowMapOutput struct{ *pulumi.OutputState }

func (AutomationWorkflowMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AutomationWorkflow)(nil)).Elem()
}

func (o AutomationWorkflowMapOutput) ToAutomationWorkflowMapOutput() AutomationWorkflowMapOutput {
	return o
}

func (o AutomationWorkflowMapOutput) ToAutomationWorkflowMapOutputWithContext(ctx context.Context) AutomationWorkflowMapOutput {
	return o
}

func (o AutomationWorkflowMapOutput) MapIndex(k pulumi.StringInput) AutomationWorkflowOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *AutomationWorkflow {
		return vs[0].(map[string]*AutomationWorkflow)[vs[1].(string)]
	}).(AutomationWorkflowOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*AutomationWorkflowInput)(nil)).Elem(), &AutomationWorkflow{})
	pulumi.RegisterInputType(reflect.TypeOf((*AutomationWorkflowArrayInput)(nil)).Elem(), AutomationWorkflowArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*AutomationWorkflowMapInput)(nil)).Elem(), AutomationWorkflowMap{})
	pulumi.RegisterOutputType(AutomationWorkflowOutput{})
	pulumi.RegisterOutputType(AutomationWorkflowArrayOutput{})
	pulumi.RegisterOutputType(AutomationWorkflowMapOutput{})
}