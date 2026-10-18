// StorageLocationPurpose.cs
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
    public enum StorageLocationPurpose
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ADO")]
        ADO,

        [EnumMember(Value = "CCES_BAAS")]
        CCES_BAAS,

        [EnumMember(Value = "CCES_PRIMARY")]
        CCES_PRIMARY,

        [EnumMember(Value = "CNP_BAAS")]
        CNP_BAAS,

        [EnumMember(Value = "PURPOSE_DEFAULT")]
        PURPOSE_DEFAULT


    } // enum StorageLocationPurpose

} // namespace RubrikSecurityCloud.Types