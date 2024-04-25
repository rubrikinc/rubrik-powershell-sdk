// OracleDbSnapshotSummary.cs
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
    #region OracleDbSnapshotSummary
    public class OracleDbSnapshotSummary: BaseType
    {
        #region members

        //      C# -> System.String? DatabaseName
        // GraphQL -> databaseName: String! (scalar)
        [JsonProperty("databaseName")]
        public System.String? DatabaseName { get; set; }

        //      C# -> System.String? HostOrRacManagedId
        // GraphQL -> hostOrRacManagedId: String (scalar)
        [JsonProperty("hostOrRacManagedId")]
        public System.String? HostOrRacManagedId { get; set; }

        //      C# -> System.String? HostOrRacName
        // GraphQL -> hostOrRacName: String (scalar)
        [JsonProperty("hostOrRacName")]
        public System.String? HostOrRacName { get; set; }

        //      C# -> System.Boolean? IsValid
        // GraphQL -> isValid: Boolean (scalar)
        [JsonProperty("isValid")]
        public System.Boolean? IsValid { get; set; }

        //      C# -> List<System.String>? Tablespaces
        // GraphQL -> tablespaces: [String!]! (scalar)
        [JsonProperty("tablespaces")]
        public List<System.String>? Tablespaces { get; set; }

        //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
        // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
        [JsonProperty("baseSnapshotSummary")]
        public BaseSnapshotSummary? BaseSnapshotSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OracleDbSnapshotSummary";
    }

    public OracleDbSnapshotSummary Set(
        System.String? DatabaseName = null,
        System.String? HostOrRacManagedId = null,
        System.String? HostOrRacName = null,
        System.Boolean? IsValid = null,
        List<System.String>? Tablespaces = null,
        BaseSnapshotSummary? BaseSnapshotSummary = null
    ) 
    {
        if ( DatabaseName != null ) {
            this.DatabaseName = DatabaseName;
        }
        if ( HostOrRacManagedId != null ) {
            this.HostOrRacManagedId = HostOrRacManagedId;
        }
        if ( HostOrRacName != null ) {
            this.HostOrRacName = HostOrRacName;
        }
        if ( IsValid != null ) {
            this.IsValid = IsValid;
        }
        if ( Tablespaces != null ) {
            this.Tablespaces = Tablespaces;
        }
        if ( BaseSnapshotSummary != null ) {
            this.BaseSnapshotSummary = BaseSnapshotSummary;
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
        //      C# -> System.String? DatabaseName
        // GraphQL -> databaseName: String! (scalar)
        if (this.DatabaseName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "databaseName\n" ;
            } else {
                s += ind + "databaseName\n" ;
            }
        }
        //      C# -> System.String? HostOrRacManagedId
        // GraphQL -> hostOrRacManagedId: String (scalar)
        if (this.HostOrRacManagedId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostOrRacManagedId\n" ;
            } else {
                s += ind + "hostOrRacManagedId\n" ;
            }
        }
        //      C# -> System.String? HostOrRacName
        // GraphQL -> hostOrRacName: String (scalar)
        if (this.HostOrRacName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostOrRacName\n" ;
            } else {
                s += ind + "hostOrRacName\n" ;
            }
        }
        //      C# -> System.Boolean? IsValid
        // GraphQL -> isValid: Boolean (scalar)
        if (this.IsValid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isValid\n" ;
            } else {
                s += ind + "isValid\n" ;
            }
        }
        //      C# -> List<System.String>? Tablespaces
        // GraphQL -> tablespaces: [String!]! (scalar)
        if (this.Tablespaces != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tablespaces\n" ;
            } else {
                s += ind + "tablespaces\n" ;
            }
        }
        //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
        // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
        if (this.BaseSnapshotSummary != null) {
            var fspec = this.BaseSnapshotSummary.AsFieldSpec(conf.Child("baseSnapshotSummary"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "baseSnapshotSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? DatabaseName
        // GraphQL -> databaseName: String! (scalar)
        if (ec.Includes("databaseName",true))
        {
            if(this.DatabaseName == null) {

                this.DatabaseName = "FETCH";

            } else {


            }
        }
        else if (this.DatabaseName != null && ec.Excludes("databaseName",true))
        {
            this.DatabaseName = null;
        }
        //      C# -> System.String? HostOrRacManagedId
        // GraphQL -> hostOrRacManagedId: String (scalar)
        if (ec.Includes("hostOrRacManagedId",true))
        {
            if(this.HostOrRacManagedId == null) {

                this.HostOrRacManagedId = "FETCH";

            } else {


            }
        }
        else if (this.HostOrRacManagedId != null && ec.Excludes("hostOrRacManagedId",true))
        {
            this.HostOrRacManagedId = null;
        }
        //      C# -> System.String? HostOrRacName
        // GraphQL -> hostOrRacName: String (scalar)
        if (ec.Includes("hostOrRacName",true))
        {
            if(this.HostOrRacName == null) {

                this.HostOrRacName = "FETCH";

            } else {


            }
        }
        else if (this.HostOrRacName != null && ec.Excludes("hostOrRacName",true))
        {
            this.HostOrRacName = null;
        }
        //      C# -> System.Boolean? IsValid
        // GraphQL -> isValid: Boolean (scalar)
        if (ec.Includes("isValid",true))
        {
            if(this.IsValid == null) {

                this.IsValid = true;

            } else {


            }
        }
        else if (this.IsValid != null && ec.Excludes("isValid",true))
        {
            this.IsValid = null;
        }
        //      C# -> List<System.String>? Tablespaces
        // GraphQL -> tablespaces: [String!]! (scalar)
        if (ec.Includes("tablespaces",true))
        {
            if(this.Tablespaces == null) {

                this.Tablespaces = new List<System.String>();

            } else {


            }
        }
        else if (this.Tablespaces != null && ec.Excludes("tablespaces",true))
        {
            this.Tablespaces = null;
        }
        //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
        // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
        if (ec.Includes("baseSnapshotSummary",false))
        {
            if(this.BaseSnapshotSummary == null) {

                this.BaseSnapshotSummary = new BaseSnapshotSummary();
                this.BaseSnapshotSummary.ApplyExploratoryFieldSpec(ec.NewChild("baseSnapshotSummary"));

            } else {

                this.BaseSnapshotSummary.ApplyExploratoryFieldSpec(ec.NewChild("baseSnapshotSummary"));

            }
        }
        else if (this.BaseSnapshotSummary != null && ec.Excludes("baseSnapshotSummary",false))
        {
            this.BaseSnapshotSummary = null;
        }
    }


    #endregion

    } // class OracleDbSnapshotSummary
    
    #endregion

    public static class ListOracleDbSnapshotSummaryExtensions
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
            this List<OracleDbSnapshotSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<OracleDbSnapshotSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OracleDbSnapshotSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleDbSnapshotSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OracleDbSnapshotSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types