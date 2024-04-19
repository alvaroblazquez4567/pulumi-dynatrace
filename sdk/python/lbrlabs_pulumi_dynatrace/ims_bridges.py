# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities
from . import outputs
from ._inputs import *

__all__ = ['ImsBridgesArgs', 'ImsBridges']

@pulumi.input_type
class ImsBridgesArgs:
    def __init__(__self__, *,
                 name: Optional[pulumi.Input[str]] = None,
                 queue_managers: Optional[pulumi.Input[Sequence[pulumi.Input['ImsBridgesQueueManagerArgs']]]] = None):
        """
        The set of arguments for constructing a ImsBridges resource.
        :param pulumi.Input[str] name: The name of the queue manager
        :param pulumi.Input[Sequence[pulumi.Input['ImsBridgesQueueManagerArgs']]] queue_managers: Queue manager(s) that belong to the IMS bridge
        """
        if name is not None:
            pulumi.set(__self__, "name", name)
        if queue_managers is not None:
            pulumi.set(__self__, "queue_managers", queue_managers)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the queue manager
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="queueManagers")
    def queue_managers(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ImsBridgesQueueManagerArgs']]]]:
        """
        Queue manager(s) that belong to the IMS bridge
        """
        return pulumi.get(self, "queue_managers")

    @queue_managers.setter
    def queue_managers(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ImsBridgesQueueManagerArgs']]]]):
        pulumi.set(self, "queue_managers", value)


@pulumi.input_type
class _ImsBridgesState:
    def __init__(__self__, *,
                 name: Optional[pulumi.Input[str]] = None,
                 queue_managers: Optional[pulumi.Input[Sequence[pulumi.Input['ImsBridgesQueueManagerArgs']]]] = None):
        """
        Input properties used for looking up and filtering ImsBridges resources.
        :param pulumi.Input[str] name: The name of the queue manager
        :param pulumi.Input[Sequence[pulumi.Input['ImsBridgesQueueManagerArgs']]] queue_managers: Queue manager(s) that belong to the IMS bridge
        """
        if name is not None:
            pulumi.set(__self__, "name", name)
        if queue_managers is not None:
            pulumi.set(__self__, "queue_managers", queue_managers)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the queue manager
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="queueManagers")
    def queue_managers(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ImsBridgesQueueManagerArgs']]]]:
        """
        Queue manager(s) that belong to the IMS bridge
        """
        return pulumi.get(self, "queue_managers")

    @queue_managers.setter
    def queue_managers(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ImsBridgesQueueManagerArgs']]]]):
        pulumi.set(self, "queue_managers", value)


class ImsBridges(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 queue_managers: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ImsBridgesQueueManagerArgs']]]]] = None,
                 __props__=None):
        """
        Create a ImsBridges resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] name: The name of the queue manager
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ImsBridgesQueueManagerArgs']]]] queue_managers: Queue manager(s) that belong to the IMS bridge
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[ImsBridgesArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a ImsBridges resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param ImsBridgesArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ImsBridgesArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 queue_managers: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ImsBridgesQueueManagerArgs']]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ImsBridgesArgs.__new__(ImsBridgesArgs)

            __props__.__dict__["name"] = name
            __props__.__dict__["queue_managers"] = queue_managers
        super(ImsBridges, __self__).__init__(
            'dynatrace:index/imsBridges:ImsBridges',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            name: Optional[pulumi.Input[str]] = None,
            queue_managers: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ImsBridgesQueueManagerArgs']]]]] = None) -> 'ImsBridges':
        """
        Get an existing ImsBridges resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] name: The name of the queue manager
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ImsBridgesQueueManagerArgs']]]] queue_managers: Queue manager(s) that belong to the IMS bridge
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ImsBridgesState.__new__(_ImsBridgesState)

        __props__.__dict__["name"] = name
        __props__.__dict__["queue_managers"] = queue_managers
        return ImsBridges(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the queue manager
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="queueManagers")
    def queue_managers(self) -> pulumi.Output[Optional[Sequence['outputs.ImsBridgesQueueManager']]]:
        """
        Queue manager(s) that belong to the IMS bridge
        """
        return pulumi.get(self, "queue_managers")
