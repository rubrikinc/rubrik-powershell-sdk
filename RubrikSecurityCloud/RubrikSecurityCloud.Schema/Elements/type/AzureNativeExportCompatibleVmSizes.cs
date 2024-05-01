// AzureNativeExportCompatibleVmSizes.cs
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
    #region AzureNativeExportCompatibleVmSizes
    public class AzureNativeExportCompatibleVmSizes: BaseType
    {
        #region members

        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String! (scalar)
        [JsonProperty("availabilityZone")]
        public System.String? AvailabilityZone { get; set; }

        //      C# -> List<System.String>? VmSizes
        // GraphQL -> vmSizes: [String!]! (scalar)
        [JsonProperty("vmSizes")]
        public List<System.String>? VmSizes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureNativeExportCompatibleVmSizes";
    }

    public AzureNativeExportCompatibleVmSizes Set(
        System.String? AvailabilityZone = null,
        List<System.String>? VmSizes = null
    ) 
    {
        if ( AvailabilityZone != null ) {
            this.AvailabilityZone = AvailabilityZone;
        }
        if ( VmSizes != null ) {
            this.VmSizes = VmSizes;
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
        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String! (scalar)
        if (this.AvailabilityZone != null) {
            if (conf.Flat) {
                s += conf.Prefix + "availabilityZone\n" ;
            } else {
                s += ind + "availabilityZone\n" ;
            }
        }
        //      C# -> List<System.String>? VmSizes
        // GraphQL -> vmSizes: [String!]! (scalar)
        if (this.VmSizes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vmSizes\n" ;
            } else {
                s += ind + "vmSizes\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String! (scalar)
        if (ec.Includes("availabilityZone",true))
        {
            if(this.AvailabilityZone == null) {

                this.AvailabilityZone = "FETCH";

            } else {


            }
        }
        else if (this.AvailabilityZone != null && ec.Excludes("availabilityZone",true))
        {
            this.AvailabilityZone = null;
        }
        //      C# -> List<System.String>? VmSizes
        // GraphQL -> vmSizes: [String!]! (scalar)
        if (ec.Includes("vmSizes",true))
        {
            if(this.VmSizes == null) {

                this.VmSizes = new List<System.String>();

            } else {


            }
        }
        else if (this.VmSizes != null && ec.Excludes("vmSizes",true))
        {
            this.VmSizes = null;
        }
    }


    #endregion

    } // class AzureNativeExportCompatibleVmSizes
    
    #endregion

    public static class ListAzureNativeExportCompatibleVmSizesExtensions
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
            this List<AzureNativeExportCompatibleVmSizes> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureNativeExportCompatibleVmSizes> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureNativeExportCompatibleVmSizes> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureNativeExportCompatibleVmSizes());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureNativeExportCompatibleVmSizes> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types