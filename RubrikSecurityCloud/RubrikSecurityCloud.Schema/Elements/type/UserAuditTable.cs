// UserAuditTable.cs
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
    #region UserAuditTable
 
    public class UserAuditTable: BaseType, ReportTableType
    {
        #region members

        //      C# -> ReportFocusEnum? Focus
        // GraphQL -> focus: ReportFocusEnum! (enum)
        [JsonProperty("focus")]
        public ReportFocusEnum? Focus { get; set; }

        //      C# -> List<UserAuditGroupByEnum>? GroupBy
        // GraphQL -> groupBy: [UserAuditGroupByEnum!] (enum)
        [JsonProperty("groupBy")]
        public List<UserAuditGroupByEnum>? GroupBy { get; set; }

        //      C# -> List<UserAuditTableColumnEnum>? SelectedColumns
        // GraphQL -> selectedColumns: [UserAuditTableColumnEnum!]! (enum)
        [JsonProperty("selectedColumns")]
        public List<UserAuditTableColumnEnum>? SelectedColumns { get; set; }

        //      C# -> UserAuditSortByEnum? SortBy
        // GraphQL -> sortBy: UserAuditSortByEnum (enum)
        [JsonProperty("sortBy")]
        public UserAuditSortByEnum? SortBy { get; set; }

        //      C# -> SortOrder? SortOrder
        // GraphQL -> sortOrder: SortOrder (enum)
        [JsonProperty("sortOrder")]
        public SortOrder? SortOrder { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UserAuditTable";
    }

    public UserAuditTable Set(
        ReportFocusEnum? Focus = null,
        List<UserAuditGroupByEnum>? GroupBy = null,
        List<UserAuditTableColumnEnum>? SelectedColumns = null,
        UserAuditSortByEnum? SortBy = null,
        SortOrder? SortOrder = null,
        System.String? Name = null
    ) 
    {
        if ( Focus != null ) {
            this.Focus = Focus;
        }
        if ( GroupBy != null ) {
            this.GroupBy = GroupBy;
        }
        if ( SelectedColumns != null ) {
            this.SelectedColumns = SelectedColumns;
        }
        if ( SortBy != null ) {
            this.SortBy = SortBy;
        }
        if ( SortOrder != null ) {
            this.SortOrder = SortOrder;
        }
        if ( Name != null ) {
            this.Name = Name;
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
        //      C# -> ReportFocusEnum? Focus
        // GraphQL -> focus: ReportFocusEnum! (enum)
        if (this.Focus != null) {
            s += ind + "focus\n" ;
        }
        //      C# -> List<UserAuditGroupByEnum>? GroupBy
        // GraphQL -> groupBy: [UserAuditGroupByEnum!] (enum)
        if (this.GroupBy != null) {
            s += ind + "groupBy\n" ;
        }
        //      C# -> List<UserAuditTableColumnEnum>? SelectedColumns
        // GraphQL -> selectedColumns: [UserAuditTableColumnEnum!]! (enum)
        if (this.SelectedColumns != null) {
            s += ind + "selectedColumns\n" ;
        }
        //      C# -> UserAuditSortByEnum? SortBy
        // GraphQL -> sortBy: UserAuditSortByEnum (enum)
        if (this.SortBy != null) {
            s += ind + "sortBy\n" ;
        }
        //      C# -> SortOrder? SortOrder
        // GraphQL -> sortOrder: SortOrder (enum)
        if (this.SortOrder != null) {
            s += ind + "sortOrder\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ReportFocusEnum? Focus
        // GraphQL -> focus: ReportFocusEnum! (enum)
        if (this.Focus == null && ec.Includes("focus",true))
        {
            this.Focus = new ReportFocusEnum();
        }
        //      C# -> List<UserAuditGroupByEnum>? GroupBy
        // GraphQL -> groupBy: [UserAuditGroupByEnum!] (enum)
        if (this.GroupBy == null && ec.Includes("groupBy",true))
        {
            this.GroupBy = new List<UserAuditGroupByEnum>();
        }
        //      C# -> List<UserAuditTableColumnEnum>? SelectedColumns
        // GraphQL -> selectedColumns: [UserAuditTableColumnEnum!]! (enum)
        if (this.SelectedColumns == null && ec.Includes("selectedColumns",true))
        {
            this.SelectedColumns = new List<UserAuditTableColumnEnum>();
        }
        //      C# -> UserAuditSortByEnum? SortBy
        // GraphQL -> sortBy: UserAuditSortByEnum (enum)
        if (this.SortBy == null && ec.Includes("sortBy",true))
        {
            this.SortBy = new UserAuditSortByEnum();
        }
        //      C# -> SortOrder? SortOrder
        // GraphQL -> sortOrder: SortOrder (enum)
        if (this.SortOrder == null && ec.Includes("sortOrder",true))
        {
            this.SortOrder = new SortOrder();
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
    }


    #endregion

    } // class UserAuditTable
    
    #endregion

    public static class ListUserAuditTableExtensions
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
            this List<UserAuditTable> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UserAuditTable> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UserAuditTable());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<UserAuditTable> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types