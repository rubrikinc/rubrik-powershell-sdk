// CreateGuestCredentialReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:09.
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
    #region CreateGuestCredentialReply
    public class CreateGuestCredentialReply: IFragment
    {
        #region members
        //      C# -> System.String? Domain
        // GraphQL -> domain: String (scalar)
        [JsonProperty("domain")]
        public System.String? Domain { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> BaseGuestCredentialDetail? BaseGuestCredentialDetail
        // GraphQL -> baseGuestCredentialDetail: BaseGuestCredentialDetail (type)
        [JsonProperty("baseGuestCredentialDetail")]
        public BaseGuestCredentialDetail? BaseGuestCredentialDetail { get; set; }

        #endregion

    #region methods

    public CreateGuestCredentialReply Set(
        System.String? Domain = null,
        System.String? Id = null,
        BaseGuestCredentialDetail? BaseGuestCredentialDetail = null
    ) 
    {
        if ( Domain != null ) {
            this.Domain = Domain;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( BaseGuestCredentialDetail != null ) {
            this.BaseGuestCredentialDetail = BaseGuestCredentialDetail;
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
            //      C# -> System.String? Domain
            // GraphQL -> domain: String (scalar)
            if (this.Domain != null)
            {
                 s += ind + "domain\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> BaseGuestCredentialDetail? BaseGuestCredentialDetail
            // GraphQL -> baseGuestCredentialDetail: BaseGuestCredentialDetail (type)
            if (this.BaseGuestCredentialDetail != null)
            {
                 s += ind + "baseGuestCredentialDetail\n";

                 s += ind + "{\n" + 
                 this.BaseGuestCredentialDetail.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Domain
            // GraphQL -> domain: String (scalar)
            if (this.Domain == null && Exploration.Includes(parent + ".domain$"))
            {
                this.Domain = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> BaseGuestCredentialDetail? BaseGuestCredentialDetail
            // GraphQL -> baseGuestCredentialDetail: BaseGuestCredentialDetail (type)
            if (this.BaseGuestCredentialDetail == null && Exploration.Includes(parent + ".baseGuestCredentialDetail"))
            {
                this.BaseGuestCredentialDetail = new BaseGuestCredentialDetail();
                this.BaseGuestCredentialDetail.ApplyExploratoryFragment(parent + ".baseGuestCredentialDetail");
            }
        }


    #endregion

    } // class CreateGuestCredentialReply
    #endregion

    public static class ListCreateGuestCredentialReplyExtensions
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
            this List<CreateGuestCredentialReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CreateGuestCredentialReply> list, 
            String parent = "")
        {
            var item = new CreateGuestCredentialReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types