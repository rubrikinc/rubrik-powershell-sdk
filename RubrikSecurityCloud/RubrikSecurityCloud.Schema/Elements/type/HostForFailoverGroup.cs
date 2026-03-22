// HostForFailoverGroup.cs
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
    #region HostForFailoverGroup
    public class HostForFailoverGroup: BaseType
    {
        #region members

        //      C# -> HostIneligibilityReason? IneligibilityReason
        // GraphQL -> ineligibilityReason: HostIneligibilityReason! (enum)
        [JsonProperty("ineligibilityReason")]
        public HostIneligibilityReason? IneligibilityReason { get; set; }

        //      C# -> HostRegisterOsType? OsType
        // GraphQL -> osType: HostRegisterOsType! (enum)
        [JsonProperty("osType")]
        public HostRegisterOsType? OsType { get; set; }

        //      C# -> HostConnectivityStatus? RbsStatus
        // GraphQL -> rbsStatus: HostConnectivityStatus! (enum)
        [JsonProperty("rbsStatus")]
        public HostConnectivityStatus? RbsStatus { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsEligible
        // GraphQL -> isEligible: Boolean! (scalar)
        [JsonProperty("isEligible")]
        public System.Boolean? IsEligible { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HostForFailoverGroup";
    }

    public HostForFailoverGroup Set(
        HostIneligibilityReason? IneligibilityReason = null,
        HostRegisterOsType? OsType = null,
        HostConnectivityStatus? RbsStatus = null,
        System.String? Id = null,
        System.Boolean? IsEligible = null,
        System.String? Name = null
    ) 
    {
        if ( IneligibilityReason != null ) {
            this.IneligibilityReason = IneligibilityReason;
        }
        if ( OsType != null ) {
            this.OsType = OsType;
        }
        if ( RbsStatus != null ) {
            this.RbsStatus = RbsStatus;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsEligible != null ) {
            this.IsEligible = IsEligible;
        }
        if ( Name != null ) {
            this.Name = Name;
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
        //      C# -> HostIneligibilityReason? IneligibilityReason
        // GraphQL -> ineligibilityReason: HostIneligibilityReason! (enum)
        if (this.IneligibilityReason != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ineligibilityReason\n" ;
            } else {
                s += ind + "ineligibilityReason\n" ;
            }
        }
        //      C# -> HostRegisterOsType? OsType
        // GraphQL -> osType: HostRegisterOsType! (enum)
        if (this.OsType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "osType\n" ;
            } else {
                s += ind + "osType\n" ;
            }
        }
        //      C# -> HostConnectivityStatus? RbsStatus
        // GraphQL -> rbsStatus: HostConnectivityStatus! (enum)
        if (this.RbsStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rbsStatus\n" ;
            } else {
                s += ind + "rbsStatus\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsEligible
        // GraphQL -> isEligible: Boolean! (scalar)
        if (this.IsEligible != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isEligible\n" ;
            } else {
                s += ind + "isEligible\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> HostIneligibilityReason? IneligibilityReason
        // GraphQL -> ineligibilityReason: HostIneligibilityReason! (enum)
        if (ec.Includes("ineligibilityReason",true))
        {
            if(this.IneligibilityReason == null) {

                this.IneligibilityReason = new HostIneligibilityReason();

            } else {


            }
        }
        else if (this.IneligibilityReason != null && ec.Excludes("ineligibilityReason",true))
        {
            this.IneligibilityReason = null;
        }
        //      C# -> HostRegisterOsType? OsType
        // GraphQL -> osType: HostRegisterOsType! (enum)
        if (ec.Includes("osType",true))
        {
            if(this.OsType == null) {

                this.OsType = new HostRegisterOsType();

            } else {


            }
        }
        else if (this.OsType != null && ec.Excludes("osType",true))
        {
            this.OsType = null;
        }
        //      C# -> HostConnectivityStatus? RbsStatus
        // GraphQL -> rbsStatus: HostConnectivityStatus! (enum)
        if (ec.Includes("rbsStatus",true))
        {
            if(this.RbsStatus == null) {

                this.RbsStatus = new HostConnectivityStatus();

            } else {


            }
        }
        else if (this.RbsStatus != null && ec.Excludes("rbsStatus",true))
        {
            this.RbsStatus = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Boolean? IsEligible
        // GraphQL -> isEligible: Boolean! (scalar)
        if (ec.Includes("isEligible",true))
        {
            if(this.IsEligible == null) {

                this.IsEligible = true;

            } else {


            }
        }
        else if (this.IsEligible != null && ec.Excludes("isEligible",true))
        {
            this.IsEligible = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
    }


    #endregion

    } // class HostForFailoverGroup
    
    #endregion

    public static class ListHostForFailoverGroupExtensions
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
            this List<HostForFailoverGroup> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HostForFailoverGroup> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HostForFailoverGroup> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HostForFailoverGroup());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HostForFailoverGroup> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types