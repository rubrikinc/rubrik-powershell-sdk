// MongoRecoverableRanges.cs
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
    #region MongoRecoverableRanges
    public class MongoRecoverableRanges: BaseType
    {
        #region members

        //      C# -> List<MongoRecoverableRange>? RecoverableRanges
        // GraphQL -> recoverableRanges: [MongoRecoverableRange!]! (type)
        [JsonProperty("recoverableRanges")]
        public List<MongoRecoverableRange>? RecoverableRanges { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MongoRecoverableRanges";
    }

    public MongoRecoverableRanges Set(
        List<MongoRecoverableRange>? RecoverableRanges = null
    ) 
    {
        if ( RecoverableRanges != null ) {
            this.RecoverableRanges = RecoverableRanges;
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
        //      C# -> List<MongoRecoverableRange>? RecoverableRanges
        // GraphQL -> recoverableRanges: [MongoRecoverableRange!]! (type)
        if (this.RecoverableRanges != null) {
            var fspec = this.RecoverableRanges.AsFieldSpec(conf.Child("recoverableRanges"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "recoverableRanges {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<MongoRecoverableRange>? RecoverableRanges
        // GraphQL -> recoverableRanges: [MongoRecoverableRange!]! (type)
        if (ec.Includes("recoverableRanges",false))
        {
            if(this.RecoverableRanges == null) {

                this.RecoverableRanges = new List<MongoRecoverableRange>();
                this.RecoverableRanges.ApplyExploratoryFieldSpec(ec.NewChild("recoverableRanges"));

            } else {

                this.RecoverableRanges.ApplyExploratoryFieldSpec(ec.NewChild("recoverableRanges"));

            }
        }
        else if (this.RecoverableRanges != null && ec.Excludes("recoverableRanges",false))
        {
            this.RecoverableRanges = null;
        }
    }


    #endregion

    } // class MongoRecoverableRanges
    
    #endregion

    public static class ListMongoRecoverableRangesExtensions
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
            this List<MongoRecoverableRanges> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<MongoRecoverableRanges> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MongoRecoverableRanges> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MongoRecoverableRanges());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MongoRecoverableRanges> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types