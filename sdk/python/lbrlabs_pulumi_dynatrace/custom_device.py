# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['CustomDeviceArgs', 'CustomDevice']

@pulumi.input_type
class CustomDeviceArgs:
    def __init__(__self__, *,
                 display_name: pulumi.Input[str],
                 config_url: Optional[pulumi.Input[str]] = None,
                 custom_device_id: Optional[pulumi.Input[str]] = None,
                 dns_names: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 favicon_url: Optional[pulumi.Input[str]] = None,
                 group: Optional[pulumi.Input[str]] = None,
                 ip_addresses: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 listen_ports: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]] = None,
                 properties: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 props: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 ui_based: Optional[pulumi.Input[bool]] = None):
        """
        The set of arguments for constructing a CustomDevice resource.
        :param pulumi.Input[str] display_name: The name of the custom device, displayed in the UI.
        :param pulumi.Input[str] config_url: The URL of a configuration web page for the custom device, such as a login page for a firewall or router.
        :param pulumi.Input[str] custom_device_id: The unique name of the custom device. This Id can either be provided in the resource or generated by Terraform when the
               resource is created. If you use the ID of an existing device, the respective parameters will be updated
        :param pulumi.Input[Sequence[pulumi.Input[str]]] dns_names: The list of DNS names related to the custom device.
        :param pulumi.Input[str] favicon_url: The icon to be displayed for your custom component within Smartscape. Provide the full URL of the icon file.
        :param pulumi.Input[str] group: User defined group of entity. Changing the group requires a new custom device to be created.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] ip_addresses: The list of IP addresses that belong to the custom device.
        :param pulumi.Input[Sequence[pulumi.Input[int]]] listen_ports: The list of ports the custom devices listens to.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] properties: The list of key-value pair properties that will be shown beneath the infographics of your custom device.
        :param pulumi.Input[str] props: The list of key-value pair properties that will be shown beneath the infographics of your custom device.
        :param pulumi.Input[str] type: The technology type definition of the custom device.
        :param pulumi.Input[bool] ui_based: If `true` the custom device will be handled as if it was created via UI. It will be refreshed automatically and won't age out. This attribute is taken into consideration when creating the custom device. Changing it afterwards won't have an effect.
        """
        pulumi.set(__self__, "display_name", display_name)
        if config_url is not None:
            pulumi.set(__self__, "config_url", config_url)
        if custom_device_id is not None:
            pulumi.set(__self__, "custom_device_id", custom_device_id)
        if dns_names is not None:
            pulumi.set(__self__, "dns_names", dns_names)
        if favicon_url is not None:
            pulumi.set(__self__, "favicon_url", favicon_url)
        if group is not None:
            pulumi.set(__self__, "group", group)
        if ip_addresses is not None:
            pulumi.set(__self__, "ip_addresses", ip_addresses)
        if listen_ports is not None:
            pulumi.set(__self__, "listen_ports", listen_ports)
        if properties is not None:
            warnings.warn("""Please use the attribute `props` instead""", DeprecationWarning)
            pulumi.log.warn("""properties is deprecated: Please use the attribute `props` instead""")
        if properties is not None:
            pulumi.set(__self__, "properties", properties)
        if props is not None:
            pulumi.set(__self__, "props", props)
        if type is not None:
            pulumi.set(__self__, "type", type)
        if ui_based is not None:
            pulumi.set(__self__, "ui_based", ui_based)

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> pulumi.Input[str]:
        """
        The name of the custom device, displayed in the UI.
        """
        return pulumi.get(self, "display_name")

    @display_name.setter
    def display_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "display_name", value)

    @property
    @pulumi.getter(name="configUrl")
    def config_url(self) -> Optional[pulumi.Input[str]]:
        """
        The URL of a configuration web page for the custom device, such as a login page for a firewall or router.
        """
        return pulumi.get(self, "config_url")

    @config_url.setter
    def config_url(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "config_url", value)

    @property
    @pulumi.getter(name="customDeviceId")
    def custom_device_id(self) -> Optional[pulumi.Input[str]]:
        """
        The unique name of the custom device. This Id can either be provided in the resource or generated by Terraform when the
        resource is created. If you use the ID of an existing device, the respective parameters will be updated
        """
        return pulumi.get(self, "custom_device_id")

    @custom_device_id.setter
    def custom_device_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "custom_device_id", value)

    @property
    @pulumi.getter(name="dnsNames")
    def dns_names(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        The list of DNS names related to the custom device.
        """
        return pulumi.get(self, "dns_names")

    @dns_names.setter
    def dns_names(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "dns_names", value)

    @property
    @pulumi.getter(name="faviconUrl")
    def favicon_url(self) -> Optional[pulumi.Input[str]]:
        """
        The icon to be displayed for your custom component within Smartscape. Provide the full URL of the icon file.
        """
        return pulumi.get(self, "favicon_url")

    @favicon_url.setter
    def favicon_url(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "favicon_url", value)

    @property
    @pulumi.getter
    def group(self) -> Optional[pulumi.Input[str]]:
        """
        User defined group of entity. Changing the group requires a new custom device to be created.
        """
        return pulumi.get(self, "group")

    @group.setter
    def group(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "group", value)

    @property
    @pulumi.getter(name="ipAddresses")
    def ip_addresses(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        The list of IP addresses that belong to the custom device.
        """
        return pulumi.get(self, "ip_addresses")

    @ip_addresses.setter
    def ip_addresses(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "ip_addresses", value)

    @property
    @pulumi.getter(name="listenPorts")
    def listen_ports(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[int]]]]:
        """
        The list of ports the custom devices listens to.
        """
        return pulumi.get(self, "listen_ports")

    @listen_ports.setter
    def listen_ports(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]]):
        pulumi.set(self, "listen_ports", value)

    @property
    @pulumi.getter
    def properties(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        The list of key-value pair properties that will be shown beneath the infographics of your custom device.
        """
        warnings.warn("""Please use the attribute `props` instead""", DeprecationWarning)
        pulumi.log.warn("""properties is deprecated: Please use the attribute `props` instead""")

        return pulumi.get(self, "properties")

    @properties.setter
    def properties(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "properties", value)

    @property
    @pulumi.getter
    def props(self) -> Optional[pulumi.Input[str]]:
        """
        The list of key-value pair properties that will be shown beneath the infographics of your custom device.
        """
        return pulumi.get(self, "props")

    @props.setter
    def props(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "props", value)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input[str]]:
        """
        The technology type definition of the custom device.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter(name="uiBased")
    def ui_based(self) -> Optional[pulumi.Input[bool]]:
        """
        If `true` the custom device will be handled as if it was created via UI. It will be refreshed automatically and won't age out. This attribute is taken into consideration when creating the custom device. Changing it afterwards won't have an effect.
        """
        return pulumi.get(self, "ui_based")

    @ui_based.setter
    def ui_based(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "ui_based", value)


@pulumi.input_type
class _CustomDeviceState:
    def __init__(__self__, *,
                 config_url: Optional[pulumi.Input[str]] = None,
                 custom_device_id: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 dns_names: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 entity_id: Optional[pulumi.Input[str]] = None,
                 favicon_url: Optional[pulumi.Input[str]] = None,
                 group: Optional[pulumi.Input[str]] = None,
                 ip_addresses: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 listen_ports: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]] = None,
                 properties: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 props: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 ui_based: Optional[pulumi.Input[bool]] = None):
        """
        Input properties used for looking up and filtering CustomDevice resources.
        :param pulumi.Input[str] config_url: The URL of a configuration web page for the custom device, such as a login page for a firewall or router.
        :param pulumi.Input[str] custom_device_id: The unique name of the custom device. This Id can either be provided in the resource or generated by Terraform when the
               resource is created. If you use the ID of an existing device, the respective parameters will be updated
        :param pulumi.Input[str] display_name: The name of the custom device, displayed in the UI.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] dns_names: The list of DNS names related to the custom device.
        :param pulumi.Input[str] entity_id: The Dynatrace EntityID of this resource. If you need to refer to this custom device within other resources you want to use this ID
        :param pulumi.Input[str] favicon_url: The icon to be displayed for your custom component within Smartscape. Provide the full URL of the icon file.
        :param pulumi.Input[str] group: User defined group of entity. Changing the group requires a new custom device to be created.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] ip_addresses: The list of IP addresses that belong to the custom device.
        :param pulumi.Input[Sequence[pulumi.Input[int]]] listen_ports: The list of ports the custom devices listens to.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] properties: The list of key-value pair properties that will be shown beneath the infographics of your custom device.
        :param pulumi.Input[str] props: The list of key-value pair properties that will be shown beneath the infographics of your custom device.
        :param pulumi.Input[str] type: The technology type definition of the custom device.
        :param pulumi.Input[bool] ui_based: If `true` the custom device will be handled as if it was created via UI. It will be refreshed automatically and won't age out. This attribute is taken into consideration when creating the custom device. Changing it afterwards won't have an effect.
        """
        if config_url is not None:
            pulumi.set(__self__, "config_url", config_url)
        if custom_device_id is not None:
            pulumi.set(__self__, "custom_device_id", custom_device_id)
        if display_name is not None:
            pulumi.set(__self__, "display_name", display_name)
        if dns_names is not None:
            pulumi.set(__self__, "dns_names", dns_names)
        if entity_id is not None:
            pulumi.set(__self__, "entity_id", entity_id)
        if favicon_url is not None:
            pulumi.set(__self__, "favicon_url", favicon_url)
        if group is not None:
            pulumi.set(__self__, "group", group)
        if ip_addresses is not None:
            pulumi.set(__self__, "ip_addresses", ip_addresses)
        if listen_ports is not None:
            pulumi.set(__self__, "listen_ports", listen_ports)
        if properties is not None:
            warnings.warn("""Please use the attribute `props` instead""", DeprecationWarning)
            pulumi.log.warn("""properties is deprecated: Please use the attribute `props` instead""")
        if properties is not None:
            pulumi.set(__self__, "properties", properties)
        if props is not None:
            pulumi.set(__self__, "props", props)
        if type is not None:
            pulumi.set(__self__, "type", type)
        if ui_based is not None:
            pulumi.set(__self__, "ui_based", ui_based)

    @property
    @pulumi.getter(name="configUrl")
    def config_url(self) -> Optional[pulumi.Input[str]]:
        """
        The URL of a configuration web page for the custom device, such as a login page for a firewall or router.
        """
        return pulumi.get(self, "config_url")

    @config_url.setter
    def config_url(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "config_url", value)

    @property
    @pulumi.getter(name="customDeviceId")
    def custom_device_id(self) -> Optional[pulumi.Input[str]]:
        """
        The unique name of the custom device. This Id can either be provided in the resource or generated by Terraform when the
        resource is created. If you use the ID of an existing device, the respective parameters will be updated
        """
        return pulumi.get(self, "custom_device_id")

    @custom_device_id.setter
    def custom_device_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "custom_device_id", value)

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the custom device, displayed in the UI.
        """
        return pulumi.get(self, "display_name")

    @display_name.setter
    def display_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "display_name", value)

    @property
    @pulumi.getter(name="dnsNames")
    def dns_names(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        The list of DNS names related to the custom device.
        """
        return pulumi.get(self, "dns_names")

    @dns_names.setter
    def dns_names(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "dns_names", value)

    @property
    @pulumi.getter(name="entityId")
    def entity_id(self) -> Optional[pulumi.Input[str]]:
        """
        The Dynatrace EntityID of this resource. If you need to refer to this custom device within other resources you want to use this ID
        """
        return pulumi.get(self, "entity_id")

    @entity_id.setter
    def entity_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "entity_id", value)

    @property
    @pulumi.getter(name="faviconUrl")
    def favicon_url(self) -> Optional[pulumi.Input[str]]:
        """
        The icon to be displayed for your custom component within Smartscape. Provide the full URL of the icon file.
        """
        return pulumi.get(self, "favicon_url")

    @favicon_url.setter
    def favicon_url(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "favicon_url", value)

    @property
    @pulumi.getter
    def group(self) -> Optional[pulumi.Input[str]]:
        """
        User defined group of entity. Changing the group requires a new custom device to be created.
        """
        return pulumi.get(self, "group")

    @group.setter
    def group(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "group", value)

    @property
    @pulumi.getter(name="ipAddresses")
    def ip_addresses(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        The list of IP addresses that belong to the custom device.
        """
        return pulumi.get(self, "ip_addresses")

    @ip_addresses.setter
    def ip_addresses(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "ip_addresses", value)

    @property
    @pulumi.getter(name="listenPorts")
    def listen_ports(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[int]]]]:
        """
        The list of ports the custom devices listens to.
        """
        return pulumi.get(self, "listen_ports")

    @listen_ports.setter
    def listen_ports(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]]):
        pulumi.set(self, "listen_ports", value)

    @property
    @pulumi.getter
    def properties(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        The list of key-value pair properties that will be shown beneath the infographics of your custom device.
        """
        warnings.warn("""Please use the attribute `props` instead""", DeprecationWarning)
        pulumi.log.warn("""properties is deprecated: Please use the attribute `props` instead""")

        return pulumi.get(self, "properties")

    @properties.setter
    def properties(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "properties", value)

    @property
    @pulumi.getter
    def props(self) -> Optional[pulumi.Input[str]]:
        """
        The list of key-value pair properties that will be shown beneath the infographics of your custom device.
        """
        return pulumi.get(self, "props")

    @props.setter
    def props(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "props", value)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input[str]]:
        """
        The technology type definition of the custom device.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter(name="uiBased")
    def ui_based(self) -> Optional[pulumi.Input[bool]]:
        """
        If `true` the custom device will be handled as if it was created via UI. It will be refreshed automatically and won't age out. This attribute is taken into consideration when creating the custom device. Changing it afterwards won't have an effect.
        """
        return pulumi.get(self, "ui_based")

    @ui_based.setter
    def ui_based(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "ui_based", value)


class CustomDevice(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 config_url: Optional[pulumi.Input[str]] = None,
                 custom_device_id: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 dns_names: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 favicon_url: Optional[pulumi.Input[str]] = None,
                 group: Optional[pulumi.Input[str]] = None,
                 ip_addresses: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 listen_ports: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]] = None,
                 properties: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 props: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 ui_based: Optional[pulumi.Input[bool]] = None,
                 __props__=None):
        """
        > This resource requires the API token scopes **Read entities** (`entities.read`) and **Write entities** (`entities.write`)

        ## Dynatrace Documentation

        - Monitored entities API - https://www.dynatrace.com/support/help/dynatrace-api/environment-api/entity-v2

        ## Resource Example Usage

        ```python
        import pulumi
        import lbrlabs_pulumi_dynatrace as dynatrace

        _name_ = dynatrace.CustomDevice("#name#",
            custom_device_id="customDeviceId",
            display_name="customDevicename")
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] config_url: The URL of a configuration web page for the custom device, such as a login page for a firewall or router.
        :param pulumi.Input[str] custom_device_id: The unique name of the custom device. This Id can either be provided in the resource or generated by Terraform when the
               resource is created. If you use the ID of an existing device, the respective parameters will be updated
        :param pulumi.Input[str] display_name: The name of the custom device, displayed in the UI.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] dns_names: The list of DNS names related to the custom device.
        :param pulumi.Input[str] favicon_url: The icon to be displayed for your custom component within Smartscape. Provide the full URL of the icon file.
        :param pulumi.Input[str] group: User defined group of entity. Changing the group requires a new custom device to be created.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] ip_addresses: The list of IP addresses that belong to the custom device.
        :param pulumi.Input[Sequence[pulumi.Input[int]]] listen_ports: The list of ports the custom devices listens to.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] properties: The list of key-value pair properties that will be shown beneath the infographics of your custom device.
        :param pulumi.Input[str] props: The list of key-value pair properties that will be shown beneath the infographics of your custom device.
        :param pulumi.Input[str] type: The technology type definition of the custom device.
        :param pulumi.Input[bool] ui_based: If `true` the custom device will be handled as if it was created via UI. It will be refreshed automatically and won't age out. This attribute is taken into consideration when creating the custom device. Changing it afterwards won't have an effect.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: CustomDeviceArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        > This resource requires the API token scopes **Read entities** (`entities.read`) and **Write entities** (`entities.write`)

        ## Dynatrace Documentation

        - Monitored entities API - https://www.dynatrace.com/support/help/dynatrace-api/environment-api/entity-v2

        ## Resource Example Usage

        ```python
        import pulumi
        import lbrlabs_pulumi_dynatrace as dynatrace

        _name_ = dynatrace.CustomDevice("#name#",
            custom_device_id="customDeviceId",
            display_name="customDevicename")
        ```

        :param str resource_name: The name of the resource.
        :param CustomDeviceArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(CustomDeviceArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 config_url: Optional[pulumi.Input[str]] = None,
                 custom_device_id: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 dns_names: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 favicon_url: Optional[pulumi.Input[str]] = None,
                 group: Optional[pulumi.Input[str]] = None,
                 ip_addresses: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 listen_ports: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]] = None,
                 properties: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 props: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 ui_based: Optional[pulumi.Input[bool]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = CustomDeviceArgs.__new__(CustomDeviceArgs)

            __props__.__dict__["config_url"] = config_url
            __props__.__dict__["custom_device_id"] = custom_device_id
            if display_name is None and not opts.urn:
                raise TypeError("Missing required property 'display_name'")
            __props__.__dict__["display_name"] = display_name
            __props__.__dict__["dns_names"] = dns_names
            __props__.__dict__["favicon_url"] = favicon_url
            __props__.__dict__["group"] = group
            __props__.__dict__["ip_addresses"] = ip_addresses
            __props__.__dict__["listen_ports"] = listen_ports
            __props__.__dict__["properties"] = properties
            __props__.__dict__["props"] = props
            __props__.__dict__["type"] = type
            __props__.__dict__["ui_based"] = ui_based
            __props__.__dict__["entity_id"] = None
        super(CustomDevice, __self__).__init__(
            'dynatrace:index/customDevice:CustomDevice',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            config_url: Optional[pulumi.Input[str]] = None,
            custom_device_id: Optional[pulumi.Input[str]] = None,
            display_name: Optional[pulumi.Input[str]] = None,
            dns_names: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            entity_id: Optional[pulumi.Input[str]] = None,
            favicon_url: Optional[pulumi.Input[str]] = None,
            group: Optional[pulumi.Input[str]] = None,
            ip_addresses: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            listen_ports: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]] = None,
            properties: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            props: Optional[pulumi.Input[str]] = None,
            type: Optional[pulumi.Input[str]] = None,
            ui_based: Optional[pulumi.Input[bool]] = None) -> 'CustomDevice':
        """
        Get an existing CustomDevice resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] config_url: The URL of a configuration web page for the custom device, such as a login page for a firewall or router.
        :param pulumi.Input[str] custom_device_id: The unique name of the custom device. This Id can either be provided in the resource or generated by Terraform when the
               resource is created. If you use the ID of an existing device, the respective parameters will be updated
        :param pulumi.Input[str] display_name: The name of the custom device, displayed in the UI.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] dns_names: The list of DNS names related to the custom device.
        :param pulumi.Input[str] entity_id: The Dynatrace EntityID of this resource. If you need to refer to this custom device within other resources you want to use this ID
        :param pulumi.Input[str] favicon_url: The icon to be displayed for your custom component within Smartscape. Provide the full URL of the icon file.
        :param pulumi.Input[str] group: User defined group of entity. Changing the group requires a new custom device to be created.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] ip_addresses: The list of IP addresses that belong to the custom device.
        :param pulumi.Input[Sequence[pulumi.Input[int]]] listen_ports: The list of ports the custom devices listens to.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] properties: The list of key-value pair properties that will be shown beneath the infographics of your custom device.
        :param pulumi.Input[str] props: The list of key-value pair properties that will be shown beneath the infographics of your custom device.
        :param pulumi.Input[str] type: The technology type definition of the custom device.
        :param pulumi.Input[bool] ui_based: If `true` the custom device will be handled as if it was created via UI. It will be refreshed automatically and won't age out. This attribute is taken into consideration when creating the custom device. Changing it afterwards won't have an effect.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _CustomDeviceState.__new__(_CustomDeviceState)

        __props__.__dict__["config_url"] = config_url
        __props__.__dict__["custom_device_id"] = custom_device_id
        __props__.__dict__["display_name"] = display_name
        __props__.__dict__["dns_names"] = dns_names
        __props__.__dict__["entity_id"] = entity_id
        __props__.__dict__["favicon_url"] = favicon_url
        __props__.__dict__["group"] = group
        __props__.__dict__["ip_addresses"] = ip_addresses
        __props__.__dict__["listen_ports"] = listen_ports
        __props__.__dict__["properties"] = properties
        __props__.__dict__["props"] = props
        __props__.__dict__["type"] = type
        __props__.__dict__["ui_based"] = ui_based
        return CustomDevice(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="configUrl")
    def config_url(self) -> pulumi.Output[Optional[str]]:
        """
        The URL of a configuration web page for the custom device, such as a login page for a firewall or router.
        """
        return pulumi.get(self, "config_url")

    @property
    @pulumi.getter(name="customDeviceId")
    def custom_device_id(self) -> pulumi.Output[str]:
        """
        The unique name of the custom device. This Id can either be provided in the resource or generated by Terraform when the
        resource is created. If you use the ID of an existing device, the respective parameters will be updated
        """
        return pulumi.get(self, "custom_device_id")

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> pulumi.Output[str]:
        """
        The name of the custom device, displayed in the UI.
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter(name="dnsNames")
    def dns_names(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        The list of DNS names related to the custom device.
        """
        return pulumi.get(self, "dns_names")

    @property
    @pulumi.getter(name="entityId")
    def entity_id(self) -> pulumi.Output[str]:
        """
        The Dynatrace EntityID of this resource. If you need to refer to this custom device within other resources you want to use this ID
        """
        return pulumi.get(self, "entity_id")

    @property
    @pulumi.getter(name="faviconUrl")
    def favicon_url(self) -> pulumi.Output[Optional[str]]:
        """
        The icon to be displayed for your custom component within Smartscape. Provide the full URL of the icon file.
        """
        return pulumi.get(self, "favicon_url")

    @property
    @pulumi.getter
    def group(self) -> pulumi.Output[str]:
        """
        User defined group of entity. Changing the group requires a new custom device to be created.
        """
        return pulumi.get(self, "group")

    @property
    @pulumi.getter(name="ipAddresses")
    def ip_addresses(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        The list of IP addresses that belong to the custom device.
        """
        return pulumi.get(self, "ip_addresses")

    @property
    @pulumi.getter(name="listenPorts")
    def listen_ports(self) -> pulumi.Output[Optional[Sequence[int]]]:
        """
        The list of ports the custom devices listens to.
        """
        return pulumi.get(self, "listen_ports")

    @property
    @pulumi.getter
    def properties(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        The list of key-value pair properties that will be shown beneath the infographics of your custom device.
        """
        warnings.warn("""Please use the attribute `props` instead""", DeprecationWarning)
        pulumi.log.warn("""properties is deprecated: Please use the attribute `props` instead""")

        return pulumi.get(self, "properties")

    @property
    @pulumi.getter
    def props(self) -> pulumi.Output[Optional[str]]:
        """
        The list of key-value pair properties that will be shown beneath the infographics of your custom device.
        """
        return pulumi.get(self, "props")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        The technology type definition of the custom device.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="uiBased")
    def ui_based(self) -> pulumi.Output[Optional[bool]]:
        """
        If `true` the custom device will be handled as if it was created via UI. It will be refreshed automatically and won't age out. This attribute is taken into consideration when creating the custom device. Changing it afterwards won't have an effect.
        """
        return pulumi.get(self, "ui_based")

