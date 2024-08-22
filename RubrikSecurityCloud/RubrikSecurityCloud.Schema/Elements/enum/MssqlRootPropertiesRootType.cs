// MssqlRootPropertiesRootType.cs
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
    public enum MssqlRootPropertiesRootType
    {
        [EnumMember(Value = "MSSQL_ROOT_PROPERTIES_ROOT_TYPE_HOST")]
        MSSQL_ROOT_PROPERTIES_ROOT_TYPE_HOST,

        [EnumMember(Value = "MSSQL_ROOT_PROPERTIES_ROOT_TYPE_MSSQL_AVAILABILITY_GROUP")]
        MSSQL_ROOT_PROPERTIES_ROOT_TYPE_MSSQL_AVAILABILITY_GROUP,

        [EnumMember(Value = "MSSQL_ROOT_PROPERTIES_ROOT_TYPE_WINDOWS_CLUSTER")]
        MSSQL_ROOT_PROPERTIES_ROOT_TYPE_WINDOWS_CLUSTER,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum MssqlRootPropertiesRootType

} // namespace RubrikSecurityCloud.Types