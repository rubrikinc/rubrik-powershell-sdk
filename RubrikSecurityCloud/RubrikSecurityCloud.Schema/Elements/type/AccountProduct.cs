// AccountProduct.cs
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
    #region AccountProduct
    public class AccountProduct: IFragment
    {
        #region members
        //      C# -> System.String? Account
        // GraphQL -> account: String! (scalar)
        [JsonProperty("account")]
        public System.String? Account { get; set; }

        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime! (scalar)
        [JsonProperty("expirationDate")]
        public DateTime? ExpirationDate { get; set; }

        //      C# -> ProductName? Name
        // GraphQL -> name: ProductName! (enum)
        [JsonProperty("name")]
        public ProductName? Name { get; set; }

        //      C# -> ProductState? State
        // GraphQL -> state: ProductState! (enum)
        [JsonProperty("state")]
        public ProductState? State { get; set; }

        //      C# -> ProductType? Type
        // GraphQL -> type: ProductType! (enum)
        [JsonProperty("type")]
        public ProductType? Type { get; set; }

        #endregion

    #region methods

    public AccountProduct Set(
        System.String? Account = null,
        DateTime? ExpirationDate = null,
        ProductName? Name = null,
        ProductState? State = null,
        ProductType? Type = null
    ) 
    {
        if ( Account != null ) {
            this.Account = Account;
        }
        if ( ExpirationDate != null ) {
            this.ExpirationDate = ExpirationDate;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( State != null ) {
            this.State = State;
        }
        if ( Type != null ) {
            this.Type = Type;
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
            //      C# -> System.String? Account
            // GraphQL -> account: String! (scalar)
            if (this.Account != null)
            {
                 s += ind + "account\n";

            }
            //      C# -> DateTime? ExpirationDate
            // GraphQL -> expirationDate: DateTime! (scalar)
            if (this.ExpirationDate != null)
            {
                 s += ind + "expirationDate\n";

            }
            //      C# -> ProductName? Name
            // GraphQL -> name: ProductName! (enum)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> ProductState? State
            // GraphQL -> state: ProductState! (enum)
            if (this.State != null)
            {
                 s += ind + "state\n";

            }
            //      C# -> ProductType? Type
            // GraphQL -> type: ProductType! (enum)
            if (this.Type != null)
            {
                 s += ind + "type\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Account
            // GraphQL -> account: String! (scalar)
            if (this.Account == null && Exploration.Includes(parent + ".account$"))
            {
                this.Account = new System.String("FETCH");
            }
            //      C# -> DateTime? ExpirationDate
            // GraphQL -> expirationDate: DateTime! (scalar)
            if (this.ExpirationDate == null && Exploration.Includes(parent + ".expirationDate$"))
            {
                this.ExpirationDate = new DateTime();
            }
            //      C# -> ProductName? Name
            // GraphQL -> name: ProductName! (enum)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new ProductName();
            }
            //      C# -> ProductState? State
            // GraphQL -> state: ProductState! (enum)
            if (this.State == null && Exploration.Includes(parent + ".state$"))
            {
                this.State = new ProductState();
            }
            //      C# -> ProductType? Type
            // GraphQL -> type: ProductType! (enum)
            if (this.Type == null && Exploration.Includes(parent + ".type$"))
            {
                this.Type = new ProductType();
            }
        }


    #endregion

    } // class AccountProduct
    #endregion

    public static class ListAccountProductExtensions
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
            this List<AccountProduct> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AccountProduct> list, 
            String parent = "")
        {
            var item = new AccountProduct();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types