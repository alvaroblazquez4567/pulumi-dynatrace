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

// > This resource is excluded by default in the export utility.
//
// > This resource requires the API token scopes **Read configuration** (`ReadConfig`) and **Write configuration** (`WriteConfig`)
//
// ## Dynatrace Documentation
//
// - Amazon Web Services - https://www.dynatrace.com/support/help/setup-and-configuration/setup-on-cloud-platforms/amazon-web-services/amazon-web-services-integrations/aws-service-metrics
//
// - AWS credentials API - https://www.dynatrace.com/support/help/dynatrace-api/configuration-api/aws-credentials-api
//
// ## Resource Example Usage
//
// This example utilizes the data source `getAwsSupportedServices` in order to query for a full list of all supported services.
// The `forEach` loop within the resource `AwsService` configures each of these services to get utilized with the default metrics recommended by Dynatrace (`useRecommendedMetrics`).
//
// If you want to configure a different set of metrics for a specific service, a separate resource `AwsService` will be necessary for that. That allows you to configure the `metric` blocks according to your wishes.
// Just be aware of the fact, that Dynatrace enforces for most services a recommended set of metrics. All of them need to be part of your configuration in order to end up with a non-empty plan.
//
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi-dynatrace/sdk/go/dynatrace"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			tERRAFORMSAMPLE, err := dynatrace.NewAwsCredentials(ctx, "tERRAFORMSAMPLE", &dynatrace.AwsCredentialsArgs{
//				Label:         pulumi.String("TERRAFORM-TEST-001"),
//				PartitionType: pulumi.String("AWS_DEFAULT"),
//				TaggedOnly:    pulumi.Bool(false),
//				AuthenticationData: &dynatrace.AwsCredentialsAuthenticationDataArgs{
//					AccountId: pulumi.String("246186168471"),
//					IamRole:   pulumi.String("Dynatrace_monitoring_role_demo1"),
//				},
//				RemoveDefaults: pulumi.Bool(true),
//			})
//			if err != nil {
//				return err
//			}
//			supportedServices, err := dynatrace.GetAwsSupportedServices(ctx, nil, nil)
//			if err != nil {
//				return err
//			}
//			var tERRAFORMSAMPLEServices []*dynatrace.AwsService
//			for key0, _ := range supportedServices.Services {
//				__res, err := dynatrace.NewAwsService(ctx, fmt.Sprintf("tERRAFORMSAMPLEServices-%v", key0), &dynatrace.AwsServiceArgs{
//					CredentialsId:         tERRAFORMSAMPLE.ID(),
//					UseRecommendedMetrics: pulumi.Bool(true),
//				})
//				if err != nil {
//					return err
//				}
//				tERRAFORMSAMPLEServices = append(tERRAFORMSAMPLEServices, __res)
//			}
//			return nil
//		})
//	}
//
// ```
type AwsService struct {
	pulumi.CustomResourceState

	// This attribute is automatically set to `true` if Dynatrace considers the supporting service with the given name to be a built-in service
	BuiltIn pulumi.BoolOutput `pulumi:"builtIn"`
	// the ID of the azure credentials this supported service belongs to
	CredentialsId pulumi.StringOutput `pulumi:"credentialsId"`
	// A list of metrics to be monitored for this service. Depending on the service Dynatrace insists on a set of recommended
	// metrics to be configured for that service. If any of these recommended metrics is missing here, the Terraform Provider
	// will automatically add them during `terraform apply`. This usually results in a non-empty plan, until all of the
	// recommended metrics are present within your configuration. For services considered `built-in` by Dynatrace any metrics
	// specified here will be ignored - Dynatrace enforces a fixed set of metrics for these services.
	Metrics AwsServiceMetricArrayOutput `pulumi:"metrics"`
	// the name of the metric of the supporting service
	Name pulumi.StringOutput `pulumi:"name"`
	// Used internally by the Terraform Provider in order to remember the metrics enforced by Dynatrace
	RequiredMetrics pulumi.StringOutput `pulumi:"requiredMetrics"`
	// If `true` Terraform will negotiate with the Dynatrace API about the recommended/enforced metrics to be applied. Any
	// `metric` specified will be therefore ignored.
	UseRecommendedMetrics pulumi.BoolPtrOutput `pulumi:"useRecommendedMetrics"`
}

// NewAwsService registers a new resource with the given unique name, arguments, and options.
func NewAwsService(ctx *pulumi.Context,
	name string, args *AwsServiceArgs, opts ...pulumi.ResourceOption) (*AwsService, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.CredentialsId == nil {
		return nil, errors.New("invalid value for required argument 'CredentialsId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource AwsService
	err := ctx.RegisterResource("dynatrace:index/awsService:AwsService", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAwsService gets an existing AwsService resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAwsService(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AwsServiceState, opts ...pulumi.ResourceOption) (*AwsService, error) {
	var resource AwsService
	err := ctx.ReadResource("dynatrace:index/awsService:AwsService", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AwsService resources.
type awsServiceState struct {
	// This attribute is automatically set to `true` if Dynatrace considers the supporting service with the given name to be a built-in service
	BuiltIn *bool `pulumi:"builtIn"`
	// the ID of the azure credentials this supported service belongs to
	CredentialsId *string `pulumi:"credentialsId"`
	// A list of metrics to be monitored for this service. Depending on the service Dynatrace insists on a set of recommended
	// metrics to be configured for that service. If any of these recommended metrics is missing here, the Terraform Provider
	// will automatically add them during `terraform apply`. This usually results in a non-empty plan, until all of the
	// recommended metrics are present within your configuration. For services considered `built-in` by Dynatrace any metrics
	// specified here will be ignored - Dynatrace enforces a fixed set of metrics for these services.
	Metrics []AwsServiceMetric `pulumi:"metrics"`
	// the name of the metric of the supporting service
	Name *string `pulumi:"name"`
	// Used internally by the Terraform Provider in order to remember the metrics enforced by Dynatrace
	RequiredMetrics *string `pulumi:"requiredMetrics"`
	// If `true` Terraform will negotiate with the Dynatrace API about the recommended/enforced metrics to be applied. Any
	// `metric` specified will be therefore ignored.
	UseRecommendedMetrics *bool `pulumi:"useRecommendedMetrics"`
}

type AwsServiceState struct {
	// This attribute is automatically set to `true` if Dynatrace considers the supporting service with the given name to be a built-in service
	BuiltIn pulumi.BoolPtrInput
	// the ID of the azure credentials this supported service belongs to
	CredentialsId pulumi.StringPtrInput
	// A list of metrics to be monitored for this service. Depending on the service Dynatrace insists on a set of recommended
	// metrics to be configured for that service. If any of these recommended metrics is missing here, the Terraform Provider
	// will automatically add them during `terraform apply`. This usually results in a non-empty plan, until all of the
	// recommended metrics are present within your configuration. For services considered `built-in` by Dynatrace any metrics
	// specified here will be ignored - Dynatrace enforces a fixed set of metrics for these services.
	Metrics AwsServiceMetricArrayInput
	// the name of the metric of the supporting service
	Name pulumi.StringPtrInput
	// Used internally by the Terraform Provider in order to remember the metrics enforced by Dynatrace
	RequiredMetrics pulumi.StringPtrInput
	// If `true` Terraform will negotiate with the Dynatrace API about the recommended/enforced metrics to be applied. Any
	// `metric` specified will be therefore ignored.
	UseRecommendedMetrics pulumi.BoolPtrInput
}

func (AwsServiceState) ElementType() reflect.Type {
	return reflect.TypeOf((*awsServiceState)(nil)).Elem()
}

type awsServiceArgs struct {
	// the ID of the azure credentials this supported service belongs to
	CredentialsId string `pulumi:"credentialsId"`
	// A list of metrics to be monitored for this service. Depending on the service Dynatrace insists on a set of recommended
	// metrics to be configured for that service. If any of these recommended metrics is missing here, the Terraform Provider
	// will automatically add them during `terraform apply`. This usually results in a non-empty plan, until all of the
	// recommended metrics are present within your configuration. For services considered `built-in` by Dynatrace any metrics
	// specified here will be ignored - Dynatrace enforces a fixed set of metrics for these services.
	Metrics []AwsServiceMetric `pulumi:"metrics"`
	// the name of the metric of the supporting service
	Name *string `pulumi:"name"`
	// If `true` Terraform will negotiate with the Dynatrace API about the recommended/enforced metrics to be applied. Any
	// `metric` specified will be therefore ignored.
	UseRecommendedMetrics *bool `pulumi:"useRecommendedMetrics"`
}

// The set of arguments for constructing a AwsService resource.
type AwsServiceArgs struct {
	// the ID of the azure credentials this supported service belongs to
	CredentialsId pulumi.StringInput
	// A list of metrics to be monitored for this service. Depending on the service Dynatrace insists on a set of recommended
	// metrics to be configured for that service. If any of these recommended metrics is missing here, the Terraform Provider
	// will automatically add them during `terraform apply`. This usually results in a non-empty plan, until all of the
	// recommended metrics are present within your configuration. For services considered `built-in` by Dynatrace any metrics
	// specified here will be ignored - Dynatrace enforces a fixed set of metrics for these services.
	Metrics AwsServiceMetricArrayInput
	// the name of the metric of the supporting service
	Name pulumi.StringPtrInput
	// If `true` Terraform will negotiate with the Dynatrace API about the recommended/enforced metrics to be applied. Any
	// `metric` specified will be therefore ignored.
	UseRecommendedMetrics pulumi.BoolPtrInput
}

func (AwsServiceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*awsServiceArgs)(nil)).Elem()
}

type AwsServiceInput interface {
	pulumi.Input

	ToAwsServiceOutput() AwsServiceOutput
	ToAwsServiceOutputWithContext(ctx context.Context) AwsServiceOutput
}

func (*AwsService) ElementType() reflect.Type {
	return reflect.TypeOf((**AwsService)(nil)).Elem()
}

func (i *AwsService) ToAwsServiceOutput() AwsServiceOutput {
	return i.ToAwsServiceOutputWithContext(context.Background())
}

func (i *AwsService) ToAwsServiceOutputWithContext(ctx context.Context) AwsServiceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AwsServiceOutput)
}

// AwsServiceArrayInput is an input type that accepts AwsServiceArray and AwsServiceArrayOutput values.
// You can construct a concrete instance of `AwsServiceArrayInput` via:
//
//	AwsServiceArray{ AwsServiceArgs{...} }
type AwsServiceArrayInput interface {
	pulumi.Input

	ToAwsServiceArrayOutput() AwsServiceArrayOutput
	ToAwsServiceArrayOutputWithContext(context.Context) AwsServiceArrayOutput
}

type AwsServiceArray []AwsServiceInput

func (AwsServiceArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AwsService)(nil)).Elem()
}

func (i AwsServiceArray) ToAwsServiceArrayOutput() AwsServiceArrayOutput {
	return i.ToAwsServiceArrayOutputWithContext(context.Background())
}

func (i AwsServiceArray) ToAwsServiceArrayOutputWithContext(ctx context.Context) AwsServiceArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AwsServiceArrayOutput)
}

// AwsServiceMapInput is an input type that accepts AwsServiceMap and AwsServiceMapOutput values.
// You can construct a concrete instance of `AwsServiceMapInput` via:
//
//	AwsServiceMap{ "key": AwsServiceArgs{...} }
type AwsServiceMapInput interface {
	pulumi.Input

	ToAwsServiceMapOutput() AwsServiceMapOutput
	ToAwsServiceMapOutputWithContext(context.Context) AwsServiceMapOutput
}

type AwsServiceMap map[string]AwsServiceInput

func (AwsServiceMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AwsService)(nil)).Elem()
}

func (i AwsServiceMap) ToAwsServiceMapOutput() AwsServiceMapOutput {
	return i.ToAwsServiceMapOutputWithContext(context.Background())
}

func (i AwsServiceMap) ToAwsServiceMapOutputWithContext(ctx context.Context) AwsServiceMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AwsServiceMapOutput)
}

type AwsServiceOutput struct{ *pulumi.OutputState }

func (AwsServiceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AwsService)(nil)).Elem()
}

func (o AwsServiceOutput) ToAwsServiceOutput() AwsServiceOutput {
	return o
}

func (o AwsServiceOutput) ToAwsServiceOutputWithContext(ctx context.Context) AwsServiceOutput {
	return o
}

// This attribute is automatically set to `true` if Dynatrace considers the supporting service with the given name to be a built-in service
func (o AwsServiceOutput) BuiltIn() pulumi.BoolOutput {
	return o.ApplyT(func(v *AwsService) pulumi.BoolOutput { return v.BuiltIn }).(pulumi.BoolOutput)
}

// the ID of the azure credentials this supported service belongs to
func (o AwsServiceOutput) CredentialsId() pulumi.StringOutput {
	return o.ApplyT(func(v *AwsService) pulumi.StringOutput { return v.CredentialsId }).(pulumi.StringOutput)
}

// A list of metrics to be monitored for this service. Depending on the service Dynatrace insists on a set of recommended
// metrics to be configured for that service. If any of these recommended metrics is missing here, the Terraform Provider
// will automatically add them during `terraform apply`. This usually results in a non-empty plan, until all of the
// recommended metrics are present within your configuration. For services considered `built-in` by Dynatrace any metrics
// specified here will be ignored - Dynatrace enforces a fixed set of metrics for these services.
func (o AwsServiceOutput) Metrics() AwsServiceMetricArrayOutput {
	return o.ApplyT(func(v *AwsService) AwsServiceMetricArrayOutput { return v.Metrics }).(AwsServiceMetricArrayOutput)
}

// the name of the metric of the supporting service
func (o AwsServiceOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *AwsService) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Used internally by the Terraform Provider in order to remember the metrics enforced by Dynatrace
func (o AwsServiceOutput) RequiredMetrics() pulumi.StringOutput {
	return o.ApplyT(func(v *AwsService) pulumi.StringOutput { return v.RequiredMetrics }).(pulumi.StringOutput)
}

// If `true` Terraform will negotiate with the Dynatrace API about the recommended/enforced metrics to be applied. Any
// `metric` specified will be therefore ignored.
func (o AwsServiceOutput) UseRecommendedMetrics() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *AwsService) pulumi.BoolPtrOutput { return v.UseRecommendedMetrics }).(pulumi.BoolPtrOutput)
}

type AwsServiceArrayOutput struct{ *pulumi.OutputState }

func (AwsServiceArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AwsService)(nil)).Elem()
}

func (o AwsServiceArrayOutput) ToAwsServiceArrayOutput() AwsServiceArrayOutput {
	return o
}

func (o AwsServiceArrayOutput) ToAwsServiceArrayOutputWithContext(ctx context.Context) AwsServiceArrayOutput {
	return o
}

func (o AwsServiceArrayOutput) Index(i pulumi.IntInput) AwsServiceOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *AwsService {
		return vs[0].([]*AwsService)[vs[1].(int)]
	}).(AwsServiceOutput)
}

type AwsServiceMapOutput struct{ *pulumi.OutputState }

func (AwsServiceMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AwsService)(nil)).Elem()
}

func (o AwsServiceMapOutput) ToAwsServiceMapOutput() AwsServiceMapOutput {
	return o
}

func (o AwsServiceMapOutput) ToAwsServiceMapOutputWithContext(ctx context.Context) AwsServiceMapOutput {
	return o
}

func (o AwsServiceMapOutput) MapIndex(k pulumi.StringInput) AwsServiceOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *AwsService {
		return vs[0].(map[string]*AwsService)[vs[1].(string)]
	}).(AwsServiceOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*AwsServiceInput)(nil)).Elem(), &AwsService{})
	pulumi.RegisterInputType(reflect.TypeOf((*AwsServiceArrayInput)(nil)).Elem(), AwsServiceArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*AwsServiceMapInput)(nil)).Elem(), AwsServiceMap{})
	pulumi.RegisterOutputType(AwsServiceOutput{})
	pulumi.RegisterOutputType(AwsServiceArrayOutput{})
	pulumi.RegisterOutputType(AwsServiceMapOutput{})
}
