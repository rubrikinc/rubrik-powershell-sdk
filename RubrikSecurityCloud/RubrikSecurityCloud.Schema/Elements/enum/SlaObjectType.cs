// SlaObjectType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:13.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Rubrik.SecurityCloud.Types
{
    public enum SlaObjectType
    {
        [EnumMember(Value = "AWS_EC2_EBS_OBJECT_TYPE")]
        AWS_EC2_EBS_OBJECT_TYPE,

        [EnumMember(Value = "AWS_RDS_OBJECT_TYPE")]
        AWS_RDS_OBJECT_TYPE,

        [EnumMember(Value = "AWS_S3_OBJECT_TYPE")]
        AWS_S3_OBJECT_TYPE,

        [EnumMember(Value = "AZURE_AD_OBJECT_TYPE")]
        AZURE_AD_OBJECT_TYPE,

        [EnumMember(Value = "AZURE_BLOB_OBJECT_TYPE")]
        AZURE_BLOB_OBJECT_TYPE,

        [EnumMember(Value = "AZURE_OBJECT_TYPE")]
        AZURE_OBJECT_TYPE,

        [EnumMember(Value = "AZURE_SQL_DATABASE_OBJECT_TYPE")]
        AZURE_SQL_DATABASE_OBJECT_TYPE,

        [EnumMember(Value = "AZURE_SQL_MANAGED_INSTANCE_OBJECT_TYPE")]
        AZURE_SQL_MANAGED_INSTANCE_OBJECT_TYPE,

        [EnumMember(Value = "CASSANDRA_OBJECT_TYPE")]
        CASSANDRA_OBJECT_TYPE,

        [EnumMember(Value = "DB2_OBJECT_TYPE")]
        DB2_OBJECT_TYPE,

        [EnumMember(Value = "EXCHANGE_OBJECT_TYPE")]
        EXCHANGE_OBJECT_TYPE,

        [EnumMember(Value = "FILESET_OBJECT_TYPE")]
        FILESET_OBJECT_TYPE,

        [EnumMember(Value = "GCP_OBJECT_TYPE")]
        GCP_OBJECT_TYPE,

        [EnumMember(Value = "HYPERV_OBJECT_TYPE")]
        HYPERV_OBJECT_TYPE,

        [EnumMember(Value = "KUPR_OBJECT_TYPE")]
        KUPR_OBJECT_TYPE,

        [EnumMember(Value = "MANAGED_VOLUME_OBJECT_TYPE")]
        MANAGED_VOLUME_OBJECT_TYPE,

        [EnumMember(Value = "MONGODB_OBJECT_TYPE")]
        MONGODB_OBJECT_TYPE,

        [EnumMember(Value = "MONGO_OBJECT_TYPE")]
        MONGO_OBJECT_TYPE,

        [EnumMember(Value = "MSSQL_OBJECT_TYPE")]
        MSSQL_OBJECT_TYPE,

        [EnumMember(Value = "NAS_OBJECT_TYPE")]
        NAS_OBJECT_TYPE,

        [EnumMember(Value = "NUTANIX_OBJECT_TYPE")]
        NUTANIX_OBJECT_TYPE,

        [EnumMember(Value = "O365_OBJECT_TYPE")]
        O365_OBJECT_TYPE,

        [EnumMember(Value = "ORACLE_OBJECT_TYPE")]
        ORACLE_OBJECT_TYPE,

        [EnumMember(Value = "SAP_HANA_OBJECT_TYPE")]
        SAP_HANA_OBJECT_TYPE,

        [EnumMember(Value = "SNAPMIRROR_CLOUD_OBJECT_TYPE")]
        SNAPMIRROR_CLOUD_OBJECT_TYPE,

        [EnumMember(Value = "UNKNOWN_OBJECT_TYPE")]
        UNKNOWN_OBJECT_TYPE,

        [EnumMember(Value = "VCD_OBJECT_TYPE")]
        VCD_OBJECT_TYPE,

        [EnumMember(Value = "VOLUME_GROUP_OBJECT_TYPE")]
        VOLUME_GROUP_OBJECT_TYPE,

        [EnumMember(Value = "VSPHERE_OBJECT_TYPE")]
        VSPHERE_OBJECT_TYPE


    } // enum SlaObjectType

} // namespace Rubrik.SecurityCloud.Types