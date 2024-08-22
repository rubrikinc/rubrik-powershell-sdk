# New-RscMutationMongo
## Subcommands
### addsource
Add a new MongoDB source

Supported in v8.1+
Adds a new MongoDB source to the Rubrik Cluster.

- There is a single argument of type AddMongoSourceInput.
- Returns AddMongoSourceReply.
### deletesource
Delete a MongoDB source

Supported in v8.1+
Deletes a specific MongoDB source.

- There is a single argument of type DeleteMongoSourceInput.
- Returns AsyncRequestStatus.
### discoversource
Discover a MongoDB source on-demand

Supported in v8.1+
Initiates an on-demand job to discover a MongoDB source.

- There is a single argument of type DiscoverMongoSourceInput.
- Returns AsyncRequestStatus.
### patchsource
Edit a MongoDB source

Supported in v8.1+
Edits the properties of a MongoDB source. Hosts, name, and type of MongoDB cannot be changed once added.

- There is a single argument of type PatchMongoSourceInput.
- Returns AsyncRequestStatus.
### recoversource
Recover a MongoDB source from Rubrik CDM cluster.

- There is a single argument of type RecoverMongoSourceInput.
- Returns AsyncRequestStatus.
### retryaddsource
Update a MongoDB source

Supported in v8.1+
Updates a MongoDB source details. You can use this endpoint for updating MongoDB source details when the request to add a source fails.

- There is a single argument of type RetryAddMongoSourceInput.
- Returns AsyncRequestStatus.
