// NcdFilesObjectProtectionStatusData.cs
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
    #region NcdFilesObjectProtectionStatusData
    public class NcdFilesObjectProtectionStatusData: BaseType
    {
        #region members

        //      C# -> System.Int64? Protected
        // GraphQL -> protected: Long! (scalar)
        [JsonProperty("protected")]
        public System.Int64? Protected { get; set; }

        //      C# -> System.Int64? TotalSizeInBytes
        // GraphQL -> totalSizeInBytes: Long! (scalar)
        [JsonProperty("totalSizeInBytes")]
        public System.Int64? TotalSizeInBytes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NcdFilesObjectProtectionStatusData";
    }

    public NcdFilesObjectProtectionStatusData Set(
        System.Int64? Protected = null,
        System.Int64? TotalSizeInBytes = null
    ) 
    {
        if ( Protected != null ) {
            this.Protected = Protected;
        }
        if ( TotalSizeInBytes != null ) {
            this.TotalSizeInBytes = TotalSizeInBytes;
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
        //      C# -> System.Int64? Protected
        // GraphQL -> protected: Long! (scalar)
        if (this.Protected != null) {
            s += ind + "protected\n" ;
        }
        //      C# -> System.Int64? TotalSizeInBytes
        // GraphQL -> totalSizeInBytes: Long! (scalar)
        if (this.TotalSizeInBytes != null) {
            s += ind + "totalSizeInBytes\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? Protected
        // GraphQL -> protected: Long! (scalar)
        if (this.Protected == null && ec.Includes("protected",true))
        {
            this.Protected = new System.Int64();
        }
        //      C# -> System.Int64? TotalSizeInBytes
        // GraphQL -> totalSizeInBytes: Long! (scalar)
        if (this.TotalSizeInBytes == null && ec.Includes("totalSizeInBytes",true))
        {
            this.TotalSizeInBytes = new System.Int64();
        }
    }


    #endregion

    } // class NcdFilesObjectProtectionStatusData
    
    #endregion

    public static class ListNcdFilesObjectProtectionStatusDataExtensions
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
            this List<NcdFilesObjectProtectionStatusData> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NcdFilesObjectProtectionStatusData> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NcdFilesObjectProtectionStatusData());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<NcdFilesObjectProtectionStatusData> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types