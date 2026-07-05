### AwsServiceType
AwsServiceType identifies whether an AWS account is onboarded for BaaS
(RSC-managed) or non-BaaS (self-managed). Defined locally to avoid
importing the cloudaccounts proto, which would close a circular build
dependency through am-service and common-go/events.

- AWS_SERVICE_TYPE_UNSPECIFIED - Unspecified AWS deployment model; treated as no filter.
- AWS_SERVICE_TYPE_BAAS - BaaS (RSC-managed) AWS workloads.
- AWS_SERVICE_TYPE_NON_BAAS - Non-BaaS (self-managed) AWS workloads.
