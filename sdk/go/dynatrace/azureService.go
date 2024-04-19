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
// - Microsoft Azure monitoring - https://www.dynatrace.com/support/help/how-to-use-dynatrace/infrastructure-monitoring/cloud-platform-monitoring/microsoft-azure-services-monitoring
//
// - Azure credentials API - https://www.dynatrace.com/support/help/dynatrace-api/configuration-api/azure-credentials-api
//
// ## Resource Example Usage
//
// This example utilizes the data source `getAzureSupportedServices` in order to query for a full list of all supported services.
// The `forEach` loop within the resource `AzureService` configures each of these services to get utilized with the default metrics recommended by Dynatrace (`useRecommendedMetrics`).
//
// If you want to configure a different set of metrics for a specific service, a separate resource `AzureService` will be necessary for that. That allows you to configure the `metric` blocks according to your wishes.
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
//			tERRAFORMSAMPLE, err := dynatrace.NewAzureCredentials(ctx, "tERRAFORMSAMPLE", &dynatrace.AzureCredentialsArgs{
//				Active:                    pulumi.Bool(false),
//				AppId:                     pulumi.String("ABCDE"),
//				AutoTagging:               pulumi.Bool(true),
//				DirectoryId:               pulumi.String("ABCDE"),
//				Label:                     pulumi.String("TERRAFORM_SAMPLE"),
//				Key:                       pulumi.String("aaaa"),
//				MonitorOnlyTaggedEntities: pulumi.Bool(true),
//				MonitorOnlyTagPairs: dynatrace.AzureCredentialsMonitorOnlyTagPairArray{
//					&dynatrace.AzureCredentialsMonitorOnlyTagPairArgs{
//						Name:  pulumi.String("string"),
//						Value: pulumi.String("string"),
//					},
//				},
//			})
//			if err != nil {
//				return err
//			}
//			supportedServices, err := dynatrace.GetAzureSupportedServices(ctx, &dynatrace.GetAzureSupportedServicesArgs{
//				Excepts: []string{
//					"AZURE_STORAGE_ACCOUNT",
//				},
//			}, nil)
//			if err != nil {
//				return err
//			}
//			var tERRAFORMSAMPLEServices []*dynatrace.AzureService
//			for key0, _ := range supportedServices.Services {
//				__res, err := dynatrace.NewAzureService(ctx, fmt.Sprintf("tERRAFORMSAMPLEServices-%v", key0), &dynatrace.AzureServiceArgs{
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
type AzureService struct {
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
	Metrics AzureServiceMetricArrayOutput `pulumi:"metrics"`
	// the name of the metric of the supporting service
	Name pulumi.StringOutput `pulumi:"name"`
	// Used internally by the Terraform Provider in order to remember the metrics enforced by Dynatrace
	RequiredMetrics pulumi.StringOutput `pulumi:"requiredMetrics"`
	// If `true` Terraform will negotiate with the Dynatrace API about the recommended/enforced metrics to be applied. Any
	// `metric` specified will be therefore ignored.
	UseRecommendedMetrics pulumi.BoolPtrOutput `pulumi:"useRecommendedMetrics"`
}

// NewAzureService registers a new resource with the given unique name, arguments, and options.
func NewAzureService(ctx *pulumi.Context,
	name string, args *AzureServiceArgs, opts ...pulumi.ResourceOption) (*AzureService, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.CredentialsId == nil {
		return nil, errors.New("invalid value for required argument 'CredentialsId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource AzureService
	err := ctx.RegisterResource("dynatrace:index/azureService:AzureService", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAzureService gets an existing AzureService resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAzureService(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AzureServiceState, opts ...pulumi.ResourceOption) (*AzureService, error) {
	var resource AzureService
	err := ctx.ReadResource("dynatrace:index/azureService:AzureService", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AzureService resources.
type azureServiceState struct {
	// This attribute is automatically set to `true` if Dynatrace considers the supporting service with the given name to be a built-in service
	BuiltIn *bool `pulumi:"builtIn"`
	// the ID of the azure credentials this supported service belongs to
	CredentialsId *string `pulumi:"credentialsId"`
	// A list of metrics to be monitored for this service. Depending on the service Dynatrace insists on a set of recommended
	// metrics to be configured for that service. If any of these recommended metrics is missing here, the Terraform Provider
	// will automatically add them during `terraform apply`. This usually results in a non-empty plan, until all of the
	// recommended metrics are present within your configuration. For services considered `built-in` by Dynatrace any metrics
	// specified here will be ignored - Dynatrace enforces a fixed set of metrics for these services.
	Metrics []AzureServiceMetric `pulumi:"metrics"`
	// the name of the metric of the supporting service
	Name *string `pulumi:"name"`
	// Used internally by the Terraform Provider in order to remember the metrics enforced by Dynatrace
	RequiredMetrics *string `pulumi:"requiredMetrics"`
	// If `true` Terraform will negotiate with the Dynatrace API about the recommended/enforced metrics to be applied. Any
	// `metric` specified will be therefore ignored.
	UseRecommendedMetrics *bool `pulumi:"useRecommendedMetrics"`
}

type AzureServiceState struct {
	// This attribute is automatically set to `true` if Dynatrace considers the supporting service with the given name to be a built-in service
	BuiltIn pulumi.BoolPtrInput
	// the ID of the azure credentials this supported service belongs to
	CredentialsId pulumi.StringPtrInput
	// A list of metrics to be monitored for this service. Depending on the service Dynatrace insists on a set of recommended
	// metrics to be configured for that service. If any of these recommended metrics is missing here, the Terraform Provider
	// will automatically add them during `terraform apply`. This usually results in a non-empty plan, until all of the
	// recommended metrics are present within your configuration. For services considered `built-in` by Dynatrace any metrics
	// specified here will be ignored - Dynatrace enforces a fixed set of metrics for these services.
	Metrics AzureServiceMetricArrayInput
	// the name of the metric of the supporting service
	Name pulumi.StringPtrInput
	// Used internally by the Terraform Provider in order to remember the metrics enforced by Dynatrace
	RequiredMetrics pulumi.StringPtrInput
	// If `true` Terraform will negotiate with the Dynatrace API about the recommended/enforced metrics to be applied. Any
	// `metric` specified will be therefore ignored.
	UseRecommendedMetrics pulumi.BoolPtrInput
}

func (AzureServiceState) ElementType() reflect.Type {
	return reflect.TypeOf((*azureServiceState)(nil)).Elem()
}

type azureServiceArgs struct {
	// the ID of the azure credentials this supported service belongs to
	CredentialsId string `pulumi:"credentialsId"`
	// A list of metrics to be monitored for this service. Depending on the service Dynatrace insists on a set of recommended
	// metrics to be configured for that service. If any of these recommended metrics is missing here, the Terraform Provider
	// will automatically add them during `terraform apply`. This usually results in a non-empty plan, until all of the
	// recommended metrics are present within your configuration. For services considered `built-in` by Dynatrace any metrics
	// specified here will be ignored - Dynatrace enforces a fixed set of metrics for these services.
	Metrics []AzureServiceMetric `pulumi:"metrics"`
	// the name of the metric of the supporting service
	Name *string `pulumi:"name"`
	// If `true` Terraform will negotiate with the Dynatrace API about the recommended/enforced metrics to be applied. Any
	// `metric` specified will be therefore ignored.
	UseRecommendedMetrics *bool `pulumi:"useRecommendedMetrics"`
}

// The set of arguments for constructing a AzureService resource.
type AzureServiceArgs struct {
	// the ID of the azure credentials this supported service belongs to
	CredentialsId pulumi.StringInput
	// A list of metrics to be monitored for this service. Depending on the service Dynatrace insists on a set of recommended
	// metrics to be configured for that service. If any of these recommended metrics is missing here, the Terraform Provider
	// will automatically add them during `terraform apply`. This usually results in a non-empty plan, until all of the
	// recommended metrics are present within your configuration. For services considered `built-in` by Dynatrace any metrics
	// specified here will be ignored - Dynatrace enforces a fixed set of metrics for these services.
	Metrics AzureServiceMetricArrayInput
	// the name of the metric of the supporting service
	Name pulumi.StringPtrInput
	// If `true` Terraform will negotiate with the Dynatrace API about the recommended/enforced metrics to be applied. Any
	// `metric` specified will be therefore ignored.
	UseRecommendedMetrics pulumi.BoolPtrInput
}

func (AzureServiceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*azureServiceArgs)(nil)).Elem()
}

type AzureServiceInput interface {
	pulumi.Input

	ToAzureServiceOutput() AzureServiceOutput
	ToAzureServiceOutputWithContext(ctx context.Context) AzureServiceOutput
}

func (*AzureService) ElementType() reflect.Type {
	return reflect.TypeOf((**AzureService)(nil)).Elem()
}

func (i *AzureService) ToAzureServiceOutput() AzureServiceOutput {
	return i.ToAzureServiceOutputWithContext(context.Background())
}

func (i *AzureService) ToAzureServiceOutputWithContext(ctx context.Context) AzureServiceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AzureServiceOutput)
}

// AzureServiceArrayInput is an input type that accepts AzureServiceArray and AzureServiceArrayOutput values.
// You can construct a concrete instance of `AzureServiceArrayInput` via:
//
//	AzureServiceArray{ AzureServiceArgs{...} }
type AzureServiceArrayInput interface {
	pulumi.Input

	ToAzureServiceArrayOutput() AzureServiceArrayOutput
	ToAzureServiceArrayOutputWithContext(context.Context) AzureServiceArrayOutput
}

type AzureServiceArray []AzureServiceInput

func (AzureServiceArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AzureService)(nil)).Elem()
}

func (i AzureServiceArray) ToAzureServiceArrayOutput() AzureServiceArrayOutput {
	return i.ToAzureServiceArrayOutputWithContext(context.Background())
}

func (i AzureServiceArray) ToAzureServiceArrayOutputWithContext(ctx context.Context) AzureServiceArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AzureServiceArrayOutput)
}

// AzureServiceMapInput is an input type that accepts AzureServiceMap and AzureServiceMapOutput values.
// You can construct a concrete instance of `AzureServiceMapInput` via:
//
//	AzureServiceMap{ "key": AzureServiceArgs{...} }
type AzureServiceMapInput interface {
	pulumi.Input

	ToAzureServiceMapOutput() AzureServiceMapOutput
	ToAzureServiceMapOutputWithContext(context.Context) AzureServiceMapOutput
}

type AzureServiceMap map[string]AzureServiceInput

func (AzureServiceMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AzureService)(nil)).Elem()
}

func (i AzureServiceMap) ToAzureServiceMapOutput() AzureServiceMapOutput {
	return i.ToAzureServiceMapOutputWithContext(context.Background())
}

func (i AzureServiceMap) ToAzureServiceMapOutputWithContext(ctx context.Context) AzureServiceMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AzureServiceMapOutput)
}

type AzureServiceOutput struct{ *pulumi.OutputState }

func (AzureServiceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AzureService)(nil)).Elem()
}

func (o AzureServiceOutput) ToAzureServiceOutput() AzureServiceOutput {
	return o
}

func (o AzureServiceOutput) ToAzureServiceOutputWithContext(ctx context.Context) AzureServiceOutput {
	return o
}

// This attribute is automatically set to `true` if Dynatrace considers the supporting service with the given name to be a built-in service
func (o AzureServiceOutput) BuiltIn() pulumi.BoolOutput {
	return o.ApplyT(func(v *AzureService) pulumi.BoolOutput { return v.BuiltIn }).(pulumi.BoolOutput)
}

// the ID of the azure credentials this supported service belongs to
func (o AzureServiceOutput) CredentialsId() pulumi.StringOutput {
	return o.ApplyT(func(v *AzureService) pulumi.StringOutput { return v.CredentialsId }).(pulumi.StringOutput)
}

// A list of metrics to be monitored for this service. Depending on the service Dynatrace insists on a set of recommended
// metrics to be configured for that service. If any of these recommended metrics is missing here, the Terraform Provider
// will automatically add them during `terraform apply`. This usually results in a non-empty plan, until all of the
// recommended metrics are present within your configuration. For services considered `built-in` by Dynatrace any metrics
// specified here will be ignored - Dynatrace enforces a fixed set of metrics for these services.
func (o AzureServiceOutput) Metrics() AzureServiceMetricArrayOutput {
	return o.ApplyT(func(v *AzureService) AzureServiceMetricArrayOutput { return v.Metrics }).(AzureServiceMetricArrayOutput)
}

// the name of the metric of the supporting service
func (o AzureServiceOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *AzureService) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Used internally by the Terraform Provider in order to remember the metrics enforced by Dynatrace
func (o AzureServiceOutput) RequiredMetrics() pulumi.StringOutput {
	return o.ApplyT(func(v *AzureService) pulumi.StringOutput { return v.RequiredMetrics }).(pulumi.StringOutput)
}

// If `true` Terraform will negotiate with the Dynatrace API about the recommended/enforced metrics to be applied. Any
// `metric` specified will be therefore ignored.
func (o AzureServiceOutput) UseRecommendedMetrics() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *AzureService) pulumi.BoolPtrOutput { return v.UseRecommendedMetrics }).(pulumi.BoolPtrOutput)
}

type AzureServiceArrayOutput struct{ *pulumi.OutputState }

func (AzureServiceArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AzureService)(nil)).Elem()
}

func (o AzureServiceArrayOutput) ToAzureServiceArrayOutput() AzureServiceArrayOutput {
	return o
}

func (o AzureServiceArrayOutput) ToAzureServiceArrayOutputWithContext(ctx context.Context) AzureServiceArrayOutput {
	return o
}

func (o AzureServiceArrayOutput) Index(i pulumi.IntInput) AzureServiceOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *AzureService {
		return vs[0].([]*AzureService)[vs[1].(int)]
	}).(AzureServiceOutput)
}

type AzureServiceMapOutput struct{ *pulumi.OutputState }

func (AzureServiceMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AzureService)(nil)).Elem()
}

func (o AzureServiceMapOutput) ToAzureServiceMapOutput() AzureServiceMapOutput {
	return o
}

func (o AzureServiceMapOutput) ToAzureServiceMapOutputWithContext(ctx context.Context) AzureServiceMapOutput {
	return o
}

func (o AzureServiceMapOutput) MapIndex(k pulumi.StringInput) AzureServiceOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *AzureService {
		return vs[0].(map[string]*AzureService)[vs[1].(string)]
	}).(AzureServiceOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*AzureServiceInput)(nil)).Elem(), &AzureService{})
	pulumi.RegisterInputType(reflect.TypeOf((*AzureServiceArrayInput)(nil)).Elem(), AzureServiceArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*AzureServiceMapInput)(nil)).Elem(), AzureServiceMap{})
	pulumi.RegisterOutputType(AzureServiceOutput{})
	pulumi.RegisterOutputType(AzureServiceArrayOutput{})
	pulumi.RegisterOutputType(AzureServiceMapOutput{})
}
