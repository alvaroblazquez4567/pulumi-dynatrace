# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['GenericSettingArgs', 'GenericSetting']

@pulumi.input_type
class GenericSettingArgs:
    def __init__(__self__, *,
                 schema: pulumi.Input[str],
                 value: pulumi.Input[str],
                 scope: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a GenericSetting resource.
        """
        pulumi.set(__self__, "schema", schema)
        pulumi.set(__self__, "value", value)
        if scope is not None:
            pulumi.set(__self__, "scope", scope)

    @property
    @pulumi.getter
    def schema(self) -> pulumi.Input[str]:
        return pulumi.get(self, "schema")

    @schema.setter
    def schema(self, value: pulumi.Input[str]):
        pulumi.set(self, "schema", value)

    @property
    @pulumi.getter
    def value(self) -> pulumi.Input[str]:
        return pulumi.get(self, "value")

    @value.setter
    def value(self, value: pulumi.Input[str]):
        pulumi.set(self, "value", value)

    @property
    @pulumi.getter
    def scope(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "scope")

    @scope.setter
    def scope(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "scope", value)


@pulumi.input_type
class _GenericSettingState:
    def __init__(__self__, *,
                 local_storage: Optional[pulumi.Input[str]] = None,
                 schema: Optional[pulumi.Input[str]] = None,
                 scope: Optional[pulumi.Input[str]] = None,
                 value: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering GenericSetting resources.
        """
        if local_storage is not None:
            pulumi.set(__self__, "local_storage", local_storage)
        if schema is not None:
            pulumi.set(__self__, "schema", schema)
        if scope is not None:
            pulumi.set(__self__, "scope", scope)
        if value is not None:
            pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter(name="localStorage")
    def local_storage(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "local_storage")

    @local_storage.setter
    def local_storage(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "local_storage", value)

    @property
    @pulumi.getter
    def schema(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "schema")

    @schema.setter
    def schema(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "schema", value)

    @property
    @pulumi.getter
    def scope(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "scope")

    @scope.setter
    def scope(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "scope", value)

    @property
    @pulumi.getter
    def value(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "value")

    @value.setter
    def value(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "value", value)


class GenericSetting(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 schema: Optional[pulumi.Input[str]] = None,
                 scope: Optional[pulumi.Input[str]] = None,
                 value: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a GenericSetting resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: GenericSettingArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a GenericSetting resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param GenericSettingArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(GenericSettingArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 schema: Optional[pulumi.Input[str]] = None,
                 scope: Optional[pulumi.Input[str]] = None,
                 value: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = GenericSettingArgs.__new__(GenericSettingArgs)

            if schema is None and not opts.urn:
                raise TypeError("Missing required property 'schema'")
            __props__.__dict__["schema"] = schema
            __props__.__dict__["scope"] = scope
            if value is None and not opts.urn:
                raise TypeError("Missing required property 'value'")
            __props__.__dict__["value"] = value
            __props__.__dict__["local_storage"] = None
        super(GenericSetting, __self__).__init__(
            'dynatrace:index/genericSetting:GenericSetting',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            local_storage: Optional[pulumi.Input[str]] = None,
            schema: Optional[pulumi.Input[str]] = None,
            scope: Optional[pulumi.Input[str]] = None,
            value: Optional[pulumi.Input[str]] = None) -> 'GenericSetting':
        """
        Get an existing GenericSetting resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _GenericSettingState.__new__(_GenericSettingState)

        __props__.__dict__["local_storage"] = local_storage
        __props__.__dict__["schema"] = schema
        __props__.__dict__["scope"] = scope
        __props__.__dict__["value"] = value
        return GenericSetting(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="localStorage")
    def local_storage(self) -> pulumi.Output[str]:
        return pulumi.get(self, "local_storage")

    @property
    @pulumi.getter
    def schema(self) -> pulumi.Output[str]:
        return pulumi.get(self, "schema")

    @property
    @pulumi.getter
    def scope(self) -> pulumi.Output[str]:
        return pulumi.get(self, "scope")

    @property
    @pulumi.getter
    def value(self) -> pulumi.Output[str]:
        return pulumi.get(self, "value")

