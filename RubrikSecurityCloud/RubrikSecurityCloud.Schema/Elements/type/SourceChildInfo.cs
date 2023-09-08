// SourceChildInfo.cs
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
    #region SourceChildInfo
    public class SourceChildInfo: BaseType
    {
        #region members

        //      C# -> System.String? FailoverChildId
        // GraphQL -> failoverChildId: String! (scalar)
        [JsonProperty("failoverChildId")]
        public System.String? FailoverChildId { get; set; }

        //      C# -> ChildInfo? ChildInfo
        // GraphQL -> childInfo: ChildInfo! (type)
        [JsonProperty("childInfo")]
        public ChildInfo? ChildInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SourceChildInfo";
    }

    public SourceChildInfo Set(
        System.String? FailoverChildId = null,
        ChildInfo? ChildInfo = null
    ) 
    {
        if ( FailoverChildId != null ) {
            this.FailoverChildId = FailoverChildId;
        }
        if ( ChildInfo != null ) {
            this.ChildInfo = ChildInfo;
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
        //      C# -> System.String? FailoverChildId
        // GraphQL -> failoverChildId: String! (scalar)
        if (this.FailoverChildId != null) {
            s += ind + "failoverChildId\n" ;
        }
        //      C# -> ChildInfo? ChildInfo
        // GraphQL -> childInfo: ChildInfo! (type)
        if (this.ChildInfo != null) {
            var fspec = this.ChildInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "childInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? FailoverChildId
        // GraphQL -> failoverChildId: String! (scalar)
        if (this.FailoverChildId == null && ec.Includes("failoverChildId",true))
        {
            this.FailoverChildId = "FETCH";
        }
        //      C# -> ChildInfo? ChildInfo
        // GraphQL -> childInfo: ChildInfo! (type)
        if (this.ChildInfo == null && ec.Includes("childInfo",false))
        {
            this.ChildInfo = new ChildInfo();
            this.ChildInfo.ApplyExploratoryFieldSpec(ec.NewChild("childInfo"));
        }
    }


    #endregion

    } // class SourceChildInfo
    
    #endregion

    public static class ListSourceChildInfoExtensions
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
            this List<SourceChildInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SourceChildInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SourceChildInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<SourceChildInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types