// RpoLagInfo.cs
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
    #region RpoLagInfo
    public class RpoLagInfo: BaseType
    {
        #region members

        //      C# -> System.Int64? ActualInSecs
        // GraphQL -> actualInSecs: Long! (scalar)
        [JsonProperty("actualInSecs")]
        public System.Int64? ActualInSecs { get; set; }

        //      C# -> System.Int64? ExpectedInSecs
        // GraphQL -> expectedInSecs: Long! (scalar)
        [JsonProperty("expectedInSecs")]
        public System.Int64? ExpectedInSecs { get; set; }

        //      C# -> System.String? Level
        // GraphQL -> level: String! (scalar)
        [JsonProperty("level")]
        public System.String? Level { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RpoLagInfo";
    }

    public RpoLagInfo Set(
        System.Int64? ActualInSecs = null,
        System.Int64? ExpectedInSecs = null,
        System.String? Level = null
    ) 
    {
        if ( ActualInSecs != null ) {
            this.ActualInSecs = ActualInSecs;
        }
        if ( ExpectedInSecs != null ) {
            this.ExpectedInSecs = ExpectedInSecs;
        }
        if ( Level != null ) {
            this.Level = Level;
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
        //      C# -> System.Int64? ActualInSecs
        // GraphQL -> actualInSecs: Long! (scalar)
        if (this.ActualInSecs != null) {
            s += ind + "actualInSecs\n" ;
        }
        //      C# -> System.Int64? ExpectedInSecs
        // GraphQL -> expectedInSecs: Long! (scalar)
        if (this.ExpectedInSecs != null) {
            s += ind + "expectedInSecs\n" ;
        }
        //      C# -> System.String? Level
        // GraphQL -> level: String! (scalar)
        if (this.Level != null) {
            s += ind + "level\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? ActualInSecs
        // GraphQL -> actualInSecs: Long! (scalar)
        if (this.ActualInSecs == null && ec.Includes("actualInSecs",true))
        {
            this.ActualInSecs = new System.Int64();
        }
        //      C# -> System.Int64? ExpectedInSecs
        // GraphQL -> expectedInSecs: Long! (scalar)
        if (this.ExpectedInSecs == null && ec.Includes("expectedInSecs",true))
        {
            this.ExpectedInSecs = new System.Int64();
        }
        //      C# -> System.String? Level
        // GraphQL -> level: String! (scalar)
        if (this.Level == null && ec.Includes("level",true))
        {
            this.Level = "FETCH";
        }
    }


    #endregion

    } // class RpoLagInfo
    
    #endregion

    public static class ListRpoLagInfoExtensions
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
            this List<RpoLagInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RpoLagInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RpoLagInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<RpoLagInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types