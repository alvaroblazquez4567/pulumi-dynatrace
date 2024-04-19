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

__all__ = ['BusinessEventsSecurityContextArgs', 'BusinessEventsSecurityContext']

@pulumi.input_type
class BusinessEventsSecurityContextArgs:
    def __init__(__self__, *,
                 security_context_rule: pulumi.Input['BusinessEventsSecurityContextSecurityContextRuleArgs'],
                 insert_after: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a BusinessEventsSecurityContext resource.
        :param pulumi.Input['BusinessEventsSecurityContextSecurityContextRuleArgs'] security_context_rule: no documentation available
        :param pulumi.Input[str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        """
        pulumi.set(__self__, "security_context_rule", security_context_rule)
        if insert_after is not None:
            pulumi.set(__self__, "insert_after", insert_after)

    @property
    @pulumi.getter(name="securityContextRule")
    def security_context_rule(self) -> pulumi.Input['BusinessEventsSecurityContextSecurityContextRuleArgs']:
        """
        no documentation available
        """
        return pulumi.get(self, "security_context_rule")

    @security_context_rule.setter
    def security_context_rule(self, value: pulumi.Input['BusinessEventsSecurityContextSecurityContextRuleArgs']):
        pulumi.set(self, "security_context_rule", value)

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
class _BusinessEventsSecurityContextState:
    def __init__(__self__, *,
                 insert_after: Optional[pulumi.Input[str]] = None,
                 security_context_rule: Optional[pulumi.Input['BusinessEventsSecurityContextSecurityContextRuleArgs']] = None):
        """
        Input properties used for looking up and filtering BusinessEventsSecurityContext resources.
        :param pulumi.Input[str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        :param pulumi.Input['BusinessEventsSecurityContextSecurityContextRuleArgs'] security_context_rule: no documentation available
        """
        if insert_after is not None:
            pulumi.set(__self__, "insert_after", insert_after)
        if security_context_rule is not None:
            pulumi.set(__self__, "security_context_rule", security_context_rule)

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
    @pulumi.getter(name="securityContextRule")
    def security_context_rule(self) -> Optional[pulumi.Input['BusinessEventsSecurityContextSecurityContextRuleArgs']]:
        """
        no documentation available
        """
        return pulumi.get(self, "security_context_rule")

    @security_context_rule.setter
    def security_context_rule(self, value: Optional[pulumi.Input['BusinessEventsSecurityContextSecurityContextRuleArgs']]):
        pulumi.set(self, "security_context_rule", value)


class BusinessEventsSecurityContext(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 insert_after: Optional[pulumi.Input[str]] = None,
                 security_context_rule: Optional[pulumi.Input[pulumi.InputType['BusinessEventsSecurityContextSecurityContextRuleArgs']]] = None,
                 __props__=None):
        """
        Create a BusinessEventsSecurityContext resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        :param pulumi.Input[pulumi.InputType['BusinessEventsSecurityContextSecurityContextRuleArgs']] security_context_rule: no documentation available
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: BusinessEventsSecurityContextArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a BusinessEventsSecurityContext resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param BusinessEventsSecurityContextArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(BusinessEventsSecurityContextArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 insert_after: Optional[pulumi.Input[str]] = None,
                 security_context_rule: Optional[pulumi.Input[pulumi.InputType['BusinessEventsSecurityContextSecurityContextRuleArgs']]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = BusinessEventsSecurityContextArgs.__new__(BusinessEventsSecurityContextArgs)

            __props__.__dict__["insert_after"] = insert_after
            if security_context_rule is None and not opts.urn:
                raise TypeError("Missing required property 'security_context_rule'")
            __props__.__dict__["security_context_rule"] = security_context_rule
        super(BusinessEventsSecurityContext, __self__).__init__(
            'dynatrace:index/businessEventsSecurityContext:BusinessEventsSecurityContext',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            insert_after: Optional[pulumi.Input[str]] = None,
            security_context_rule: Optional[pulumi.Input[pulumi.InputType['BusinessEventsSecurityContextSecurityContextRuleArgs']]] = None) -> 'BusinessEventsSecurityContext':
        """
        Get an existing BusinessEventsSecurityContext resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        :param pulumi.Input[pulumi.InputType['BusinessEventsSecurityContextSecurityContextRuleArgs']] security_context_rule: no documentation available
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _BusinessEventsSecurityContextState.__new__(_BusinessEventsSecurityContextState)

        __props__.__dict__["insert_after"] = insert_after
        __props__.__dict__["security_context_rule"] = security_context_rule
        return BusinessEventsSecurityContext(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="insertAfter")
    def insert_after(self) -> pulumi.Output[str]:
        """
        Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        """
        return pulumi.get(self, "insert_after")

    @property
    @pulumi.getter(name="securityContextRule")
    def security_context_rule(self) -> pulumi.Output['outputs.BusinessEventsSecurityContextSecurityContextRule']:
        """
        no documentation available
        """
        return pulumi.get(self, "security_context_rule")

