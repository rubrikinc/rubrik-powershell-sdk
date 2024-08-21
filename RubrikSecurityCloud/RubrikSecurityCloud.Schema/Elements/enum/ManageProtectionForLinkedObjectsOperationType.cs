// ManageProtectionForLinkedObjectsOperationType.cs
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
    public enum ManageProtectionForLinkedObjectsOperationType
    {
        [EnumMember(Value = "ASSIGN_SLA")]
        ASSIGN_SLA,

        [EnumMember(Value = "LINK")]
        LINK,

        [EnumMember(Value = "UNLINK")]
        UNLINK,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ManageProtectionForLinkedObjectsOperationType

} // namespace RubrikSecurityCloud.Types