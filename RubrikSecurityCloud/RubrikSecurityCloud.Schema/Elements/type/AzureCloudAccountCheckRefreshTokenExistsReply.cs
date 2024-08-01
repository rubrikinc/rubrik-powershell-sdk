// AzureCloudAccountCheckRefreshTokenExistsReply.cs
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
    #region AzureCloudAccountCheckRefreshTokenExistsReply
    public class AzureCloudAccountCheckRefreshTokenExistsReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? HasRefreshToken
        // GraphQL -> hasRefreshToken: Boolean! (scalar)
        [JsonProperty("hasRefreshToken")]
        public System.Boolean? HasRefreshToken { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureCloudAccountCheckRefreshTokenExistsReply";
    }

    public AzureCloudAccountCheckRefreshTokenExistsReply Set(
        System.Boolean? HasRefreshToken = null
    ) 
    {
        if ( HasRefreshToken != null ) {
            this.HasRefreshToken = HasRefreshToken;
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
        //      C# -> System.Boolean? HasRefreshToken
        // GraphQL -> hasRefreshToken: Boolean! (scalar)
        if (this.HasRefreshToken != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasRefreshToken\n" ;
            } else {
                s += ind + "hasRefreshToken\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? HasRefreshToken
        // GraphQL -> hasRefreshToken: Boolean! (scalar)
        if (ec.Includes("hasRefreshToken",true))
        {
            if(this.HasRefreshToken == null) {

                this.HasRefreshToken = true;

            } else {


            }
        }
        else if (this.HasRefreshToken != null && ec.Excludes("hasRefreshToken",true))
        {
            this.HasRefreshToken = null;
        }
    }


    #endregion

    } // class AzureCloudAccountCheckRefreshTokenExistsReply
    
    #endregion

    public static class ListAzureCloudAccountCheckRefreshTokenExistsReplyExtensions
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
            this List<AzureCloudAccountCheckRefreshTokenExistsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureCloudAccountCheckRefreshTokenExistsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureCloudAccountCheckRefreshTokenExistsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureCloudAccountCheckRefreshTokenExistsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureCloudAccountCheckRefreshTokenExistsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types