// DataGovShareType.cs
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
    public enum DataGovShareType
    {
        [EnumMember(Value = "NFS")]
        NFS,

        [EnumMember(Value = "SMB")]
        SMB,

        [EnumMember(Value = "UNKNOWN_SHARE_TYPE")]
        UNKNOWN_SHARE_TYPE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum DataGovShareType

} // namespace RubrikSecurityCloud.Types