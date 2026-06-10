// AzureAdEmAssignment.cs
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
    #region AzureAdEmAssignment
    public class AzureAdEmAssignment: BaseType
    {
        #region members

        //      C# -> EmSubjectType? PrincipalType
        // GraphQL -> principalType: EmSubjectType! (enum)
        [JsonProperty("principalType")]
        public EmSubjectType? PrincipalType { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> DateTime? EndDate
        // GraphQL -> endDate: DateTime (scalar)
        [JsonProperty("endDate")]
        public DateTime? EndDate { get; set; }

        //      C# -> DateTime? StartDate
        // GraphQL -> startDate: DateTime (scalar)
        [JsonProperty("startDate")]
        public DateTime? StartDate { get; set; }

        //      C# -> System.String? UserPrincipalName
        // GraphQL -> userPrincipalName: String! (scalar)
        [JsonProperty("userPrincipalName")]
        public System.String? UserPrincipalName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdEmAssignment";
    }

    public AzureAdEmAssignment Set(
        EmSubjectType? PrincipalType = null,
        System.String? DisplayName = null,
        DateTime? EndDate = null,
        DateTime? StartDate = null,
        System.String? UserPrincipalName = null
    ) 
    {
        if ( PrincipalType != null ) {
            this.PrincipalType = PrincipalType;
        }
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( EndDate != null ) {
            this.EndDate = EndDate;
        }
        if ( StartDate != null ) {
            this.StartDate = StartDate;
        }
        if ( UserPrincipalName != null ) {
            this.UserPrincipalName = UserPrincipalName;
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
        //      C# -> EmSubjectType? PrincipalType
        // GraphQL -> principalType: EmSubjectType! (enum)
        if (this.PrincipalType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "principalType\n" ;
            } else {
                s += ind + "principalType\n" ;
            }
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "displayName\n" ;
            } else {
                s += ind + "displayName\n" ;
            }
        }
        //      C# -> DateTime? EndDate
        // GraphQL -> endDate: DateTime (scalar)
        if (this.EndDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endDate\n" ;
            } else {
                s += ind + "endDate\n" ;
            }
        }
        //      C# -> DateTime? StartDate
        // GraphQL -> startDate: DateTime (scalar)
        if (this.StartDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startDate\n" ;
            } else {
                s += ind + "startDate\n" ;
            }
        }
        //      C# -> System.String? UserPrincipalName
        // GraphQL -> userPrincipalName: String! (scalar)
        if (this.UserPrincipalName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userPrincipalName\n" ;
            } else {
                s += ind + "userPrincipalName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> EmSubjectType? PrincipalType
        // GraphQL -> principalType: EmSubjectType! (enum)
        if (ec.Includes("principalType",true))
        {
            if(this.PrincipalType == null) {

                this.PrincipalType = new EmSubjectType();

            } else {


            }
        }
        else if (this.PrincipalType != null && ec.Excludes("principalType",true))
        {
            this.PrincipalType = null;
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (ec.Includes("displayName",true))
        {
            if(this.DisplayName == null) {

                this.DisplayName = "FETCH";

            } else {


            }
        }
        else if (this.DisplayName != null && ec.Excludes("displayName",true))
        {
            this.DisplayName = null;
        }
        //      C# -> DateTime? EndDate
        // GraphQL -> endDate: DateTime (scalar)
        if (ec.Includes("endDate",true))
        {
            if(this.EndDate == null) {

                this.EndDate = new DateTime();

            } else {


            }
        }
        else if (this.EndDate != null && ec.Excludes("endDate",true))
        {
            this.EndDate = null;
        }
        //      C# -> DateTime? StartDate
        // GraphQL -> startDate: DateTime (scalar)
        if (ec.Includes("startDate",true))
        {
            if(this.StartDate == null) {

                this.StartDate = new DateTime();

            } else {


            }
        }
        else if (this.StartDate != null && ec.Excludes("startDate",true))
        {
            this.StartDate = null;
        }
        //      C# -> System.String? UserPrincipalName
        // GraphQL -> userPrincipalName: String! (scalar)
        if (ec.Includes("userPrincipalName",true))
        {
            if(this.UserPrincipalName == null) {

                this.UserPrincipalName = "FETCH";

            } else {


            }
        }
        else if (this.UserPrincipalName != null && ec.Excludes("userPrincipalName",true))
        {
            this.UserPrincipalName = null;
        }
    }


    #endregion

    } // class AzureAdEmAssignment
    
    #endregion

    public static class ListAzureAdEmAssignmentExtensions
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
            this List<AzureAdEmAssignment> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureAdEmAssignment> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureAdEmAssignment> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAdEmAssignment());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureAdEmAssignment> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types