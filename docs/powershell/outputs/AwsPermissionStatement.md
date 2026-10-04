### AwsPermissionStatement
AWS IAM permission statement.

- actions: list of AwsActionWithUseCases
  - List of actions with use cases.
- resources: list of System.Strings
  - Resource ARNs or ARN patterns the statement applies to. Empty when the
statement carries no Resource element, which grants on the action alone.
- effect: System.String
  - Whether the statement allows or denies the actions. "Allow" or "Deny".
- conditionJson: System.String
  - The IAM Condition block gating the statement, serialized as JSON. Empty
when the statement is unconditioned. A conditioned statement grants far
less than its action list alone suggests, so consumers rendering the
actions must render this alongside them.
- iamRoleName: System.String
  - Name of the IAM role the statement is attached to. The same action can
appear on more than one role with a different scope on each, so this is
part of a statement's identity rather than a display detail.
