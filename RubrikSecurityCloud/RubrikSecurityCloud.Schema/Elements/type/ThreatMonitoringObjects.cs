// ThreatMonitoringObjects.cs
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
    #region ThreatMonitoringObjects
    public class ThreatMonitoringObjects: BaseType
    {
        #region members

        //      C# -> System.Int64? ObjectsWithThreats
        // GraphQL -> objectsWithThreats: Long! (scalar)
        [JsonProperty("objectsWithThreats")]
        public System.Int64? ObjectsWithThreats { get; set; }

        //      C# -> System.Int64? ObjectsWithoutThreats
        // GraphQL -> objectsWithoutThreats: Long! (scalar)
        [JsonProperty("objectsWithoutThreats")]
        public System.Int64? ObjectsWithoutThreats { get; set; }

        //      C# -> System.Int64? UnscannedObjects
        // GraphQL -> unscannedObjects: Long! (scalar)
        [JsonProperty("unscannedObjects")]
        public System.Int64? UnscannedObjects { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ThreatMonitoringObjects";
    }

    public ThreatMonitoringObjects Set(
        System.Int64? ObjectsWithThreats = null,
        System.Int64? ObjectsWithoutThreats = null,
        System.Int64? UnscannedObjects = null
    ) 
    {
        if ( ObjectsWithThreats != null ) {
            this.ObjectsWithThreats = ObjectsWithThreats;
        }
        if ( ObjectsWithoutThreats != null ) {
            this.ObjectsWithoutThreats = ObjectsWithoutThreats;
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
        //      C# -> System.Int64? ObjectsWithThreats
        // GraphQL -> objectsWithThreats: Long! (scalar)
        if (this.ObjectsWithThreats != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectsWithThreats\n" ;
            } else {
                s += ind + "objectsWithThreats\n" ;
            }
        }
        //      C# -> System.Int64? ObjectsWithoutThreats
        // GraphQL -> objectsWithoutThreats: Long! (scalar)
        if (this.ObjectsWithoutThreats != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectsWithoutThreats\n" ;
            } else {
                s += ind + "objectsWithoutThreats\n" ;
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
        //      C# -> System.Int64? ObjectsWithThreats
        // GraphQL -> objectsWithThreats: Long! (scalar)
        if (ec.Includes("objectsWithThreats",true))
        {
            if(this.ObjectsWithThreats == null) {

                this.ObjectsWithThreats = new System.Int64();

            } else {


            }
        }
        else if (this.ObjectsWithThreats != null && ec.Excludes("objectsWithThreats",true))
        {
            this.ObjectsWithThreats = null;
        }
        //      C# -> System.Int64? ObjectsWithoutThreats
        // GraphQL -> objectsWithoutThreats: Long! (scalar)
        if (ec.Includes("objectsWithoutThreats",true))
        {
            if(this.ObjectsWithoutThreats == null) {

                this.ObjectsWithoutThreats = new System.Int64();

            } else {


            }
        }
        else if (this.ObjectsWithoutThreats != null && ec.Excludes("objectsWithoutThreats",true))
        {
            this.ObjectsWithoutThreats = null;
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

    } // class ThreatMonitoringObjects
    
    #endregion

    public static class ListThreatMonitoringObjectsExtensions
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
            this List<ThreatMonitoringObjects> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ThreatMonitoringObjects> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ThreatMonitoringObjects> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatMonitoringObjects());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ThreatMonitoringObjects> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types