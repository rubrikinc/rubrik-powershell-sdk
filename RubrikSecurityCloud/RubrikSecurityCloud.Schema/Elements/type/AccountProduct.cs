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
        // GraphQL -> expirationDate: DateTime (scalar)
        [JsonProperty("expirationDate")]
        public DateTime? ExpirationDate { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AccountProduct";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> ProductName? Name
        // GraphQL -> name: ProductName! (enum)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> ProductState? State
        // GraphQL -> state: ProductState! (enum)
        if (this.State != null) {
            if (conf.Flat) {
                s += conf.Prefix + "state\n" ;
            } else {
                s += ind + "state\n" ;
            }
        }
        //      C# -> ProductType? Type
        // GraphQL -> type: ProductType! (enum)
        if (this.Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "type\n" ;
            } else {
                s += ind + "type\n" ;
            }
        }
        //      C# -> System.String? Account
        // GraphQL -> account: String! (scalar)
        if (this.Account != null) {
            if (conf.Flat) {
                s += conf.Prefix + "account\n" ;
            } else {
                s += ind + "account\n" ;
            }
        }
        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        if (this.ExpirationDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expirationDate\n" ;
            } else {
                s += ind + "expirationDate\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ProductName? Name
        // GraphQL -> name: ProductName! (enum)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = new ProductName();

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> ProductState? State
        // GraphQL -> state: ProductState! (enum)
        if (ec.Includes("state",true))
        {
            if(this.State == null) {

                this.State = new ProductState();

            } else {


            }
        }
        else if (this.State != null && ec.Excludes("state",true))
        {
            this.State = null;
        }
        //      C# -> ProductType? Type
        // GraphQL -> type: ProductType! (enum)
        if (ec.Includes("type",true))
        {
            if(this.Type == null) {

                this.Type = new ProductType();

            } else {


            }
        }
        else if (this.Type != null && ec.Excludes("type",true))
        {
            this.Type = null;
        }
        //      C# -> System.String? Account
        // GraphQL -> account: String! (scalar)
        if (ec.Includes("account",true))
        {
            if(this.Account == null) {

                this.Account = "FETCH";

            } else {


            }
        }
        else if (this.Account != null && ec.Excludes("account",true))
        {
            this.Account = null;
        }
        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        if (ec.Includes("expirationDate",true))
        {
            if(this.ExpirationDate == null) {

                this.ExpirationDate = new DateTime();

            } else {


            }
        }
        else if (this.ExpirationDate != null && ec.Excludes("expirationDate",true))
        {
            this.ExpirationDate = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<AccountProduct> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AccountProduct> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AccountProduct());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AccountProduct> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types