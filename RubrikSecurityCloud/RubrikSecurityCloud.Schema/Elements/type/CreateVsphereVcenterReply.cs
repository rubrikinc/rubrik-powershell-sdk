// CreateVsphereVcenterReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:41.
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
    #region CreateVsphereVcenterReply
    public class CreateVsphereVcenterReply: IFragment
    {
        #region members
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsHotAddProxyEnabledForOnPremVcenter
        // GraphQL -> isHotAddProxyEnabledForOnPremVcenter: Boolean (scalar)
        [JsonProperty("isHotAddProxyEnabledForOnPremVcenter")]
        public System.Boolean? IsHotAddProxyEnabledForOnPremVcenter { get; set; }

        //      C# -> System.Boolean? IsVmc
        // GraphQL -> isVmc: Boolean! (scalar)
        [JsonProperty("isVmc")]
        public System.Boolean? IsVmc { get; set; }

        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        [JsonProperty("asyncRequestStatus")]
        public AsyncRequestStatus? AsyncRequestStatus { get; set; }

        #endregion

    #region methods

    public CreateVsphereVcenterReply Set(
        System.String? Id = null,
        System.Boolean? IsHotAddProxyEnabledForOnPremVcenter = null,
        System.Boolean? IsVmc = null,
        AsyncRequestStatus? AsyncRequestStatus = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsHotAddProxyEnabledForOnPremVcenter != null ) {
            this.IsHotAddProxyEnabledForOnPremVcenter = IsHotAddProxyEnabledForOnPremVcenter;
        }
        if ( IsVmc != null ) {
            this.IsVmc = IsVmc;
        }
        if ( AsyncRequestStatus != null ) {
            this.AsyncRequestStatus = AsyncRequestStatus;
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
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsHotAddProxyEnabledForOnPremVcenter
            // GraphQL -> isHotAddProxyEnabledForOnPremVcenter: Boolean (scalar)
            if (this.IsHotAddProxyEnabledForOnPremVcenter != null)
            {
                 s += ind + "isHotAddProxyEnabledForOnPremVcenter\n";

            }
            //      C# -> System.Boolean? IsVmc
            // GraphQL -> isVmc: Boolean! (scalar)
            if (this.IsVmc != null)
            {
                 s += ind + "isVmc\n";

            }
            //      C# -> AsyncRequestStatus? AsyncRequestStatus
            // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
            if (this.AsyncRequestStatus != null)
            {
                 s += ind + "asyncRequestStatus\n";

                 s += ind + "{\n" + 
                 this.AsyncRequestStatus.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsHotAddProxyEnabledForOnPremVcenter
            // GraphQL -> isHotAddProxyEnabledForOnPremVcenter: Boolean (scalar)
            if (this.IsHotAddProxyEnabledForOnPremVcenter == null && Exploration.Includes(parent + ".isHotAddProxyEnabledForOnPremVcenter$"))
            {
                this.IsHotAddProxyEnabledForOnPremVcenter = new System.Boolean();
            }
            //      C# -> System.Boolean? IsVmc
            // GraphQL -> isVmc: Boolean! (scalar)
            if (this.IsVmc == null && Exploration.Includes(parent + ".isVmc$"))
            {
                this.IsVmc = new System.Boolean();
            }
            //      C# -> AsyncRequestStatus? AsyncRequestStatus
            // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
            if (this.AsyncRequestStatus == null && Exploration.Includes(parent + ".asyncRequestStatus"))
            {
                this.AsyncRequestStatus = new AsyncRequestStatus();
                this.AsyncRequestStatus.ApplyExploratoryFragment(parent + ".asyncRequestStatus");
            }
        }


    #endregion

    } // class CreateVsphereVcenterReply
    #endregion

    public static class ListCreateVsphereVcenterReplyExtensions
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
            this List<CreateVsphereVcenterReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CreateVsphereVcenterReply> list, 
            String parent = "")
        {
            var item = new CreateVsphereVcenterReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types