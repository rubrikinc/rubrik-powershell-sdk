// ArchivalLocationOperationType.cs
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
    public enum ArchivalLocationOperationType
    {
        [EnumMember(Value = "CREATE_EDIT")]
        CREATE_EDIT,

        [EnumMember(Value = "DELETE")]
        DELETE,

        [EnumMember(Value = "OPERATION_UNSPECIFIED")]
        OPERATION_UNSPECIFIED,

        [EnumMember(Value = "PROMOTE_TO_OWNER")]
        PROMOTE_TO_OWNER,

        [EnumMember(Value = "READER_REFRESH")]
        READER_REFRESH,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ArchivalLocationOperationType

} // namespace RubrikSecurityCloud.Types