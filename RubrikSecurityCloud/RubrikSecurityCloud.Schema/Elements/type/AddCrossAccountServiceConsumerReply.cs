// AddCrossAccountServiceConsumerReply.cs
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
    #region AddCrossAccountServiceConsumerReply
    public class AddCrossAccountServiceConsumerReply: BaseType
    {
        #region members

        //      C# -> CrossAccountSaType? ServiceProviderSa
        // GraphQL -> serviceProviderSa: CrossAccountSaType (type)
        [JsonProperty("serviceProviderSa")]
        public CrossAccountSaType? ServiceProviderSa { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AddCrossAccountServiceConsumerReply";
    }

    public AddCrossAccountServiceConsumerReply Set(
        CrossAccountSaType? ServiceProviderSa = null
    ) 
    {
        if ( ServiceProviderSa != null ) {
            this.ServiceProviderSa = ServiceProviderSa;
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
        //      C# -> CrossAccountSaType? ServiceProviderSa
        // GraphQL -> serviceProviderSa: CrossAccountSaType (type)
        if (this.ServiceProviderSa != null) {
            var fspec = this.ServiceProviderSa.AsFieldSpec(conf.Child("serviceProviderSa"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "serviceProviderSa {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CrossAccountSaType? ServiceProviderSa
        // GraphQL -> serviceProviderSa: CrossAccountSaType (type)
        if (ec.Includes("serviceProviderSa",false))
        {
            if(this.ServiceProviderSa == null) {

                this.ServiceProviderSa = new CrossAccountSaType();
                this.ServiceProviderSa.ApplyExploratoryFieldSpec(ec.NewChild("serviceProviderSa"));

            } else {

                this.ServiceProviderSa.ApplyExploratoryFieldSpec(ec.NewChild("serviceProviderSa"));

            }
        }
        else if (this.ServiceProviderSa != null && ec.Excludes("serviceProviderSa",false))
        {
            this.ServiceProviderSa = null;
        }
    }


    #endregion

    } // class AddCrossAccountServiceConsumerReply
    
    #endregion

    public static class ListAddCrossAccountServiceConsumerReplyExtensions
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
            this List<AddCrossAccountServiceConsumerReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<AddCrossAccountServiceConsumerReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AddCrossAccountServiceConsumerReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AddCrossAccountServiceConsumerReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AddCrossAccountServiceConsumerReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types