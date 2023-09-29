# New-RscMutationReplication
## Subcommands
### createpair
Creates replication pairing between two Rubrik clusters.

- There is a single argument of type CreateReplicationPairInput.
- Returns System.String.
### deletepair
Deletes replication pairing between two Rubrik clusters.

- There is a single argument of type DeleteReplicationPairInput.
- Returns System.String.
### disablepause
A single Rubrik cluster can be the replication target for multiple source Rubrik clusters. For each source cluster specified, this resumes replication from that source cluster to the target cluster.

- There is a single argument of type DisableReplicationPauseInput.
- Returns ResponseSuccess.
### enablepause
A single Rubrik cluster can be the replication target for multiple source Rubrik clusters. For each source cluster specified, this pauses replication from that source cluster to the target cluster.

- There is a single argument of type EnablePerLocationPauseInputVariable.
- Returns ResponseSuccess.
### updatetarget
Update the setup information, address, username, and password for the replication target.

- There is a single argument of type UpdateReplicationTargetInput.
- Returns System.String.
