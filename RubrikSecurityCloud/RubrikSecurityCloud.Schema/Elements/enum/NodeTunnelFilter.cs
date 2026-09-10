// NodeTunnelFilter.cs
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
    public enum NodeTunnelFilter
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "NODE_TUNNEL_FILTER_CLOSED")]
        NODE_TUNNEL_FILTER_CLOSED,

        [EnumMember(Value = "NODE_TUNNEL_FILTER_OPEN")]
        NODE_TUNNEL_FILTER_OPEN,

        [EnumMember(Value = "NODE_TUNNEL_FILTER_UNSPECIFIED")]
        NODE_TUNNEL_FILTER_UNSPECIFIED


    } // enum NodeTunnelFilter

} // namespace RubrikSecurityCloud.Types