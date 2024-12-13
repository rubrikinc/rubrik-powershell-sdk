// GlobalCertificateSortBy.cs
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
    public enum GlobalCertificateSortBy
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "SORT_BY_EXPIRATION_DATE")]
        SORT_BY_EXPIRATION_DATE,

        [EnumMember(Value = "SORT_BY_NAME")]
        SORT_BY_NAME,

        [EnumMember(Value = "SORT_BY_UNSPECIFIED")]
        SORT_BY_UNSPECIFIED


    } // enum GlobalCertificateSortBy

} // namespace RubrikSecurityCloud.Types