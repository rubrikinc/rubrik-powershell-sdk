// OracleSddDetail.cs
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
    #region OracleSddDetail
    public class OracleSddDetail: BaseType
    {
        #region members

        //      C# -> System.Boolean? ShouldSddViaRba
        // GraphQL -> shouldSddViaRba: Boolean! (scalar)
        [JsonProperty("shouldSddViaRba")]
        public System.Boolean? ShouldSddViaRba { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        //      C# -> System.String? WalletPath
        // GraphQL -> walletPath: String! (scalar)
        [JsonProperty("walletPath")]
        public System.String? WalletPath { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OracleSddDetail";
    }

    public OracleSddDetail Set(
        System.Boolean? ShouldSddViaRba = null,
        System.String? Username = null,
        System.String? WalletPath = null
    ) 
    {
        if ( ShouldSddViaRba != null ) {
            this.ShouldSddViaRba = ShouldSddViaRba;
        }
        if ( Username != null ) {
            this.Username = Username;
        }
        if ( WalletPath != null ) {
            this.WalletPath = WalletPath;
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
        //      C# -> System.Boolean? ShouldSddViaRba
        // GraphQL -> shouldSddViaRba: Boolean! (scalar)
        if (this.ShouldSddViaRba != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldSddViaRba\n" ;
            } else {
                s += ind + "shouldSddViaRba\n" ;
            }
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username != null) {
            if (conf.Flat) {
                s += conf.Prefix + "username\n" ;
            } else {
                s += ind + "username\n" ;
            }
        }
        //      C# -> System.String? WalletPath
        // GraphQL -> walletPath: String! (scalar)
        if (this.WalletPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "walletPath\n" ;
            } else {
                s += ind + "walletPath\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? ShouldSddViaRba
        // GraphQL -> shouldSddViaRba: Boolean! (scalar)
        if (ec.Includes("shouldSddViaRba",true))
        {
            if(this.ShouldSddViaRba == null) {

                this.ShouldSddViaRba = true;

            } else {


            }
        }
        else if (this.ShouldSddViaRba != null && ec.Excludes("shouldSddViaRba",true))
        {
            this.ShouldSddViaRba = null;
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (ec.Includes("username",true))
        {
            if(this.Username == null) {

                this.Username = "FETCH";

            } else {


            }
        }
        else if (this.Username != null && ec.Excludes("username",true))
        {
            this.Username = null;
        }
        //      C# -> System.String? WalletPath
        // GraphQL -> walletPath: String! (scalar)
        if (ec.Includes("walletPath",true))
        {
            if(this.WalletPath == null) {

                this.WalletPath = "FETCH";

            } else {


            }
        }
        else if (this.WalletPath != null && ec.Excludes("walletPath",true))
        {
            this.WalletPath = null;
        }
    }


    #endregion

    } // class OracleSddDetail
    
    #endregion

    public static class ListOracleSddDetailExtensions
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
            this List<OracleSddDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<OracleSddDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OracleSddDetail> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleSddDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OracleSddDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types