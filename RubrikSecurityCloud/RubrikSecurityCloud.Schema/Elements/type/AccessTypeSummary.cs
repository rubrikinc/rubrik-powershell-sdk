// AccessTypeSummary.cs
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
    #region AccessTypeSummary
    public class AccessTypeSummary: BaseType
    {
        #region members

        //      C# -> List<System.String>? AccessViaGroupIds
        // GraphQL -> accessViaGroupIds: [String!]! (scalar)
        [JsonProperty("accessViaGroupIds")]
        public List<System.String>? AccessViaGroupIds { get; set; }

        //      C# -> List<System.String>? AccessViaRoleIds
        // GraphQL -> accessViaRoleIds: [String!]! (scalar)
        [JsonProperty("accessViaRoleIds")]
        public List<System.String>? AccessViaRoleIds { get; set; }

        //      C# -> System.Int32? DirectAccessCount
        // GraphQL -> directAccessCount: Int! (scalar)
        [JsonProperty("directAccessCount")]
        public System.Int32? DirectAccessCount { get; set; }

        //      C# -> System.Int32? IndirectAccessCount
        // GraphQL -> indirectAccessCount: Int! (scalar)
        [JsonProperty("indirectAccessCount")]
        public System.Int32? IndirectAccessCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AccessTypeSummary";
    }

    public AccessTypeSummary Set(
        List<System.String>? AccessViaGroupIds = null,
        List<System.String>? AccessViaRoleIds = null,
        System.Int32? DirectAccessCount = null,
        System.Int32? IndirectAccessCount = null
    ) 
    {
        if ( AccessViaGroupIds != null ) {
            this.AccessViaGroupIds = AccessViaGroupIds;
        }
        if ( AccessViaRoleIds != null ) {
            this.AccessViaRoleIds = AccessViaRoleIds;
        }
        if ( DirectAccessCount != null ) {
            this.DirectAccessCount = DirectAccessCount;
        }
        if ( IndirectAccessCount != null ) {
            this.IndirectAccessCount = IndirectAccessCount;
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
        //      C# -> List<System.String>? AccessViaGroupIds
        // GraphQL -> accessViaGroupIds: [String!]! (scalar)
        if (this.AccessViaGroupIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accessViaGroupIds\n" ;
            } else {
                s += ind + "accessViaGroupIds\n" ;
            }
        }
        //      C# -> List<System.String>? AccessViaRoleIds
        // GraphQL -> accessViaRoleIds: [String!]! (scalar)
        if (this.AccessViaRoleIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accessViaRoleIds\n" ;
            } else {
                s += ind + "accessViaRoleIds\n" ;
            }
        }
        //      C# -> System.Int32? DirectAccessCount
        // GraphQL -> directAccessCount: Int! (scalar)
        if (this.DirectAccessCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "directAccessCount\n" ;
            } else {
                s += ind + "directAccessCount\n" ;
            }
        }
        //      C# -> System.Int32? IndirectAccessCount
        // GraphQL -> indirectAccessCount: Int! (scalar)
        if (this.IndirectAccessCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "indirectAccessCount\n" ;
            } else {
                s += ind + "indirectAccessCount\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<System.String>? AccessViaGroupIds
        // GraphQL -> accessViaGroupIds: [String!]! (scalar)
        if (ec.Includes("accessViaGroupIds",true))
        {
            if(this.AccessViaGroupIds == null) {

                this.AccessViaGroupIds = new List<System.String>();

            } else {


            }
        }
        else if (this.AccessViaGroupIds != null && ec.Excludes("accessViaGroupIds",true))
        {
            this.AccessViaGroupIds = null;
        }
        //      C# -> List<System.String>? AccessViaRoleIds
        // GraphQL -> accessViaRoleIds: [String!]! (scalar)
        if (ec.Includes("accessViaRoleIds",true))
        {
            if(this.AccessViaRoleIds == null) {

                this.AccessViaRoleIds = new List<System.String>();

            } else {


            }
        }
        else if (this.AccessViaRoleIds != null && ec.Excludes("accessViaRoleIds",true))
        {
            this.AccessViaRoleIds = null;
        }
        //      C# -> System.Int32? DirectAccessCount
        // GraphQL -> directAccessCount: Int! (scalar)
        if (ec.Includes("directAccessCount",true))
        {
            if(this.DirectAccessCount == null) {

                this.DirectAccessCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.DirectAccessCount != null && ec.Excludes("directAccessCount",true))
        {
            this.DirectAccessCount = null;
        }
        //      C# -> System.Int32? IndirectAccessCount
        // GraphQL -> indirectAccessCount: Int! (scalar)
        if (ec.Includes("indirectAccessCount",true))
        {
            if(this.IndirectAccessCount == null) {

                this.IndirectAccessCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.IndirectAccessCount != null && ec.Excludes("indirectAccessCount",true))
        {
            this.IndirectAccessCount = null;
        }
    }


    #endregion

    } // class AccessTypeSummary
    
    #endregion

    public static class ListAccessTypeSummaryExtensions
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
            this List<AccessTypeSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AccessTypeSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AccessTypeSummary> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AccessTypeSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AccessTypeSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types