### RecoveryCommitStatus
Commit status of a recovery under DR Commit/Rollback.

- UNKNOWN - Recovery has not reached a commit decision (legacy / non-DR / pre-gate).
- COMMITTED - Every commit step succeeded.
- COMMIT_INCOMPLETE - The commit finalized the failover but left a user-fixable step incomplete.
