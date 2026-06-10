### NetworkRuleSet
NetworkRuleSet defines network rules for Azure storage account.

- defaultAction: DefaultActionType
  - Specifies the default action of allow or deny when no other rules match.
Possible values include: 'DefaultActionAllow', 'DefaultActionDeny'
- ipRules: list of IpRules
  - Specifies the IP ACL rules.
