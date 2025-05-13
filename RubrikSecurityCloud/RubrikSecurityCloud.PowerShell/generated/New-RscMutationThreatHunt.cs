// New-RscMutationThreatHunt.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Create a new RscQuery object for any of the 5
    /// operations in the 'ThreatHunt' API domain:
    /// Cancel, Start, StartBulk, StartTurbo, or StartV2.
    /// </summary>
    /// <description>
    /// New-RscMutationThreatHunt creates a new
    /// mutation object for operations
    /// in the 'ThreatHunt' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 5 operations
    /// in the 'ThreatHunt' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: Cancel, Start, StartBulk, StartTurbo, or StartV2.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationThreatHunt -Cancel).Info().
    /// Each operation also has its own set of fields that can be
    /// selected for retrieval. If you do not specify any fields,
    /// a set of default fields will be selected. The selection is
    /// rule-based, and tries to select the most commonly used fields.
    /// For example if a field is named 'id' or 'name', 
    /// it will be selected. If you give -FieldProfile DETAIL, then
    /// another set of rules will be used to select more fields on top
    /// of the default fields. The set of rules for selecting fields
    /// is called a field profile. You can specify a field profile
    /// with the -FieldProfile parameter. You can add or remove fields
    /// from the field profile with the -AddField and -RemoveField
    /// parameters. If you end up with too many -AddField and -RemoveField
    /// parameters, you can list them in a text file, one per line,
    /// with a '+' or '-' prefix, and pass the file name to the
    /// -FilePatch parameter. Profiles and Patches are one way to
    /// customize the fields that are selected. Another way is to
    /// specify the fields by passing the -Field parameter an object
    /// that contains the fields you want to select as properties.
    /// Any property that is not null in that object is interpreted
    /// as a field to select
    /// (and the actual values they are set to do not matter).
    /// The [RubrikSecurityCloud.Types] namespace
    /// contains a set of classes that you can use to specify fields.
    /// To know what [RubrikSecurityCloud.Types] object to use
    /// for a specific operation,
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationThreatHunt -Cancel).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the Cancel operation
    /// of the 'ThreatHunt' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ThreatHunt
    /// # API Operation: Cancel
    /// 
    /// $query = New-RscMutationThreatHunt -Operation Cancel
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	huntId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Start operation
    /// of the 'ThreatHunt' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ThreatHunt
    /// # API Operation: Start
    /// 
    /// $query = New-RscMutationThreatHunt -Operation Start
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	notes = $someString
    /// 	# OPTIONAL
    /// 	fileScanCriteria = @{
    /// 		# OPTIONAL
    /// 		fileSizeLimits = @{
    /// 			# OPTIONAL
    /// 			maximumSizeInBytes = $someInt64
    /// 			# OPTIONAL
    /// 			minimumSizeInBytes = $someInt64
    /// 		}
    /// 		# OPTIONAL
    /// 		fileTimeLimits = @{
    /// 			# OPTIONAL
    /// 			earliestCreationTime = $someDateTime
    /// 			# OPTIONAL
    /// 			earliestModificationTime = $someDateTime
    /// 			# OPTIONAL
    /// 			latestCreationTime = $someDateTime
    /// 			# OPTIONAL
    /// 			latestModificationTime = $someDateTime
    /// 		}
    /// 		# OPTIONAL
    /// 		pathFilter = @{
    /// 			# OPTIONAL
    /// 			exceptions = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			excludes = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			includes = @(
    /// 				$someString
    /// 			)
    /// 		}
    /// 	}
    /// 	# REQUIRED
    /// 	indicatorsOfCompromise = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			threatFamily = $someString
    /// 			# REQUIRED
    /// 			iocKind = $someIndicatorOfCompromiseKind # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IndicatorOfCompromiseKind]) for enum values.
    /// 			# REQUIRED
    /// 			iocValue = $someString
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	maxMatchesPerSnapshot = $someInt
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	objectFids = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	requestedMatchDetails = @{
    /// 		# OPTIONAL
    /// 		requestedHashTypes = @(
    /// 			$someHashType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HashType]) for enum values.
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	shouldTrustFilesystemTimeInfo = $someBoolean
    /// 	# OPTIONAL
    /// 	snapshotScanLimit = @{
    /// 		# OPTIONAL
    /// 		endTime = $someDateTime
    /// 		# OPTIONAL
    /// 		maxSnapshotsPerObject = $someInt
    /// 		# OPTIONAL
    /// 		startTime = $someDateTime
    /// 		# OPTIONAL
    /// 		snapshotsToScanPerObject = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				id = $someString
    /// 				# REQUIRED
    /// 				snapshots = @(
    /// 					$someString
    /// 				)
    /// 			}
    /// 		)
    /// 	}
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: StartThreatHuntReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartBulk operation
    /// of the 'ThreatHunt' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ThreatHunt
    /// # API Operation: StartBulk
    /// 
    /// $query = New-RscMutationThreatHunt -Operation StartBulk
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	baseConfig = @{
    /// 		# OPTIONAL
    /// 		notes = $someString
    /// 		# REQUIRED
    /// 		threatHuntType = $someThreatHuntType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ThreatHuntType]) for enum values.
    /// 		# REQUIRED
    /// 		ioc = @{
    /// 			# OPTIONAL
    /// 			iocList = @{
    /// 				# REQUIRED
    /// 				indicatorsOfCompromise = @(
    /// 					@{
    /// 						# OPTIONAL
    /// 						threatFamily = $someString
    /// 						# REQUIRED
    /// 						iocKind = $someIndicatorOfCompromiseKind # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IndicatorOfCompromiseKind]) for enum values.
    /// 						# REQUIRED
    /// 						iocValue = $someString
    /// 					}
    /// 				)
    /// 			}
    /// 			# OPTIONAL
    /// 			feedProviderId = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		snapshotScanLimit = @{
    /// 			# OPTIONAL
    /// 			scanConfig = @{
    /// 				# OPTIONAL
    /// 				startTime = $someDateTime
    /// 				# OPTIONAL
    /// 				endTime = $someDateTime
    /// 				# OPTIONAL
    /// 				maxSnapshotsPerObject = $someInt
    /// 			}
    /// 			# OPTIONAL
    /// 			objectSnapshotConfig = @{
    /// 				# REQUIRED
    /// 				objectSnapshotIds = @(
    /// 					@{
    /// 						# REQUIRED
    /// 						objectFid = $someString
    /// 						# REQUIRED
    /// 						snapshotFid = @(
    /// 							$someString
    /// 						)
    /// 					}
    /// 				)
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		fileScanCriteria = @{
    /// 			# OPTIONAL
    /// 			fileSizeLimits = @{
    /// 				# OPTIONAL
    /// 				maximumSizeInBytes = $someInt64
    /// 				# OPTIONAL
    /// 				minimumSizeInBytes = $someInt64
    /// 			}
    /// 			# OPTIONAL
    /// 			fileTimeLimits = @{
    /// 				# OPTIONAL
    /// 				earliestCreationTime = $someDateTime
    /// 				# OPTIONAL
    /// 				earliestModificationTime = $someDateTime
    /// 				# OPTIONAL
    /// 				latestCreationTime = $someDateTime
    /// 				# OPTIONAL
    /// 				latestModificationTime = $someDateTime
    /// 			}
    /// 			# OPTIONAL
    /// 			pathFilter = @{
    /// 				# OPTIONAL
    /// 				inclusions = @(
    /// 					$someString
    /// 				)
    /// 				# OPTIONAL
    /// 				exclusions = @(
    /// 					$someString
    /// 				)
    /// 				# OPTIONAL
    /// 				exemptions = @(
    /// 					$someString
    /// 				)
    /// 			}
    /// 		}
    /// 		# REQUIRED
    /// 		name = $someString
    /// 		# OPTIONAL
    /// 		maxMatchesPerSnapshot = $someInt
    /// 	}
    /// 	# REQUIRED
    /// 	objectFids = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: StartBulkThreatHuntReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartTurbo operation
    /// of the 'ThreatHunt' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ThreatHunt
    /// # API Operation: StartTurbo
    /// 
    /// $query = New-RscMutationThreatHunt -Operation StartTurbo
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# REQUIRED
    /// 		baseConfig = @{
    /// 			# OPTIONAL
    /// 			notes = $someString
    /// 			# REQUIRED
    /// 			threatHuntType = $someThreatHuntType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ThreatHuntType]) for enum values.
    /// 			# REQUIRED
    /// 			ioc = @{
    /// 				# OPTIONAL
    /// 				iocList = @{
    /// 					# REQUIRED
    /// 					indicatorsOfCompromise = @(
    /// 						@{
    /// 							# OPTIONAL
    /// 							threatFamily = $someString
    /// 							# REQUIRED
    /// 							iocKind = $someIndicatorOfCompromiseKind # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IndicatorOfCompromiseKind]) for enum values.
    /// 							# REQUIRED
    /// 							iocValue = $someString
    /// 						}
    /// 					)
    /// 				}
    /// 				# OPTIONAL
    /// 				feedProviderId = $someString
    /// 			}
    /// 			# OPTIONAL
    /// 			snapshotScanLimit = @{
    /// 				# OPTIONAL
    /// 				scanConfig = @{
    /// 					# OPTIONAL
    /// 					startTime = $someDateTime
    /// 					# OPTIONAL
    /// 					endTime = $someDateTime
    /// 					# OPTIONAL
    /// 					maxSnapshotsPerObject = $someInt
    /// 				}
    /// 				# OPTIONAL
    /// 				objectSnapshotConfig = @{
    /// 					# REQUIRED
    /// 					objectSnapshotIds = @(
    /// 						@{
    /// 							# REQUIRED
    /// 							objectFid = $someString
    /// 							# REQUIRED
    /// 							snapshotFid = @(
    /// 								$someString
    /// 							)
    /// 						}
    /// 					)
    /// 				}
    /// 			}
    /// 			# OPTIONAL
    /// 			fileScanCriteria = @{
    /// 				# OPTIONAL
    /// 				fileSizeLimits = @{
    /// 					# OPTIONAL
    /// 					maximumSizeInBytes = $someInt64
    /// 					# OPTIONAL
    /// 					minimumSizeInBytes = $someInt64
    /// 				}
    /// 				# OPTIONAL
    /// 				fileTimeLimits = @{
    /// 					# OPTIONAL
    /// 					earliestCreationTime = $someDateTime
    /// 					# OPTIONAL
    /// 					earliestModificationTime = $someDateTime
    /// 					# OPTIONAL
    /// 					latestCreationTime = $someDateTime
    /// 					# OPTIONAL
    /// 					latestModificationTime = $someDateTime
    /// 				}
    /// 				# OPTIONAL
    /// 				pathFilter = @{
    /// 					# OPTIONAL
    /// 					inclusions = @(
    /// 						$someString
    /// 					)
    /// 					# OPTIONAL
    /// 					exclusions = @(
    /// 						$someString
    /// 					)
    /// 					# OPTIONAL
    /// 					exemptions = @(
    /// 						$someString
    /// 					)
    /// 				}
    /// 			}
    /// 			# REQUIRED
    /// 			name = $someString
    /// 			# OPTIONAL
    /// 			maxMatchesPerSnapshot = $someInt
    /// 		}
    /// 		# OPTIONAL
    /// 		clusterIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		objectsToScan = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				objectIds = @(
    /// 					$someString
    /// 				)
    /// 				# REQUIRED
    /// 				objectType = $someThreatHuntRootObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ThreatHuntRootObjectType]) for enum values.
    /// 			}
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: StartTurboThreatHuntReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartV2 operation
    /// of the 'ThreatHunt' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ThreatHunt
    /// # API Operation: StartV2
    /// 
    /// $query = New-RscMutationThreatHunt -Operation StartV2
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	baseConfig = @{
    /// 		# OPTIONAL
    /// 		notes = $someString
    /// 		# REQUIRED
    /// 		threatHuntType = $someThreatHuntType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ThreatHuntType]) for enum values.
    /// 		# REQUIRED
    /// 		ioc = @{
    /// 			# OPTIONAL
    /// 			iocList = @{
    /// 				# REQUIRED
    /// 				indicatorsOfCompromise = @(
    /// 					@{
    /// 						# OPTIONAL
    /// 						threatFamily = $someString
    /// 						# REQUIRED
    /// 						iocKind = $someIndicatorOfCompromiseKind # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IndicatorOfCompromiseKind]) for enum values.
    /// 						# REQUIRED
    /// 						iocValue = $someString
    /// 					}
    /// 				)
    /// 			}
    /// 			# OPTIONAL
    /// 			feedProviderId = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		snapshotScanLimit = @{
    /// 			# OPTIONAL
    /// 			scanConfig = @{
    /// 				# OPTIONAL
    /// 				startTime = $someDateTime
    /// 				# OPTIONAL
    /// 				endTime = $someDateTime
    /// 				# OPTIONAL
    /// 				maxSnapshotsPerObject = $someInt
    /// 			}
    /// 			# OPTIONAL
    /// 			objectSnapshotConfig = @{
    /// 				# REQUIRED
    /// 				objectSnapshotIds = @(
    /// 					@{
    /// 						# REQUIRED
    /// 						objectFid = $someString
    /// 						# REQUIRED
    /// 						snapshotFid = @(
    /// 							$someString
    /// 						)
    /// 					}
    /// 				)
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		fileScanCriteria = @{
    /// 			# OPTIONAL
    /// 			fileSizeLimits = @{
    /// 				# OPTIONAL
    /// 				maximumSizeInBytes = $someInt64
    /// 				# OPTIONAL
    /// 				minimumSizeInBytes = $someInt64
    /// 			}
    /// 			# OPTIONAL
    /// 			fileTimeLimits = @{
    /// 				# OPTIONAL
    /// 				earliestCreationTime = $someDateTime
    /// 				# OPTIONAL
    /// 				earliestModificationTime = $someDateTime
    /// 				# OPTIONAL
    /// 				latestCreationTime = $someDateTime
    /// 				# OPTIONAL
    /// 				latestModificationTime = $someDateTime
    /// 			}
    /// 			# OPTIONAL
    /// 			pathFilter = @{
    /// 				# OPTIONAL
    /// 				inclusions = @(
    /// 					$someString
    /// 				)
    /// 				# OPTIONAL
    /// 				exclusions = @(
    /// 					$someString
    /// 				)
    /// 				# OPTIONAL
    /// 				exemptions = @(
    /// 					$someString
    /// 				)
    /// 			}
    /// 		}
    /// 		# REQUIRED
    /// 		name = $someString
    /// 		# OPTIONAL
    /// 		maxMatchesPerSnapshot = $someInt
    /// 	}
    /// 	# REQUIRED
    /// 	objectFids = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: StartThreatHuntV2Reply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationThreatHunt",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationThreatHunt : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "Cancel",
                "Start",
                "StartBulk",
                "StartTurbo",
                "StartV2",
                IgnoreCase = true)]
        public string Operation { get; set; } = "";

        internal override string GetOperationParameter()
        {
            return this.Operation;
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "Cancel":
                        this.ProcessRecord_Cancel();
                        break;
                    case "Start":
                        this.ProcessRecord_Start();
                        break;
                    case "StartBulk":
                        this.ProcessRecord_StartBulk();
                        break;
                    case "StartTurbo":
                        this.ProcessRecord_StartTurbo();
                        break;
                    case "StartV2":
                        this.ProcessRecord_StartV2();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + this.GetOp().OpName());
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
        }

        // This parameter set invokes a single graphql operation:
        // cancelThreatHunt.
        internal void ProcessRecord_Cancel()
        {
            this._logger.name += " -Cancel";
            // Create new graphql operation cancelThreatHunt
            InitMutationCancelThreatHunt();
        }

        // This parameter set invokes a single graphql operation:
        // startThreatHunt.
        internal void ProcessRecord_Start()
        {
            this._logger.name += " -Start";
            // Create new graphql operation startThreatHunt
            InitMutationStartThreatHunt();
        }

        // This parameter set invokes a single graphql operation:
        // startBulkThreatHunt.
        internal void ProcessRecord_StartBulk()
        {
            this._logger.name += " -StartBulk";
            // Create new graphql operation startBulkThreatHunt
            InitMutationStartBulkThreatHunt();
        }

        // This parameter set invokes a single graphql operation:
        // startTurboThreatHunt.
        internal void ProcessRecord_StartTurbo()
        {
            this._logger.name += " -StartTurbo";
            // Create new graphql operation startTurboThreatHunt
            InitMutationStartTurboThreatHunt();
        }

        // This parameter set invokes a single graphql operation:
        // startThreatHuntV2.
        internal void ProcessRecord_StartV2()
        {
            this._logger.name += " -StartV2";
            // Create new graphql operation startThreatHuntV2
            InitMutationStartThreatHuntV2();
        }


        // Create new GraphQL Mutation:
        // cancelThreatHunt(input: CancelThreatHuntInput!): Void
        internal void InitMutationCancelThreatHunt()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CancelThreatHuntInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCancelThreatHunt",
                "($input: CancelThreatHuntInput!)",
                "System.String",
                Mutation.CancelThreatHunt,
                Mutation.CancelThreatHuntFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	huntId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // startThreatHunt(input: StartThreatHuntInput!): StartThreatHuntReply!
        internal void InitMutationStartThreatHunt()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartThreatHuntInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartThreatHunt",
                "($input: StartThreatHuntInput!)",
                "StartThreatHuntReply",
                Mutation.StartThreatHunt,
                Mutation.StartThreatHuntFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	notes = $someString
	# OPTIONAL
	fileScanCriteria = @{
		# OPTIONAL
		fileSizeLimits = @{
			# OPTIONAL
			maximumSizeInBytes = $someInt64
			# OPTIONAL
			minimumSizeInBytes = $someInt64
		}
		# OPTIONAL
		fileTimeLimits = @{
			# OPTIONAL
			earliestCreationTime = $someDateTime
			# OPTIONAL
			earliestModificationTime = $someDateTime
			# OPTIONAL
			latestCreationTime = $someDateTime
			# OPTIONAL
			latestModificationTime = $someDateTime
		}
		# OPTIONAL
		pathFilter = @{
			# OPTIONAL
			exceptions = @(
				$someString
			)
			# OPTIONAL
			excludes = @(
				$someString
			)
			# OPTIONAL
			includes = @(
				$someString
			)
		}
	}
	# REQUIRED
	indicatorsOfCompromise = @(
		@{
			# OPTIONAL
			threatFamily = $someString
			# REQUIRED
			iocKind = $someIndicatorOfCompromiseKind # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IndicatorOfCompromiseKind]) for enum values.
			# REQUIRED
			iocValue = $someString
		}
	)
	# OPTIONAL
	maxMatchesPerSnapshot = $someInt
	# REQUIRED
	name = $someString
	# REQUIRED
	objectFids = @(
		$someString
	)
	# OPTIONAL
	requestedMatchDetails = @{
		# OPTIONAL
		requestedHashTypes = @(
			$someHashType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HashType]) for enum values.
		)
	}
	# OPTIONAL
	shouldTrustFilesystemTimeInfo = $someBoolean
	# OPTIONAL
	snapshotScanLimit = @{
		# OPTIONAL
		endTime = $someDateTime
		# OPTIONAL
		maxSnapshotsPerObject = $someInt
		# OPTIONAL
		startTime = $someDateTime
		# OPTIONAL
		snapshotsToScanPerObject = @(
			@{
				# REQUIRED
				id = $someString
				# REQUIRED
				snapshots = @(
					$someString
				)
			}
		)
	}
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // startBulkThreatHunt(input: StartThreatHuntV2Input!): StartBulkThreatHuntReply!
        internal void InitMutationStartBulkThreatHunt()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartThreatHuntV2Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartBulkThreatHunt",
                "($input: StartThreatHuntV2Input!)",
                "StartBulkThreatHuntReply",
                Mutation.StartBulkThreatHunt,
                Mutation.StartBulkThreatHuntFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	baseConfig = @{
		# OPTIONAL
		notes = $someString
		# REQUIRED
		threatHuntType = $someThreatHuntType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ThreatHuntType]) for enum values.
		# REQUIRED
		ioc = @{
			# OPTIONAL
			iocList = @{
				# REQUIRED
				indicatorsOfCompromise = @(
					@{
						# OPTIONAL
						threatFamily = $someString
						# REQUIRED
						iocKind = $someIndicatorOfCompromiseKind # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IndicatorOfCompromiseKind]) for enum values.
						# REQUIRED
						iocValue = $someString
					}
				)
			}
			# OPTIONAL
			feedProviderId = $someString
		}
		# OPTIONAL
		snapshotScanLimit = @{
			# OPTIONAL
			scanConfig = @{
				# OPTIONAL
				startTime = $someDateTime
				# OPTIONAL
				endTime = $someDateTime
				# OPTIONAL
				maxSnapshotsPerObject = $someInt
			}
			# OPTIONAL
			objectSnapshotConfig = @{
				# REQUIRED
				objectSnapshotIds = @(
					@{
						# REQUIRED
						objectFid = $someString
						# REQUIRED
						snapshotFid = @(
							$someString
						)
					}
				)
			}
		}
		# OPTIONAL
		fileScanCriteria = @{
			# OPTIONAL
			fileSizeLimits = @{
				# OPTIONAL
				maximumSizeInBytes = $someInt64
				# OPTIONAL
				minimumSizeInBytes = $someInt64
			}
			# OPTIONAL
			fileTimeLimits = @{
				# OPTIONAL
				earliestCreationTime = $someDateTime
				# OPTIONAL
				earliestModificationTime = $someDateTime
				# OPTIONAL
				latestCreationTime = $someDateTime
				# OPTIONAL
				latestModificationTime = $someDateTime
			}
			# OPTIONAL
			pathFilter = @{
				# OPTIONAL
				inclusions = @(
					$someString
				)
				# OPTIONAL
				exclusions = @(
					$someString
				)
				# OPTIONAL
				exemptions = @(
					$someString
				)
			}
		}
		# REQUIRED
		name = $someString
		# OPTIONAL
		maxMatchesPerSnapshot = $someInt
	}
	# REQUIRED
	objectFids = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // startTurboThreatHunt(input: StartTurboThreatHuntInput!): StartTurboThreatHuntReply!
        internal void InitMutationStartTurboThreatHunt()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartTurboThreatHuntInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartTurboThreatHunt",
                "($input: StartTurboThreatHuntInput!)",
                "StartTurboThreatHuntReply",
                Mutation.StartTurboThreatHunt,
                Mutation.StartTurboThreatHuntFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		baseConfig = @{
			# OPTIONAL
			notes = $someString
			# REQUIRED
			threatHuntType = $someThreatHuntType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ThreatHuntType]) for enum values.
			# REQUIRED
			ioc = @{
				# OPTIONAL
				iocList = @{
					# REQUIRED
					indicatorsOfCompromise = @(
						@{
							# OPTIONAL
							threatFamily = $someString
							# REQUIRED
							iocKind = $someIndicatorOfCompromiseKind # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IndicatorOfCompromiseKind]) for enum values.
							# REQUIRED
							iocValue = $someString
						}
					)
				}
				# OPTIONAL
				feedProviderId = $someString
			}
			# OPTIONAL
			snapshotScanLimit = @{
				# OPTIONAL
				scanConfig = @{
					# OPTIONAL
					startTime = $someDateTime
					# OPTIONAL
					endTime = $someDateTime
					# OPTIONAL
					maxSnapshotsPerObject = $someInt
				}
				# OPTIONAL
				objectSnapshotConfig = @{
					# REQUIRED
					objectSnapshotIds = @(
						@{
							# REQUIRED
							objectFid = $someString
							# REQUIRED
							snapshotFid = @(
								$someString
							)
						}
					)
				}
			}
			# OPTIONAL
			fileScanCriteria = @{
				# OPTIONAL
				fileSizeLimits = @{
					# OPTIONAL
					maximumSizeInBytes = $someInt64
					# OPTIONAL
					minimumSizeInBytes = $someInt64
				}
				# OPTIONAL
				fileTimeLimits = @{
					# OPTIONAL
					earliestCreationTime = $someDateTime
					# OPTIONAL
					earliestModificationTime = $someDateTime
					# OPTIONAL
					latestCreationTime = $someDateTime
					# OPTIONAL
					latestModificationTime = $someDateTime
				}
				# OPTIONAL
				pathFilter = @{
					# OPTIONAL
					inclusions = @(
						$someString
					)
					# OPTIONAL
					exclusions = @(
						$someString
					)
					# OPTIONAL
					exemptions = @(
						$someString
					)
				}
			}
			# REQUIRED
			name = $someString
			# OPTIONAL
			maxMatchesPerSnapshot = $someInt
		}
		# OPTIONAL
		clusterIds = @(
			$someString
		)
		# OPTIONAL
		objectsToScan = @(
			@{
				# OPTIONAL
				objectIds = @(
					$someString
				)
				# REQUIRED
				objectType = $someThreatHuntRootObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ThreatHuntRootObjectType]) for enum values.
			}
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // startThreatHuntV2(input: StartThreatHuntV2Input!): StartThreatHuntV2Reply!
        internal void InitMutationStartThreatHuntV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartThreatHuntV2Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartThreatHuntV2",
                "($input: StartThreatHuntV2Input!)",
                "StartThreatHuntV2Reply",
                Mutation.StartThreatHuntV2,
                Mutation.StartThreatHuntV2FieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	baseConfig = @{
		# OPTIONAL
		notes = $someString
		# REQUIRED
		threatHuntType = $someThreatHuntType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ThreatHuntType]) for enum values.
		# REQUIRED
		ioc = @{
			# OPTIONAL
			iocList = @{
				# REQUIRED
				indicatorsOfCompromise = @(
					@{
						# OPTIONAL
						threatFamily = $someString
						# REQUIRED
						iocKind = $someIndicatorOfCompromiseKind # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IndicatorOfCompromiseKind]) for enum values.
						# REQUIRED
						iocValue = $someString
					}
				)
			}
			# OPTIONAL
			feedProviderId = $someString
		}
		# OPTIONAL
		snapshotScanLimit = @{
			# OPTIONAL
			scanConfig = @{
				# OPTIONAL
				startTime = $someDateTime
				# OPTIONAL
				endTime = $someDateTime
				# OPTIONAL
				maxSnapshotsPerObject = $someInt
			}
			# OPTIONAL
			objectSnapshotConfig = @{
				# REQUIRED
				objectSnapshotIds = @(
					@{
						# REQUIRED
						objectFid = $someString
						# REQUIRED
						snapshotFid = @(
							$someString
						)
					}
				)
			}
		}
		# OPTIONAL
		fileScanCriteria = @{
			# OPTIONAL
			fileSizeLimits = @{
				# OPTIONAL
				maximumSizeInBytes = $someInt64
				# OPTIONAL
				minimumSizeInBytes = $someInt64
			}
			# OPTIONAL
			fileTimeLimits = @{
				# OPTIONAL
				earliestCreationTime = $someDateTime
				# OPTIONAL
				earliestModificationTime = $someDateTime
				# OPTIONAL
				latestCreationTime = $someDateTime
				# OPTIONAL
				latestModificationTime = $someDateTime
			}
			# OPTIONAL
			pathFilter = @{
				# OPTIONAL
				inclusions = @(
					$someString
				)
				# OPTIONAL
				exclusions = @(
					$someString
				)
				# OPTIONAL
				exemptions = @(
					$someString
				)
			}
		}
		# REQUIRED
		name = $someString
		# OPTIONAL
		maxMatchesPerSnapshot = $someInt
	}
	# REQUIRED
	objectFids = @(
		$someString
	)
}"
            );
        }


    } // class New_RscMutationThreatHunt
}