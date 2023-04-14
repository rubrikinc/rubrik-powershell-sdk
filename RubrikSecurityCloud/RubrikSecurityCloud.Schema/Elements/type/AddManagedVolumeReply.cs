// AddManagedVolumeReply.cs
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
    #region AddManagedVolumeReply
    public class AddManagedVolumeReply: IFragment
    {
        #region members
        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        [JsonProperty("asyncRequestStatus")]
        public AsyncRequestStatus? AsyncRequestStatus { get; set; }

        //      C# -> UpdateManagedVolumeReply? ManagedVolumeSummary
        // GraphQL -> managedVolumeSummary: UpdateManagedVolumeReply (type)
        [JsonProperty("managedVolumeSummary")]
        public UpdateManagedVolumeReply? ManagedVolumeSummary { get; set; }

        #endregion

    #region methods

    public AddManagedVolumeReply Set(
        AsyncRequestStatus? AsyncRequestStatus = null,
        UpdateManagedVolumeReply? ManagedVolumeSummary = null
    ) 
    {
        if ( AsyncRequestStatus != null ) {
            this.AsyncRequestStatus = AsyncRequestStatus;
        }
        if ( ManagedVolumeSummary != null ) {
            this.ManagedVolumeSummary = ManagedVolumeSummary;
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
            //      C# -> AsyncRequestStatus? AsyncRequestStatus
            // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
            if (this.AsyncRequestStatus != null)
            {
                 s += ind + "asyncRequestStatus\n";

                 s += ind + "{\n" + 
                 this.AsyncRequestStatus.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> UpdateManagedVolumeReply? ManagedVolumeSummary
            // GraphQL -> managedVolumeSummary: UpdateManagedVolumeReply (type)
            if (this.ManagedVolumeSummary != null)
            {
                 s += ind + "managedVolumeSummary\n";

                 s += ind + "{\n" + 
                 this.ManagedVolumeSummary.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> AsyncRequestStatus? AsyncRequestStatus
            // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
            if (this.AsyncRequestStatus == null && Exploration.Includes(parent + ".asyncRequestStatus"))
            {
                this.AsyncRequestStatus = new AsyncRequestStatus();
                this.AsyncRequestStatus.ApplyExploratoryFragment(parent + ".asyncRequestStatus");
            }
            //      C# -> UpdateManagedVolumeReply? ManagedVolumeSummary
            // GraphQL -> managedVolumeSummary: UpdateManagedVolumeReply (type)
            if (this.ManagedVolumeSummary == null && Exploration.Includes(parent + ".managedVolumeSummary"))
            {
                this.ManagedVolumeSummary = new UpdateManagedVolumeReply();
                this.ManagedVolumeSummary.ApplyExploratoryFragment(parent + ".managedVolumeSummary");
            }
        }


    #endregion

    } // class AddManagedVolumeReply
    #endregion

    public static class ListAddManagedVolumeReplyExtensions
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
            this List<AddManagedVolumeReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AddManagedVolumeReply> list, 
            String parent = "")
        {
            var item = new AddManagedVolumeReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types