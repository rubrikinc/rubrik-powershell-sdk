// KdcCredential.cs
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
    #region KdcCredential
    public class KdcCredential: BaseType
    {
        #region members

        //      C# -> System.Int32? Id
        // GraphQL -> id: Int! (scalar)
        [JsonProperty("id")]
        public System.Int32? Id { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        //      C# -> KdcConfig? KdcConfig
        // GraphQL -> kdcConfig: KdcConfig (type)
        [JsonProperty("kdcConfig")]
        public KdcConfig? KdcConfig { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "KdcCredential";
    }

    public KdcCredential Set(
        System.Int32? Id = null,
        System.String? Username = null,
        KdcConfig? KdcConfig = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Username != null ) {
            this.Username = Username;
        }
        if ( KdcConfig != null ) {
            this.KdcConfig = KdcConfig;
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
        //      C# -> System.Int32? Id
        // GraphQL -> id: Int! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
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
        //      C# -> KdcConfig? KdcConfig
        // GraphQL -> kdcConfig: KdcConfig (type)
        if (this.KdcConfig != null) {
            var fspec = this.KdcConfig.AsFieldSpec(conf.Child("kdcConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "kdcConfig" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int32? Id
        // GraphQL -> id: Int! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = Int32.MinValue;

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
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
        //      C# -> KdcConfig? KdcConfig
        // GraphQL -> kdcConfig: KdcConfig (type)
        if (ec.Includes("kdcConfig",false))
        {
            if(this.KdcConfig == null) {

                this.KdcConfig = new KdcConfig();
                this.KdcConfig.ApplyExploratoryFieldSpec(ec.NewChild("kdcConfig"));

            } else {

                this.KdcConfig.ApplyExploratoryFieldSpec(ec.NewChild("kdcConfig"));

            }
        }
        else if (this.KdcConfig != null && ec.Excludes("kdcConfig",false))
        {
            this.KdcConfig = null;
        }
    }


    #endregion

    } // class KdcCredential
    
    #endregion

    public static class ListKdcCredentialExtensions
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
            this List<KdcCredential> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<KdcCredential> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<KdcCredential> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new KdcCredential());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<KdcCredential> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types