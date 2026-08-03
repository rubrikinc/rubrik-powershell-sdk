// AppAccessEdgeAnnotation.cs
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
    public enum AppAccessEdgeAnnotation
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "EDGE_ANNOTATION_ACCESS_GRANTED")]
        EDGE_ANNOTATION_ACCESS_GRANTED,

        [EnumMember(Value = "EDGE_ANNOTATION_ACCESS_REVOKED")]
        EDGE_ANNOTATION_ACCESS_REVOKED,

        [EnumMember(Value = "EDGE_ANNOTATION_MEMBERSHIP_ADDED")]
        EDGE_ANNOTATION_MEMBERSHIP_ADDED,

        [EnumMember(Value = "EDGE_ANNOTATION_MEMBERSHIP_REMOVED")]
        EDGE_ANNOTATION_MEMBERSHIP_REMOVED,

        [EnumMember(Value = "EDGE_ANNOTATION_NONE")]
        EDGE_ANNOTATION_NONE,

        [EnumMember(Value = "EDGE_ANNOTATION_PATH_ADDED")]
        EDGE_ANNOTATION_PATH_ADDED,

        [EnumMember(Value = "EDGE_ANNOTATION_PATH_REMOVED")]
        EDGE_ANNOTATION_PATH_REMOVED,

        [EnumMember(Value = "EDGE_ANNOTATION_TARGET_DELETED")]
        EDGE_ANNOTATION_TARGET_DELETED,

        [EnumMember(Value = "EDGE_ANNOTATION_UNSPECIFIED")]
        EDGE_ANNOTATION_UNSPECIFIED


    } // enum AppAccessEdgeAnnotation

} // namespace RubrikSecurityCloud.Types