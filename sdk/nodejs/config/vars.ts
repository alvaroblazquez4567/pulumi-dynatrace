// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

declare var exports: any;
const __config = new pulumi.Config("dynatrace");

export declare const accountId: string | undefined;
Object.defineProperty(exports, "accountId", {
    get() {
        return __config.get("accountId");
    },
    enumerable: true,
});

export declare const automationClientId: string | undefined;
Object.defineProperty(exports, "automationClientId", {
    get() {
        return __config.get("automationClientId");
    },
    enumerable: true,
});

export declare const automationClientSecret: string | undefined;
Object.defineProperty(exports, "automationClientSecret", {
    get() {
        return __config.get("automationClientSecret");
    },
    enumerable: true,
});

/**
 * The URL of the Dynatrace Environment with Platform capabilities turned on (`https://#####.apps.dynatrace.com)`. This is
 * optional configuration when `dt_env_url` already specifies a SaaS Environment like `https://#####.live.dynatrace.com` or
 * `https://#####.apps.dynatrace.com`
 */
export declare const automationEnvUrl: string | undefined;
Object.defineProperty(exports, "automationEnvUrl", {
    get() {
        return __config.get("automationEnvUrl");
    },
    enumerable: true,
});

/**
 * The URL that provides the Bearer tokens when accessing the Automation REST API. This is optional configuration when
 * `dt_env_url` already specifies a SaaS Environment like `https://#####.live.dynatrace.com` or
 * `https://#####.apps.dynatrace.com`
 */
export declare const automationTokenUrl: string | undefined;
Object.defineProperty(exports, "automationTokenUrl", {
    get() {
        return __config.get("automationTokenUrl");
    },
    enumerable: true,
});

export declare const clientId: string | undefined;
Object.defineProperty(exports, "clientId", {
    get() {
        return __config.get("clientId");
    },
    enumerable: true,
});

export declare const clientSecret: string | undefined;
Object.defineProperty(exports, "clientSecret", {
    get() {
        return __config.get("clientSecret");
    },
    enumerable: true,
});

export declare const dtApiToken: string | undefined;
Object.defineProperty(exports, "dtApiToken", {
    get() {
        return __config.get("dtApiToken") ?? utilities.getEnv("DYNATRACE_API_TOKEN", "DT_API_TOKEN");
    },
    enumerable: true,
});

export declare const dtClusterApiToken: string | undefined;
Object.defineProperty(exports, "dtClusterApiToken", {
    get() {
        return __config.get("dtClusterApiToken") ?? utilities.getEnv("DYNATRACE_CLUSTER_API_TOKEN", "DT_CLUSTER_API_TOKEN");
    },
    enumerable: true,
});

export declare const dtClusterUrl: string | undefined;
Object.defineProperty(exports, "dtClusterUrl", {
    get() {
        return __config.get("dtClusterUrl") ?? utilities.getEnv("DYNATRACE_CLUSTER_URL", "DT_CLUSTER_URL");
    },
    enumerable: true,
});

export declare const dtEnvUrl: string | undefined;
Object.defineProperty(exports, "dtEnvUrl", {
    get() {
        return __config.get("dtEnvUrl") ?? utilities.getEnv("DYNATRACE_ENV_URL", "DT_ENV_URL");
    },
    enumerable: true,
});

export declare const iamAccountId: string | undefined;
Object.defineProperty(exports, "iamAccountId", {
    get() {
        return __config.get("iamAccountId");
    },
    enumerable: true,
});

export declare const iamClientId: string | undefined;
Object.defineProperty(exports, "iamClientId", {
    get() {
        return __config.get("iamClientId");
    },
    enumerable: true,
});

export declare const iamClientSecret: string | undefined;
Object.defineProperty(exports, "iamClientSecret", {
    get() {
        return __config.get("iamClientSecret");
    },
    enumerable: true,
});

