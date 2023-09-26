// SnapshotFileDelta.cs
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
    #region SnapshotFileDelta
    public class SnapshotFileDelta: BaseType
    {
        #region members

        //      C# -> List<SnapshotDelta>? ChildrenDeltas
        // GraphQL -> childrenDeltas: [SnapshotDelta!]! (type)
        [JsonProperty("childrenDeltas")]
        public List<SnapshotDelta>? ChildrenDeltas { get; set; }

        //      C# -> SnapshotFile? File
        // GraphQL -> file: SnapshotFile! (type)
        [JsonProperty("file")]
        public SnapshotFile? File { get; set; }

        //      C# -> QuarantineInfo? PreviousSnapshotQuarantineInfo
        // GraphQL -> previousSnapshotQuarantineInfo: QuarantineInfo (type)
        [JsonProperty("previousSnapshotQuarantineInfo")]
        public QuarantineInfo? PreviousSnapshotQuarantineInfo { get; set; }

        //      C# -> List<SnapshotDelta>? SelfDeltas
        // GraphQL -> selfDeltas: [SnapshotDelta!]! (type)
        [JsonProperty("selfDeltas")]
        public List<SnapshotDelta>? SelfDeltas { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SnapshotFileDelta";
    }

    public SnapshotFileDelta Set(
        List<SnapshotDelta>? ChildrenDeltas = null,
        SnapshotFile? File = null,
        QuarantineInfo? PreviousSnapshotQuarantineInfo = null,
        List<SnapshotDelta>? SelfDeltas = null
    ) 
    {
        if ( ChildrenDeltas != null ) {
            this.ChildrenDeltas = ChildrenDeltas;
        }
        if ( File != null ) {
            this.File = File;
        }
        if ( PreviousSnapshotQuarantineInfo != null ) {
            this.PreviousSnapshotQuarantineInfo = PreviousSnapshotQuarantineInfo;
        }
        if ( SelfDeltas != null ) {
            this.SelfDeltas = SelfDeltas;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<SnapshotDelta>? ChildrenDeltas
        // GraphQL -> childrenDeltas: [SnapshotDelta!]! (type)
        if (this.ChildrenDeltas != null) {
            var fspec = this.ChildrenDeltas.AsFieldSpec(conf.Child("childrenDeltas"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "childrenDeltas {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SnapshotFile? File
        // GraphQL -> file: SnapshotFile! (type)
        if (this.File != null) {
            var fspec = this.File.AsFieldSpec(conf.Child("file"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "file {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> QuarantineInfo? PreviousSnapshotQuarantineInfo
        // GraphQL -> previousSnapshotQuarantineInfo: QuarantineInfo (type)
        if (this.PreviousSnapshotQuarantineInfo != null) {
            var fspec = this.PreviousSnapshotQuarantineInfo.AsFieldSpec(conf.Child("previousSnapshotQuarantineInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "previousSnapshotQuarantineInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<SnapshotDelta>? SelfDeltas
        // GraphQL -> selfDeltas: [SnapshotDelta!]! (type)
        if (this.SelfDeltas != null) {
            var fspec = this.SelfDeltas.AsFieldSpec(conf.Child("selfDeltas"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "selfDeltas {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<SnapshotDelta>? ChildrenDeltas
        // GraphQL -> childrenDeltas: [SnapshotDelta!]! (type)
        if (ec.Includes("childrenDeltas",false))
        {
            if(this.ChildrenDeltas == null) {

                this.ChildrenDeltas = new List<SnapshotDelta>();
                this.ChildrenDeltas.ApplyExploratoryFieldSpec(ec.NewChild("childrenDeltas"));

            } else {

                this.ChildrenDeltas.ApplyExploratoryFieldSpec(ec.NewChild("childrenDeltas"));

            }
        }
        else if (this.ChildrenDeltas != null && ec.Excludes("childrenDeltas",false))
        {
            this.ChildrenDeltas = null;
        }
        //      C# -> SnapshotFile? File
        // GraphQL -> file: SnapshotFile! (type)
        if (ec.Includes("file",false))
        {
            if(this.File == null) {

                this.File = new SnapshotFile();
                this.File.ApplyExploratoryFieldSpec(ec.NewChild("file"));

            } else {

                this.File.ApplyExploratoryFieldSpec(ec.NewChild("file"));

            }
        }
        else if (this.File != null && ec.Excludes("file",false))
        {
            this.File = null;
        }
        //      C# -> QuarantineInfo? PreviousSnapshotQuarantineInfo
        // GraphQL -> previousSnapshotQuarantineInfo: QuarantineInfo (type)
        if (ec.Includes("previousSnapshotQuarantineInfo",false))
        {
            if(this.PreviousSnapshotQuarantineInfo == null) {

                this.PreviousSnapshotQuarantineInfo = new QuarantineInfo();
                this.PreviousSnapshotQuarantineInfo.ApplyExploratoryFieldSpec(ec.NewChild("previousSnapshotQuarantineInfo"));

            } else {

                this.PreviousSnapshotQuarantineInfo.ApplyExploratoryFieldSpec(ec.NewChild("previousSnapshotQuarantineInfo"));

            }
        }
        else if (this.PreviousSnapshotQuarantineInfo != null && ec.Excludes("previousSnapshotQuarantineInfo",false))
        {
            this.PreviousSnapshotQuarantineInfo = null;
        }
        //      C# -> List<SnapshotDelta>? SelfDeltas
        // GraphQL -> selfDeltas: [SnapshotDelta!]! (type)
        if (ec.Includes("selfDeltas",false))
        {
            if(this.SelfDeltas == null) {

                this.SelfDeltas = new List<SnapshotDelta>();
                this.SelfDeltas.ApplyExploratoryFieldSpec(ec.NewChild("selfDeltas"));

            } else {

                this.SelfDeltas.ApplyExploratoryFieldSpec(ec.NewChild("selfDeltas"));

            }
        }
        else if (this.SelfDeltas != null && ec.Excludes("selfDeltas",false))
        {
            this.SelfDeltas = null;
        }
    }


    #endregion

    } // class SnapshotFileDelta
    
    #endregion

    public static class ListSnapshotFileDeltaExtensions
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
            this List<SnapshotFileDelta> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SnapshotFileDelta> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SnapshotFileDelta());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SnapshotFileDelta> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types