// NasNamespaceNetAppMetroClusterInfo.cs
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
    #region NasNamespaceNetAppMetroClusterInfo
    public class NasNamespaceNetAppMetroClusterInfo: BaseType
    {
        #region members

        //      C# -> System.String? ConfigurationState
        // GraphQL -> configurationState: String! (scalar)
        [JsonProperty("configurationState")]
        public System.String? ConfigurationState { get; set; }

        //      C# -> System.String? PartnerNamespaceIdOnNas
        // GraphQL -> partnerNamespaceIdOnNas: String! (scalar)
        [JsonProperty("partnerNamespaceIdOnNas")]
        public System.String? PartnerNamespaceIdOnNas { get; set; }

        //      C# -> System.String? PartnerNamespaceName
        // GraphQL -> partnerNamespaceName: String! (scalar)
        [JsonProperty("partnerNamespaceName")]
        public System.String? PartnerNamespaceName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NasNamespaceNetAppMetroClusterInfo";
    }

    public NasNamespaceNetAppMetroClusterInfo Set(
        System.String? ConfigurationState = null,
        System.String? PartnerNamespaceIdOnNas = null,
        System.String? PartnerNamespaceName = null
    ) 
    {
        if ( ConfigurationState != null ) {
            this.ConfigurationState = ConfigurationState;
        }
        if ( PartnerNamespaceIdOnNas != null ) {
            this.PartnerNamespaceIdOnNas = PartnerNamespaceIdOnNas;
        }
        if ( PartnerNamespaceName != null ) {
            this.PartnerNamespaceName = PartnerNamespaceName;
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
        //      C# -> System.String? ConfigurationState
        // GraphQL -> configurationState: String! (scalar)
        if (this.ConfigurationState != null) {
            if (conf.Flat) {
                s += conf.Prefix + "configurationState\n" ;
            } else {
                s += ind + "configurationState\n" ;
            }
        }
        //      C# -> System.String? PartnerNamespaceIdOnNas
        // GraphQL -> partnerNamespaceIdOnNas: String! (scalar)
        if (this.PartnerNamespaceIdOnNas != null) {
            if (conf.Flat) {
                s += conf.Prefix + "partnerNamespaceIdOnNas\n" ;
            } else {
                s += ind + "partnerNamespaceIdOnNas\n" ;
            }
        }
        //      C# -> System.String? PartnerNamespaceName
        // GraphQL -> partnerNamespaceName: String! (scalar)
        if (this.PartnerNamespaceName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "partnerNamespaceName\n" ;
            } else {
                s += ind + "partnerNamespaceName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? ConfigurationState
        // GraphQL -> configurationState: String! (scalar)
        if (ec.Includes("configurationState",true))
        {
            if(this.ConfigurationState == null) {

                this.ConfigurationState = "FETCH";

            } else {


            }
        }
        else if (this.ConfigurationState != null && ec.Excludes("configurationState",true))
        {
            this.ConfigurationState = null;
        }
        //      C# -> System.String? PartnerNamespaceIdOnNas
        // GraphQL -> partnerNamespaceIdOnNas: String! (scalar)
        if (ec.Includes("partnerNamespaceIdOnNas",true))
        {
            if(this.PartnerNamespaceIdOnNas == null) {

                this.PartnerNamespaceIdOnNas = "FETCH";

            } else {


            }
        }
        else if (this.PartnerNamespaceIdOnNas != null && ec.Excludes("partnerNamespaceIdOnNas",true))
        {
            this.PartnerNamespaceIdOnNas = null;
        }
        //      C# -> System.String? PartnerNamespaceName
        // GraphQL -> partnerNamespaceName: String! (scalar)
        if (ec.Includes("partnerNamespaceName",true))
        {
            if(this.PartnerNamespaceName == null) {

                this.PartnerNamespaceName = "FETCH";

            } else {


            }
        }
        else if (this.PartnerNamespaceName != null && ec.Excludes("partnerNamespaceName",true))
        {
            this.PartnerNamespaceName = null;
        }
    }


    #endregion

    } // class NasNamespaceNetAppMetroClusterInfo
    
    #endregion

    public static class ListNasNamespaceNetAppMetroClusterInfoExtensions
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
            this List<NasNamespaceNetAppMetroClusterInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NasNamespaceNetAppMetroClusterInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NasNamespaceNetAppMetroClusterInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NasNamespaceNetAppMetroClusterInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NasNamespaceNetAppMetroClusterInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types