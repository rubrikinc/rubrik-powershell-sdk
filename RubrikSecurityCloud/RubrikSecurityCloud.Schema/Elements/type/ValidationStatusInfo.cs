// ValidationStatusInfo.cs
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
    #region ValidationStatusInfo
    public class ValidationStatusInfo: BaseType
    {
        #region members

        //      C# -> ValidationStatus? ValidationStatus
        // GraphQL -> validationStatus: ValidationStatus! (enum)
        [JsonProperty("validationStatus")]
        public ValidationStatus? ValidationStatus { get; set; }

        //      C# -> List<System.String>? FailureReasons
        // GraphQL -> failureReasons: [String!]! (scalar)
        [JsonProperty("failureReasons")]
        public List<System.String>? FailureReasons { get; set; }

        //      C# -> List<System.String>? WarningReasons
        // GraphQL -> warningReasons: [String!]! (scalar)
        [JsonProperty("warningReasons")]
        public List<System.String>? WarningReasons { get; set; }

        //      C# -> ResourceInfo? ResourceInfo
        // GraphQL -> resourceInfo: ResourceInfo (type)
        [JsonProperty("resourceInfo")]
        public ResourceInfo? ResourceInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ValidationStatusInfo";
    }

    public ValidationStatusInfo Set(
        ValidationStatus? ValidationStatus = null,
        List<System.String>? FailureReasons = null,
        List<System.String>? WarningReasons = null,
        ResourceInfo? ResourceInfo = null
    ) 
    {
        if ( ValidationStatus != null ) {
            this.ValidationStatus = ValidationStatus;
        }
        if ( FailureReasons != null ) {
            this.FailureReasons = FailureReasons;
        }
        if ( WarningReasons != null ) {
            this.WarningReasons = WarningReasons;
        }
        if ( ResourceInfo != null ) {
            this.ResourceInfo = ResourceInfo;
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
        //      C# -> ValidationStatus? ValidationStatus
        // GraphQL -> validationStatus: ValidationStatus! (enum)
        if (this.ValidationStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "validationStatus\n" ;
            } else {
                s += ind + "validationStatus\n" ;
            }
        }
        //      C# -> List<System.String>? FailureReasons
        // GraphQL -> failureReasons: [String!]! (scalar)
        if (this.FailureReasons != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failureReasons\n" ;
            } else {
                s += ind + "failureReasons\n" ;
            }
        }
        //      C# -> List<System.String>? WarningReasons
        // GraphQL -> warningReasons: [String!]! (scalar)
        if (this.WarningReasons != null) {
            if (conf.Flat) {
                s += conf.Prefix + "warningReasons\n" ;
            } else {
                s += ind + "warningReasons\n" ;
            }
        }
        //      C# -> ResourceInfo? ResourceInfo
        // GraphQL -> resourceInfo: ResourceInfo (type)
        if (this.ResourceInfo != null) {
            var fspec = this.ResourceInfo.AsFieldSpec(conf.Child("resourceInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "resourceInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ValidationStatus? ValidationStatus
        // GraphQL -> validationStatus: ValidationStatus! (enum)
        if (ec.Includes("validationStatus",true))
        {
            if(this.ValidationStatus == null) {

                this.ValidationStatus = new ValidationStatus();

            } else {


            }
        }
        else if (this.ValidationStatus != null && ec.Excludes("validationStatus",true))
        {
            this.ValidationStatus = null;
        }
        //      C# -> List<System.String>? FailureReasons
        // GraphQL -> failureReasons: [String!]! (scalar)
        if (ec.Includes("failureReasons",true))
        {
            if(this.FailureReasons == null) {

                this.FailureReasons = new List<System.String>();

            } else {


            }
        }
        else if (this.FailureReasons != null && ec.Excludes("failureReasons",true))
        {
            this.FailureReasons = null;
        }
        //      C# -> List<System.String>? WarningReasons
        // GraphQL -> warningReasons: [String!]! (scalar)
        if (ec.Includes("warningReasons",true))
        {
            if(this.WarningReasons == null) {

                this.WarningReasons = new List<System.String>();

            } else {


            }
        }
        else if (this.WarningReasons != null && ec.Excludes("warningReasons",true))
        {
            this.WarningReasons = null;
        }
        //      C# -> ResourceInfo? ResourceInfo
        // GraphQL -> resourceInfo: ResourceInfo (type)
        if (ec.Includes("resourceInfo",false))
        {
            if(this.ResourceInfo == null) {

                this.ResourceInfo = new ResourceInfo();
                this.ResourceInfo.ApplyExploratoryFieldSpec(ec.NewChild("resourceInfo"));

            } else {

                this.ResourceInfo.ApplyExploratoryFieldSpec(ec.NewChild("resourceInfo"));

            }
        }
        else if (this.ResourceInfo != null && ec.Excludes("resourceInfo",false))
        {
            this.ResourceInfo = null;
        }
    }


    #endregion

    } // class ValidationStatusInfo
    
    #endregion

    public static class ListValidationStatusInfoExtensions
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
            this List<ValidationStatusInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ValidationStatusInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ValidationStatusInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ValidationStatusInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ValidationStatusInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types