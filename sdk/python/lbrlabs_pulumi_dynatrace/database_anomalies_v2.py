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

__all__ = ['DatabaseAnomaliesV2Args', 'DatabaseAnomaliesV2']

@pulumi.input_type
class DatabaseAnomaliesV2Args:
    def __init__(__self__, *,
                 database_connections: pulumi.Input['DatabaseAnomaliesV2DatabaseConnectionsArgs'],
                 failure_rate: pulumi.Input['DatabaseAnomaliesV2FailureRateArgs'],
                 load_drops: pulumi.Input['DatabaseAnomaliesV2LoadDropsArgs'],
                 load_spikes: pulumi.Input['DatabaseAnomaliesV2LoadSpikesArgs'],
                 response_time: pulumi.Input['DatabaseAnomaliesV2ResponseTimeArgs'],
                 scope: pulumi.Input[str]):
        """
        The set of arguments for constructing a DatabaseAnomaliesV2 resource.
        :param pulumi.Input['DatabaseAnomaliesV2DatabaseConnectionsArgs'] database_connections: Alert if the number of failed database connects within the specified time exceeds the specified absolute threshold:
        :param pulumi.Input['DatabaseAnomaliesV2FailureRateArgs'] failure_rate: Failure rate
        :param pulumi.Input['DatabaseAnomaliesV2LoadDropsArgs'] load_drops: Alert if the observed load is lower than the expected load by a specified margin for a specified amount of time.
        :param pulumi.Input['DatabaseAnomaliesV2LoadSpikesArgs'] load_spikes: Alert if the observed load exceeds the expected load by a specified margin for a specified amount of time.
        :param pulumi.Input['DatabaseAnomaliesV2ResponseTimeArgs'] response_time: Response time
        :param pulumi.Input[str] scope: The scope for the database anomaly detection
        """
        pulumi.set(__self__, "database_connections", database_connections)
        pulumi.set(__self__, "failure_rate", failure_rate)
        pulumi.set(__self__, "load_drops", load_drops)
        pulumi.set(__self__, "load_spikes", load_spikes)
        pulumi.set(__self__, "response_time", response_time)
        pulumi.set(__self__, "scope", scope)

    @property
    @pulumi.getter(name="databaseConnections")
    def database_connections(self) -> pulumi.Input['DatabaseAnomaliesV2DatabaseConnectionsArgs']:
        """
        Alert if the number of failed database connects within the specified time exceeds the specified absolute threshold:
        """
        return pulumi.get(self, "database_connections")

    @database_connections.setter
    def database_connections(self, value: pulumi.Input['DatabaseAnomaliesV2DatabaseConnectionsArgs']):
        pulumi.set(self, "database_connections", value)

    @property
    @pulumi.getter(name="failureRate")
    def failure_rate(self) -> pulumi.Input['DatabaseAnomaliesV2FailureRateArgs']:
        """
        Failure rate
        """
        return pulumi.get(self, "failure_rate")

    @failure_rate.setter
    def failure_rate(self, value: pulumi.Input['DatabaseAnomaliesV2FailureRateArgs']):
        pulumi.set(self, "failure_rate", value)

    @property
    @pulumi.getter(name="loadDrops")
    def load_drops(self) -> pulumi.Input['DatabaseAnomaliesV2LoadDropsArgs']:
        """
        Alert if the observed load is lower than the expected load by a specified margin for a specified amount of time.
        """
        return pulumi.get(self, "load_drops")

    @load_drops.setter
    def load_drops(self, value: pulumi.Input['DatabaseAnomaliesV2LoadDropsArgs']):
        pulumi.set(self, "load_drops", value)

    @property
    @pulumi.getter(name="loadSpikes")
    def load_spikes(self) -> pulumi.Input['DatabaseAnomaliesV2LoadSpikesArgs']:
        """
        Alert if the observed load exceeds the expected load by a specified margin for a specified amount of time.
        """
        return pulumi.get(self, "load_spikes")

    @load_spikes.setter
    def load_spikes(self, value: pulumi.Input['DatabaseAnomaliesV2LoadSpikesArgs']):
        pulumi.set(self, "load_spikes", value)

    @property
    @pulumi.getter(name="responseTime")
    def response_time(self) -> pulumi.Input['DatabaseAnomaliesV2ResponseTimeArgs']:
        """
        Response time
        """
        return pulumi.get(self, "response_time")

    @response_time.setter
    def response_time(self, value: pulumi.Input['DatabaseAnomaliesV2ResponseTimeArgs']):
        pulumi.set(self, "response_time", value)

    @property
    @pulumi.getter
    def scope(self) -> pulumi.Input[str]:
        """
        The scope for the database anomaly detection
        """
        return pulumi.get(self, "scope")

    @scope.setter
    def scope(self, value: pulumi.Input[str]):
        pulumi.set(self, "scope", value)


@pulumi.input_type
class _DatabaseAnomaliesV2State:
    def __init__(__self__, *,
                 database_connections: Optional[pulumi.Input['DatabaseAnomaliesV2DatabaseConnectionsArgs']] = None,
                 failure_rate: Optional[pulumi.Input['DatabaseAnomaliesV2FailureRateArgs']] = None,
                 load_drops: Optional[pulumi.Input['DatabaseAnomaliesV2LoadDropsArgs']] = None,
                 load_spikes: Optional[pulumi.Input['DatabaseAnomaliesV2LoadSpikesArgs']] = None,
                 response_time: Optional[pulumi.Input['DatabaseAnomaliesV2ResponseTimeArgs']] = None,
                 scope: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering DatabaseAnomaliesV2 resources.
        :param pulumi.Input['DatabaseAnomaliesV2DatabaseConnectionsArgs'] database_connections: Alert if the number of failed database connects within the specified time exceeds the specified absolute threshold:
        :param pulumi.Input['DatabaseAnomaliesV2FailureRateArgs'] failure_rate: Failure rate
        :param pulumi.Input['DatabaseAnomaliesV2LoadDropsArgs'] load_drops: Alert if the observed load is lower than the expected load by a specified margin for a specified amount of time.
        :param pulumi.Input['DatabaseAnomaliesV2LoadSpikesArgs'] load_spikes: Alert if the observed load exceeds the expected load by a specified margin for a specified amount of time.
        :param pulumi.Input['DatabaseAnomaliesV2ResponseTimeArgs'] response_time: Response time
        :param pulumi.Input[str] scope: The scope for the database anomaly detection
        """
        if database_connections is not None:
            pulumi.set(__self__, "database_connections", database_connections)
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
    @pulumi.getter(name="databaseConnections")
    def database_connections(self) -> Optional[pulumi.Input['DatabaseAnomaliesV2DatabaseConnectionsArgs']]:
        """
        Alert if the number of failed database connects within the specified time exceeds the specified absolute threshold:
        """
        return pulumi.get(self, "database_connections")

    @database_connections.setter
    def database_connections(self, value: Optional[pulumi.Input['DatabaseAnomaliesV2DatabaseConnectionsArgs']]):
        pulumi.set(self, "database_connections", value)

    @property
    @pulumi.getter(name="failureRate")
    def failure_rate(self) -> Optional[pulumi.Input['DatabaseAnomaliesV2FailureRateArgs']]:
        """
        Failure rate
        """
        return pulumi.get(self, "failure_rate")

    @failure_rate.setter
    def failure_rate(self, value: Optional[pulumi.Input['DatabaseAnomaliesV2FailureRateArgs']]):
        pulumi.set(self, "failure_rate", value)

    @property
    @pulumi.getter(name="loadDrops")
    def load_drops(self) -> Optional[pulumi.Input['DatabaseAnomaliesV2LoadDropsArgs']]:
        """
        Alert if the observed load is lower than the expected load by a specified margin for a specified amount of time.
        """
        return pulumi.get(self, "load_drops")

    @load_drops.setter
    def load_drops(self, value: Optional[pulumi.Input['DatabaseAnomaliesV2LoadDropsArgs']]):
        pulumi.set(self, "load_drops", value)

    @property
    @pulumi.getter(name="loadSpikes")
    def load_spikes(self) -> Optional[pulumi.Input['DatabaseAnomaliesV2LoadSpikesArgs']]:
        """
        Alert if the observed load exceeds the expected load by a specified margin for a specified amount of time.
        """
        return pulumi.get(self, "load_spikes")

    @load_spikes.setter
    def load_spikes(self, value: Optional[pulumi.Input['DatabaseAnomaliesV2LoadSpikesArgs']]):
        pulumi.set(self, "load_spikes", value)

    @property
    @pulumi.getter(name="responseTime")
    def response_time(self) -> Optional[pulumi.Input['DatabaseAnomaliesV2ResponseTimeArgs']]:
        """
        Response time
        """
        return pulumi.get(self, "response_time")

    @response_time.setter
    def response_time(self, value: Optional[pulumi.Input['DatabaseAnomaliesV2ResponseTimeArgs']]):
        pulumi.set(self, "response_time", value)

    @property
    @pulumi.getter
    def scope(self) -> Optional[pulumi.Input[str]]:
        """
        The scope for the database anomaly detection
        """
        return pulumi.get(self, "scope")

    @scope.setter
    def scope(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "scope", value)


class DatabaseAnomaliesV2(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 database_connections: Optional[pulumi.Input[pulumi.InputType['DatabaseAnomaliesV2DatabaseConnectionsArgs']]] = None,
                 failure_rate: Optional[pulumi.Input[pulumi.InputType['DatabaseAnomaliesV2FailureRateArgs']]] = None,
                 load_drops: Optional[pulumi.Input[pulumi.InputType['DatabaseAnomaliesV2LoadDropsArgs']]] = None,
                 load_spikes: Optional[pulumi.Input[pulumi.InputType['DatabaseAnomaliesV2LoadSpikesArgs']]] = None,
                 response_time: Optional[pulumi.Input[pulumi.InputType['DatabaseAnomaliesV2ResponseTimeArgs']]] = None,
                 scope: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a DatabaseAnomaliesV2 resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['DatabaseAnomaliesV2DatabaseConnectionsArgs']] database_connections: Alert if the number of failed database connects within the specified time exceeds the specified absolute threshold:
        :param pulumi.Input[pulumi.InputType['DatabaseAnomaliesV2FailureRateArgs']] failure_rate: Failure rate
        :param pulumi.Input[pulumi.InputType['DatabaseAnomaliesV2LoadDropsArgs']] load_drops: Alert if the observed load is lower than the expected load by a specified margin for a specified amount of time.
        :param pulumi.Input[pulumi.InputType['DatabaseAnomaliesV2LoadSpikesArgs']] load_spikes: Alert if the observed load exceeds the expected load by a specified margin for a specified amount of time.
        :param pulumi.Input[pulumi.InputType['DatabaseAnomaliesV2ResponseTimeArgs']] response_time: Response time
        :param pulumi.Input[str] scope: The scope for the database anomaly detection
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: DatabaseAnomaliesV2Args,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a DatabaseAnomaliesV2 resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param DatabaseAnomaliesV2Args args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(DatabaseAnomaliesV2Args, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 database_connections: Optional[pulumi.Input[pulumi.InputType['DatabaseAnomaliesV2DatabaseConnectionsArgs']]] = None,
                 failure_rate: Optional[pulumi.Input[pulumi.InputType['DatabaseAnomaliesV2FailureRateArgs']]] = None,
                 load_drops: Optional[pulumi.Input[pulumi.InputType['DatabaseAnomaliesV2LoadDropsArgs']]] = None,
                 load_spikes: Optional[pulumi.Input[pulumi.InputType['DatabaseAnomaliesV2LoadSpikesArgs']]] = None,
                 response_time: Optional[pulumi.Input[pulumi.InputType['DatabaseAnomaliesV2ResponseTimeArgs']]] = None,
                 scope: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = DatabaseAnomaliesV2Args.__new__(DatabaseAnomaliesV2Args)

            if database_connections is None and not opts.urn:
                raise TypeError("Missing required property 'database_connections'")
            __props__.__dict__["database_connections"] = database_connections
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
            if scope is None and not opts.urn:
                raise TypeError("Missing required property 'scope'")
            __props__.__dict__["scope"] = scope
        super(DatabaseAnomaliesV2, __self__).__init__(
            'dynatrace:index/databaseAnomaliesV2:DatabaseAnomaliesV2',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            database_connections: Optional[pulumi.Input[pulumi.InputType['DatabaseAnomaliesV2DatabaseConnectionsArgs']]] = None,
            failure_rate: Optional[pulumi.Input[pulumi.InputType['DatabaseAnomaliesV2FailureRateArgs']]] = None,
            load_drops: Optional[pulumi.Input[pulumi.InputType['DatabaseAnomaliesV2LoadDropsArgs']]] = None,
            load_spikes: Optional[pulumi.Input[pulumi.InputType['DatabaseAnomaliesV2LoadSpikesArgs']]] = None,
            response_time: Optional[pulumi.Input[pulumi.InputType['DatabaseAnomaliesV2ResponseTimeArgs']]] = None,
            scope: Optional[pulumi.Input[str]] = None) -> 'DatabaseAnomaliesV2':
        """
        Get an existing DatabaseAnomaliesV2 resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['DatabaseAnomaliesV2DatabaseConnectionsArgs']] database_connections: Alert if the number of failed database connects within the specified time exceeds the specified absolute threshold:
        :param pulumi.Input[pulumi.InputType['DatabaseAnomaliesV2FailureRateArgs']] failure_rate: Failure rate
        :param pulumi.Input[pulumi.InputType['DatabaseAnomaliesV2LoadDropsArgs']] load_drops: Alert if the observed load is lower than the expected load by a specified margin for a specified amount of time.
        :param pulumi.Input[pulumi.InputType['DatabaseAnomaliesV2LoadSpikesArgs']] load_spikes: Alert if the observed load exceeds the expected load by a specified margin for a specified amount of time.
        :param pulumi.Input[pulumi.InputType['DatabaseAnomaliesV2ResponseTimeArgs']] response_time: Response time
        :param pulumi.Input[str] scope: The scope for the database anomaly detection
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _DatabaseAnomaliesV2State.__new__(_DatabaseAnomaliesV2State)

        __props__.__dict__["database_connections"] = database_connections
        __props__.__dict__["failure_rate"] = failure_rate
        __props__.__dict__["load_drops"] = load_drops
        __props__.__dict__["load_spikes"] = load_spikes
        __props__.__dict__["response_time"] = response_time
        __props__.__dict__["scope"] = scope
        return DatabaseAnomaliesV2(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="databaseConnections")
    def database_connections(self) -> pulumi.Output['outputs.DatabaseAnomaliesV2DatabaseConnections']:
        """
        Alert if the number of failed database connects within the specified time exceeds the specified absolute threshold:
        """
        return pulumi.get(self, "database_connections")

    @property
    @pulumi.getter(name="failureRate")
    def failure_rate(self) -> pulumi.Output['outputs.DatabaseAnomaliesV2FailureRate']:
        """
        Failure rate
        """
        return pulumi.get(self, "failure_rate")

    @property
    @pulumi.getter(name="loadDrops")
    def load_drops(self) -> pulumi.Output['outputs.DatabaseAnomaliesV2LoadDrops']:
        """
        Alert if the observed load is lower than the expected load by a specified margin for a specified amount of time.
        """
        return pulumi.get(self, "load_drops")

    @property
    @pulumi.getter(name="loadSpikes")
    def load_spikes(self) -> pulumi.Output['outputs.DatabaseAnomaliesV2LoadSpikes']:
        """
        Alert if the observed load exceeds the expected load by a specified margin for a specified amount of time.
        """
        return pulumi.get(self, "load_spikes")

    @property
    @pulumi.getter(name="responseTime")
    def response_time(self) -> pulumi.Output['outputs.DatabaseAnomaliesV2ResponseTime']:
        """
        Response time
        """
        return pulumi.get(self, "response_time")

    @property
    @pulumi.getter
    def scope(self) -> pulumi.Output[str]:
        """
        The scope for the database anomaly detection
        """
        return pulumi.get(self, "scope")

