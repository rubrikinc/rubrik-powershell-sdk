// SlaConflictObjectsWithParent.cs
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
    #region SlaConflictObjectsWithParent
    public class SlaConflictObjectsWithParent: BaseType
    {
        #region members

        //      C# -> List<HierarchyObject>? ConflictObjects
        // GraphQL -> conflictObjects: [HierarchyObject!]! (interface)
        [JsonProperty("conflictObjects")]
        public List<HierarchyObject>? ConflictObjects { get; set; }

        //      C# -> System.String? ParentId
        // GraphQL -> parentId: UUID! (scalar)
        [JsonProperty("parentId")]
        public System.String? ParentId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SlaConflictObjectsWithParent";
    }

    public SlaConflictObjectsWithParent Set(
        List<HierarchyObject>? ConflictObjects = null,
        System.String? ParentId = null
    ) 
    {
        if ( ConflictObjects != null ) {
            this.ConflictObjects = ConflictObjects;
        }
        if ( ParentId != null ) {
            this.ParentId = ParentId;
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
        //      C# -> List<HierarchyObject>? ConflictObjects
        // GraphQL -> conflictObjects: [HierarchyObject!]! (interface)
        if (this.ConflictObjects != null) {
                var fspec = this.ConflictObjects.AsFieldSpec(conf.Child("conflictObjects"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "conflictObjects" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> System.String? ParentId
        // GraphQL -> parentId: UUID! (scalar)
        if (this.ParentId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "parentId\n" ;
            } else {
                s += ind + "parentId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<HierarchyObject>? ConflictObjects
        // GraphQL -> conflictObjects: [HierarchyObject!]! (interface)
        if (ec.Includes("conflictObjects",false))
        {
            if(this.ConflictObjects == null) {

                this.ConflictObjects = new List<HierarchyObject>();
                this.ConflictObjects.ApplyExploratoryFieldSpec(ec.NewChild("conflictObjects"));

            } else {

                this.ConflictObjects.ApplyExploratoryFieldSpec(ec.NewChild("conflictObjects"));

            }
        }
        else if (this.ConflictObjects != null && ec.Excludes("conflictObjects",false))
        {
            this.ConflictObjects = null;
        }
        //      C# -> System.String? ParentId
        // GraphQL -> parentId: UUID! (scalar)
        if (ec.Includes("parentId",true))
        {
            if(this.ParentId == null) {

                this.ParentId = "FETCH";

            } else {


            }
        }
        else if (this.ParentId != null && ec.Excludes("parentId",true))
        {
            this.ParentId = null;
        }
    }


    #endregion

    } // class SlaConflictObjectsWithParent
    
    #endregion

    public static class ListSlaConflictObjectsWithParentExtensions
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
            this List<SlaConflictObjectsWithParent> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SlaConflictObjectsWithParent> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SlaConflictObjectsWithParent> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SlaConflictObjectsWithParent());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SlaConflictObjectsWithParent> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types