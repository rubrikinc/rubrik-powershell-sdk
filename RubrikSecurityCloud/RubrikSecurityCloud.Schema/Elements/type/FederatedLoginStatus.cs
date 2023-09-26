// FederatedLoginStatus.cs
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
    #region FederatedLoginStatus
    public class FederatedLoginStatus: BaseType
    {
        #region members

        //      C# -> System.Boolean? Enabled
        // GraphQL -> enabled: Boolean! (scalar)
        [JsonProperty("enabled")]
        public System.Boolean? Enabled { get; set; }

        //      C# -> System.Boolean? InventoryCardEnabled
        // GraphQL -> inventoryCardEnabled: Boolean! (scalar)
        [JsonProperty("inventoryCardEnabled")]
        public System.Boolean? InventoryCardEnabled { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FederatedLoginStatus";
    }

    public FederatedLoginStatus Set(
        System.Boolean? Enabled = null,
        System.Boolean? InventoryCardEnabled = null
    ) 
    {
        if ( Enabled != null ) {
            this.Enabled = Enabled;
        }
        if ( InventoryCardEnabled != null ) {
            this.InventoryCardEnabled = InventoryCardEnabled;
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
        //      C# -> System.Boolean? Enabled
        // GraphQL -> enabled: Boolean! (scalar)
        if (this.Enabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "enabled\n" ;
            } else {
                s += ind + "enabled\n" ;
            }
        }
        //      C# -> System.Boolean? InventoryCardEnabled
        // GraphQL -> inventoryCardEnabled: Boolean! (scalar)
        if (this.InventoryCardEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "inventoryCardEnabled\n" ;
            } else {
                s += ind + "inventoryCardEnabled\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? Enabled
        // GraphQL -> enabled: Boolean! (scalar)
        if (ec.Includes("enabled",true))
        {
            if(this.Enabled == null) {

                this.Enabled = true;

            } else {


            }
        }
        else if (this.Enabled != null && ec.Excludes("enabled",true))
        {
            this.Enabled = null;
        }
        //      C# -> System.Boolean? InventoryCardEnabled
        // GraphQL -> inventoryCardEnabled: Boolean! (scalar)
        if (ec.Includes("inventoryCardEnabled",true))
        {
            if(this.InventoryCardEnabled == null) {

                this.InventoryCardEnabled = true;

            } else {


            }
        }
        else if (this.InventoryCardEnabled != null && ec.Excludes("inventoryCardEnabled",true))
        {
            this.InventoryCardEnabled = null;
        }
    }


    #endregion

    } // class FederatedLoginStatus
    
    #endregion

    public static class ListFederatedLoginStatusExtensions
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
            this List<FederatedLoginStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FederatedLoginStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FederatedLoginStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FederatedLoginStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types