// GroupCountListWithTotal.cs
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
    #region GroupCountListWithTotal
    public class GroupCountListWithTotal: BaseType
    {
        #region members

        //      C# -> System.Int32? TotalCount
        // GraphQL -> totalCount: Int! (scalar)
        [JsonProperty("totalCount")]
        public System.Int32? TotalCount { get; set; }

        //      C# -> List<GroupCount>? GroupList
        // GraphQL -> groupList: [GroupCount!]! (type)
        [JsonProperty("groupList")]
        public List<GroupCount>? GroupList { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GroupCountListWithTotal";
    }

    public GroupCountListWithTotal Set(
        System.Int32? TotalCount = null,
        List<GroupCount>? GroupList = null
    ) 
    {
        if ( TotalCount != null ) {
            this.TotalCount = TotalCount;
        }
        if ( GroupList != null ) {
            this.GroupList = GroupList;
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
        //      C# -> System.Int32? TotalCount
        // GraphQL -> totalCount: Int! (scalar)
        if (this.TotalCount != null) {
            s += ind + "totalCount\n" ;
        }
        //      C# -> List<GroupCount>? GroupList
        // GraphQL -> groupList: [GroupCount!]! (type)
        if (this.GroupList != null) {
            var fspec = this.GroupList.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "groupList {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? TotalCount
        // GraphQL -> totalCount: Int! (scalar)
        if (this.TotalCount == null && ec.Includes("totalCount",true))
        {
            this.TotalCount = Int32.MinValue;
        }
        //      C# -> List<GroupCount>? GroupList
        // GraphQL -> groupList: [GroupCount!]! (type)
        if (this.GroupList == null && ec.Includes("groupList",false))
        {
            this.GroupList = new List<GroupCount>();
            this.GroupList.ApplyExploratoryFieldSpec(ec.NewChild("groupList"));
        }
    }


    #endregion

    } // class GroupCountListWithTotal
    
    #endregion

    public static class ListGroupCountListWithTotalExtensions
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
            this List<GroupCountListWithTotal> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GroupCountListWithTotal> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GroupCountListWithTotal());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<GroupCountListWithTotal> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types