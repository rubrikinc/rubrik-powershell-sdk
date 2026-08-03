### SigninAnomalyViolationDetails
SigninAnomalyViolationDetails is the violation_details payload for
POLICY_TYPE_SIGNIN_ANOMALY violations.

No denormalized domain_name/tenant_id is carried here -- CAPs are principals
keyed by cap_id, so alert-list hydration resolves the chip (name/type/domain)
via the existing principalMap path.

- detectionWindow: DetectionWindow
  - Timing fields for the most recent observation that fired/extended this
violation.
- conditionDetails: SigninConditionDetails
  - Condition-specific details (e.g. per-CAP spike).
- idpType: IdpType
  - IDP type of the subject (always ENTRA_ID for P0). Denormalized onto the
violation_details blob so the read-path idpTypes filter can match sign-in
violations via JSON_EXTRACT on $.signinAnomalyViolationDetails.idpType,
mirroring how IdentityViolationDetails exposes idp_type. This is distinct
from SigninAnomalyPolicyInfo.idp_type, which is the policy's configured
scope.
