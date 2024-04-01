// CdmMongoSslParams.cs
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
    #region CdmMongoSslParams
    public class CdmMongoSslParams: BaseType
    {
        #region members

        //      C# -> SourceSslCertReqs? SslCertRequirements
        // GraphQL -> sslCertRequirements: SourceSslCertReqs! (enum)
        [JsonProperty("sslCertRequirements")]
        public SourceSslCertReqs? SslCertRequirements { get; set; }

        //      C# -> System.Boolean? IsSslEnabled
        // GraphQL -> isSslEnabled: Boolean! (scalar)
        [JsonProperty("isSslEnabled")]
        public System.Boolean? IsSslEnabled { get; set; }

        //      C# -> System.String? SslCaCerts
        // GraphQL -> sslCaCerts: String! (scalar)
        [JsonProperty("sslCaCerts")]
        public System.String? SslCaCerts { get; set; }

        //      C# -> System.String? SslCertfile
        // GraphQL -> sslCertfile: String! (scalar)
        [JsonProperty("sslCertfile")]
        public System.String? SslCertfile { get; set; }

        //      C# -> System.String? SslKeyfile
        // GraphQL -> sslKeyfile: String! (scalar)
        [JsonProperty("sslKeyfile")]
        public System.String? SslKeyfile { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmMongoSslParams";
    }

    public CdmMongoSslParams Set(
        SourceSslCertReqs? SslCertRequirements = null,
        System.Boolean? IsSslEnabled = null,
        System.String? SslCaCerts = null,
        System.String? SslCertfile = null,
        System.String? SslKeyfile = null
    ) 
    {
        if ( SslCertRequirements != null ) {
            this.SslCertRequirements = SslCertRequirements;
        }
        if ( IsSslEnabled != null ) {
            this.IsSslEnabled = IsSslEnabled;
        }
        if ( SslCaCerts != null ) {
            this.SslCaCerts = SslCaCerts;
        }
        if ( SslCertfile != null ) {
            this.SslCertfile = SslCertfile;
        }
        if ( SslKeyfile != null ) {
            this.SslKeyfile = SslKeyfile;
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
        //      C# -> SourceSslCertReqs? SslCertRequirements
        // GraphQL -> sslCertRequirements: SourceSslCertReqs! (enum)
        if (this.SslCertRequirements != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sslCertRequirements\n" ;
            } else {
                s += ind + "sslCertRequirements\n" ;
            }
        }
        //      C# -> System.Boolean? IsSslEnabled
        // GraphQL -> isSslEnabled: Boolean! (scalar)
        if (this.IsSslEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isSslEnabled\n" ;
            } else {
                s += ind + "isSslEnabled\n" ;
            }
        }
        //      C# -> System.String? SslCaCerts
        // GraphQL -> sslCaCerts: String! (scalar)
        if (this.SslCaCerts != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sslCaCerts\n" ;
            } else {
                s += ind + "sslCaCerts\n" ;
            }
        }
        //      C# -> System.String? SslCertfile
        // GraphQL -> sslCertfile: String! (scalar)
        if (this.SslCertfile != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sslCertfile\n" ;
            } else {
                s += ind + "sslCertfile\n" ;
            }
        }
        //      C# -> System.String? SslKeyfile
        // GraphQL -> sslKeyfile: String! (scalar)
        if (this.SslKeyfile != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sslKeyfile\n" ;
            } else {
                s += ind + "sslKeyfile\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SourceSslCertReqs? SslCertRequirements
        // GraphQL -> sslCertRequirements: SourceSslCertReqs! (enum)
        if (ec.Includes("sslCertRequirements",true))
        {
            if(this.SslCertRequirements == null) {

                this.SslCertRequirements = new SourceSslCertReqs();

            } else {


            }
        }
        else if (this.SslCertRequirements != null && ec.Excludes("sslCertRequirements",true))
        {
            this.SslCertRequirements = null;
        }
        //      C# -> System.Boolean? IsSslEnabled
        // GraphQL -> isSslEnabled: Boolean! (scalar)
        if (ec.Includes("isSslEnabled",true))
        {
            if(this.IsSslEnabled == null) {

                this.IsSslEnabled = true;

            } else {


            }
        }
        else if (this.IsSslEnabled != null && ec.Excludes("isSslEnabled",true))
        {
            this.IsSslEnabled = null;
        }
        //      C# -> System.String? SslCaCerts
        // GraphQL -> sslCaCerts: String! (scalar)
        if (ec.Includes("sslCaCerts",true))
        {
            if(this.SslCaCerts == null) {

                this.SslCaCerts = "FETCH";

            } else {


            }
        }
        else if (this.SslCaCerts != null && ec.Excludes("sslCaCerts",true))
        {
            this.SslCaCerts = null;
        }
        //      C# -> System.String? SslCertfile
        // GraphQL -> sslCertfile: String! (scalar)
        if (ec.Includes("sslCertfile",true))
        {
            if(this.SslCertfile == null) {

                this.SslCertfile = "FETCH";

            } else {


            }
        }
        else if (this.SslCertfile != null && ec.Excludes("sslCertfile",true))
        {
            this.SslCertfile = null;
        }
        //      C# -> System.String? SslKeyfile
        // GraphQL -> sslKeyfile: String! (scalar)
        if (ec.Includes("sslKeyfile",true))
        {
            if(this.SslKeyfile == null) {

                this.SslKeyfile = "FETCH";

            } else {


            }
        }
        else if (this.SslKeyfile != null && ec.Excludes("sslKeyfile",true))
        {
            this.SslKeyfile = null;
        }
    }


    #endregion

    } // class CdmMongoSslParams
    
    #endregion

    public static class ListCdmMongoSslParamsExtensions
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
            this List<CdmMongoSslParams> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CdmMongoSslParams> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CdmMongoSslParams> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmMongoSslParams());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CdmMongoSslParams> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types