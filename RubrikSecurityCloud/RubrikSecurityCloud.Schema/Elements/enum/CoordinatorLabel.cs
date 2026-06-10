// CoordinatorLabel.cs
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
    public enum CoordinatorLabel
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "BACKUP_SUITE")]
        BACKUP_SUITE,

        [EnumMember(Value = "COPY")]
        COPY,

        [EnumMember(Value = "DISCOVER")]
        DISCOVER,

        [EnumMember(Value = "RESTORE")]
        RESTORE


    } // enum CoordinatorLabel

} // namespace RubrikSecurityCloud.Types