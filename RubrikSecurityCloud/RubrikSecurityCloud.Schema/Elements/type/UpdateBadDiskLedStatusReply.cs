// UpdateBadDiskLedStatusReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:16.
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
    #region UpdateBadDiskLedStatusReply
    public class UpdateBadDiskLedStatusReply: IFragment
    {
        #region members
        //      C# -> System.String? Output
        // GraphQL -> output: String (scalar)
        [JsonProperty("output")]
        public System.String? Output { get; set; }

        //      C# -> CdmFindBadDiskResultType? Result
        // GraphQL -> result: CdmFindBadDiskResultType! (enum)
        [JsonProperty("result")]
        public CdmFindBadDiskResultType? Result { get; set; }

        #endregion

    #region methods

    public UpdateBadDiskLedStatusReply Set(
        System.String? Output = null,
        CdmFindBadDiskResultType? Result = null
    ) 
    {
        if ( Output != null ) {
            this.Output = Output;
        }
        if ( Result != null ) {
            this.Result = Result;
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
            //      C# -> System.String? Output
            // GraphQL -> output: String (scalar)
            if (this.Output != null)
            {
                 s += ind + "output\n";

            }
            //      C# -> CdmFindBadDiskResultType? Result
            // GraphQL -> result: CdmFindBadDiskResultType! (enum)
            if (this.Result != null)
            {
                 s += ind + "result\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Output
            // GraphQL -> output: String (scalar)
            if (this.Output == null && Exploration.Includes(parent + ".output$"))
            {
                this.Output = new System.String("FETCH");
            }
            //      C# -> CdmFindBadDiskResultType? Result
            // GraphQL -> result: CdmFindBadDiskResultType! (enum)
            if (this.Result == null && Exploration.Includes(parent + ".result$"))
            {
                this.Result = new CdmFindBadDiskResultType();
            }
        }


    #endregion

    } // class UpdateBadDiskLedStatusReply
    #endregion

    public static class ListUpdateBadDiskLedStatusReplyExtensions
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
            this List<UpdateBadDiskLedStatusReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<UpdateBadDiskLedStatusReply> list, 
            String parent = "")
        {
            var item = new UpdateBadDiskLedStatusReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types