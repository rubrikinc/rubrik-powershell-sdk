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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<SnapshotDelta>? ChildrenDeltas
        // GraphQL -> childrenDeltas: [SnapshotDelta!]! (type)
        if (this.ChildrenDeltas != null) {
            var fspec = this.ChildrenDeltas.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "childrenDeltas {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SnapshotFile? File
        // GraphQL -> file: SnapshotFile! (type)
        if (this.File != null) {
            var fspec = this.File.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "file {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> QuarantineInfo? PreviousSnapshotQuarantineInfo
        // GraphQL -> previousSnapshotQuarantineInfo: QuarantineInfo (type)
        if (this.PreviousSnapshotQuarantineInfo != null) {
            var fspec = this.PreviousSnapshotQuarantineInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "previousSnapshotQuarantineInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<SnapshotDelta>? SelfDeltas
        // GraphQL -> selfDeltas: [SnapshotDelta!]! (type)
        if (this.SelfDeltas != null) {
            var fspec = this.SelfDeltas.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "selfDeltas {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<SnapshotDelta>? ChildrenDeltas
        // GraphQL -> childrenDeltas: [SnapshotDelta!]! (type)
        if (this.ChildrenDeltas == null && Exploration.Includes(parent + ".childrenDeltas"))
        {
            this.ChildrenDeltas = new List<SnapshotDelta>();
            this.ChildrenDeltas.ApplyExploratoryFieldSpec(parent + ".childrenDeltas");
        }
        //      C# -> SnapshotFile? File
        // GraphQL -> file: SnapshotFile! (type)
        if (this.File == null && Exploration.Includes(parent + ".file"))
        {
            this.File = new SnapshotFile();
            this.File.ApplyExploratoryFieldSpec(parent + ".file");
        }
        //      C# -> QuarantineInfo? PreviousSnapshotQuarantineInfo
        // GraphQL -> previousSnapshotQuarantineInfo: QuarantineInfo (type)
        if (this.PreviousSnapshotQuarantineInfo == null && Exploration.Includes(parent + ".previousSnapshotQuarantineInfo"))
        {
            this.PreviousSnapshotQuarantineInfo = new QuarantineInfo();
            this.PreviousSnapshotQuarantineInfo.ApplyExploratoryFieldSpec(parent + ".previousSnapshotQuarantineInfo");
        }
        //      C# -> List<SnapshotDelta>? SelfDeltas
        // GraphQL -> selfDeltas: [SnapshotDelta!]! (type)
        if (this.SelfDeltas == null && Exploration.Includes(parent + ".selfDeltas"))
        {
            this.SelfDeltas = new List<SnapshotDelta>();
            this.SelfDeltas.ApplyExploratoryFieldSpec(parent + ".selfDeltas");
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SnapshotFileDelta> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SnapshotFileDelta());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types