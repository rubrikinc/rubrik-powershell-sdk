// New-RscMutationHost.cs
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
    /// Create a new RscQuery object for any of the 7
    /// operations in the 'Host' API domain:
    /// BulkDelete, BulkRefresh, BulkRegister, BulkRegisterAsync, BulkUpdate, ChangeVfd, or Refresh.
    /// </summary>
    /// <description>
    /// New-RscMutationHost creates a new
    /// mutation object for operations
    /// in the 'Host' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 7 operations
    /// in the 'Host' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: BulkDelete, BulkRefresh, BulkRegister, BulkRegisterAsync, BulkUpdate, ChangeVfd, or Refresh.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationHost -BulkDelete).Info().
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
    /// (New-RscMutationHost -BulkDelete).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the BulkDelete operation
    /// of the 'Host' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Host
    /// # API Operation: BulkDelete
    /// 
    /// $query = New-RscMutationHost -BulkDelete
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	ids = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ResponseSuccess
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BulkRefresh operation
    /// of the 'Host' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Host
    /// # API Operation: BulkRefresh
    /// 
    /// $query = New-RscMutationHost -BulkRefresh
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	ids = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	shouldRunAsynchronously = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BulkRefreshHostsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BulkRegister operation
    /// of the 'Host' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Host
    /// # API Operation: BulkRegister
    /// 
    /// $query = New-RscMutationHost -BulkRegister
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	hosts = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			hasAgent = $someBoolean
    /// 			# OPTIONAL
    /// 			oracleQueryUser = $someString
    /// 			# OPTIONAL
    /// 			oracleSysDbaUser = $someString
    /// 			# OPTIONAL
    /// 			organizationId = $someString
    /// 			# OPTIONAL
    /// 			alias = $someString
    /// 			# OPTIONAL
    /// 			isOracleHost = $someBoolean
    /// 			# OPTIONAL
    /// 			mssqlSddCertificateId = $someString
    /// 			# OPTIONAL
    /// 			orgNetworkId = $someString
    /// 			# OPTIONAL
    /// 			osType = $someHostRegisterOsType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HostRegisterOsType]) for enum values.
    /// 			# OPTIONAL
    /// 			hdfsConfig = @{
    /// 				# OPTIONAL
    /// 				hdfsBaseConfig = @{
    /// 					# OPTIONAL
    /// 					apiToken = $someString
    /// 					# OPTIONAL
    /// 					kerberosTicket = $someString
    /// 					# OPTIONAL
    /// 					nameservices = $someString
    /// 					# OPTIONAL
    /// 					username = $someString
    /// 					# REQUIRED
    /// 					hosts = @(
    /// 						@{
    /// 							# REQUIRED
    /// 							hostname = $someString
    /// 							# REQUIRED
    /// 							port = $someInt
    /// 						}
    /// 					)
    /// 				}
    /// 			}
    /// 			# REQUIRED
    /// 			hostname = $someString
    /// 			# OPTIONAL
    /// 			mssqlSddUserCredentials = @{
    /// 				# REQUIRED
    /// 				password = $someString
    /// 				# REQUIRED
    /// 				username = $someString
    /// 			}
    /// 			# OPTIONAL
    /// 			nasConfig = @{
    /// 				# OPTIONAL
    /// 				apiCertificate = $someString
    /// 				# OPTIONAL
    /// 				apiEndpoint = $someString
    /// 				# OPTIONAL
    /// 				apiHostname = $someString
    /// 				# OPTIONAL
    /// 				apiPassword = $someString
    /// 				# OPTIONAL
    /// 				apiToken = $someString
    /// 				# OPTIONAL
    /// 				apiUsername = $someString
    /// 				# OPTIONAL
    /// 				zoneName = $someString
    /// 				# OPTIONAL
    /// 				isSnapdiffEnabled = $someBoolean
    /// 				# OPTIONAL
    /// 				isIsilonChangelistEnabled = $someBoolean
    /// 				# OPTIONAL
    /// 				isNetAppSnapDiffEnabled = $someBoolean
    /// 				# OPTIONAL
    /// 				isShareAutoDiscoveryEnabled = $someBoolean
    /// 				# OPTIONAL
    /// 				isNutanixCftEnabled = $someBoolean
    /// 				# REQUIRED
    /// 				vendorType = $someString
    /// 			}
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BulkRegisterHostReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BulkRegisterAsync operation
    /// of the 'Host' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Host
    /// # API Operation: BulkRegisterAsync
    /// 
    /// $query = New-RscMutationHost -BulkRegisterAsync
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	hosts = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			hasAgent = $someBoolean
    /// 			# OPTIONAL
    /// 			oracleQueryUser = $someString
    /// 			# OPTIONAL
    /// 			oracleSysDbaUser = $someString
    /// 			# OPTIONAL
    /// 			organizationId = $someString
    /// 			# OPTIONAL
    /// 			alias = $someString
    /// 			# OPTIONAL
    /// 			isOracleHost = $someBoolean
    /// 			# OPTIONAL
    /// 			mssqlSddCertificateId = $someString
    /// 			# OPTIONAL
    /// 			orgNetworkId = $someString
    /// 			# OPTIONAL
    /// 			osType = $someHostRegisterOsType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HostRegisterOsType]) for enum values.
    /// 			# OPTIONAL
    /// 			hdfsConfig = @{
    /// 				# OPTIONAL
    /// 				hdfsBaseConfig = @{
    /// 					# OPTIONAL
    /// 					apiToken = $someString
    /// 					# OPTIONAL
    /// 					kerberosTicket = $someString
    /// 					# OPTIONAL
    /// 					nameservices = $someString
    /// 					# OPTIONAL
    /// 					username = $someString
    /// 					# REQUIRED
    /// 					hosts = @(
    /// 						@{
    /// 							# REQUIRED
    /// 							hostname = $someString
    /// 							# REQUIRED
    /// 							port = $someInt
    /// 						}
    /// 					)
    /// 				}
    /// 			}
    /// 			# REQUIRED
    /// 			hostname = $someString
    /// 			# OPTIONAL
    /// 			mssqlSddUserCredentials = @{
    /// 				# REQUIRED
    /// 				password = $someString
    /// 				# REQUIRED
    /// 				username = $someString
    /// 			}
    /// 			# OPTIONAL
    /// 			nasConfig = @{
    /// 				# OPTIONAL
    /// 				apiCertificate = $someString
    /// 				# OPTIONAL
    /// 				apiEndpoint = $someString
    /// 				# OPTIONAL
    /// 				apiHostname = $someString
    /// 				# OPTIONAL
    /// 				apiPassword = $someString
    /// 				# OPTIONAL
    /// 				apiToken = $someString
    /// 				# OPTIONAL
    /// 				apiUsername = $someString
    /// 				# OPTIONAL
    /// 				zoneName = $someString
    /// 				# OPTIONAL
    /// 				isSnapdiffEnabled = $someBoolean
    /// 				# OPTIONAL
    /// 				isIsilonChangelistEnabled = $someBoolean
    /// 				# OPTIONAL
    /// 				isNetAppSnapDiffEnabled = $someBoolean
    /// 				# OPTIONAL
    /// 				isShareAutoDiscoveryEnabled = $someBoolean
    /// 				# OPTIONAL
    /// 				isNutanixCftEnabled = $someBoolean
    /// 				# REQUIRED
    /// 				vendorType = $someString
    /// 			}
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BulkRegisterHostAsyncReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BulkUpdate operation
    /// of the 'Host' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Host
    /// # API Operation: BulkUpdate
    /// 
    /// $query = New-RscMutationHost -BulkUpdate
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	hostUpdateProperties = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			hostId = $someString
    /// 			# REQUIRED
    /// 			updateProperties = @{
    /// 				# OPTIONAL
    /// 				compressionEnabled = $someBoolean
    /// 				# OPTIONAL
    /// 				hostVfdDriverInstalled = $someBoolean
    /// 				# OPTIONAL
    /// 				hostname = $someString
    /// 				# OPTIONAL
    /// 				mssqlCbtDriverInstalled = $someBoolean
    /// 				# OPTIONAL
    /// 				oracleQueryUser = $someString
    /// 				# OPTIONAL
    /// 				oracleSysDbaUser = $someString
    /// 				# OPTIONAL
    /// 				alias = $someString
    /// 				# OPTIONAL
    /// 				isOracleHost = $someBoolean
    /// 				# OPTIONAL
    /// 				isUpdateCertAndAgentIdEnabled = $someBoolean
    /// 				# OPTIONAL
    /// 				isRefreshPaused = $someBoolean
    /// 				# OPTIONAL
    /// 				mssqlSddCertificateId = $someString
    /// 				# OPTIONAL
    /// 				hostVfdEnabled = $someHostVfdInstallConfig # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HostVfdInstallConfig]) for enum values.
    /// 				# OPTIONAL
    /// 				mssqlCbtEnabled = $someMssqlCbtStatusType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlCbtStatusType]) for enum values.
    /// 				# OPTIONAL
    /// 				hdfsConfig = @{
    /// 					# OPTIONAL
    /// 					hdfsBaseConfig = @{
    /// 						# OPTIONAL
    /// 						apiToken = $someString
    /// 						# OPTIONAL
    /// 						kerberosTicket = $someString
    /// 						# OPTIONAL
    /// 						nameservices = $someString
    /// 						# OPTIONAL
    /// 						username = $someString
    /// 						# REQUIRED
    /// 						hosts = @(
    /// 							@{
    /// 								# REQUIRED
    /// 								hostname = $someString
    /// 								# REQUIRED
    /// 								port = $someInt
    /// 							}
    /// 						)
    /// 					}
    /// 				}
    /// 				# OPTIONAL
    /// 				mssqlSddUserCredentials = @{
    /// 					# REQUIRED
    /// 					password = $someString
    /// 					# REQUIRED
    /// 					username = $someString
    /// 				}
    /// 				# OPTIONAL
    /// 				nasConfig = @{
    /// 					# OPTIONAL
    /// 					apiCertificate = $someString
    /// 					# OPTIONAL
    /// 					apiEndpoint = $someString
    /// 					# OPTIONAL
    /// 					apiHostname = $someString
    /// 					# OPTIONAL
    /// 					apiPassword = $someString
    /// 					# OPTIONAL
    /// 					apiToken = $someString
    /// 					# OPTIONAL
    /// 					apiUsername = $someString
    /// 					# OPTIONAL
    /// 					zoneName = $someString
    /// 					# OPTIONAL
    /// 					isSnapdiffEnabled = $someBoolean
    /// 					# OPTIONAL
    /// 					isIsilonChangelistEnabled = $someBoolean
    /// 					# OPTIONAL
    /// 					isNetAppSnapDiffEnabled = $someBoolean
    /// 					# OPTIONAL
    /// 					isShareAutoDiscoveryEnabled = $someBoolean
    /// 					# OPTIONAL
    /// 					isNutanixCftEnabled = $someBoolean
    /// 					# REQUIRED
    /// 					vendorType = $someString
    /// 				}
    /// 			}
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BulkUpdateHostReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ChangeVfd operation
    /// of the 'Host' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Host
    /// # API Operation: ChangeVfd
    /// 
    /// $query = New-RscMutationHost -ChangeVfd
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# REQUIRED
    /// 		hostIds = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		install = $someBoolean
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ChangeVfdOnHostReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Refresh operation
    /// of the 'Host' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Host
    /// # API Operation: Refresh
    /// 
    /// $query = New-RscMutationHost -Refresh
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RefreshHostReply
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
        "RscMutationHost",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationHost : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "BulkDelete",
                "BulkRefresh",
                "BulkRegister",
                "BulkRegisterAsync",
                "BulkUpdate",
                "ChangeVfd",
                "Refresh",
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
                    case "BulkDelete":
                        this.ProcessRecord_BulkDelete();
                        break;
                    case "BulkRefresh":
                        this.ProcessRecord_BulkRefresh();
                        break;
                    case "BulkRegister":
                        this.ProcessRecord_BulkRegister();
                        break;
                    case "BulkRegisterAsync":
                        this.ProcessRecord_BulkRegisterAsync();
                        break;
                    case "BulkUpdate":
                        this.ProcessRecord_BulkUpdate();
                        break;
                    case "ChangeVfd":
                        this.ProcessRecord_ChangeVfd();
                        break;
                    case "Refresh":
                        this.ProcessRecord_Refresh();
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
        // bulkDeleteHost.
        internal void ProcessRecord_BulkDelete()
        {
            this._logger.name += " -BulkDelete";
            // Create new graphql operation bulkDeleteHost
            InitMutationBulkDeleteHost();
        }

        // This parameter set invokes a single graphql operation:
        // bulkRefreshHosts.
        internal void ProcessRecord_BulkRefresh()
        {
            this._logger.name += " -BulkRefresh";
            // Create new graphql operation bulkRefreshHosts
            InitMutationBulkRefreshHosts();
        }

        // This parameter set invokes a single graphql operation:
        // bulkRegisterHost.
        internal void ProcessRecord_BulkRegister()
        {
            this._logger.name += " -BulkRegister";
            // Create new graphql operation bulkRegisterHost
            InitMutationBulkRegisterHost();
        }

        // This parameter set invokes a single graphql operation:
        // bulkRegisterHostAsync.
        internal void ProcessRecord_BulkRegisterAsync()
        {
            this._logger.name += " -BulkRegisterAsync";
            // Create new graphql operation bulkRegisterHostAsync
            InitMutationBulkRegisterHostAsync();
        }

        // This parameter set invokes a single graphql operation:
        // bulkUpdateHost.
        internal void ProcessRecord_BulkUpdate()
        {
            this._logger.name += " -BulkUpdate";
            // Create new graphql operation bulkUpdateHost
            InitMutationBulkUpdateHost();
        }

        // This parameter set invokes a single graphql operation:
        // changeVfdOnHost.
        internal void ProcessRecord_ChangeVfd()
        {
            this._logger.name += " -ChangeVfd";
            // Create new graphql operation changeVfdOnHost
            InitMutationChangeVfdOnHost();
        }

        // This parameter set invokes a single graphql operation:
        // refreshHost.
        internal void ProcessRecord_Refresh()
        {
            this._logger.name += " -Refresh";
            // Create new graphql operation refreshHost
            InitMutationRefreshHost();
        }


        // Create new GraphQL Mutation:
        // bulkDeleteHost(input: BulkDeleteHostInput!): ResponseSuccess!
        internal void InitMutationBulkDeleteHost()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkDeleteHostInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkDeleteHost",
                "($input: BulkDeleteHostInput!)",
                "ResponseSuccess",
                Mutation.BulkDeleteHost,
                Mutation.BulkDeleteHostFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	ids = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkRefreshHosts(input: BulkRefreshHostsInput!): BulkRefreshHostsReply!
        internal void InitMutationBulkRefreshHosts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkRefreshHostsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkRefreshHosts",
                "($input: BulkRefreshHostsInput!)",
                "BulkRefreshHostsReply",
                Mutation.BulkRefreshHosts,
                Mutation.BulkRefreshHostsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	ids = @(
		$someString
	)
	# REQUIRED
	shouldRunAsynchronously = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkRegisterHost(input: BulkRegisterHostInput!): BulkRegisterHostReply!
        internal void InitMutationBulkRegisterHost()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkRegisterHostInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkRegisterHost",
                "($input: BulkRegisterHostInput!)",
                "BulkRegisterHostReply",
                Mutation.BulkRegisterHost,
                Mutation.BulkRegisterHostFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	hosts = @(
		@{
			# OPTIONAL
			hasAgent = $someBoolean
			# OPTIONAL
			oracleQueryUser = $someString
			# OPTIONAL
			oracleSysDbaUser = $someString
			# OPTIONAL
			organizationId = $someString
			# OPTIONAL
			alias = $someString
			# OPTIONAL
			isOracleHost = $someBoolean
			# OPTIONAL
			mssqlSddCertificateId = $someString
			# OPTIONAL
			orgNetworkId = $someString
			# OPTIONAL
			osType = $someHostRegisterOsType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HostRegisterOsType]) for enum values.
			# OPTIONAL
			hdfsConfig = @{
				# OPTIONAL
				hdfsBaseConfig = @{
					# OPTIONAL
					apiToken = $someString
					# OPTIONAL
					kerberosTicket = $someString
					# OPTIONAL
					nameservices = $someString
					# OPTIONAL
					username = $someString
					# REQUIRED
					hosts = @(
						@{
							# REQUIRED
							hostname = $someString
							# REQUIRED
							port = $someInt
						}
					)
				}
			}
			# REQUIRED
			hostname = $someString
			# OPTIONAL
			mssqlSddUserCredentials = @{
				# REQUIRED
				password = $someString
				# REQUIRED
				username = $someString
			}
			# OPTIONAL
			nasConfig = @{
				# OPTIONAL
				apiCertificate = $someString
				# OPTIONAL
				apiEndpoint = $someString
				# OPTIONAL
				apiHostname = $someString
				# OPTIONAL
				apiPassword = $someString
				# OPTIONAL
				apiToken = $someString
				# OPTIONAL
				apiUsername = $someString
				# OPTIONAL
				zoneName = $someString
				# OPTIONAL
				isSnapdiffEnabled = $someBoolean
				# OPTIONAL
				isIsilonChangelistEnabled = $someBoolean
				# OPTIONAL
				isNetAppSnapDiffEnabled = $someBoolean
				# OPTIONAL
				isShareAutoDiscoveryEnabled = $someBoolean
				# OPTIONAL
				isNutanixCftEnabled = $someBoolean
				# REQUIRED
				vendorType = $someString
			}
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkRegisterHostAsync(input: BulkRegisterHostAsyncInput!): BulkRegisterHostAsyncReply!
        internal void InitMutationBulkRegisterHostAsync()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkRegisterHostAsyncInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkRegisterHostAsync",
                "($input: BulkRegisterHostAsyncInput!)",
                "BulkRegisterHostAsyncReply",
                Mutation.BulkRegisterHostAsync,
                Mutation.BulkRegisterHostAsyncFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	hosts = @(
		@{
			# OPTIONAL
			hasAgent = $someBoolean
			# OPTIONAL
			oracleQueryUser = $someString
			# OPTIONAL
			oracleSysDbaUser = $someString
			# OPTIONAL
			organizationId = $someString
			# OPTIONAL
			alias = $someString
			# OPTIONAL
			isOracleHost = $someBoolean
			# OPTIONAL
			mssqlSddCertificateId = $someString
			# OPTIONAL
			orgNetworkId = $someString
			# OPTIONAL
			osType = $someHostRegisterOsType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HostRegisterOsType]) for enum values.
			# OPTIONAL
			hdfsConfig = @{
				# OPTIONAL
				hdfsBaseConfig = @{
					# OPTIONAL
					apiToken = $someString
					# OPTIONAL
					kerberosTicket = $someString
					# OPTIONAL
					nameservices = $someString
					# OPTIONAL
					username = $someString
					# REQUIRED
					hosts = @(
						@{
							# REQUIRED
							hostname = $someString
							# REQUIRED
							port = $someInt
						}
					)
				}
			}
			# REQUIRED
			hostname = $someString
			# OPTIONAL
			mssqlSddUserCredentials = @{
				# REQUIRED
				password = $someString
				# REQUIRED
				username = $someString
			}
			# OPTIONAL
			nasConfig = @{
				# OPTIONAL
				apiCertificate = $someString
				# OPTIONAL
				apiEndpoint = $someString
				# OPTIONAL
				apiHostname = $someString
				# OPTIONAL
				apiPassword = $someString
				# OPTIONAL
				apiToken = $someString
				# OPTIONAL
				apiUsername = $someString
				# OPTIONAL
				zoneName = $someString
				# OPTIONAL
				isSnapdiffEnabled = $someBoolean
				# OPTIONAL
				isIsilonChangelistEnabled = $someBoolean
				# OPTIONAL
				isNetAppSnapDiffEnabled = $someBoolean
				# OPTIONAL
				isShareAutoDiscoveryEnabled = $someBoolean
				# OPTIONAL
				isNutanixCftEnabled = $someBoolean
				# REQUIRED
				vendorType = $someString
			}
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkUpdateHost(input: BulkUpdateHostInput!): BulkUpdateHostReply!
        internal void InitMutationBulkUpdateHost()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkUpdateHostInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkUpdateHost",
                "($input: BulkUpdateHostInput!)",
                "BulkUpdateHostReply",
                Mutation.BulkUpdateHost,
                Mutation.BulkUpdateHostFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	hostUpdateProperties = @(
		@{
			# REQUIRED
			hostId = $someString
			# REQUIRED
			updateProperties = @{
				# OPTIONAL
				compressionEnabled = $someBoolean
				# OPTIONAL
				hostVfdDriverInstalled = $someBoolean
				# OPTIONAL
				hostname = $someString
				# OPTIONAL
				mssqlCbtDriverInstalled = $someBoolean
				# OPTIONAL
				oracleQueryUser = $someString
				# OPTIONAL
				oracleSysDbaUser = $someString
				# OPTIONAL
				alias = $someString
				# OPTIONAL
				isOracleHost = $someBoolean
				# OPTIONAL
				isUpdateCertAndAgentIdEnabled = $someBoolean
				# OPTIONAL
				isRefreshPaused = $someBoolean
				# OPTIONAL
				mssqlSddCertificateId = $someString
				# OPTIONAL
				hostVfdEnabled = $someHostVfdInstallConfig # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HostVfdInstallConfig]) for enum values.
				# OPTIONAL
				mssqlCbtEnabled = $someMssqlCbtStatusType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlCbtStatusType]) for enum values.
				# OPTIONAL
				hdfsConfig = @{
					# OPTIONAL
					hdfsBaseConfig = @{
						# OPTIONAL
						apiToken = $someString
						# OPTIONAL
						kerberosTicket = $someString
						# OPTIONAL
						nameservices = $someString
						# OPTIONAL
						username = $someString
						# REQUIRED
						hosts = @(
							@{
								# REQUIRED
								hostname = $someString
								# REQUIRED
								port = $someInt
							}
						)
					}
				}
				# OPTIONAL
				mssqlSddUserCredentials = @{
					# REQUIRED
					password = $someString
					# REQUIRED
					username = $someString
				}
				# OPTIONAL
				nasConfig = @{
					# OPTIONAL
					apiCertificate = $someString
					# OPTIONAL
					apiEndpoint = $someString
					# OPTIONAL
					apiHostname = $someString
					# OPTIONAL
					apiPassword = $someString
					# OPTIONAL
					apiToken = $someString
					# OPTIONAL
					apiUsername = $someString
					# OPTIONAL
					zoneName = $someString
					# OPTIONAL
					isSnapdiffEnabled = $someBoolean
					# OPTIONAL
					isIsilonChangelistEnabled = $someBoolean
					# OPTIONAL
					isNetAppSnapDiffEnabled = $someBoolean
					# OPTIONAL
					isShareAutoDiscoveryEnabled = $someBoolean
					# OPTIONAL
					isNutanixCftEnabled = $someBoolean
					# REQUIRED
					vendorType = $someString
				}
			}
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // changeVfdOnHost(input: ChangeVfdOnHostInput!): ChangeVfdOnHostReply!
        internal void InitMutationChangeVfdOnHost()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ChangeVfdOnHostInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationChangeVfdOnHost",
                "($input: ChangeVfdOnHostInput!)",
                "ChangeVfdOnHostReply",
                Mutation.ChangeVfdOnHost,
                Mutation.ChangeVfdOnHostFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		hostIds = @(
			$someString
		)
		# REQUIRED
		install = $someBoolean
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // refreshHost(input: RefreshHostInput!): RefreshHostReply!
        internal void InitMutationRefreshHost()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshHostInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshHost",
                "($input: RefreshHostInput!)",
                "RefreshHostReply",
                Mutation.RefreshHost,
                Mutation.RefreshHostFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }


    } // class New_RscMutationHost
}