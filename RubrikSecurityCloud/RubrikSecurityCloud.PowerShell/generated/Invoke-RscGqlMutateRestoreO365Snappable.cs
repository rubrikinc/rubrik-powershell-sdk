// Invoke-RscGqlMutateRestoreO365Snappable.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using GraphQL;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Invoke GraphQL Mutation restoreO365Snappable
    /// restoreO365Snappable(input: RestoreO365SnappableInput!): CreateOnDemandJobReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateRestoreO365Snappable")
    ]
    public class Invoke_RscGqlMutateRestoreO365Snappable : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("restoreO365Snappable");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation restoreO365Snappable
        /// restoreO365Snappable(input: RestoreO365SnappableInput!): CreateOnDemandJobReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_restoreO365Snappable();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_restoreO365Snappable()
        {
            this._logger.name += " -restoreO365Snappable";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreO365SnappableInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreO365Snappable",
                "($input: RestoreO365SnappableInput!)",
                "CreateOnDemandJobReply",
                Mutation.RestoreO365Snappable_ObjectFieldSpec,
                Mutation.RestoreO365SnappableFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snappableType = <SnappableType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableType]) for enum values.
	# REQUIRED
	sourceSnappableUuid = <System.String>
	# REQUIRED
	destinationSnappableUuid = <System.String>
	# REQUIRED
	restoreConfig = @{
		# OPTIONAL
		SharePointDriveRestoreConfig = @{
			# REQUIRED
			driveRestoreConfig = @{
				# REQUIRED
				filesToRestore = @(
					@{
						# REQUIRED
						fileId = <System.String>
						# REQUIRED
						fileName = <System.String>
						# REQUIRED
						fileSnapshotsToRestore = @(
							@{
								# REQUIRED
								snapshotId = <System.String>
								# REQUIRED
								snapshotNum = <System.Int32>
								# REQUIRED
								fileSize = <System.Int64>
							}
						)
						# OPTIONAL
						channelInfo = @{
							# REQUIRED
							TeamID = <System.String>
							# OPTIONAL
							ChannelID = <System.String>
							# OPTIONAL
							ChannelName = <System.String>
							# OPTIONAL
							ChannelFolderName = <System.String>
							# OPTIONAL
							ChannelNaturalId = <System.String>
							# REQUIRED
							channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
						}
					}
				)
				# REQUIRED
				foldersToRestore = @(
					@{
						# REQUIRED
						folderId = <System.String>
						# REQUIRED
						folderName = <System.String>
						# REQUIRED
						folderSize = <System.Int64>
						# REQUIRED
						snapshotId = <System.String>
						# REQUIRED
						snapshotNum = <System.Int32>
						# OPTIONAL
						channelInfo = @{
							# REQUIRED
							TeamID = <System.String>
							# OPTIONAL
							ChannelID = <System.String>
							# OPTIONAL
							ChannelName = <System.String>
							# OPTIONAL
							ChannelFolderName = <System.String>
							# OPTIONAL
							ChannelNaturalId = <System.String>
							# REQUIRED
							channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
						}
					}
				)
				# REQUIRED
				restoreFolderPath = <System.String>
			}
			# OPTIONAL
			docLibName = <System.String>
			# OPTIONAL
			parentSiteUuid = <System.String>
		}
		# OPTIONAL
		sharePointListRestoreConfig = @{
			# REQUIRED
			itemsToRestore = @(
				@{
					# REQUIRED
					itemId = <System.String>
					# REQUIRED
					itemName = <System.String>
					# REQUIRED
					itemSnapshotsToRestore = @(
						@{
							# REQUIRED
							snapshotId = <System.String>
							# REQUIRED
							snapshotNum = <System.Int32>
						}
					)
				}
			)
			# REQUIRED
			foldersToRestore = @(
				@{
					# REQUIRED
					folderId = <System.String>
					# REQUIRED
					folderName = <System.String>
					# REQUIRED
					folderSize = <System.Int64>
					# REQUIRED
					snapshotId = <System.String>
					# REQUIRED
					snapshotNum = <System.Int32>
					# OPTIONAL
					channelInfo = @{
						# REQUIRED
						TeamID = <System.String>
						# OPTIONAL
						ChannelID = <System.String>
						# OPTIONAL
						ChannelName = <System.String>
						# OPTIONAL
						ChannelFolderName = <System.String>
						# OPTIONAL
						ChannelNaturalId = <System.String>
						# REQUIRED
						channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
					}
				}
			)
			# REQUIRED
			restoreFolderPath = <System.String>
			# OPTIONAL
			listName = <System.String>
			# OPTIONAL
			parentSiteUuid = <System.String>
		}
		# OPTIONAL
		sharePointFullRestoreConfig = @{
			# OPTIONAL
			spObjectToRestore = @{
				# REQUIRED
				objectSharepointId = <System.String>
				# REQUIRED
				objectName = <System.String>
				# OPTIONAL
				objectType = <SnappableType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableType]) for enum values.
				# REQUIRED
				snapshotId = <System.String>
				# REQUIRED
				snapshotNum = <System.Int32>
			}
			# OPTIONAL
			spItemsToRestore = @{
				# REQUIRED
				sharepointId = <System.String>
				# OPTIONAL
				snappableType = <SnappableType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableType]) for enum values.
				# REQUIRED
				listItems = @(
					@{
						# REQUIRED
						itemId = <System.String>
						# REQUIRED
						itemName = <System.String>
						# REQUIRED
						itemSnapshotsToRestore = @(
							@{
								# REQUIRED
								snapshotId = <System.String>
								# REQUIRED
								snapshotNum = <System.Int32>
							}
						)
					}
				)
				# REQUIRED
				folderItems = @(
					@{
						# REQUIRED
						folderId = <System.String>
						# REQUIRED
						folderName = <System.String>
						# REQUIRED
						folderSize = <System.Int64>
						# REQUIRED
						snapshotId = <System.String>
						# REQUIRED
						snapshotNum = <System.Int32>
						# OPTIONAL
						channelInfo = @{
							# REQUIRED
							TeamID = <System.String>
							# OPTIONAL
							ChannelID = <System.String>
							# OPTIONAL
							ChannelName = <System.String>
							# OPTIONAL
							ChannelFolderName = <System.String>
							# OPTIONAL
							ChannelNaturalId = <System.String>
							# REQUIRED
							channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
						}
					}
				)
				# REQUIRED
				fileItems = @(
					@{
						# REQUIRED
						fileId = <System.String>
						# REQUIRED
						fileName = <System.String>
						# REQUIRED
						fileSnapshotsToRestore = @(
							@{
								# REQUIRED
								snapshotId = <System.String>
								# REQUIRED
								snapshotNum = <System.Int32>
								# REQUIRED
								fileSize = <System.Int64>
							}
						)
						# OPTIONAL
						channelInfo = @{
							# REQUIRED
							TeamID = <System.String>
							# OPTIONAL
							ChannelID = <System.String>
							# OPTIONAL
							ChannelName = <System.String>
							# OPTIONAL
							ChannelFolderName = <System.String>
							# OPTIONAL
							ChannelNaturalId = <System.String>
							# REQUIRED
							channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
						}
					}
				)
				# REQUIRED
				arePageLibraryItems = <System.Boolean>
			}
			# OPTIONAL
			targetObjectUuid = <System.String>
			# OPTIONAL
			targetObjectType = <SnappableType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableType]) for enum values.
			# REQUIRED
			shouldCreateNewObject = <System.Boolean>
			# OPTIONAL
			newObjectType = <SnappableType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableType]) for enum values.
			# OPTIONAL
			newObjectName = <System.String>
		}
		# OPTIONAL
		OneDriveRestoreConfig = @{
			# REQUIRED
			filesToRestore = @(
				@{
					# REQUIRED
					fileId = <System.String>
					# REQUIRED
					fileName = <System.String>
					# REQUIRED
					fileSnapshotsToRestore = @(
						@{
							# REQUIRED
							snapshotId = <System.String>
							# REQUIRED
							snapshotNum = <System.Int32>
							# REQUIRED
							fileSize = <System.Int64>
						}
					)
					# OPTIONAL
					channelInfo = @{
						# REQUIRED
						TeamID = <System.String>
						# OPTIONAL
						ChannelID = <System.String>
						# OPTIONAL
						ChannelName = <System.String>
						# OPTIONAL
						ChannelFolderName = <System.String>
						# OPTIONAL
						ChannelNaturalId = <System.String>
						# REQUIRED
						channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
					}
				}
			)
			# REQUIRED
			foldersToRestore = @(
				@{
					# REQUIRED
					folderId = <System.String>
					# REQUIRED
					folderName = <System.String>
					# REQUIRED
					folderSize = <System.Int64>
					# REQUIRED
					snapshotId = <System.String>
					# REQUIRED
					snapshotNum = <System.Int32>
					# OPTIONAL
					channelInfo = @{
						# REQUIRED
						TeamID = <System.String>
						# OPTIONAL
						ChannelID = <System.String>
						# OPTIONAL
						ChannelName = <System.String>
						# OPTIONAL
						ChannelFolderName = <System.String>
						# OPTIONAL
						ChannelNaturalId = <System.String>
						# REQUIRED
						channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
					}
				}
			)
			# REQUIRED
			restoreFolderPath = <System.String>
		}
		# OPTIONAL
		TeamsRestoreConfig = @{
			# OPTIONAL
			filesRestoreConfig = @{
				# REQUIRED
				filesToRestore = @(
					@{
						# REQUIRED
						fileId = <System.String>
						# REQUIRED
						fileName = <System.String>
						# REQUIRED
						fileSnapshotsToRestore = @(
							@{
								# REQUIRED
								snapshotId = <System.String>
								# REQUIRED
								snapshotNum = <System.Int32>
								# REQUIRED
								fileSize = <System.Int64>
							}
						)
						# OPTIONAL
						channelInfo = @{
							# REQUIRED
							TeamID = <System.String>
							# OPTIONAL
							ChannelID = <System.String>
							# OPTIONAL
							ChannelName = <System.String>
							# OPTIONAL
							ChannelFolderName = <System.String>
							# OPTIONAL
							ChannelNaturalId = <System.String>
							# REQUIRED
							channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
						}
					}
				)
				# REQUIRED
				foldersToRestore = @(
					@{
						# REQUIRED
						folderId = <System.String>
						# REQUIRED
						folderName = <System.String>
						# REQUIRED
						folderSize = <System.Int64>
						# REQUIRED
						snapshotId = <System.String>
						# REQUIRED
						snapshotNum = <System.Int32>
						# OPTIONAL
						channelInfo = @{
							# REQUIRED
							TeamID = <System.String>
							# OPTIONAL
							ChannelID = <System.String>
							# OPTIONAL
							ChannelName = <System.String>
							# OPTIONAL
							ChannelFolderName = <System.String>
							# OPTIONAL
							ChannelNaturalId = <System.String>
							# REQUIRED
							channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
						}
					}
				)
				# REQUIRED
				restoreFolderPath = <System.String>
			}
			# OPTIONAL
			conversationsRestoreConfig = @{
				# OPTIONAL
				SearchFilter = @{
					# OPTIONAL
					PostedTime = @{
						# OPTIONAL
						FromTime = <System.Int64>
						# OPTIONAL
						UntilTime = <System.Int64>
					}
					# OPTIONAL
					PostedBy = <System.String>
					# OPTIONAL
					SnapshotId = <System.String>
				}
				# OPTIONAL
				ChannelInfoForFullRestore = @{
					# REQUIRED
					TeamID = <System.String>
					# OPTIONAL
					ChannelID = <System.String>
					# OPTIONAL
					ChannelName = <System.String>
					# OPTIONAL
					ChannelFolderName = <System.String>
					# OPTIONAL
					ChannelFolderId = <System.String>
					# OPTIONAL
					ChannelNaturalId = <System.String>
				}
				# REQUIRED
				RefreshTokenEncrypted = <System.String>
				# REQUIRED
				O365AppID = <System.String>
				# REQUIRED
				ChannelsToRestore = @(
					@{
						# REQUIRED
						TeamID = <System.String>
						# OPTIONAL
						ChannelID = <System.String>
						# OPTIONAL
						ChannelName = <System.String>
						# OPTIONAL
						ChannelFolderName = <System.String>
						# OPTIONAL
						ChannelFolderId = <System.String>
						# OPTIONAL
						ChannelNaturalId = <System.String>
					}
				)
				# REQUIRED
				ShouldRestoreFileAttachments = <System.Boolean>
			}
			# OPTIONAL
			destChannelInfo = @{
				# REQUIRED
				TeamID = <System.String>
				# OPTIONAL
				ChannelID = <System.String>
				# OPTIONAL
				ChannelName = <System.String>
				# OPTIONAL
				ChannelFolderName = <System.String>
				# OPTIONAL
				ChannelNaturalId = <System.String>
				# REQUIRED
				channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
			}
			# REQUIRED
			shouldCreateDestChannel = <System.Boolean>
			# REQUIRED
			channelType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
			# REQUIRED
			restoreLatestPermissions = <System.Boolean>
			# REQUIRED
			snapshotSequenceNum = <System.Int32>
		}
		# OPTIONAL
		MailboxRestoreConfig = @{
			# OPTIONAL
			SnapshotUUID = <System.String>
			# REQUIRED
			RestoreConfigs = @(
				@{
					# REQUIRED
					SnapshotUUID = <System.String>
					# OPTIONAL
					EmailID = <System.String>
					# OPTIONAL
					FolderID = <System.String>
				}
			)
		}
		# OPTIONAL
		calendarRestoreConfig = @{
			# REQUIRED
			eventsToRestore = @(
				@{
					# REQUIRED
					eventId = <System.String>
					# REQUIRED
					snapshotId = <System.String>
				}
			)
			# REQUIRED
			calendarsToRestore = @(
				@{
					# REQUIRED
					calendarId = <System.String>
					# REQUIRED
					snapshotId = <System.String>
				}
			)
			# REQUIRED
			calendarGroupsToRestore = @(
				@{
					# REQUIRED
					calendarGroupId = <System.String>
					# REQUIRED
					snapshotId = <System.String>
				}
			)
		}
		# OPTIONAL
		contactsRestoreConfig = @{
			# REQUIRED
			contactsToRestore = @(
				@{
					# REQUIRED
					contactId = <System.String>
					# REQUIRED
					snapshotId = <System.String>
					# REQUIRED
					snapshotNum = <System.Int32>
				}
			)
			# REQUIRED
			contactFoldersToRestore = @(
				@{
					# REQUIRED
					contactFolderId = <System.String>
					# REQUIRED
					snapshotId = <System.String>
					# REQUIRED
					snapshotNum = <System.Int32>
				}
			)
		}
	}
	# REQUIRED
	actionType = <O365RestoreActionType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365RestoreActionType]) for enum values.
}"
            );
        }

    } // class Invoke-RscGqlMutateRestoreO365Snappable
}