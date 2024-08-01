// M365LicenseEntitlementReply.cs
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
    #region M365LicenseEntitlementReply
    public class M365LicenseEntitlementReply: BaseType
    {
        #region members

        //      C# -> System.Int64? CapacityEntitledInBytes
        // GraphQL -> capacityEntitledInBytes: Long! (scalar)
        [JsonProperty("capacityEntitledInBytes")]
        public System.Int64? CapacityEntitledInBytes { get; set; }

        //      C# -> System.Int64? UsersEntitled
        // GraphQL -> usersEntitled: Long! (scalar)
        [JsonProperty("usersEntitled")]
        public System.Int64? UsersEntitled { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "M365LicenseEntitlementReply";
    }

    public M365LicenseEntitlementReply Set(
        System.Int64? CapacityEntitledInBytes = null,
        System.Int64? UsersEntitled = null
    ) 
    {
        if ( CapacityEntitledInBytes != null ) {
            this.CapacityEntitledInBytes = CapacityEntitledInBytes;
        }
        if ( UsersEntitled != null ) {
            this.UsersEntitled = UsersEntitled;
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
        //      C# -> System.Int64? CapacityEntitledInBytes
        // GraphQL -> capacityEntitledInBytes: Long! (scalar)
        if (this.CapacityEntitledInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "capacityEntitledInBytes\n" ;
            } else {
                s += ind + "capacityEntitledInBytes\n" ;
            }
        }
        //      C# -> System.Int64? UsersEntitled
        // GraphQL -> usersEntitled: Long! (scalar)
        if (this.UsersEntitled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "usersEntitled\n" ;
            } else {
                s += ind + "usersEntitled\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? CapacityEntitledInBytes
        // GraphQL -> capacityEntitledInBytes: Long! (scalar)
        if (ec.Includes("capacityEntitledInBytes",true))
        {
            if(this.CapacityEntitledInBytes == null) {

                this.CapacityEntitledInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.CapacityEntitledInBytes != null && ec.Excludes("capacityEntitledInBytes",true))
        {
            this.CapacityEntitledInBytes = null;
        }
        //      C# -> System.Int64? UsersEntitled
        // GraphQL -> usersEntitled: Long! (scalar)
        if (ec.Includes("usersEntitled",true))
        {
            if(this.UsersEntitled == null) {

                this.UsersEntitled = new System.Int64();

            } else {


            }
        }
        else if (this.UsersEntitled != null && ec.Excludes("usersEntitled",true))
        {
            this.UsersEntitled = null;
        }
    }


    #endregion

    } // class M365LicenseEntitlementReply
    
    #endregion

    public static class ListM365LicenseEntitlementReplyExtensions
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
            this List<M365LicenseEntitlementReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<M365LicenseEntitlementReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<M365LicenseEntitlementReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new M365LicenseEntitlementReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<M365LicenseEntitlementReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types