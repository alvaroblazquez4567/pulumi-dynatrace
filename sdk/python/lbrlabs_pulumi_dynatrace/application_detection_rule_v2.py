# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['ApplicationDetectionRuleV2Args', 'ApplicationDetectionRuleV2']

@pulumi.input_type
class ApplicationDetectionRuleV2Args:
    def __init__(__self__, *,
                 application_id: pulumi.Input[str],
                 matcher: pulumi.Input[str],
                 pattern: pulumi.Input[str],
                 description: Optional[pulumi.Input[str]] = None,
                 insert_after: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a ApplicationDetectionRuleV2 resource.
        :param pulumi.Input[str] application_id: Select an existing application or create a new one.
        :param pulumi.Input[str] matcher: Possible Values: `DOMAIN_CONTAINS`, `DOMAIN_ENDS_WITH`, `DOMAIN_EQUALS`, `DOMAIN_MATCHES`, `DOMAIN_STARTS_WITH`, `URL_CONTAINS`, `URL_ENDS_WITH`, `URL_EQUALS`, `URL_STARTS_WITH`
        :param pulumi.Input[str] pattern: Pattern
        :param pulumi.Input[str] description: (v1.274) Add a description for your rule
        :param pulumi.Input[str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        """
        pulumi.set(__self__, "application_id", application_id)
        pulumi.set(__self__, "matcher", matcher)
        pulumi.set(__self__, "pattern", pattern)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if insert_after is not None:
            pulumi.set(__self__, "insert_after", insert_after)

    @property
    @pulumi.getter(name="applicationId")
    def application_id(self) -> pulumi.Input[str]:
        """
        Select an existing application or create a new one.
        """
        return pulumi.get(self, "application_id")

    @application_id.setter
    def application_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "application_id", value)

    @property
    @pulumi.getter
    def matcher(self) -> pulumi.Input[str]:
        """
        Possible Values: `DOMAIN_CONTAINS`, `DOMAIN_ENDS_WITH`, `DOMAIN_EQUALS`, `DOMAIN_MATCHES`, `DOMAIN_STARTS_WITH`, `URL_CONTAINS`, `URL_ENDS_WITH`, `URL_EQUALS`, `URL_STARTS_WITH`
        """
        return pulumi.get(self, "matcher")

    @matcher.setter
    def matcher(self, value: pulumi.Input[str]):
        pulumi.set(self, "matcher", value)

    @property
    @pulumi.getter
    def pattern(self) -> pulumi.Input[str]:
        """
        Pattern
        """
        return pulumi.get(self, "pattern")

    @pattern.setter
    def pattern(self, value: pulumi.Input[str]):
        pulumi.set(self, "pattern", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        (v1.274) Add a description for your rule
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

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
class _ApplicationDetectionRuleV2State:
    def __init__(__self__, *,
                 application_id: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 insert_after: Optional[pulumi.Input[str]] = None,
                 matcher: Optional[pulumi.Input[str]] = None,
                 pattern: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering ApplicationDetectionRuleV2 resources.
        :param pulumi.Input[str] application_id: Select an existing application or create a new one.
        :param pulumi.Input[str] description: (v1.274) Add a description for your rule
        :param pulumi.Input[str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        :param pulumi.Input[str] matcher: Possible Values: `DOMAIN_CONTAINS`, `DOMAIN_ENDS_WITH`, `DOMAIN_EQUALS`, `DOMAIN_MATCHES`, `DOMAIN_STARTS_WITH`, `URL_CONTAINS`, `URL_ENDS_WITH`, `URL_EQUALS`, `URL_STARTS_WITH`
        :param pulumi.Input[str] pattern: Pattern
        """
        if application_id is not None:
            pulumi.set(__self__, "application_id", application_id)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if insert_after is not None:
            pulumi.set(__self__, "insert_after", insert_after)
        if matcher is not None:
            pulumi.set(__self__, "matcher", matcher)
        if pattern is not None:
            pulumi.set(__self__, "pattern", pattern)

    @property
    @pulumi.getter(name="applicationId")
    def application_id(self) -> Optional[pulumi.Input[str]]:
        """
        Select an existing application or create a new one.
        """
        return pulumi.get(self, "application_id")

    @application_id.setter
    def application_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "application_id", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        (v1.274) Add a description for your rule
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

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
    def matcher(self) -> Optional[pulumi.Input[str]]:
        """
        Possible Values: `DOMAIN_CONTAINS`, `DOMAIN_ENDS_WITH`, `DOMAIN_EQUALS`, `DOMAIN_MATCHES`, `DOMAIN_STARTS_WITH`, `URL_CONTAINS`, `URL_ENDS_WITH`, `URL_EQUALS`, `URL_STARTS_WITH`
        """
        return pulumi.get(self, "matcher")

    @matcher.setter
    def matcher(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "matcher", value)

    @property
    @pulumi.getter
    def pattern(self) -> Optional[pulumi.Input[str]]:
        """
        Pattern
        """
        return pulumi.get(self, "pattern")

    @pattern.setter
    def pattern(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "pattern", value)


class ApplicationDetectionRuleV2(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 application_id: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 insert_after: Optional[pulumi.Input[str]] = None,
                 matcher: Optional[pulumi.Input[str]] = None,
                 pattern: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a ApplicationDetectionRuleV2 resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] application_id: Select an existing application or create a new one.
        :param pulumi.Input[str] description: (v1.274) Add a description for your rule
        :param pulumi.Input[str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        :param pulumi.Input[str] matcher: Possible Values: `DOMAIN_CONTAINS`, `DOMAIN_ENDS_WITH`, `DOMAIN_EQUALS`, `DOMAIN_MATCHES`, `DOMAIN_STARTS_WITH`, `URL_CONTAINS`, `URL_ENDS_WITH`, `URL_EQUALS`, `URL_STARTS_WITH`
        :param pulumi.Input[str] pattern: Pattern
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ApplicationDetectionRuleV2Args,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a ApplicationDetectionRuleV2 resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param ApplicationDetectionRuleV2Args args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ApplicationDetectionRuleV2Args, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 application_id: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 insert_after: Optional[pulumi.Input[str]] = None,
                 matcher: Optional[pulumi.Input[str]] = None,
                 pattern: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ApplicationDetectionRuleV2Args.__new__(ApplicationDetectionRuleV2Args)

            if application_id is None and not opts.urn:
                raise TypeError("Missing required property 'application_id'")
            __props__.__dict__["application_id"] = application_id
            __props__.__dict__["description"] = description
            __props__.__dict__["insert_after"] = insert_after
            if matcher is None and not opts.urn:
                raise TypeError("Missing required property 'matcher'")
            __props__.__dict__["matcher"] = matcher
            if pattern is None and not opts.urn:
                raise TypeError("Missing required property 'pattern'")
            __props__.__dict__["pattern"] = pattern
        super(ApplicationDetectionRuleV2, __self__).__init__(
            'dynatrace:index/applicationDetectionRuleV2:ApplicationDetectionRuleV2',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            application_id: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            insert_after: Optional[pulumi.Input[str]] = None,
            matcher: Optional[pulumi.Input[str]] = None,
            pattern: Optional[pulumi.Input[str]] = None) -> 'ApplicationDetectionRuleV2':
        """
        Get an existing ApplicationDetectionRuleV2 resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] application_id: Select an existing application or create a new one.
        :param pulumi.Input[str] description: (v1.274) Add a description for your rule
        :param pulumi.Input[str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        :param pulumi.Input[str] matcher: Possible Values: `DOMAIN_CONTAINS`, `DOMAIN_ENDS_WITH`, `DOMAIN_EQUALS`, `DOMAIN_MATCHES`, `DOMAIN_STARTS_WITH`, `URL_CONTAINS`, `URL_ENDS_WITH`, `URL_EQUALS`, `URL_STARTS_WITH`
        :param pulumi.Input[str] pattern: Pattern
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ApplicationDetectionRuleV2State.__new__(_ApplicationDetectionRuleV2State)

        __props__.__dict__["application_id"] = application_id
        __props__.__dict__["description"] = description
        __props__.__dict__["insert_after"] = insert_after
        __props__.__dict__["matcher"] = matcher
        __props__.__dict__["pattern"] = pattern
        return ApplicationDetectionRuleV2(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="applicationId")
    def application_id(self) -> pulumi.Output[str]:
        """
        Select an existing application or create a new one.
        """
        return pulumi.get(self, "application_id")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        (v1.274) Add a description for your rule
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="insertAfter")
    def insert_after(self) -> pulumi.Output[str]:
        """
        Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        """
        return pulumi.get(self, "insert_after")

    @property
    @pulumi.getter
    def matcher(self) -> pulumi.Output[str]:
        """
        Possible Values: `DOMAIN_CONTAINS`, `DOMAIN_ENDS_WITH`, `DOMAIN_EQUALS`, `DOMAIN_MATCHES`, `DOMAIN_STARTS_WITH`, `URL_CONTAINS`, `URL_ENDS_WITH`, `URL_EQUALS`, `URL_STARTS_WITH`
        """
        return pulumi.get(self, "matcher")

    @property
    @pulumi.getter
    def pattern(self) -> pulumi.Output[str]:
        """
        Pattern
        """
        return pulumi.get(self, "pattern")

