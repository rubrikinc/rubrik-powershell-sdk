// AwsOutpostAccount.cs
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
    #region AwsOutpostAccount
    public class AwsOutpostAccount: BaseType
    {
        #region members

        //      C# -> System.String? ExternalId
        // GraphQL -> externalId: String! (scalar)
        [JsonProperty("externalId")]
        public System.String? ExternalId { get; set; }

        //      C# -> System.String? OutpostAwsNativeId
        // GraphQL -> outpostAwsNativeId: String! (scalar)
        [JsonProperty("outpostAwsNativeId")]
        public System.String? OutpostAwsNativeId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsOutpostAccount";
    }

    public AwsOutpostAccount Set(
        System.String? ExternalId = null,
        System.String? OutpostAwsNativeId = null
    ) 
    {
        if ( ExternalId != null ) {
            this.ExternalId = ExternalId;
        }
        if ( OutpostAwsNativeId != null ) {
            this.OutpostAwsNativeId = OutpostAwsNativeId;
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
        //      C# -> System.String? ExternalId
        // GraphQL -> externalId: String! (scalar)
        if (this.ExternalId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "externalId\n" ;
            } else {
                s += ind + "externalId\n" ;
            }
        }
        //      C# -> System.String? OutpostAwsNativeId
        // GraphQL -> outpostAwsNativeId: String! (scalar)
        if (this.OutpostAwsNativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "outpostAwsNativeId\n" ;
            } else {
                s += ind + "outpostAwsNativeId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ExternalId
        // GraphQL -> externalId: String! (scalar)
        if (ec.Includes("externalId",true))
        {
            if(this.ExternalId == null) {

                this.ExternalId = "FETCH";

            } else {


            }
        }
        else if (this.ExternalId != null && ec.Excludes("externalId",true))
        {
            this.ExternalId = null;
        }
        //      C# -> System.String? OutpostAwsNativeId
        // GraphQL -> outpostAwsNativeId: String! (scalar)
        if (ec.Includes("outpostAwsNativeId",true))
        {
            if(this.OutpostAwsNativeId == null) {

                this.OutpostAwsNativeId = "FETCH";

            } else {


            }
        }
        else if (this.OutpostAwsNativeId != null && ec.Excludes("outpostAwsNativeId",true))
        {
            this.OutpostAwsNativeId = null;
        }
    }


    #endregion

    } // class AwsOutpostAccount
    
    #endregion

    public static class ListAwsOutpostAccountExtensions
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
            this List<AwsOutpostAccount> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsOutpostAccount> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsOutpostAccount> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsOutpostAccount());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsOutpostAccount> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types