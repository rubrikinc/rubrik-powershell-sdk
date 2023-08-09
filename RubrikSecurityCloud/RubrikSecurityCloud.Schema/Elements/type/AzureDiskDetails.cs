// AzureDiskDetails.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region AzureDiskDetails
    public class AzureDiskDetails: BaseType
    {
        #region members

        //      C# -> System.String? DiskNativeName
        // GraphQL -> diskNativeName: String! (scalar)
        [JsonProperty("diskNativeName")]
        public System.String? DiskNativeName { get; set; }

        //      C# -> System.Boolean? IsOsDisk
        // GraphQL -> isOsDisk: Boolean! (scalar)
        [JsonProperty("isOsDisk")]
        public System.Boolean? IsOsDisk { get; set; }

        //      C# -> System.String? MountedDiskId
        // GraphQL -> mountedDiskId: UUID! (scalar)
        [JsonProperty("mountedDiskId")]
        public System.String? MountedDiskId { get; set; }

        //      C# -> System.String? MountedDiskNativeId
        // GraphQL -> mountedDiskNativeId: UUID! (scalar)
        [JsonProperty("mountedDiskNativeId")]
        public System.String? MountedDiskNativeId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureDiskDetails";
    }

    public AzureDiskDetails Set(
        System.String? DiskNativeName = null,
        System.Boolean? IsOsDisk = null,
        System.String? MountedDiskId = null,
        System.String? MountedDiskNativeId = null
    ) 
    {
        if ( DiskNativeName != null ) {
            this.DiskNativeName = DiskNativeName;
        }
        if ( IsOsDisk != null ) {
            this.IsOsDisk = IsOsDisk;
        }
        if ( MountedDiskId != null ) {
            this.MountedDiskId = MountedDiskId;
        }
        if ( MountedDiskNativeId != null ) {
            this.MountedDiskNativeId = MountedDiskNativeId;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? DiskNativeName
        // GraphQL -> diskNativeName: String! (scalar)
        if (this.DiskNativeName != null) {
            s += ind + "diskNativeName\n" ;
        }
        //      C# -> System.Boolean? IsOsDisk
        // GraphQL -> isOsDisk: Boolean! (scalar)
        if (this.IsOsDisk != null) {
            s += ind + "isOsDisk\n" ;
        }
        //      C# -> System.String? MountedDiskId
        // GraphQL -> mountedDiskId: UUID! (scalar)
        if (this.MountedDiskId != null) {
            s += ind + "mountedDiskId\n" ;
        }
        //      C# -> System.String? MountedDiskNativeId
        // GraphQL -> mountedDiskNativeId: UUID! (scalar)
        if (this.MountedDiskNativeId != null) {
            s += ind + "mountedDiskNativeId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? DiskNativeName
        // GraphQL -> diskNativeName: String! (scalar)
        if (this.DiskNativeName == null && Exploration.Includes(parent + ".diskNativeName", true))
        {
            this.DiskNativeName = "FETCH";
        }
        //      C# -> System.Boolean? IsOsDisk
        // GraphQL -> isOsDisk: Boolean! (scalar)
        if (this.IsOsDisk == null && Exploration.Includes(parent + ".isOsDisk", true))
        {
            this.IsOsDisk = true;
        }
        //      C# -> System.String? MountedDiskId
        // GraphQL -> mountedDiskId: UUID! (scalar)
        if (this.MountedDiskId == null && Exploration.Includes(parent + ".mountedDiskId", true))
        {
            this.MountedDiskId = "FETCH";
        }
        //      C# -> System.String? MountedDiskNativeId
        // GraphQL -> mountedDiskNativeId: UUID! (scalar)
        if (this.MountedDiskNativeId == null && Exploration.Includes(parent + ".mountedDiskNativeId", true))
        {
            this.MountedDiskNativeId = "FETCH";
        }
    }


    #endregion

    } // class AzureDiskDetails
    
    #endregion

    public static class ListAzureDiskDetailsExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<AzureDiskDetails> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureDiskDetails> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureDiskDetails());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types