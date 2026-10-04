### ActorType
Represents the kind of actor that triggered the audit.

- ACTOR_TYPE_UNSPECIFIED - Actor could not be classified.
- SERVICE_ACCOUNT - Action performed by a service account (typically a JWT subject prefixed with "client|").
- HUMAN_USER - Action performed by a human user via a session-authenticated request.
- PERSONAL_ACCESS_TOKEN - Action performed via a Personal Access Token.
- RUBRIK_AI - Action performed by Rubrik AI on behalf of a user.
- AUTOMATION - Action performed by an automated system task (e.g. a korg job) with no human user session.
