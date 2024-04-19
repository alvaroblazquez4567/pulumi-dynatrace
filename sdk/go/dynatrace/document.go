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
// - Dynatrace Documents - https://########.apps.dynatrace.com/platform/swagger-ui/index.html?urls.primaryName=Document%20Service
//
// ## Prerequisites
//
// Using this resource requires an OAuth client to be configured within your account settings.
// The scopes of the OAuth Client need to include `Create and edit documents (document:documents:write)`, `View documents (document:documents:read)`, `Delete documents (document:documents:delete)`.
//
// Finally the provider configuration requires the credentials for that OAuth Client.
// The configuration section of your provider needs to look like this.
//
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
//
// > In order to handle credentials in a secure manner we recommend to use the environment variables `DYNATRACE_AUTOMATION_CLIENT_ID` and `DYNATRACE_AUTOMATION_CLIENT_SECRET` as an alternative.
type Document struct {
	pulumi.CustomResourceState

	// The user context the executions of the document will happen with
	Actor pulumi.StringOutput `pulumi:"actor"`
	// Document content as JSON
	Content pulumi.StringOutput `pulumi:"content"`
	// The name/name of the document
	Name pulumi.StringOutput `pulumi:"name"`
	// The ID of the owner of this document
	Owner pulumi.StringOutput `pulumi:"owner"`
	// Type of the document. Possible Values are `dashboard` and `notebook`
	Type pulumi.StringOutput `pulumi:"type"`
	// The version of the document
	Version pulumi.IntOutput `pulumi:"version"`
}

// NewDocument registers a new resource with the given unique name, arguments, and options.
func NewDocument(ctx *pulumi.Context,
	name string, args *DocumentArgs, opts ...pulumi.ResourceOption) (*Document, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Content == nil {
		return nil, errors.New("invalid value for required argument 'Content'")
	}
	if args.Type == nil {
		return nil, errors.New("invalid value for required argument 'Type'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource Document
	err := ctx.RegisterResource("dynatrace:index/document:Document", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDocument gets an existing Document resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDocument(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DocumentState, opts ...pulumi.ResourceOption) (*Document, error) {
	var resource Document
	err := ctx.ReadResource("dynatrace:index/document:Document", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Document resources.
type documentState struct {
	// The user context the executions of the document will happen with
	Actor *string `pulumi:"actor"`
	// Document content as JSON
	Content *string `pulumi:"content"`
	// The name/name of the document
	Name *string `pulumi:"name"`
	// The ID of the owner of this document
	Owner *string `pulumi:"owner"`
	// Type of the document. Possible Values are `dashboard` and `notebook`
	Type *string `pulumi:"type"`
	// The version of the document
	Version *int `pulumi:"version"`
}

type DocumentState struct {
	// The user context the executions of the document will happen with
	Actor pulumi.StringPtrInput
	// Document content as JSON
	Content pulumi.StringPtrInput
	// The name/name of the document
	Name pulumi.StringPtrInput
	// The ID of the owner of this document
	Owner pulumi.StringPtrInput
	// Type of the document. Possible Values are `dashboard` and `notebook`
	Type pulumi.StringPtrInput
	// The version of the document
	Version pulumi.IntPtrInput
}

func (DocumentState) ElementType() reflect.Type {
	return reflect.TypeOf((*documentState)(nil)).Elem()
}

type documentArgs struct {
	// The user context the executions of the document will happen with
	Actor *string `pulumi:"actor"`
	// Document content as JSON
	Content string `pulumi:"content"`
	// The name/name of the document
	Name *string `pulumi:"name"`
	// The ID of the owner of this document
	Owner *string `pulumi:"owner"`
	// Type of the document. Possible Values are `dashboard` and `notebook`
	Type string `pulumi:"type"`
}

// The set of arguments for constructing a Document resource.
type DocumentArgs struct {
	// The user context the executions of the document will happen with
	Actor pulumi.StringPtrInput
	// Document content as JSON
	Content pulumi.StringInput
	// The name/name of the document
	Name pulumi.StringPtrInput
	// The ID of the owner of this document
	Owner pulumi.StringPtrInput
	// Type of the document. Possible Values are `dashboard` and `notebook`
	Type pulumi.StringInput
}

func (DocumentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*documentArgs)(nil)).Elem()
}

type DocumentInput interface {
	pulumi.Input

	ToDocumentOutput() DocumentOutput
	ToDocumentOutputWithContext(ctx context.Context) DocumentOutput
}

func (*Document) ElementType() reflect.Type {
	return reflect.TypeOf((**Document)(nil)).Elem()
}

func (i *Document) ToDocumentOutput() DocumentOutput {
	return i.ToDocumentOutputWithContext(context.Background())
}

func (i *Document) ToDocumentOutputWithContext(ctx context.Context) DocumentOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DocumentOutput)
}

// DocumentArrayInput is an input type that accepts DocumentArray and DocumentArrayOutput values.
// You can construct a concrete instance of `DocumentArrayInput` via:
//
//	DocumentArray{ DocumentArgs{...} }
type DocumentArrayInput interface {
	pulumi.Input

	ToDocumentArrayOutput() DocumentArrayOutput
	ToDocumentArrayOutputWithContext(context.Context) DocumentArrayOutput
}

type DocumentArray []DocumentInput

func (DocumentArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Document)(nil)).Elem()
}

func (i DocumentArray) ToDocumentArrayOutput() DocumentArrayOutput {
	return i.ToDocumentArrayOutputWithContext(context.Background())
}

func (i DocumentArray) ToDocumentArrayOutputWithContext(ctx context.Context) DocumentArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DocumentArrayOutput)
}

// DocumentMapInput is an input type that accepts DocumentMap and DocumentMapOutput values.
// You can construct a concrete instance of `DocumentMapInput` via:
//
//	DocumentMap{ "key": DocumentArgs{...} }
type DocumentMapInput interface {
	pulumi.Input

	ToDocumentMapOutput() DocumentMapOutput
	ToDocumentMapOutputWithContext(context.Context) DocumentMapOutput
}

type DocumentMap map[string]DocumentInput

func (DocumentMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Document)(nil)).Elem()
}

func (i DocumentMap) ToDocumentMapOutput() DocumentMapOutput {
	return i.ToDocumentMapOutputWithContext(context.Background())
}

func (i DocumentMap) ToDocumentMapOutputWithContext(ctx context.Context) DocumentMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DocumentMapOutput)
}

type DocumentOutput struct{ *pulumi.OutputState }

func (DocumentOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Document)(nil)).Elem()
}

func (o DocumentOutput) ToDocumentOutput() DocumentOutput {
	return o
}

func (o DocumentOutput) ToDocumentOutputWithContext(ctx context.Context) DocumentOutput {
	return o
}

// The user context the executions of the document will happen with
func (o DocumentOutput) Actor() pulumi.StringOutput {
	return o.ApplyT(func(v *Document) pulumi.StringOutput { return v.Actor }).(pulumi.StringOutput)
}

// Document content as JSON
func (o DocumentOutput) Content() pulumi.StringOutput {
	return o.ApplyT(func(v *Document) pulumi.StringOutput { return v.Content }).(pulumi.StringOutput)
}

// The name/name of the document
func (o DocumentOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *Document) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// The ID of the owner of this document
func (o DocumentOutput) Owner() pulumi.StringOutput {
	return o.ApplyT(func(v *Document) pulumi.StringOutput { return v.Owner }).(pulumi.StringOutput)
}

// Type of the document. Possible Values are `dashboard` and `notebook`
func (o DocumentOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v *Document) pulumi.StringOutput { return v.Type }).(pulumi.StringOutput)
}

// The version of the document
func (o DocumentOutput) Version() pulumi.IntOutput {
	return o.ApplyT(func(v *Document) pulumi.IntOutput { return v.Version }).(pulumi.IntOutput)
}

type DocumentArrayOutput struct{ *pulumi.OutputState }

func (DocumentArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Document)(nil)).Elem()
}

func (o DocumentArrayOutput) ToDocumentArrayOutput() DocumentArrayOutput {
	return o
}

func (o DocumentArrayOutput) ToDocumentArrayOutputWithContext(ctx context.Context) DocumentArrayOutput {
	return o
}

func (o DocumentArrayOutput) Index(i pulumi.IntInput) DocumentOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Document {
		return vs[0].([]*Document)[vs[1].(int)]
	}).(DocumentOutput)
}

type DocumentMapOutput struct{ *pulumi.OutputState }

func (DocumentMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Document)(nil)).Elem()
}

func (o DocumentMapOutput) ToDocumentMapOutput() DocumentMapOutput {
	return o
}

func (o DocumentMapOutput) ToDocumentMapOutputWithContext(ctx context.Context) DocumentMapOutput {
	return o
}

func (o DocumentMapOutput) MapIndex(k pulumi.StringInput) DocumentOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Document {
		return vs[0].(map[string]*Document)[vs[1].(string)]
	}).(DocumentOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*DocumentInput)(nil)).Elem(), &Document{})
	pulumi.RegisterInputType(reflect.TypeOf((*DocumentArrayInput)(nil)).Elem(), DocumentArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*DocumentMapInput)(nil)).Elem(), DocumentMap{})
	pulumi.RegisterOutputType(DocumentOutput{})
	pulumi.RegisterOutputType(DocumentArrayOutput{})
	pulumi.RegisterOutputType(DocumentMapOutput{})
}