// RansomwareInvestigationObjectsReply.cs
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
    #region RansomwareInvestigationObjectsReply
    public class RansomwareInvestigationObjectsReply: BaseType
    {
        #region members

        //      C# -> System.Int64? ObjectsNoAnomalies
        // GraphQL -> objectsNoAnomalies: Long! (scalar)
        [JsonProperty("objectsNoAnomalies")]
        public System.Int64? ObjectsNoAnomalies { get; set; }

        //      C# -> System.Int64? ObjectsNoThreats
        // GraphQL -> objectsNoThreats: Long! (scalar)
        [JsonProperty("objectsNoThreats")]
        public System.Int64? ObjectsNoThreats { get; set; }

        //      C# -> System.Int64? ObjectsWithAnomalies
        // GraphQL -> objectsWithAnomalies: Long! (scalar)
        [JsonProperty("objectsWithAnomalies")]
        public System.Int64? ObjectsWithAnomalies { get; set; }

        //      C# -> System.Int64? ObjectsWithThreats
        // GraphQL -> objectsWithThreats: Long! (scalar)
        [JsonProperty("objectsWithThreats")]
        public System.Int64? ObjectsWithThreats { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RansomwareInvestigationObjectsReply";
    }

    public RansomwareInvestigationObjectsReply Set(
        System.Int64? ObjectsNoAnomalies = null,
        System.Int64? ObjectsNoThreats = null,
        System.Int64? ObjectsWithAnomalies = null,
        System.Int64? ObjectsWithThreats = null
    ) 
    {
        if ( ObjectsNoAnomalies != null ) {
            this.ObjectsNoAnomalies = ObjectsNoAnomalies;
        }
        if ( ObjectsNoThreats != null ) {
            this.ObjectsNoThreats = ObjectsNoThreats;
        }
        if ( ObjectsWithAnomalies != null ) {
            this.ObjectsWithAnomalies = ObjectsWithAnomalies;
        }
        if ( ObjectsWithThreats != null ) {
            this.ObjectsWithThreats = ObjectsWithThreats;
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
        //      C# -> System.Int64? ObjectsNoAnomalies
        // GraphQL -> objectsNoAnomalies: Long! (scalar)
        if (this.ObjectsNoAnomalies != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectsNoAnomalies\n" ;
            } else {
                s += ind + "objectsNoAnomalies\n" ;
            }
        }
        //      C# -> System.Int64? ObjectsNoThreats
        // GraphQL -> objectsNoThreats: Long! (scalar)
        if (this.ObjectsNoThreats != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectsNoThreats\n" ;
            } else {
                s += ind + "objectsNoThreats\n" ;
            }
        }
        //      C# -> System.Int64? ObjectsWithAnomalies
        // GraphQL -> objectsWithAnomalies: Long! (scalar)
        if (this.ObjectsWithAnomalies != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectsWithAnomalies\n" ;
            } else {
                s += ind + "objectsWithAnomalies\n" ;
            }
        }
        //      C# -> System.Int64? ObjectsWithThreats
        // GraphQL -> objectsWithThreats: Long! (scalar)
        if (this.ObjectsWithThreats != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectsWithThreats\n" ;
            } else {
                s += ind + "objectsWithThreats\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? ObjectsNoAnomalies
        // GraphQL -> objectsNoAnomalies: Long! (scalar)
        if (ec.Includes("objectsNoAnomalies",true))
        {
            if(this.ObjectsNoAnomalies == null) {

                this.ObjectsNoAnomalies = new System.Int64();

            } else {


            }
        }
        else if (this.ObjectsNoAnomalies != null && ec.Excludes("objectsNoAnomalies",true))
        {
            this.ObjectsNoAnomalies = null;
        }
        //      C# -> System.Int64? ObjectsNoThreats
        // GraphQL -> objectsNoThreats: Long! (scalar)
        if (ec.Includes("objectsNoThreats",true))
        {
            if(this.ObjectsNoThreats == null) {

                this.ObjectsNoThreats = new System.Int64();

            } else {


            }
        }
        else if (this.ObjectsNoThreats != null && ec.Excludes("objectsNoThreats",true))
        {
            this.ObjectsNoThreats = null;
        }
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
    }


    #endregion

    } // class RansomwareInvestigationObjectsReply
    
    #endregion

    public static class ListRansomwareInvestigationObjectsReplyExtensions
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
            this List<RansomwareInvestigationObjectsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RansomwareInvestigationObjectsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RansomwareInvestigationObjectsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RansomwareInvestigationObjectsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RansomwareInvestigationObjectsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types