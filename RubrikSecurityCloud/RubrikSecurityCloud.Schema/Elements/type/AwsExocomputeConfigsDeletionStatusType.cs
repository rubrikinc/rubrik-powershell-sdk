// AwsExocomputeConfigsDeletionStatusType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:21.
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
    #region AwsExocomputeConfigsDeletionStatusType
    public class AwsExocomputeConfigsDeletionStatusType: IFragment
    {
        #region members
        //      C# -> System.String? ExocomputeConfigId
        // GraphQL -> exocomputeConfigId: String! (scalar)
        [JsonProperty("exocomputeConfigId")]
        public System.String? ExocomputeConfigId { get; set; }

        //      C# -> System.Boolean? Success
        // GraphQL -> success: Boolean! (scalar)
        [JsonProperty("success")]
        public System.Boolean? Success { get; set; }

        #endregion

    #region methods

    public AwsExocomputeConfigsDeletionStatusType Set(
        System.String? ExocomputeConfigId = null,
        System.Boolean? Success = null
    ) 
    {
        if ( ExocomputeConfigId != null ) {
            this.ExocomputeConfigId = ExocomputeConfigId;
        }
        if ( Success != null ) {
            this.Success = Success;
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
            //      C# -> System.String? ExocomputeConfigId
            // GraphQL -> exocomputeConfigId: String! (scalar)
            if (this.ExocomputeConfigId != null)
            {
                 s += ind + "exocomputeConfigId\n";

            }
            //      C# -> System.Boolean? Success
            // GraphQL -> success: Boolean! (scalar)
            if (this.Success != null)
            {
                 s += ind + "success\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ExocomputeConfigId
            // GraphQL -> exocomputeConfigId: String! (scalar)
            if (this.ExocomputeConfigId == null && Exploration.Includes(parent + ".exocomputeConfigId$"))
            {
                this.ExocomputeConfigId = new System.String("FETCH");
            }
            //      C# -> System.Boolean? Success
            // GraphQL -> success: Boolean! (scalar)
            if (this.Success == null && Exploration.Includes(parent + ".success$"))
            {
                this.Success = new System.Boolean();
            }
        }


    #endregion

    } // class AwsExocomputeConfigsDeletionStatusType
    #endregion

    public static class ListAwsExocomputeConfigsDeletionStatusTypeExtensions
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
            this List<AwsExocomputeConfigsDeletionStatusType> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AwsExocomputeConfigsDeletionStatusType> list, 
            String parent = "")
        {
            var item = new AwsExocomputeConfigsDeletionStatusType();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types