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

__all__ = ['GenericRelationshipsArgs', 'GenericRelationships']

@pulumi.input_type
class GenericRelationshipsArgs:
    def __init__(__self__, *,
                 created_by: pulumi.Input[str],
                 enabled: pulumi.Input[bool],
                 from_type: pulumi.Input[str],
                 sources: pulumi.Input['GenericRelationshipsSourcesArgs'],
                 to_type: pulumi.Input[str],
                 type_of_relation: pulumi.Input[str],
                 from_role: Optional[pulumi.Input[str]] = None,
                 to_role: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a GenericRelationships resource.
        :param pulumi.Input[str] created_by: The user or extension that created this relationship.
        :param pulumi.Input[bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[str] from_type: Define an entity type as the source of the relationship.
        :param pulumi.Input['GenericRelationshipsSourcesArgs'] sources: Specify all sources which should be evaluated for this relationship rule. The relationship is only created when any of the filters match.
        :param pulumi.Input[str] to_type: Define an entity type as the destination of the relationship. You can choose the same type as the source type. In this case you also may assign different roles for source and destination for having directed relationships.
        :param pulumi.Input[str] type_of_relation: Possible Values: `CALLS`, `CHILD_OF`, `INSTANCE_OF`, `PART_OF`, `RUNS_ON`, `SAME_AS`
        :param pulumi.Input[str] from_role: Specify a role for the source entity. If both source and destination type are the same, referring different roles will allow identification of a relationships direction. If role is left blank, any role of the source type is considered for the relationship.
        :param pulumi.Input[str] to_role: Specify a role for the destination entity. If both source and destination type are the same, referring different roles will allow identification of a relationships direction. If role is left blank, any role of the destination type is considered for the relationship.
        """
        pulumi.set(__self__, "created_by", created_by)
        pulumi.set(__self__, "enabled", enabled)
        pulumi.set(__self__, "from_type", from_type)
        pulumi.set(__self__, "sources", sources)
        pulumi.set(__self__, "to_type", to_type)
        pulumi.set(__self__, "type_of_relation", type_of_relation)
        if from_role is not None:
            pulumi.set(__self__, "from_role", from_role)
        if to_role is not None:
            pulumi.set(__self__, "to_role", to_role)

    @property
    @pulumi.getter(name="createdBy")
    def created_by(self) -> pulumi.Input[str]:
        """
        The user or extension that created this relationship.
        """
        return pulumi.get(self, "created_by")

    @created_by.setter
    def created_by(self, value: pulumi.Input[str]):
        pulumi.set(self, "created_by", value)

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
    @pulumi.getter(name="fromType")
    def from_type(self) -> pulumi.Input[str]:
        """
        Define an entity type as the source of the relationship.
        """
        return pulumi.get(self, "from_type")

    @from_type.setter
    def from_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "from_type", value)

    @property
    @pulumi.getter
    def sources(self) -> pulumi.Input['GenericRelationshipsSourcesArgs']:
        """
        Specify all sources which should be evaluated for this relationship rule. The relationship is only created when any of the filters match.
        """
        return pulumi.get(self, "sources")

    @sources.setter
    def sources(self, value: pulumi.Input['GenericRelationshipsSourcesArgs']):
        pulumi.set(self, "sources", value)

    @property
    @pulumi.getter(name="toType")
    def to_type(self) -> pulumi.Input[str]:
        """
        Define an entity type as the destination of the relationship. You can choose the same type as the source type. In this case you also may assign different roles for source and destination for having directed relationships.
        """
        return pulumi.get(self, "to_type")

    @to_type.setter
    def to_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "to_type", value)

    @property
    @pulumi.getter(name="typeOfRelation")
    def type_of_relation(self) -> pulumi.Input[str]:
        """
        Possible Values: `CALLS`, `CHILD_OF`, `INSTANCE_OF`, `PART_OF`, `RUNS_ON`, `SAME_AS`
        """
        return pulumi.get(self, "type_of_relation")

    @type_of_relation.setter
    def type_of_relation(self, value: pulumi.Input[str]):
        pulumi.set(self, "type_of_relation", value)

    @property
    @pulumi.getter(name="fromRole")
    def from_role(self) -> Optional[pulumi.Input[str]]:
        """
        Specify a role for the source entity. If both source and destination type are the same, referring different roles will allow identification of a relationships direction. If role is left blank, any role of the source type is considered for the relationship.
        """
        return pulumi.get(self, "from_role")

    @from_role.setter
    def from_role(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "from_role", value)

    @property
    @pulumi.getter(name="toRole")
    def to_role(self) -> Optional[pulumi.Input[str]]:
        """
        Specify a role for the destination entity. If both source and destination type are the same, referring different roles will allow identification of a relationships direction. If role is left blank, any role of the destination type is considered for the relationship.
        """
        return pulumi.get(self, "to_role")

    @to_role.setter
    def to_role(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "to_role", value)


@pulumi.input_type
class _GenericRelationshipsState:
    def __init__(__self__, *,
                 created_by: Optional[pulumi.Input[str]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 from_role: Optional[pulumi.Input[str]] = None,
                 from_type: Optional[pulumi.Input[str]] = None,
                 sources: Optional[pulumi.Input['GenericRelationshipsSourcesArgs']] = None,
                 to_role: Optional[pulumi.Input[str]] = None,
                 to_type: Optional[pulumi.Input[str]] = None,
                 type_of_relation: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering GenericRelationships resources.
        :param pulumi.Input[str] created_by: The user or extension that created this relationship.
        :param pulumi.Input[bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[str] from_role: Specify a role for the source entity. If both source and destination type are the same, referring different roles will allow identification of a relationships direction. If role is left blank, any role of the source type is considered for the relationship.
        :param pulumi.Input[str] from_type: Define an entity type as the source of the relationship.
        :param pulumi.Input['GenericRelationshipsSourcesArgs'] sources: Specify all sources which should be evaluated for this relationship rule. The relationship is only created when any of the filters match.
        :param pulumi.Input[str] to_role: Specify a role for the destination entity. If both source and destination type are the same, referring different roles will allow identification of a relationships direction. If role is left blank, any role of the destination type is considered for the relationship.
        :param pulumi.Input[str] to_type: Define an entity type as the destination of the relationship. You can choose the same type as the source type. In this case you also may assign different roles for source and destination for having directed relationships.
        :param pulumi.Input[str] type_of_relation: Possible Values: `CALLS`, `CHILD_OF`, `INSTANCE_OF`, `PART_OF`, `RUNS_ON`, `SAME_AS`
        """
        if created_by is not None:
            pulumi.set(__self__, "created_by", created_by)
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)
        if from_role is not None:
            pulumi.set(__self__, "from_role", from_role)
        if from_type is not None:
            pulumi.set(__self__, "from_type", from_type)
        if sources is not None:
            pulumi.set(__self__, "sources", sources)
        if to_role is not None:
            pulumi.set(__self__, "to_role", to_role)
        if to_type is not None:
            pulumi.set(__self__, "to_type", to_type)
        if type_of_relation is not None:
            pulumi.set(__self__, "type_of_relation", type_of_relation)

    @property
    @pulumi.getter(name="createdBy")
    def created_by(self) -> Optional[pulumi.Input[str]]:
        """
        The user or extension that created this relationship.
        """
        return pulumi.get(self, "created_by")

    @created_by.setter
    def created_by(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "created_by", value)

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
    @pulumi.getter(name="fromRole")
    def from_role(self) -> Optional[pulumi.Input[str]]:
        """
        Specify a role for the source entity. If both source and destination type are the same, referring different roles will allow identification of a relationships direction. If role is left blank, any role of the source type is considered for the relationship.
        """
        return pulumi.get(self, "from_role")

    @from_role.setter
    def from_role(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "from_role", value)

    @property
    @pulumi.getter(name="fromType")
    def from_type(self) -> Optional[pulumi.Input[str]]:
        """
        Define an entity type as the source of the relationship.
        """
        return pulumi.get(self, "from_type")

    @from_type.setter
    def from_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "from_type", value)

    @property
    @pulumi.getter
    def sources(self) -> Optional[pulumi.Input['GenericRelationshipsSourcesArgs']]:
        """
        Specify all sources which should be evaluated for this relationship rule. The relationship is only created when any of the filters match.
        """
        return pulumi.get(self, "sources")

    @sources.setter
    def sources(self, value: Optional[pulumi.Input['GenericRelationshipsSourcesArgs']]):
        pulumi.set(self, "sources", value)

    @property
    @pulumi.getter(name="toRole")
    def to_role(self) -> Optional[pulumi.Input[str]]:
        """
        Specify a role for the destination entity. If both source and destination type are the same, referring different roles will allow identification of a relationships direction. If role is left blank, any role of the destination type is considered for the relationship.
        """
        return pulumi.get(self, "to_role")

    @to_role.setter
    def to_role(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "to_role", value)

    @property
    @pulumi.getter(name="toType")
    def to_type(self) -> Optional[pulumi.Input[str]]:
        """
        Define an entity type as the destination of the relationship. You can choose the same type as the source type. In this case you also may assign different roles for source and destination for having directed relationships.
        """
        return pulumi.get(self, "to_type")

    @to_type.setter
    def to_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "to_type", value)

    @property
    @pulumi.getter(name="typeOfRelation")
    def type_of_relation(self) -> Optional[pulumi.Input[str]]:
        """
        Possible Values: `CALLS`, `CHILD_OF`, `INSTANCE_OF`, `PART_OF`, `RUNS_ON`, `SAME_AS`
        """
        return pulumi.get(self, "type_of_relation")

    @type_of_relation.setter
    def type_of_relation(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "type_of_relation", value)


class GenericRelationships(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 created_by: Optional[pulumi.Input[str]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 from_role: Optional[pulumi.Input[str]] = None,
                 from_type: Optional[pulumi.Input[str]] = None,
                 sources: Optional[pulumi.Input[pulumi.InputType['GenericRelationshipsSourcesArgs']]] = None,
                 to_role: Optional[pulumi.Input[str]] = None,
                 to_type: Optional[pulumi.Input[str]] = None,
                 type_of_relation: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a GenericRelationships resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] created_by: The user or extension that created this relationship.
        :param pulumi.Input[bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[str] from_role: Specify a role for the source entity. If both source and destination type are the same, referring different roles will allow identification of a relationships direction. If role is left blank, any role of the source type is considered for the relationship.
        :param pulumi.Input[str] from_type: Define an entity type as the source of the relationship.
        :param pulumi.Input[pulumi.InputType['GenericRelationshipsSourcesArgs']] sources: Specify all sources which should be evaluated for this relationship rule. The relationship is only created when any of the filters match.
        :param pulumi.Input[str] to_role: Specify a role for the destination entity. If both source and destination type are the same, referring different roles will allow identification of a relationships direction. If role is left blank, any role of the destination type is considered for the relationship.
        :param pulumi.Input[str] to_type: Define an entity type as the destination of the relationship. You can choose the same type as the source type. In this case you also may assign different roles for source and destination for having directed relationships.
        :param pulumi.Input[str] type_of_relation: Possible Values: `CALLS`, `CHILD_OF`, `INSTANCE_OF`, `PART_OF`, `RUNS_ON`, `SAME_AS`
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: GenericRelationshipsArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a GenericRelationships resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param GenericRelationshipsArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(GenericRelationshipsArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 created_by: Optional[pulumi.Input[str]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 from_role: Optional[pulumi.Input[str]] = None,
                 from_type: Optional[pulumi.Input[str]] = None,
                 sources: Optional[pulumi.Input[pulumi.InputType['GenericRelationshipsSourcesArgs']]] = None,
                 to_role: Optional[pulumi.Input[str]] = None,
                 to_type: Optional[pulumi.Input[str]] = None,
                 type_of_relation: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = GenericRelationshipsArgs.__new__(GenericRelationshipsArgs)

            if created_by is None and not opts.urn:
                raise TypeError("Missing required property 'created_by'")
            __props__.__dict__["created_by"] = created_by
            if enabled is None and not opts.urn:
                raise TypeError("Missing required property 'enabled'")
            __props__.__dict__["enabled"] = enabled
            __props__.__dict__["from_role"] = from_role
            if from_type is None and not opts.urn:
                raise TypeError("Missing required property 'from_type'")
            __props__.__dict__["from_type"] = from_type
            if sources is None and not opts.urn:
                raise TypeError("Missing required property 'sources'")
            __props__.__dict__["sources"] = sources
            __props__.__dict__["to_role"] = to_role
            if to_type is None and not opts.urn:
                raise TypeError("Missing required property 'to_type'")
            __props__.__dict__["to_type"] = to_type
            if type_of_relation is None and not opts.urn:
                raise TypeError("Missing required property 'type_of_relation'")
            __props__.__dict__["type_of_relation"] = type_of_relation
        super(GenericRelationships, __self__).__init__(
            'dynatrace:index/genericRelationships:GenericRelationships',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            created_by: Optional[pulumi.Input[str]] = None,
            enabled: Optional[pulumi.Input[bool]] = None,
            from_role: Optional[pulumi.Input[str]] = None,
            from_type: Optional[pulumi.Input[str]] = None,
            sources: Optional[pulumi.Input[pulumi.InputType['GenericRelationshipsSourcesArgs']]] = None,
            to_role: Optional[pulumi.Input[str]] = None,
            to_type: Optional[pulumi.Input[str]] = None,
            type_of_relation: Optional[pulumi.Input[str]] = None) -> 'GenericRelationships':
        """
        Get an existing GenericRelationships resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] created_by: The user or extension that created this relationship.
        :param pulumi.Input[bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[str] from_role: Specify a role for the source entity. If both source and destination type are the same, referring different roles will allow identification of a relationships direction. If role is left blank, any role of the source type is considered for the relationship.
        :param pulumi.Input[str] from_type: Define an entity type as the source of the relationship.
        :param pulumi.Input[pulumi.InputType['GenericRelationshipsSourcesArgs']] sources: Specify all sources which should be evaluated for this relationship rule. The relationship is only created when any of the filters match.
        :param pulumi.Input[str] to_role: Specify a role for the destination entity. If both source and destination type are the same, referring different roles will allow identification of a relationships direction. If role is left blank, any role of the destination type is considered for the relationship.
        :param pulumi.Input[str] to_type: Define an entity type as the destination of the relationship. You can choose the same type as the source type. In this case you also may assign different roles for source and destination for having directed relationships.
        :param pulumi.Input[str] type_of_relation: Possible Values: `CALLS`, `CHILD_OF`, `INSTANCE_OF`, `PART_OF`, `RUNS_ON`, `SAME_AS`
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _GenericRelationshipsState.__new__(_GenericRelationshipsState)

        __props__.__dict__["created_by"] = created_by
        __props__.__dict__["enabled"] = enabled
        __props__.__dict__["from_role"] = from_role
        __props__.__dict__["from_type"] = from_type
        __props__.__dict__["sources"] = sources
        __props__.__dict__["to_role"] = to_role
        __props__.__dict__["to_type"] = to_type
        __props__.__dict__["type_of_relation"] = type_of_relation
        return GenericRelationships(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="createdBy")
    def created_by(self) -> pulumi.Output[str]:
        """
        The user or extension that created this relationship.
        """
        return pulumi.get(self, "created_by")

    @property
    @pulumi.getter
    def enabled(self) -> pulumi.Output[bool]:
        """
        This setting is enabled (`true`) or disabled (`false`)
        """
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter(name="fromRole")
    def from_role(self) -> pulumi.Output[Optional[str]]:
        """
        Specify a role for the source entity. If both source and destination type are the same, referring different roles will allow identification of a relationships direction. If role is left blank, any role of the source type is considered for the relationship.
        """
        return pulumi.get(self, "from_role")

    @property
    @pulumi.getter(name="fromType")
    def from_type(self) -> pulumi.Output[str]:
        """
        Define an entity type as the source of the relationship.
        """
        return pulumi.get(self, "from_type")

    @property
    @pulumi.getter
    def sources(self) -> pulumi.Output['outputs.GenericRelationshipsSources']:
        """
        Specify all sources which should be evaluated for this relationship rule. The relationship is only created when any of the filters match.
        """
        return pulumi.get(self, "sources")

    @property
    @pulumi.getter(name="toRole")
    def to_role(self) -> pulumi.Output[Optional[str]]:
        """
        Specify a role for the destination entity. If both source and destination type are the same, referring different roles will allow identification of a relationships direction. If role is left blank, any role of the destination type is considered for the relationship.
        """
        return pulumi.get(self, "to_role")

    @property
    @pulumi.getter(name="toType")
    def to_type(self) -> pulumi.Output[str]:
        """
        Define an entity type as the destination of the relationship. You can choose the same type as the source type. In this case you also may assign different roles for source and destination for having directed relationships.
        """
        return pulumi.get(self, "to_type")

    @property
    @pulumi.getter(name="typeOfRelation")
    def type_of_relation(self) -> pulumi.Output[str]:
        """
        Possible Values: `CALLS`, `CHILD_OF`, `INSTANCE_OF`, `PART_OF`, `RUNS_ON`, `SAME_AS`
        """
        return pulumi.get(self, "type_of_relation")
