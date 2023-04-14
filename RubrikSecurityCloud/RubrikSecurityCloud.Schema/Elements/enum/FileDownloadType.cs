// FileDownloadType.cs
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
    public enum FileDownloadType
    {
        [EnumMember(Value = "DOWNLOAD_TO_CLOUD")]
        DOWNLOAD_TO_CLOUD,

        [EnumMember(Value = "DOWNLOAD_TO_VM")]
        DOWNLOAD_TO_VM,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED


    } // enum FileDownloadType

} // namespace Rubrik.SecurityCloud.Types