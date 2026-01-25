# New-RscMutationPolicy
## Subcommands
### addpolicyobjects
Add policies to objects.

- There are 4 arguments.
    - policyIds - list of System.Strings
    - objectIds - list of System.Strings
    - objectRootIds - list of System.Strings: List of supported root IDs.
    - clusterIds - list of System.Strings: List of Rubrik cluster IDs.
- Returns System.String.
### createpolicy
Create a classification policy.

- There is a single argument of type CreatePolicyInput.
- Returns ClassificationPolicyDetail.
### createtprpolicy
Create a TPR policy.

- There is a single argument of type CreateTprPolicyInput.
- Returns CreateTprPolicyReply.
### deactivatepolicy
Deactivate a classification policy.

- There are 2 arguments.
    - policyId - System.String
    - runAsync - System.Boolean
- Returns list of System.Strings.
### deletetprpolicy
Delete a TPR policy.

- There is a single argument of type DeleteTprPolicyInput.
- Returns System.String.
### failoverhapolicy
Failover a failover group

Supported in v9.5
Starts an asynchronous request to failover a failover group when issued to a secondary cluster.

- There is a single argument of type FailoverHaPolicyInput.
- Returns AsyncRequestStatus.
### gethealthmonitorpolicystatus
Get health monitor policies on the Rubrik cluster.

- There is a single argument of type GetHealthMonitorPolicyStatusInput.
- Returns GetHealthMonitorPolicyStatusReply.
### removepolicyobjects
Remove policies from objects.

- There are 5 arguments.
    - policyIds - list of System.Strings
    - objectIds - list of System.Strings
    - objectRootIds - list of System.Strings: List of supported root IDs.
    - clusterIds - list of System.Strings: List of Rubrik cluster IDs.
    - runAsync - System.Boolean
- Returns list of System.Strings.
### seedenabledpolicies
Seed account with enabled policies.

- The seedenabledpolicies subcommand takes no arguments.
- Returns SeedEnabledPoliciesReply.
### seedinitialpolicies
DEPRECATED (use seedEnabledPolicies instead) Seed account with initial policies.

- The seedinitialpolicies subcommand takes no arguments.
- Returns SeedInitialPoliciesReply.
### setairpolicyalertstatus
Set policy alert status.

- There is a single argument of type SetAirPolicyAlertStatusInput.
- Returns SetAirPolicyAlertStatusReply.
### setpasswordcomplexitypolicy
Set the password complexity policy for the current organization.

- There is a single argument of type SetPasswordComplexityPolicyInput.
- Returns System.String.
### updateautoenablepolicyclusterconfig
Update Rubrik cluster configuration to enable or not enable the Auto-enabled Data Discovery Policies feature.

- There is a single argument of type UpdateAutoEnablePolicyClusterConfigInput.
- Returns UpdateAutoEnablePolicyClusterConfigReply.
### updatehealthmonitorpolicystatus
Run health monitor policies on the CDM cluster.

- There is a single argument of type UpdateHealthMonitorPolicyStatusInput.
- Returns UpdateHealthMonitorPolicyStatusReply.
### updateorgsecuritypolicy
Update organization security policy.

- There is a single argument of type UpdateOrgSecurityPolicyInput.
- Returns System.String.
### updatepolicy
Update a classification policy.

- There is a single argument of type UpdatePolicyInput.
- Returns ClassificationPolicyDetail.
### updatetprpolicy
Update a TPR policy.

- There is a single argument of type UpdateTprPolicyInput.
- Returns System.String.
