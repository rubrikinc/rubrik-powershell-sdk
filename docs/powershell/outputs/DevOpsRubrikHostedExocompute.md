### DevOpsRubrikHostedExocompute
DevOpsRubrikHostedExocompute adds details specific to Rubrik hosted
exocompute.

- exocomputeClusterId: System.String
  - ID of the exocompute cluster.
- region: System.String
  - Region of the exocompute cluster.
- isProvisioned: System.Boolean
  - Whether all Rubrik-provisioned resources for this org are ready. True
when the exocompute cluster ID has been assigned, the Zeus lifecycle is
settled (not required or already provisioned), and a backup location ID
has been set.
