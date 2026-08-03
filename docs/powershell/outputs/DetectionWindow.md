### DetectionWindow
DetectionWindow carries the timing fields shared by every anomaly
violation_details message. Persisted on the violation_details blob; read by
the anomaly dedup helper and surfaced in the Overview tab.

Relocated from policyengine_common.proto into this dedicated anomaly-common
file so anomaly-specific protos (e.g. policyengine_signin_anomaly.proto) can
import DetectionWindow without forming a common -> signin -> common import
cycle. Same Go package (rubrik/policyengine/proto), so Go consumers are
unaffected by the relocation.

- firstObservedWindowStart: DateTime
  - First time the spike that opened this violation was observed. Pinned
across dedup UPDATEs.
- windowStart: DateTime
  - Sliding-window start for the most recent observation.
- windowEnd: DateTime
  - Sliding-window end for the most recent observation. This is the violation's
last-seen: it advances on every extend and is surfaced as
SigninAnomalyMetadata.last_seen (there is no separate last-seen field or
DB column).
- threshold: System.Int64
  - Configured detection threshold (event count or rate) that this
observation crossed to fire the violation. Not the observed count.
