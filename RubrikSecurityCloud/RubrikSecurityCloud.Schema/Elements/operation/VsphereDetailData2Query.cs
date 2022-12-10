// This file is auto-generated, do not edit.
using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace Rubrik.SecurityCloud.Operations {
    public class VsphereDetailData2Query {
      /// <summary>
      /// VsphereDetailData2Query.Request 
      /// <para>Required variables:<br/> { fid=(any) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = VsphereDetailData2Document,
          OperationName = "VsphereDetailData2",
          Variables = variables
        };
      }

      
      public static string VsphereDetailData2Document = @"
        query VsphereDetailData2($fid: UUID!) {
          vSphereVmNew(fid: $fid) {
            ...VsphereVmFragment2
          }
        }
        fragment VsphereVmFragment2 on VsphereVm {
          cdmId
          isRelic
          guestOsName
          powerStatus
          vmwareToolsInstalled
          vsphereTagPath {
            fid
            name
            objectType
          }
          isBlueprintChild
          isActive
          blueprintName
          blueprintId
          isArrayIntegrationPossible
          parentWorkloadIdOpt
          parentWorkloadTypeOpt
          id
          vSphereMounts {
            count
          }
          vSphereLiveMounts {
            count
          }
          vsphereVirtualDisks {
            count
          }
          reportWorkload {
            id
            name
            complianceStatus
            protectionStatus
            objectType
            protectedOn
            totalSnapshots
            missedSnapshots
            lastSnapshot
            latestArchivalSnapshot
            latestReplicationSnapshot
            localOnDemandSnapshots
            localSlaSnapshots
            archivalSnapshotLag
            replicationSnapshotLag
            archivalComplianceStatus
            replicationComplianceStatus
            awaitingFirstFull
            pullTime
            location
            localStorage
            localMeteredData
            usedBytes
            provisionedBytes
            localProtectedData
            localEffectiveStorage
            lastSnapshotLogicalBytes
            orgId
            fid
            localSnapshots
            replicaSnapshots
            archiveSnapshots
            physicalBytes
            transferredBytes
            logicalBytes
            replicaStorage
            archiveStorage
            dataReduction
            logicalDataReduction
            orgName
          }
          agentStatus {
            agentStatus
            disconnectReason
          }
          arrayIntegrationEnabled
          guestCredentialAuthorizationStatus
          guestOsType
          protectionDate
          snapshotConsistencyMandate
          preBackupScript {
            scriptPath
            timeoutMs
            failureHandling
          }
          postBackupScript {
            scriptPath
            timeoutMs
            failureHandling
          }
          postSnapScript {
            scriptPath
            timeoutMs
            failureHandling
          }
          duplicatedVms {
            fid
            slaAssignment
          }
          cluster {
            id
            name
            defaultAddress
            systemStatus
            pauseStatus
            systemStatusMessage
            registrationTime
            lastConnectionTime
            productType
            version
            encryptionEnabled
            estimatedRunway
            snapshotCount
            type
            status
            subStatus
            timezone
            passesConnectivityCheck
            connectivityLastUpdated
            noSqlWorkloadCount
            licensedProducts
          }
          primaryClusterLocation {
            id
            createDate
            isActive
            isArchived
            type
            clusterUuid
            name
          }
          pendingSla {
            id
            name
            version
          }
          pendingObjectDeletionStatus {
            objectFid
            status
          }
          replicatedObjects {
            replicatedObjectCount
            authorizedOperations
            id
            name
            objectType
            slaAssignment
            slaPauseStatus
            numWorkloadDescendants
          }
          latestUserNote {
            time
            userName
            objectId
            userNote
          }
          replicatedObjectCount
          authorizedOperations
          name
          objectType
          slaAssignment
          effectiveSlaDomain {
            id
            name
            version
          }
          slaPauseStatus
          snapshotDistribution {
            totalCount
            scheduledCount
            onDemandCount
            retrievedCount
            id
          }
          effectiveRetentionSlaDomain {
            id
            name
            version
          }
          configuredSlaDomain {
            id
            name
            version
          }
          effectiveSlaSourceObject {
            fid
            name
            objectType
          }
          logicalPath {
            fid
            name
            objectType
          }
          physicalPath {
            fid
            name
            objectType
          }
          numWorkloadDescendants
          allOrgs {
            id
            name
            description
            fullName
            authDomainConfig
            shouldEnforceMfaForAll
            isEnvoyRequired
            allowedClusters
            physicalStorageUsed
            tenantNetworkHealth
            hasOwnIdpConfigured
            allUrls
          }
          cdmLink
          missedSnapshotConnection {
            count
          }
          newestSnapshot {
            id
            date
            expirationDate
            expiryHint
            isCorrupted
            indexingAttempts
            isIndexed
            isUnindexable
            isOnDemandSnapshot
            isRetentionLocked
            cdmId
            cdmVersion
            isDownloadedSnapshot
            isSapHanaIncrementalSnapshot
            resourceSpec
            fileCount
            isAnomaly
            isQuarantined
            hasDelta
            consistencyLevel
            hasImageConverted
            isExpired
            snappableId
          }
          oldestSnapshot {
            id
            date
            expirationDate
            expiryHint
            isCorrupted
            indexingAttempts
            isIndexed
            isUnindexable
            isOnDemandSnapshot
            isRetentionLocked
            cdmId
            cdmVersion
            isDownloadedSnapshot
            isSapHanaIncrementalSnapshot
            resourceSpec
            fileCount
            isAnomaly
            isQuarantined
            hasDelta
            consistencyLevel
            hasImageConverted
            isExpired
            snappableId
          }
          onDemandSnapshotCount
          newestArchivedSnapshot {
            id
            date
            expirationDate
            expiryHint
            isCorrupted
            indexingAttempts
            isIndexed
            isUnindexable
            isOnDemandSnapshot
            isRetentionLocked
            cdmId
            cdmVersion
            isDownloadedSnapshot
            isSapHanaIncrementalSnapshot
            resourceSpec
            fileCount
            isAnomaly
            isQuarantined
            hasDelta
            consistencyLevel
            hasImageConverted
            isExpired
            snappableId
          }
          newestReplicatedSnapshot {
            id
            date
            expirationDate
            expiryHint
            isCorrupted
            indexingAttempts
            isIndexed
            isUnindexable
            isOnDemandSnapshot
            isRetentionLocked
            cdmId
            cdmVersion
            isDownloadedSnapshot
            isSapHanaIncrementalSnapshot
            resourceSpec
            fileCount
            isAnomaly
            isQuarantined
            hasDelta
            consistencyLevel
            hasImageConverted
            isExpired
            snappableId
          }
        }";
      
    }
}
