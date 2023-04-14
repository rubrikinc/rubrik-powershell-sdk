// GetImplicitlyAuthorizedObjectSummariesResponse.cs
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
    #region GetImplicitlyAuthorizedObjectSummariesResponse
    public class GetImplicitlyAuthorizedObjectSummariesResponse: IFragment
    {
        #region members
        //      C# -> List<ObjectSummary>? ObjectSummaries
        // GraphQL -> objectSummaries: [ObjectSummary!]! (type)
        [JsonProperty("objectSummaries")]
        public List<ObjectSummary>? ObjectSummaries { get; set; }

        #endregion

    #region methods

    public GetImplicitlyAuthorizedObjectSummariesResponse Set(
        List<ObjectSummary>? ObjectSummaries = null
    ) 
    {
        if ( ObjectSummaries != null ) {
            this.ObjectSummaries = ObjectSummaries;
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
            //      C# -> List<ObjectSummary>? ObjectSummaries
            // GraphQL -> objectSummaries: [ObjectSummary!]! (type)
            if (this.ObjectSummaries != null)
            {
                 s += ind + "objectSummaries\n";

                 s += ind + "{\n" + 
                 this.ObjectSummaries.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<ObjectSummary>? ObjectSummaries
            // GraphQL -> objectSummaries: [ObjectSummary!]! (type)
            if (this.ObjectSummaries == null && Exploration.Includes(parent + ".objectSummaries"))
            {
                this.ObjectSummaries = new List<ObjectSummary>();
                this.ObjectSummaries.ApplyExploratoryFragment(parent + ".objectSummaries");
            }
        }


    #endregion

    } // class GetImplicitlyAuthorizedObjectSummariesResponse
    #endregion

    public static class ListGetImplicitlyAuthorizedObjectSummariesResponseExtensions
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
            this List<GetImplicitlyAuthorizedObjectSummariesResponse> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<GetImplicitlyAuthorizedObjectSummariesResponse> list, 
            String parent = "")
        {
            var item = new GetImplicitlyAuthorizedObjectSummariesResponse();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types