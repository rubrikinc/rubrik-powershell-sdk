// MosaicAddStoreRequestStoreType.cs
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
    public enum MosaicAddStoreRequestStoreType
    {
        [EnumMember(Value = "MOSAIC_ADD_STORE_REQUEST_STORE_TYPE_AZURE_STORE")]
        MOSAIC_ADD_STORE_REQUEST_STORE_TYPE_AZURE_STORE,

        [EnumMember(Value = "MOSAIC_ADD_STORE_REQUEST_STORE_TYPE_GS_STORE")]
        MOSAIC_ADD_STORE_REQUEST_STORE_TYPE_GS_STORE,

        [EnumMember(Value = "MOSAIC_ADD_STORE_REQUEST_STORE_TYPE_NFS_STORE")]
        MOSAIC_ADD_STORE_REQUEST_STORE_TYPE_NFS_STORE,

        [EnumMember(Value = "MOSAIC_ADD_STORE_REQUEST_STORE_TYPE_S3_STORE")]
        MOSAIC_ADD_STORE_REQUEST_STORE_TYPE_S3_STORE


    } // enum MosaicAddStoreRequestStoreType

} // namespace Rubrik.SecurityCloud.Types