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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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
            this List<CertificateUsageInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
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