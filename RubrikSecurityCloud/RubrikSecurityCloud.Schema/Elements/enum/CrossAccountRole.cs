// CrossAccountRole.cs
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
    public enum CrossAccountRole
    {
        [EnumMember(Value = "ROLE_UNSPECIFIED")]
        ROLE_UNSPECIFIED,

        [EnumMember(Value = "SERVICE_CONSUMER")]
        SERVICE_CONSUMER,

        [EnumMember(Value = "SERVICE_PROVIDER")]
        SERVICE_PROVIDER,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum CrossAccountRole

} // namespace RubrikSecurityCloud.Types