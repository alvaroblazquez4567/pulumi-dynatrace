import * as pulumi from "@pulumi/pulumi";
import {FailureDetectionParameters, FailureDetectionParametersArgs} from "@alvaroblazquez4567/pulumi-dynatrace";

const failureDetectionConfig = {
    name: "myFailureDetection",
    description: "myFailureDetectionDescription",
    httpResponseCodes: {
      clientSideErrors: "400-403,405-599",
      serverSideErrors: "500-599",
    },
    managementZones: ["myManagementZone"]
  }

const failureDetectionParametersArgs: FailureDetectionParametersArgs = {
    name: `test-parameters`,
    description: 'test-description',
    httpResponseCodes: {
      clientSideErrors: failureDetectionConfig.httpResponseCodes.clientSideErrors,
      serverSideErrors: failureDetectionConfig.httpResponseCodes.serverSideErrors,
      failOnMissingResponseCodeClientSide: false,
      failOnMissingResponseCodeServerSide: false
    },
    brokenLinks: {
      http404NotFoundFailures: false
    },
    exceptionRules: {
      ignoreAllExceptions: false,
      ignoreSpanFailureDetection: false
    }
  }
  new FailureDetectionParameters(failureDetectionConfig.name, failureDetectionParametersArgs);