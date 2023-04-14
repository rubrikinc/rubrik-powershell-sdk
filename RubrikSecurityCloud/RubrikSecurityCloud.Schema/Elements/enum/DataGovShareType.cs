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

namespace Rubrik.SecurityCloud.Types
{
    public enum DataGovShareType
    {
        [EnumMember(Value = "NFS")]
        NFS,

        [EnumMember(Value = "SMB")]
        SMB,

        [EnumMember(Value = "UNKNOWN_SHARE_TYPE")]
        UNKNOWN_SHARE_TYPE


    } // enum DataGovShareType

} // namespace Rubrik.SecurityCloud.Types