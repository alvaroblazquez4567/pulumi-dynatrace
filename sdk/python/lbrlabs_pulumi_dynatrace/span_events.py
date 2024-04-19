# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['SpanEventsArgs', 'SpanEvents']

@pulumi.input_type
class SpanEventsArgs:
    def __init__(__self__, *,
                 key: pulumi.Input[str],
                 masking: pulumi.Input[str]):
        """
        The set of arguments for constructing a SpanEvents resource.
        :param pulumi.Input[str] key: Key of the span event attribute to store
        :param pulumi.Input[str] masking: Possible Values: `MASK_ENTIRE_VALUE`, `MASK_ONLY_CONFIDENTIAL_DATA`, `NOT_MASKED`
        """
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "masking", masking)

    @property
    @pulumi.getter
    def key(self) -> pulumi.Input[str]:
        """
        Key of the span event attribute to store
        """
        return pulumi.get(self, "key")

    @key.setter
    def key(self, value: pulumi.Input[str]):
        pulumi.set(self, "key", value)

    @property
    @pulumi.getter
    def masking(self) -> pulumi.Input[str]:
        """
        Possible Values: `MASK_ENTIRE_VALUE`, `MASK_ONLY_CONFIDENTIAL_DATA`, `NOT_MASKED`
        """
        return pulumi.get(self, "masking")

    @masking.setter
    def masking(self, value: pulumi.Input[str]):
        pulumi.set(self, "masking", value)


@pulumi.input_type
class _SpanEventsState:
    def __init__(__self__, *,
                 key: Optional[pulumi.Input[str]] = None,
                 masking: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering SpanEvents resources.
        :param pulumi.Input[str] key: Key of the span event attribute to store
        :param pulumi.Input[str] masking: Possible Values: `MASK_ENTIRE_VALUE`, `MASK_ONLY_CONFIDENTIAL_DATA`, `NOT_MASKED`
        """
        if key is not None:
            pulumi.set(__self__, "key", key)
        if masking is not None:
            pulumi.set(__self__, "masking", masking)

    @property
    @pulumi.getter
    def key(self) -> Optional[pulumi.Input[str]]:
        """
        Key of the span event attribute to store
        """
        return pulumi.get(self, "key")

    @key.setter
    def key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key", value)

    @property
    @pulumi.getter
    def masking(self) -> Optional[pulumi.Input[str]]:
        """
        Possible Values: `MASK_ENTIRE_VALUE`, `MASK_ONLY_CONFIDENTIAL_DATA`, `NOT_MASKED`
        """
        return pulumi.get(self, "masking")

    @masking.setter
    def masking(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "masking", value)


class SpanEvents(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 key: Optional[pulumi.Input[str]] = None,
                 masking: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a SpanEvents resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] key: Key of the span event attribute to store
        :param pulumi.Input[str] masking: Possible Values: `MASK_ENTIRE_VALUE`, `MASK_ONLY_CONFIDENTIAL_DATA`, `NOT_MASKED`
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: SpanEventsArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a SpanEvents resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param SpanEventsArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(SpanEventsArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 key: Optional[pulumi.Input[str]] = None,
                 masking: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = SpanEventsArgs.__new__(SpanEventsArgs)

            if key is None and not opts.urn:
                raise TypeError("Missing required property 'key'")
            __props__.__dict__["key"] = key
            if masking is None and not opts.urn:
                raise TypeError("Missing required property 'masking'")
            __props__.__dict__["masking"] = masking
        super(SpanEvents, __self__).__init__(
            'dynatrace:index/spanEvents:SpanEvents',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            key: Optional[pulumi.Input[str]] = None,
            masking: Optional[pulumi.Input[str]] = None) -> 'SpanEvents':
        """
        Get an existing SpanEvents resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] key: Key of the span event attribute to store
        :param pulumi.Input[str] masking: Possible Values: `MASK_ENTIRE_VALUE`, `MASK_ONLY_CONFIDENTIAL_DATA`, `NOT_MASKED`
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _SpanEventsState.__new__(_SpanEventsState)

        __props__.__dict__["key"] = key
        __props__.__dict__["masking"] = masking
        return SpanEvents(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def key(self) -> pulumi.Output[str]:
        """
        Key of the span event attribute to store
        """
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def masking(self) -> pulumi.Output[str]:
        """
        Possible Values: `MASK_ENTIRE_VALUE`, `MASK_ONLY_CONFIDENTIAL_DATA`, `NOT_MASKED`
        """
        return pulumi.get(self, "masking")

