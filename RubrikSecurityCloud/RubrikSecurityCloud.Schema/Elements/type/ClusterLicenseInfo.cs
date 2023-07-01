// ClusterLicenseInfo.cs
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
    #region ClusterLicenseInfo
    public class ClusterLicenseInfo: BaseType
    {
        #region members

        //      C# -> Product? Product
        // GraphQL -> product: Product! (enum)
        [JsonProperty("product")]
        public Product? Product { get; set; }

        //      C# -> ClusterLicenseInfoType? Type
        // GraphQL -> type: ClusterLicenseInfoType! (enum)
        [JsonProperty("type")]
        public ClusterLicenseInfoType? Type { get; set; }

        //      C# -> DateTime? MaxTermEndDate
        // GraphQL -> maxTermEndDate: DateTime (scalar)
        [JsonProperty("maxTermEndDate")]
        public DateTime? MaxTermEndDate { get; set; }

        //      C# -> System.Single? RequestedCapacityBytes
        // GraphQL -> requestedCapacityBytes: Float! (scalar)
        [JsonProperty("requestedCapacityBytes")]
        public System.Single? RequestedCapacityBytes { get; set; }

        //      C# -> System.Single? TotalCapacityBytes
        // GraphQL -> totalCapacityBytes: Float! (scalar)
        [JsonProperty("totalCapacityBytes")]
        public System.Single? TotalCapacityBytes { get; set; }

        //      C# -> System.Single? UsableCapacityBytes
        // GraphQL -> usableCapacityBytes: Float! (scalar)
        [JsonProperty("usableCapacityBytes")]
        public System.Single? UsableCapacityBytes { get; set; }

        //      C# -> System.Single? UsedCapacityBytes
        // GraphQL -> usedCapacityBytes: Float! (scalar)
        [JsonProperty("usedCapacityBytes")]
        public System.Single? UsedCapacityBytes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterLicenseInfo";
    }

    public ClusterLicenseInfo Set(
        Product? Product = null,
        ClusterLicenseInfoType? Type = null,
        DateTime? MaxTermEndDate = null,
        System.Single? RequestedCapacityBytes = null,
        System.Single? TotalCapacityBytes = null,
        System.Single? UsableCapacityBytes = null,
        System.Single? UsedCapacityBytes = null
    ) 
    {
        if ( Product != null ) {
            this.Product = Product;
        }
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( MaxTermEndDate != null ) {
            this.MaxTermEndDate = MaxTermEndDate;
        }
        if ( RequestedCapacityBytes != null ) {
            this.RequestedCapacityBytes = RequestedCapacityBytes;
        }
        if ( TotalCapacityBytes != null ) {
            this.TotalCapacityBytes = TotalCapacityBytes;
        }
        if ( UsableCapacityBytes != null ) {
            this.UsableCapacityBytes = UsableCapacityBytes;
        }
        if ( UsedCapacityBytes != null ) {
            this.UsedCapacityBytes = UsedCapacityBytes;
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
        //      C# -> Product? Product
        // GraphQL -> product: Product! (enum)
        if (this.Product != null) {
            s += ind + "product\n" ;
        }
        //      C# -> ClusterLicenseInfoType? Type
        // GraphQL -> type: ClusterLicenseInfoType! (enum)
        if (this.Type != null) {
            s += ind + "type\n" ;
        }
        //      C# -> DateTime? MaxTermEndDate
        // GraphQL -> maxTermEndDate: DateTime (scalar)
        if (this.MaxTermEndDate != null) {
            s += ind + "maxTermEndDate\n" ;
        }
        //      C# -> System.Single? RequestedCapacityBytes
        // GraphQL -> requestedCapacityBytes: Float! (scalar)
        if (this.RequestedCapacityBytes != null) {
            s += ind + "requestedCapacityBytes\n" ;
        }
        //      C# -> System.Single? TotalCapacityBytes
        // GraphQL -> totalCapacityBytes: Float! (scalar)
        if (this.TotalCapacityBytes != null) {
            s += ind + "totalCapacityBytes\n" ;
        }
        //      C# -> System.Single? UsableCapacityBytes
        // GraphQL -> usableCapacityBytes: Float! (scalar)
        if (this.UsableCapacityBytes != null) {
            s += ind + "usableCapacityBytes\n" ;
        }
        //      C# -> System.Single? UsedCapacityBytes
        // GraphQL -> usedCapacityBytes: Float! (scalar)
        if (this.UsedCapacityBytes != null) {
            s += ind + "usedCapacityBytes\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> Product? Product
        // GraphQL -> product: Product! (enum)
        if (this.Product == null && Exploration.Includes(parent + ".product", true))
        {
            this.Product = new Product();
        }
        //      C# -> ClusterLicenseInfoType? Type
        // GraphQL -> type: ClusterLicenseInfoType! (enum)
        if (this.Type == null && Exploration.Includes(parent + ".type", true))
        {
            this.Type = new ClusterLicenseInfoType();
        }
        //      C# -> DateTime? MaxTermEndDate
        // GraphQL -> maxTermEndDate: DateTime (scalar)
        if (this.MaxTermEndDate == null && Exploration.Includes(parent + ".maxTermEndDate", true))
        {
            this.MaxTermEndDate = new DateTime();
        }
        //      C# -> System.Single? RequestedCapacityBytes
        // GraphQL -> requestedCapacityBytes: Float! (scalar)
        if (this.RequestedCapacityBytes == null && Exploration.Includes(parent + ".requestedCapacityBytes", true))
        {
            this.RequestedCapacityBytes = new System.Single();
        }
        //      C# -> System.Single? TotalCapacityBytes
        // GraphQL -> totalCapacityBytes: Float! (scalar)
        if (this.TotalCapacityBytes == null && Exploration.Includes(parent + ".totalCapacityBytes", true))
        {
            this.TotalCapacityBytes = new System.Single();
        }
        //      C# -> System.Single? UsableCapacityBytes
        // GraphQL -> usableCapacityBytes: Float! (scalar)
        if (this.UsableCapacityBytes == null && Exploration.Includes(parent + ".usableCapacityBytes", true))
        {
            this.UsableCapacityBytes = new System.Single();
        }
        //      C# -> System.Single? UsedCapacityBytes
        // GraphQL -> usedCapacityBytes: Float! (scalar)
        if (this.UsedCapacityBytes == null && Exploration.Includes(parent + ".usedCapacityBytes", true))
        {
            this.UsedCapacityBytes = new System.Single();
        }
    }


    #endregion

    } // class ClusterLicenseInfo
    
    #endregion

    public static class ListClusterLicenseInfoExtensions
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
            this List<ClusterLicenseInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterLicenseInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterLicenseInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types