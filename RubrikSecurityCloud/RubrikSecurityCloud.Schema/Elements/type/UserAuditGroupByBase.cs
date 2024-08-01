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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "UserAuditGroupByBase";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> UserAuditGroupBy? GroupByField
        // GraphQL -> groupByField: UserAuditGroupBy! (enum)
        if (this.GroupByField != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupByField\n" ;
            } else {
                s += ind + "groupByField\n" ;
            }
        }
        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        if (this.Count != null) {
            if (conf.Flat) {
                s += conf.Prefix + "count\n" ;
            } else {
                s += ind + "count\n" ;
            }
        }
        //      C# -> System.String? GroupByValue
        // GraphQL -> groupByValue: String! (scalar)
        if (this.GroupByValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupByValue\n" ;
            } else {
                s += ind + "groupByValue\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> UserAuditGroupBy? GroupByField
        // GraphQL -> groupByField: UserAuditGroupBy! (enum)
        if (ec.Includes("groupByField",true))
        {
            if(this.GroupByField == null) {

                this.GroupByField = new UserAuditGroupBy();

            } else {


            }
        }
        else if (this.GroupByField != null && ec.Excludes("groupByField",true))
        {
            this.GroupByField = null;
        }
        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        if (ec.Includes("count",true))
        {
            if(this.Count == null) {

                this.Count = new System.Int64();

            } else {


            }
        }
        else if (this.Count != null && ec.Excludes("count",true))
        {
            this.Count = null;
        }
        //      C# -> System.String? GroupByValue
        // GraphQL -> groupByValue: String! (scalar)
        if (ec.Includes("groupByValue",true))
        {
            if(this.GroupByValue == null) {

                this.GroupByValue = "FETCH";

            } else {


            }
        }
        else if (this.GroupByValue != null && ec.Excludes("groupByValue",true))
        {
            this.GroupByValue = null;
        }
    }


    #endregion

    } // class UserAuditGroupByBase
    
    #endregion

    public static class ListUserAuditGroupByBaseExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<UserAuditGroupByBase> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UserAuditGroupByBase> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UserAuditGroupByBase> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UserAuditGroupByBase());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UserAuditGroupByBase> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types