// CloudAccountWithExocomputeMapping.cs
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
    #region CloudAccountWithExocomputeMapping
    public class CloudAccountWithExocomputeMapping: BaseType
    {
        #region members

        //      C# -> CloudAccountDetails? ApplicationAccount
        // GraphQL -> applicationAccount: CloudAccountDetails! (type)
        [JsonProperty("applicationAccount")]
        public CloudAccountDetails? ApplicationAccount { get; set; }

        //      C# -> CloudAccountDetails? ExocomputeAccount
        // GraphQL -> exocomputeAccount: CloudAccountDetails (type)
        [JsonProperty("exocomputeAccount")]
        public CloudAccountDetails? ExocomputeAccount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudAccountWithExocomputeMapping";
    }

    public CloudAccountWithExocomputeMapping Set(
        CloudAccountDetails? ApplicationAccount = null,
        CloudAccountDetails? ExocomputeAccount = null
    ) 
    {
        if ( ApplicationAccount != null ) {
            this.ApplicationAccount = ApplicationAccount;
        }
        if ( ExocomputeAccount != null ) {
            this.ExocomputeAccount = ExocomputeAccount;
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
        //      C# -> CloudAccountDetails? ApplicationAccount
        // GraphQL -> applicationAccount: CloudAccountDetails! (type)
        if (this.ApplicationAccount != null) {
            var fspec = this.ApplicationAccount.AsFieldSpec(conf.Child("applicationAccount"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "applicationAccount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CloudAccountDetails? ExocomputeAccount
        // GraphQL -> exocomputeAccount: CloudAccountDetails (type)
        if (this.ExocomputeAccount != null) {
            var fspec = this.ExocomputeAccount.AsFieldSpec(conf.Child("exocomputeAccount"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "exocomputeAccount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CloudAccountDetails? ApplicationAccount
        // GraphQL -> applicationAccount: CloudAccountDetails! (type)
        if (ec.Includes("applicationAccount",false))
        {
            if(this.ApplicationAccount == null) {

                this.ApplicationAccount = new CloudAccountDetails();
                this.ApplicationAccount.ApplyExploratoryFieldSpec(ec.NewChild("applicationAccount"));

            } else {

                this.ApplicationAccount.ApplyExploratoryFieldSpec(ec.NewChild("applicationAccount"));

            }
        }
        else if (this.ApplicationAccount != null && ec.Excludes("applicationAccount",false))
        {
            this.ApplicationAccount = null;
        }
        //      C# -> CloudAccountDetails? ExocomputeAccount
        // GraphQL -> exocomputeAccount: CloudAccountDetails (type)
        if (ec.Includes("exocomputeAccount",false))
        {
            if(this.ExocomputeAccount == null) {

                this.ExocomputeAccount = new CloudAccountDetails();
                this.ExocomputeAccount.ApplyExploratoryFieldSpec(ec.NewChild("exocomputeAccount"));

            } else {

                this.ExocomputeAccount.ApplyExploratoryFieldSpec(ec.NewChild("exocomputeAccount"));

            }
        }
        else if (this.ExocomputeAccount != null && ec.Excludes("exocomputeAccount",false))
        {
            this.ExocomputeAccount = null;
        }
    }


    #endregion

    } // class CloudAccountWithExocomputeMapping
    
    #endregion

    public static class ListCloudAccountWithExocomputeMappingExtensions
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
            this List<CloudAccountWithExocomputeMapping> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudAccountWithExocomputeMapping> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudAccountWithExocomputeMapping> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudAccountWithExocomputeMapping());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudAccountWithExocomputeMapping> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types