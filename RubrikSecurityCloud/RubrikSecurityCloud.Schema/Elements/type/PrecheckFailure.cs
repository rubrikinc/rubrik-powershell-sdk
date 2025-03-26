// PrecheckFailure.cs
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
    #region PrecheckFailure
    public class PrecheckFailure: BaseType
    {
        #region members

        //      C# -> PrecheckIdentifier? PrecheckIdentifier
        // GraphQL -> precheckIdentifier: PrecheckIdentifier! (enum)
        [JsonProperty("precheckIdentifier")]
        public PrecheckIdentifier? PrecheckIdentifier { get; set; }

        //      C# -> System.String? Cause
        // GraphQL -> cause: String! (scalar)
        [JsonProperty("cause")]
        public System.String? Cause { get; set; }

        //      C# -> System.String? PrecheckName
        // GraphQL -> precheckName: String! (scalar)
        [JsonProperty("precheckName")]
        public System.String? PrecheckName { get; set; }

        //      C# -> System.String? Remedy
        // GraphQL -> remedy: String! (scalar)
        [JsonProperty("remedy")]
        public System.String? Remedy { get; set; }

        //      C# -> System.Boolean? UpgradeBlocker
        // GraphQL -> upgradeBlocker: Boolean! (scalar)
        [JsonProperty("upgradeBlocker")]
        public System.Boolean? UpgradeBlocker { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PrecheckFailure";
    }

    public PrecheckFailure Set(
        PrecheckIdentifier? PrecheckIdentifier = null,
        System.String? Cause = null,
        System.String? PrecheckName = null,
        System.String? Remedy = null,
        System.Boolean? UpgradeBlocker = null
    ) 
    {
        if ( PrecheckIdentifier != null ) {
            this.PrecheckIdentifier = PrecheckIdentifier;
        }
        if ( Cause != null ) {
            this.Cause = Cause;
        }
        if ( PrecheckName != null ) {
            this.PrecheckName = PrecheckName;
        }
        if ( Remedy != null ) {
            this.Remedy = Remedy;
        }
        if ( UpgradeBlocker != null ) {
            this.UpgradeBlocker = UpgradeBlocker;
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
        //      C# -> PrecheckIdentifier? PrecheckIdentifier
        // GraphQL -> precheckIdentifier: PrecheckIdentifier! (enum)
        if (this.PrecheckIdentifier != null) {
            if (conf.Flat) {
                s += conf.Prefix + "precheckIdentifier\n" ;
            } else {
                s += ind + "precheckIdentifier\n" ;
            }
        }
        //      C# -> System.String? Cause
        // GraphQL -> cause: String! (scalar)
        if (this.Cause != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cause\n" ;
            } else {
                s += ind + "cause\n" ;
            }
        }
        //      C# -> System.String? PrecheckName
        // GraphQL -> precheckName: String! (scalar)
        if (this.PrecheckName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "precheckName\n" ;
            } else {
                s += ind + "precheckName\n" ;
            }
        }
        //      C# -> System.String? Remedy
        // GraphQL -> remedy: String! (scalar)
        if (this.Remedy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "remedy\n" ;
            } else {
                s += ind + "remedy\n" ;
            }
        }
        //      C# -> System.Boolean? UpgradeBlocker
        // GraphQL -> upgradeBlocker: Boolean! (scalar)
        if (this.UpgradeBlocker != null) {
            if (conf.Flat) {
                s += conf.Prefix + "upgradeBlocker\n" ;
            } else {
                s += ind + "upgradeBlocker\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> PrecheckIdentifier? PrecheckIdentifier
        // GraphQL -> precheckIdentifier: PrecheckIdentifier! (enum)
        if (ec.Includes("precheckIdentifier",true))
        {
            if(this.PrecheckIdentifier == null) {

                this.PrecheckIdentifier = new PrecheckIdentifier();

            } else {


            }
        }
        else if (this.PrecheckIdentifier != null && ec.Excludes("precheckIdentifier",true))
        {
            this.PrecheckIdentifier = null;
        }
        //      C# -> System.String? Cause
        // GraphQL -> cause: String! (scalar)
        if (ec.Includes("cause",true))
        {
            if(this.Cause == null) {

                this.Cause = "FETCH";

            } else {


            }
        }
        else if (this.Cause != null && ec.Excludes("cause",true))
        {
            this.Cause = null;
        }
        //      C# -> System.String? PrecheckName
        // GraphQL -> precheckName: String! (scalar)
        if (ec.Includes("precheckName",true))
        {
            if(this.PrecheckName == null) {

                this.PrecheckName = "FETCH";

            } else {


            }
        }
        else if (this.PrecheckName != null && ec.Excludes("precheckName",true))
        {
            this.PrecheckName = null;
        }
        //      C# -> System.String? Remedy
        // GraphQL -> remedy: String! (scalar)
        if (ec.Includes("remedy",true))
        {
            if(this.Remedy == null) {

                this.Remedy = "FETCH";

            } else {


            }
        }
        else if (this.Remedy != null && ec.Excludes("remedy",true))
        {
            this.Remedy = null;
        }
        //      C# -> System.Boolean? UpgradeBlocker
        // GraphQL -> upgradeBlocker: Boolean! (scalar)
        if (ec.Includes("upgradeBlocker",true))
        {
            if(this.UpgradeBlocker == null) {

                this.UpgradeBlocker = true;

            } else {


            }
        }
        else if (this.UpgradeBlocker != null && ec.Excludes("upgradeBlocker",true))
        {
            this.UpgradeBlocker = null;
        }
    }


    #endregion

    } // class PrecheckFailure
    
    #endregion

    public static class ListPrecheckFailureExtensions
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
            this List<PrecheckFailure> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PrecheckFailure> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PrecheckFailure> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PrecheckFailure());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PrecheckFailure> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types