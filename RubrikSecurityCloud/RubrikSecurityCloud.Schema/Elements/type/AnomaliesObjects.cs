// AnomaliesObjects.cs
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
    #region AnomaliesObjects
    public class AnomaliesObjects: BaseType
    {
        #region members

        //      C# -> System.Int64? ObjectsWithAnomalies
        // GraphQL -> objectsWithAnomalies: Long! (scalar)
        [JsonProperty("objectsWithAnomalies")]
        public System.Int64? ObjectsWithAnomalies { get; set; }

        //      C# -> System.Int64? ObjectsWithResolvedAnomalies
        // GraphQL -> objectsWithResolvedAnomalies: Long! (scalar)
        [JsonProperty("objectsWithResolvedAnomalies")]
        public System.Int64? ObjectsWithResolvedAnomalies { get; set; }

        //      C# -> System.Int64? ObjectsWithoutAnomalies
        // GraphQL -> objectsWithoutAnomalies: Long! (scalar)
        [JsonProperty("objectsWithoutAnomalies")]
        public System.Int64? ObjectsWithoutAnomalies { get; set; }

        //      C# -> System.Int64? UnscannedObjects
        // GraphQL -> unscannedObjects: Long! (scalar)
        [JsonProperty("unscannedObjects")]
        public System.Int64? UnscannedObjects { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AnomaliesObjects";
    }

    public AnomaliesObjects Set(
        System.Int64? ObjectsWithAnomalies = null,
        System.Int64? ObjectsWithResolvedAnomalies = null,
        System.Int64? ObjectsWithoutAnomalies = null,
        System.Int64? UnscannedObjects = null
    ) 
    {
        if ( ObjectsWithAnomalies != null ) {
            this.ObjectsWithAnomalies = ObjectsWithAnomalies;
        }
        if ( ObjectsWithResolvedAnomalies != null ) {
            this.ObjectsWithResolvedAnomalies = ObjectsWithResolvedAnomalies;
        }
        if ( ObjectsWithoutAnomalies != null ) {
            this.ObjectsWithoutAnomalies = ObjectsWithoutAnomalies;
        }
        if ( UnscannedObjects != null ) {
            this.UnscannedObjects = UnscannedObjects;
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
        //      C# -> System.Int64? ObjectsWithAnomalies
        // GraphQL -> objectsWithAnomalies: Long! (scalar)
        if (this.ObjectsWithAnomalies != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectsWithAnomalies\n" ;
            } else {
                s += ind + "objectsWithAnomalies\n" ;
            }
        }
        //      C# -> System.Int64? ObjectsWithResolvedAnomalies
        // GraphQL -> objectsWithResolvedAnomalies: Long! (scalar)
        if (this.ObjectsWithResolvedAnomalies != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectsWithResolvedAnomalies\n" ;
            } else {
                s += ind + "objectsWithResolvedAnomalies\n" ;
            }
        }
        //      C# -> System.Int64? ObjectsWithoutAnomalies
        // GraphQL -> objectsWithoutAnomalies: Long! (scalar)
        if (this.ObjectsWithoutAnomalies != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectsWithoutAnomalies\n" ;
            } else {
                s += ind + "objectsWithoutAnomalies\n" ;
            }
        }
        //      C# -> System.Int64? UnscannedObjects
        // GraphQL -> unscannedObjects: Long! (scalar)
        if (this.UnscannedObjects != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unscannedObjects\n" ;
            } else {
                s += ind + "unscannedObjects\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? ObjectsWithAnomalies
        // GraphQL -> objectsWithAnomalies: Long! (scalar)
        if (ec.Includes("objectsWithAnomalies",true))
        {
            if(this.ObjectsWithAnomalies == null) {

                this.ObjectsWithAnomalies = new System.Int64();

            } else {


            }
        }
        else if (this.ObjectsWithAnomalies != null && ec.Excludes("objectsWithAnomalies",true))
        {
            this.ObjectsWithAnomalies = null;
        }
        //      C# -> System.Int64? ObjectsWithResolvedAnomalies
        // GraphQL -> objectsWithResolvedAnomalies: Long! (scalar)
        if (ec.Includes("objectsWithResolvedAnomalies",true))
        {
            if(this.ObjectsWithResolvedAnomalies == null) {

                this.ObjectsWithResolvedAnomalies = new System.Int64();

            } else {


            }
        }
        else if (this.ObjectsWithResolvedAnomalies != null && ec.Excludes("objectsWithResolvedAnomalies",true))
        {
            this.ObjectsWithResolvedAnomalies = null;
        }
        //      C# -> System.Int64? ObjectsWithoutAnomalies
        // GraphQL -> objectsWithoutAnomalies: Long! (scalar)
        if (ec.Includes("objectsWithoutAnomalies",true))
        {
            if(this.ObjectsWithoutAnomalies == null) {

                this.ObjectsWithoutAnomalies = new System.Int64();

            } else {


            }
        }
        else if (this.ObjectsWithoutAnomalies != null && ec.Excludes("objectsWithoutAnomalies",true))
        {
            this.ObjectsWithoutAnomalies = null;
        }
        //      C# -> System.Int64? UnscannedObjects
        // GraphQL -> unscannedObjects: Long! (scalar)
        if (ec.Includes("unscannedObjects",true))
        {
            if(this.UnscannedObjects == null) {

                this.UnscannedObjects = new System.Int64();

            } else {


            }
        }
        else if (this.UnscannedObjects != null && ec.Excludes("unscannedObjects",true))
        {
            this.UnscannedObjects = null;
        }
    }


    #endregion

    } // class AnomaliesObjects
    
    #endregion

    public static class ListAnomaliesObjectsExtensions
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
            this List<AnomaliesObjects> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AnomaliesObjects> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AnomaliesObjects> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AnomaliesObjects());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AnomaliesObjects> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types