// UnmanagedObjectAvailabilityFilter.cs
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
    public enum UnmanagedObjectAvailabilityFilter
    {
        [EnumMember(Value = "PROTECTED")]
        PROTECTED,

        [EnumMember(Value = "RELIC")]
        RELIC,

        [EnumMember(Value = "REMOTE_UNPROTECTED")]
        REMOTE_UNPROTECTED,

        [EnumMember(Value = "REPLICATED_RELIC")]
        REPLICATED_RELIC,

        [EnumMember(Value = "UNMANAGED_OBJECT_UNKNOWN")]
        UNMANAGED_OBJECT_UNKNOWN,

        [EnumMember(Value = "UNPROTECTED")]
        UNPROTECTED


    } // enum UnmanagedObjectAvailabilityFilter

} // namespace Rubrik.SecurityCloud.Types