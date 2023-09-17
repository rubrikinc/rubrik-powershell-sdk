// NcdBackEndCapacity.cs
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
    #region NcdBackEndCapacity
    public class NcdBackEndCapacity: BaseType
    {
        #region members

        //      C# -> System.Int64? UsageInBytes
        // GraphQL -> usageInBytes: Long! (scalar)
        [JsonProperty("usageInBytes")]
        public System.Int64? UsageInBytes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NcdBackEndCapacity";
    }

    public NcdBackEndCapacity Set(
        System.Int64? UsageInBytes = null
    ) 
    {
        if ( UsageInBytes != null ) {
            this.UsageInBytes = UsageInBytes;
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
        //      C# -> System.Int64? UsageInBytes
        // GraphQL -> usageInBytes: Long! (scalar)
        if (this.UsageInBytes != null) {
            s += ind + "usageInBytes\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? UsageInBytes
        // GraphQL -> usageInBytes: Long! (scalar)
        if (this.UsageInBytes == null && ec.Includes("usageInBytes",true))
        {
            this.UsageInBytes = new System.Int64();
        }
    }


    #endregion

    } // class NcdBackEndCapacity
    
    #endregion

    public static class ListNcdBackEndCapacityExtensions
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
            this List<NcdBackEndCapacity> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NcdBackEndCapacity> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NcdBackEndCapacity());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NcdBackEndCapacity> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types