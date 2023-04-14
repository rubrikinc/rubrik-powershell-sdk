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

namespace Rubrik.SecurityCloud.Types
{
    #region ClusterLicenseInfo
    public class ClusterLicenseInfo: IFragment
    {
        #region members
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

        //      C# -> Product? Product
        // GraphQL -> product: Product! (enum)
        [JsonProperty("product")]
        public Product? Product { get; set; }

        //      C# -> ClusterLicenseInfoType? Type
        // GraphQL -> type: ClusterLicenseInfoType! (enum)
        [JsonProperty("type")]
        public ClusterLicenseInfoType? Type { get; set; }

        #endregion

    #region methods

    public ClusterLicenseInfo Set(
        DateTime? MaxTermEndDate = null,
        System.Single? RequestedCapacityBytes = null,
        System.Single? TotalCapacityBytes = null,
        System.Single? UsableCapacityBytes = null,
        System.Single? UsedCapacityBytes = null,
        Product? Product = null,
        ClusterLicenseInfoType? Type = null
    ) 
    {
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
        if ( Product != null ) {
            this.Product = Product;
        }
        if ( Type != null ) {
            this.Type = Type;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> DateTime? MaxTermEndDate
            // GraphQL -> maxTermEndDate: DateTime (scalar)
            if (this.MaxTermEndDate != null)
            {
                 s += ind + "maxTermEndDate\n";

            }
            //      C# -> System.Single? RequestedCapacityBytes
            // GraphQL -> requestedCapacityBytes: Float! (scalar)
            if (this.RequestedCapacityBytes != null)
            {
                 s += ind + "requestedCapacityBytes\n";

            }
            //      C# -> System.Single? TotalCapacityBytes
            // GraphQL -> totalCapacityBytes: Float! (scalar)
            if (this.TotalCapacityBytes != null)
            {
                 s += ind + "totalCapacityBytes\n";

            }
            //      C# -> System.Single? UsableCapacityBytes
            // GraphQL -> usableCapacityBytes: Float! (scalar)
            if (this.UsableCapacityBytes != null)
            {
                 s += ind + "usableCapacityBytes\n";

            }
            //      C# -> System.Single? UsedCapacityBytes
            // GraphQL -> usedCapacityBytes: Float! (scalar)
            if (this.UsedCapacityBytes != null)
            {
                 s += ind + "usedCapacityBytes\n";

            }
            //      C# -> Product? Product
            // GraphQL -> product: Product! (enum)
            if (this.Product != null)
            {
                 s += ind + "product\n";

            }
            //      C# -> ClusterLicenseInfoType? Type
            // GraphQL -> type: ClusterLicenseInfoType! (enum)
            if (this.Type != null)
            {
                 s += ind + "type\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> DateTime? MaxTermEndDate
            // GraphQL -> maxTermEndDate: DateTime (scalar)
            if (this.MaxTermEndDate == null && Exploration.Includes(parent + ".maxTermEndDate$"))
            {
                this.MaxTermEndDate = new DateTime();
            }
            //      C# -> System.Single? RequestedCapacityBytes
            // GraphQL -> requestedCapacityBytes: Float! (scalar)
            if (this.RequestedCapacityBytes == null && Exploration.Includes(parent + ".requestedCapacityBytes$"))
            {
                this.RequestedCapacityBytes = new System.Single();
            }
            //      C# -> System.Single? TotalCapacityBytes
            // GraphQL -> totalCapacityBytes: Float! (scalar)
            if (this.TotalCapacityBytes == null && Exploration.Includes(parent + ".totalCapacityBytes$"))
            {
                this.TotalCapacityBytes = new System.Single();
            }
            //      C# -> System.Single? UsableCapacityBytes
            // GraphQL -> usableCapacityBytes: Float! (scalar)
            if (this.UsableCapacityBytes == null && Exploration.Includes(parent + ".usableCapacityBytes$"))
            {
                this.UsableCapacityBytes = new System.Single();
            }
            //      C# -> System.Single? UsedCapacityBytes
            // GraphQL -> usedCapacityBytes: Float! (scalar)
            if (this.UsedCapacityBytes == null && Exploration.Includes(parent + ".usedCapacityBytes$"))
            {
                this.UsedCapacityBytes = new System.Single();
            }
            //      C# -> Product? Product
            // GraphQL -> product: Product! (enum)
            if (this.Product == null && Exploration.Includes(parent + ".product$"))
            {
                this.Product = new Product();
            }
            //      C# -> ClusterLicenseInfoType? Type
            // GraphQL -> type: ClusterLicenseInfoType! (enum)
            if (this.Type == null && Exploration.Includes(parent + ".type$"))
            {
                this.Type = new ClusterLicenseInfoType();
            }
        }


    #endregion

    } // class ClusterLicenseInfo
    #endregion

    public static class ListClusterLicenseInfoExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<ClusterLicenseInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ClusterLicenseInfo> list, 
            String parent = "")
        {
            var item = new ClusterLicenseInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types