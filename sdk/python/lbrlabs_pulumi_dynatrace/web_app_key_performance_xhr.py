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

__all__ = ['WebAppKeyPerformanceXhrArgs', 'WebAppKeyPerformanceXhr']

@pulumi.input_type
class WebAppKeyPerformanceXhrArgs:
    def __init__(__self__, *,
                 kpm: pulumi.Input[str],
                 scope: pulumi.Input[str],
                 thresholds: pulumi.Input['WebAppKeyPerformanceXhrThresholdsArgs'],
                 fallback_thresholds: Optional[pulumi.Input['WebAppKeyPerformanceXhrFallbackThresholdsArgs']] = None):
        """
        The set of arguments for constructing a WebAppKeyPerformanceXhr resource.
        :param pulumi.Input[str] kpm: Possible Values: `RESPONSE_END`, `RESPONSE_START`, `USER_ACTION_DURATION`, `VISUALLY_COMPLETE`
        :param pulumi.Input[str] scope: The scope of this setting (APPLICATION_METHOD, APPLICATION)
        :param pulumi.Input['WebAppKeyPerformanceXhrThresholdsArgs'] thresholds: Set the Tolerating and Frustrated performance thresholds for this action type.
        :param pulumi.Input['WebAppKeyPerformanceXhrFallbackThresholdsArgs'] fallback_thresholds: If the selected key performance metric is not detected, the **User action duration** metric is used instead.
        """
        pulumi.set(__self__, "kpm", kpm)
        pulumi.set(__self__, "scope", scope)
        pulumi.set(__self__, "thresholds", thresholds)
        if fallback_thresholds is not None:
            pulumi.set(__self__, "fallback_thresholds", fallback_thresholds)

    @property
    @pulumi.getter
    def kpm(self) -> pulumi.Input[str]:
        """
        Possible Values: `RESPONSE_END`, `RESPONSE_START`, `USER_ACTION_DURATION`, `VISUALLY_COMPLETE`
        """
        return pulumi.get(self, "kpm")

    @kpm.setter
    def kpm(self, value: pulumi.Input[str]):
        pulumi.set(self, "kpm", value)

    @property
    @pulumi.getter
    def scope(self) -> pulumi.Input[str]:
        """
        The scope of this setting (APPLICATION_METHOD, APPLICATION)
        """
        return pulumi.get(self, "scope")

    @scope.setter
    def scope(self, value: pulumi.Input[str]):
        pulumi.set(self, "scope", value)

    @property
    @pulumi.getter
    def thresholds(self) -> pulumi.Input['WebAppKeyPerformanceXhrThresholdsArgs']:
        """
        Set the Tolerating and Frustrated performance thresholds for this action type.
        """
        return pulumi.get(self, "thresholds")

    @thresholds.setter
    def thresholds(self, value: pulumi.Input['WebAppKeyPerformanceXhrThresholdsArgs']):
        pulumi.set(self, "thresholds", value)

    @property
    @pulumi.getter(name="fallbackThresholds")
    def fallback_thresholds(self) -> Optional[pulumi.Input['WebAppKeyPerformanceXhrFallbackThresholdsArgs']]:
        """
        If the selected key performance metric is not detected, the **User action duration** metric is used instead.
        """
        return pulumi.get(self, "fallback_thresholds")

    @fallback_thresholds.setter
    def fallback_thresholds(self, value: Optional[pulumi.Input['WebAppKeyPerformanceXhrFallbackThresholdsArgs']]):
        pulumi.set(self, "fallback_thresholds", value)


@pulumi.input_type
class _WebAppKeyPerformanceXhrState:
    def __init__(__self__, *,
                 fallback_thresholds: Optional[pulumi.Input['WebAppKeyPerformanceXhrFallbackThresholdsArgs']] = None,
                 kpm: Optional[pulumi.Input[str]] = None,
                 scope: Optional[pulumi.Input[str]] = None,
                 thresholds: Optional[pulumi.Input['WebAppKeyPerformanceXhrThresholdsArgs']] = None):
        """
        Input properties used for looking up and filtering WebAppKeyPerformanceXhr resources.
        :param pulumi.Input['WebAppKeyPerformanceXhrFallbackThresholdsArgs'] fallback_thresholds: If the selected key performance metric is not detected, the **User action duration** metric is used instead.
        :param pulumi.Input[str] kpm: Possible Values: `RESPONSE_END`, `RESPONSE_START`, `USER_ACTION_DURATION`, `VISUALLY_COMPLETE`
        :param pulumi.Input[str] scope: The scope of this setting (APPLICATION_METHOD, APPLICATION)
        :param pulumi.Input['WebAppKeyPerformanceXhrThresholdsArgs'] thresholds: Set the Tolerating and Frustrated performance thresholds for this action type.
        """
        if fallback_thresholds is not None:
            pulumi.set(__self__, "fallback_thresholds", fallback_thresholds)
        if kpm is not None:
            pulumi.set(__self__, "kpm", kpm)
        if scope is not None:
            pulumi.set(__self__, "scope", scope)
        if thresholds is not None:
            pulumi.set(__self__, "thresholds", thresholds)

    @property
    @pulumi.getter(name="fallbackThresholds")
    def fallback_thresholds(self) -> Optional[pulumi.Input['WebAppKeyPerformanceXhrFallbackThresholdsArgs']]:
        """
        If the selected key performance metric is not detected, the **User action duration** metric is used instead.
        """
        return pulumi.get(self, "fallback_thresholds")

    @fallback_thresholds.setter
    def fallback_thresholds(self, value: Optional[pulumi.Input['WebAppKeyPerformanceXhrFallbackThresholdsArgs']]):
        pulumi.set(self, "fallback_thresholds", value)

    @property
    @pulumi.getter
    def kpm(self) -> Optional[pulumi.Input[str]]:
        """
        Possible Values: `RESPONSE_END`, `RESPONSE_START`, `USER_ACTION_DURATION`, `VISUALLY_COMPLETE`
        """
        return pulumi.get(self, "kpm")

    @kpm.setter
    def kpm(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "kpm", value)

    @property
    @pulumi.getter
    def scope(self) -> Optional[pulumi.Input[str]]:
        """
        The scope of this setting (APPLICATION_METHOD, APPLICATION)
        """
        return pulumi.get(self, "scope")

    @scope.setter
    def scope(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "scope", value)

    @property
    @pulumi.getter
    def thresholds(self) -> Optional[pulumi.Input['WebAppKeyPerformanceXhrThresholdsArgs']]:
        """
        Set the Tolerating and Frustrated performance thresholds for this action type.
        """
        return pulumi.get(self, "thresholds")

    @thresholds.setter
    def thresholds(self, value: Optional[pulumi.Input['WebAppKeyPerformanceXhrThresholdsArgs']]):
        pulumi.set(self, "thresholds", value)


class WebAppKeyPerformanceXhr(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 fallback_thresholds: Optional[pulumi.Input[pulumi.InputType['WebAppKeyPerformanceXhrFallbackThresholdsArgs']]] = None,
                 kpm: Optional[pulumi.Input[str]] = None,
                 scope: Optional[pulumi.Input[str]] = None,
                 thresholds: Optional[pulumi.Input[pulumi.InputType['WebAppKeyPerformanceXhrThresholdsArgs']]] = None,
                 __props__=None):
        """
        Create a WebAppKeyPerformanceXhr resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['WebAppKeyPerformanceXhrFallbackThresholdsArgs']] fallback_thresholds: If the selected key performance metric is not detected, the **User action duration** metric is used instead.
        :param pulumi.Input[str] kpm: Possible Values: `RESPONSE_END`, `RESPONSE_START`, `USER_ACTION_DURATION`, `VISUALLY_COMPLETE`
        :param pulumi.Input[str] scope: The scope of this setting (APPLICATION_METHOD, APPLICATION)
        :param pulumi.Input[pulumi.InputType['WebAppKeyPerformanceXhrThresholdsArgs']] thresholds: Set the Tolerating and Frustrated performance thresholds for this action type.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: WebAppKeyPerformanceXhrArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a WebAppKeyPerformanceXhr resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param WebAppKeyPerformanceXhrArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(WebAppKeyPerformanceXhrArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 fallback_thresholds: Optional[pulumi.Input[pulumi.InputType['WebAppKeyPerformanceXhrFallbackThresholdsArgs']]] = None,
                 kpm: Optional[pulumi.Input[str]] = None,
                 scope: Optional[pulumi.Input[str]] = None,
                 thresholds: Optional[pulumi.Input[pulumi.InputType['WebAppKeyPerformanceXhrThresholdsArgs']]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = WebAppKeyPerformanceXhrArgs.__new__(WebAppKeyPerformanceXhrArgs)

            __props__.__dict__["fallback_thresholds"] = fallback_thresholds
            if kpm is None and not opts.urn:
                raise TypeError("Missing required property 'kpm'")
            __props__.__dict__["kpm"] = kpm
            if scope is None and not opts.urn:
                raise TypeError("Missing required property 'scope'")
            __props__.__dict__["scope"] = scope
            if thresholds is None and not opts.urn:
                raise TypeError("Missing required property 'thresholds'")
            __props__.__dict__["thresholds"] = thresholds
        super(WebAppKeyPerformanceXhr, __self__).__init__(
            'dynatrace:index/webAppKeyPerformanceXhr:WebAppKeyPerformanceXhr',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            fallback_thresholds: Optional[pulumi.Input[pulumi.InputType['WebAppKeyPerformanceXhrFallbackThresholdsArgs']]] = None,
            kpm: Optional[pulumi.Input[str]] = None,
            scope: Optional[pulumi.Input[str]] = None,
            thresholds: Optional[pulumi.Input[pulumi.InputType['WebAppKeyPerformanceXhrThresholdsArgs']]] = None) -> 'WebAppKeyPerformanceXhr':
        """
        Get an existing WebAppKeyPerformanceXhr resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['WebAppKeyPerformanceXhrFallbackThresholdsArgs']] fallback_thresholds: If the selected key performance metric is not detected, the **User action duration** metric is used instead.
        :param pulumi.Input[str] kpm: Possible Values: `RESPONSE_END`, `RESPONSE_START`, `USER_ACTION_DURATION`, `VISUALLY_COMPLETE`
        :param pulumi.Input[str] scope: The scope of this setting (APPLICATION_METHOD, APPLICATION)
        :param pulumi.Input[pulumi.InputType['WebAppKeyPerformanceXhrThresholdsArgs']] thresholds: Set the Tolerating and Frustrated performance thresholds for this action type.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _WebAppKeyPerformanceXhrState.__new__(_WebAppKeyPerformanceXhrState)

        __props__.__dict__["fallback_thresholds"] = fallback_thresholds
        __props__.__dict__["kpm"] = kpm
        __props__.__dict__["scope"] = scope
        __props__.__dict__["thresholds"] = thresholds
        return WebAppKeyPerformanceXhr(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="fallbackThresholds")
    def fallback_thresholds(self) -> pulumi.Output[Optional['outputs.WebAppKeyPerformanceXhrFallbackThresholds']]:
        """
        If the selected key performance metric is not detected, the **User action duration** metric is used instead.
        """
        return pulumi.get(self, "fallback_thresholds")

    @property
    @pulumi.getter
    def kpm(self) -> pulumi.Output[str]:
        """
        Possible Values: `RESPONSE_END`, `RESPONSE_START`, `USER_ACTION_DURATION`, `VISUALLY_COMPLETE`
        """
        return pulumi.get(self, "kpm")

    @property
    @pulumi.getter
    def scope(self) -> pulumi.Output[str]:
        """
        The scope of this setting (APPLICATION_METHOD, APPLICATION)
        """
        return pulumi.get(self, "scope")

    @property
    @pulumi.getter
    def thresholds(self) -> pulumi.Output['outputs.WebAppKeyPerformanceXhrThresholds']:
        """
        Set the Tolerating and Frustrated performance thresholds for this action type.
        """
        return pulumi.get(self, "thresholds")

