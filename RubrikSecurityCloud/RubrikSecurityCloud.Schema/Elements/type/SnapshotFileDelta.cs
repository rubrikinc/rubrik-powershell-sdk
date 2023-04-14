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

namespace Rubrik.SecurityCloud.Types
{
    #region SnapshotFileDelta
    public class SnapshotFileDelta: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> List<SnapshotDelta>? ChildrenDeltas
            // GraphQL -> childrenDeltas: [SnapshotDelta!]! (type)
            if (this.ChildrenDeltas != null)
            {
                 s += ind + "childrenDeltas\n";

                 s += ind + "{\n" + 
                 this.ChildrenDeltas.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SnapshotFile? File
            // GraphQL -> file: SnapshotFile! (type)
            if (this.File != null)
            {
                 s += ind + "file\n";

                 s += ind + "{\n" + 
                 this.File.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> QuarantineInfo? PreviousSnapshotQuarantineInfo
            // GraphQL -> previousSnapshotQuarantineInfo: QuarantineInfo (type)
            if (this.PreviousSnapshotQuarantineInfo != null)
            {
                 s += ind + "previousSnapshotQuarantineInfo\n";

                 s += ind + "{\n" + 
                 this.PreviousSnapshotQuarantineInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<SnapshotDelta>? SelfDeltas
            // GraphQL -> selfDeltas: [SnapshotDelta!]! (type)
            if (this.SelfDeltas != null)
            {
                 s += ind + "selfDeltas\n";

                 s += ind + "{\n" + 
                 this.SelfDeltas.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<SnapshotDelta>? ChildrenDeltas
            // GraphQL -> childrenDeltas: [SnapshotDelta!]! (type)
            if (this.ChildrenDeltas == null && Exploration.Includes(parent + ".childrenDeltas"))
            {
                this.ChildrenDeltas = new List<SnapshotDelta>();
                this.ChildrenDeltas.ApplyExploratoryFragment(parent + ".childrenDeltas");
            }
            //      C# -> SnapshotFile? File
            // GraphQL -> file: SnapshotFile! (type)
            if (this.File == null && Exploration.Includes(parent + ".file"))
            {
                this.File = new SnapshotFile();
                this.File.ApplyExploratoryFragment(parent + ".file");
            }
            //      C# -> QuarantineInfo? PreviousSnapshotQuarantineInfo
            // GraphQL -> previousSnapshotQuarantineInfo: QuarantineInfo (type)
            if (this.PreviousSnapshotQuarantineInfo == null && Exploration.Includes(parent + ".previousSnapshotQuarantineInfo"))
            {
                this.PreviousSnapshotQuarantineInfo = new QuarantineInfo();
                this.PreviousSnapshotQuarantineInfo.ApplyExploratoryFragment(parent + ".previousSnapshotQuarantineInfo");
            }
            //      C# -> List<SnapshotDelta>? SelfDeltas
            // GraphQL -> selfDeltas: [SnapshotDelta!]! (type)
            if (this.SelfDeltas == null && Exploration.Includes(parent + ".selfDeltas"))
            {
                this.SelfDeltas = new List<SnapshotDelta>();
                this.SelfDeltas.ApplyExploratoryFragment(parent + ".selfDeltas");
            }
        }


    #endregion

    } // class SnapshotFileDelta
    #endregion

    public static class ListSnapshotFileDeltaExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<SnapshotFileDelta> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SnapshotFileDelta> list, 
            String parent = "")
        {
            var item = new SnapshotFileDelta();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types