// MosaicStoreObjectStoreType.cs
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

namespace Rubrik.SecurityCloud.Types
{
    public enum MosaicStoreObjectStoreType
    {
        [EnumMember(Value = "MOSAIC_STORE_OBJECT_STORE_TYPE_AZURE_STORE")]
        MOSAIC_STORE_OBJECT_STORE_TYPE_AZURE_STORE,

        [EnumMember(Value = "MOSAIC_STORE_OBJECT_STORE_TYPE_GS_STORE")]
        MOSAIC_STORE_OBJECT_STORE_TYPE_GS_STORE,

        [EnumMember(Value = "MOSAIC_STORE_OBJECT_STORE_TYPE_NFS_STORE")]
        MOSAIC_STORE_OBJECT_STORE_TYPE_NFS_STORE,

        [EnumMember(Value = "MOSAIC_STORE_OBJECT_STORE_TYPE_S3_STORE")]
        MOSAIC_STORE_OBJECT_STORE_TYPE_S3_STORE,

        [EnumMember(Value = "MOSAIC_STORE_OBJECT_STORE_TYPE_SWIFT_STORE")]
        MOSAIC_STORE_OBJECT_STORE_TYPE_SWIFT_STORE,

        [EnumMember(Value = "MOSAIC_STORE_OBJECT_STORE_TYPE_VFS_STORE")]
        MOSAIC_STORE_OBJECT_STORE_TYPE_VFS_STORE


    } // enum MosaicStoreObjectStoreType

} // namespace Rubrik.SecurityCloud.Types