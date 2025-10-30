// ValidatePermissionsForRoleReply.cs
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
    #region ValidatePermissionsForRoleReply
    public class ValidatePermissionsForRoleReply: BaseType
    {
        #region members

        //      C# -> RoleType? Role
        // GraphQL -> role: RoleType! (enum)
        [JsonProperty("role")]
        public RoleType? Role { get; set; }

        //      C# -> SuccessStatus? Status
        // GraphQL -> status: SuccessStatus! (enum)
        [JsonProperty("status")]
        public SuccessStatus? Status { get; set; }

        //      C# -> System.Int32? NumMissingPermissions
        // GraphQL -> numMissingPermissions: Int! (scalar)
        [JsonProperty("numMissingPermissions")]
        public System.Int32? NumMissingPermissions { get; set; }

        //      C# -> System.String? RoleArn
        // GraphQL -> roleArn: String! (scalar)
        [JsonProperty("roleArn")]
        public System.String? RoleArn { get; set; }

        //      C# -> List<SimulationResult>? ActionResults
        // GraphQL -> actionResults: [SimulationResult!]! (type)
        [JsonProperty("actionResults")]
        public List<SimulationResult>? ActionResults { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ValidatePermissionsForRoleReply";
    }

    public ValidatePermissionsForRoleReply Set(
        RoleType? Role = null,
        SuccessStatus? Status = null,
        System.Int32? NumMissingPermissions = null,
        System.String? RoleArn = null,
        List<SimulationResult>? ActionResults = null
    ) 
    {
        if ( Role != null ) {
            this.Role = Role;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( NumMissingPermissions != null ) {
            this.NumMissingPermissions = NumMissingPermissions;
        }
        if ( RoleArn != null ) {
            this.RoleArn = RoleArn;
        }
        if ( ActionResults != null ) {
            this.ActionResults = ActionResults;
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
        //      C# -> RoleType? Role
        // GraphQL -> role: RoleType! (enum)
        if (this.Role != null) {
            if (conf.Flat) {
                s += conf.Prefix + "role\n" ;
            } else {
                s += ind + "role\n" ;
            }
        }
        //      C# -> SuccessStatus? Status
        // GraphQL -> status: SuccessStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.Int32? NumMissingPermissions
        // GraphQL -> numMissingPermissions: Int! (scalar)
        if (this.NumMissingPermissions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numMissingPermissions\n" ;
            } else {
                s += ind + "numMissingPermissions\n" ;
            }
        }
        //      C# -> System.String? RoleArn
        // GraphQL -> roleArn: String! (scalar)
        if (this.RoleArn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "roleArn\n" ;
            } else {
                s += ind + "roleArn\n" ;
            }
        }
        //      C# -> List<SimulationResult>? ActionResults
        // GraphQL -> actionResults: [SimulationResult!]! (type)
        if (this.ActionResults != null) {
            var fspec = this.ActionResults.AsFieldSpec(conf.Child("actionResults"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "actionResults" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> RoleType? Role
        // GraphQL -> role: RoleType! (enum)
        if (ec.Includes("role",true))
        {
            if(this.Role == null) {

                this.Role = new RoleType();

            } else {


            }
        }
        else if (this.Role != null && ec.Excludes("role",true))
        {
            this.Role = null;
        }
        //      C# -> SuccessStatus? Status
        // GraphQL -> status: SuccessStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new SuccessStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.Int32? NumMissingPermissions
        // GraphQL -> numMissingPermissions: Int! (scalar)
        if (ec.Includes("numMissingPermissions",true))
        {
            if(this.NumMissingPermissions == null) {

                this.NumMissingPermissions = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumMissingPermissions != null && ec.Excludes("numMissingPermissions",true))
        {
            this.NumMissingPermissions = null;
        }
        //      C# -> System.String? RoleArn
        // GraphQL -> roleArn: String! (scalar)
        if (ec.Includes("roleArn",true))
        {
            if(this.RoleArn == null) {

                this.RoleArn = "FETCH";

            } else {


            }
        }
        else if (this.RoleArn != null && ec.Excludes("roleArn",true))
        {
            this.RoleArn = null;
        }
        //      C# -> List<SimulationResult>? ActionResults
        // GraphQL -> actionResults: [SimulationResult!]! (type)
        if (ec.Includes("actionResults",false))
        {
            if(this.ActionResults == null) {

                this.ActionResults = new List<SimulationResult>();
                this.ActionResults.ApplyExploratoryFieldSpec(ec.NewChild("actionResults"));

            } else {

                this.ActionResults.ApplyExploratoryFieldSpec(ec.NewChild("actionResults"));

            }
        }
        else if (this.ActionResults != null && ec.Excludes("actionResults",false))
        {
            this.ActionResults = null;
        }
    }


    #endregion

    } // class ValidatePermissionsForRoleReply
    
    #endregion

    public static class ListValidatePermissionsForRoleReplyExtensions
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
            this List<ValidatePermissionsForRoleReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ValidatePermissionsForRoleReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ValidatePermissionsForRoleReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ValidatePermissionsForRoleReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ValidatePermissionsForRoleReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types