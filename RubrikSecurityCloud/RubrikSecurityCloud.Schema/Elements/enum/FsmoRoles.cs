// FsmoRoles.cs
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
    public enum FsmoRoles
    {
        [EnumMember(Value = "DOMAIN_NAMING_MASTER")]
        DOMAIN_NAMING_MASTER,

        [EnumMember(Value = "INFRASTRUCTURE_MASTER")]
        INFRASTRUCTURE_MASTER,

        [EnumMember(Value = "PDC_EMULATOR")]
        PDC_EMULATOR,

        [EnumMember(Value = "RID_MASTER")]
        RID_MASTER,

        [EnumMember(Value = "SCHEMA_MASTER")]
        SCHEMA_MASTER


    } // enum FsmoRoles

} // namespace RubrikSecurityCloud.Types