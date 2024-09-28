// ManagedObjectSummary.cs
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
    #region ManagedObjectSummary
    public class ManagedObjectSummary: BaseType
    {
        #region members

        //      C# -> ManagedObjectType? ObjectType
        // GraphQL -> objectType: ManagedObjectType! (enum)
        [JsonProperty("objectType")]
        public ManagedObjectType? ObjectType { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? ParentIdForConflictingAssignment
        // GraphQL -> parentIdForConflictingAssignment: String (scalar)
        [JsonProperty("parentIdForConflictingAssignment")]
        public System.String? ParentIdForConflictingAssignment { get; set; }

        //      C# -> SlaDomainSummary? SlaDomain
        // GraphQL -> slaDomain: SlaDomainSummary (type)
        [JsonProperty("slaDomain")]
        public SlaDomainSummary? SlaDomain { get; set; }

        //      C# -> List<SnapshotDetails>? SnapshotsDetails
        // GraphQL -> snapshotsDetails: [SnapshotDetails!]! (type)
        [JsonProperty("snapshotsDetails")]
        public List<SnapshotDetails>? SnapshotsDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ManagedObjectSummary";
    }

    public ManagedObjectSummary Set(
        ManagedObjectType? ObjectType = null,
        System.String? Id = null,
        System.String? Name = null,
        System.String? ParentIdForConflictingAssignment = null,
        SlaDomainSummary? SlaDomain = null,
        List<SnapshotDetails>? SnapshotsDetails = null
    ) 
    {
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( ParentIdForConflictingAssignment != null ) {
            this.ParentIdForConflictingAssignment = ParentIdForConflictingAssignment;
        }
        if ( SlaDomain != null ) {
            this.SlaDomain = SlaDomain;
        }
        if ( SnapshotsDetails != null ) {
            this.SnapshotsDetails = SnapshotsDetails;
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
        //      C# -> ManagedObjectType? ObjectType
        // GraphQL -> objectType: ManagedObjectType! (enum)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? ParentIdForConflictingAssignment
        // GraphQL -> parentIdForConflictingAssignment: String (scalar)
        if (this.ParentIdForConflictingAssignment != null) {
            if (conf.Flat) {
                s += conf.Prefix + "parentIdForConflictingAssignment\n" ;
            } else {
                s += ind + "parentIdForConflictingAssignment\n" ;
            }
        }
        //      C# -> SlaDomainSummary? SlaDomain
        // GraphQL -> slaDomain: SlaDomainSummary (type)
        if (this.SlaDomain != null) {
            var fspec = this.SlaDomain.AsFieldSpec(conf.Child("slaDomain"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "slaDomain" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<SnapshotDetails>? SnapshotsDetails
        // GraphQL -> snapshotsDetails: [SnapshotDetails!]! (type)
        if (this.SnapshotsDetails != null) {
            var fspec = this.SnapshotsDetails.AsFieldSpec(conf.Child("snapshotsDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotsDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ManagedObjectType? ObjectType
        // GraphQL -> objectType: ManagedObjectType! (enum)
        if (ec.Includes("objectType",true))
        {
            if(this.ObjectType == null) {

                this.ObjectType = new ManagedObjectType();

            } else {


            }
        }
        else if (this.ObjectType != null && ec.Excludes("objectType",true))
        {
            this.ObjectType = null;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
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
        //      C# -> System.String? ParentIdForConflictingAssignment
        // GraphQL -> parentIdForConflictingAssignment: String (scalar)
        if (ec.Includes("parentIdForConflictingAssignment",true))
        {
            if(this.ParentIdForConflictingAssignment == null) {

                this.ParentIdForConflictingAssignment = "FETCH";

            } else {


            }
        }
        else if (this.ParentIdForConflictingAssignment != null && ec.Excludes("parentIdForConflictingAssignment",true))
        {
            this.ParentIdForConflictingAssignment = null;
        }
        //      C# -> SlaDomainSummary? SlaDomain
        // GraphQL -> slaDomain: SlaDomainSummary (type)
        if (ec.Includes("slaDomain",false))
        {
            if(this.SlaDomain == null) {

                this.SlaDomain = new SlaDomainSummary();
                this.SlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("slaDomain"));

            } else {

                this.SlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("slaDomain"));

            }
        }
        else if (this.SlaDomain != null && ec.Excludes("slaDomain",false))
        {
            this.SlaDomain = null;
        }
        //      C# -> List<SnapshotDetails>? SnapshotsDetails
        // GraphQL -> snapshotsDetails: [SnapshotDetails!]! (type)
        if (ec.Includes("snapshotsDetails",false))
        {
            if(this.SnapshotsDetails == null) {

                this.SnapshotsDetails = new List<SnapshotDetails>();
                this.SnapshotsDetails.ApplyExploratoryFieldSpec(ec.NewChild("snapshotsDetails"));

            } else {

                this.SnapshotsDetails.ApplyExploratoryFieldSpec(ec.NewChild("snapshotsDetails"));

            }
        }
        else if (this.SnapshotsDetails != null && ec.Excludes("snapshotsDetails",false))
        {
            this.SnapshotsDetails = null;
        }
    }


    #endregion

    } // class ManagedObjectSummary
    
    #endregion

    public static class ListManagedObjectSummaryExtensions
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
            this List<ManagedObjectSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ManagedObjectSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ManagedObjectSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedObjectSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ManagedObjectSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types