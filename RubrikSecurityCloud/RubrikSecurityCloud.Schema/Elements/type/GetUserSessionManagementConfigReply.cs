// GetUserSessionManagementConfigReply.cs
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
    #region GetUserSessionManagementConfigReply
    public class GetUserSessionManagementConfigReply: BaseType
    {
        #region members

        //      C# -> UserSessionManagementConfig? Config
        // GraphQL -> config: UserSessionManagementConfig (type)
        [JsonProperty("config")]
        public UserSessionManagementConfig? Config { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetUserSessionManagementConfigReply";
    }

    public GetUserSessionManagementConfigReply Set(
        UserSessionManagementConfig? Config = null
    ) 
    {
        if ( Config != null ) {
            this.Config = Config;
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
        //      C# -> UserSessionManagementConfig? Config
        // GraphQL -> config: UserSessionManagementConfig (type)
        if (this.Config != null) {
            var fspec = this.Config.AsFieldSpec(conf.Child("config"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "config {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> UserSessionManagementConfig? Config
        // GraphQL -> config: UserSessionManagementConfig (type)
        if (ec.Includes("config",false))
        {
            if(this.Config == null) {

                this.Config = new UserSessionManagementConfig();
                this.Config.ApplyExploratoryFieldSpec(ec.NewChild("config"));

            } else {

                this.Config.ApplyExploratoryFieldSpec(ec.NewChild("config"));

            }
        }
        else if (this.Config != null && ec.Excludes("config",false))
        {
            this.Config = null;
        }
    }


    #endregion

    } // class GetUserSessionManagementConfigReply
    
    #endregion

    public static class ListGetUserSessionManagementConfigReplyExtensions
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
            this List<GetUserSessionManagementConfigReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<GetUserSessionManagementConfigReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetUserSessionManagementConfigReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetUserSessionManagementConfigReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetUserSessionManagementConfigReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types