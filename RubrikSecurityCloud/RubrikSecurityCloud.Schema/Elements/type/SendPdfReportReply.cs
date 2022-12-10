// SendPdfReportReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:43.
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
    #region SendPdfReportReply
    public class SendPdfReportReply: IFragment
    {
        #region members
        //      C# -> System.String? TaskchainUuid
        // GraphQL -> taskchainUuid: String! (scalar)
        [JsonProperty("taskchainUuid")]
        public System.String? TaskchainUuid { get; set; }

        #endregion

    #region methods

    public SendPdfReportReply Set(
        System.String? TaskchainUuid = null
    ) 
    {
        if ( TaskchainUuid != null ) {
            this.TaskchainUuid = TaskchainUuid;
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
            //      C# -> System.String? TaskchainUuid
            // GraphQL -> taskchainUuid: String! (scalar)
            if (this.TaskchainUuid != null)
            {
                 s += ind + "taskchainUuid\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? TaskchainUuid
            // GraphQL -> taskchainUuid: String! (scalar)
            if (this.TaskchainUuid == null && Exploration.Includes(parent + ".taskchainUuid$"))
            {
                this.TaskchainUuid = new System.String("FETCH");
            }
        }


    #endregion

    } // class SendPdfReportReply
    #endregion

    public static class ListSendPdfReportReplyExtensions
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
            this List<SendPdfReportReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SendPdfReportReply> list, 
            String parent = "")
        {
            var item = new SendPdfReportReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types