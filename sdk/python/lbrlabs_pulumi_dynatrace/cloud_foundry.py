# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['CloudFoundryArgs', 'CloudFoundry']

@pulumi.input_type
class CloudFoundryArgs:
    def __init__(__self__, *,
                 api_url: pulumi.Input[str],
                 enabled: pulumi.Input[bool],
                 label: pulumi.Input[str],
                 login_url: pulumi.Input[str],
                 password: pulumi.Input[str],
                 username: pulumi.Input[str],
                 active_gate_group: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a CloudFoundry resource.
        :param pulumi.Input[str] api_url: Cloud Foundry API Target
        :param pulumi.Input[bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[str] label: Name this connection
        :param pulumi.Input[str] login_url: Cloud Foundry Authentication Endpoint
        :param pulumi.Input[str] password: Cloud Foundry Password
        :param pulumi.Input[str] username: Cloud Foundry Username
        :param pulumi.Input[str] active_gate_group: ActiveGate group
        """
        pulumi.set(__self__, "api_url", api_url)
        pulumi.set(__self__, "enabled", enabled)
        pulumi.set(__self__, "label", label)
        pulumi.set(__self__, "login_url", login_url)
        pulumi.set(__self__, "password", password)
        pulumi.set(__self__, "username", username)
        if active_gate_group is not None:
            pulumi.set(__self__, "active_gate_group", active_gate_group)

    @property
    @pulumi.getter(name="apiUrl")
    def api_url(self) -> pulumi.Input[str]:
        """
        Cloud Foundry API Target
        """
        return pulumi.get(self, "api_url")

    @api_url.setter
    def api_url(self, value: pulumi.Input[str]):
        pulumi.set(self, "api_url", value)

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
    def label(self) -> pulumi.Input[str]:
        """
        Name this connection
        """
        return pulumi.get(self, "label")

    @label.setter
    def label(self, value: pulumi.Input[str]):
        pulumi.set(self, "label", value)

    @property
    @pulumi.getter(name="loginUrl")
    def login_url(self) -> pulumi.Input[str]:
        """
        Cloud Foundry Authentication Endpoint
        """
        return pulumi.get(self, "login_url")

    @login_url.setter
    def login_url(self, value: pulumi.Input[str]):
        pulumi.set(self, "login_url", value)

    @property
    @pulumi.getter
    def password(self) -> pulumi.Input[str]:
        """
        Cloud Foundry Password
        """
        return pulumi.get(self, "password")

    @password.setter
    def password(self, value: pulumi.Input[str]):
        pulumi.set(self, "password", value)

    @property
    @pulumi.getter
    def username(self) -> pulumi.Input[str]:
        """
        Cloud Foundry Username
        """
        return pulumi.get(self, "username")

    @username.setter
    def username(self, value: pulumi.Input[str]):
        pulumi.set(self, "username", value)

    @property
    @pulumi.getter(name="activeGateGroup")
    def active_gate_group(self) -> Optional[pulumi.Input[str]]:
        """
        ActiveGate group
        """
        return pulumi.get(self, "active_gate_group")

    @active_gate_group.setter
    def active_gate_group(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "active_gate_group", value)


@pulumi.input_type
class _CloudFoundryState:
    def __init__(__self__, *,
                 active_gate_group: Optional[pulumi.Input[str]] = None,
                 api_url: Optional[pulumi.Input[str]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 label: Optional[pulumi.Input[str]] = None,
                 login_url: Optional[pulumi.Input[str]] = None,
                 password: Optional[pulumi.Input[str]] = None,
                 username: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering CloudFoundry resources.
        :param pulumi.Input[str] active_gate_group: ActiveGate group
        :param pulumi.Input[str] api_url: Cloud Foundry API Target
        :param pulumi.Input[bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[str] label: Name this connection
        :param pulumi.Input[str] login_url: Cloud Foundry Authentication Endpoint
        :param pulumi.Input[str] password: Cloud Foundry Password
        :param pulumi.Input[str] username: Cloud Foundry Username
        """
        if active_gate_group is not None:
            pulumi.set(__self__, "active_gate_group", active_gate_group)
        if api_url is not None:
            pulumi.set(__self__, "api_url", api_url)
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)
        if label is not None:
            pulumi.set(__self__, "label", label)
        if login_url is not None:
            pulumi.set(__self__, "login_url", login_url)
        if password is not None:
            pulumi.set(__self__, "password", password)
        if username is not None:
            pulumi.set(__self__, "username", username)

    @property
    @pulumi.getter(name="activeGateGroup")
    def active_gate_group(self) -> Optional[pulumi.Input[str]]:
        """
        ActiveGate group
        """
        return pulumi.get(self, "active_gate_group")

    @active_gate_group.setter
    def active_gate_group(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "active_gate_group", value)

    @property
    @pulumi.getter(name="apiUrl")
    def api_url(self) -> Optional[pulumi.Input[str]]:
        """
        Cloud Foundry API Target
        """
        return pulumi.get(self, "api_url")

    @api_url.setter
    def api_url(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "api_url", value)

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
    @pulumi.getter
    def label(self) -> Optional[pulumi.Input[str]]:
        """
        Name this connection
        """
        return pulumi.get(self, "label")

    @label.setter
    def label(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "label", value)

    @property
    @pulumi.getter(name="loginUrl")
    def login_url(self) -> Optional[pulumi.Input[str]]:
        """
        Cloud Foundry Authentication Endpoint
        """
        return pulumi.get(self, "login_url")

    @login_url.setter
    def login_url(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "login_url", value)

    @property
    @pulumi.getter
    def password(self) -> Optional[pulumi.Input[str]]:
        """
        Cloud Foundry Password
        """
        return pulumi.get(self, "password")

    @password.setter
    def password(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "password", value)

    @property
    @pulumi.getter
    def username(self) -> Optional[pulumi.Input[str]]:
        """
        Cloud Foundry Username
        """
        return pulumi.get(self, "username")

    @username.setter
    def username(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "username", value)


class CloudFoundry(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 active_gate_group: Optional[pulumi.Input[str]] = None,
                 api_url: Optional[pulumi.Input[str]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 label: Optional[pulumi.Input[str]] = None,
                 login_url: Optional[pulumi.Input[str]] = None,
                 password: Optional[pulumi.Input[str]] = None,
                 username: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a CloudFoundry resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] active_gate_group: ActiveGate group
        :param pulumi.Input[str] api_url: Cloud Foundry API Target
        :param pulumi.Input[bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[str] label: Name this connection
        :param pulumi.Input[str] login_url: Cloud Foundry Authentication Endpoint
        :param pulumi.Input[str] password: Cloud Foundry Password
        :param pulumi.Input[str] username: Cloud Foundry Username
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: CloudFoundryArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a CloudFoundry resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param CloudFoundryArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(CloudFoundryArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 active_gate_group: Optional[pulumi.Input[str]] = None,
                 api_url: Optional[pulumi.Input[str]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 label: Optional[pulumi.Input[str]] = None,
                 login_url: Optional[pulumi.Input[str]] = None,
                 password: Optional[pulumi.Input[str]] = None,
                 username: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = CloudFoundryArgs.__new__(CloudFoundryArgs)

            __props__.__dict__["active_gate_group"] = active_gate_group
            if api_url is None and not opts.urn:
                raise TypeError("Missing required property 'api_url'")
            __props__.__dict__["api_url"] = api_url
            if enabled is None and not opts.urn:
                raise TypeError("Missing required property 'enabled'")
            __props__.__dict__["enabled"] = enabled
            if label is None and not opts.urn:
                raise TypeError("Missing required property 'label'")
            __props__.__dict__["label"] = label
            if login_url is None and not opts.urn:
                raise TypeError("Missing required property 'login_url'")
            __props__.__dict__["login_url"] = login_url
            if password is None and not opts.urn:
                raise TypeError("Missing required property 'password'")
            __props__.__dict__["password"] = None if password is None else pulumi.Output.secret(password)
            if username is None and not opts.urn:
                raise TypeError("Missing required property 'username'")
            __props__.__dict__["username"] = username
        secret_opts = pulumi.ResourceOptions(additional_secret_outputs=["password"])
        opts = pulumi.ResourceOptions.merge(opts, secret_opts)
        super(CloudFoundry, __self__).__init__(
            'dynatrace:index/cloudFoundry:CloudFoundry',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            active_gate_group: Optional[pulumi.Input[str]] = None,
            api_url: Optional[pulumi.Input[str]] = None,
            enabled: Optional[pulumi.Input[bool]] = None,
            label: Optional[pulumi.Input[str]] = None,
            login_url: Optional[pulumi.Input[str]] = None,
            password: Optional[pulumi.Input[str]] = None,
            username: Optional[pulumi.Input[str]] = None) -> 'CloudFoundry':
        """
        Get an existing CloudFoundry resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] active_gate_group: ActiveGate group
        :param pulumi.Input[str] api_url: Cloud Foundry API Target
        :param pulumi.Input[bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[str] label: Name this connection
        :param pulumi.Input[str] login_url: Cloud Foundry Authentication Endpoint
        :param pulumi.Input[str] password: Cloud Foundry Password
        :param pulumi.Input[str] username: Cloud Foundry Username
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _CloudFoundryState.__new__(_CloudFoundryState)

        __props__.__dict__["active_gate_group"] = active_gate_group
        __props__.__dict__["api_url"] = api_url
        __props__.__dict__["enabled"] = enabled
        __props__.__dict__["label"] = label
        __props__.__dict__["login_url"] = login_url
        __props__.__dict__["password"] = password
        __props__.__dict__["username"] = username
        return CloudFoundry(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="activeGateGroup")
    def active_gate_group(self) -> pulumi.Output[Optional[str]]:
        """
        ActiveGate group
        """
        return pulumi.get(self, "active_gate_group")

    @property
    @pulumi.getter(name="apiUrl")
    def api_url(self) -> pulumi.Output[str]:
        """
        Cloud Foundry API Target
        """
        return pulumi.get(self, "api_url")

    @property
    @pulumi.getter
    def enabled(self) -> pulumi.Output[bool]:
        """
        This setting is enabled (`true`) or disabled (`false`)
        """
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter
    def label(self) -> pulumi.Output[str]:
        """
        Name this connection
        """
        return pulumi.get(self, "label")

    @property
    @pulumi.getter(name="loginUrl")
    def login_url(self) -> pulumi.Output[str]:
        """
        Cloud Foundry Authentication Endpoint
        """
        return pulumi.get(self, "login_url")

    @property
    @pulumi.getter
    def password(self) -> pulumi.Output[str]:
        """
        Cloud Foundry Password
        """
        return pulumi.get(self, "password")

    @property
    @pulumi.getter
    def username(self) -> pulumi.Output[str]:
        """
        Cloud Foundry Username
        """
        return pulumi.get(self, "username")

