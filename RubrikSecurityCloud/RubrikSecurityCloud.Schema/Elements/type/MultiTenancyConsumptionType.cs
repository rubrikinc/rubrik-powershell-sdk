// MultiTenancyConsumptionType.cs
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
    #region MultiTenancyConsumptionType
    public class MultiTenancyConsumptionType: BaseType
    {
        #region members

        //      C# -> System.String? MspOrgId
        // GraphQL -> mspOrgId: String! (scalar)
        [JsonProperty("mspOrgId")]
        public System.String? MspOrgId { get; set; }

        //      C# -> LicenseConsumptionType? Consumption
        // GraphQL -> consumption: LicenseConsumptionType (type)
        [JsonProperty("consumption")]
        public LicenseConsumptionType? Consumption { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MultiTenancyConsumptionType";
    }

    public MultiTenancyConsumptionType Set(
        System.String? MspOrgId = null,
        LicenseConsumptionType? Consumption = null
    ) 
    {
        if ( MspOrgId != null ) {
            this.MspOrgId = MspOrgId;
        }
        if ( Consumption != null ) {
            this.Consumption = Consumption;
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
        //      C# -> System.String? MspOrgId
        // GraphQL -> mspOrgId: String! (scalar)
        if (this.MspOrgId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mspOrgId\n" ;
            } else {
                s += ind + "mspOrgId\n" ;
            }
        }
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? MspOrgId
        // GraphQL -> mspOrgId: String! (scalar)
        if (ec.Includes("mspOrgId",true))
        {
            if(this.MspOrgId == null) {

                this.MspOrgId = "FETCH";

            } else {


            }
        }
        else if (this.MspOrgId != null && ec.Excludes("mspOrgId",true))
        {
            this.MspOrgId = null;
        }
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
    }


    #endregion

    } // class MultiTenancyConsumptionType
    
    #endregion

    public static class ListMultiTenancyConsumptionTypeExtensions
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
            this List<MultiTenancyConsumptionType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MultiTenancyConsumptionType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MultiTenancyConsumptionType> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MultiTenancyConsumptionType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MultiTenancyConsumptionType> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types