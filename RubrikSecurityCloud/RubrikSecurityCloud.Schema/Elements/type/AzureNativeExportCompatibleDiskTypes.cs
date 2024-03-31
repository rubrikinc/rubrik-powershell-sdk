// AzureNativeExportCompatibleDiskTypes.cs
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
    #region AzureNativeExportCompatibleDiskTypes
    public class AzureNativeExportCompatibleDiskTypes: BaseType
    {
        #region members

        //      C# -> List<AzureNativeManagedDiskType>? DiskTypes
        // GraphQL -> diskTypes: [AzureNativeManagedDiskType!]! (enum)
        [JsonProperty("diskTypes")]
        public List<AzureNativeManagedDiskType>? DiskTypes { get; set; }

        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String! (scalar)
        [JsonProperty("availabilityZone")]
        public System.String? AvailabilityZone { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureNativeExportCompatibleDiskTypes";
    }

    public AzureNativeExportCompatibleDiskTypes Set(
        List<AzureNativeManagedDiskType>? DiskTypes = null,
        System.String? AvailabilityZone = null
    ) 
    {
        if ( DiskTypes != null ) {
            this.DiskTypes = DiskTypes;
        }
        if ( AvailabilityZone != null ) {
            this.AvailabilityZone = AvailabilityZone;
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
        //      C# -> List<AzureNativeManagedDiskType>? DiskTypes
        // GraphQL -> diskTypes: [AzureNativeManagedDiskType!]! (enum)
        if (this.DiskTypes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "diskTypes\n" ;
            } else {
                s += ind + "diskTypes\n" ;
            }
        }
        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String! (scalar)
        if (this.AvailabilityZone != null) {
            if (conf.Flat) {
                s += conf.Prefix + "availabilityZone\n" ;
            } else {
                s += ind + "availabilityZone\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<AzureNativeManagedDiskType>? DiskTypes
        // GraphQL -> diskTypes: [AzureNativeManagedDiskType!]! (enum)
        if (ec.Includes("diskTypes",true))
        {
            if(this.DiskTypes == null) {

                this.DiskTypes = new List<AzureNativeManagedDiskType>();

            } else {


            }
        }
        else if (this.DiskTypes != null && ec.Excludes("diskTypes",true))
        {
            this.DiskTypes = null;
        }
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
    }


    #endregion

    } // class AzureNativeExportCompatibleDiskTypes
    
    #endregion

    public static class ListAzureNativeExportCompatibleDiskTypesExtensions
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
            this List<AzureNativeExportCompatibleDiskTypes> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureNativeExportCompatibleDiskTypes> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureNativeExportCompatibleDiskTypes> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureNativeExportCompatibleDiskTypes());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureNativeExportCompatibleDiskTypes> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types