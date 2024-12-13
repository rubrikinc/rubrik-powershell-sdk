// PrivateEndpointErrors.cs
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
    public enum PrivateEndpointErrors
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AZURE_ERR")]
        AZURE_ERR,

        [EnumMember(Value = "ERR_UNSPECIFIED")]
        ERR_UNSPECIFIED,

        [EnumMember(Value = "INTERNAL")]
        INTERNAL,

        [EnumMember(Value = "INVALID_REQ_MSG")]
        INVALID_REQ_MSG,

        [EnumMember(Value = "NO_ERR")]
        NO_ERR,

        [EnumMember(Value = "NO_PENDING_PE")]
        NO_PENDING_PE


    } // enum PrivateEndpointErrors

} // namespace RubrikSecurityCloud.Types