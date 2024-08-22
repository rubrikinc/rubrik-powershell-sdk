// MosaicStoreType.cs
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
    public enum MosaicStoreType
    {
        [EnumMember(Value = "AZURE_STORE")]
        AZURE_STORE,

        [EnumMember(Value = "GS_STORE")]
        GS_STORE,

        [EnumMember(Value = "NFS_STORE")]
        NFS_STORE,

        [EnumMember(Value = "S3_STORE")]
        S3_STORE,

        [EnumMember(Value = "TYPE_UNAVAILABLE")]
        TYPE_UNAVAILABLE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum MosaicStoreType

} // namespace RubrikSecurityCloud.Types