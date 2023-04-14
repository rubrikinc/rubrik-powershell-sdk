// StalenessType.cs
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
    public enum StalenessType
    {
        [EnumMember(Value = "IS_STALE")]
        IS_STALE,

        [EnumMember(Value = "NOT_STALE")]
        NOT_STALE


    } // enum StalenessType

} // namespace Rubrik.SecurityCloud.Types