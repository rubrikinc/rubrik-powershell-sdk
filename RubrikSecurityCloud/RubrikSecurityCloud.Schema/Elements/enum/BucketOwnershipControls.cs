// BucketOwnershipControls.cs
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
    public enum BucketOwnershipControls
    {
        [EnumMember(Value = "BUCKET_OWNER_ENFORCED")]
        BUCKET_OWNER_ENFORCED,

        [EnumMember(Value = "BUCKET_OWNER_PREFERRED")]
        BUCKET_OWNER_PREFERRED,

        [EnumMember(Value = "OBJECT_WRITER")]
        OBJECT_WRITER,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum BucketOwnershipControls

} // namespace RubrikSecurityCloud.Types