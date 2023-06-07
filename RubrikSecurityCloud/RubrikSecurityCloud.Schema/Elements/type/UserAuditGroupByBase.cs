// UserAuditGroupByBase.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region UserAuditGroupByBase
    public class UserAuditGroupByBase: BaseType
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


        #endregion

    #region methods

    public UserAuditGroupByBase Set(
        UserAuditGroupBy? GroupByField = null,
        System.Int64? Count = null,
        System.String? GroupByValue = null
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
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> UserAuditGroupBy? GroupByField
        // GraphQL -> groupByField: UserAuditGroupBy! (enum)
        if (this.GroupByField == null && Exploration.Includes(parent + ".groupByField", true))
        {
            this.GroupByField = new UserAuditGroupBy();
        }
        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        if (this.Count == null && Exploration.Includes(parent + ".count", true))
        {
            this.Count = new System.Int64();
        }
        //      C# -> System.String? GroupByValue
        // GraphQL -> groupByValue: String! (scalar)
        if (this.GroupByValue == null && Exploration.Includes(parent + ".groupByValue", true))
        {
            this.GroupByValue = "FETCH";
        }
    }


    #endregion

    } // class UserAuditGroupByBase
    
    #endregion

    public static class ListUserAuditGroupByBaseExtensions
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
            this List<UserAuditGroupByBase> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UserAuditGroupByBase> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new UserAuditGroupByBase());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types