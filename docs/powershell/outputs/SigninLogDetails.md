### SigninLogDetails
Detailed sign-in log information.

- eventId: System.String
  - Unique identifier for the sign-in event.
- provider: EventProvider
  - The identity provider.
- eventType: System.String
  - The type of sign-in event.
- eventTitle: System.String
  - Human-readable title for the event.
- tenantId: System.String
  - The tenant ID from the identity provider.
- correlationId: System.String
  - Correlation ID for tracking related events.
- sessionId: System.String
  - Session ID for the sign-in session.
- actorId: System.String
  - Actor information.
The actor's unique ID.
- actorSid: System.String
  - The actor's SID (for on-prem AD).
- actorPrincipalName: System.String
  - The actor's principal name (email or UPN).
- actorDisplayName: System.String
  - The actor's display name.
- actorDomain: System.String
  - The actor's domain.
- actorUserType: System.String
  - The actor's user type.
- targetId: System.String
  - Target information.
The target's unique ID.
- targetSid: System.String
  - The target's SID (for on-prem AD).
- targetPrincipalName: System.String
  - The target's principal name.
- targetDisplayName: System.String
  - The target's display name.
- targetDomain: System.String
  - The target's domain.
- authenticationPackage: System.String
  - Authentication details.
The authentication package used.
- authenticationMethod: System.String
  - The authentication method used.
- logonType: System.Int64
  - The logon type (numeric code).
- logonTypeDescription: System.String
  - Description of the logon type.
- processName: System.String
  - The process name that initiated the logon.
- mfaStatus: System.String
  - MFA information.
MFA status: SATISFIED, REQUIRED, NOT_REQUIRED.
- mfaMethod: System.String
  - The MFA method used.
- applicationId: System.String
  - Application information.
The application ID accessed.
- applicationName: System.String
  - The application name accessed.
- resourceId: System.String
  - The resource ID accessed.
- resourceName: System.String
  - The resource name accessed.
- result: SigninLogResult
  - Result information.
The result of the sign-in.
- resultReason: System.String
  - The reason for the result.
- errorCode: System.String
  - Error code if sign-in failed.
- ipAddress: System.String
  - Location information.
The IP address from which the sign-in occurred.
- city: System.String
  - The city from which the sign-in occurred.
- state: System.String
  - The state from which the sign-in occurred.
- country: System.String
  - The country from which the sign-in occurred.
- countryCode: System.String
  - The country code.
- deviceName: System.String
  - Device information.
The device name.
- deviceOs: System.String
  - The device operating system.
- riskLevel: SigninLogRiskLevel
  - Risk information.
The risk level.
- riskIndicators: System.String
  - JSON array of risk indicators.
- eventTimestamp: DateTime
  - Timestamps.
The timestamp when the event occurred.
- ingestionTimestamp: DateTime
  - The timestamp when the event was ingested.
- additionalData: System.String
  - Additional data.
Provider-specific metadata additional_data.
For EntraID: contains additionalDetails from Microsoft Graph signInStatus.
