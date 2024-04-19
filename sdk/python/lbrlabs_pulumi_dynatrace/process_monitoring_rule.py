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

__all__ = ['ProcessMonitoringRuleArgs', 'ProcessMonitoringRule']

@pulumi.input_type
class ProcessMonitoringRuleArgs:
    def __init__(__self__, *,
                 condition: pulumi.Input['ProcessMonitoringRuleConditionArgs'],
                 enabled: pulumi.Input[bool],
                 mode: pulumi.Input[str],
                 host_group_id: Optional[pulumi.Input[str]] = None,
                 insert_after: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a ProcessMonitoringRule resource.
        :param pulumi.Input['ProcessMonitoringRuleConditionArgs'] condition: Condition
        :param pulumi.Input[bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[str] mode: Possible Values: `MONITORING_ON`, `MONITORING_OFF`
        :param pulumi.Input[str] host_group_id: The scope of this settings. If the settings should cover the whole environment, just don't specify any scope
        :param pulumi.Input[str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        """
        pulumi.set(__self__, "condition", condition)
        pulumi.set(__self__, "enabled", enabled)
        pulumi.set(__self__, "mode", mode)
        if host_group_id is not None:
            pulumi.set(__self__, "host_group_id", host_group_id)
        if insert_after is not None:
            pulumi.set(__self__, "insert_after", insert_after)

    @property
    @pulumi.getter
    def condition(self) -> pulumi.Input['ProcessMonitoringRuleConditionArgs']:
        """
        Condition
        """
        return pulumi.get(self, "condition")

    @condition.setter
    def condition(self, value: pulumi.Input['ProcessMonitoringRuleConditionArgs']):
        pulumi.set(self, "condition", value)

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
    @pulumi.getter
    def mode(self) -> pulumi.Input[str]:
        """
        Possible Values: `MONITORING_ON`, `MONITORING_OFF`
        """
        return pulumi.get(self, "mode")

    @mode.setter
    def mode(self, value: pulumi.Input[str]):
        pulumi.set(self, "mode", value)

    @property
    @pulumi.getter(name="hostGroupId")
    def host_group_id(self) -> Optional[pulumi.Input[str]]:
        """
        The scope of this settings. If the settings should cover the whole environment, just don't specify any scope
        """
        return pulumi.get(self, "host_group_id")

    @host_group_id.setter
    def host_group_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "host_group_id", value)

    @property
    @pulumi.getter(name="insertAfter")
    def insert_after(self) -> Optional[pulumi.Input[str]]:
        """
        Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        """
        return pulumi.get(self, "insert_after")

    @insert_after.setter
    def insert_after(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "insert_after", value)


@pulumi.input_type
class _ProcessMonitoringRuleState:
    def __init__(__self__, *,
                 condition: Optional[pulumi.Input['ProcessMonitoringRuleConditionArgs']] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 host_group_id: Optional[pulumi.Input[str]] = None,
                 insert_after: Optional[pulumi.Input[str]] = None,
                 mode: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering ProcessMonitoringRule resources.
        :param pulumi.Input['ProcessMonitoringRuleConditionArgs'] condition: Condition
        :param pulumi.Input[bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[str] host_group_id: The scope of this settings. If the settings should cover the whole environment, just don't specify any scope
        :param pulumi.Input[str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        :param pulumi.Input[str] mode: Possible Values: `MONITORING_ON`, `MONITORING_OFF`
        """
        if condition is not None:
            pulumi.set(__self__, "condition", condition)
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)
        if host_group_id is not None:
            pulumi.set(__self__, "host_group_id", host_group_id)
        if insert_after is not None:
            pulumi.set(__self__, "insert_after", insert_after)
        if mode is not None:
            pulumi.set(__self__, "mode", mode)

    @property
    @pulumi.getter
    def condition(self) -> Optional[pulumi.Input['ProcessMonitoringRuleConditionArgs']]:
        """
        Condition
        """
        return pulumi.get(self, "condition")

    @condition.setter
    def condition(self, value: Optional[pulumi.Input['ProcessMonitoringRuleConditionArgs']]):
        pulumi.set(self, "condition", value)

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
    @pulumi.getter(name="hostGroupId")
    def host_group_id(self) -> Optional[pulumi.Input[str]]:
        """
        The scope of this settings. If the settings should cover the whole environment, just don't specify any scope
        """
        return pulumi.get(self, "host_group_id")

    @host_group_id.setter
    def host_group_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "host_group_id", value)

    @property
    @pulumi.getter(name="insertAfter")
    def insert_after(self) -> Optional[pulumi.Input[str]]:
        """
        Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        """
        return pulumi.get(self, "insert_after")

    @insert_after.setter
    def insert_after(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "insert_after", value)

    @property
    @pulumi.getter
    def mode(self) -> Optional[pulumi.Input[str]]:
        """
        Possible Values: `MONITORING_ON`, `MONITORING_OFF`
        """
        return pulumi.get(self, "mode")

    @mode.setter
    def mode(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "mode", value)


class ProcessMonitoringRule(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 condition: Optional[pulumi.Input[pulumi.InputType['ProcessMonitoringRuleConditionArgs']]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 host_group_id: Optional[pulumi.Input[str]] = None,
                 insert_after: Optional[pulumi.Input[str]] = None,
                 mode: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a ProcessMonitoringRule resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['ProcessMonitoringRuleConditionArgs']] condition: Condition
        :param pulumi.Input[bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[str] host_group_id: The scope of this settings. If the settings should cover the whole environment, just don't specify any scope
        :param pulumi.Input[str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        :param pulumi.Input[str] mode: Possible Values: `MONITORING_ON`, `MONITORING_OFF`
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ProcessMonitoringRuleArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a ProcessMonitoringRule resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param ProcessMonitoringRuleArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ProcessMonitoringRuleArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 condition: Optional[pulumi.Input[pulumi.InputType['ProcessMonitoringRuleConditionArgs']]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 host_group_id: Optional[pulumi.Input[str]] = None,
                 insert_after: Optional[pulumi.Input[str]] = None,
                 mode: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ProcessMonitoringRuleArgs.__new__(ProcessMonitoringRuleArgs)

            if condition is None and not opts.urn:
                raise TypeError("Missing required property 'condition'")
            __props__.__dict__["condition"] = condition
            if enabled is None and not opts.urn:
                raise TypeError("Missing required property 'enabled'")
            __props__.__dict__["enabled"] = enabled
            __props__.__dict__["host_group_id"] = host_group_id
            __props__.__dict__["insert_after"] = insert_after
            if mode is None and not opts.urn:
                raise TypeError("Missing required property 'mode'")
            __props__.__dict__["mode"] = mode
        super(ProcessMonitoringRule, __self__).__init__(
            'dynatrace:index/processMonitoringRule:ProcessMonitoringRule',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            condition: Optional[pulumi.Input[pulumi.InputType['ProcessMonitoringRuleConditionArgs']]] = None,
            enabled: Optional[pulumi.Input[bool]] = None,
            host_group_id: Optional[pulumi.Input[str]] = None,
            insert_after: Optional[pulumi.Input[str]] = None,
            mode: Optional[pulumi.Input[str]] = None) -> 'ProcessMonitoringRule':
        """
        Get an existing ProcessMonitoringRule resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['ProcessMonitoringRuleConditionArgs']] condition: Condition
        :param pulumi.Input[bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[str] host_group_id: The scope of this settings. If the settings should cover the whole environment, just don't specify any scope
        :param pulumi.Input[str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        :param pulumi.Input[str] mode: Possible Values: `MONITORING_ON`, `MONITORING_OFF`
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ProcessMonitoringRuleState.__new__(_ProcessMonitoringRuleState)

        __props__.__dict__["condition"] = condition
        __props__.__dict__["enabled"] = enabled
        __props__.__dict__["host_group_id"] = host_group_id
        __props__.__dict__["insert_after"] = insert_after
        __props__.__dict__["mode"] = mode
        return ProcessMonitoringRule(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def condition(self) -> pulumi.Output['outputs.ProcessMonitoringRuleCondition']:
        """
        Condition
        """
        return pulumi.get(self, "condition")

    @property
    @pulumi.getter
    def enabled(self) -> pulumi.Output[bool]:
        """
        This setting is enabled (`true`) or disabled (`false`)
        """
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter(name="hostGroupId")
    def host_group_id(self) -> pulumi.Output[Optional[str]]:
        """
        The scope of this settings. If the settings should cover the whole environment, just don't specify any scope
        """
        return pulumi.get(self, "host_group_id")

    @property
    @pulumi.getter(name="insertAfter")
    def insert_after(self) -> pulumi.Output[str]:
        """
        Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        """
        return pulumi.get(self, "insert_after")

    @property
    @pulumi.getter
    def mode(self) -> pulumi.Output[str]:
        """
        Possible Values: `MONITORING_ON`, `MONITORING_OFF`
        """
        return pulumi.get(self, "mode")

