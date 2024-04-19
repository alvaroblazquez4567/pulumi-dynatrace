# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = [
    'GetManagementZoneResult',
    'AwaitableGetManagementZoneResult',
    'get_management_zone',
    'get_management_zone_output',
]

@pulumi.output_type
class GetManagementZoneResult:
    """
    A collection of values returned by getManagementZone.
    """
    def __init__(__self__, id=None, legacy_id=None, name=None, settings20_id=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if legacy_id and not isinstance(legacy_id, str):
            raise TypeError("Expected argument 'legacy_id' to be a str")
        pulumi.set(__self__, "legacy_id", legacy_id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if settings20_id and not isinstance(settings20_id, str):
            raise TypeError("Expected argument 'settings20_id' to be a str")
        pulumi.set(__self__, "settings20_id", settings20_id)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="legacyId")
    def legacy_id(self) -> str:
        return pulumi.get(self, "legacy_id")

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="settings20Id")
    def settings20_id(self) -> str:
        return pulumi.get(self, "settings20_id")


class AwaitableGetManagementZoneResult(GetManagementZoneResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetManagementZoneResult(
            id=self.id,
            legacy_id=self.legacy_id,
            name=self.name,
            settings20_id=self.settings20_id)


def get_management_zone(name: Optional[str] = None,
                        opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetManagementZoneResult:
    """
    The management zone data source allows the management zone ID to be retrieved by its name.

    > This data source requires the API token scope **Read configuration** (`ReadConfig`)

    !> This data source is utilizing an older API endpoint, please use ManagementZoneV2 instead.

    - `name` queries for all management zones with the specified name

    ## Example Usage

    ```python
    import pulumi
    import lbrlabs_pulumi_dynatrace as dynatrace
    import pulumi_dynatrace as dynatrace

    test = dynatrace.get_management_zone(name="Example")
    _name_ = dynatrace.CalculatedServiceMetric("#name#",
        conditions=[dynatrace.CalculatedServiceMetricConditionArgs(
            conditions=[dynatrace.CalculatedServiceMetricConditionConditionArgs(
                attribute="HTTP_REQUEST_METHOD",
                comparison=dynatrace.CalculatedServiceMetricConditionConditionComparisonArgs(
                    http_method=dynatrace.CalculatedServiceMetricConditionConditionComparisonHttpMethodArgs(
                        operator="EQUALS_ANY_OF",
                        values=[
                            "POST",
                            "GET",
                        ],
                    ),
                    negate=False,
                ),
            )],
        )],
        enabled=True,
        management_zones=[test.id],
        metric_definition=dynatrace.CalculatedServiceMetricMetricDefinitionArgs(
            metric="REQUEST_ATTRIBUTE",
            request_attribute="foo",
        ),
        metric_key="calc:service.#name#",
        unit="MILLI_SECOND_PER_MINUTE")
    ```
    """
    __args__ = dict()
    __args__['name'] = name
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('dynatrace:index/getManagementZone:getManagementZone', __args__, opts=opts, typ=GetManagementZoneResult).value

    return AwaitableGetManagementZoneResult(
        id=pulumi.get(__ret__, 'id'),
        legacy_id=pulumi.get(__ret__, 'legacy_id'),
        name=pulumi.get(__ret__, 'name'),
        settings20_id=pulumi.get(__ret__, 'settings20_id'))


@_utilities.lift_output_func(get_management_zone)
def get_management_zone_output(name: Optional[pulumi.Input[str]] = None,
                               opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetManagementZoneResult]:
    """
    The management zone data source allows the management zone ID to be retrieved by its name.

    > This data source requires the API token scope **Read configuration** (`ReadConfig`)

    !> This data source is utilizing an older API endpoint, please use ManagementZoneV2 instead.

    - `name` queries for all management zones with the specified name

    ## Example Usage

    ```python
    import pulumi
    import lbrlabs_pulumi_dynatrace as dynatrace
    import pulumi_dynatrace as dynatrace

    test = dynatrace.get_management_zone(name="Example")
    _name_ = dynatrace.CalculatedServiceMetric("#name#",
        conditions=[dynatrace.CalculatedServiceMetricConditionArgs(
            conditions=[dynatrace.CalculatedServiceMetricConditionConditionArgs(
                attribute="HTTP_REQUEST_METHOD",
                comparison=dynatrace.CalculatedServiceMetricConditionConditionComparisonArgs(
                    http_method=dynatrace.CalculatedServiceMetricConditionConditionComparisonHttpMethodArgs(
                        operator="EQUALS_ANY_OF",
                        values=[
                            "POST",
                            "GET",
                        ],
                    ),
                    negate=False,
                ),
            )],
        )],
        enabled=True,
        management_zones=[test.id],
        metric_definition=dynatrace.CalculatedServiceMetricMetricDefinitionArgs(
            metric="REQUEST_ATTRIBUTE",
            request_attribute="foo",
        ),
        metric_key="calc:service.#name#",
        unit="MILLI_SECOND_PER_MINUTE")
    ```
    """
    ...