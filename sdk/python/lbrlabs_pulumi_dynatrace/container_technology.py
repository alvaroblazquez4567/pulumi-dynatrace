# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['ContainerTechnologyArgs', 'ContainerTechnology']

@pulumi.input_type
class ContainerTechnologyArgs:
    def __init__(__self__, *,
                 bosh_process_manager: pulumi.Input[bool],
                 containerd: pulumi.Input[bool],
                 crio: pulumi.Input[bool],
                 docker: pulumi.Input[bool],
                 docker_windows: pulumi.Input[bool],
                 garden: pulumi.Input[bool],
                 podman: pulumi.Input[bool],
                 winc: pulumi.Input[bool],
                 scope: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a ContainerTechnology resource.
        :param pulumi.Input[bool] bosh_process_manager: Platform: Cloud Foundry
        :param pulumi.Input[bool] containerd: Platform: Kubernetes Status: Released Operating system: Linux Min agent version: 1.169
        :param pulumi.Input[bool] crio: Platform: Kubernetes Status: Released Operating system: Linux Min agent version: 1.163
        :param pulumi.Input[bool] docker: Platform: Docker and Kubernetes Status: Released Operating system: Linux
        :param pulumi.Input[bool] docker_windows: Platform: Docker Status: Early adopter Operating system: Windows Min agent version: 1.149
        :param pulumi.Input[bool] garden: Platform: Cloud Foundry Status: Released Operating system: Linux Min agent version: 1.133
        :param pulumi.Input[bool] podman: Platform: Podman Status: Released Operating system: Linux Min agent version: 1.267
        :param pulumi.Input[bool] winc: Platform: Cloud Foundry Status: Early adopter Operating system: Windows Min agent version: 1.175
        :param pulumi.Input[str] scope: The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        """
        pulumi.set(__self__, "bosh_process_manager", bosh_process_manager)
        pulumi.set(__self__, "containerd", containerd)
        pulumi.set(__self__, "crio", crio)
        pulumi.set(__self__, "docker", docker)
        pulumi.set(__self__, "docker_windows", docker_windows)
        pulumi.set(__self__, "garden", garden)
        pulumi.set(__self__, "podman", podman)
        pulumi.set(__self__, "winc", winc)
        if scope is not None:
            pulumi.set(__self__, "scope", scope)

    @property
    @pulumi.getter(name="boshProcessManager")
    def bosh_process_manager(self) -> pulumi.Input[bool]:
        """
        Platform: Cloud Foundry
        """
        return pulumi.get(self, "bosh_process_manager")

    @bosh_process_manager.setter
    def bosh_process_manager(self, value: pulumi.Input[bool]):
        pulumi.set(self, "bosh_process_manager", value)

    @property
    @pulumi.getter
    def containerd(self) -> pulumi.Input[bool]:
        """
        Platform: Kubernetes Status: Released Operating system: Linux Min agent version: 1.169
        """
        return pulumi.get(self, "containerd")

    @containerd.setter
    def containerd(self, value: pulumi.Input[bool]):
        pulumi.set(self, "containerd", value)

    @property
    @pulumi.getter
    def crio(self) -> pulumi.Input[bool]:
        """
        Platform: Kubernetes Status: Released Operating system: Linux Min agent version: 1.163
        """
        return pulumi.get(self, "crio")

    @crio.setter
    def crio(self, value: pulumi.Input[bool]):
        pulumi.set(self, "crio", value)

    @property
    @pulumi.getter
    def docker(self) -> pulumi.Input[bool]:
        """
        Platform: Docker and Kubernetes Status: Released Operating system: Linux
        """
        return pulumi.get(self, "docker")

    @docker.setter
    def docker(self, value: pulumi.Input[bool]):
        pulumi.set(self, "docker", value)

    @property
    @pulumi.getter(name="dockerWindows")
    def docker_windows(self) -> pulumi.Input[bool]:
        """
        Platform: Docker Status: Early adopter Operating system: Windows Min agent version: 1.149
        """
        return pulumi.get(self, "docker_windows")

    @docker_windows.setter
    def docker_windows(self, value: pulumi.Input[bool]):
        pulumi.set(self, "docker_windows", value)

    @property
    @pulumi.getter
    def garden(self) -> pulumi.Input[bool]:
        """
        Platform: Cloud Foundry Status: Released Operating system: Linux Min agent version: 1.133
        """
        return pulumi.get(self, "garden")

    @garden.setter
    def garden(self, value: pulumi.Input[bool]):
        pulumi.set(self, "garden", value)

    @property
    @pulumi.getter
    def podman(self) -> pulumi.Input[bool]:
        """
        Platform: Podman Status: Released Operating system: Linux Min agent version: 1.267
        """
        return pulumi.get(self, "podman")

    @podman.setter
    def podman(self, value: pulumi.Input[bool]):
        pulumi.set(self, "podman", value)

    @property
    @pulumi.getter
    def winc(self) -> pulumi.Input[bool]:
        """
        Platform: Cloud Foundry Status: Early adopter Operating system: Windows Min agent version: 1.175
        """
        return pulumi.get(self, "winc")

    @winc.setter
    def winc(self, value: pulumi.Input[bool]):
        pulumi.set(self, "winc", value)

    @property
    @pulumi.getter
    def scope(self) -> Optional[pulumi.Input[str]]:
        """
        The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        """
        return pulumi.get(self, "scope")

    @scope.setter
    def scope(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "scope", value)


@pulumi.input_type
class _ContainerTechnologyState:
    def __init__(__self__, *,
                 bosh_process_manager: Optional[pulumi.Input[bool]] = None,
                 containerd: Optional[pulumi.Input[bool]] = None,
                 crio: Optional[pulumi.Input[bool]] = None,
                 docker: Optional[pulumi.Input[bool]] = None,
                 docker_windows: Optional[pulumi.Input[bool]] = None,
                 garden: Optional[pulumi.Input[bool]] = None,
                 podman: Optional[pulumi.Input[bool]] = None,
                 scope: Optional[pulumi.Input[str]] = None,
                 winc: Optional[pulumi.Input[bool]] = None):
        """
        Input properties used for looking up and filtering ContainerTechnology resources.
        :param pulumi.Input[bool] bosh_process_manager: Platform: Cloud Foundry
        :param pulumi.Input[bool] containerd: Platform: Kubernetes Status: Released Operating system: Linux Min agent version: 1.169
        :param pulumi.Input[bool] crio: Platform: Kubernetes Status: Released Operating system: Linux Min agent version: 1.163
        :param pulumi.Input[bool] docker: Platform: Docker and Kubernetes Status: Released Operating system: Linux
        :param pulumi.Input[bool] docker_windows: Platform: Docker Status: Early adopter Operating system: Windows Min agent version: 1.149
        :param pulumi.Input[bool] garden: Platform: Cloud Foundry Status: Released Operating system: Linux Min agent version: 1.133
        :param pulumi.Input[bool] podman: Platform: Podman Status: Released Operating system: Linux Min agent version: 1.267
        :param pulumi.Input[str] scope: The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        :param pulumi.Input[bool] winc: Platform: Cloud Foundry Status: Early adopter Operating system: Windows Min agent version: 1.175
        """
        if bosh_process_manager is not None:
            pulumi.set(__self__, "bosh_process_manager", bosh_process_manager)
        if containerd is not None:
            pulumi.set(__self__, "containerd", containerd)
        if crio is not None:
            pulumi.set(__self__, "crio", crio)
        if docker is not None:
            pulumi.set(__self__, "docker", docker)
        if docker_windows is not None:
            pulumi.set(__self__, "docker_windows", docker_windows)
        if garden is not None:
            pulumi.set(__self__, "garden", garden)
        if podman is not None:
            pulumi.set(__self__, "podman", podman)
        if scope is not None:
            pulumi.set(__self__, "scope", scope)
        if winc is not None:
            pulumi.set(__self__, "winc", winc)

    @property
    @pulumi.getter(name="boshProcessManager")
    def bosh_process_manager(self) -> Optional[pulumi.Input[bool]]:
        """
        Platform: Cloud Foundry
        """
        return pulumi.get(self, "bosh_process_manager")

    @bosh_process_manager.setter
    def bosh_process_manager(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "bosh_process_manager", value)

    @property
    @pulumi.getter
    def containerd(self) -> Optional[pulumi.Input[bool]]:
        """
        Platform: Kubernetes Status: Released Operating system: Linux Min agent version: 1.169
        """
        return pulumi.get(self, "containerd")

    @containerd.setter
    def containerd(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "containerd", value)

    @property
    @pulumi.getter
    def crio(self) -> Optional[pulumi.Input[bool]]:
        """
        Platform: Kubernetes Status: Released Operating system: Linux Min agent version: 1.163
        """
        return pulumi.get(self, "crio")

    @crio.setter
    def crio(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "crio", value)

    @property
    @pulumi.getter
    def docker(self) -> Optional[pulumi.Input[bool]]:
        """
        Platform: Docker and Kubernetes Status: Released Operating system: Linux
        """
        return pulumi.get(self, "docker")

    @docker.setter
    def docker(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "docker", value)

    @property
    @pulumi.getter(name="dockerWindows")
    def docker_windows(self) -> Optional[pulumi.Input[bool]]:
        """
        Platform: Docker Status: Early adopter Operating system: Windows Min agent version: 1.149
        """
        return pulumi.get(self, "docker_windows")

    @docker_windows.setter
    def docker_windows(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "docker_windows", value)

    @property
    @pulumi.getter
    def garden(self) -> Optional[pulumi.Input[bool]]:
        """
        Platform: Cloud Foundry Status: Released Operating system: Linux Min agent version: 1.133
        """
        return pulumi.get(self, "garden")

    @garden.setter
    def garden(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "garden", value)

    @property
    @pulumi.getter
    def podman(self) -> Optional[pulumi.Input[bool]]:
        """
        Platform: Podman Status: Released Operating system: Linux Min agent version: 1.267
        """
        return pulumi.get(self, "podman")

    @podman.setter
    def podman(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "podman", value)

    @property
    @pulumi.getter
    def scope(self) -> Optional[pulumi.Input[str]]:
        """
        The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        """
        return pulumi.get(self, "scope")

    @scope.setter
    def scope(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "scope", value)

    @property
    @pulumi.getter
    def winc(self) -> Optional[pulumi.Input[bool]]:
        """
        Platform: Cloud Foundry Status: Early adopter Operating system: Windows Min agent version: 1.175
        """
        return pulumi.get(self, "winc")

    @winc.setter
    def winc(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "winc", value)


class ContainerTechnology(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 bosh_process_manager: Optional[pulumi.Input[bool]] = None,
                 containerd: Optional[pulumi.Input[bool]] = None,
                 crio: Optional[pulumi.Input[bool]] = None,
                 docker: Optional[pulumi.Input[bool]] = None,
                 docker_windows: Optional[pulumi.Input[bool]] = None,
                 garden: Optional[pulumi.Input[bool]] = None,
                 podman: Optional[pulumi.Input[bool]] = None,
                 scope: Optional[pulumi.Input[str]] = None,
                 winc: Optional[pulumi.Input[bool]] = None,
                 __props__=None):
        """
        Create a ContainerTechnology resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] bosh_process_manager: Platform: Cloud Foundry
        :param pulumi.Input[bool] containerd: Platform: Kubernetes Status: Released Operating system: Linux Min agent version: 1.169
        :param pulumi.Input[bool] crio: Platform: Kubernetes Status: Released Operating system: Linux Min agent version: 1.163
        :param pulumi.Input[bool] docker: Platform: Docker and Kubernetes Status: Released Operating system: Linux
        :param pulumi.Input[bool] docker_windows: Platform: Docker Status: Early adopter Operating system: Windows Min agent version: 1.149
        :param pulumi.Input[bool] garden: Platform: Cloud Foundry Status: Released Operating system: Linux Min agent version: 1.133
        :param pulumi.Input[bool] podman: Platform: Podman Status: Released Operating system: Linux Min agent version: 1.267
        :param pulumi.Input[str] scope: The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        :param pulumi.Input[bool] winc: Platform: Cloud Foundry Status: Early adopter Operating system: Windows Min agent version: 1.175
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ContainerTechnologyArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a ContainerTechnology resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param ContainerTechnologyArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ContainerTechnologyArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 bosh_process_manager: Optional[pulumi.Input[bool]] = None,
                 containerd: Optional[pulumi.Input[bool]] = None,
                 crio: Optional[pulumi.Input[bool]] = None,
                 docker: Optional[pulumi.Input[bool]] = None,
                 docker_windows: Optional[pulumi.Input[bool]] = None,
                 garden: Optional[pulumi.Input[bool]] = None,
                 podman: Optional[pulumi.Input[bool]] = None,
                 scope: Optional[pulumi.Input[str]] = None,
                 winc: Optional[pulumi.Input[bool]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ContainerTechnologyArgs.__new__(ContainerTechnologyArgs)

            if bosh_process_manager is None and not opts.urn:
                raise TypeError("Missing required property 'bosh_process_manager'")
            __props__.__dict__["bosh_process_manager"] = bosh_process_manager
            if containerd is None and not opts.urn:
                raise TypeError("Missing required property 'containerd'")
            __props__.__dict__["containerd"] = containerd
            if crio is None and not opts.urn:
                raise TypeError("Missing required property 'crio'")
            __props__.__dict__["crio"] = crio
            if docker is None and not opts.urn:
                raise TypeError("Missing required property 'docker'")
            __props__.__dict__["docker"] = docker
            if docker_windows is None and not opts.urn:
                raise TypeError("Missing required property 'docker_windows'")
            __props__.__dict__["docker_windows"] = docker_windows
            if garden is None and not opts.urn:
                raise TypeError("Missing required property 'garden'")
            __props__.__dict__["garden"] = garden
            if podman is None and not opts.urn:
                raise TypeError("Missing required property 'podman'")
            __props__.__dict__["podman"] = podman
            __props__.__dict__["scope"] = scope
            if winc is None and not opts.urn:
                raise TypeError("Missing required property 'winc'")
            __props__.__dict__["winc"] = winc
        super(ContainerTechnology, __self__).__init__(
            'dynatrace:index/containerTechnology:ContainerTechnology',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            bosh_process_manager: Optional[pulumi.Input[bool]] = None,
            containerd: Optional[pulumi.Input[bool]] = None,
            crio: Optional[pulumi.Input[bool]] = None,
            docker: Optional[pulumi.Input[bool]] = None,
            docker_windows: Optional[pulumi.Input[bool]] = None,
            garden: Optional[pulumi.Input[bool]] = None,
            podman: Optional[pulumi.Input[bool]] = None,
            scope: Optional[pulumi.Input[str]] = None,
            winc: Optional[pulumi.Input[bool]] = None) -> 'ContainerTechnology':
        """
        Get an existing ContainerTechnology resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] bosh_process_manager: Platform: Cloud Foundry
        :param pulumi.Input[bool] containerd: Platform: Kubernetes Status: Released Operating system: Linux Min agent version: 1.169
        :param pulumi.Input[bool] crio: Platform: Kubernetes Status: Released Operating system: Linux Min agent version: 1.163
        :param pulumi.Input[bool] docker: Platform: Docker and Kubernetes Status: Released Operating system: Linux
        :param pulumi.Input[bool] docker_windows: Platform: Docker Status: Early adopter Operating system: Windows Min agent version: 1.149
        :param pulumi.Input[bool] garden: Platform: Cloud Foundry Status: Released Operating system: Linux Min agent version: 1.133
        :param pulumi.Input[bool] podman: Platform: Podman Status: Released Operating system: Linux Min agent version: 1.267
        :param pulumi.Input[str] scope: The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        :param pulumi.Input[bool] winc: Platform: Cloud Foundry Status: Early adopter Operating system: Windows Min agent version: 1.175
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ContainerTechnologyState.__new__(_ContainerTechnologyState)

        __props__.__dict__["bosh_process_manager"] = bosh_process_manager
        __props__.__dict__["containerd"] = containerd
        __props__.__dict__["crio"] = crio
        __props__.__dict__["docker"] = docker
        __props__.__dict__["docker_windows"] = docker_windows
        __props__.__dict__["garden"] = garden
        __props__.__dict__["podman"] = podman
        __props__.__dict__["scope"] = scope
        __props__.__dict__["winc"] = winc
        return ContainerTechnology(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="boshProcessManager")
    def bosh_process_manager(self) -> pulumi.Output[bool]:
        """
        Platform: Cloud Foundry
        """
        return pulumi.get(self, "bosh_process_manager")

    @property
    @pulumi.getter
    def containerd(self) -> pulumi.Output[bool]:
        """
        Platform: Kubernetes Status: Released Operating system: Linux Min agent version: 1.169
        """
        return pulumi.get(self, "containerd")

    @property
    @pulumi.getter
    def crio(self) -> pulumi.Output[bool]:
        """
        Platform: Kubernetes Status: Released Operating system: Linux Min agent version: 1.163
        """
        return pulumi.get(self, "crio")

    @property
    @pulumi.getter
    def docker(self) -> pulumi.Output[bool]:
        """
        Platform: Docker and Kubernetes Status: Released Operating system: Linux
        """
        return pulumi.get(self, "docker")

    @property
    @pulumi.getter(name="dockerWindows")
    def docker_windows(self) -> pulumi.Output[bool]:
        """
        Platform: Docker Status: Early adopter Operating system: Windows Min agent version: 1.149
        """
        return pulumi.get(self, "docker_windows")

    @property
    @pulumi.getter
    def garden(self) -> pulumi.Output[bool]:
        """
        Platform: Cloud Foundry Status: Released Operating system: Linux Min agent version: 1.133
        """
        return pulumi.get(self, "garden")

    @property
    @pulumi.getter
    def podman(self) -> pulumi.Output[bool]:
        """
        Platform: Podman Status: Released Operating system: Linux Min agent version: 1.267
        """
        return pulumi.get(self, "podman")

    @property
    @pulumi.getter
    def scope(self) -> pulumi.Output[Optional[str]]:
        """
        The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        """
        return pulumi.get(self, "scope")

    @property
    @pulumi.getter
    def winc(self) -> pulumi.Output[bool]:
        """
        Platform: Cloud Foundry Status: Early adopter Operating system: Windows Min agent version: 1.175
        """
        return pulumi.get(self, "winc")

