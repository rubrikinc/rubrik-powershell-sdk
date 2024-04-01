// ObjectIdsForHierarchyType.cs
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
    #region ObjectIdsForHierarchyType
    public class ObjectIdsForHierarchyType: BaseType
    {
        #region members

        //      C# -> WorkloadLevelHierarchy? SnappableType
        // GraphQL -> snappableType: WorkloadLevelHierarchy! (enum)
        [JsonProperty("snappableType")]
        public WorkloadLevelHierarchy? SnappableType { get; set; }

        //      C# -> List<System.String>? ObjectIds
        // GraphQL -> objectIds: [String!]! (scalar)
        [JsonProperty("objectIds")]
        public List<System.String>? ObjectIds { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ObjectIdsForHierarchyType";
    }

    public ObjectIdsForHierarchyType Set(
        WorkloadLevelHierarchy? SnappableType = null,
        List<System.String>? ObjectIds = null
    ) 
    {
        if ( SnappableType != null ) {
            this.SnappableType = SnappableType;
        }
        if ( ObjectIds != null ) {
            this.ObjectIds = ObjectIds;
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
        //      C# -> WorkloadLevelHierarchy? SnappableType
        // GraphQL -> snappableType: WorkloadLevelHierarchy! (enum)
        if (this.SnappableType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snappableType\n" ;
            } else {
                s += ind + "snappableType\n" ;
            }
        }
        //      C# -> List<System.String>? ObjectIds
        // GraphQL -> objectIds: [String!]! (scalar)
        if (this.ObjectIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectIds\n" ;
            } else {
                s += ind + "objectIds\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> WorkloadLevelHierarchy? SnappableType
        // GraphQL -> snappableType: WorkloadLevelHierarchy! (enum)
        if (ec.Includes("snappableType",true))
        {
            if(this.SnappableType == null) {

                this.SnappableType = new WorkloadLevelHierarchy();

            } else {


            }
        }
        else if (this.SnappableType != null && ec.Excludes("snappableType",true))
        {
            this.SnappableType = null;
        }
        //      C# -> List<System.String>? ObjectIds
        // GraphQL -> objectIds: [String!]! (scalar)
        if (ec.Includes("objectIds",true))
        {
            if(this.ObjectIds == null) {

                this.ObjectIds = new List<System.String>();

            } else {


            }
        }
        else if (this.ObjectIds != null && ec.Excludes("objectIds",true))
        {
            this.ObjectIds = null;
        }
    }


    #endregion

    } // class ObjectIdsForHierarchyType
    
    #endregion

    public static class ListObjectIdsForHierarchyTypeExtensions
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
            this List<ObjectIdsForHierarchyType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ObjectIdsForHierarchyType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ObjectIdsForHierarchyType> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ObjectIdsForHierarchyType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ObjectIdsForHierarchyType> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types