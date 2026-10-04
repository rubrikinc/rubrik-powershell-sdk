// SupportPortalRole.cs
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
    #region SupportPortalRole
    public class SupportPortalRole: BaseType
    {
        #region members

        //      C# -> System.Boolean? CanCreateCases
        // GraphQL -> canCreateCases: Boolean! (scalar)
        [JsonProperty("canCreateCases")]
        public System.Boolean? CanCreateCases { get; set; }

        //      C# -> System.Boolean? HasEscalateCasesPermission
        // GraphQL -> hasEscalateCasesPermission: Boolean! (scalar)
        [JsonProperty("hasEscalateCasesPermission")]
        public System.Boolean? HasEscalateCasesPermission { get; set; }

        //      C# -> System.Boolean? HasUpdateCaseStatusPermission
        // GraphQL -> hasUpdateCaseStatusPermission: Boolean! (scalar)
        [JsonProperty("hasUpdateCaseStatusPermission")]
        public System.Boolean? HasUpdateCaseStatusPermission { get; set; }

        //      C# -> System.Boolean? HasUploadFilesPermission
        // GraphQL -> hasUploadFilesPermission: Boolean! (scalar)
        [JsonProperty("hasUploadFilesPermission")]
        public System.Boolean? HasUploadFilesPermission { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SupportPortalRole";
    }

    public SupportPortalRole Set(
        System.Boolean? CanCreateCases = null,
        System.Boolean? HasEscalateCasesPermission = null,
        System.Boolean? HasUpdateCaseStatusPermission = null,
        System.Boolean? HasUploadFilesPermission = null
    ) 
    {
        if ( CanCreateCases != null ) {
            this.CanCreateCases = CanCreateCases;
        }
        if ( HasEscalateCasesPermission != null ) {
            this.HasEscalateCasesPermission = HasEscalateCasesPermission;
        }
        if ( HasUpdateCaseStatusPermission != null ) {
            this.HasUpdateCaseStatusPermission = HasUpdateCaseStatusPermission;
        }
        if ( HasUploadFilesPermission != null ) {
            this.HasUploadFilesPermission = HasUploadFilesPermission;
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
        //      C# -> System.Boolean? CanCreateCases
        // GraphQL -> canCreateCases: Boolean! (scalar)
        if (this.CanCreateCases != null) {
            if (conf.Flat) {
                s += conf.Prefix + "canCreateCases\n" ;
            } else {
                s += ind + "canCreateCases\n" ;
            }
        }
        //      C# -> System.Boolean? HasEscalateCasesPermission
        // GraphQL -> hasEscalateCasesPermission: Boolean! (scalar)
        if (this.HasEscalateCasesPermission != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasEscalateCasesPermission\n" ;
            } else {
                s += ind + "hasEscalateCasesPermission\n" ;
            }
        }
        //      C# -> System.Boolean? HasUpdateCaseStatusPermission
        // GraphQL -> hasUpdateCaseStatusPermission: Boolean! (scalar)
        if (this.HasUpdateCaseStatusPermission != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasUpdateCaseStatusPermission\n" ;
            } else {
                s += ind + "hasUpdateCaseStatusPermission\n" ;
            }
        }
        //      C# -> System.Boolean? HasUploadFilesPermission
        // GraphQL -> hasUploadFilesPermission: Boolean! (scalar)
        if (this.HasUploadFilesPermission != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasUploadFilesPermission\n" ;
            } else {
                s += ind + "hasUploadFilesPermission\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? CanCreateCases
        // GraphQL -> canCreateCases: Boolean! (scalar)
        if (ec.Includes("canCreateCases",true))
        {
            if(this.CanCreateCases == null) {

                this.CanCreateCases = true;

            } else {


            }
        }
        else if (this.CanCreateCases != null && ec.Excludes("canCreateCases",true))
        {
            this.CanCreateCases = null;
        }
        //      C# -> System.Boolean? HasEscalateCasesPermission
        // GraphQL -> hasEscalateCasesPermission: Boolean! (scalar)
        if (ec.Includes("hasEscalateCasesPermission",true))
        {
            if(this.HasEscalateCasesPermission == null) {

                this.HasEscalateCasesPermission = true;

            } else {


            }
        }
        else if (this.HasEscalateCasesPermission != null && ec.Excludes("hasEscalateCasesPermission",true))
        {
            this.HasEscalateCasesPermission = null;
        }
        //      C# -> System.Boolean? HasUpdateCaseStatusPermission
        // GraphQL -> hasUpdateCaseStatusPermission: Boolean! (scalar)
        if (ec.Includes("hasUpdateCaseStatusPermission",true))
        {
            if(this.HasUpdateCaseStatusPermission == null) {

                this.HasUpdateCaseStatusPermission = true;

            } else {


            }
        }
        else if (this.HasUpdateCaseStatusPermission != null && ec.Excludes("hasUpdateCaseStatusPermission",true))
        {
            this.HasUpdateCaseStatusPermission = null;
        }
        //      C# -> System.Boolean? HasUploadFilesPermission
        // GraphQL -> hasUploadFilesPermission: Boolean! (scalar)
        if (ec.Includes("hasUploadFilesPermission",true))
        {
            if(this.HasUploadFilesPermission == null) {

                this.HasUploadFilesPermission = true;

            } else {


            }
        }
        else if (this.HasUploadFilesPermission != null && ec.Excludes("hasUploadFilesPermission",true))
        {
            this.HasUploadFilesPermission = null;
        }
    }


    #endregion

    } // class SupportPortalRole
    
    #endregion

    public static class ListSupportPortalRoleExtensions
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
            this List<SupportPortalRole> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SupportPortalRole> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SupportPortalRole> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SupportPortalRole());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SupportPortalRole> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types