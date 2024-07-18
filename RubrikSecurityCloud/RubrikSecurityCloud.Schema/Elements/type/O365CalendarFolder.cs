// O365CalendarFolder.cs
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
    #region O365CalendarFolder
 
    public class O365CalendarFolder: BaseType, O365ExchangeObject
    {
        #region members

        //      C# -> ExchangeItemHierarchyType? HierarchyType
        // GraphQL -> hierarchyType: ExchangeItemHierarchyType! (enum)
        [JsonProperty("hierarchyType")]
        public ExchangeItemHierarchyType? HierarchyType { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsCalendarGroup
        // GraphQL -> isCalendarGroup: Boolean! (scalar)
        [JsonProperty("isCalendarGroup")]
        public System.Boolean? IsCalendarGroup { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? ParentFolderId
        // GraphQL -> parentFolderId: String (scalar)
        [JsonProperty("parentFolderId")]
        public System.String? ParentFolderId { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        [JsonProperty("snapshotTime")]
        public DateTime? SnapshotTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365CalendarFolder";
    }

    public O365CalendarFolder Set(
        ExchangeItemHierarchyType? HierarchyType = null,
        System.String? Id = null,
        System.Boolean? IsCalendarGroup = null,
        System.String? Name = null,
        System.String? ParentFolderId = null,
        System.String? SnapshotId = null,
        DateTime? SnapshotTime = null
    ) 
    {
        if ( HierarchyType != null ) {
            this.HierarchyType = HierarchyType;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsCalendarGroup != null ) {
            this.IsCalendarGroup = IsCalendarGroup;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( ParentFolderId != null ) {
            this.ParentFolderId = ParentFolderId;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( SnapshotTime != null ) {
            this.SnapshotTime = SnapshotTime;
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
        //      C# -> ExchangeItemHierarchyType? HierarchyType
        // GraphQL -> hierarchyType: ExchangeItemHierarchyType! (enum)
        if (this.HierarchyType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hierarchyType\n" ;
            } else {
                s += ind + "hierarchyType\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsCalendarGroup
        // GraphQL -> isCalendarGroup: Boolean! (scalar)
        if (this.IsCalendarGroup != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isCalendarGroup\n" ;
            } else {
                s += ind + "isCalendarGroup\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? ParentFolderId
        // GraphQL -> parentFolderId: String (scalar)
        if (this.ParentFolderId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "parentFolderId\n" ;
            } else {
                s += ind + "parentFolderId\n" ;
            }
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        if (this.SnapshotTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotTime\n" ;
            } else {
                s += ind + "snapshotTime\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ExchangeItemHierarchyType? HierarchyType
        // GraphQL -> hierarchyType: ExchangeItemHierarchyType! (enum)
        if (ec.Includes("hierarchyType",true))
        {
            if(this.HierarchyType == null) {

                this.HierarchyType = new ExchangeItemHierarchyType();

            } else {


            }
        }
        else if (this.HierarchyType != null && ec.Excludes("hierarchyType",true))
        {
            this.HierarchyType = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Boolean? IsCalendarGroup
        // GraphQL -> isCalendarGroup: Boolean! (scalar)
        if (ec.Includes("isCalendarGroup",true))
        {
            if(this.IsCalendarGroup == null) {

                this.IsCalendarGroup = true;

            } else {


            }
        }
        else if (this.IsCalendarGroup != null && ec.Excludes("isCalendarGroup",true))
        {
            this.IsCalendarGroup = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? ParentFolderId
        // GraphQL -> parentFolderId: String (scalar)
        if (ec.Includes("parentFolderId",true))
        {
            if(this.ParentFolderId == null) {

                this.ParentFolderId = "FETCH";

            } else {


            }
        }
        else if (this.ParentFolderId != null && ec.Excludes("parentFolderId",true))
        {
            this.ParentFolderId = null;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
        if (ec.Includes("snapshotId",true))
        {
            if(this.SnapshotId == null) {

                this.SnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotId != null && ec.Excludes("snapshotId",true))
        {
            this.SnapshotId = null;
        }
        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        if (ec.Includes("snapshotTime",true))
        {
            if(this.SnapshotTime == null) {

                this.SnapshotTime = new DateTime();

            } else {


            }
        }
        else if (this.SnapshotTime != null && ec.Excludes("snapshotTime",true))
        {
            this.SnapshotTime = null;
        }
    }


    #endregion

    } // class O365CalendarFolder
    
    #endregion

    public static class ListO365CalendarFolderExtensions
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
            this List<O365CalendarFolder> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<O365CalendarFolder> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<O365CalendarFolder> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365CalendarFolder());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365CalendarFolder> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types