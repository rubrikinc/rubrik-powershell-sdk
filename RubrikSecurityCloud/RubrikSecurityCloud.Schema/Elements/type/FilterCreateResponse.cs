// FilterCreateResponse.cs
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
    #region FilterCreateResponse
    public class FilterCreateResponse: IFragment
    {
        #region members
        //      C# -> System.String? Condition
        // GraphQL -> condition: String! (scalar)
        [JsonProperty("condition")]
        public System.String? Condition { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        [JsonProperty("asyncRequestStatus")]
        public AsyncRequestStatus? AsyncRequestStatus { get; set; }

        #endregion

    #region methods

    public FilterCreateResponse Set(
        System.String? Condition = null,
        System.String? Id = null,
        System.String? Name = null,
        AsyncRequestStatus? AsyncRequestStatus = null
    ) 
    {
        if ( Condition != null ) {
            this.Condition = Condition;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
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
            //      C# -> System.String? Condition
            // GraphQL -> condition: String! (scalar)
            if (this.Condition != null)
            {
                 s += ind + "condition\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

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
            //      C# -> System.String? Condition
            // GraphQL -> condition: String! (scalar)
            if (this.Condition == null && Exploration.Includes(parent + ".condition$"))
            {
                this.Condition = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
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

    } // class FilterCreateResponse
    #endregion

    public static class ListFilterCreateResponseExtensions
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
            this List<FilterCreateResponse> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<FilterCreateResponse> list, 
            String parent = "")
        {
            var item = new FilterCreateResponse();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types