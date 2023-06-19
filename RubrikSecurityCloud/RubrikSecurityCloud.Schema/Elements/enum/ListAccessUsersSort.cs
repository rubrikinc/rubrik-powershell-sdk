// ListAccessUsersSort.cs
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
    public enum ListAccessUsersSort
    {
        [EnumMember(Value = "EMAIL")]
        EMAIL,

        [EnumMember(Value = "NUM_ACTIVITIES")]
        NUM_ACTIVITIES,

        [EnumMember(Value = "NUM_ACTIVITY_DELTA")]
        NUM_ACTIVITY_DELTA,

        [EnumMember(Value = "USERNAME")]
        USERNAME


    } // enum ListAccessUsersSort

} // namespace RubrikSecurityCloud.Types