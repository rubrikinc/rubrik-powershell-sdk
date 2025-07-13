// CloudDirectOfflineFilesBehaviour.cs
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
    public enum CloudDirectOfflineFilesBehaviour
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "READ")]
        READ,

        [EnumMember(Value = "SKIP")]
        SKIP,

        [EnumMember(Value = "STUBONLY")]
        STUBONLY


    } // enum CloudDirectOfflineFilesBehaviour

} // namespace RubrikSecurityCloud.Types