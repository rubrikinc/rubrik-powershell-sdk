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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> HierarchyObject? Snappable
        // GraphQL -> snappable: HierarchyObject! (interface)
        if (this.Snappable != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.Snappable).AsFieldSpec(conf.Child("snappable"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snappable {\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> System.String? NativePath
        // GraphQL -> nativePath: String! (scalar)
        if (this.NativePath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nativePath\n" ;
            } else {
                s += ind + "nativePath\n" ;
            }
        }
        //      C# -> System.String? StdPath
        // GraphQL -> stdPath: String! (scalar)
        if (this.StdPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "stdPath\n" ;
            } else {
                s += ind + "stdPath\n" ;
            }
        }
        //      C# -> System.Int64? UpdateTs
        // GraphQL -> updateTs: Long! (scalar)
        if (this.UpdateTs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "updateTs\n" ;
            } else {
                s += ind + "updateTs\n" ;
            }
        }
        //      C# -> System.String? UpdateUsername
        // GraphQL -> updateUsername: String! (scalar)
        if (this.UpdateUsername != null) {
            if (conf.Flat) {
                s += conf.Prefix + "updateUsername\n" ;
            } else {
                s += ind + "updateUsername\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> HierarchyObject? Snappable
        // GraphQL -> snappable: HierarchyObject! (interface)
        if (ec.Includes("snappable",false))
        {
            if(this.Snappable == null) {

                var impls = new List<HierarchyObject>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("snappable"));
                this.Snappable = (HierarchyObject)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<HierarchyObject>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("snappable"));
                this.Snappable = (HierarchyObject)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.Snappable != null && ec.Excludes("snappable",false))
        {
            this.Snappable = null;
        }
        //      C# -> System.String? NativePath
        // GraphQL -> nativePath: String! (scalar)
        if (ec.Includes("nativePath",true))
        {
            if(this.NativePath == null) {

                this.NativePath = "FETCH";

            } else {


            }
        }
        else if (this.NativePath != null && ec.Excludes("nativePath",true))
        {
            this.NativePath = null;
        }
        //      C# -> System.String? StdPath
        // GraphQL -> stdPath: String! (scalar)
        if (ec.Includes("stdPath",true))
        {
            if(this.StdPath == null) {

                this.StdPath = "FETCH";

            } else {


            }
        }
        else if (this.StdPath != null && ec.Excludes("stdPath",true))
        {
            this.StdPath = null;
        }
        //      C# -> System.Int64? UpdateTs
        // GraphQL -> updateTs: Long! (scalar)
        if (ec.Includes("updateTs",true))
        {
            if(this.UpdateTs == null) {

                this.UpdateTs = new System.Int64();

            } else {


            }
        }
        else if (this.UpdateTs != null && ec.Excludes("updateTs",true))
        {
            this.UpdateTs = null;
        }
        //      C# -> System.String? UpdateUsername
        // GraphQL -> updateUsername: String! (scalar)
        if (ec.Includes("updateUsername",true))
        {
            if(this.UpdateUsername == null) {

                this.UpdateUsername = "FETCH";

            } else {


            }
        }
        else if (this.UpdateUsername != null && ec.Excludes("updateUsername",true))
        {
            this.UpdateUsername = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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