// SimulationResult.cs
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
    #region SimulationResult
    public class SimulationResult: BaseType
    {
        #region members

        //      C# -> System.String? Action
        // GraphQL -> action: String! (scalar)
        [JsonProperty("action")]
        public System.String? Action { get; set; }

        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        [JsonProperty("errorMessage")]
        public System.String? ErrorMessage { get; set; }

        //      C# -> System.Boolean? IsAllowed
        // GraphQL -> isAllowed: Boolean! (scalar)
        [JsonProperty("isAllowed")]
        public System.Boolean? IsAllowed { get; set; }

        //      C# -> System.Boolean? IsDeniedByPermissionBoundaries
        // GraphQL -> isDeniedByPermissionBoundaries: Boolean! (scalar)
        [JsonProperty("isDeniedByPermissionBoundaries")]
        public System.Boolean? IsDeniedByPermissionBoundaries { get; set; }

        //      C# -> System.Boolean? IsDeniedByScp
        // GraphQL -> isDeniedByScp: Boolean! (scalar)
        [JsonProperty("isDeniedByScp")]
        public System.Boolean? IsDeniedByScp { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SimulationResult";
    }

    public SimulationResult Set(
        System.String? Action = null,
        System.String? ErrorMessage = null,
        System.Boolean? IsAllowed = null,
        System.Boolean? IsDeniedByPermissionBoundaries = null,
        System.Boolean? IsDeniedByScp = null
    ) 
    {
        if ( Action != null ) {
            this.Action = Action;
        }
        if ( ErrorMessage != null ) {
            this.ErrorMessage = ErrorMessage;
        }
        if ( IsAllowed != null ) {
            this.IsAllowed = IsAllowed;
        }
        if ( IsDeniedByPermissionBoundaries != null ) {
            this.IsDeniedByPermissionBoundaries = IsDeniedByPermissionBoundaries;
        }
        if ( IsDeniedByScp != null ) {
            this.IsDeniedByScp = IsDeniedByScp;
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
        //      C# -> System.String? Action
        // GraphQL -> action: String! (scalar)
        if (this.Action != null) {
            if (conf.Flat) {
                s += conf.Prefix + "action\n" ;
            } else {
                s += ind + "action\n" ;
            }
        }
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        if (this.ErrorMessage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "errorMessage\n" ;
            } else {
                s += ind + "errorMessage\n" ;
            }
        }
        //      C# -> System.Boolean? IsAllowed
        // GraphQL -> isAllowed: Boolean! (scalar)
        if (this.IsAllowed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAllowed\n" ;
            } else {
                s += ind + "isAllowed\n" ;
            }
        }
        //      C# -> System.Boolean? IsDeniedByPermissionBoundaries
        // GraphQL -> isDeniedByPermissionBoundaries: Boolean! (scalar)
        if (this.IsDeniedByPermissionBoundaries != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDeniedByPermissionBoundaries\n" ;
            } else {
                s += ind + "isDeniedByPermissionBoundaries\n" ;
            }
        }
        //      C# -> System.Boolean? IsDeniedByScp
        // GraphQL -> isDeniedByScp: Boolean! (scalar)
        if (this.IsDeniedByScp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDeniedByScp\n" ;
            } else {
                s += ind + "isDeniedByScp\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? Action
        // GraphQL -> action: String! (scalar)
        if (ec.Includes("action",true))
        {
            if(this.Action == null) {

                this.Action = "FETCH";

            } else {


            }
        }
        else if (this.Action != null && ec.Excludes("action",true))
        {
            this.Action = null;
        }
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        if (ec.Includes("errorMessage",true))
        {
            if(this.ErrorMessage == null) {

                this.ErrorMessage = "FETCH";

            } else {


            }
        }
        else if (this.ErrorMessage != null && ec.Excludes("errorMessage",true))
        {
            this.ErrorMessage = null;
        }
        //      C# -> System.Boolean? IsAllowed
        // GraphQL -> isAllowed: Boolean! (scalar)
        if (ec.Includes("isAllowed",true))
        {
            if(this.IsAllowed == null) {

                this.IsAllowed = true;

            } else {


            }
        }
        else if (this.IsAllowed != null && ec.Excludes("isAllowed",true))
        {
            this.IsAllowed = null;
        }
        //      C# -> System.Boolean? IsDeniedByPermissionBoundaries
        // GraphQL -> isDeniedByPermissionBoundaries: Boolean! (scalar)
        if (ec.Includes("isDeniedByPermissionBoundaries",true))
        {
            if(this.IsDeniedByPermissionBoundaries == null) {

                this.IsDeniedByPermissionBoundaries = true;

            } else {


            }
        }
        else if (this.IsDeniedByPermissionBoundaries != null && ec.Excludes("isDeniedByPermissionBoundaries",true))
        {
            this.IsDeniedByPermissionBoundaries = null;
        }
        //      C# -> System.Boolean? IsDeniedByScp
        // GraphQL -> isDeniedByScp: Boolean! (scalar)
        if (ec.Includes("isDeniedByScp",true))
        {
            if(this.IsDeniedByScp == null) {

                this.IsDeniedByScp = true;

            } else {


            }
        }
        else if (this.IsDeniedByScp != null && ec.Excludes("isDeniedByScp",true))
        {
            this.IsDeniedByScp = null;
        }
    }


    #endregion

    } // class SimulationResult
    
    #endregion

    public static class ListSimulationResultExtensions
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
            this List<SimulationResult> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SimulationResult> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SimulationResult> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SimulationResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SimulationResult> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types