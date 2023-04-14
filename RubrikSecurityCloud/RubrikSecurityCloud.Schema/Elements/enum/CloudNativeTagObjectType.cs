// CloudNativeTagObjectType.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
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
    public enum CloudNativeTagObjectType
    {
        [EnumMember(Value = "AWS_EBS_VOLUME")]
        AWS_EBS_VOLUME,

        [EnumMember(Value = "AWS_EC2_INSTANCE")]
        AWS_EC2_INSTANCE,

        [EnumMember(Value = "AWS_RDS_INSTANCE")]
        AWS_RDS_INSTANCE,

        [EnumMember(Value = "AWS_S3_BUCKET")]
        AWS_S3_BUCKET,

        [EnumMember(Value = "AZURE_MANAGED_DISK")]
        AZURE_MANAGED_DISK,

        [EnumMember(Value = "AZURE_SQL_DATABASE_DB")]
        AZURE_SQL_DATABASE_DB,

        [EnumMember(Value = "AZURE_SQL_DATABASE_SERVER")]
        AZURE_SQL_DATABASE_SERVER,

        [EnumMember(Value = "AZURE_SQL_MANAGED_INSTANCE_SERVER")]
        AZURE_SQL_MANAGED_INSTANCE_SERVER,

        [EnumMember(Value = "AZURE_VIRTUAL_MACHINE")]
        AZURE_VIRTUAL_MACHINE


    } // enum CloudNativeTagObjectType

} // namespace Rubrik.SecurityCloud.Types