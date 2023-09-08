// UserAuditGroupByInfo.cs
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
    #region UserAuditGroupByInfo
    public class UserAuditGroupByInfo: BaseType
    {
        #region members

        //      C# -> UserAuditGroupBy? GroupByField
        // GraphQL -> groupByField: UserAuditGroupBy! (enum)
        [JsonProperty("groupByField")]
        public UserAuditGroupBy? GroupByField { get; set; }

        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        [JsonProperty("count")]
        public System.Int64? Count { get; set; }

        //      C# -> System.String? GroupByValue
        // GraphQL -> groupByValue: String! (scalar)
        [JsonProperty("groupByValue")]
        public System.String? GroupByValue { get; set; }

        //      C# -> List<UserAuditGroupByBase>? SecondaryGroupByInfo
        // GraphQL -> secondaryGroupByInfo: [UserAuditGroupByBase!]! (type)
        [JsonProperty("secondaryGroupByInfo")]
        public List<UserAuditGroupByBase>? SecondaryGroupByInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UserAuditGroupByInfo";
    }

    public UserAuditGroupByInfo Set(
        UserAuditGroupBy? GroupByField = null,
        System.Int64? Count = null,
        System.String? GroupByValue = null,
        List<UserAuditGroupByBase>? SecondaryGroupByInfo = null
    ) 
    {
        if ( GroupByField != null ) {
            this.GroupByField = GroupByField;
        }
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( GroupByValue != null ) {
            this.GroupByValue = GroupByValue;
        }
        if ( SecondaryGroupByInfo != null ) {
            this.SecondaryGroupByInfo = SecondaryGroupByInfo;
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
        //      C# -> UserAuditGroupBy? GroupByField
        // GraphQL -> groupByField: UserAuditGroupBy! (enum)
        if (this.GroupByField != null) {
            s += ind + "groupByField\n" ;
        }
        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        if (this.Count != null) {
            s += ind + "count\n" ;
        }
        //      C# -> System.String? GroupByValue
        // GraphQL -> groupByValue: String! (scalar)
        if (this.GroupByValue != null) {
            s += ind + "groupByValue\n" ;
        }
        //      C# -> List<UserAuditGroupByBase>? SecondaryGroupByInfo
        // GraphQL -> secondaryGroupByInfo: [UserAuditGroupByBase!]! (type)
        if (this.SecondaryGroupByInfo != null) {
            var fspec = this.SecondaryGroupByInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "secondaryGroupByInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> UserAuditGroupBy? GroupByField
        // GraphQL -> groupByField: UserAuditGroupBy! (enum)
        if (this.GroupByField == null && ec.Includes("groupByField",true))
        {
            this.GroupByField = new UserAuditGroupBy();
        }
        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        if (this.Count == null && ec.Includes("count",true))
        {
            this.Count = new System.Int64();
        }
        //      C# -> System.String? GroupByValue
        // GraphQL -> groupByValue: String! (scalar)
        if (this.GroupByValue == null && ec.Includes("groupByValue",true))
        {
            this.GroupByValue = "FETCH";
        }
        //      C# -> List<UserAuditGroupByBase>? SecondaryGroupByInfo
        // GraphQL -> secondaryGroupByInfo: [UserAuditGroupByBase!]! (type)
        if (this.SecondaryGroupByInfo == null && ec.Includes("secondaryGroupByInfo",false))
        {
            this.SecondaryGroupByInfo = new List<UserAuditGroupByBase>();
            this.SecondaryGroupByInfo.ApplyExploratoryFieldSpec(ec.NewChild("secondaryGroupByInfo"));
        }
    }


    #endregion

    } // class UserAuditGroupByInfo
    
    #endregion

    public static class ListUserAuditGroupByInfoExtensions
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
            this List<UserAuditGroupByInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UserAuditGroupByInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UserAuditGroupByInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<UserAuditGroupByInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types