// DataLocation.cs
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
    #region DataLocation
    public class DataLocation: IFragment
    {
        #region members
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> DateTime? CreateDate
        // GraphQL -> createDate: DateTime! (scalar)
        [JsonProperty("createDate")]
        public DateTime? CreateDate { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsActive
        // GraphQL -> isActive: Boolean! (scalar)
        [JsonProperty("isActive")]
        public System.Boolean? IsActive { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> DataLocationName? Type
        // GraphQL -> type: DataLocationName! (enum)
        [JsonProperty("type")]
        public DataLocationName? Type { get; set; }

        #endregion

    #region methods

    public DataLocation Set(
        System.String? ClusterUuid = null,
        DateTime? CreateDate = null,
        System.String? Id = null,
        System.Boolean? IsActive = null,
        System.Boolean? IsArchived = null,
        System.String? Name = null,
        DataLocationName? Type = null
    ) 
    {
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( CreateDate != null ) {
            this.CreateDate = CreateDate;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsActive != null ) {
            this.IsActive = IsActive;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( Name != null ) {
            this.Name = Name;
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
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: UUID! (scalar)
            if (this.ClusterUuid != null)
            {
                 s += ind + "clusterUuid\n";

            }
            //      C# -> DateTime? CreateDate
            // GraphQL -> createDate: DateTime! (scalar)
            if (this.CreateDate != null)
            {
                 s += ind + "createDate\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsActive
            // GraphQL -> isActive: Boolean! (scalar)
            if (this.IsActive != null)
            {
                 s += ind + "isActive\n";

            }
            //      C# -> System.Boolean? IsArchived
            // GraphQL -> isArchived: Boolean! (scalar)
            if (this.IsArchived != null)
            {
                 s += ind + "isArchived\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> DataLocationName? Type
            // GraphQL -> type: DataLocationName! (enum)
            if (this.Type != null)
            {
                 s += ind + "type\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: UUID! (scalar)
            if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid$"))
            {
                this.ClusterUuid = new System.String("FETCH");
            }
            //      C# -> DateTime? CreateDate
            // GraphQL -> createDate: DateTime! (scalar)
            if (this.CreateDate == null && Exploration.Includes(parent + ".createDate$"))
            {
                this.CreateDate = new DateTime();
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsActive
            // GraphQL -> isActive: Boolean! (scalar)
            if (this.IsActive == null && Exploration.Includes(parent + ".isActive$"))
            {
                this.IsActive = new System.Boolean();
            }
            //      C# -> System.Boolean? IsArchived
            // GraphQL -> isArchived: Boolean! (scalar)
            if (this.IsArchived == null && Exploration.Includes(parent + ".isArchived$"))
            {
                this.IsArchived = new System.Boolean();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> DataLocationName? Type
            // GraphQL -> type: DataLocationName! (enum)
            if (this.Type == null && Exploration.Includes(parent + ".type$"))
            {
                this.Type = new DataLocationName();
            }
        }


    #endregion

    } // class DataLocation
    #endregion

    public static class ListDataLocationExtensions
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
            this List<DataLocation> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<DataLocation> list, 
            String parent = "")
        {
            var item = new DataLocation();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types