// ClosestSnapshotSearchResult.cs
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
    #region ClosestSnapshotSearchResult
    public class ClosestSnapshotSearchResult: BaseType
    {
        #region members

        //      C# -> SnapshotSearchError? Error
        // GraphQL -> error: SnapshotSearchError (enum)
        [JsonProperty("error")]
        public SnapshotSearchError? Error { get; set; }

        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        [JsonProperty("snappableId")]
        public System.String? SnappableId { get; set; }

        //      C# -> ClosestSnapshotDetail? Snapshot
        // GraphQL -> snapshot: ClosestSnapshotDetail (type)
        [JsonProperty("snapshot")]
        public ClosestSnapshotDetail? Snapshot { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClosestSnapshotSearchResult";
    }

    public ClosestSnapshotSearchResult Set(
        SnapshotSearchError? Error = null,
        System.String? SnappableId = null,
        ClosestSnapshotDetail? Snapshot = null
    ) 
    {
        if ( Error != null ) {
            this.Error = Error;
        }
        if ( SnappableId != null ) {
            this.SnappableId = SnappableId;
        }
        if ( Snapshot != null ) {
            this.Snapshot = Snapshot;
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
        //      C# -> SnapshotSearchError? Error
        // GraphQL -> error: SnapshotSearchError (enum)
        if (this.Error != null) {
            if (conf.Flat) {
                s += conf.Prefix + "error\n" ;
            } else {
                s += ind + "error\n" ;
            }
        }
        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        if (this.SnappableId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snappableId\n" ;
            } else {
                s += ind + "snappableId\n" ;
            }
        }
        //      C# -> ClosestSnapshotDetail? Snapshot
        // GraphQL -> snapshot: ClosestSnapshotDetail (type)
        if (this.Snapshot != null) {
            var fspec = this.Snapshot.AsFieldSpec(conf.Child("snapshot"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshot" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SnapshotSearchError? Error
        // GraphQL -> error: SnapshotSearchError (enum)
        if (ec.Includes("error",true))
        {
            if(this.Error == null) {

                this.Error = new SnapshotSearchError();

            } else {


            }
        }
        else if (this.Error != null && ec.Excludes("error",true))
        {
            this.Error = null;
        }
        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        if (ec.Includes("snappableId",true))
        {
            if(this.SnappableId == null) {

                this.SnappableId = "FETCH";

            } else {


            }
        }
        else if (this.SnappableId != null && ec.Excludes("snappableId",true))
        {
            this.SnappableId = null;
        }
        //      C# -> ClosestSnapshotDetail? Snapshot
        // GraphQL -> snapshot: ClosestSnapshotDetail (type)
        if (ec.Includes("snapshot",false))
        {
            if(this.Snapshot == null) {

                this.Snapshot = new ClosestSnapshotDetail();
                this.Snapshot.ApplyExploratoryFieldSpec(ec.NewChild("snapshot"));

            } else {

                this.Snapshot.ApplyExploratoryFieldSpec(ec.NewChild("snapshot"));

            }
        }
        else if (this.Snapshot != null && ec.Excludes("snapshot",false))
        {
            this.Snapshot = null;
        }
    }


    #endregion

    } // class ClosestSnapshotSearchResult
    
    #endregion

    public static class ListClosestSnapshotSearchResultExtensions
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
            this List<ClosestSnapshotSearchResult> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClosestSnapshotSearchResult> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClosestSnapshotSearchResult> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClosestSnapshotSearchResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClosestSnapshotSearchResult> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types