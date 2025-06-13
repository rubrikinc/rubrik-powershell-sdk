// NasSystemNetAppMetroClusterInfo.cs
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
    #region NasSystemNetAppMetroClusterInfo
    public class NasSystemNetAppMetroClusterInfo: BaseType
    {
        #region members

        //      C# -> System.String? LocalClusterIdOnNas
        // GraphQL -> localClusterIdOnNas: String! (scalar)
        [JsonProperty("localClusterIdOnNas")]
        public System.String? LocalClusterIdOnNas { get; set; }

        //      C# -> System.String? LocalClusterMode
        // GraphQL -> localClusterMode: String! (scalar)
        [JsonProperty("localClusterMode")]
        public System.String? LocalClusterMode { get; set; }

        //      C# -> System.String? LocalClusterNameOnNas
        // GraphQL -> localClusterNameOnNas: String! (scalar)
        [JsonProperty("localClusterNameOnNas")]
        public System.String? LocalClusterNameOnNas { get; set; }

        //      C# -> System.String? PartnerClusterIdOnNas
        // GraphQL -> partnerClusterIdOnNas: String! (scalar)
        [JsonProperty("partnerClusterIdOnNas")]
        public System.String? PartnerClusterIdOnNas { get; set; }

        //      C# -> System.String? PartnerClusterMode
        // GraphQL -> partnerClusterMode: String! (scalar)
        [JsonProperty("partnerClusterMode")]
        public System.String? PartnerClusterMode { get; set; }

        //      C# -> System.String? PartnerClusterNameOnNas
        // GraphQL -> partnerClusterNameOnNas: String! (scalar)
        [JsonProperty("partnerClusterNameOnNas")]
        public System.String? PartnerClusterNameOnNas { get; set; }

        //      C# -> System.String? PartnerNasSystemCdmIdOpt
        // GraphQL -> partnerNasSystemCdmIdOpt: UUID (scalar)
        [JsonProperty("partnerNasSystemCdmIdOpt")]
        public System.String? PartnerNasSystemCdmIdOpt { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NasSystemNetAppMetroClusterInfo";
    }

    public NasSystemNetAppMetroClusterInfo Set(
        System.String? LocalClusterIdOnNas = null,
        System.String? LocalClusterMode = null,
        System.String? LocalClusterNameOnNas = null,
        System.String? PartnerClusterIdOnNas = null,
        System.String? PartnerClusterMode = null,
        System.String? PartnerClusterNameOnNas = null,
        System.String? PartnerNasSystemCdmIdOpt = null
    ) 
    {
        if ( LocalClusterIdOnNas != null ) {
            this.LocalClusterIdOnNas = LocalClusterIdOnNas;
        }
        if ( LocalClusterMode != null ) {
            this.LocalClusterMode = LocalClusterMode;
        }
        if ( LocalClusterNameOnNas != null ) {
            this.LocalClusterNameOnNas = LocalClusterNameOnNas;
        }
        if ( PartnerClusterIdOnNas != null ) {
            this.PartnerClusterIdOnNas = PartnerClusterIdOnNas;
        }
        if ( PartnerClusterMode != null ) {
            this.PartnerClusterMode = PartnerClusterMode;
        }
        if ( PartnerClusterNameOnNas != null ) {
            this.PartnerClusterNameOnNas = PartnerClusterNameOnNas;
        }
        if ( PartnerNasSystemCdmIdOpt != null ) {
            this.PartnerNasSystemCdmIdOpt = PartnerNasSystemCdmIdOpt;
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
        //      C# -> System.String? LocalClusterIdOnNas
        // GraphQL -> localClusterIdOnNas: String! (scalar)
        if (this.LocalClusterIdOnNas != null) {
            if (conf.Flat) {
                s += conf.Prefix + "localClusterIdOnNas\n" ;
            } else {
                s += ind + "localClusterIdOnNas\n" ;
            }
        }
        //      C# -> System.String? LocalClusterMode
        // GraphQL -> localClusterMode: String! (scalar)
        if (this.LocalClusterMode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "localClusterMode\n" ;
            } else {
                s += ind + "localClusterMode\n" ;
            }
        }
        //      C# -> System.String? LocalClusterNameOnNas
        // GraphQL -> localClusterNameOnNas: String! (scalar)
        if (this.LocalClusterNameOnNas != null) {
            if (conf.Flat) {
                s += conf.Prefix + "localClusterNameOnNas\n" ;
            } else {
                s += ind + "localClusterNameOnNas\n" ;
            }
        }
        //      C# -> System.String? PartnerClusterIdOnNas
        // GraphQL -> partnerClusterIdOnNas: String! (scalar)
        if (this.PartnerClusterIdOnNas != null) {
            if (conf.Flat) {
                s += conf.Prefix + "partnerClusterIdOnNas\n" ;
            } else {
                s += ind + "partnerClusterIdOnNas\n" ;
            }
        }
        //      C# -> System.String? PartnerClusterMode
        // GraphQL -> partnerClusterMode: String! (scalar)
        if (this.PartnerClusterMode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "partnerClusterMode\n" ;
            } else {
                s += ind + "partnerClusterMode\n" ;
            }
        }
        //      C# -> System.String? PartnerClusterNameOnNas
        // GraphQL -> partnerClusterNameOnNas: String! (scalar)
        if (this.PartnerClusterNameOnNas != null) {
            if (conf.Flat) {
                s += conf.Prefix + "partnerClusterNameOnNas\n" ;
            } else {
                s += ind + "partnerClusterNameOnNas\n" ;
            }
        }
        //      C# -> System.String? PartnerNasSystemCdmIdOpt
        // GraphQL -> partnerNasSystemCdmIdOpt: UUID (scalar)
        if (this.PartnerNasSystemCdmIdOpt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "partnerNasSystemCdmIdOpt\n" ;
            } else {
                s += ind + "partnerNasSystemCdmIdOpt\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? LocalClusterIdOnNas
        // GraphQL -> localClusterIdOnNas: String! (scalar)
        if (ec.Includes("localClusterIdOnNas",true))
        {
            if(this.LocalClusterIdOnNas == null) {

                this.LocalClusterIdOnNas = "FETCH";

            } else {


            }
        }
        else if (this.LocalClusterIdOnNas != null && ec.Excludes("localClusterIdOnNas",true))
        {
            this.LocalClusterIdOnNas = null;
        }
        //      C# -> System.String? LocalClusterMode
        // GraphQL -> localClusterMode: String! (scalar)
        if (ec.Includes("localClusterMode",true))
        {
            if(this.LocalClusterMode == null) {

                this.LocalClusterMode = "FETCH";

            } else {


            }
        }
        else if (this.LocalClusterMode != null && ec.Excludes("localClusterMode",true))
        {
            this.LocalClusterMode = null;
        }
        //      C# -> System.String? LocalClusterNameOnNas
        // GraphQL -> localClusterNameOnNas: String! (scalar)
        if (ec.Includes("localClusterNameOnNas",true))
        {
            if(this.LocalClusterNameOnNas == null) {

                this.LocalClusterNameOnNas = "FETCH";

            } else {


            }
        }
        else if (this.LocalClusterNameOnNas != null && ec.Excludes("localClusterNameOnNas",true))
        {
            this.LocalClusterNameOnNas = null;
        }
        //      C# -> System.String? PartnerClusterIdOnNas
        // GraphQL -> partnerClusterIdOnNas: String! (scalar)
        if (ec.Includes("partnerClusterIdOnNas",true))
        {
            if(this.PartnerClusterIdOnNas == null) {

                this.PartnerClusterIdOnNas = "FETCH";

            } else {


            }
        }
        else if (this.PartnerClusterIdOnNas != null && ec.Excludes("partnerClusterIdOnNas",true))
        {
            this.PartnerClusterIdOnNas = null;
        }
        //      C# -> System.String? PartnerClusterMode
        // GraphQL -> partnerClusterMode: String! (scalar)
        if (ec.Includes("partnerClusterMode",true))
        {
            if(this.PartnerClusterMode == null) {

                this.PartnerClusterMode = "FETCH";

            } else {


            }
        }
        else if (this.PartnerClusterMode != null && ec.Excludes("partnerClusterMode",true))
        {
            this.PartnerClusterMode = null;
        }
        //      C# -> System.String? PartnerClusterNameOnNas
        // GraphQL -> partnerClusterNameOnNas: String! (scalar)
        if (ec.Includes("partnerClusterNameOnNas",true))
        {
            if(this.PartnerClusterNameOnNas == null) {

                this.PartnerClusterNameOnNas = "FETCH";

            } else {


            }
        }
        else if (this.PartnerClusterNameOnNas != null && ec.Excludes("partnerClusterNameOnNas",true))
        {
            this.PartnerClusterNameOnNas = null;
        }
        //      C# -> System.String? PartnerNasSystemCdmIdOpt
        // GraphQL -> partnerNasSystemCdmIdOpt: UUID (scalar)
        if (ec.Includes("partnerNasSystemCdmIdOpt",true))
        {
            if(this.PartnerNasSystemCdmIdOpt == null) {

                this.PartnerNasSystemCdmIdOpt = "FETCH";

            } else {


            }
        }
        else if (this.PartnerNasSystemCdmIdOpt != null && ec.Excludes("partnerNasSystemCdmIdOpt",true))
        {
            this.PartnerNasSystemCdmIdOpt = null;
        }
    }


    #endregion

    } // class NasSystemNetAppMetroClusterInfo
    
    #endregion

    public static class ListNasSystemNetAppMetroClusterInfoExtensions
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
            this List<NasSystemNetAppMetroClusterInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NasSystemNetAppMetroClusterInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NasSystemNetAppMetroClusterInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NasSystemNetAppMetroClusterInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NasSystemNetAppMetroClusterInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types