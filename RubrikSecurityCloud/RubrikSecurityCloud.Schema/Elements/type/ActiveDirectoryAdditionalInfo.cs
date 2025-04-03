// ActiveDirectoryAdditionalInfo.cs
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
    #region ActiveDirectoryAdditionalInfo
    public class ActiveDirectoryAdditionalInfo: BaseType
    {
        #region members

        //      C# -> List<System.String>? ForestDomains
        // GraphQL -> forestDomains: [String!]! (scalar)
        [JsonProperty("forestDomains")]
        public List<System.String>? ForestDomains { get; set; }

        //      C# -> System.String? ForestId
        // GraphQL -> forestId: String (scalar)
        [JsonProperty("forestId")]
        public System.String? ForestId { get; set; }

        //      C# -> System.String? HostDomainId
        // GraphQL -> hostDomainId: String (scalar)
        [JsonProperty("hostDomainId")]
        public System.String? HostDomainId { get; set; }

        //      C# -> System.String? HostDomainName
        // GraphQL -> hostDomainName: String (scalar)
        [JsonProperty("hostDomainName")]
        public System.String? HostDomainName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ActiveDirectoryAdditionalInfo";
    }

    public ActiveDirectoryAdditionalInfo Set(
        List<System.String>? ForestDomains = null,
        System.String? ForestId = null,
        System.String? HostDomainId = null,
        System.String? HostDomainName = null
    ) 
    {
        if ( ForestDomains != null ) {
            this.ForestDomains = ForestDomains;
        }
        if ( ForestId != null ) {
            this.ForestId = ForestId;
        }
        if ( HostDomainId != null ) {
            this.HostDomainId = HostDomainId;
        }
        if ( HostDomainName != null ) {
            this.HostDomainName = HostDomainName;
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
        //      C# -> List<System.String>? ForestDomains
        // GraphQL -> forestDomains: [String!]! (scalar)
        if (this.ForestDomains != null) {
            if (conf.Flat) {
                s += conf.Prefix + "forestDomains\n" ;
            } else {
                s += ind + "forestDomains\n" ;
            }
        }
        //      C# -> System.String? ForestId
        // GraphQL -> forestId: String (scalar)
        if (this.ForestId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "forestId\n" ;
            } else {
                s += ind + "forestId\n" ;
            }
        }
        //      C# -> System.String? HostDomainId
        // GraphQL -> hostDomainId: String (scalar)
        if (this.HostDomainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostDomainId\n" ;
            } else {
                s += ind + "hostDomainId\n" ;
            }
        }
        //      C# -> System.String? HostDomainName
        // GraphQL -> hostDomainName: String (scalar)
        if (this.HostDomainName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostDomainName\n" ;
            } else {
                s += ind + "hostDomainName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<System.String>? ForestDomains
        // GraphQL -> forestDomains: [String!]! (scalar)
        if (ec.Includes("forestDomains",true))
        {
            if(this.ForestDomains == null) {

                this.ForestDomains = new List<System.String>();

            } else {


            }
        }
        else if (this.ForestDomains != null && ec.Excludes("forestDomains",true))
        {
            this.ForestDomains = null;
        }
        //      C# -> System.String? ForestId
        // GraphQL -> forestId: String (scalar)
        if (ec.Includes("forestId",true))
        {
            if(this.ForestId == null) {

                this.ForestId = "FETCH";

            } else {


            }
        }
        else if (this.ForestId != null && ec.Excludes("forestId",true))
        {
            this.ForestId = null;
        }
        //      C# -> System.String? HostDomainId
        // GraphQL -> hostDomainId: String (scalar)
        if (ec.Includes("hostDomainId",true))
        {
            if(this.HostDomainId == null) {

                this.HostDomainId = "FETCH";

            } else {


            }
        }
        else if (this.HostDomainId != null && ec.Excludes("hostDomainId",true))
        {
            this.HostDomainId = null;
        }
        //      C# -> System.String? HostDomainName
        // GraphQL -> hostDomainName: String (scalar)
        if (ec.Includes("hostDomainName",true))
        {
            if(this.HostDomainName == null) {

                this.HostDomainName = "FETCH";

            } else {


            }
        }
        else if (this.HostDomainName != null && ec.Excludes("hostDomainName",true))
        {
            this.HostDomainName = null;
        }
    }


    #endregion

    } // class ActiveDirectoryAdditionalInfo
    
    #endregion

    public static class ListActiveDirectoryAdditionalInfoExtensions
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
            this List<ActiveDirectoryAdditionalInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ActiveDirectoryAdditionalInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ActiveDirectoryAdditionalInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ActiveDirectoryAdditionalInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ActiveDirectoryAdditionalInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types