// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dynatrace

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi-dynatrace/sdk/go/dynatrace/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type QueueManager struct {
	pulumi.CustomResourceState

	// The alias queues in the queue manager
	AliasQueues QueueManagerAliasQueueArrayOutput `pulumi:"aliasQueues"`
	// The alias queues in the queue manager
	ClusterQueues QueueManagerClusterQueueArrayOutput `pulumi:"clusterQueues"`
	// Name of the cluster(s) this queue manager is part of
	Clusters pulumi.StringArrayOutput `pulumi:"clusters"`
	// The name of the queue manager
	Name pulumi.StringOutput `pulumi:"name"`
	// The alias queues in the queue manager
	RemoteQueues QueueManagerRemoteQueueArrayOutput `pulumi:"remoteQueues"`
}

// NewQueueManager registers a new resource with the given unique name, arguments, and options.
func NewQueueManager(ctx *pulumi.Context,
	name string, args *QueueManagerArgs, opts ...pulumi.ResourceOption) (*QueueManager, error) {
	if args == nil {
		args = &QueueManagerArgs{}
	}

	opts = internal.PkgResourceDefaultOpts(opts)
	var resource QueueManager
	err := ctx.RegisterResource("dynatrace:index/queueManager:QueueManager", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetQueueManager gets an existing QueueManager resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetQueueManager(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *QueueManagerState, opts ...pulumi.ResourceOption) (*QueueManager, error) {
	var resource QueueManager
	err := ctx.ReadResource("dynatrace:index/queueManager:QueueManager", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering QueueManager resources.
type queueManagerState struct {
	// The alias queues in the queue manager
	AliasQueues []QueueManagerAliasQueue `pulumi:"aliasQueues"`
	// The alias queues in the queue manager
	ClusterQueues []QueueManagerClusterQueue `pulumi:"clusterQueues"`
	// Name of the cluster(s) this queue manager is part of
	Clusters []string `pulumi:"clusters"`
	// The name of the queue manager
	Name *string `pulumi:"name"`
	// The alias queues in the queue manager
	RemoteQueues []QueueManagerRemoteQueue `pulumi:"remoteQueues"`
}

type QueueManagerState struct {
	// The alias queues in the queue manager
	AliasQueues QueueManagerAliasQueueArrayInput
	// The alias queues in the queue manager
	ClusterQueues QueueManagerClusterQueueArrayInput
	// Name of the cluster(s) this queue manager is part of
	Clusters pulumi.StringArrayInput
	// The name of the queue manager
	Name pulumi.StringPtrInput
	// The alias queues in the queue manager
	RemoteQueues QueueManagerRemoteQueueArrayInput
}

func (QueueManagerState) ElementType() reflect.Type {
	return reflect.TypeOf((*queueManagerState)(nil)).Elem()
}

type queueManagerArgs struct {
	// The alias queues in the queue manager
	AliasQueues []QueueManagerAliasQueue `pulumi:"aliasQueues"`
	// The alias queues in the queue manager
	ClusterQueues []QueueManagerClusterQueue `pulumi:"clusterQueues"`
	// Name of the cluster(s) this queue manager is part of
	Clusters []string `pulumi:"clusters"`
	// The name of the queue manager
	Name *string `pulumi:"name"`
	// The alias queues in the queue manager
	RemoteQueues []QueueManagerRemoteQueue `pulumi:"remoteQueues"`
}

// The set of arguments for constructing a QueueManager resource.
type QueueManagerArgs struct {
	// The alias queues in the queue manager
	AliasQueues QueueManagerAliasQueueArrayInput
	// The alias queues in the queue manager
	ClusterQueues QueueManagerClusterQueueArrayInput
	// Name of the cluster(s) this queue manager is part of
	Clusters pulumi.StringArrayInput
	// The name of the queue manager
	Name pulumi.StringPtrInput
	// The alias queues in the queue manager
	RemoteQueues QueueManagerRemoteQueueArrayInput
}

func (QueueManagerArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*queueManagerArgs)(nil)).Elem()
}

type QueueManagerInput interface {
	pulumi.Input

	ToQueueManagerOutput() QueueManagerOutput
	ToQueueManagerOutputWithContext(ctx context.Context) QueueManagerOutput
}

func (*QueueManager) ElementType() reflect.Type {
	return reflect.TypeOf((**QueueManager)(nil)).Elem()
}

func (i *QueueManager) ToQueueManagerOutput() QueueManagerOutput {
	return i.ToQueueManagerOutputWithContext(context.Background())
}

func (i *QueueManager) ToQueueManagerOutputWithContext(ctx context.Context) QueueManagerOutput {
	return pulumi.ToOutputWithContext(ctx, i).(QueueManagerOutput)
}

// QueueManagerArrayInput is an input type that accepts QueueManagerArray and QueueManagerArrayOutput values.
// You can construct a concrete instance of `QueueManagerArrayInput` via:
//
//	QueueManagerArray{ QueueManagerArgs{...} }
type QueueManagerArrayInput interface {
	pulumi.Input

	ToQueueManagerArrayOutput() QueueManagerArrayOutput
	ToQueueManagerArrayOutputWithContext(context.Context) QueueManagerArrayOutput
}

type QueueManagerArray []QueueManagerInput

func (QueueManagerArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*QueueManager)(nil)).Elem()
}

func (i QueueManagerArray) ToQueueManagerArrayOutput() QueueManagerArrayOutput {
	return i.ToQueueManagerArrayOutputWithContext(context.Background())
}

func (i QueueManagerArray) ToQueueManagerArrayOutputWithContext(ctx context.Context) QueueManagerArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(QueueManagerArrayOutput)
}

// QueueManagerMapInput is an input type that accepts QueueManagerMap and QueueManagerMapOutput values.
// You can construct a concrete instance of `QueueManagerMapInput` via:
//
//	QueueManagerMap{ "key": QueueManagerArgs{...} }
type QueueManagerMapInput interface {
	pulumi.Input

	ToQueueManagerMapOutput() QueueManagerMapOutput
	ToQueueManagerMapOutputWithContext(context.Context) QueueManagerMapOutput
}

type QueueManagerMap map[string]QueueManagerInput

func (QueueManagerMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*QueueManager)(nil)).Elem()
}

func (i QueueManagerMap) ToQueueManagerMapOutput() QueueManagerMapOutput {
	return i.ToQueueManagerMapOutputWithContext(context.Background())
}

func (i QueueManagerMap) ToQueueManagerMapOutputWithContext(ctx context.Context) QueueManagerMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(QueueManagerMapOutput)
}

type QueueManagerOutput struct{ *pulumi.OutputState }

func (QueueManagerOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**QueueManager)(nil)).Elem()
}

func (o QueueManagerOutput) ToQueueManagerOutput() QueueManagerOutput {
	return o
}

func (o QueueManagerOutput) ToQueueManagerOutputWithContext(ctx context.Context) QueueManagerOutput {
	return o
}

// The alias queues in the queue manager
func (o QueueManagerOutput) AliasQueues() QueueManagerAliasQueueArrayOutput {
	return o.ApplyT(func(v *QueueManager) QueueManagerAliasQueueArrayOutput { return v.AliasQueues }).(QueueManagerAliasQueueArrayOutput)
}

// The alias queues in the queue manager
func (o QueueManagerOutput) ClusterQueues() QueueManagerClusterQueueArrayOutput {
	return o.ApplyT(func(v *QueueManager) QueueManagerClusterQueueArrayOutput { return v.ClusterQueues }).(QueueManagerClusterQueueArrayOutput)
}

// Name of the cluster(s) this queue manager is part of
func (o QueueManagerOutput) Clusters() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *QueueManager) pulumi.StringArrayOutput { return v.Clusters }).(pulumi.StringArrayOutput)
}

// The name of the queue manager
func (o QueueManagerOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *QueueManager) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// The alias queues in the queue manager
func (o QueueManagerOutput) RemoteQueues() QueueManagerRemoteQueueArrayOutput {
	return o.ApplyT(func(v *QueueManager) QueueManagerRemoteQueueArrayOutput { return v.RemoteQueues }).(QueueManagerRemoteQueueArrayOutput)
}

type QueueManagerArrayOutput struct{ *pulumi.OutputState }

func (QueueManagerArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*QueueManager)(nil)).Elem()
}

func (o QueueManagerArrayOutput) ToQueueManagerArrayOutput() QueueManagerArrayOutput {
	return o
}

func (o QueueManagerArrayOutput) ToQueueManagerArrayOutputWithContext(ctx context.Context) QueueManagerArrayOutput {
	return o
}

func (o QueueManagerArrayOutput) Index(i pulumi.IntInput) QueueManagerOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *QueueManager {
		return vs[0].([]*QueueManager)[vs[1].(int)]
	}).(QueueManagerOutput)
}

type QueueManagerMapOutput struct{ *pulumi.OutputState }

func (QueueManagerMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*QueueManager)(nil)).Elem()
}

func (o QueueManagerMapOutput) ToQueueManagerMapOutput() QueueManagerMapOutput {
	return o
}

func (o QueueManagerMapOutput) ToQueueManagerMapOutputWithContext(ctx context.Context) QueueManagerMapOutput {
	return o
}

func (o QueueManagerMapOutput) MapIndex(k pulumi.StringInput) QueueManagerOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *QueueManager {
		return vs[0].(map[string]*QueueManager)[vs[1].(string)]
	}).(QueueManagerOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*QueueManagerInput)(nil)).Elem(), &QueueManager{})
	pulumi.RegisterInputType(reflect.TypeOf((*QueueManagerArrayInput)(nil)).Elem(), QueueManagerArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*QueueManagerMapInput)(nil)).Elem(), QueueManagerMap{})
	pulumi.RegisterOutputType(QueueManagerOutput{})
	pulumi.RegisterOutputType(QueueManagerArrayOutput{})
	pulumi.RegisterOutputType(QueueManagerMapOutput{})
}
