// MssqlRestoreEstimateResult.cs
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
    #region MssqlRestoreEstimateResult
    public class MssqlRestoreEstimateResult: BaseType
    {
        #region members

        //      C# -> System.Int64? BytesFromCloud
        // GraphQL -> bytesFromCloud: Long! (scalar)
        [JsonProperty("bytesFromCloud")]
        public System.Int64? BytesFromCloud { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MssqlRestoreEstimateResult";
    }

    public MssqlRestoreEstimateResult Set(
        System.Int64? BytesFromCloud = null
    ) 
    {
        if ( BytesFromCloud != null ) {
            this.BytesFromCloud = BytesFromCloud;
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
        //      C# -> System.Int64? BytesFromCloud
        // GraphQL -> bytesFromCloud: Long! (scalar)
        if (this.BytesFromCloud != null) {
            s += ind + "bytesFromCloud\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? BytesFromCloud
        // GraphQL -> bytesFromCloud: Long! (scalar)
        if (this.BytesFromCloud == null && ec.Includes("bytesFromCloud",true))
        {
            this.BytesFromCloud = new System.Int64();
        }
    }


    #endregion

    } // class MssqlRestoreEstimateResult
    
    #endregion

    public static class ListMssqlRestoreEstimateResultExtensions
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
            this List<MssqlRestoreEstimateResult> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MssqlRestoreEstimateResult> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlRestoreEstimateResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<MssqlRestoreEstimateResult> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types