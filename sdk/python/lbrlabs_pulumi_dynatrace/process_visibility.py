# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['ProcessVisibilityArgs', 'ProcessVisibility']

@pulumi.input_type
class ProcessVisibilityArgs:
    def __init__(__self__, *,
                 enabled: pulumi.Input[bool],
                 max_processes: pulumi.Input[int],
                 scope: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a ProcessVisibility resource.
        :param pulumi.Input[bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[int] max_processes: The maximum amount of processes that host may report is **100**
        :param pulumi.Input[str] scope: The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        """
        pulumi.set(__self__, "enabled", enabled)
        pulumi.set(__self__, "max_processes", max_processes)
        if scope is not None:
            pulumi.set(__self__, "scope", scope)

    @property
    @pulumi.getter
    def enabled(self) -> pulumi.Input[bool]:
        """
        This setting is enabled (`true`) or disabled (`false`)
        """
        return pulumi.get(self, "enabled")

    @enabled.setter
    def enabled(self, value: pulumi.Input[bool]):
        pulumi.set(self, "enabled", value)

    @property
    @pulumi.getter(name="maxProcesses")
    def max_processes(self) -> pulumi.Input[int]:
        """
        The maximum amount of processes that host may report is **100**
        """
        return pulumi.get(self, "max_processes")

    @max_processes.setter
    def max_processes(self, value: pulumi.Input[int]):
        pulumi.set(self, "max_processes", value)

    @property
    @pulumi.getter
    def scope(self) -> Optional[pulumi.Input[str]]:
        """
        The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        """
        return pulumi.get(self, "scope")

    @scope.setter
    def scope(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "scope", value)


@pulumi.input_type
class _ProcessVisibilityState:
    def __init__(__self__, *,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 max_processes: Optional[pulumi.Input[int]] = None,
                 scope: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering ProcessVisibility resources.
        :param pulumi.Input[bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[int] max_processes: The maximum amount of processes that host may report is **100**
        :param pulumi.Input[str] scope: The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        """
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)
        if max_processes is not None:
            pulumi.set(__self__, "max_processes", max_processes)
        if scope is not None:
            pulumi.set(__self__, "scope", scope)

    @property
    @pulumi.getter
    def enabled(self) -> Optional[pulumi.Input[bool]]:
        """
        This setting is enabled (`true`) or disabled (`false`)
        """
        return pulumi.get(self, "enabled")

    @enabled.setter
    def enabled(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enabled", value)

    @property
    @pulumi.getter(name="maxProcesses")
    def max_processes(self) -> Optional[pulumi.Input[int]]:
        """
        The maximum amount of processes that host may report is **100**
        """
        return pulumi.get(self, "max_processes")

    @max_processes.setter
    def max_processes(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "max_processes", value)

    @property
    @pulumi.getter
    def scope(self) -> Optional[pulumi.Input[str]]:
        """
        The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        """
        return pulumi.get(self, "scope")

    @scope.setter
    def scope(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "scope", value)


class ProcessVisibility(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 max_processes: Optional[pulumi.Input[int]] = None,
                 scope: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a ProcessVisibility resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[int] max_processes: The maximum amount of processes that host may report is **100**
        :param pulumi.Input[str] scope: The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ProcessVisibilityArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a ProcessVisibility resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param ProcessVisibilityArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ProcessVisibilityArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 max_processes: Optional[pulumi.Input[int]] = None,
                 scope: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ProcessVisibilityArgs.__new__(ProcessVisibilityArgs)

            if enabled is None and not opts.urn:
                raise TypeError("Missing required property 'enabled'")
            __props__.__dict__["enabled"] = enabled
            if max_processes is None and not opts.urn:
                raise TypeError("Missing required property 'max_processes'")
            __props__.__dict__["max_processes"] = max_processes
            __props__.__dict__["scope"] = scope
        super(ProcessVisibility, __self__).__init__(
            'dynatrace:index/processVisibility:ProcessVisibility',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            enabled: Optional[pulumi.Input[bool]] = None,
            max_processes: Optional[pulumi.Input[int]] = None,
            scope: Optional[pulumi.Input[str]] = None) -> 'ProcessVisibility':
        """
        Get an existing ProcessVisibility resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[int] max_processes: The maximum amount of processes that host may report is **100**
        :param pulumi.Input[str] scope: The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ProcessVisibilityState.__new__(_ProcessVisibilityState)

        __props__.__dict__["enabled"] = enabled
        __props__.__dict__["max_processes"] = max_processes
        __props__.__dict__["scope"] = scope
        return ProcessVisibility(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def enabled(self) -> pulumi.Output[bool]:
        """
        This setting is enabled (`true`) or disabled (`false`)
        """
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter(name="maxProcesses")
    def max_processes(self) -> pulumi.Output[int]:
        """
        The maximum amount of processes that host may report is **100**
        """
        return pulumi.get(self, "max_processes")

    @property
    @pulumi.getter
    def scope(self) -> pulumi.Output[Optional[str]]:
        """
        The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        """
        return pulumi.get(self, "scope")

