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

__all__ = ['GenericTypesArgs', 'GenericTypes']

@pulumi.input_type
class GenericTypesArgs:
    def __init__(__self__, *,
                 created_by: pulumi.Input[str],
                 display_name: pulumi.Input[str],
                 enabled: pulumi.Input[bool],
                 rules: pulumi.Input['GenericTypesRulesArgs'],
                 insert_after: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a GenericTypes resource.
        :param pulumi.Input[str] created_by: The user or extension that created this type.
        :param pulumi.Input[str] display_name: The human readable attribute name for this extraction rule. Leave blank to use the key as the display name.
        :param pulumi.Input[bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input['GenericTypesRulesArgs'] rules: Specify a list of rules which are evaluated in order. When **any** rule matches, the entity defined according to that rule will be extracted. Subsequent rules will not be evaluated.
        :param pulumi.Input[str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        :param pulumi.Input[str] name: The entity type name. This type name must be unique and must not be changed after creation.
        """
        pulumi.set(__self__, "created_by", created_by)
        pulumi.set(__self__, "display_name", display_name)
        pulumi.set(__self__, "enabled", enabled)
        pulumi.set(__self__, "rules", rules)
        if insert_after is not None:
            pulumi.set(__self__, "insert_after", insert_after)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter(name="createdBy")
    def created_by(self) -> pulumi.Input[str]:
        """
        The user or extension that created this type.
        """
        return pulumi.get(self, "created_by")

    @created_by.setter
    def created_by(self, value: pulumi.Input[str]):
        pulumi.set(self, "created_by", value)

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> pulumi.Input[str]:
        """
        The human readable attribute name for this extraction rule. Leave blank to use the key as the display name.
        """
        return pulumi.get(self, "display_name")

    @display_name.setter
    def display_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "display_name", value)

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
    def rules(self) -> pulumi.Input['GenericTypesRulesArgs']:
        """
        Specify a list of rules which are evaluated in order. When **any** rule matches, the entity defined according to that rule will be extracted. Subsequent rules will not be evaluated.
        """
        return pulumi.get(self, "rules")

    @rules.setter
    def rules(self, value: pulumi.Input['GenericTypesRulesArgs']):
        pulumi.set(self, "rules", value)

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
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        The entity type name. This type name must be unique and must not be changed after creation.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)


@pulumi.input_type
class _GenericTypesState:
    def __init__(__self__, *,
                 created_by: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 insert_after: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 rules: Optional[pulumi.Input['GenericTypesRulesArgs']] = None):
        """
        Input properties used for looking up and filtering GenericTypes resources.
        :param pulumi.Input[str] created_by: The user or extension that created this type.
        :param pulumi.Input[str] display_name: The human readable attribute name for this extraction rule. Leave blank to use the key as the display name.
        :param pulumi.Input[bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        :param pulumi.Input[str] name: The entity type name. This type name must be unique and must not be changed after creation.
        :param pulumi.Input['GenericTypesRulesArgs'] rules: Specify a list of rules which are evaluated in order. When **any** rule matches, the entity defined according to that rule will be extracted. Subsequent rules will not be evaluated.
        """
        if created_by is not None:
            pulumi.set(__self__, "created_by", created_by)
        if display_name is not None:
            pulumi.set(__self__, "display_name", display_name)
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)
        if insert_after is not None:
            pulumi.set(__self__, "insert_after", insert_after)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if rules is not None:
            pulumi.set(__self__, "rules", rules)

    @property
    @pulumi.getter(name="createdBy")
    def created_by(self) -> Optional[pulumi.Input[str]]:
        """
        The user or extension that created this type.
        """
        return pulumi.get(self, "created_by")

    @created_by.setter
    def created_by(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "created_by", value)

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> Optional[pulumi.Input[str]]:
        """
        The human readable attribute name for this extraction rule. Leave blank to use the key as the display name.
        """
        return pulumi.get(self, "display_name")

    @display_name.setter
    def display_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "display_name", value)

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
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        The entity type name. This type name must be unique and must not be changed after creation.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def rules(self) -> Optional[pulumi.Input['GenericTypesRulesArgs']]:
        """
        Specify a list of rules which are evaluated in order. When **any** rule matches, the entity defined according to that rule will be extracted. Subsequent rules will not be evaluated.
        """
        return pulumi.get(self, "rules")

    @rules.setter
    def rules(self, value: Optional[pulumi.Input['GenericTypesRulesArgs']]):
        pulumi.set(self, "rules", value)


class GenericTypes(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 created_by: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 insert_after: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 rules: Optional[pulumi.Input[pulumi.InputType['GenericTypesRulesArgs']]] = None,
                 __props__=None):
        """
        Create a GenericTypes resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] created_by: The user or extension that created this type.
        :param pulumi.Input[str] display_name: The human readable attribute name for this extraction rule. Leave blank to use the key as the display name.
        :param pulumi.Input[bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        :param pulumi.Input[str] name: The entity type name. This type name must be unique and must not be changed after creation.
        :param pulumi.Input[pulumi.InputType['GenericTypesRulesArgs']] rules: Specify a list of rules which are evaluated in order. When **any** rule matches, the entity defined according to that rule will be extracted. Subsequent rules will not be evaluated.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: GenericTypesArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a GenericTypes resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param GenericTypesArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(GenericTypesArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 created_by: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 insert_after: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 rules: Optional[pulumi.Input[pulumi.InputType['GenericTypesRulesArgs']]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = GenericTypesArgs.__new__(GenericTypesArgs)

            if created_by is None and not opts.urn:
                raise TypeError("Missing required property 'created_by'")
            __props__.__dict__["created_by"] = created_by
            if display_name is None and not opts.urn:
                raise TypeError("Missing required property 'display_name'")
            __props__.__dict__["display_name"] = display_name
            if enabled is None and not opts.urn:
                raise TypeError("Missing required property 'enabled'")
            __props__.__dict__["enabled"] = enabled
            __props__.__dict__["insert_after"] = insert_after
            __props__.__dict__["name"] = name
            if rules is None and not opts.urn:
                raise TypeError("Missing required property 'rules'")
            __props__.__dict__["rules"] = rules
        super(GenericTypes, __self__).__init__(
            'dynatrace:index/genericTypes:GenericTypes',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            created_by: Optional[pulumi.Input[str]] = None,
            display_name: Optional[pulumi.Input[str]] = None,
            enabled: Optional[pulumi.Input[bool]] = None,
            insert_after: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            rules: Optional[pulumi.Input[pulumi.InputType['GenericTypesRulesArgs']]] = None) -> 'GenericTypes':
        """
        Get an existing GenericTypes resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] created_by: The user or extension that created this type.
        :param pulumi.Input[str] display_name: The human readable attribute name for this extraction rule. Leave blank to use the key as the display name.
        :param pulumi.Input[bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        :param pulumi.Input[str] name: The entity type name. This type name must be unique and must not be changed after creation.
        :param pulumi.Input[pulumi.InputType['GenericTypesRulesArgs']] rules: Specify a list of rules which are evaluated in order. When **any** rule matches, the entity defined according to that rule will be extracted. Subsequent rules will not be evaluated.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _GenericTypesState.__new__(_GenericTypesState)

        __props__.__dict__["created_by"] = created_by
        __props__.__dict__["display_name"] = display_name
        __props__.__dict__["enabled"] = enabled
        __props__.__dict__["insert_after"] = insert_after
        __props__.__dict__["name"] = name
        __props__.__dict__["rules"] = rules
        return GenericTypes(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="createdBy")
    def created_by(self) -> pulumi.Output[str]:
        """
        The user or extension that created this type.
        """
        return pulumi.get(self, "created_by")

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> pulumi.Output[str]:
        """
        The human readable attribute name for this extraction rule. Leave blank to use the key as the display name.
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter
    def enabled(self) -> pulumi.Output[bool]:
        """
        This setting is enabled (`true`) or disabled (`false`)
        """
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter(name="insertAfter")
    def insert_after(self) -> pulumi.Output[str]:
        """
        Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        """
        return pulumi.get(self, "insert_after")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The entity type name. This type name must be unique and must not be changed after creation.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def rules(self) -> pulumi.Output['outputs.GenericTypesRules']:
        """
        Specify a list of rules which are evaluated in order. When **any** rule matches, the entity defined according to that rule will be extracted. Subsequent rules will not be evaluated.
        """
        return pulumi.get(self, "rules")

