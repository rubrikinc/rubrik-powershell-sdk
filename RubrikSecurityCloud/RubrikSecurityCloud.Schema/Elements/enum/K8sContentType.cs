// K8sContentType.cs
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
    public enum K8sContentType
    {
        [EnumMember(Value = "STRING")]
        STRING,

        [EnumMember(Value = "URL")]
        URL,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum K8sContentType

} // namespace RubrikSecurityCloud.Types