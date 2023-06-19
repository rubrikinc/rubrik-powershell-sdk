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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region AccountProduct
    public class AccountProduct: BaseType
    {
        #region members

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

        //      C# -> System.String? Account
        // GraphQL -> account: String! (scalar)
        [JsonProperty("account")]
        public System.String? Account { get; set; }

        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime! (scalar)
        [JsonProperty("expirationDate")]
        public DateTime? ExpirationDate { get; set; }


        #endregion

    #region methods

    public AccountProduct Set(
        ProductName? Name = null,
        ProductState? State = null,
        ProductType? Type = null,
        System.String? Account = null,
        DateTime? ExpirationDate = null
    ) 
    {
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( State != null ) {
            this.State = State;
        }
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( Account != null ) {
            this.Account = Account;
        }
        if ( ExpirationDate != null ) {
            this.ExpirationDate = ExpirationDate;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> ProductName? Name
        // GraphQL -> name: ProductName! (enum)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> ProductState? State
        // GraphQL -> state: ProductState! (enum)
        if (this.State != null) {
            s += ind + "state\n" ;
        }
        //      C# -> ProductType? Type
        // GraphQL -> type: ProductType! (enum)
        if (this.Type != null) {
            s += ind + "type\n" ;
        }
        //      C# -> System.String? Account
        // GraphQL -> account: String! (scalar)
        if (this.Account != null) {
            s += ind + "account\n" ;
        }
        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime! (scalar)
        if (this.ExpirationDate != null) {
            s += ind + "expirationDate\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ProductName? Name
        // GraphQL -> name: ProductName! (enum)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = new ProductName();
        }
        //      C# -> ProductState? State
        // GraphQL -> state: ProductState! (enum)
        if (this.State == null && Exploration.Includes(parent + ".state", true))
        {
            this.State = new ProductState();
        }
        //      C# -> ProductType? Type
        // GraphQL -> type: ProductType! (enum)
        if (this.Type == null && Exploration.Includes(parent + ".type", true))
        {
            this.Type = new ProductType();
        }
        //      C# -> System.String? Account
        // GraphQL -> account: String! (scalar)
        if (this.Account == null && Exploration.Includes(parent + ".account", true))
        {
            this.Account = "FETCH";
        }
        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime! (scalar)
        if (this.ExpirationDate == null && Exploration.Includes(parent + ".expirationDate", true))
        {
            this.ExpirationDate = new DateTime();
        }
    }


    #endregion

    } // class AccountProduct
    
    #endregion

    public static class ListAccountProductExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<AccountProduct> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AccountProduct> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AccountProduct());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types