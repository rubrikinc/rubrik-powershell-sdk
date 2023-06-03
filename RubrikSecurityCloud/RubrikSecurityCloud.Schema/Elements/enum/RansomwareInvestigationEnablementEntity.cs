// RansomwareInvestigationEnablementEntity.cs
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
    public enum RansomwareInvestigationEnablementEntity
    {
        [EnumMember(Value = "CDM_CLUSTER")]
        CDM_CLUSTER,

        [EnumMember(Value = "MICROSOFT_365")]
        MICROSOFT_365,

        [EnumMember(Value = "RCV")]
        RCV,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum RansomwareInvestigationEnablementEntity

} // namespace Rubrik.SecurityCloud.Types