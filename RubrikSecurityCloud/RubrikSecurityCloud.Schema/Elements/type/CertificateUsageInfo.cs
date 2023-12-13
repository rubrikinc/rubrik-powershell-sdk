// CertificateUsageInfo.cs
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
    #region CertificateUsageInfo
    public class CertificateUsageInfo: BaseType
    {
        #region members

        //      C# -> CertificateUsage? Type
        // GraphQL -> type: CertificateUsage! (enum)
        [JsonProperty("type")]
        public CertificateUsage? Type { get; set; }

        //      C# -> List<CertificateUsageParameter>? Params
        // GraphQL -> params: [CertificateUsageParameter!]! (type)
        [JsonProperty("params")]
        public List<CertificateUsageParameter>? Params { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CertificateUsageInfo";
    }

    public CertificateUsageInfo Set(
        CertificateUsage? Type = null,
        List<CertificateUsageParameter>? Params = null
    ) 
    {
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( Params != null ) {
            this.Params = Params;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> CertificateUsage? Type
        // GraphQL -> type: CertificateUsage! (enum)
        if (this.Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "type\n" ;
            } else {
                s += ind + "type\n" ;
            }
        }
        //      C# -> List<CertificateUsageParameter>? Params
        // GraphQL -> params: [CertificateUsageParameter!]! (type)
        if (this.Params != null) {
            var fspec = this.Params.AsFieldSpec(conf.Child("params"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "params {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CertificateUsage? Type
        // GraphQL -> type: CertificateUsage! (enum)
        if (ec.Includes("type",true))
        {
            if(this.Type == null) {

                this.Type = new CertificateUsage();

            } else {


            }
        }
        else if (this.Type != null && ec.Excludes("type",true))
        {
            this.Type = null;
        }
        //      C# -> List<CertificateUsageParameter>? Params
        // GraphQL -> params: [CertificateUsageParameter!]! (type)
        if (ec.Includes("params",false))
        {
            if(this.Params == null) {

                this.Params = new List<CertificateUsageParameter>();
                this.Params.ApplyExploratoryFieldSpec(ec.NewChild("params"));

            } else {

                this.Params.ApplyExploratoryFieldSpec(ec.NewChild("params"));

            }
        }
        else if (this.Params != null && ec.Excludes("params",false))
        {
            this.Params = null;
        }
    }


    #endregion

    } // class CertificateUsageInfo
    
    #endregion

    public static class ListCertificateUsageInfoExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<CertificateUsageInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<CertificateUsageInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CertificateUsageInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CertificateUsageInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CertificateUsageInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types