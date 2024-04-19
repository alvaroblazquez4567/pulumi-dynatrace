# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['ManagedPublicEndpointsArgs', 'ManagedPublicEndpoints']

@pulumi.input_type
class ManagedPublicEndpointsArgs:
    def __init__(__self__, *,
                 additional_web_ui_addresses: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 beacon_forwarder_address: Optional[pulumi.Input[str]] = None,
                 cdn_address: Optional[pulumi.Input[str]] = None,
                 web_ui_address: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a ManagedPublicEndpoints resource.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] additional_web_ui_addresses: Additional web UI addresses
        :param pulumi.Input[str] beacon_forwarder_address: Beacon forwarder address
        :param pulumi.Input[str] cdn_address: CDN address
        :param pulumi.Input[str] web_ui_address: Web UI address
        """
        if additional_web_ui_addresses is not None:
            pulumi.set(__self__, "additional_web_ui_addresses", additional_web_ui_addresses)
        if beacon_forwarder_address is not None:
            pulumi.set(__self__, "beacon_forwarder_address", beacon_forwarder_address)
        if cdn_address is not None:
            pulumi.set(__self__, "cdn_address", cdn_address)
        if web_ui_address is not None:
            pulumi.set(__self__, "web_ui_address", web_ui_address)

    @property
    @pulumi.getter(name="additionalWebUiAddresses")
    def additional_web_ui_addresses(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Additional web UI addresses
        """
        return pulumi.get(self, "additional_web_ui_addresses")

    @additional_web_ui_addresses.setter
    def additional_web_ui_addresses(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "additional_web_ui_addresses", value)

    @property
    @pulumi.getter(name="beaconForwarderAddress")
    def beacon_forwarder_address(self) -> Optional[pulumi.Input[str]]:
        """
        Beacon forwarder address
        """
        return pulumi.get(self, "beacon_forwarder_address")

    @beacon_forwarder_address.setter
    def beacon_forwarder_address(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "beacon_forwarder_address", value)

    @property
    @pulumi.getter(name="cdnAddress")
    def cdn_address(self) -> Optional[pulumi.Input[str]]:
        """
        CDN address
        """
        return pulumi.get(self, "cdn_address")

    @cdn_address.setter
    def cdn_address(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cdn_address", value)

    @property
    @pulumi.getter(name="webUiAddress")
    def web_ui_address(self) -> Optional[pulumi.Input[str]]:
        """
        Web UI address
        """
        return pulumi.get(self, "web_ui_address")

    @web_ui_address.setter
    def web_ui_address(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "web_ui_address", value)


@pulumi.input_type
class _ManagedPublicEndpointsState:
    def __init__(__self__, *,
                 additional_web_ui_addresses: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 beacon_forwarder_address: Optional[pulumi.Input[str]] = None,
                 cdn_address: Optional[pulumi.Input[str]] = None,
                 web_ui_address: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering ManagedPublicEndpoints resources.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] additional_web_ui_addresses: Additional web UI addresses
        :param pulumi.Input[str] beacon_forwarder_address: Beacon forwarder address
        :param pulumi.Input[str] cdn_address: CDN address
        :param pulumi.Input[str] web_ui_address: Web UI address
        """
        if additional_web_ui_addresses is not None:
            pulumi.set(__self__, "additional_web_ui_addresses", additional_web_ui_addresses)
        if beacon_forwarder_address is not None:
            pulumi.set(__self__, "beacon_forwarder_address", beacon_forwarder_address)
        if cdn_address is not None:
            pulumi.set(__self__, "cdn_address", cdn_address)
        if web_ui_address is not None:
            pulumi.set(__self__, "web_ui_address", web_ui_address)

    @property
    @pulumi.getter(name="additionalWebUiAddresses")
    def additional_web_ui_addresses(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Additional web UI addresses
        """
        return pulumi.get(self, "additional_web_ui_addresses")

    @additional_web_ui_addresses.setter
    def additional_web_ui_addresses(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "additional_web_ui_addresses", value)

    @property
    @pulumi.getter(name="beaconForwarderAddress")
    def beacon_forwarder_address(self) -> Optional[pulumi.Input[str]]:
        """
        Beacon forwarder address
        """
        return pulumi.get(self, "beacon_forwarder_address")

    @beacon_forwarder_address.setter
    def beacon_forwarder_address(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "beacon_forwarder_address", value)

    @property
    @pulumi.getter(name="cdnAddress")
    def cdn_address(self) -> Optional[pulumi.Input[str]]:
        """
        CDN address
        """
        return pulumi.get(self, "cdn_address")

    @cdn_address.setter
    def cdn_address(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cdn_address", value)

    @property
    @pulumi.getter(name="webUiAddress")
    def web_ui_address(self) -> Optional[pulumi.Input[str]]:
        """
        Web UI address
        """
        return pulumi.get(self, "web_ui_address")

    @web_ui_address.setter
    def web_ui_address(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "web_ui_address", value)


class ManagedPublicEndpoints(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 additional_web_ui_addresses: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 beacon_forwarder_address: Optional[pulumi.Input[str]] = None,
                 cdn_address: Optional[pulumi.Input[str]] = None,
                 web_ui_address: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a ManagedPublicEndpoints resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] additional_web_ui_addresses: Additional web UI addresses
        :param pulumi.Input[str] beacon_forwarder_address: Beacon forwarder address
        :param pulumi.Input[str] cdn_address: CDN address
        :param pulumi.Input[str] web_ui_address: Web UI address
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[ManagedPublicEndpointsArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a ManagedPublicEndpoints resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param ManagedPublicEndpointsArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ManagedPublicEndpointsArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 additional_web_ui_addresses: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 beacon_forwarder_address: Optional[pulumi.Input[str]] = None,
                 cdn_address: Optional[pulumi.Input[str]] = None,
                 web_ui_address: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ManagedPublicEndpointsArgs.__new__(ManagedPublicEndpointsArgs)

            __props__.__dict__["additional_web_ui_addresses"] = additional_web_ui_addresses
            __props__.__dict__["beacon_forwarder_address"] = beacon_forwarder_address
            __props__.__dict__["cdn_address"] = cdn_address
            __props__.__dict__["web_ui_address"] = web_ui_address
        super(ManagedPublicEndpoints, __self__).__init__(
            'dynatrace:index/managedPublicEndpoints:ManagedPublicEndpoints',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            additional_web_ui_addresses: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            beacon_forwarder_address: Optional[pulumi.Input[str]] = None,
            cdn_address: Optional[pulumi.Input[str]] = None,
            web_ui_address: Optional[pulumi.Input[str]] = None) -> 'ManagedPublicEndpoints':
        """
        Get an existing ManagedPublicEndpoints resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] additional_web_ui_addresses: Additional web UI addresses
        :param pulumi.Input[str] beacon_forwarder_address: Beacon forwarder address
        :param pulumi.Input[str] cdn_address: CDN address
        :param pulumi.Input[str] web_ui_address: Web UI address
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ManagedPublicEndpointsState.__new__(_ManagedPublicEndpointsState)

        __props__.__dict__["additional_web_ui_addresses"] = additional_web_ui_addresses
        __props__.__dict__["beacon_forwarder_address"] = beacon_forwarder_address
        __props__.__dict__["cdn_address"] = cdn_address
        __props__.__dict__["web_ui_address"] = web_ui_address
        return ManagedPublicEndpoints(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="additionalWebUiAddresses")
    def additional_web_ui_addresses(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        Additional web UI addresses
        """
        return pulumi.get(self, "additional_web_ui_addresses")

    @property
    @pulumi.getter(name="beaconForwarderAddress")
    def beacon_forwarder_address(self) -> pulumi.Output[Optional[str]]:
        """
        Beacon forwarder address
        """
        return pulumi.get(self, "beacon_forwarder_address")

    @property
    @pulumi.getter(name="cdnAddress")
    def cdn_address(self) -> pulumi.Output[Optional[str]]:
        """
        CDN address
        """
        return pulumi.get(self, "cdn_address")

    @property
    @pulumi.getter(name="webUiAddress")
    def web_ui_address(self) -> pulumi.Output[Optional[str]]:
        """
        Web UI address
        """
        return pulumi.get(self, "web_ui_address")
