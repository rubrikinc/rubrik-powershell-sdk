// ThreatHuntObjectMetricsReply.cs
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
    #region ThreatHuntObjectMetricsReply
    public class ThreatHuntObjectMetricsReply: BaseType
    {
        #region members

        //      C# -> System.Int64? CleanRecoverableObjectLimit
        // GraphQL -> cleanRecoverableObjectLimit: Long! (scalar)
        [JsonProperty("cleanRecoverableObjectLimit")]
        public System.Int64? CleanRecoverableObjectLimit { get; set; }

        //      C# -> System.Int64? TotalAffectedObjects
        // GraphQL -> totalAffectedObjects: Long! (scalar)
        [JsonProperty("totalAffectedObjects")]
        public System.Int64? TotalAffectedObjects { get; set; }

        //      C# -> System.Int64? TotalObjectsScanned
        // GraphQL -> totalObjectsScanned: Long! (scalar)
        [JsonProperty("totalObjectsScanned")]
        public System.Int64? TotalObjectsScanned { get; set; }

        //      C# -> System.Int64? TotalObjectsUnscannable
        // GraphQL -> totalObjectsUnscannable: Long! (scalar)
        [JsonProperty("totalObjectsUnscannable")]
        public System.Int64? TotalObjectsUnscannable { get; set; }

        //      C# -> System.Int64? TotalUnaffectedObjects
        // GraphQL -> totalUnaffectedObjects: Long! (scalar)
        [JsonProperty("totalUnaffectedObjects")]
        public System.Int64? TotalUnaffectedObjects { get; set; }

        //      C# -> System.Int64? UnaffectedObjectsFromDb
        // GraphQL -> unaffectedObjectsFromDb: Long! (scalar)
        [JsonProperty("unaffectedObjectsFromDb")]
        public System.Int64? UnaffectedObjectsFromDb { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ThreatHuntObjectMetricsReply";
    }

    public ThreatHuntObjectMetricsReply Set(
        System.Int64? CleanRecoverableObjectLimit = null,
        System.Int64? TotalAffectedObjects = null,
        System.Int64? TotalObjectsScanned = null,
        System.Int64? TotalObjectsUnscannable = null,
        System.Int64? TotalUnaffectedObjects = null,
        System.Int64? UnaffectedObjectsFromDb = null
    ) 
    {
        if ( CleanRecoverableObjectLimit != null ) {
            this.CleanRecoverableObjectLimit = CleanRecoverableObjectLimit;
        }
        if ( TotalAffectedObjects != null ) {
            this.TotalAffectedObjects = TotalAffectedObjects;
        }
        if ( TotalObjectsScanned != null ) {
            this.TotalObjectsScanned = TotalObjectsScanned;
        }
        if ( TotalObjectsUnscannable != null ) {
            this.TotalObjectsUnscannable = TotalObjectsUnscannable;
        }
        if ( TotalUnaffectedObjects != null ) {
            this.TotalUnaffectedObjects = TotalUnaffectedObjects;
        }
        if ( UnaffectedObjectsFromDb != null ) {
            this.UnaffectedObjectsFromDb = UnaffectedObjectsFromDb;
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
        //      C# -> System.Int64? CleanRecoverableObjectLimit
        // GraphQL -> cleanRecoverableObjectLimit: Long! (scalar)
        if (this.CleanRecoverableObjectLimit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cleanRecoverableObjectLimit\n" ;
            } else {
                s += ind + "cleanRecoverableObjectLimit\n" ;
            }
        }
        //      C# -> System.Int64? TotalAffectedObjects
        // GraphQL -> totalAffectedObjects: Long! (scalar)
        if (this.TotalAffectedObjects != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalAffectedObjects\n" ;
            } else {
                s += ind + "totalAffectedObjects\n" ;
            }
        }
        //      C# -> System.Int64? TotalObjectsScanned
        // GraphQL -> totalObjectsScanned: Long! (scalar)
        if (this.TotalObjectsScanned != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalObjectsScanned\n" ;
            } else {
                s += ind + "totalObjectsScanned\n" ;
            }
        }
        //      C# -> System.Int64? TotalObjectsUnscannable
        // GraphQL -> totalObjectsUnscannable: Long! (scalar)
        if (this.TotalObjectsUnscannable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalObjectsUnscannable\n" ;
            } else {
                s += ind + "totalObjectsUnscannable\n" ;
            }
        }
        //      C# -> System.Int64? TotalUnaffectedObjects
        // GraphQL -> totalUnaffectedObjects: Long! (scalar)
        if (this.TotalUnaffectedObjects != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalUnaffectedObjects\n" ;
            } else {
                s += ind + "totalUnaffectedObjects\n" ;
            }
        }
        //      C# -> System.Int64? UnaffectedObjectsFromDb
        // GraphQL -> unaffectedObjectsFromDb: Long! (scalar)
        if (this.UnaffectedObjectsFromDb != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unaffectedObjectsFromDb\n" ;
            } else {
                s += ind + "unaffectedObjectsFromDb\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? CleanRecoverableObjectLimit
        // GraphQL -> cleanRecoverableObjectLimit: Long! (scalar)
        if (ec.Includes("cleanRecoverableObjectLimit",true))
        {
            if(this.CleanRecoverableObjectLimit == null) {

                this.CleanRecoverableObjectLimit = new System.Int64();

            } else {


            }
        }
        else if (this.CleanRecoverableObjectLimit != null && ec.Excludes("cleanRecoverableObjectLimit",true))
        {
            this.CleanRecoverableObjectLimit = null;
        }
        //      C# -> System.Int64? TotalAffectedObjects
        // GraphQL -> totalAffectedObjects: Long! (scalar)
        if (ec.Includes("totalAffectedObjects",true))
        {
            if(this.TotalAffectedObjects == null) {

                this.TotalAffectedObjects = new System.Int64();

            } else {


            }
        }
        else if (this.TotalAffectedObjects != null && ec.Excludes("totalAffectedObjects",true))
        {
            this.TotalAffectedObjects = null;
        }
        //      C# -> System.Int64? TotalObjectsScanned
        // GraphQL -> totalObjectsScanned: Long! (scalar)
        if (ec.Includes("totalObjectsScanned",true))
        {
            if(this.TotalObjectsScanned == null) {

                this.TotalObjectsScanned = new System.Int64();

            } else {


            }
        }
        else if (this.TotalObjectsScanned != null && ec.Excludes("totalObjectsScanned",true))
        {
            this.TotalObjectsScanned = null;
        }
        //      C# -> System.Int64? TotalObjectsUnscannable
        // GraphQL -> totalObjectsUnscannable: Long! (scalar)
        if (ec.Includes("totalObjectsUnscannable",true))
        {
            if(this.TotalObjectsUnscannable == null) {

                this.TotalObjectsUnscannable = new System.Int64();

            } else {


            }
        }
        else if (this.TotalObjectsUnscannable != null && ec.Excludes("totalObjectsUnscannable",true))
        {
            this.TotalObjectsUnscannable = null;
        }
        //      C# -> System.Int64? TotalUnaffectedObjects
        // GraphQL -> totalUnaffectedObjects: Long! (scalar)
        if (ec.Includes("totalUnaffectedObjects",true))
        {
            if(this.TotalUnaffectedObjects == null) {

                this.TotalUnaffectedObjects = new System.Int64();

            } else {


            }
        }
        else if (this.TotalUnaffectedObjects != null && ec.Excludes("totalUnaffectedObjects",true))
        {
            this.TotalUnaffectedObjects = null;
        }
        //      C# -> System.Int64? UnaffectedObjectsFromDb
        // GraphQL -> unaffectedObjectsFromDb: Long! (scalar)
        if (ec.Includes("unaffectedObjectsFromDb",true))
        {
            if(this.UnaffectedObjectsFromDb == null) {

                this.UnaffectedObjectsFromDb = new System.Int64();

            } else {


            }
        }
        else if (this.UnaffectedObjectsFromDb != null && ec.Excludes("unaffectedObjectsFromDb",true))
        {
            this.UnaffectedObjectsFromDb = null;
        }
    }


    #endregion

    } // class ThreatHuntObjectMetricsReply
    
    #endregion

    public static class ListThreatHuntObjectMetricsReplyExtensions
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
            this List<ThreatHuntObjectMetricsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ThreatHuntObjectMetricsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ThreatHuntObjectMetricsReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatHuntObjectMetricsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ThreatHuntObjectMetricsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types