// SyslogExportRuleSummary.cs
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
    #region SyslogExportRuleSummary
    public class SyslogExportRuleSummary: BaseType
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> SyslogCertificateInfo? SyslogCertificateInfo
        // GraphQL -> syslogCertificateInfo: SyslogCertificateInfo (type)
        [JsonProperty("syslogCertificateInfo")]
        public SyslogCertificateInfo? SyslogCertificateInfo { get; set; }

        //      C# -> SyslogExportRuleFull? SyslogExportRuleFull
        // GraphQL -> syslogExportRuleFull: SyslogExportRuleFull (type)
        [JsonProperty("syslogExportRuleFull")]
        public SyslogExportRuleFull? SyslogExportRuleFull { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SyslogExportRuleSummary";
    }

    public SyslogExportRuleSummary Set(
        System.String? Id = null,
        SyslogCertificateInfo? SyslogCertificateInfo = null,
        SyslogExportRuleFull? SyslogExportRuleFull = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( SyslogCertificateInfo != null ) {
            this.SyslogCertificateInfo = SyslogCertificateInfo;
        }
        if ( SyslogExportRuleFull != null ) {
            this.SyslogExportRuleFull = SyslogExportRuleFull;
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
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> SyslogCertificateInfo? SyslogCertificateInfo
        // GraphQL -> syslogCertificateInfo: SyslogCertificateInfo (type)
        if (this.SyslogCertificateInfo != null) {
            var fspec = this.SyslogCertificateInfo.AsFieldSpec(conf.Child("syslogCertificateInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "syslogCertificateInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SyslogExportRuleFull? SyslogExportRuleFull
        // GraphQL -> syslogExportRuleFull: SyslogExportRuleFull (type)
        if (this.SyslogExportRuleFull != null) {
            var fspec = this.SyslogExportRuleFull.AsFieldSpec(conf.Child("syslogExportRuleFull"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "syslogExportRuleFull" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> SyslogCertificateInfo? SyslogCertificateInfo
        // GraphQL -> syslogCertificateInfo: SyslogCertificateInfo (type)
        if (ec.Includes("syslogCertificateInfo",false))
        {
            if(this.SyslogCertificateInfo == null) {

                this.SyslogCertificateInfo = new SyslogCertificateInfo();
                this.SyslogCertificateInfo.ApplyExploratoryFieldSpec(ec.NewChild("syslogCertificateInfo"));

            } else {

                this.SyslogCertificateInfo.ApplyExploratoryFieldSpec(ec.NewChild("syslogCertificateInfo"));

            }
        }
        else if (this.SyslogCertificateInfo != null && ec.Excludes("syslogCertificateInfo",false))
        {
            this.SyslogCertificateInfo = null;
        }
        //      C# -> SyslogExportRuleFull? SyslogExportRuleFull
        // GraphQL -> syslogExportRuleFull: SyslogExportRuleFull (type)
        if (ec.Includes("syslogExportRuleFull",false))
        {
            if(this.SyslogExportRuleFull == null) {

                this.SyslogExportRuleFull = new SyslogExportRuleFull();
                this.SyslogExportRuleFull.ApplyExploratoryFieldSpec(ec.NewChild("syslogExportRuleFull"));

            } else {

                this.SyslogExportRuleFull.ApplyExploratoryFieldSpec(ec.NewChild("syslogExportRuleFull"));

            }
        }
        else if (this.SyslogExportRuleFull != null && ec.Excludes("syslogExportRuleFull",false))
        {
            this.SyslogExportRuleFull = null;
        }
    }


    #endregion

    } // class SyslogExportRuleSummary
    
    #endregion

    public static class ListSyslogExportRuleSummaryExtensions
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
            this List<SyslogExportRuleSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SyslogExportRuleSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SyslogExportRuleSummary> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SyslogExportRuleSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SyslogExportRuleSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types