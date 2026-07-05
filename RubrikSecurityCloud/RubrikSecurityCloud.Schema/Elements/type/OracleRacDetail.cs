// OracleRacDetail.cs
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
    #region OracleRacDetail
    public class OracleRacDetail: BaseType
    {
        #region members

        //      C# -> List<System.String>? BackupNodes
        // GraphQL -> backupNodes: [String!]! (scalar)
        [JsonProperty("backupNodes")]
        public List<System.String>? BackupNodes { get; set; }

        //      C# -> System.String? PrimaryNode
        // GraphQL -> primaryNode: String (scalar)
        [JsonProperty("primaryNode")]
        public System.String? PrimaryNode { get; set; }

        //      C# -> System.String? Scan
        // GraphQL -> scan: String! (scalar)
        [JsonProperty("scan")]
        public System.String? Scan { get; set; }

        //      C# -> List<System.String>? SecondaryNodes
        // GraphQL -> secondaryNodes: [String!]! (scalar)
        [JsonProperty("secondaryNodes")]
        public List<System.String>? SecondaryNodes { get; set; }

        //      C# -> OracleNonSlaProperties? OracleNonSlaProperties
        // GraphQL -> oracleNonSlaProperties: OracleNonSlaProperties (type)
        [JsonProperty("oracleNonSlaProperties")]
        public OracleNonSlaProperties? OracleNonSlaProperties { get; set; }

        //      C# -> OracleRacSummary? OracleRacSummary
        // GraphQL -> oracleRacSummary: OracleRacSummary (type)
        [JsonProperty("oracleRacSummary")]
        public OracleRacSummary? OracleRacSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OracleRacDetail";
    }

    public OracleRacDetail Set(
        List<System.String>? BackupNodes = null,
        System.String? PrimaryNode = null,
        System.String? Scan = null,
        List<System.String>? SecondaryNodes = null,
        OracleNonSlaProperties? OracleNonSlaProperties = null,
        OracleRacSummary? OracleRacSummary = null
    ) 
    {
        if ( BackupNodes != null ) {
            this.BackupNodes = BackupNodes;
        }
        if ( PrimaryNode != null ) {
            this.PrimaryNode = PrimaryNode;
        }
        if ( Scan != null ) {
            this.Scan = Scan;
        }
        if ( SecondaryNodes != null ) {
            this.SecondaryNodes = SecondaryNodes;
        }
        if ( OracleNonSlaProperties != null ) {
            this.OracleNonSlaProperties = OracleNonSlaProperties;
        }
        if ( OracleRacSummary != null ) {
            this.OracleRacSummary = OracleRacSummary;
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
        //      C# -> List<System.String>? BackupNodes
        // GraphQL -> backupNodes: [String!]! (scalar)
        if (this.BackupNodes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupNodes\n" ;
            } else {
                s += ind + "backupNodes\n" ;
            }
        }
        //      C# -> System.String? PrimaryNode
        // GraphQL -> primaryNode: String (scalar)
        if (this.PrimaryNode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "primaryNode\n" ;
            } else {
                s += ind + "primaryNode\n" ;
            }
        }
        //      C# -> System.String? Scan
        // GraphQL -> scan: String! (scalar)
        if (this.Scan != null) {
            if (conf.Flat) {
                s += conf.Prefix + "scan\n" ;
            } else {
                s += ind + "scan\n" ;
            }
        }
        //      C# -> List<System.String>? SecondaryNodes
        // GraphQL -> secondaryNodes: [String!]! (scalar)
        if (this.SecondaryNodes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "secondaryNodes\n" ;
            } else {
                s += ind + "secondaryNodes\n" ;
            }
        }
        //      C# -> OracleNonSlaProperties? OracleNonSlaProperties
        // GraphQL -> oracleNonSlaProperties: OracleNonSlaProperties (type)
        if (this.OracleNonSlaProperties != null) {
            var fspec = this.OracleNonSlaProperties.AsFieldSpec(conf.Child("oracleNonSlaProperties"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "oracleNonSlaProperties" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> OracleRacSummary? OracleRacSummary
        // GraphQL -> oracleRacSummary: OracleRacSummary (type)
        if (this.OracleRacSummary != null) {
            var fspec = this.OracleRacSummary.AsFieldSpec(conf.Child("oracleRacSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "oracleRacSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<System.String>? BackupNodes
        // GraphQL -> backupNodes: [String!]! (scalar)
        if (ec.Includes("backupNodes",true))
        {
            if(this.BackupNodes == null) {

                this.BackupNodes = new List<System.String>();

            } else {


            }
        }
        else if (this.BackupNodes != null && ec.Excludes("backupNodes",true))
        {
            this.BackupNodes = null;
        }
        //      C# -> System.String? PrimaryNode
        // GraphQL -> primaryNode: String (scalar)
        if (ec.Includes("primaryNode",true))
        {
            if(this.PrimaryNode == null) {

                this.PrimaryNode = "FETCH";

            } else {


            }
        }
        else if (this.PrimaryNode != null && ec.Excludes("primaryNode",true))
        {
            this.PrimaryNode = null;
        }
        //      C# -> System.String? Scan
        // GraphQL -> scan: String! (scalar)
        if (ec.Includes("scan",true))
        {
            if(this.Scan == null) {

                this.Scan = "FETCH";

            } else {


            }
        }
        else if (this.Scan != null && ec.Excludes("scan",true))
        {
            this.Scan = null;
        }
        //      C# -> List<System.String>? SecondaryNodes
        // GraphQL -> secondaryNodes: [String!]! (scalar)
        if (ec.Includes("secondaryNodes",true))
        {
            if(this.SecondaryNodes == null) {

                this.SecondaryNodes = new List<System.String>();

            } else {


            }
        }
        else if (this.SecondaryNodes != null && ec.Excludes("secondaryNodes",true))
        {
            this.SecondaryNodes = null;
        }
        //      C# -> OracleNonSlaProperties? OracleNonSlaProperties
        // GraphQL -> oracleNonSlaProperties: OracleNonSlaProperties (type)
        if (ec.Includes("oracleNonSlaProperties",false))
        {
            if(this.OracleNonSlaProperties == null) {

                this.OracleNonSlaProperties = new OracleNonSlaProperties();
                this.OracleNonSlaProperties.ApplyExploratoryFieldSpec(ec.NewChild("oracleNonSlaProperties"));

            } else {

                this.OracleNonSlaProperties.ApplyExploratoryFieldSpec(ec.NewChild("oracleNonSlaProperties"));

            }
        }
        else if (this.OracleNonSlaProperties != null && ec.Excludes("oracleNonSlaProperties",false))
        {
            this.OracleNonSlaProperties = null;
        }
        //      C# -> OracleRacSummary? OracleRacSummary
        // GraphQL -> oracleRacSummary: OracleRacSummary (type)
        if (ec.Includes("oracleRacSummary",false))
        {
            if(this.OracleRacSummary == null) {

                this.OracleRacSummary = new OracleRacSummary();
                this.OracleRacSummary.ApplyExploratoryFieldSpec(ec.NewChild("oracleRacSummary"));

            } else {

                this.OracleRacSummary.ApplyExploratoryFieldSpec(ec.NewChild("oracleRacSummary"));

            }
        }
        else if (this.OracleRacSummary != null && ec.Excludes("oracleRacSummary",false))
        {
            this.OracleRacSummary = null;
        }
    }


    #endregion

    } // class OracleRacDetail
    
    #endregion

    public static class ListOracleRacDetailExtensions
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
            this List<OracleRacDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<OracleRacDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OracleRacDetail> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleRacDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OracleRacDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types