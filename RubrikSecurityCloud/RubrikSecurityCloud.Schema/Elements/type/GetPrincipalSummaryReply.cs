// GetPrincipalSummaryReply.cs
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
    #region GetPrincipalSummaryReply
    public class GetPrincipalSummaryReply: BaseType
    {
        #region members

        //      C# -> System.Int32? SecretsCount
        // GraphQL -> secretsCount: Int! (scalar)
        [JsonProperty("secretsCount")]
        public System.Int32? SecretsCount { get; set; }

        //      C# -> Count? PrivilegedApiPermissionsCount
        // GraphQL -> privilegedApiPermissionsCount: Count (type)
        [JsonProperty("privilegedApiPermissionsCount")]
        public Count? PrivilegedApiPermissionsCount { get; set; }

        //      C# -> Count? PrivilegedMembersCount
        // GraphQL -> privilegedMembersCount: Count (type)
        [JsonProperty("privilegedMembersCount")]
        public Count? PrivilegedMembersCount { get; set; }

        //      C# -> Count? PrivilegedMembersofCount
        // GraphQL -> privilegedMembersofCount: Count (type)
        [JsonProperty("privilegedMembersofCount")]
        public Count? PrivilegedMembersofCount { get; set; }

        //      C# -> Count? PrivilegedRolesCount
        // GraphQL -> privilegedRolesCount: Count (type)
        [JsonProperty("privilegedRolesCount")]
        public Count? PrivilegedRolesCount { get; set; }

        //      C# -> PrincipalSummary? Summary
        // GraphQL -> summary: PrincipalSummary (type)
        [JsonProperty("summary")]
        public PrincipalSummary? Summary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetPrincipalSummaryReply";
    }

    public GetPrincipalSummaryReply Set(
        System.Int32? SecretsCount = null,
        Count? PrivilegedApiPermissionsCount = null,
        Count? PrivilegedMembersCount = null,
        Count? PrivilegedMembersofCount = null,
        Count? PrivilegedRolesCount = null,
        PrincipalSummary? Summary = null
    ) 
    {
        if ( SecretsCount != null ) {
            this.SecretsCount = SecretsCount;
        }
        if ( PrivilegedApiPermissionsCount != null ) {
            this.PrivilegedApiPermissionsCount = PrivilegedApiPermissionsCount;
        }
        if ( PrivilegedMembersCount != null ) {
            this.PrivilegedMembersCount = PrivilegedMembersCount;
        }
        if ( PrivilegedMembersofCount != null ) {
            this.PrivilegedMembersofCount = PrivilegedMembersofCount;
        }
        if ( PrivilegedRolesCount != null ) {
            this.PrivilegedRolesCount = PrivilegedRolesCount;
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
        //      C# -> System.Int32? SecretsCount
        // GraphQL -> secretsCount: Int! (scalar)
        if (this.SecretsCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "secretsCount\n" ;
            } else {
                s += ind + "secretsCount\n" ;
            }
        }
        //      C# -> Count? PrivilegedApiPermissionsCount
        // GraphQL -> privilegedApiPermissionsCount: Count (type)
        if (this.PrivilegedApiPermissionsCount != null) {
            var fspec = this.PrivilegedApiPermissionsCount.AsFieldSpec(conf.Child("privilegedApiPermissionsCount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "privilegedApiPermissionsCount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Count? PrivilegedMembersCount
        // GraphQL -> privilegedMembersCount: Count (type)
        if (this.PrivilegedMembersCount != null) {
            var fspec = this.PrivilegedMembersCount.AsFieldSpec(conf.Child("privilegedMembersCount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "privilegedMembersCount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Count? PrivilegedMembersofCount
        // GraphQL -> privilegedMembersofCount: Count (type)
        if (this.PrivilegedMembersofCount != null) {
            var fspec = this.PrivilegedMembersofCount.AsFieldSpec(conf.Child("privilegedMembersofCount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "privilegedMembersofCount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Count? PrivilegedRolesCount
        // GraphQL -> privilegedRolesCount: Count (type)
        if (this.PrivilegedRolesCount != null) {
            var fspec = this.PrivilegedRolesCount.AsFieldSpec(conf.Child("privilegedRolesCount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "privilegedRolesCount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PrincipalSummary? Summary
        // GraphQL -> summary: PrincipalSummary (type)
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
        //      C# -> System.Int32? SecretsCount
        // GraphQL -> secretsCount: Int! (scalar)
        if (ec.Includes("secretsCount",true))
        {
            if(this.SecretsCount == null) {

                this.SecretsCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.SecretsCount != null && ec.Excludes("secretsCount",true))
        {
            this.SecretsCount = null;
        }
        //      C# -> Count? PrivilegedApiPermissionsCount
        // GraphQL -> privilegedApiPermissionsCount: Count (type)
        if (ec.Includes("privilegedApiPermissionsCount",false))
        {
            if(this.PrivilegedApiPermissionsCount == null) {

                this.PrivilegedApiPermissionsCount = new Count();
                this.PrivilegedApiPermissionsCount.ApplyExploratoryFieldSpec(ec.NewChild("privilegedApiPermissionsCount"));

            } else {

                this.PrivilegedApiPermissionsCount.ApplyExploratoryFieldSpec(ec.NewChild("privilegedApiPermissionsCount"));

            }
        }
        else if (this.PrivilegedApiPermissionsCount != null && ec.Excludes("privilegedApiPermissionsCount",false))
        {
            this.PrivilegedApiPermissionsCount = null;
        }
        //      C# -> Count? PrivilegedMembersCount
        // GraphQL -> privilegedMembersCount: Count (type)
        if (ec.Includes("privilegedMembersCount",false))
        {
            if(this.PrivilegedMembersCount == null) {

                this.PrivilegedMembersCount = new Count();
                this.PrivilegedMembersCount.ApplyExploratoryFieldSpec(ec.NewChild("privilegedMembersCount"));

            } else {

                this.PrivilegedMembersCount.ApplyExploratoryFieldSpec(ec.NewChild("privilegedMembersCount"));

            }
        }
        else if (this.PrivilegedMembersCount != null && ec.Excludes("privilegedMembersCount",false))
        {
            this.PrivilegedMembersCount = null;
        }
        //      C# -> Count? PrivilegedMembersofCount
        // GraphQL -> privilegedMembersofCount: Count (type)
        if (ec.Includes("privilegedMembersofCount",false))
        {
            if(this.PrivilegedMembersofCount == null) {

                this.PrivilegedMembersofCount = new Count();
                this.PrivilegedMembersofCount.ApplyExploratoryFieldSpec(ec.NewChild("privilegedMembersofCount"));

            } else {

                this.PrivilegedMembersofCount.ApplyExploratoryFieldSpec(ec.NewChild("privilegedMembersofCount"));

            }
        }
        else if (this.PrivilegedMembersofCount != null && ec.Excludes("privilegedMembersofCount",false))
        {
            this.PrivilegedMembersofCount = null;
        }
        //      C# -> Count? PrivilegedRolesCount
        // GraphQL -> privilegedRolesCount: Count (type)
        if (ec.Includes("privilegedRolesCount",false))
        {
            if(this.PrivilegedRolesCount == null) {

                this.PrivilegedRolesCount = new Count();
                this.PrivilegedRolesCount.ApplyExploratoryFieldSpec(ec.NewChild("privilegedRolesCount"));

            } else {

                this.PrivilegedRolesCount.ApplyExploratoryFieldSpec(ec.NewChild("privilegedRolesCount"));

            }
        }
        else if (this.PrivilegedRolesCount != null && ec.Excludes("privilegedRolesCount",false))
        {
            this.PrivilegedRolesCount = null;
        }
        //      C# -> PrincipalSummary? Summary
        // GraphQL -> summary: PrincipalSummary (type)
        if (ec.Includes("summary",false))
        {
            if(this.Summary == null) {

                this.Summary = new PrincipalSummary();
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

    } // class GetPrincipalSummaryReply
    
    #endregion

    public static class ListGetPrincipalSummaryReplyExtensions
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
            this List<GetPrincipalSummaryReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetPrincipalSummaryReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetPrincipalSummaryReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetPrincipalSummaryReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetPrincipalSummaryReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types