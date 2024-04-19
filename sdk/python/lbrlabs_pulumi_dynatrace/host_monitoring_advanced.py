# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['HostMonitoringAdvancedArgs', 'HostMonitoringAdvanced']

@pulumi.input_type
class HostMonitoringAdvancedArgs:
    def __init__(__self__, *,
                 host_id: pulumi.Input[str],
                 process_agent_injection: pulumi.Input[bool],
                 code_module_injection: Optional[pulumi.Input[bool]] = None):
        """
        The set of arguments for constructing a HostMonitoringAdvanced resource.
        :param pulumi.Input[str] host_id: The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        :param pulumi.Input[bool] process_agent_injection: Disabling this via [oneagentctl](https://dt-url.net/oneagentctl) takes precedence over this setting and cannot be changed from the Dynatrace web UI.
        :param pulumi.Input[bool] code_module_injection: Inject CodeModules in Discovery mode.
        """
        pulumi.set(__self__, "host_id", host_id)
        pulumi.set(__self__, "process_agent_injection", process_agent_injection)
        if code_module_injection is not None:
            pulumi.set(__self__, "code_module_injection", code_module_injection)

    @property
    @pulumi.getter(name="hostId")
    def host_id(self) -> pulumi.Input[str]:
        """
        The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        """
        return pulumi.get(self, "host_id")

    @host_id.setter
    def host_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "host_id", value)

    @property
    @pulumi.getter(name="processAgentInjection")
    def process_agent_injection(self) -> pulumi.Input[bool]:
        """
        Disabling this via [oneagentctl](https://dt-url.net/oneagentctl) takes precedence over this setting and cannot be changed from the Dynatrace web UI.
        """
        return pulumi.get(self, "process_agent_injection")

    @process_agent_injection.setter
    def process_agent_injection(self, value: pulumi.Input[bool]):
        pulumi.set(self, "process_agent_injection", value)

    @property
    @pulumi.getter(name="codeModuleInjection")
    def code_module_injection(self) -> Optional[pulumi.Input[bool]]:
        """
        Inject CodeModules in Discovery mode.
        """
        return pulumi.get(self, "code_module_injection")

    @code_module_injection.setter
    def code_module_injection(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "code_module_injection", value)


@pulumi.input_type
class _HostMonitoringAdvancedState:
    def __init__(__self__, *,
                 code_module_injection: Optional[pulumi.Input[bool]] = None,
                 host_id: Optional[pulumi.Input[str]] = None,
                 process_agent_injection: Optional[pulumi.Input[bool]] = None):
        """
        Input properties used for looking up and filtering HostMonitoringAdvanced resources.
        :param pulumi.Input[bool] code_module_injection: Inject CodeModules in Discovery mode.
        :param pulumi.Input[str] host_id: The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        :param pulumi.Input[bool] process_agent_injection: Disabling this via [oneagentctl](https://dt-url.net/oneagentctl) takes precedence over this setting and cannot be changed from the Dynatrace web UI.
        """
        if code_module_injection is not None:
            pulumi.set(__self__, "code_module_injection", code_module_injection)
        if host_id is not None:
            pulumi.set(__self__, "host_id", host_id)
        if process_agent_injection is not None:
            pulumi.set(__self__, "process_agent_injection", process_agent_injection)

    @property
    @pulumi.getter(name="codeModuleInjection")
    def code_module_injection(self) -> Optional[pulumi.Input[bool]]:
        """
        Inject CodeModules in Discovery mode.
        """
        return pulumi.get(self, "code_module_injection")

    @code_module_injection.setter
    def code_module_injection(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "code_module_injection", value)

    @property
    @pulumi.getter(name="hostId")
    def host_id(self) -> Optional[pulumi.Input[str]]:
        """
        The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        """
        return pulumi.get(self, "host_id")

    @host_id.setter
    def host_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "host_id", value)

    @property
    @pulumi.getter(name="processAgentInjection")
    def process_agent_injection(self) -> Optional[pulumi.Input[bool]]:
        """
        Disabling this via [oneagentctl](https://dt-url.net/oneagentctl) takes precedence over this setting and cannot be changed from the Dynatrace web UI.
        """
        return pulumi.get(self, "process_agent_injection")

    @process_agent_injection.setter
    def process_agent_injection(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "process_agent_injection", value)


class HostMonitoringAdvanced(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 code_module_injection: Optional[pulumi.Input[bool]] = None,
                 host_id: Optional[pulumi.Input[str]] = None,
                 process_agent_injection: Optional[pulumi.Input[bool]] = None,
                 __props__=None):
        """
        Create a HostMonitoringAdvanced resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] code_module_injection: Inject CodeModules in Discovery mode.
        :param pulumi.Input[str] host_id: The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        :param pulumi.Input[bool] process_agent_injection: Disabling this via [oneagentctl](https://dt-url.net/oneagentctl) takes precedence over this setting and cannot be changed from the Dynatrace web UI.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: HostMonitoringAdvancedArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a HostMonitoringAdvanced resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param HostMonitoringAdvancedArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(HostMonitoringAdvancedArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 code_module_injection: Optional[pulumi.Input[bool]] = None,
                 host_id: Optional[pulumi.Input[str]] = None,
                 process_agent_injection: Optional[pulumi.Input[bool]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = HostMonitoringAdvancedArgs.__new__(HostMonitoringAdvancedArgs)

            __props__.__dict__["code_module_injection"] = code_module_injection
            if host_id is None and not opts.urn:
                raise TypeError("Missing required property 'host_id'")
            __props__.__dict__["host_id"] = host_id
            if process_agent_injection is None and not opts.urn:
                raise TypeError("Missing required property 'process_agent_injection'")
            __props__.__dict__["process_agent_injection"] = process_agent_injection
        super(HostMonitoringAdvanced, __self__).__init__(
            'dynatrace:index/hostMonitoringAdvanced:HostMonitoringAdvanced',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            code_module_injection: Optional[pulumi.Input[bool]] = None,
            host_id: Optional[pulumi.Input[str]] = None,
            process_agent_injection: Optional[pulumi.Input[bool]] = None) -> 'HostMonitoringAdvanced':
        """
        Get an existing HostMonitoringAdvanced resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] code_module_injection: Inject CodeModules in Discovery mode.
        :param pulumi.Input[str] host_id: The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        :param pulumi.Input[bool] process_agent_injection: Disabling this via [oneagentctl](https://dt-url.net/oneagentctl) takes precedence over this setting and cannot be changed from the Dynatrace web UI.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _HostMonitoringAdvancedState.__new__(_HostMonitoringAdvancedState)

        __props__.__dict__["code_module_injection"] = code_module_injection
        __props__.__dict__["host_id"] = host_id
        __props__.__dict__["process_agent_injection"] = process_agent_injection
        return HostMonitoringAdvanced(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="codeModuleInjection")
    def code_module_injection(self) -> pulumi.Output[Optional[bool]]:
        """
        Inject CodeModules in Discovery mode.
        """
        return pulumi.get(self, "code_module_injection")

    @property
    @pulumi.getter(name="hostId")
    def host_id(self) -> pulumi.Output[str]:
        """
        The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        """
        return pulumi.get(self, "host_id")

    @property
    @pulumi.getter(name="processAgentInjection")
    def process_agent_injection(self) -> pulumi.Output[bool]:
        """
        Disabling this via [oneagentctl](https://dt-url.net/oneagentctl) takes precedence over this setting and cannot be changed from the Dynatrace web UI.
        """
        return pulumi.get(self, "process_agent_injection")

