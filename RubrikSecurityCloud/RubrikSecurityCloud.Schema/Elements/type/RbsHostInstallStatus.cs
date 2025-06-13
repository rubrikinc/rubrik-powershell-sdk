// RbsHostInstallStatus.cs
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
    #region RbsHostInstallStatus
    public class RbsHostInstallStatus: BaseType
    {
        #region members

        //      C# -> System.String? Error
        // GraphQL -> error: String (scalar)
        [JsonProperty("error")]
        public System.String? Error { get; set; }

        //      C# -> HostDetail? HostDetail
        // GraphQL -> hostDetail: HostDetail (type)
        [JsonProperty("hostDetail")]
        public HostDetail? HostDetail { get; set; }

        //      C# -> RbsHostSummary? Summary
        // GraphQL -> summary: RbsHostSummary (type)
        [JsonProperty("summary")]
        public RbsHostSummary? Summary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RbsHostInstallStatus";
    }

    public RbsHostInstallStatus Set(
        System.String? Error = null,
        HostDetail? HostDetail = null,
        RbsHostSummary? Summary = null
    ) 
    {
        if ( Error != null ) {
            this.Error = Error;
        }
        if ( HostDetail != null ) {
            this.HostDetail = HostDetail;
        }
        if ( Summary != null ) {
            this.Summary = Summary;
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
        //      C# -> System.String? Error
        // GraphQL -> error: String (scalar)
        if (this.Error != null) {
            if (conf.Flat) {
                s += conf.Prefix + "error\n" ;
            } else {
                s += ind + "error\n" ;
            }
        }
        //      C# -> HostDetail? HostDetail
        // GraphQL -> hostDetail: HostDetail (type)
        if (this.HostDetail != null) {
            var fspec = this.HostDetail.AsFieldSpec(conf.Child("hostDetail"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hostDetail" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RbsHostSummary? Summary
        // GraphQL -> summary: RbsHostSummary (type)
        if (this.Summary != null) {
            var fspec = this.Summary.AsFieldSpec(conf.Child("summary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "summary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? Error
        // GraphQL -> error: String (scalar)
        if (ec.Includes("error",true))
        {
            if(this.Error == null) {

                this.Error = "FETCH";

            } else {


            }
        }
        else if (this.Error != null && ec.Excludes("error",true))
        {
            this.Error = null;
        }
        //      C# -> HostDetail? HostDetail
        // GraphQL -> hostDetail: HostDetail (type)
        if (ec.Includes("hostDetail",false))
        {
            if(this.HostDetail == null) {

                this.HostDetail = new HostDetail();
                this.HostDetail.ApplyExploratoryFieldSpec(ec.NewChild("hostDetail"));

            } else {

                this.HostDetail.ApplyExploratoryFieldSpec(ec.NewChild("hostDetail"));

            }
        }
        else if (this.HostDetail != null && ec.Excludes("hostDetail",false))
        {
            this.HostDetail = null;
        }
        //      C# -> RbsHostSummary? Summary
        // GraphQL -> summary: RbsHostSummary (type)
        if (ec.Includes("summary",false))
        {
            if(this.Summary == null) {

                this.Summary = new RbsHostSummary();
                this.Summary.ApplyExploratoryFieldSpec(ec.NewChild("summary"));

            } else {

                this.Summary.ApplyExploratoryFieldSpec(ec.NewChild("summary"));

            }
        }
        else if (this.Summary != null && ec.Excludes("summary",false))
        {
            this.Summary = null;
        }
    }


    #endregion

    } // class RbsHostInstallStatus
    
    #endregion

    public static class ListRbsHostInstallStatusExtensions
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
            this List<RbsHostInstallStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RbsHostInstallStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RbsHostInstallStatus> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RbsHostInstallStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RbsHostInstallStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types