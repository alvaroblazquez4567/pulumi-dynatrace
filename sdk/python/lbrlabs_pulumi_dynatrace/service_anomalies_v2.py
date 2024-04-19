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

__all__ = ['ServiceAnomaliesV2Args', 'ServiceAnomaliesV2']

@pulumi.input_type
class ServiceAnomaliesV2Args:
    def __init__(__self__, *,
                 failure_rate: pulumi.Input['ServiceAnomaliesV2FailureRateArgs'],
                 load_drops: pulumi.Input['ServiceAnomaliesV2LoadDropsArgs'],
                 load_spikes: pulumi.Input['ServiceAnomaliesV2LoadSpikesArgs'],
                 response_time: pulumi.Input['ServiceAnomaliesV2ResponseTimeArgs'],
                 scope: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a ServiceAnomaliesV2 resource.
        :param pulumi.Input['ServiceAnomaliesV2FailureRateArgs'] failure_rate: Failure rate
        :param pulumi.Input['ServiceAnomaliesV2LoadDropsArgs'] load_drops: Alert if the observed load is lower than the expected load by a specified margin for a specified amount of time:
        :param pulumi.Input['ServiceAnomaliesV2LoadSpikesArgs'] load_spikes: Alert if the observed load exceeds the expected load by a specified margin for a specified amount of time:
        :param pulumi.Input['ServiceAnomaliesV2ResponseTimeArgs'] response_time: Response time
        :param pulumi.Input[str] scope: The scope of this setting (SERVICE*METHOD, SERVICE, HOST*GROUP). Omit this property if you want to cover the whole environment.
        """
        pulumi.set(__self__, "failure_rate", failure_rate)
        pulumi.set(__self__, "load_drops", load_drops)
        pulumi.set(__self__, "load_spikes", load_spikes)
        pulumi.set(__self__, "response_time", response_time)
        if scope is not None:
            pulumi.set(__self__, "scope", scope)

    @property
    @pulumi.getter(name="failureRate")
    def failure_rate(self) -> pulumi.Input['ServiceAnomaliesV2FailureRateArgs']:
        """
        Failure rate
        """
        return pulumi.get(self, "failure_rate")

    @failure_rate.setter
    def failure_rate(self, value: pulumi.Input['ServiceAnomaliesV2FailureRateArgs']):
        pulumi.set(self, "failure_rate", value)

    @property
    @pulumi.getter(name="loadDrops")
    def load_drops(self) -> pulumi.Input['ServiceAnomaliesV2LoadDropsArgs']:
        """
        Alert if the observed load is lower than the expected load by a specified margin for a specified amount of time:
        """
        return pulumi.get(self, "load_drops")

    @load_drops.setter
    def load_drops(self, value: pulumi.Input['ServiceAnomaliesV2LoadDropsArgs']):
        pulumi.set(self, "load_drops", value)

    @property
    @pulumi.getter(name="loadSpikes")
    def load_spikes(self) -> pulumi.Input['ServiceAnomaliesV2LoadSpikesArgs']:
        """
        Alert if the observed load exceeds the expected load by a specified margin for a specified amount of time:
        """
        return pulumi.get(self, "load_spikes")

    @load_spikes.setter
    def load_spikes(self, value: pulumi.Input['ServiceAnomaliesV2LoadSpikesArgs']):
        pulumi.set(self, "load_spikes", value)

    @property
    @pulumi.getter(name="responseTime")
    def response_time(self) -> pulumi.Input['ServiceAnomaliesV2ResponseTimeArgs']:
        """
        Response time
        """
        return pulumi.get(self, "response_time")

    @response_time.setter
    def response_time(self, value: pulumi.Input['ServiceAnomaliesV2ResponseTimeArgs']):
        pulumi.set(self, "response_time", value)

    @property
    @pulumi.getter
    def scope(self) -> Optional[pulumi.Input[str]]:
        """
        The scope of this setting (SERVICE*METHOD, SERVICE, HOST*GROUP). Omit this property if you want to cover the whole environment.
        """
        return pulumi.get(self, "scope")

    @scope.setter
    def scope(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "scope", value)


@pulumi.input_type
class _ServiceAnomaliesV2State:
    def __init__(__self__, *,
                 failure_rate: Optional[pulumi.Input['ServiceAnomaliesV2FailureRateArgs']] = None,
                 load_drops: Optional[pulumi.Input['ServiceAnomaliesV2LoadDropsArgs']] = None,
                 load_spikes: Optional[pulumi.Input['ServiceAnomaliesV2LoadSpikesArgs']] = None,
                 response_time: Optional[pulumi.Input['ServiceAnomaliesV2ResponseTimeArgs']] = None,
                 scope: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering ServiceAnomaliesV2 resources.
        :param pulumi.Input['ServiceAnomaliesV2FailureRateArgs'] failure_rate: Failure rate
        :param pulumi.Input['ServiceAnomaliesV2LoadDropsArgs'] load_drops: Alert if the observed load is lower than the expected load by a specified margin for a specified amount of time:
        :param pulumi.Input['ServiceAnomaliesV2LoadSpikesArgs'] load_spikes: Alert if the observed load exceeds the expected load by a specified margin for a specified amount of time:
        :param pulumi.Input['ServiceAnomaliesV2ResponseTimeArgs'] response_time: Response time
        :param pulumi.Input[str] scope: The scope of this setting (SERVICE*METHOD, SERVICE, HOST*GROUP). Omit this property if you want to cover the whole environment.
        """
        if failure_rate is not None:
            pulumi.set(__self__, "failure_rate", failure_rate)
        if load_drops is not None:
            pulumi.set(__self__, "load_drops", load_drops)
        if load_spikes is not None:
            pulumi.set(__self__, "load_spikes", load_spikes)
        if response_time is not None:
            pulumi.set(__self__, "response_time", response_time)
        if scope is not None:
            pulumi.set(__self__, "scope", scope)

    @property
    @pulumi.getter(name="failureRate")
    def failure_rate(self) -> Optional[pulumi.Input['ServiceAnomaliesV2FailureRateArgs']]:
        """
        Failure rate
        """
        return pulumi.get(self, "failure_rate")

    @failure_rate.setter
    def failure_rate(self, value: Optional[pulumi.Input['ServiceAnomaliesV2FailureRateArgs']]):
        pulumi.set(self, "failure_rate", value)

    @property
    @pulumi.getter(name="loadDrops")
    def load_drops(self) -> Optional[pulumi.Input['ServiceAnomaliesV2LoadDropsArgs']]:
        """
        Alert if the observed load is lower than the expected load by a specified margin for a specified amount of time:
        """
        return pulumi.get(self, "load_drops")

    @load_drops.setter
    def load_drops(self, value: Optional[pulumi.Input['ServiceAnomaliesV2LoadDropsArgs']]):
        pulumi.set(self, "load_drops", value)

    @property
    @pulumi.getter(name="loadSpikes")
    def load_spikes(self) -> Optional[pulumi.Input['ServiceAnomaliesV2LoadSpikesArgs']]:
        """
        Alert if the observed load exceeds the expected load by a specified margin for a specified amount of time:
        """
        return pulumi.get(self, "load_spikes")

    @load_spikes.setter
    def load_spikes(self, value: Optional[pulumi.Input['ServiceAnomaliesV2LoadSpikesArgs']]):
        pulumi.set(self, "load_spikes", value)

    @property
    @pulumi.getter(name="responseTime")
    def response_time(self) -> Optional[pulumi.Input['ServiceAnomaliesV2ResponseTimeArgs']]:
        """
        Response time
        """
        return pulumi.get(self, "response_time")

    @response_time.setter
    def response_time(self, value: Optional[pulumi.Input['ServiceAnomaliesV2ResponseTimeArgs']]):
        pulumi.set(self, "response_time", value)

    @property
    @pulumi.getter
    def scope(self) -> Optional[pulumi.Input[str]]:
        """
        The scope of this setting (SERVICE*METHOD, SERVICE, HOST*GROUP). Omit this property if you want to cover the whole environment.
        """
        return pulumi.get(self, "scope")

    @scope.setter
    def scope(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "scope", value)


class ServiceAnomaliesV2(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 failure_rate: Optional[pulumi.Input[pulumi.InputType['ServiceAnomaliesV2FailureRateArgs']]] = None,
                 load_drops: Optional[pulumi.Input[pulumi.InputType['ServiceAnomaliesV2LoadDropsArgs']]] = None,
                 load_spikes: Optional[pulumi.Input[pulumi.InputType['ServiceAnomaliesV2LoadSpikesArgs']]] = None,
                 response_time: Optional[pulumi.Input[pulumi.InputType['ServiceAnomaliesV2ResponseTimeArgs']]] = None,
                 scope: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a ServiceAnomaliesV2 resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['ServiceAnomaliesV2FailureRateArgs']] failure_rate: Failure rate
        :param pulumi.Input[pulumi.InputType['ServiceAnomaliesV2LoadDropsArgs']] load_drops: Alert if the observed load is lower than the expected load by a specified margin for a specified amount of time:
        :param pulumi.Input[pulumi.InputType['ServiceAnomaliesV2LoadSpikesArgs']] load_spikes: Alert if the observed load exceeds the expected load by a specified margin for a specified amount of time:
        :param pulumi.Input[pulumi.InputType['ServiceAnomaliesV2ResponseTimeArgs']] response_time: Response time
        :param pulumi.Input[str] scope: The scope of this setting (SERVICE*METHOD, SERVICE, HOST*GROUP). Omit this property if you want to cover the whole environment.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ServiceAnomaliesV2Args,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a ServiceAnomaliesV2 resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param ServiceAnomaliesV2Args args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ServiceAnomaliesV2Args, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 failure_rate: Optional[pulumi.Input[pulumi.InputType['ServiceAnomaliesV2FailureRateArgs']]] = None,
                 load_drops: Optional[pulumi.Input[pulumi.InputType['ServiceAnomaliesV2LoadDropsArgs']]] = None,
                 load_spikes: Optional[pulumi.Input[pulumi.InputType['ServiceAnomaliesV2LoadSpikesArgs']]] = None,
                 response_time: Optional[pulumi.Input[pulumi.InputType['ServiceAnomaliesV2ResponseTimeArgs']]] = None,
                 scope: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ServiceAnomaliesV2Args.__new__(ServiceAnomaliesV2Args)

            if failure_rate is None and not opts.urn:
                raise TypeError("Missing required property 'failure_rate'")
            __props__.__dict__["failure_rate"] = failure_rate
            if load_drops is None and not opts.urn:
                raise TypeError("Missing required property 'load_drops'")
            __props__.__dict__["load_drops"] = load_drops
            if load_spikes is None and not opts.urn:
                raise TypeError("Missing required property 'load_spikes'")
            __props__.__dict__["load_spikes"] = load_spikes
            if response_time is None and not opts.urn:
                raise TypeError("Missing required property 'response_time'")
            __props__.__dict__["response_time"] = response_time
            __props__.__dict__["scope"] = scope
        super(ServiceAnomaliesV2, __self__).__init__(
            'dynatrace:index/serviceAnomaliesV2:ServiceAnomaliesV2',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            failure_rate: Optional[pulumi.Input[pulumi.InputType['ServiceAnomaliesV2FailureRateArgs']]] = None,
            load_drops: Optional[pulumi.Input[pulumi.InputType['ServiceAnomaliesV2LoadDropsArgs']]] = None,
            load_spikes: Optional[pulumi.Input[pulumi.InputType['ServiceAnomaliesV2LoadSpikesArgs']]] = None,
            response_time: Optional[pulumi.Input[pulumi.InputType['ServiceAnomaliesV2ResponseTimeArgs']]] = None,
            scope: Optional[pulumi.Input[str]] = None) -> 'ServiceAnomaliesV2':
        """
        Get an existing ServiceAnomaliesV2 resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['ServiceAnomaliesV2FailureRateArgs']] failure_rate: Failure rate
        :param pulumi.Input[pulumi.InputType['ServiceAnomaliesV2LoadDropsArgs']] load_drops: Alert if the observed load is lower than the expected load by a specified margin for a specified amount of time:
        :param pulumi.Input[pulumi.InputType['ServiceAnomaliesV2LoadSpikesArgs']] load_spikes: Alert if the observed load exceeds the expected load by a specified margin for a specified amount of time:
        :param pulumi.Input[pulumi.InputType['ServiceAnomaliesV2ResponseTimeArgs']] response_time: Response time
        :param pulumi.Input[str] scope: The scope of this setting (SERVICE*METHOD, SERVICE, HOST*GROUP). Omit this property if you want to cover the whole environment.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ServiceAnomaliesV2State.__new__(_ServiceAnomaliesV2State)

        __props__.__dict__["failure_rate"] = failure_rate
        __props__.__dict__["load_drops"] = load_drops
        __props__.__dict__["load_spikes"] = load_spikes
        __props__.__dict__["response_time"] = response_time
        __props__.__dict__["scope"] = scope
        return ServiceAnomaliesV2(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="failureRate")
    def failure_rate(self) -> pulumi.Output['outputs.ServiceAnomaliesV2FailureRate']:
        """
        Failure rate
        """
        return pulumi.get(self, "failure_rate")

    @property
    @pulumi.getter(name="loadDrops")
    def load_drops(self) -> pulumi.Output['outputs.ServiceAnomaliesV2LoadDrops']:
        """
        Alert if the observed load is lower than the expected load by a specified margin for a specified amount of time:
        """
        return pulumi.get(self, "load_drops")

    @property
    @pulumi.getter(name="loadSpikes")
    def load_spikes(self) -> pulumi.Output['outputs.ServiceAnomaliesV2LoadSpikes']:
        """
        Alert if the observed load exceeds the expected load by a specified margin for a specified amount of time:
        """
        return pulumi.get(self, "load_spikes")

    @property
    @pulumi.getter(name="responseTime")
    def response_time(self) -> pulumi.Output['outputs.ServiceAnomaliesV2ResponseTime']:
        """
        Response time
        """
        return pulumi.get(self, "response_time")

    @property
    @pulumi.getter
    def scope(self) -> pulumi.Output[Optional[str]]:
        """
        The scope of this setting (SERVICE*METHOD, SERVICE, HOST*GROUP). Omit this property if you want to cover the whole environment.
        """
        return pulumi.get(self, "scope")

