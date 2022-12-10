// CdmMssqlDbReplicaAvailabilityInfo.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:45.
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
    #region CdmMssqlDbReplicaAvailabilityInfo
    public class CdmMssqlDbReplicaAvailabilityInfo: IFragment
    {
        #region members
        //      C# -> System.String? AvailabilityMode
        // GraphQL -> availabilityMode: String! (scalar)
        [JsonProperty("availabilityMode")]
        public System.String? AvailabilityMode { get; set; }

        //      C# -> System.String? ReplicaId
        // GraphQL -> replicaId: String! (scalar)
        [JsonProperty("replicaId")]
        public System.String? ReplicaId { get; set; }

        //      C# -> System.String? Role
        // GraphQL -> role: String! (scalar)
        [JsonProperty("role")]
        public System.String? Role { get; set; }

        #endregion

    #region methods

    public CdmMssqlDbReplicaAvailabilityInfo Set(
        System.String? AvailabilityMode = null,
        System.String? ReplicaId = null,
        System.String? Role = null
    ) 
    {
        if ( AvailabilityMode != null ) {
            this.AvailabilityMode = AvailabilityMode;
        }
        if ( ReplicaId != null ) {
            this.ReplicaId = ReplicaId;
        }
        if ( Role != null ) {
            this.Role = Role;
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
            //      C# -> System.String? AvailabilityMode
            // GraphQL -> availabilityMode: String! (scalar)
            if (this.AvailabilityMode != null)
            {
                 s += ind + "availabilityMode\n";

            }
            //      C# -> System.String? ReplicaId
            // GraphQL -> replicaId: String! (scalar)
            if (this.ReplicaId != null)
            {
                 s += ind + "replicaId\n";

            }
            //      C# -> System.String? Role
            // GraphQL -> role: String! (scalar)
            if (this.Role != null)
            {
                 s += ind + "role\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AvailabilityMode
            // GraphQL -> availabilityMode: String! (scalar)
            if (this.AvailabilityMode == null && Exploration.Includes(parent + ".availabilityMode$"))
            {
                this.AvailabilityMode = new System.String("FETCH");
            }
            //      C# -> System.String? ReplicaId
            // GraphQL -> replicaId: String! (scalar)
            if (this.ReplicaId == null && Exploration.Includes(parent + ".replicaId$"))
            {
                this.ReplicaId = new System.String("FETCH");
            }
            //      C# -> System.String? Role
            // GraphQL -> role: String! (scalar)
            if (this.Role == null && Exploration.Includes(parent + ".role$"))
            {
                this.Role = new System.String("FETCH");
            }
        }


    #endregion

    } // class CdmMssqlDbReplicaAvailabilityInfo
    #endregion

    public static class ListCdmMssqlDbReplicaAvailabilityInfoExtensions
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
            this List<CdmMssqlDbReplicaAvailabilityInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CdmMssqlDbReplicaAvailabilityInfo> list, 
            String parent = "")
        {
            var item = new CdmMssqlDbReplicaAvailabilityInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types