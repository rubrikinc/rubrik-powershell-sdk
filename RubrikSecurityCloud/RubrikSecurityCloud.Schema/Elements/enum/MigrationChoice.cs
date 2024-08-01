// MigrationChoice.cs
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
    public enum MigrationChoice
    {
        [EnumMember(Value = "MIGRATION_CHOICE_UNSPECIFIED")]
        MIGRATION_CHOICE_UNSPECIFIED,

        [EnumMember(Value = "RSC")]
        RSC,

        [EnumMember(Value = "RSC_G")]
        RSC_G,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum MigrationChoice

} // namespace RubrikSecurityCloud.Types