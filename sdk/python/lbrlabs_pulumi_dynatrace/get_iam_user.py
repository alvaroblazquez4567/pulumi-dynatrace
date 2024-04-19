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
    'GetIamUserResult',
    'AwaitableGetIamUserResult',
    'get_iam_user',
    'get_iam_user_output',
]

@pulumi.output_type
class GetIamUserResult:
    """
    A collection of values returned by getIamUser.
    """
    def __init__(__self__, email=None, groups=None, id=None, uid=None):
        if email and not isinstance(email, str):
            raise TypeError("Expected argument 'email' to be a str")
        pulumi.set(__self__, "email", email)
        if groups and not isinstance(groups, list):
            raise TypeError("Expected argument 'groups' to be a list")
        pulumi.set(__self__, "groups", groups)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if uid and not isinstance(uid, str):
            raise TypeError("Expected argument 'uid' to be a str")
        pulumi.set(__self__, "uid", uid)

    @property
    @pulumi.getter
    def email(self) -> str:
        return pulumi.get(self, "email")

    @property
    @pulumi.getter
    def groups(self) -> Sequence[str]:
        return pulumi.get(self, "groups")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def uid(self) -> str:
        return pulumi.get(self, "uid")


class AwaitableGetIamUserResult(GetIamUserResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetIamUserResult(
            email=self.email,
            groups=self.groups,
            id=self.id,
            uid=self.uid)


def get_iam_user(email: Optional[str] = None,
                 opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetIamUserResult:
    """
    This data source allows you to specify the email address of the user and produces an ordered list of group IDs this user is a member of

    ## Example Usage

    ```python
    import pulumi
    import pulumi_dynatrace as dynatrace

    user_a = dynatrace.get_iam_user(email="me@home.com")
    pulumi.export("groups", user_a.groups)
    ```
    """
    __args__ = dict()
    __args__['email'] = email
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('dynatrace:index/getIamUser:getIamUser', __args__, opts=opts, typ=GetIamUserResult).value

    return AwaitableGetIamUserResult(
        email=pulumi.get(__ret__, 'email'),
        groups=pulumi.get(__ret__, 'groups'),
        id=pulumi.get(__ret__, 'id'),
        uid=pulumi.get(__ret__, 'uid'))


@_utilities.lift_output_func(get_iam_user)
def get_iam_user_output(email: Optional[pulumi.Input[str]] = None,
                        opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetIamUserResult]:
    """
    This data source allows you to specify the email address of the user and produces an ordered list of group IDs this user is a member of

    ## Example Usage

    ```python
    import pulumi
    import pulumi_dynatrace as dynatrace

    user_a = dynatrace.get_iam_user(email="me@home.com")
    pulumi.export("groups", user_a.groups)
    ```
    """
    ...