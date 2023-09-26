// CreateOrgReply.cs
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
    #region CreateOrgReply
    public class CreateOrgReply: BaseType
    {
        #region members

        //      C# -> System.String? OrganizationId
        // GraphQL -> organizationId: String! (scalar)
        [JsonProperty("organizationId")]
        public System.String? OrganizationId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CreateOrgReply";
    }

    public CreateOrgReply Set(
        System.String? OrganizationId = null
    ) 
    {
        if ( OrganizationId != null ) {
            this.OrganizationId = OrganizationId;
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
        //      C# -> System.String? OrganizationId
        // GraphQL -> organizationId: String! (scalar)
        if (this.OrganizationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "organizationId\n" ;
            } else {
                s += ind + "organizationId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? OrganizationId
        // GraphQL -> organizationId: String! (scalar)
        if (ec.Includes("organizationId",true))
        {
            if(this.OrganizationId == null) {

                this.OrganizationId = "FETCH";

            } else {


            }
        }
        else if (this.OrganizationId != null && ec.Excludes("organizationId",true))
        {
            this.OrganizationId = null;
        }
    }


    #endregion

    } // class CreateOrgReply
    
    #endregion

    public static class ListCreateOrgReplyExtensions
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
            this List<CreateOrgReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CreateOrgReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CreateOrgReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CreateOrgReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types