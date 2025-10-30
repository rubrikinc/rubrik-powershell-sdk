// KdcConfig.cs
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
    #region KdcConfig
    public class KdcConfig: BaseType
    {
        #region members

        //      C# -> System.String? Kdc1
        // GraphQL -> kdc1: String! (scalar)
        [JsonProperty("kdc1")]
        public System.String? Kdc1 { get; set; }

        //      C# -> System.String? Kdc2
        // GraphQL -> kdc2: String! (scalar)
        [JsonProperty("kdc2")]
        public System.String? Kdc2 { get; set; }

        //      C# -> System.String? Realm
        // GraphQL -> realm: String! (scalar)
        [JsonProperty("realm")]
        public System.String? Realm { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "KdcConfig";
    }

    public KdcConfig Set(
        System.String? Kdc1 = null,
        System.String? Kdc2 = null,
        System.String? Realm = null
    ) 
    {
        if ( Kdc1 != null ) {
            this.Kdc1 = Kdc1;
        }
        if ( Kdc2 != null ) {
            this.Kdc2 = Kdc2;
        }
        if ( Realm != null ) {
            this.Realm = Realm;
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
        //      C# -> System.String? Kdc1
        // GraphQL -> kdc1: String! (scalar)
        if (this.Kdc1 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "kdc1\n" ;
            } else {
                s += ind + "kdc1\n" ;
            }
        }
        //      C# -> System.String? Kdc2
        // GraphQL -> kdc2: String! (scalar)
        if (this.Kdc2 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "kdc2\n" ;
            } else {
                s += ind + "kdc2\n" ;
            }
        }
        //      C# -> System.String? Realm
        // GraphQL -> realm: String! (scalar)
        if (this.Realm != null) {
            if (conf.Flat) {
                s += conf.Prefix + "realm\n" ;
            } else {
                s += ind + "realm\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? Kdc1
        // GraphQL -> kdc1: String! (scalar)
        if (ec.Includes("kdc1",true))
        {
            if(this.Kdc1 == null) {

                this.Kdc1 = "FETCH";

            } else {


            }
        }
        else if (this.Kdc1 != null && ec.Excludes("kdc1",true))
        {
            this.Kdc1 = null;
        }
        //      C# -> System.String? Kdc2
        // GraphQL -> kdc2: String! (scalar)
        if (ec.Includes("kdc2",true))
        {
            if(this.Kdc2 == null) {

                this.Kdc2 = "FETCH";

            } else {


            }
        }
        else if (this.Kdc2 != null && ec.Excludes("kdc2",true))
        {
            this.Kdc2 = null;
        }
        //      C# -> System.String? Realm
        // GraphQL -> realm: String! (scalar)
        if (ec.Includes("realm",true))
        {
            if(this.Realm == null) {

                this.Realm = "FETCH";

            } else {


            }
        }
        else if (this.Realm != null && ec.Excludes("realm",true))
        {
            this.Realm = null;
        }
    }


    #endregion

    } // class KdcConfig
    
    #endregion

    public static class ListKdcConfigExtensions
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
            this List<KdcConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<KdcConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<KdcConfig> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new KdcConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<KdcConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types