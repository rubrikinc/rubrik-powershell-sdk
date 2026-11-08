// ApplicationWarningFlag.cs
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
    public enum ApplicationWarningFlag
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "APPLICATION_WARNING_FLAG_BACKUP_LOCATION_MISSING")]
        APPLICATION_WARNING_FLAG_BACKUP_LOCATION_MISSING,

        [EnumMember(Value = "APPLICATION_WARNING_FLAG_EXOCOMPUTE_MISSING")]
        APPLICATION_WARNING_FLAG_EXOCOMPUTE_MISSING,

        [EnumMember(Value = "APPLICATION_WARNING_FLAG_NON_COMPLIANT_SLA")]
        APPLICATION_WARNING_FLAG_NON_COMPLIANT_SLA,

        [EnumMember(Value = "APPLICATION_WARNING_FLAG_UNSPECIFIED")]
        APPLICATION_WARNING_FLAG_UNSPECIFIED


    } // enum ApplicationWarningFlag

} // namespace RubrikSecurityCloud.Types