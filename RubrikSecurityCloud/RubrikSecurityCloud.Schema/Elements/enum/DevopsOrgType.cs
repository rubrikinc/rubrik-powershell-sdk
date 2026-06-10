// DevopsOrgType.cs
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
    public enum DevopsOrgType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AZURE_DEVOPS")]
        AZURE_DEVOPS,

        [EnumMember(Value = "DEVOPS_ORG_TYPE_UNSPECIFIED")]
        DEVOPS_ORG_TYPE_UNSPECIFIED,

        [EnumMember(Value = "GITHUB")]
        GITHUB


    } // enum DevopsOrgType

} // namespace RubrikSecurityCloud.Types