// RecoveryValidationFinding.cs
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
    #region RecoveryValidationFinding
    public class RecoveryValidationFinding: BaseType
    {
        #region members

        //      C# -> RecoveryCheck? Check
        // GraphQL -> check: RecoveryCheck! (enum)
        [JsonProperty("check")]
        public RecoveryCheck? Check { get; set; }

        //      C# -> RecoverySeverity? Severity
        // GraphQL -> severity: RecoverySeverity! (enum)
        [JsonProperty("severity")]
        public RecoverySeverity? Severity { get; set; }

        //      C# -> System.String? Detail
        // GraphQL -> detail: String! (scalar)
        [JsonProperty("detail")]
        public System.String? Detail { get; set; }

        //      C# -> System.String? Remediation
        // GraphQL -> remediation: String! (scalar)
        [JsonProperty("remediation")]
        public System.String? Remediation { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RecoveryValidationFinding";
    }

    public RecoveryValidationFinding Set(
        RecoveryCheck? Check = null,
        RecoverySeverity? Severity = null,
        System.String? Detail = null,
        System.String? Remediation = null
    ) 
    {
        if ( Check != null ) {
            this.Check = Check;
        }
        if ( Severity != null ) {
            this.Severity = Severity;
        }
        if ( Detail != null ) {
            this.Detail = Detail;
        }
        if ( Remediation != null ) {
            this.Remediation = Remediation;
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
        //      C# -> RecoveryCheck? Check
        // GraphQL -> check: RecoveryCheck! (enum)
        if (this.Check != null) {
            if (conf.Flat) {
                s += conf.Prefix + "check\n" ;
            } else {
                s += ind + "check\n" ;
            }
        }
        //      C# -> RecoverySeverity? Severity
        // GraphQL -> severity: RecoverySeverity! (enum)
        if (this.Severity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "severity\n" ;
            } else {
                s += ind + "severity\n" ;
            }
        }
        //      C# -> System.String? Detail
        // GraphQL -> detail: String! (scalar)
        if (this.Detail != null) {
            if (conf.Flat) {
                s += conf.Prefix + "detail\n" ;
            } else {
                s += ind + "detail\n" ;
            }
        }
        //      C# -> System.String? Remediation
        // GraphQL -> remediation: String! (scalar)
        if (this.Remediation != null) {
            if (conf.Flat) {
                s += conf.Prefix + "remediation\n" ;
            } else {
                s += ind + "remediation\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> RecoveryCheck? Check
        // GraphQL -> check: RecoveryCheck! (enum)
        if (ec.Includes("check",true))
        {
            if(this.Check == null) {

                this.Check = new RecoveryCheck();

            } else {


            }
        }
        else if (this.Check != null && ec.Excludes("check",true))
        {
            this.Check = null;
        }
        //      C# -> RecoverySeverity? Severity
        // GraphQL -> severity: RecoverySeverity! (enum)
        if (ec.Includes("severity",true))
        {
            if(this.Severity == null) {

                this.Severity = new RecoverySeverity();

            } else {


            }
        }
        else if (this.Severity != null && ec.Excludes("severity",true))
        {
            this.Severity = null;
        }
        //      C# -> System.String? Detail
        // GraphQL -> detail: String! (scalar)
        if (ec.Includes("detail",true))
        {
            if(this.Detail == null) {

                this.Detail = "FETCH";

            } else {


            }
        }
        else if (this.Detail != null && ec.Excludes("detail",true))
        {
            this.Detail = null;
        }
        //      C# -> System.String? Remediation
        // GraphQL -> remediation: String! (scalar)
        if (ec.Includes("remediation",true))
        {
            if(this.Remediation == null) {

                this.Remediation = "FETCH";

            } else {


            }
        }
        else if (this.Remediation != null && ec.Excludes("remediation",true))
        {
            this.Remediation = null;
        }
    }


    #endregion

    } // class RecoveryValidationFinding
    
    #endregion

    public static class ListRecoveryValidationFindingExtensions
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
            this List<RecoveryValidationFinding> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RecoveryValidationFinding> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RecoveryValidationFinding> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RecoveryValidationFinding());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RecoveryValidationFinding> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types