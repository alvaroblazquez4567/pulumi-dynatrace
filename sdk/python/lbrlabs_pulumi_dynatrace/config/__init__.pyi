# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

accountId: Optional[str]

automationClientId: Optional[str]

automationClientSecret: Optional[str]

automationEnvUrl: Optional[str]
"""
The URL of the Dynatrace Environment with Platform capabilities turned on (`https://#####.apps.dynatrace.com)`. This is
optional configuration when `dt_env_url` already specifies a SaaS Environment like `https://#####.live.dynatrace.com` or
`https://#####.apps.dynatrace.com`
"""

automationTokenUrl: Optional[str]
"""
The URL that provides the Bearer tokens when accessing the Automation REST API. This is optional configuration when
`dt_env_url` already specifies a SaaS Environment like `https://#####.live.dynatrace.com` or
`https://#####.apps.dynatrace.com`
"""

clientId: Optional[str]

clientSecret: Optional[str]

dtApiToken: Optional[str]

dtClusterApiToken: Optional[str]

dtClusterUrl: Optional[str]

dtEnvUrl: Optional[str]

iamAccountId: Optional[str]

iamClientId: Optional[str]

iamClientSecret: Optional[str]
