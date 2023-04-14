// StartThreatHuntReply.cs
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
    #region StartThreatHuntReply
    public class StartThreatHuntReply: IFragment
    {
        #region members
        //      C# -> System.String? HuntId
        // GraphQL -> huntId: String! (scalar)
        [JsonProperty("huntId")]
        public System.String? HuntId { get; set; }

        //      C# -> System.Boolean? IsSyncSuccessful
        // GraphQL -> isSyncSuccessful: Boolean! (scalar)
        [JsonProperty("isSyncSuccessful")]
        public System.Boolean? IsSyncSuccessful { get; set; }

        //      C# -> AsyncRequestStatus? HuntStatus
        // GraphQL -> huntStatus: AsyncRequestStatus (type)
        [JsonProperty("huntStatus")]
        public AsyncRequestStatus? HuntStatus { get; set; }

        #endregion

    #region methods

    public StartThreatHuntReply Set(
        System.String? HuntId = null,
        System.Boolean? IsSyncSuccessful = null,
        AsyncRequestStatus? HuntStatus = null
    ) 
    {
        if ( HuntId != null ) {
            this.HuntId = HuntId;
        }
        if ( IsSyncSuccessful != null ) {
            this.IsSyncSuccessful = IsSyncSuccessful;
        }
        if ( HuntStatus != null ) {
            this.HuntStatus = HuntStatus;
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
            //      C# -> System.String? HuntId
            // GraphQL -> huntId: String! (scalar)
            if (this.HuntId != null)
            {
                 s += ind + "huntId\n";

            }
            //      C# -> System.Boolean? IsSyncSuccessful
            // GraphQL -> isSyncSuccessful: Boolean! (scalar)
            if (this.IsSyncSuccessful != null)
            {
                 s += ind + "isSyncSuccessful\n";

            }
            //      C# -> AsyncRequestStatus? HuntStatus
            // GraphQL -> huntStatus: AsyncRequestStatus (type)
            if (this.HuntStatus != null)
            {
                 s += ind + "huntStatus\n";

                 s += ind + "{\n" + 
                 this.HuntStatus.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? HuntId
            // GraphQL -> huntId: String! (scalar)
            if (this.HuntId == null && Exploration.Includes(parent + ".huntId$"))
            {
                this.HuntId = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsSyncSuccessful
            // GraphQL -> isSyncSuccessful: Boolean! (scalar)
            if (this.IsSyncSuccessful == null && Exploration.Includes(parent + ".isSyncSuccessful$"))
            {
                this.IsSyncSuccessful = new System.Boolean();
            }
            //      C# -> AsyncRequestStatus? HuntStatus
            // GraphQL -> huntStatus: AsyncRequestStatus (type)
            if (this.HuntStatus == null && Exploration.Includes(parent + ".huntStatus"))
            {
                this.HuntStatus = new AsyncRequestStatus();
                this.HuntStatus.ApplyExploratoryFragment(parent + ".huntStatus");
            }
        }


    #endregion

    } // class StartThreatHuntReply
    #endregion

    public static class ListStartThreatHuntReplyExtensions
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
            this List<StartThreatHuntReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<StartThreatHuntReply> list, 
            String parent = "")
        {
            var item = new StartThreatHuntReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types