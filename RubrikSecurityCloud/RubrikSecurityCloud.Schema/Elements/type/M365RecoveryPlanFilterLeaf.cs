// M365RecoveryPlanFilterLeaf.cs
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
    #region M365RecoveryPlanFilterLeaf
    public class M365RecoveryPlanFilterLeaf: BaseType
    {
        #region members

        //      C# -> M365ExchangeRecoveryPlanFilterLeaf? Exchange
        // GraphQL -> exchange: M365ExchangeRecoveryPlanFilterLeaf (type)
        [JsonProperty("exchange")]
        public M365ExchangeRecoveryPlanFilterLeaf? Exchange { get; set; }

        //      C# -> M365OneDriveRecoveryPlanFilterLeaf? Onedrive
        // GraphQL -> onedrive: M365OneDriveRecoveryPlanFilterLeaf (type)
        [JsonProperty("onedrive")]
        public M365OneDriveRecoveryPlanFilterLeaf? Onedrive { get; set; }

        //      C# -> M365SharePointRecoveryPlanFilterLeaf? Sharepoint
        // GraphQL -> sharepoint: M365SharePointRecoveryPlanFilterLeaf (type)
        [JsonProperty("sharepoint")]
        public M365SharePointRecoveryPlanFilterLeaf? Sharepoint { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "M365RecoveryPlanFilterLeaf";
    }

    public M365RecoveryPlanFilterLeaf Set(
        M365ExchangeRecoveryPlanFilterLeaf? Exchange = null,
        M365OneDriveRecoveryPlanFilterLeaf? Onedrive = null,
        M365SharePointRecoveryPlanFilterLeaf? Sharepoint = null
    ) 
    {
        if ( Exchange != null ) {
            this.Exchange = Exchange;
        }
        if ( Onedrive != null ) {
            this.Onedrive = Onedrive;
        }
        if ( Sharepoint != null ) {
            this.Sharepoint = Sharepoint;
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
        //      C# -> M365ExchangeRecoveryPlanFilterLeaf? Exchange
        // GraphQL -> exchange: M365ExchangeRecoveryPlanFilterLeaf (type)
        if (this.Exchange != null) {
            var fspec = this.Exchange.AsFieldSpec(conf.Child("exchange"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "exchange" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> M365OneDriveRecoveryPlanFilterLeaf? Onedrive
        // GraphQL -> onedrive: M365OneDriveRecoveryPlanFilterLeaf (type)
        if (this.Onedrive != null) {
            var fspec = this.Onedrive.AsFieldSpec(conf.Child("onedrive"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "onedrive" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> M365SharePointRecoveryPlanFilterLeaf? Sharepoint
        // GraphQL -> sharepoint: M365SharePointRecoveryPlanFilterLeaf (type)
        if (this.Sharepoint != null) {
            var fspec = this.Sharepoint.AsFieldSpec(conf.Child("sharepoint"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sharepoint" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> M365ExchangeRecoveryPlanFilterLeaf? Exchange
        // GraphQL -> exchange: M365ExchangeRecoveryPlanFilterLeaf (type)
        if (ec.Includes("exchange",false))
        {
            if(this.Exchange == null) {

                this.Exchange = new M365ExchangeRecoveryPlanFilterLeaf();
                this.Exchange.ApplyExploratoryFieldSpec(ec.NewChild("exchange"));

            } else {

                this.Exchange.ApplyExploratoryFieldSpec(ec.NewChild("exchange"));

            }
        }
        else if (this.Exchange != null && ec.Excludes("exchange",false))
        {
            this.Exchange = null;
        }
        //      C# -> M365OneDriveRecoveryPlanFilterLeaf? Onedrive
        // GraphQL -> onedrive: M365OneDriveRecoveryPlanFilterLeaf (type)
        if (ec.Includes("onedrive",false))
        {
            if(this.Onedrive == null) {

                this.Onedrive = new M365OneDriveRecoveryPlanFilterLeaf();
                this.Onedrive.ApplyExploratoryFieldSpec(ec.NewChild("onedrive"));

            } else {

                this.Onedrive.ApplyExploratoryFieldSpec(ec.NewChild("onedrive"));

            }
        }
        else if (this.Onedrive != null && ec.Excludes("onedrive",false))
        {
            this.Onedrive = null;
        }
        //      C# -> M365SharePointRecoveryPlanFilterLeaf? Sharepoint
        // GraphQL -> sharepoint: M365SharePointRecoveryPlanFilterLeaf (type)
        if (ec.Includes("sharepoint",false))
        {
            if(this.Sharepoint == null) {

                this.Sharepoint = new M365SharePointRecoveryPlanFilterLeaf();
                this.Sharepoint.ApplyExploratoryFieldSpec(ec.NewChild("sharepoint"));

            } else {

                this.Sharepoint.ApplyExploratoryFieldSpec(ec.NewChild("sharepoint"));

            }
        }
        else if (this.Sharepoint != null && ec.Excludes("sharepoint",false))
        {
            this.Sharepoint = null;
        }
    }


    #endregion

    } // class M365RecoveryPlanFilterLeaf
    
    #endregion

    public static class ListM365RecoveryPlanFilterLeafExtensions
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
            this List<M365RecoveryPlanFilterLeaf> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<M365RecoveryPlanFilterLeaf> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<M365RecoveryPlanFilterLeaf> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new M365RecoveryPlanFilterLeaf());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<M365RecoveryPlanFilterLeaf> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types