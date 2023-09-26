// LookupAccountReply.cs
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
    #region LookupAccountReply
    public class LookupAccountReply: BaseType
    {
        #region members

        //      C# -> AccountState? AccountState
        // GraphQL -> accountState: AccountState! (enum)
        [JsonProperty("accountState")]
        public AccountState? AccountState { get; set; }

        //      C# -> AccountType? AccountType
        // GraphQL -> accountType: AccountType! (enum)
        [JsonProperty("accountType")]
        public AccountType? AccountType { get; set; }

        //      C# -> DateTime? AccountExpiryDate
        // GraphQL -> accountExpiryDate: DateTime (scalar)
        [JsonProperty("accountExpiryDate")]
        public DateTime? AccountExpiryDate { get; set; }

        //      C# -> System.Int64? AccountHoldLength
        // GraphQL -> accountHoldLength: Long! (scalar)
        [JsonProperty("accountHoldLength")]
        public System.Int64? AccountHoldLength { get; set; }

        //      C# -> DateTime? AccountStateUpdatedAt
        // GraphQL -> accountStateUpdatedAt: DateTime (scalar)
        [JsonProperty("accountStateUpdatedAt")]
        public DateTime? AccountStateUpdatedAt { get; set; }

        //      C# -> System.Int64? HoldWarningLength
        // GraphQL -> holdWarningLength: Long! (scalar)
        [JsonProperty("holdWarningLength")]
        public System.Int64? HoldWarningLength { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "LookupAccountReply";
    }

    public LookupAccountReply Set(
        AccountState? AccountState = null,
        AccountType? AccountType = null,
        DateTime? AccountExpiryDate = null,
        System.Int64? AccountHoldLength = null,
        DateTime? AccountStateUpdatedAt = null,
        System.Int64? HoldWarningLength = null
    ) 
    {
        if ( AccountState != null ) {
            this.AccountState = AccountState;
        }
        if ( AccountType != null ) {
            this.AccountType = AccountType;
        }
        if ( AccountExpiryDate != null ) {
            this.AccountExpiryDate = AccountExpiryDate;
        }
        if ( AccountHoldLength != null ) {
            this.AccountHoldLength = AccountHoldLength;
        }
        if ( AccountStateUpdatedAt != null ) {
            this.AccountStateUpdatedAt = AccountStateUpdatedAt;
        }
        if ( HoldWarningLength != null ) {
            this.HoldWarningLength = HoldWarningLength;
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
        //      C# -> AccountState? AccountState
        // GraphQL -> accountState: AccountState! (enum)
        if (this.AccountState != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accountState\n" ;
            } else {
                s += ind + "accountState\n" ;
            }
        }
        //      C# -> AccountType? AccountType
        // GraphQL -> accountType: AccountType! (enum)
        if (this.AccountType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accountType\n" ;
            } else {
                s += ind + "accountType\n" ;
            }
        }
        //      C# -> DateTime? AccountExpiryDate
        // GraphQL -> accountExpiryDate: DateTime (scalar)
        if (this.AccountExpiryDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accountExpiryDate\n" ;
            } else {
                s += ind + "accountExpiryDate\n" ;
            }
        }
        //      C# -> System.Int64? AccountHoldLength
        // GraphQL -> accountHoldLength: Long! (scalar)
        if (this.AccountHoldLength != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accountHoldLength\n" ;
            } else {
                s += ind + "accountHoldLength\n" ;
            }
        }
        //      C# -> DateTime? AccountStateUpdatedAt
        // GraphQL -> accountStateUpdatedAt: DateTime (scalar)
        if (this.AccountStateUpdatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accountStateUpdatedAt\n" ;
            } else {
                s += ind + "accountStateUpdatedAt\n" ;
            }
        }
        //      C# -> System.Int64? HoldWarningLength
        // GraphQL -> holdWarningLength: Long! (scalar)
        if (this.HoldWarningLength != null) {
            if (conf.Flat) {
                s += conf.Prefix + "holdWarningLength\n" ;
            } else {
                s += ind + "holdWarningLength\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AccountState? AccountState
        // GraphQL -> accountState: AccountState! (enum)
        if (ec.Includes("accountState",true))
        {
            if(this.AccountState == null) {

                this.AccountState = new AccountState();

            } else {


            }
        }
        else if (this.AccountState != null && ec.Excludes("accountState",true))
        {
            this.AccountState = null;
        }
        //      C# -> AccountType? AccountType
        // GraphQL -> accountType: AccountType! (enum)
        if (ec.Includes("accountType",true))
        {
            if(this.AccountType == null) {

                this.AccountType = new AccountType();

            } else {


            }
        }
        else if (this.AccountType != null && ec.Excludes("accountType",true))
        {
            this.AccountType = null;
        }
        //      C# -> DateTime? AccountExpiryDate
        // GraphQL -> accountExpiryDate: DateTime (scalar)
        if (ec.Includes("accountExpiryDate",true))
        {
            if(this.AccountExpiryDate == null) {

                this.AccountExpiryDate = new DateTime();

            } else {


            }
        }
        else if (this.AccountExpiryDate != null && ec.Excludes("accountExpiryDate",true))
        {
            this.AccountExpiryDate = null;
        }
        //      C# -> System.Int64? AccountHoldLength
        // GraphQL -> accountHoldLength: Long! (scalar)
        if (ec.Includes("accountHoldLength",true))
        {
            if(this.AccountHoldLength == null) {

                this.AccountHoldLength = new System.Int64();

            } else {


            }
        }
        else if (this.AccountHoldLength != null && ec.Excludes("accountHoldLength",true))
        {
            this.AccountHoldLength = null;
        }
        //      C# -> DateTime? AccountStateUpdatedAt
        // GraphQL -> accountStateUpdatedAt: DateTime (scalar)
        if (ec.Includes("accountStateUpdatedAt",true))
        {
            if(this.AccountStateUpdatedAt == null) {

                this.AccountStateUpdatedAt = new DateTime();

            } else {


            }
        }
        else if (this.AccountStateUpdatedAt != null && ec.Excludes("accountStateUpdatedAt",true))
        {
            this.AccountStateUpdatedAt = null;
        }
        //      C# -> System.Int64? HoldWarningLength
        // GraphQL -> holdWarningLength: Long! (scalar)
        if (ec.Includes("holdWarningLength",true))
        {
            if(this.HoldWarningLength == null) {

                this.HoldWarningLength = new System.Int64();

            } else {


            }
        }
        else if (this.HoldWarningLength != null && ec.Excludes("holdWarningLength",true))
        {
            this.HoldWarningLength = null;
        }
    }


    #endregion

    } // class LookupAccountReply
    
    #endregion

    public static class ListLookupAccountReplyExtensions
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
            this List<LookupAccountReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<LookupAccountReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new LookupAccountReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<LookupAccountReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types