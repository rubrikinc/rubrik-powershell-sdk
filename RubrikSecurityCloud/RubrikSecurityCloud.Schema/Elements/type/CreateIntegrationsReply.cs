// CreateIntegrationsReply.cs
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
    #region CreateIntegrationsReply
    public class CreateIntegrationsReply: BaseType
    {
        #region members

        //      C# -> List<System.Int64>? Ids
        // GraphQL -> ids: [Long!]! (scalar)
        [JsonProperty("ids")]
        public List<System.Int64>? Ids { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CreateIntegrationsReply";
    }

    public CreateIntegrationsReply Set(
        List<System.Int64>? Ids = null
    ) 
    {
        if ( Ids != null ) {
            this.Ids = Ids;
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
        //      C# -> List<System.Int64>? Ids
        // GraphQL -> ids: [Long!]! (scalar)
        if (this.Ids != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ids\n" ;
            } else {
                s += ind + "ids\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.Int64>? Ids
        // GraphQL -> ids: [Long!]! (scalar)
        if (ec.Includes("ids",true))
        {
            if(this.Ids == null) {

                this.Ids = new List<System.Int64>();

            } else {


            }
        }
        else if (this.Ids != null && ec.Excludes("ids",true))
        {
            this.Ids = null;
        }
    }


    #endregion

    } // class CreateIntegrationsReply
    
    #endregion

    public static class ListCreateIntegrationsReplyExtensions
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
            this List<CreateIntegrationsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<CreateIntegrationsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CreateIntegrationsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CreateIntegrationsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CreateIntegrationsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types