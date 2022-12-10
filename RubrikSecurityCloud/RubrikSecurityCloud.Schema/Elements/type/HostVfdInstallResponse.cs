// HostVfdInstallResponse.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:37.
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
    #region HostVfdInstallResponse
    public class HostVfdInstallResponse: IFragment
    {
        #region members
        //      C# -> System.String? ErrorInfo
        // GraphQL -> errorInfo: String (scalar)
        [JsonProperty("errorInfo")]
        public System.String? ErrorInfo { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> HostVfdState? HostVfdDriverState
        // GraphQL -> hostVfdDriverState: HostVfdState! (enum)
        [JsonProperty("hostVfdDriverState")]
        public HostVfdState? HostVfdDriverState { get; set; }

        #endregion

    #region methods

    public HostVfdInstallResponse Set(
        System.String? ErrorInfo = null,
        System.String? HostId = null,
        HostVfdState? HostVfdDriverState = null
    ) 
    {
        if ( ErrorInfo != null ) {
            this.ErrorInfo = ErrorInfo;
        }
        if ( HostId != null ) {
            this.HostId = HostId;
        }
        if ( HostVfdDriverState != null ) {
            this.HostVfdDriverState = HostVfdDriverState;
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
            //      C# -> System.String? ErrorInfo
            // GraphQL -> errorInfo: String (scalar)
            if (this.ErrorInfo != null)
            {
                 s += ind + "errorInfo\n";

            }
            //      C# -> System.String? HostId
            // GraphQL -> hostId: String! (scalar)
            if (this.HostId != null)
            {
                 s += ind + "hostId\n";

            }
            //      C# -> HostVfdState? HostVfdDriverState
            // GraphQL -> hostVfdDriverState: HostVfdState! (enum)
            if (this.HostVfdDriverState != null)
            {
                 s += ind + "hostVfdDriverState\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ErrorInfo
            // GraphQL -> errorInfo: String (scalar)
            if (this.ErrorInfo == null && Exploration.Includes(parent + ".errorInfo$"))
            {
                this.ErrorInfo = new System.String("FETCH");
            }
            //      C# -> System.String? HostId
            // GraphQL -> hostId: String! (scalar)
            if (this.HostId == null && Exploration.Includes(parent + ".hostId$"))
            {
                this.HostId = new System.String("FETCH");
            }
            //      C# -> HostVfdState? HostVfdDriverState
            // GraphQL -> hostVfdDriverState: HostVfdState! (enum)
            if (this.HostVfdDriverState == null && Exploration.Includes(parent + ".hostVfdDriverState$"))
            {
                this.HostVfdDriverState = new HostVfdState();
            }
        }


    #endregion

    } // class HostVfdInstallResponse
    #endregion

    public static class ListHostVfdInstallResponseExtensions
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
            this List<HostVfdInstallResponse> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<HostVfdInstallResponse> list, 
            String parent = "")
        {
            var item = new HostVfdInstallResponse();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types