// ClassificationPolicyWhitelistDetailedEntry.cs
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
    #region ClassificationPolicyWhitelistDetailedEntry
    public class ClassificationPolicyWhitelistDetailedEntry: BaseType
    {
        #region members

        //      C# -> HierarchyObject? Snappable
        // GraphQL -> snappable: HierarchyObject! (interface)
        [JsonProperty("snappable")]
        public HierarchyObject? Snappable { get; set; }

        //      C# -> System.String? NativePath
        // GraphQL -> nativePath: String! (scalar)
        [JsonProperty("nativePath")]
        public System.String? NativePath { get; set; }

        //      C# -> System.String? StdPath
        // GraphQL -> stdPath: String! (scalar)
        [JsonProperty("stdPath")]
        public System.String? StdPath { get; set; }

        //      C# -> System.Int64? UpdateTs
        // GraphQL -> updateTs: Long! (scalar)
        [JsonProperty("updateTs")]
        public System.Int64? UpdateTs { get; set; }

        //      C# -> System.String? UpdateUsername
        // GraphQL -> updateUsername: String! (scalar)
        [JsonProperty("updateUsername")]
        public System.String? UpdateUsername { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClassificationPolicyWhitelistDetailedEntry";
    }

    public ClassificationPolicyWhitelistDetailedEntry Set(
        HierarchyObject? Snappable = null,
        System.String? NativePath = null,
        System.String? StdPath = null,
        System.Int64? UpdateTs = null,
        System.String? UpdateUsername = null
    ) 
    {
        if ( Snappable != null ) {
            this.Snappable = Snappable;
        }
        if ( NativePath != null ) {
            this.NativePath = NativePath;
        }
        if ( StdPath != null ) {
            this.StdPath = StdPath;
        }
        if ( UpdateTs != null ) {
            this.UpdateTs = UpdateTs;
        }
        if ( UpdateUsername != null ) {
            this.UpdateUsername = UpdateUsername;
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
        //      C# -> HierarchyObject? Snappable
        // GraphQL -> snappable: HierarchyObject! (interface)
        if (this.Snappable != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.Snappable).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snappable {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> System.String? NativePath
        // GraphQL -> nativePath: String! (scalar)
        if (this.NativePath != null) {
            s += ind + "nativePath\n" ;
        }
        //      C# -> System.String? StdPath
        // GraphQL -> stdPath: String! (scalar)
        if (this.StdPath != null) {
            s += ind + "stdPath\n" ;
        }
        //      C# -> System.Int64? UpdateTs
        // GraphQL -> updateTs: Long! (scalar)
        if (this.UpdateTs != null) {
            s += ind + "updateTs\n" ;
        }
        //      C# -> System.String? UpdateUsername
        // GraphQL -> updateUsername: String! (scalar)
        if (this.UpdateUsername != null) {
            s += ind + "updateUsername\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> HierarchyObject? Snappable
        // GraphQL -> snappable: HierarchyObject! (interface)
        if (this.Snappable == null && ec.Includes("snappable",false))
        {
            var impls = new List<HierarchyObject>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("snappable"));
            this.Snappable = (HierarchyObject)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> System.String? NativePath
        // GraphQL -> nativePath: String! (scalar)
        if (this.NativePath == null && ec.Includes("nativePath",true))
        {
            this.NativePath = "FETCH";
        }
        //      C# -> System.String? StdPath
        // GraphQL -> stdPath: String! (scalar)
        if (this.StdPath == null && ec.Includes("stdPath",true))
        {
            this.StdPath = "FETCH";
        }
        //      C# -> System.Int64? UpdateTs
        // GraphQL -> updateTs: Long! (scalar)
        if (this.UpdateTs == null && ec.Includes("updateTs",true))
        {
            this.UpdateTs = new System.Int64();
        }
        //      C# -> System.String? UpdateUsername
        // GraphQL -> updateUsername: String! (scalar)
        if (this.UpdateUsername == null && ec.Includes("updateUsername",true))
        {
            this.UpdateUsername = "FETCH";
        }
    }


    #endregion

    } // class ClassificationPolicyWhitelistDetailedEntry
    
    #endregion

    public static class ListClassificationPolicyWhitelistDetailedEntryExtensions
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
            this List<ClassificationPolicyWhitelistDetailedEntry> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClassificationPolicyWhitelistDetailedEntry> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClassificationPolicyWhitelistDetailedEntry());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClassificationPolicyWhitelistDetailedEntry> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types