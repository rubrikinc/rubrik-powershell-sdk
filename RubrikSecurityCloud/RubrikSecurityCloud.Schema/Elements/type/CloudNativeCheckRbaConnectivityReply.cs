// CloudNativeCheckRbaConnectivityReply.cs
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
    #region CloudNativeCheckRbaConnectivityReply
    public class CloudNativeCheckRbaConnectivityReply: IFragment
    {
        #region members
        //      C# -> List<Failure>? Failures
        // GraphQL -> failures: [Failure!]! (type)
        [JsonProperty("failures")]
        public List<Failure>? Failures { get; set; }

        //      C# -> List<Success>? Successes
        // GraphQL -> successes: [Success!]! (type)
        [JsonProperty("successes")]
        public List<Success>? Successes { get; set; }

        #endregion

    #region methods

    public CloudNativeCheckRbaConnectivityReply Set(
        List<Failure>? Failures = null,
        List<Success>? Successes = null
    ) 
    {
        if ( Failures != null ) {
            this.Failures = Failures;
        }
        if ( Successes != null ) {
            this.Successes = Successes;
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
            //      C# -> List<Failure>? Failures
            // GraphQL -> failures: [Failure!]! (type)
            if (this.Failures != null)
            {
                 s += ind + "failures\n";

                 s += ind + "{\n" + 
                 this.Failures.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<Success>? Successes
            // GraphQL -> successes: [Success!]! (type)
            if (this.Successes != null)
            {
                 s += ind + "successes\n";

                 s += ind + "{\n" + 
                 this.Successes.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<Failure>? Failures
            // GraphQL -> failures: [Failure!]! (type)
            if (this.Failures == null && Exploration.Includes(parent + ".failures"))
            {
                this.Failures = new List<Failure>();
                this.Failures.ApplyExploratoryFragment(parent + ".failures");
            }
            //      C# -> List<Success>? Successes
            // GraphQL -> successes: [Success!]! (type)
            if (this.Successes == null && Exploration.Includes(parent + ".successes"))
            {
                this.Successes = new List<Success>();
                this.Successes.ApplyExploratoryFragment(parent + ".successes");
            }
        }


    #endregion

    } // class CloudNativeCheckRbaConnectivityReply
    #endregion

    public static class ListCloudNativeCheckRbaConnectivityReplyExtensions
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
            this List<CloudNativeCheckRbaConnectivityReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CloudNativeCheckRbaConnectivityReply> list, 
            String parent = "")
        {
            var item = new CloudNativeCheckRbaConnectivityReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types