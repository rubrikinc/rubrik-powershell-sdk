// Entry.cs
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
    #region Entry
    public class Entry: BaseType
    {
        #region members

        //      C# -> System.Single? Distance
        // GraphQL -> distance: Float! (scalar)
        [JsonProperty("distance")]
        public System.Single? Distance { get; set; }

        //      C# -> System.String? DocumentId
        // GraphQL -> documentId: String! (scalar)
        [JsonProperty("documentId")]
        public System.String? DocumentId { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: UUID! (scalar)
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? Text
        // GraphQL -> text: String! (scalar)
        [JsonProperty("text")]
        public System.String? Text { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Entry";
    }

    public Entry Set(
        System.Single? Distance = null,
        System.String? DocumentId = null,
        System.String? Id = null,
        System.String? ObjectId = null,
        System.String? SnapshotId = null,
        System.String? Text = null
    ) 
    {
        if ( Distance != null ) {
            this.Distance = Distance;
        }
        if ( DocumentId != null ) {
            this.DocumentId = DocumentId;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( ObjectId != null ) {
            this.ObjectId = ObjectId;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( Text != null ) {
            this.Text = Text;
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
        //      C# -> System.Single? Distance
        // GraphQL -> distance: Float! (scalar)
        if (this.Distance != null) {
            if (conf.Flat) {
                s += conf.Prefix + "distance\n" ;
            } else {
                s += ind + "distance\n" ;
            }
        }
        //      C# -> System.String? DocumentId
        // GraphQL -> documentId: String! (scalar)
        if (this.DocumentId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "documentId\n" ;
            } else {
                s += ind + "documentId\n" ;
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
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: UUID! (scalar)
        if (this.ObjectId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectId\n" ;
            } else {
                s += ind + "objectId\n" ;
            }
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        //      C# -> System.String? Text
        // GraphQL -> text: String! (scalar)
        if (this.Text != null) {
            if (conf.Flat) {
                s += conf.Prefix + "text\n" ;
            } else {
                s += ind + "text\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Single? Distance
        // GraphQL -> distance: Float! (scalar)
        if (ec.Includes("distance",true))
        {
            if(this.Distance == null) {

                this.Distance = new System.Single();

            } else {


            }
        }
        else if (this.Distance != null && ec.Excludes("distance",true))
        {
            this.Distance = null;
        }
        //      C# -> System.String? DocumentId
        // GraphQL -> documentId: String! (scalar)
        if (ec.Includes("documentId",true))
        {
            if(this.DocumentId == null) {

                this.DocumentId = "FETCH";

            } else {


            }
        }
        else if (this.DocumentId != null && ec.Excludes("documentId",true))
        {
            this.DocumentId = null;
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
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: UUID! (scalar)
        if (ec.Includes("objectId",true))
        {
            if(this.ObjectId == null) {

                this.ObjectId = "FETCH";

            } else {


            }
        }
        else if (this.ObjectId != null && ec.Excludes("objectId",true))
        {
            this.ObjectId = null;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
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
        //      C# -> System.String? Text
        // GraphQL -> text: String! (scalar)
        if (ec.Includes("text",true))
        {
            if(this.Text == null) {

                this.Text = "FETCH";

            } else {


            }
        }
        else if (this.Text != null && ec.Excludes("text",true))
        {
            this.Text = null;
        }
    }


    #endregion

    } // class Entry
    
    #endregion

    public static class ListEntryExtensions
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
            this List<Entry> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Entry> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Entry> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Entry());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Entry> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types