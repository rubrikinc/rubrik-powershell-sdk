// RubrikCloudVaultType.cs
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
    public enum RubrikCloudVaultType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CLOUD_NATIVE")]
        CLOUD_NATIVE,

        [EnumMember(Value = "DATA_CENTER")]
        DATA_CENTER,

        [EnumMember(Value = "NAS_CD")]
        NAS_CD,

        [EnumMember(Value = "USE_CASE_TYPE_UNSPECIFIED")]
        USE_CASE_TYPE_UNSPECIFIED


    } // enum RubrikCloudVaultType

} // namespace RubrikSecurityCloud.Types