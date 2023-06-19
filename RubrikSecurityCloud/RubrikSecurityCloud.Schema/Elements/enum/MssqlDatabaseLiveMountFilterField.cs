// MssqlDatabaseLiveMountFilterField.cs
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

namespace RubrikSecurityCloud.Types
{
    public enum MssqlDatabaseLiveMountFilterField
    {
        [EnumMember(Value = "CLUSTER_UUID")]
        CLUSTER_UUID,

        [EnumMember(Value = "MOUNTED_DATABASE_NAME")]
        MOUNTED_DATABASE_NAME,

        [EnumMember(Value = "ORG_ID")]
        ORG_ID,

        [EnumMember(Value = "SOURCE_DATABASE_ID")]
        SOURCE_DATABASE_ID


    } // enum MssqlDatabaseLiveMountFilterField

} // namespace RubrikSecurityCloud.Types