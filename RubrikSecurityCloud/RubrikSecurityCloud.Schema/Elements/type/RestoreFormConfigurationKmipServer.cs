// RestoreFormConfigurationKmipServer.cs
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
    #region RestoreFormConfigurationKmipServer
    public class RestoreFormConfigurationKmipServer: BaseType
    {
        #region members

        //      C# -> System.String? ServerAddress
        // GraphQL -> serverAddress: String! (scalar)
        [JsonProperty("serverAddress")]
        public System.String? ServerAddress { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RestoreFormConfigurationKmipServer";
    }

    public RestoreFormConfigurationKmipServer Set(
        System.String? ServerAddress = null
    ) 
    {
        if ( ServerAddress != null ) {
            this.ServerAddress = ServerAddress;
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
        //      C# -> System.String? ServerAddress
        // GraphQL -> serverAddress: String! (scalar)
        if (this.ServerAddress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "serverAddress\n" ;
            } else {
                s += ind + "serverAddress\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ServerAddress
        // GraphQL -> serverAddress: String! (scalar)
        if (ec.Includes("serverAddress",true))
        {
            if(this.ServerAddress == null) {

                this.ServerAddress = "FETCH";

            } else {


            }
        }
        else if (this.ServerAddress != null && ec.Excludes("serverAddress",true))
        {
            this.ServerAddress = null;
        }
    }


    #endregion

    } // class RestoreFormConfigurationKmipServer
    
    #endregion

    public static class ListRestoreFormConfigurationKmipServerExtensions
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
            this List<RestoreFormConfigurationKmipServer> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<RestoreFormConfigurationKmipServer> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RestoreFormConfigurationKmipServer> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RestoreFormConfigurationKmipServer());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RestoreFormConfigurationKmipServer> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types