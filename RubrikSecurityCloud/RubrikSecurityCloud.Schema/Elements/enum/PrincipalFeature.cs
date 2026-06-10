// PrincipalFeature.cs
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
    public enum PrincipalFeature
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DAG")]
        DAG,

        [EnumMember(Value = "IR")]
        IR,

        [EnumMember(Value = "PRINCIPAL_FEATURE_UNSPECIFIED")]
        PRINCIPAL_FEATURE_UNSPECIFIED


    } // enum PrincipalFeature

} // namespace RubrikSecurityCloud.Types