// ObjectProtectionSummaryPerSnappableType.cs
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
    #region ObjectProtectionSummaryPerSnappableType
    public class ObjectProtectionSummaryPerSnappableType: BaseType
    {
        #region members

        //      C# -> ManagedObjectType? SnappableType
        // GraphQL -> snappableType: ManagedObjectType! (enum)
        [JsonProperty("snappableType")]
        public ManagedObjectType? SnappableType { get; set; }

        //      C# -> List<ObjectProtectionSummarySensitivityData>? ObjectProtectionSummarySensitivityData
        // GraphQL -> objectProtectionSummarySensitivityData: [ObjectProtectionSummarySensitivityData!]! (type)
        [JsonProperty("objectProtectionSummarySensitivityData")]
        public List<ObjectProtectionSummarySensitivityData>? ObjectProtectionSummarySensitivityData { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ObjectProtectionSummaryPerSnappableType";
    }

    public ObjectProtectionSummaryPerSnappableType Set(
        ManagedObjectType? SnappableType = null,
        List<ObjectProtectionSummarySensitivityData>? ObjectProtectionSummarySensitivityData = null
    ) 
    {
        if ( SnappableType != null ) {
            this.SnappableType = SnappableType;
        }
        if ( ObjectProtectionSummarySensitivityData != null ) {
            this.ObjectProtectionSummarySensitivityData = ObjectProtectionSummarySensitivityData;
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
        //      C# -> ManagedObjectType? SnappableType
        // GraphQL -> snappableType: ManagedObjectType! (enum)
        if (this.SnappableType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snappableType\n" ;
            } else {
                s += ind + "snappableType\n" ;
            }
        }
        //      C# -> List<ObjectProtectionSummarySensitivityData>? ObjectProtectionSummarySensitivityData
        // GraphQL -> objectProtectionSummarySensitivityData: [ObjectProtectionSummarySensitivityData!]! (type)
        if (this.ObjectProtectionSummarySensitivityData != null) {
            var fspec = this.ObjectProtectionSummarySensitivityData.AsFieldSpec(conf.Child("objectProtectionSummarySensitivityData"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "objectProtectionSummarySensitivityData" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ManagedObjectType? SnappableType
        // GraphQL -> snappableType: ManagedObjectType! (enum)
        if (ec.Includes("snappableType",true))
        {
            if(this.SnappableType == null) {

                this.SnappableType = new ManagedObjectType();

            } else {


            }
        }
        else if (this.SnappableType != null && ec.Excludes("snappableType",true))
        {
            this.SnappableType = null;
        }
        //      C# -> List<ObjectProtectionSummarySensitivityData>? ObjectProtectionSummarySensitivityData
        // GraphQL -> objectProtectionSummarySensitivityData: [ObjectProtectionSummarySensitivityData!]! (type)
        if (ec.Includes("objectProtectionSummarySensitivityData",false))
        {
            if(this.ObjectProtectionSummarySensitivityData == null) {

                this.ObjectProtectionSummarySensitivityData = new List<ObjectProtectionSummarySensitivityData>();
                this.ObjectProtectionSummarySensitivityData.ApplyExploratoryFieldSpec(ec.NewChild("objectProtectionSummarySensitivityData"));

            } else {

                this.ObjectProtectionSummarySensitivityData.ApplyExploratoryFieldSpec(ec.NewChild("objectProtectionSummarySensitivityData"));

            }
        }
        else if (this.ObjectProtectionSummarySensitivityData != null && ec.Excludes("objectProtectionSummarySensitivityData",false))
        {
            this.ObjectProtectionSummarySensitivityData = null;
        }
    }


    #endregion

    } // class ObjectProtectionSummaryPerSnappableType
    
    #endregion

    public static class ListObjectProtectionSummaryPerSnappableTypeExtensions
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
            this List<ObjectProtectionSummaryPerSnappableType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ObjectProtectionSummaryPerSnappableType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ObjectProtectionSummaryPerSnappableType> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ObjectProtectionSummaryPerSnappableType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ObjectProtectionSummaryPerSnappableType> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types