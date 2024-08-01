// MigrationCustomer.cs
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
    #region MigrationCustomer
    public class MigrationCustomer: BaseType
    {
        #region members

        //      C# -> MigrationCustomerType? CustomerType
        // GraphQL -> customerType: MigrationCustomerType! (enum)
        [JsonProperty("customerType")]
        public MigrationCustomerType? CustomerType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MigrationCustomer";
    }

    public MigrationCustomer Set(
        MigrationCustomerType? CustomerType = null
    ) 
    {
        if ( CustomerType != null ) {
            this.CustomerType = CustomerType;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> MigrationCustomerType? CustomerType
        // GraphQL -> customerType: MigrationCustomerType! (enum)
        if (this.CustomerType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "customerType\n" ;
            } else {
                s += ind + "customerType\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> MigrationCustomerType? CustomerType
        // GraphQL -> customerType: MigrationCustomerType! (enum)
        if (ec.Includes("customerType",true))
        {
            if(this.CustomerType == null) {

                this.CustomerType = new MigrationCustomerType();

            } else {


            }
        }
        else if (this.CustomerType != null && ec.Excludes("customerType",true))
        {
            this.CustomerType = null;
        }
    }


    #endregion

    } // class MigrationCustomer
    
    #endregion

    public static class ListMigrationCustomerExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<MigrationCustomer> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MigrationCustomer> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MigrationCustomer> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MigrationCustomer());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MigrationCustomer> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types