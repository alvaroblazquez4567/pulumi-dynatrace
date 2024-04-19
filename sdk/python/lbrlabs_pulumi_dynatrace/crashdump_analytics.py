# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['CrashdumpAnalyticsArgs', 'CrashdumpAnalytics']

@pulumi.input_type
class CrashdumpAnalyticsArgs:
    def __init__(__self__, *,
                 enable_crash_dump_analytics: pulumi.Input[bool],
                 host_id: pulumi.Input[str]):
        """
        The set of arguments for constructing a CrashdumpAnalytics resource.
        :param pulumi.Input[bool] enable_crash_dump_analytics: Control the automatic crash dump analytics feature. It's strongly recommended to keep this option enabled. Disabling this feature will stop receiving information about potential problems
        :param pulumi.Input[str] host_id: The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        """
        pulumi.set(__self__, "enable_crash_dump_analytics", enable_crash_dump_analytics)
        pulumi.set(__self__, "host_id", host_id)

    @property
    @pulumi.getter(name="enableCrashDumpAnalytics")
    def enable_crash_dump_analytics(self) -> pulumi.Input[bool]:
        """
        Control the automatic crash dump analytics feature. It's strongly recommended to keep this option enabled. Disabling this feature will stop receiving information about potential problems
        """
        return pulumi.get(self, "enable_crash_dump_analytics")

    @enable_crash_dump_analytics.setter
    def enable_crash_dump_analytics(self, value: pulumi.Input[bool]):
        pulumi.set(self, "enable_crash_dump_analytics", value)

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


@pulumi.input_type
class _CrashdumpAnalyticsState:
    def __init__(__self__, *,
                 enable_crash_dump_analytics: Optional[pulumi.Input[bool]] = None,
                 host_id: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering CrashdumpAnalytics resources.
        :param pulumi.Input[bool] enable_crash_dump_analytics: Control the automatic crash dump analytics feature. It's strongly recommended to keep this option enabled. Disabling this feature will stop receiving information about potential problems
        :param pulumi.Input[str] host_id: The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        """
        if enable_crash_dump_analytics is not None:
            pulumi.set(__self__, "enable_crash_dump_analytics", enable_crash_dump_analytics)
        if host_id is not None:
            pulumi.set(__self__, "host_id", host_id)

    @property
    @pulumi.getter(name="enableCrashDumpAnalytics")
    def enable_crash_dump_analytics(self) -> Optional[pulumi.Input[bool]]:
        """
        Control the automatic crash dump analytics feature. It's strongly recommended to keep this option enabled. Disabling this feature will stop receiving information about potential problems
        """
        return pulumi.get(self, "enable_crash_dump_analytics")

    @enable_crash_dump_analytics.setter
    def enable_crash_dump_analytics(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enable_crash_dump_analytics", value)

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


class CrashdumpAnalytics(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 enable_crash_dump_analytics: Optional[pulumi.Input[bool]] = None,
                 host_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a CrashdumpAnalytics resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] enable_crash_dump_analytics: Control the automatic crash dump analytics feature. It's strongly recommended to keep this option enabled. Disabling this feature will stop receiving information about potential problems
        :param pulumi.Input[str] host_id: The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: CrashdumpAnalyticsArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a CrashdumpAnalytics resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param CrashdumpAnalyticsArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(CrashdumpAnalyticsArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 enable_crash_dump_analytics: Optional[pulumi.Input[bool]] = None,
                 host_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = CrashdumpAnalyticsArgs.__new__(CrashdumpAnalyticsArgs)

            if enable_crash_dump_analytics is None and not opts.urn:
                raise TypeError("Missing required property 'enable_crash_dump_analytics'")
            __props__.__dict__["enable_crash_dump_analytics"] = enable_crash_dump_analytics
            if host_id is None and not opts.urn:
                raise TypeError("Missing required property 'host_id'")
            __props__.__dict__["host_id"] = host_id
        super(CrashdumpAnalytics, __self__).__init__(
            'dynatrace:index/crashdumpAnalytics:CrashdumpAnalytics',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            enable_crash_dump_analytics: Optional[pulumi.Input[bool]] = None,
            host_id: Optional[pulumi.Input[str]] = None) -> 'CrashdumpAnalytics':
        """
        Get an existing CrashdumpAnalytics resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] enable_crash_dump_analytics: Control the automatic crash dump analytics feature. It's strongly recommended to keep this option enabled. Disabling this feature will stop receiving information about potential problems
        :param pulumi.Input[str] host_id: The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _CrashdumpAnalyticsState.__new__(_CrashdumpAnalyticsState)

        __props__.__dict__["enable_crash_dump_analytics"] = enable_crash_dump_analytics
        __props__.__dict__["host_id"] = host_id
        return CrashdumpAnalytics(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="enableCrashDumpAnalytics")
    def enable_crash_dump_analytics(self) -> pulumi.Output[bool]:
        """
        Control the automatic crash dump analytics feature. It's strongly recommended to keep this option enabled. Disabling this feature will stop receiving information about potential problems
        """
        return pulumi.get(self, "enable_crash_dump_analytics")

    @property
    @pulumi.getter(name="hostId")
    def host_id(self) -> pulumi.Output[str]:
        """
        The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
        """
        return pulumi.get(self, "host_id")

