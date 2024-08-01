// CheckGuestOsReply.cs
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
    #region CheckGuestOsReply
    public class CheckGuestOsReply: BaseType
    {
        #region members

        //      C# -> List<GuestOs>? SupportedOs
        // GraphQL -> supportedOs: [GuestOS!]! (enum)
        [JsonProperty("supportedOs")]
        public List<GuestOs>? SupportedOs { get; set; }

        //      C# -> System.Boolean? Success
        // GraphQL -> success: Boolean! (scalar)
        [JsonProperty("success")]
        public System.Boolean? Success { get; set; }

        //      C# -> List<CheckGuestOsResult>? ValidationResult
        // GraphQL -> validationResult: [CheckGuestOsResult!]! (type)
        [JsonProperty("validationResult")]
        public List<CheckGuestOsResult>? ValidationResult { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CheckGuestOsReply";
    }

    public CheckGuestOsReply Set(
        List<GuestOs>? SupportedOs = null,
        System.Boolean? Success = null,
        List<CheckGuestOsResult>? ValidationResult = null
    ) 
    {
        if ( SupportedOs != null ) {
            this.SupportedOs = SupportedOs;
        }
        if ( Success != null ) {
            this.Success = Success;
        }
        if ( ValidationResult != null ) {
            this.ValidationResult = ValidationResult;
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
        //      C# -> List<GuestOs>? SupportedOs
        // GraphQL -> supportedOs: [GuestOS!]! (enum)
        if (this.SupportedOs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "supportedOs\n" ;
            } else {
                s += ind + "supportedOs\n" ;
            }
        }
        //      C# -> System.Boolean? Success
        // GraphQL -> success: Boolean! (scalar)
        if (this.Success != null) {
            if (conf.Flat) {
                s += conf.Prefix + "success\n" ;
            } else {
                s += ind + "success\n" ;
            }
        }
        //      C# -> List<CheckGuestOsResult>? ValidationResult
        // GraphQL -> validationResult: [CheckGuestOsResult!]! (type)
        if (this.ValidationResult != null) {
            var fspec = this.ValidationResult.AsFieldSpec(conf.Child("validationResult"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "validationResult" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<GuestOs>? SupportedOs
        // GraphQL -> supportedOs: [GuestOS!]! (enum)
        if (ec.Includes("supportedOs",true))
        {
            if(this.SupportedOs == null) {

                this.SupportedOs = new List<GuestOs>();

            } else {


            }
        }
        else if (this.SupportedOs != null && ec.Excludes("supportedOs",true))
        {
            this.SupportedOs = null;
        }
        //      C# -> System.Boolean? Success
        // GraphQL -> success: Boolean! (scalar)
        if (ec.Includes("success",true))
        {
            if(this.Success == null) {

                this.Success = true;

            } else {


            }
        }
        else if (this.Success != null && ec.Excludes("success",true))
        {
            this.Success = null;
        }
        //      C# -> List<CheckGuestOsResult>? ValidationResult
        // GraphQL -> validationResult: [CheckGuestOsResult!]! (type)
        if (ec.Includes("validationResult",false))
        {
            if(this.ValidationResult == null) {

                this.ValidationResult = new List<CheckGuestOsResult>();
                this.ValidationResult.ApplyExploratoryFieldSpec(ec.NewChild("validationResult"));

            } else {

                this.ValidationResult.ApplyExploratoryFieldSpec(ec.NewChild("validationResult"));

            }
        }
        else if (this.ValidationResult != null && ec.Excludes("validationResult",false))
        {
            this.ValidationResult = null;
        }
    }


    #endregion

    } // class CheckGuestOsReply
    
    #endregion

    public static class ListCheckGuestOsReplyExtensions
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
            this List<CheckGuestOsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CheckGuestOsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CheckGuestOsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CheckGuestOsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CheckGuestOsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types