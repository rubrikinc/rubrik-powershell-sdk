// CloudAccountsExocomputeAccountMapping.cs
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
    #region CloudAccountsExocomputeAccountMapping
    public class CloudAccountsExocomputeAccountMapping: BaseType
    {
        #region members

        //      C# -> System.String? ApplicationCloudAccountId
        // GraphQL -> applicationCloudAccountId: UUID! (scalar)
        [JsonProperty("applicationCloudAccountId")]
        public System.String? ApplicationCloudAccountId { get; set; }

        //      C# -> System.String? ExocomputeCloudAccountId
        // GraphQL -> exocomputeCloudAccountId: UUID! (scalar)
        [JsonProperty("exocomputeCloudAccountId")]
        public System.String? ExocomputeCloudAccountId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudAccountsExocomputeAccountMapping";
    }

    public CloudAccountsExocomputeAccountMapping Set(
        System.String? ApplicationCloudAccountId = null,
        System.String? ExocomputeCloudAccountId = null
    ) 
    {
        if ( ApplicationCloudAccountId != null ) {
            this.ApplicationCloudAccountId = ApplicationCloudAccountId;
        }
        if ( ExocomputeCloudAccountId != null ) {
            this.ExocomputeCloudAccountId = ExocomputeCloudAccountId;
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
        //      C# -> System.String? ApplicationCloudAccountId
        // GraphQL -> applicationCloudAccountId: UUID! (scalar)
        if (this.ApplicationCloudAccountId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "applicationCloudAccountId\n" ;
            } else {
                s += ind + "applicationCloudAccountId\n" ;
            }
        }
        //      C# -> System.String? ExocomputeCloudAccountId
        // GraphQL -> exocomputeCloudAccountId: UUID! (scalar)
        if (this.ExocomputeCloudAccountId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "exocomputeCloudAccountId\n" ;
            } else {
                s += ind + "exocomputeCloudAccountId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ApplicationCloudAccountId
        // GraphQL -> applicationCloudAccountId: UUID! (scalar)
        if (ec.Includes("applicationCloudAccountId",true))
        {
            if(this.ApplicationCloudAccountId == null) {

                this.ApplicationCloudAccountId = "FETCH";

            } else {


            }
        }
        else if (this.ApplicationCloudAccountId != null && ec.Excludes("applicationCloudAccountId",true))
        {
            this.ApplicationCloudAccountId = null;
        }
        //      C# -> System.String? ExocomputeCloudAccountId
        // GraphQL -> exocomputeCloudAccountId: UUID! (scalar)
        if (ec.Includes("exocomputeCloudAccountId",true))
        {
            if(this.ExocomputeCloudAccountId == null) {

                this.ExocomputeCloudAccountId = "FETCH";

            } else {


            }
        }
        else if (this.ExocomputeCloudAccountId != null && ec.Excludes("exocomputeCloudAccountId",true))
        {
            this.ExocomputeCloudAccountId = null;
        }
    }


    #endregion

    } // class CloudAccountsExocomputeAccountMapping
    
    #endregion

    public static class ListCloudAccountsExocomputeAccountMappingExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<CloudAccountsExocomputeAccountMapping> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudAccountsExocomputeAccountMapping> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudAccountsExocomputeAccountMapping> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudAccountsExocomputeAccountMapping());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudAccountsExocomputeAccountMapping> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types