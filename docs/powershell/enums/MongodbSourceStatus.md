### MongodbSourceStatus
Represents connection status of MongoDB source to Mosaic cluster.

- ADDING - Source is being added to nosql cluster. Onboarding tasks are in process and source is not confirmed yet.
- REFRESHING - Source is connected and metadata is being refreshed.
- CONNECTED - Source is connected.
- DISCONNECTED - Source is disconnected. This message is displayed when source is down or unreachable from nosql cluster.
- DELETING - Source is being removed from nosql cluster and cleanup activities are in process.
- DELETED - Source is deleted from nosql cluster and it will not be tracked.
- UNKNOWN_SYSTEM_STATUS - Represents error in displaying status. This status does not necessarily mean that something is wrong with the source.
