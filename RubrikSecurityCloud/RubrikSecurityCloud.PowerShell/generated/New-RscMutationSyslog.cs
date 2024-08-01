// New-RscMutationSyslog.cs
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
    /// operations in the 'Syslog' API domain:
    /// AddConfiguration, AddExportRule, DeleteConfiguration, DeleteExportRule, SendTest, TestExportRule, or UpdateExportRule.
    /// </summary>
    /// <description>
    /// New-RscMutationSyslog creates a new
    /// mutation object for operations
    /// in the 'Syslog' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 7 operations
    /// in the 'Syslog' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AddConfiguration, AddExportRule, DeleteConfiguration, DeleteExportRule, SendTest, TestExportRule, or UpdateExportRule.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationSyslog -AddConfiguration).Info().
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
    /// (New-RscMutationSyslog -AddConfiguration).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AddConfiguration operation
    /// of the 'Syslog' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Syslog
    /// # API Operation: AddConfiguration
    /// 
    /// $query = New-RscMutationSyslog -AddConfiguration
    /// 
    /// # REQUIRED
    /// $query.Var.hostName = $someString
    /// # REQUIRED
    /// $query.Var.port = $someInt
    /// # REQUIRED
    /// $query.Var.networkProtocolType = $someNetworkProtocolTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NetworkProtocolTypeEnum]) for enum values.
    /// # REQUIRED
    /// $query.Var.useTLS = $someBoolean
    /// # REQUIRED
    /// $query.Var.syslogFacility = $someSyslogFacilityTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacilityTypeEnum]) for enum values.
    /// # REQUIRED
    /// $query.Var.syslogSeverity = $someSyslogSeverityTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverityTypeEnum]) for enum values.
    /// # REQUIRED
    /// $query.Var.trustedCerts = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AddExportRule operation
    /// of the 'Syslog' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Syslog
    /// # API Operation: AddExportRule
    /// 
    /// $query = New-RscMutationSyslog -AddExportRule
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# OPTIONAL
    /// 	syslogExportRuleV51 = @{
    /// 		# OPTIONAL
    /// 		syslogCertificateInfo = @{
    /// 			# OPTIONAL
    /// 			serverCertificate = $someString
    /// 			# OPTIONAL
    /// 			serverCertificateName = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		syslogExportRuleFull = @{
    /// 			# OPTIONAL
    /// 			certificateId = $someString
    /// 			# REQUIRED
    /// 			facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 			# REQUIRED
    /// 			protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 			# REQUIRED
    /// 			severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 			# REQUIRED
    /// 			enableTls = $someBoolean
    /// 			# REQUIRED
    /// 			hostname = $someString
    /// 			# REQUIRED
    /// 			port = $someInt
    /// 		}
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV52 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV53 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV60 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV70 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV80 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV81 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV90 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV91 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV92 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV93 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddSyslogExportRuleReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteConfiguration operation
    /// of the 'Syslog' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Syslog
    /// # API Operation: DeleteConfiguration
    /// 
    /// $query = New-RscMutationSyslog -DeleteConfiguration
    /// 
    /// # REQUIRED
    /// $query.Var.ids = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteExportRule operation
    /// of the 'Syslog' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Syslog
    /// # API Operation: DeleteExportRule
    /// 
    /// $query = New-RscMutationSyslog -DeleteExportRule
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	id = $someString
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
    /// Runs the SendTest operation
    /// of the 'Syslog' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Syslog
    /// # API Operation: SendTest
    /// 
    /// $query = New-RscMutationSyslog -SendTest
    /// 
    /// # OPTIONAL
    /// $query.Var.config = @{
    /// 	# OPTIONAL
    /// 	id = $someInt
    /// 	# OPTIONAL
    /// 	notificationConf = @{
    /// 		# OPTIONAL
    /// 		hostname = $someString
    /// 		# OPTIONAL
    /// 		port = $someInt
    /// 		# OPTIONAL
    /// 		networkType = $someNetworkProtocolTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NetworkProtocolTypeEnum]) for enum values.
    /// 		# OPTIONAL
    /// 		securityType = $someSMTPSecurityTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SMTPSecurityTypeEnum]) for enum values.
    /// 		# OPTIONAL
    /// 		trustedCerts = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogConf = @{
    /// 		# OPTIONAL
    /// 		facility = $someSyslogFacilityTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacilityTypeEnum]) for enum values.
    /// 		# OPTIONAL
    /// 		severity = $someSyslogSeverityTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverityTypeEnum]) for enum values.
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TestExportRule operation
    /// of the 'Syslog' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Syslog
    /// # API Operation: TestExportRule
    /// 
    /// $query = New-RscMutationSyslog -TestExportRule
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# OPTIONAL
    /// 	syslogExportRuleV51 = @{
    /// 		# OPTIONAL
    /// 		syslogCertificateInfo = @{
    /// 			# OPTIONAL
    /// 			serverCertificate = $someString
    /// 			# OPTIONAL
    /// 			serverCertificateName = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		syslogExportRuleFull = @{
    /// 			# OPTIONAL
    /// 			certificateId = $someString
    /// 			# REQUIRED
    /// 			facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 			# REQUIRED
    /// 			protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 			# REQUIRED
    /// 			severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 			# REQUIRED
    /// 			enableTls = $someBoolean
    /// 			# REQUIRED
    /// 			hostname = $someString
    /// 			# REQUIRED
    /// 			port = $someInt
    /// 		}
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV52 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV53 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV60 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV70 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV80 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV81 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV90 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV91 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV92 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV93 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TestSyslogExportRuleReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateExportRule operation
    /// of the 'Syslog' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Syslog
    /// # API Operation: UpdateExportRule
    /// 
    /// $query = New-RscMutationSyslog -UpdateExportRule
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	syslogSettingsV51 = @{
    /// 		# OPTIONAL
    /// 		syslogCertificateInfo = @{
    /// 			# OPTIONAL
    /// 			serverCertificate = $someString
    /// 			# OPTIONAL
    /// 			serverCertificateName = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		syslogExportRulePartial = @{
    /// 			# OPTIONAL
    /// 			enableTls = $someBoolean
    /// 			# OPTIONAL
    /// 			hostname = $someString
    /// 			# OPTIONAL
    /// 			port = $someInt
    /// 			# OPTIONAL
    /// 			certificateId = $someString
    /// 			# OPTIONAL
    /// 			facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 			# OPTIONAL
    /// 			protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 			# OPTIONAL
    /// 			severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		}
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogSettingsV52 = @{
    /// 		# OPTIONAL
    /// 		enableTls = $someBoolean
    /// 		# OPTIONAL
    /// 		hostname = $someString
    /// 		# OPTIONAL
    /// 		port = $someInt
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# OPTIONAL
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# OPTIONAL
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# OPTIONAL
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogSettingsV53 = @{
    /// 		# OPTIONAL
    /// 		enableTls = $someBoolean
    /// 		# OPTIONAL
    /// 		hostname = $someString
    /// 		# OPTIONAL
    /// 		port = $someInt
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# OPTIONAL
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# OPTIONAL
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# OPTIONAL
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogSettingsV60 = @{
    /// 		# OPTIONAL
    /// 		enableTls = $someBoolean
    /// 		# OPTIONAL
    /// 		hostname = $someString
    /// 		# OPTIONAL
    /// 		port = $someInt
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# OPTIONAL
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# OPTIONAL
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# OPTIONAL
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogSettingsV70 = @{
    /// 		# OPTIONAL
    /// 		enableTls = $someBoolean
    /// 		# OPTIONAL
    /// 		hostname = $someString
    /// 		# OPTIONAL
    /// 		port = $someInt
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# OPTIONAL
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# OPTIONAL
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# OPTIONAL
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogSettingsV80 = @{
    /// 		# OPTIONAL
    /// 		enableTls = $someBoolean
    /// 		# OPTIONAL
    /// 		hostname = $someString
    /// 		# OPTIONAL
    /// 		port = $someInt
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# OPTIONAL
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# OPTIONAL
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# OPTIONAL
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogSettingsV81 = @{
    /// 		# OPTIONAL
    /// 		enableTls = $someBoolean
    /// 		# OPTIONAL
    /// 		hostname = $someString
    /// 		# OPTIONAL
    /// 		port = $someInt
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# OPTIONAL
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# OPTIONAL
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# OPTIONAL
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogSettingsV90 = @{
    /// 		# OPTIONAL
    /// 		enableTls = $someBoolean
    /// 		# OPTIONAL
    /// 		hostname = $someString
    /// 		# OPTIONAL
    /// 		port = $someInt
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# OPTIONAL
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# OPTIONAL
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# OPTIONAL
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogSettingsV91 = @{
    /// 		# OPTIONAL
    /// 		enableTls = $someBoolean
    /// 		# OPTIONAL
    /// 		hostname = $someString
    /// 		# OPTIONAL
    /// 		port = $someInt
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# OPTIONAL
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# OPTIONAL
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# OPTIONAL
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogSettingsV92 = @{
    /// 		# OPTIONAL
    /// 		enableTls = $someBoolean
    /// 		# OPTIONAL
    /// 		hostname = $someString
    /// 		# OPTIONAL
    /// 		port = $someInt
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# OPTIONAL
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# OPTIONAL
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# OPTIONAL
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogSettingsV93 = @{
    /// 		# OPTIONAL
    /// 		enableTls = $someBoolean
    /// 		# OPTIONAL
    /// 		hostname = $someString
    /// 		# OPTIONAL
    /// 		port = $someInt
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# OPTIONAL
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# OPTIONAL
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# OPTIONAL
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateSyslogExportRuleReply
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
        "RscMutationSyslog",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationSyslog : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "AddConfiguration",
                "AddExportRule",
                "DeleteConfiguration",
                "DeleteExportRule",
                "SendTest",
                "TestExportRule",
                "UpdateExportRule",
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
                    case "AddConfiguration":
                        this.ProcessRecord_AddConfiguration();
                        break;
                    case "AddExportRule":
                        this.ProcessRecord_AddExportRule();
                        break;
                    case "DeleteConfiguration":
                        this.ProcessRecord_DeleteConfiguration();
                        break;
                    case "DeleteExportRule":
                        this.ProcessRecord_DeleteExportRule();
                        break;
                    case "SendTest":
                        this.ProcessRecord_SendTest();
                        break;
                    case "TestExportRule":
                        this.ProcessRecord_TestExportRule();
                        break;
                    case "UpdateExportRule":
                        this.ProcessRecord_UpdateExportRule();
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
        // addSyslogConfiguration.
        internal void ProcessRecord_AddConfiguration()
        {
            this._logger.name += " -AddConfiguration";
            // Create new graphql operation addSyslogConfiguration
            InitMutationAddSyslogConfiguration();
        }

        // This parameter set invokes a single graphql operation:
        // addSyslogExportRule.
        internal void ProcessRecord_AddExportRule()
        {
            this._logger.name += " -AddExportRule";
            // Create new graphql operation addSyslogExportRule
            InitMutationAddSyslogExportRule();
        }

        // This parameter set invokes a single graphql operation:
        // deleteSyslogConfiguration.
        internal void ProcessRecord_DeleteConfiguration()
        {
            this._logger.name += " -DeleteConfiguration";
            // Create new graphql operation deleteSyslogConfiguration
            InitMutationDeleteSyslogConfiguration();
        }

        // This parameter set invokes a single graphql operation:
        // deleteSyslogExportRule.
        internal void ProcessRecord_DeleteExportRule()
        {
            this._logger.name += " -DeleteExportRule";
            // Create new graphql operation deleteSyslogExportRule
            InitMutationDeleteSyslogExportRule();
        }

        // This parameter set invokes a single graphql operation:
        // sendTestSyslog.
        internal void ProcessRecord_SendTest()
        {
            this._logger.name += " -SendTest";
            // Create new graphql operation sendTestSyslog
            InitMutationSendTestSyslog();
        }

        // This parameter set invokes a single graphql operation:
        // testSyslogExportRule.
        internal void ProcessRecord_TestExportRule()
        {
            this._logger.name += " -TestExportRule";
            // Create new graphql operation testSyslogExportRule
            InitMutationTestSyslogExportRule();
        }

        // This parameter set invokes a single graphql operation:
        // updateSyslogExportRule.
        internal void ProcessRecord_UpdateExportRule()
        {
            this._logger.name += " -UpdateExportRule";
            // Create new graphql operation updateSyslogExportRule
            InitMutationUpdateSyslogExportRule();
        }


        // Create new GraphQL Mutation:
        // addSyslogConfiguration(
        //     hostName: String!
        //     port: Int!
        //     networkProtocolType: NetworkProtocolTypeEnum!
        //     useTLS: Boolean!
        //     syslogFacility: SyslogFacilityTypeEnum!
        //     syslogSeverity: SyslogSeverityTypeEnum!
        //     trustedCerts: String!
        //   ): Boolean!
        internal void InitMutationAddSyslogConfiguration()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("hostName", "String!"),
                Tuple.Create("port", "Int!"),
                Tuple.Create("networkProtocolType", "NetworkProtocolTypeEnum!"),
                Tuple.Create("useTLS", "Boolean!"),
                Tuple.Create("syslogFacility", "SyslogFacilityTypeEnum!"),
                Tuple.Create("syslogSeverity", "SyslogSeverityTypeEnum!"),
                Tuple.Create("trustedCerts", "String!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddSyslogConfiguration",
                "($hostName: String!,$port: Int!,$networkProtocolType: NetworkProtocolTypeEnum!,$useTLS: Boolean!,$syslogFacility: SyslogFacilityTypeEnum!,$syslogSeverity: SyslogSeverityTypeEnum!,$trustedCerts: String!)",
                "System.Boolean",
                Mutation.AddSyslogConfiguration,
                Mutation.AddSyslogConfigurationFieldSpec,
                @"# REQUIRED
$query.Var.hostName = $someString
# REQUIRED
$query.Var.port = $someInt
# REQUIRED
$query.Var.networkProtocolType = $someNetworkProtocolTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NetworkProtocolTypeEnum]) for enum values.
# REQUIRED
$query.Var.useTLS = $someBoolean
# REQUIRED
$query.Var.syslogFacility = $someSyslogFacilityTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacilityTypeEnum]) for enum values.
# REQUIRED
$query.Var.syslogSeverity = $someSyslogSeverityTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverityTypeEnum]) for enum values.
# REQUIRED
$query.Var.trustedCerts = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // addSyslogExportRule(input: AddSyslogExportRuleInput!): AddSyslogExportRuleReply!
        internal void InitMutationAddSyslogExportRule()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddSyslogExportRuleInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddSyslogExportRule",
                "($input: AddSyslogExportRuleInput!)",
                "AddSyslogExportRuleReply",
                Mutation.AddSyslogExportRule,
                Mutation.AddSyslogExportRuleFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# OPTIONAL
	syslogExportRuleV51 = @{
		# OPTIONAL
		syslogCertificateInfo = @{
			# OPTIONAL
			serverCertificate = $someString
			# OPTIONAL
			serverCertificateName = $someString
		}
		# OPTIONAL
		syslogExportRuleFull = @{
			# OPTIONAL
			certificateId = $someString
			# REQUIRED
			facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
			# REQUIRED
			protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
			# REQUIRED
			severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
			# REQUIRED
			enableTls = $someBoolean
			# REQUIRED
			hostname = $someString
			# REQUIRED
			port = $someInt
		}
	}
	# OPTIONAL
	syslogExportRuleV52 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# OPTIONAL
	syslogExportRuleV53 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# OPTIONAL
	syslogExportRuleV60 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# OPTIONAL
	syslogExportRuleV70 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# OPTIONAL
	syslogExportRuleV80 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# OPTIONAL
	syslogExportRuleV81 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# OPTIONAL
	syslogExportRuleV90 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# OPTIONAL
	syslogExportRuleV91 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# OPTIONAL
	syslogExportRuleV92 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# OPTIONAL
	syslogExportRuleV93 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteSyslogConfiguration(ids: [String!]!): Boolean!
        internal void InitMutationDeleteSyslogConfiguration()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("ids", "[String!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteSyslogConfiguration",
                "($ids: [String!]!)",
                "System.Boolean",
                Mutation.DeleteSyslogConfiguration,
                Mutation.DeleteSyslogConfigurationFieldSpec,
                @"# REQUIRED
$query.Var.ids = @(
	$someString
)"
            );
        }

        // Create new GraphQL Mutation:
        // deleteSyslogExportRule(input: DeleteSyslogExportRuleInput!): Void
        internal void InitMutationDeleteSyslogExportRule()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteSyslogExportRuleInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteSyslogExportRule",
                "($input: DeleteSyslogExportRuleInput!)",
                "System.String",
                Mutation.DeleteSyslogExportRule,
                Mutation.DeleteSyslogExportRuleFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // sendTestSyslog(config: SyslogConfigInputType): Boolean!
        internal void InitMutationSendTestSyslog()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("config", "SyslogConfigInputType"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSendTestSyslog",
                "($config: SyslogConfigInputType)",
                "System.Boolean",
                Mutation.SendTestSyslog,
                Mutation.SendTestSyslogFieldSpec,
                @"# OPTIONAL
$query.Var.config = @{
	# OPTIONAL
	id = $someInt
	# OPTIONAL
	notificationConf = @{
		# OPTIONAL
		hostname = $someString
		# OPTIONAL
		port = $someInt
		# OPTIONAL
		networkType = $someNetworkProtocolTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NetworkProtocolTypeEnum]) for enum values.
		# OPTIONAL
		securityType = $someSMTPSecurityTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SMTPSecurityTypeEnum]) for enum values.
		# OPTIONAL
		trustedCerts = $someString
	}
	# OPTIONAL
	syslogConf = @{
		# OPTIONAL
		facility = $someSyslogFacilityTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacilityTypeEnum]) for enum values.
		# OPTIONAL
		severity = $someSyslogSeverityTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverityTypeEnum]) for enum values.
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // testSyslogExportRule(input: TestSyslogExportRuleInput!): TestSyslogExportRuleReply!
        internal void InitMutationTestSyslogExportRule()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "TestSyslogExportRuleInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationTestSyslogExportRule",
                "($input: TestSyslogExportRuleInput!)",
                "TestSyslogExportRuleReply",
                Mutation.TestSyslogExportRule,
                Mutation.TestSyslogExportRuleFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# OPTIONAL
	syslogExportRuleV51 = @{
		# OPTIONAL
		syslogCertificateInfo = @{
			# OPTIONAL
			serverCertificate = $someString
			# OPTIONAL
			serverCertificateName = $someString
		}
		# OPTIONAL
		syslogExportRuleFull = @{
			# OPTIONAL
			certificateId = $someString
			# REQUIRED
			facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
			# REQUIRED
			protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
			# REQUIRED
			severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
			# REQUIRED
			enableTls = $someBoolean
			# REQUIRED
			hostname = $someString
			# REQUIRED
			port = $someInt
		}
	}
	# OPTIONAL
	syslogExportRuleV52 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# OPTIONAL
	syslogExportRuleV53 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# OPTIONAL
	syslogExportRuleV60 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# OPTIONAL
	syslogExportRuleV70 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# OPTIONAL
	syslogExportRuleV80 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# OPTIONAL
	syslogExportRuleV81 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# OPTIONAL
	syslogExportRuleV90 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# OPTIONAL
	syslogExportRuleV91 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# OPTIONAL
	syslogExportRuleV92 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# OPTIONAL
	syslogExportRuleV93 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateSyslogExportRule(input: UpdateSyslogExportRuleInput!): UpdateSyslogExportRuleReply!
        internal void InitMutationUpdateSyslogExportRule()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateSyslogExportRuleInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateSyslogExportRule",
                "($input: UpdateSyslogExportRuleInput!)",
                "UpdateSyslogExportRuleReply",
                Mutation.UpdateSyslogExportRule,
                Mutation.UpdateSyslogExportRuleFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	id = $someString
	# OPTIONAL
	syslogSettingsV51 = @{
		# OPTIONAL
		syslogCertificateInfo = @{
			# OPTIONAL
			serverCertificate = $someString
			# OPTIONAL
			serverCertificateName = $someString
		}
		# OPTIONAL
		syslogExportRulePartial = @{
			# OPTIONAL
			enableTls = $someBoolean
			# OPTIONAL
			hostname = $someString
			# OPTIONAL
			port = $someInt
			# OPTIONAL
			certificateId = $someString
			# OPTIONAL
			facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
			# OPTIONAL
			protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
			# OPTIONAL
			severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		}
	}
	# OPTIONAL
	syslogSettingsV52 = @{
		# OPTIONAL
		enableTls = $someBoolean
		# OPTIONAL
		hostname = $someString
		# OPTIONAL
		port = $someInt
		# OPTIONAL
		certificateId = $someString
		# OPTIONAL
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# OPTIONAL
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# OPTIONAL
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
	}
	# OPTIONAL
	syslogSettingsV53 = @{
		# OPTIONAL
		enableTls = $someBoolean
		# OPTIONAL
		hostname = $someString
		# OPTIONAL
		port = $someInt
		# OPTIONAL
		certificateId = $someString
		# OPTIONAL
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# OPTIONAL
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# OPTIONAL
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
	}
	# OPTIONAL
	syslogSettingsV60 = @{
		# OPTIONAL
		enableTls = $someBoolean
		# OPTIONAL
		hostname = $someString
		# OPTIONAL
		port = $someInt
		# OPTIONAL
		certificateId = $someString
		# OPTIONAL
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# OPTIONAL
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# OPTIONAL
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
	}
	# OPTIONAL
	syslogSettingsV70 = @{
		# OPTIONAL
		enableTls = $someBoolean
		# OPTIONAL
		hostname = $someString
		# OPTIONAL
		port = $someInt
		# OPTIONAL
		certificateId = $someString
		# OPTIONAL
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# OPTIONAL
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# OPTIONAL
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
	}
	# OPTIONAL
	syslogSettingsV80 = @{
		# OPTIONAL
		enableTls = $someBoolean
		# OPTIONAL
		hostname = $someString
		# OPTIONAL
		port = $someInt
		# OPTIONAL
		certificateId = $someString
		# OPTIONAL
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# OPTIONAL
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# OPTIONAL
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
	}
	# OPTIONAL
	syslogSettingsV81 = @{
		# OPTIONAL
		enableTls = $someBoolean
		# OPTIONAL
		hostname = $someString
		# OPTIONAL
		port = $someInt
		# OPTIONAL
		certificateId = $someString
		# OPTIONAL
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# OPTIONAL
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# OPTIONAL
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
	}
	# OPTIONAL
	syslogSettingsV90 = @{
		# OPTIONAL
		enableTls = $someBoolean
		# OPTIONAL
		hostname = $someString
		# OPTIONAL
		port = $someInt
		# OPTIONAL
		certificateId = $someString
		# OPTIONAL
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# OPTIONAL
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# OPTIONAL
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
	}
	# OPTIONAL
	syslogSettingsV91 = @{
		# OPTIONAL
		enableTls = $someBoolean
		# OPTIONAL
		hostname = $someString
		# OPTIONAL
		port = $someInt
		# OPTIONAL
		certificateId = $someString
		# OPTIONAL
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# OPTIONAL
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# OPTIONAL
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
	}
	# OPTIONAL
	syslogSettingsV92 = @{
		# OPTIONAL
		enableTls = $someBoolean
		# OPTIONAL
		hostname = $someString
		# OPTIONAL
		port = $someInt
		# OPTIONAL
		certificateId = $someString
		# OPTIONAL
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# OPTIONAL
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# OPTIONAL
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
	}
	# OPTIONAL
	syslogSettingsV93 = @{
		# OPTIONAL
		enableTls = $someBoolean
		# OPTIONAL
		hostname = $someString
		# OPTIONAL
		port = $someInt
		# OPTIONAL
		certificateId = $someString
		# OPTIONAL
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# OPTIONAL
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# OPTIONAL
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
	}
}"
            );
        }


    } // class New_RscMutationSyslog
}