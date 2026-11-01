// VsphereNamespaceStatus.cs
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
    public enum VsphereNamespaceStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CONFIGURING")]
        CONFIGURING,

        [EnumMember(Value = "ERROR")]
        ERROR,

        [EnumMember(Value = "REMOVING")]
        REMOVING,

        [EnumMember(Value = "RUNNING")]
        RUNNING


    } // enum VsphereNamespaceStatus

} // namespace RubrikSecurityCloud.Types