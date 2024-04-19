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

__all__ = ['RequestNamingArgs', 'RequestNaming']

@pulumi.input_type
class RequestNamingArgs:
    def __init__(__self__, *,
                 conditions: pulumi.Input['RequestNamingConditionsArgs'],
                 naming_pattern: pulumi.Input[str],
                 enabled: Optional[pulumi.Input[bool]] = None,
                 management_zones: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 placeholders: Optional[pulumi.Input['RequestNamingPlaceholdersArgs']] = None,
                 unknowns: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a RequestNaming resource.
        :param pulumi.Input['RequestNamingConditionsArgs'] conditions: The set of conditions for the request naming rule usage. You can specify several conditions. The request has to match
               **all** the specified conditions for the rule to trigger
        :param pulumi.Input[str] naming_pattern: The name to be assigned to matching requests
        :param pulumi.Input[bool] enabled: The rule is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[Sequence[pulumi.Input[str]]] management_zones: Specifies the management zones for which this rule should be applied
        :param pulumi.Input['RequestNamingPlaceholdersArgs'] placeholders: The list of custom placeholders to be used in the naming pattern. It enables you to extract a request attribute value or
               other request attribute and use it in the request naming pattern.
        :param pulumi.Input[str] unknowns: allows for configuring properties that are not explicitly supported by the current version of this provider
        """
        pulumi.set(__self__, "conditions", conditions)
        pulumi.set(__self__, "naming_pattern", naming_pattern)
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)
        if management_zones is not None:
            pulumi.set(__self__, "management_zones", management_zones)
        if placeholders is not None:
            pulumi.set(__self__, "placeholders", placeholders)
        if unknowns is not None:
            pulumi.set(__self__, "unknowns", unknowns)

    @property
    @pulumi.getter
    def conditions(self) -> pulumi.Input['RequestNamingConditionsArgs']:
        """
        The set of conditions for the request naming rule usage. You can specify several conditions. The request has to match
        **all** the specified conditions for the rule to trigger
        """
        return pulumi.get(self, "conditions")

    @conditions.setter
    def conditions(self, value: pulumi.Input['RequestNamingConditionsArgs']):
        pulumi.set(self, "conditions", value)

    @property
    @pulumi.getter(name="namingPattern")
    def naming_pattern(self) -> pulumi.Input[str]:
        """
        The name to be assigned to matching requests
        """
        return pulumi.get(self, "naming_pattern")

    @naming_pattern.setter
    def naming_pattern(self, value: pulumi.Input[str]):
        pulumi.set(self, "naming_pattern", value)

    @property
    @pulumi.getter
    def enabled(self) -> Optional[pulumi.Input[bool]]:
        """
        The rule is enabled (`true`) or disabled (`false`)
        """
        return pulumi.get(self, "enabled")

    @enabled.setter
    def enabled(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enabled", value)

    @property
    @pulumi.getter(name="managementZones")
    def management_zones(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Specifies the management zones for which this rule should be applied
        """
        return pulumi.get(self, "management_zones")

    @management_zones.setter
    def management_zones(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "management_zones", value)

    @property
    @pulumi.getter
    def placeholders(self) -> Optional[pulumi.Input['RequestNamingPlaceholdersArgs']]:
        """
        The list of custom placeholders to be used in the naming pattern. It enables you to extract a request attribute value or
        other request attribute and use it in the request naming pattern.
        """
        return pulumi.get(self, "placeholders")

    @placeholders.setter
    def placeholders(self, value: Optional[pulumi.Input['RequestNamingPlaceholdersArgs']]):
        pulumi.set(self, "placeholders", value)

    @property
    @pulumi.getter
    def unknowns(self) -> Optional[pulumi.Input[str]]:
        """
        allows for configuring properties that are not explicitly supported by the current version of this provider
        """
        return pulumi.get(self, "unknowns")

    @unknowns.setter
    def unknowns(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "unknowns", value)


@pulumi.input_type
class _RequestNamingState:
    def __init__(__self__, *,
                 conditions: Optional[pulumi.Input['RequestNamingConditionsArgs']] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 management_zones: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 naming_pattern: Optional[pulumi.Input[str]] = None,
                 placeholders: Optional[pulumi.Input['RequestNamingPlaceholdersArgs']] = None,
                 unknowns: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering RequestNaming resources.
        :param pulumi.Input['RequestNamingConditionsArgs'] conditions: The set of conditions for the request naming rule usage. You can specify several conditions. The request has to match
               **all** the specified conditions for the rule to trigger
        :param pulumi.Input[bool] enabled: The rule is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[Sequence[pulumi.Input[str]]] management_zones: Specifies the management zones for which this rule should be applied
        :param pulumi.Input[str] naming_pattern: The name to be assigned to matching requests
        :param pulumi.Input['RequestNamingPlaceholdersArgs'] placeholders: The list of custom placeholders to be used in the naming pattern. It enables you to extract a request attribute value or
               other request attribute and use it in the request naming pattern.
        :param pulumi.Input[str] unknowns: allows for configuring properties that are not explicitly supported by the current version of this provider
        """
        if conditions is not None:
            pulumi.set(__self__, "conditions", conditions)
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)
        if management_zones is not None:
            pulumi.set(__self__, "management_zones", management_zones)
        if naming_pattern is not None:
            pulumi.set(__self__, "naming_pattern", naming_pattern)
        if placeholders is not None:
            pulumi.set(__self__, "placeholders", placeholders)
        if unknowns is not None:
            pulumi.set(__self__, "unknowns", unknowns)

    @property
    @pulumi.getter
    def conditions(self) -> Optional[pulumi.Input['RequestNamingConditionsArgs']]:
        """
        The set of conditions for the request naming rule usage. You can specify several conditions. The request has to match
        **all** the specified conditions for the rule to trigger
        """
        return pulumi.get(self, "conditions")

    @conditions.setter
    def conditions(self, value: Optional[pulumi.Input['RequestNamingConditionsArgs']]):
        pulumi.set(self, "conditions", value)

    @property
    @pulumi.getter
    def enabled(self) -> Optional[pulumi.Input[bool]]:
        """
        The rule is enabled (`true`) or disabled (`false`)
        """
        return pulumi.get(self, "enabled")

    @enabled.setter
    def enabled(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enabled", value)

    @property
    @pulumi.getter(name="managementZones")
    def management_zones(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Specifies the management zones for which this rule should be applied
        """
        return pulumi.get(self, "management_zones")

    @management_zones.setter
    def management_zones(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "management_zones", value)

    @property
    @pulumi.getter(name="namingPattern")
    def naming_pattern(self) -> Optional[pulumi.Input[str]]:
        """
        The name to be assigned to matching requests
        """
        return pulumi.get(self, "naming_pattern")

    @naming_pattern.setter
    def naming_pattern(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "naming_pattern", value)

    @property
    @pulumi.getter
    def placeholders(self) -> Optional[pulumi.Input['RequestNamingPlaceholdersArgs']]:
        """
        The list of custom placeholders to be used in the naming pattern. It enables you to extract a request attribute value or
        other request attribute and use it in the request naming pattern.
        """
        return pulumi.get(self, "placeholders")

    @placeholders.setter
    def placeholders(self, value: Optional[pulumi.Input['RequestNamingPlaceholdersArgs']]):
        pulumi.set(self, "placeholders", value)

    @property
    @pulumi.getter
    def unknowns(self) -> Optional[pulumi.Input[str]]:
        """
        allows for configuring properties that are not explicitly supported by the current version of this provider
        """
        return pulumi.get(self, "unknowns")

    @unknowns.setter
    def unknowns(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "unknowns", value)


class RequestNaming(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 conditions: Optional[pulumi.Input[pulumi.InputType['RequestNamingConditionsArgs']]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 management_zones: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 naming_pattern: Optional[pulumi.Input[str]] = None,
                 placeholders: Optional[pulumi.Input[pulumi.InputType['RequestNamingPlaceholdersArgs']]] = None,
                 unknowns: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a RequestNaming resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['RequestNamingConditionsArgs']] conditions: The set of conditions for the request naming rule usage. You can specify several conditions. The request has to match
               **all** the specified conditions for the rule to trigger
        :param pulumi.Input[bool] enabled: The rule is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[Sequence[pulumi.Input[str]]] management_zones: Specifies the management zones for which this rule should be applied
        :param pulumi.Input[str] naming_pattern: The name to be assigned to matching requests
        :param pulumi.Input[pulumi.InputType['RequestNamingPlaceholdersArgs']] placeholders: The list of custom placeholders to be used in the naming pattern. It enables you to extract a request attribute value or
               other request attribute and use it in the request naming pattern.
        :param pulumi.Input[str] unknowns: allows for configuring properties that are not explicitly supported by the current version of this provider
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: RequestNamingArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a RequestNaming resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param RequestNamingArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(RequestNamingArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 conditions: Optional[pulumi.Input[pulumi.InputType['RequestNamingConditionsArgs']]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 management_zones: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 naming_pattern: Optional[pulumi.Input[str]] = None,
                 placeholders: Optional[pulumi.Input[pulumi.InputType['RequestNamingPlaceholdersArgs']]] = None,
                 unknowns: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = RequestNamingArgs.__new__(RequestNamingArgs)

            if conditions is None and not opts.urn:
                raise TypeError("Missing required property 'conditions'")
            __props__.__dict__["conditions"] = conditions
            __props__.__dict__["enabled"] = enabled
            __props__.__dict__["management_zones"] = management_zones
            if naming_pattern is None and not opts.urn:
                raise TypeError("Missing required property 'naming_pattern'")
            __props__.__dict__["naming_pattern"] = naming_pattern
            __props__.__dict__["placeholders"] = placeholders
            __props__.__dict__["unknowns"] = unknowns
        super(RequestNaming, __self__).__init__(
            'dynatrace:index/requestNaming:RequestNaming',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            conditions: Optional[pulumi.Input[pulumi.InputType['RequestNamingConditionsArgs']]] = None,
            enabled: Optional[pulumi.Input[bool]] = None,
            management_zones: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            naming_pattern: Optional[pulumi.Input[str]] = None,
            placeholders: Optional[pulumi.Input[pulumi.InputType['RequestNamingPlaceholdersArgs']]] = None,
            unknowns: Optional[pulumi.Input[str]] = None) -> 'RequestNaming':
        """
        Get an existing RequestNaming resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['RequestNamingConditionsArgs']] conditions: The set of conditions for the request naming rule usage. You can specify several conditions. The request has to match
               **all** the specified conditions for the rule to trigger
        :param pulumi.Input[bool] enabled: The rule is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[Sequence[pulumi.Input[str]]] management_zones: Specifies the management zones for which this rule should be applied
        :param pulumi.Input[str] naming_pattern: The name to be assigned to matching requests
        :param pulumi.Input[pulumi.InputType['RequestNamingPlaceholdersArgs']] placeholders: The list of custom placeholders to be used in the naming pattern. It enables you to extract a request attribute value or
               other request attribute and use it in the request naming pattern.
        :param pulumi.Input[str] unknowns: allows for configuring properties that are not explicitly supported by the current version of this provider
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _RequestNamingState.__new__(_RequestNamingState)

        __props__.__dict__["conditions"] = conditions
        __props__.__dict__["enabled"] = enabled
        __props__.__dict__["management_zones"] = management_zones
        __props__.__dict__["naming_pattern"] = naming_pattern
        __props__.__dict__["placeholders"] = placeholders
        __props__.__dict__["unknowns"] = unknowns
        return RequestNaming(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def conditions(self) -> pulumi.Output['outputs.RequestNamingConditions']:
        """
        The set of conditions for the request naming rule usage. You can specify several conditions. The request has to match
        **all** the specified conditions for the rule to trigger
        """
        return pulumi.get(self, "conditions")

    @property
    @pulumi.getter
    def enabled(self) -> pulumi.Output[Optional[bool]]:
        """
        The rule is enabled (`true`) or disabled (`false`)
        """
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter(name="managementZones")
    def management_zones(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        Specifies the management zones for which this rule should be applied
        """
        return pulumi.get(self, "management_zones")

    @property
    @pulumi.getter(name="namingPattern")
    def naming_pattern(self) -> pulumi.Output[str]:
        """
        The name to be assigned to matching requests
        """
        return pulumi.get(self, "naming_pattern")

    @property
    @pulumi.getter
    def placeholders(self) -> pulumi.Output[Optional['outputs.RequestNamingPlaceholders']]:
        """
        The list of custom placeholders to be used in the naming pattern. It enables you to extract a request attribute value or
        other request attribute and use it in the request naming pattern.
        """
        return pulumi.get(self, "placeholders")

    @property
    @pulumi.getter
    def unknowns(self) -> pulumi.Output[Optional[str]]:
        """
        allows for configuring properties that are not explicitly supported by the current version of this provider
        """
        return pulumi.get(self, "unknowns")

