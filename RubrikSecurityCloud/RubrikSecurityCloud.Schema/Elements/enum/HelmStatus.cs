// HelmStatus.cs
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
    public enum HelmStatus
    {
        [EnumMember(Value = "OK")]
        OK,

        [EnumMember(Value = "STALE_CDM")]
        STALE_CDM,

        [EnumMember(Value = "STALE_HELM")]
        STALE_HELM,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum HelmStatus

} // namespace RubrikSecurityCloud.Types