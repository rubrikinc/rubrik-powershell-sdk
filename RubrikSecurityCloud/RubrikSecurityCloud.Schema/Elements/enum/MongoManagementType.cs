// MongoManagementType.cs
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
    public enum MongoManagementType
    {
        [EnumMember(Value = "INVALID_MANAGEMENT_TYPE")]
        INVALID_MANAGEMENT_TYPE,

        [EnumMember(Value = "NATIVE")]
        NATIVE,

        [EnumMember(Value = "OPSMANAGER")]
        OPSMANAGER


    } // enum MongoManagementType

} // namespace RubrikSecurityCloud.Types