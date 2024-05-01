// O365Consumption.cs
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
    #region O365Consumption
    public class O365Consumption: BaseType
    {
        #region members

        //      C# -> LicenseConsumptionType? Consumption
        // GraphQL -> consumption: LicenseConsumptionType (type)
        [JsonProperty("consumption")]
        public LicenseConsumptionType? Consumption { get; set; }

        //      C# -> List<MultiTenancyConsumptionType>? ConsumptionPerMspOrg
        // GraphQL -> consumptionPerMspOrg: [MultiTenancyConsumptionType!]! (type)
        [JsonProperty("consumptionPerMspOrg")]
        public List<MultiTenancyConsumptionType>? ConsumptionPerMspOrg { get; set; }

        //      C# -> List<PerWorkloadConsumptionType>? ConsumptionPerWorkloadType
        // GraphQL -> consumptionPerWorkloadType: [PerWorkloadConsumptionType!]! (type)
        [JsonProperty("consumptionPerWorkloadType")]
        public List<PerWorkloadConsumptionType>? ConsumptionPerWorkloadType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365Consumption";
    }

    public O365Consumption Set(
        LicenseConsumptionType? Consumption = null,
        List<MultiTenancyConsumptionType>? ConsumptionPerMspOrg = null,
        List<PerWorkloadConsumptionType>? ConsumptionPerWorkloadType = null
    ) 
    {
        if ( Consumption != null ) {
            this.Consumption = Consumption;
        }
        if ( ConsumptionPerMspOrg != null ) {
            this.ConsumptionPerMspOrg = ConsumptionPerMspOrg;
        }
        if ( ConsumptionPerWorkloadType != null ) {
            this.ConsumptionPerWorkloadType = ConsumptionPerWorkloadType;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> LicenseConsumptionType? Consumption
        // GraphQL -> consumption: LicenseConsumptionType (type)
        if (this.Consumption != null) {
            var fspec = this.Consumption.AsFieldSpec(conf.Child("consumption"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "consumption" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<MultiTenancyConsumptionType>? ConsumptionPerMspOrg
        // GraphQL -> consumptionPerMspOrg: [MultiTenancyConsumptionType!]! (type)
        if (this.ConsumptionPerMspOrg != null) {
            var fspec = this.ConsumptionPerMspOrg.AsFieldSpec(conf.Child("consumptionPerMspOrg"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "consumptionPerMspOrg" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<PerWorkloadConsumptionType>? ConsumptionPerWorkloadType
        // GraphQL -> consumptionPerWorkloadType: [PerWorkloadConsumptionType!]! (type)
        if (this.ConsumptionPerWorkloadType != null) {
            var fspec = this.ConsumptionPerWorkloadType.AsFieldSpec(conf.Child("consumptionPerWorkloadType"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "consumptionPerWorkloadType" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> LicenseConsumptionType? Consumption
        // GraphQL -> consumption: LicenseConsumptionType (type)
        if (ec.Includes("consumption",false))
        {
            if(this.Consumption == null) {

                this.Consumption = new LicenseConsumptionType();
                this.Consumption.ApplyExploratoryFieldSpec(ec.NewChild("consumption"));

            } else {

                this.Consumption.ApplyExploratoryFieldSpec(ec.NewChild("consumption"));

            }
        }
        else if (this.Consumption != null && ec.Excludes("consumption",false))
        {
            this.Consumption = null;
        }
        //      C# -> List<MultiTenancyConsumptionType>? ConsumptionPerMspOrg
        // GraphQL -> consumptionPerMspOrg: [MultiTenancyConsumptionType!]! (type)
        if (ec.Includes("consumptionPerMspOrg",false))
        {
            if(this.ConsumptionPerMspOrg == null) {

                this.ConsumptionPerMspOrg = new List<MultiTenancyConsumptionType>();
                this.ConsumptionPerMspOrg.ApplyExploratoryFieldSpec(ec.NewChild("consumptionPerMspOrg"));

            } else {

                this.ConsumptionPerMspOrg.ApplyExploratoryFieldSpec(ec.NewChild("consumptionPerMspOrg"));

            }
        }
        else if (this.ConsumptionPerMspOrg != null && ec.Excludes("consumptionPerMspOrg",false))
        {
            this.ConsumptionPerMspOrg = null;
        }
        //      C# -> List<PerWorkloadConsumptionType>? ConsumptionPerWorkloadType
        // GraphQL -> consumptionPerWorkloadType: [PerWorkloadConsumptionType!]! (type)
        if (ec.Includes("consumptionPerWorkloadType",false))
        {
            if(this.ConsumptionPerWorkloadType == null) {

                this.ConsumptionPerWorkloadType = new List<PerWorkloadConsumptionType>();
                this.ConsumptionPerWorkloadType.ApplyExploratoryFieldSpec(ec.NewChild("consumptionPerWorkloadType"));

            } else {

                this.ConsumptionPerWorkloadType.ApplyExploratoryFieldSpec(ec.NewChild("consumptionPerWorkloadType"));

            }
        }
        else if (this.ConsumptionPerWorkloadType != null && ec.Excludes("consumptionPerWorkloadType",false))
        {
            this.ConsumptionPerWorkloadType = null;
        }
    }


    #endregion

    } // class O365Consumption
    
    #endregion

    public static class ListO365ConsumptionExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<O365Consumption> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<O365Consumption> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<O365Consumption> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365Consumption());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365Consumption> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types