### SigninConditionDetails
SigninConditionDetails carries the condition-specific details for a sign-in
anomaly violation. The oneof allows future sign-in anomaly conditions to add
their own details messages without schema changes.

- perCapSpike: PerCapSpikeDetails
  - Per-CAP sign-in failure spike details.
