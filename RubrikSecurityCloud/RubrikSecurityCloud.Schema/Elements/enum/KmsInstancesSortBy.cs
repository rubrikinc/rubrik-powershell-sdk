// KmsInstancesSortBy.cs
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
    public enum KmsInstancesSortBy
    {
        [EnumMember(Value = "DATA_LOCATIONS_COUNT")]
        DATA_LOCATIONS_COUNT,

        [EnumMember(Value = "KMS_DESCRIPTION")]
        KMS_DESCRIPTION,

        [EnumMember(Value = "KMS_IDENTIFIER")]
        KMS_IDENTIFIER,

        [EnumMember(Value = "KMS_NAME")]
        KMS_NAME,

        [EnumMember(Value = "KMS_SORT_BY_UNSPECIFIED")]
        KMS_SORT_BY_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum KmsInstancesSortBy

} // namespace RubrikSecurityCloud.Types