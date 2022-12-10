// GetSchemaResponse.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:17.
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
    #region GetSchemaResponse
    public class GetSchemaResponse: IFragment
    {
        #region members
        //      C# -> System.String? Message
        // GraphQL -> message: String (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> System.Int64? ReturnCode
        // GraphQL -> returnCode: Long (scalar)
        [JsonProperty("returnCode")]
        public System.Int64? ReturnCode { get; set; }

        //      C# -> System.Boolean? Status
        // GraphQL -> status: Boolean (scalar)
        [JsonProperty("status")]
        public System.Boolean? Status { get; set; }

        //      C# -> CassandraSchemaObject? Data
        // GraphQL -> data: CassandraSchemaObject (type)
        [JsonProperty("data")]
        public CassandraSchemaObject? Data { get; set; }

        #endregion

    #region methods

    public GetSchemaResponse Set(
        System.String? Message = null,
        System.Int64? ReturnCode = null,
        System.Boolean? Status = null,
        CassandraSchemaObject? Data = null
    ) 
    {
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( ReturnCode != null ) {
            this.ReturnCode = ReturnCode;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Data != null ) {
            this.Data = Data;
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
            //      C# -> System.String? Message
            // GraphQL -> message: String (scalar)
            if (this.Message != null)
            {
                 s += ind + "message\n";

            }
            //      C# -> System.Int64? ReturnCode
            // GraphQL -> returnCode: Long (scalar)
            if (this.ReturnCode != null)
            {
                 s += ind + "returnCode\n";

            }
            //      C# -> System.Boolean? Status
            // GraphQL -> status: Boolean (scalar)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            //      C# -> CassandraSchemaObject? Data
            // GraphQL -> data: CassandraSchemaObject (type)
            if (this.Data != null)
            {
                 s += ind + "data\n";

                 s += ind + "{\n" + 
                 this.Data.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Message
            // GraphQL -> message: String (scalar)
            if (this.Message == null && Exploration.Includes(parent + ".message$"))
            {
                this.Message = new System.String("FETCH");
            }
            //      C# -> System.Int64? ReturnCode
            // GraphQL -> returnCode: Long (scalar)
            if (this.ReturnCode == null && Exploration.Includes(parent + ".returnCode$"))
            {
                this.ReturnCode = new System.Int64();
            }
            //      C# -> System.Boolean? Status
            // GraphQL -> status: Boolean (scalar)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new System.Boolean();
            }
            //      C# -> CassandraSchemaObject? Data
            // GraphQL -> data: CassandraSchemaObject (type)
            if (this.Data == null && Exploration.Includes(parent + ".data"))
            {
                this.Data = new CassandraSchemaObject();
                this.Data.ApplyExploratoryFragment(parent + ".data");
            }
        }


    #endregion

    } // class GetSchemaResponse
    #endregion

    public static class ListGetSchemaResponseExtensions
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
            this List<GetSchemaResponse> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<GetSchemaResponse> list, 
            String parent = "")
        {
            var item = new GetSchemaResponse();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types