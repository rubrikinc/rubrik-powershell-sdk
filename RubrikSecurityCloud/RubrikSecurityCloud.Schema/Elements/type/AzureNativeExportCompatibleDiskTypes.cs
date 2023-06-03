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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<AzureNativeManagedDiskType>? DiskTypes
        // GraphQL -> diskTypes: [AzureNativeManagedDiskType!]! (enum)
        if (this.DiskTypes != null) {
            s += ind + "diskTypes\n" ;
        }
        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String! (scalar)
        if (this.AvailabilityZone != null) {
            s += ind + "availabilityZone\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<AzureNativeManagedDiskType>? DiskTypes
        // GraphQL -> diskTypes: [AzureNativeManagedDiskType!]! (enum)
        if (this.DiskTypes == null && Exploration.Includes(parent + ".diskTypes", true))
        {
            this.DiskTypes = new List<AzureNativeManagedDiskType>();
        }
        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String! (scalar)
        if (this.AvailabilityZone == null && Exploration.Includes(parent + ".availabilityZone", true))
        {
            this.AvailabilityZone = new System.String("FETCH");
        }
    }


    #endregion

    } // class AzureNativeExportCompatibleDiskTypes
    
    #endregion

    public static class ListAzureNativeExportCompatibleDiskTypesExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<AzureNativeExportCompatibleDiskTypes> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureNativeExportCompatibleDiskTypes> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureNativeExportCompatibleDiskTypes());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types