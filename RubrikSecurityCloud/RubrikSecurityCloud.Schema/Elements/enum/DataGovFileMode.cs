// DataGovFileMode.cs
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
    public enum DataGovFileMode
    {
        [EnumMember(Value = "DIRECTORY")]
        DIRECTORY,

        [EnumMember(Value = "FILE")]
        FILE,

        [EnumMember(Value = "SYMLINK")]
        SYMLINK,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum DataGovFileMode

} // namespace Rubrik.SecurityCloud.Types