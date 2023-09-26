// AnomalyResultAggregation.cs
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
    #region AnomalyResultAggregation
    public class AnomalyResultAggregation: BaseType
    {
        #region members

        //      C# -> System.Int64? BytesAdded
        // GraphQL -> bytesAdded: Long! (scalar)
        [JsonProperty("bytesAdded")]
        public System.Int64? BytesAdded { get; set; }

        //      C# -> System.Int64? BytesDeleted
        // GraphQL -> bytesDeleted: Long! (scalar)
        [JsonProperty("bytesDeleted")]
        public System.Int64? BytesDeleted { get; set; }

        //      C# -> System.Int64? BytesModified
        // GraphQL -> bytesModified: Long! (scalar)
        [JsonProperty("bytesModified")]
        public System.Int64? BytesModified { get; set; }

        //      C# -> System.Int64? FilesAdded
        // GraphQL -> filesAdded: Long! (scalar)
        [JsonProperty("filesAdded")]
        public System.Int64? FilesAdded { get; set; }

        //      C# -> System.Int64? FilesDeleted
        // GraphQL -> filesDeleted: Long! (scalar)
        [JsonProperty("filesDeleted")]
        public System.Int64? FilesDeleted { get; set; }

        //      C# -> System.Int64? FilesModified
        // GraphQL -> filesModified: Long! (scalar)
        [JsonProperty("filesModified")]
        public System.Int64? FilesModified { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AnomalyResultAggregation";
    }

    public AnomalyResultAggregation Set(
        System.Int64? BytesAdded = null,
        System.Int64? BytesDeleted = null,
        System.Int64? BytesModified = null,
        System.Int64? FilesAdded = null,
        System.Int64? FilesDeleted = null,
        System.Int64? FilesModified = null
    ) 
    {
        if ( BytesAdded != null ) {
            this.BytesAdded = BytesAdded;
        }
        if ( BytesDeleted != null ) {
            this.BytesDeleted = BytesDeleted;
        }
        if ( BytesModified != null ) {
            this.BytesModified = BytesModified;
        }
        if ( FilesAdded != null ) {
            this.FilesAdded = FilesAdded;
        }
        if ( FilesDeleted != null ) {
            this.FilesDeleted = FilesDeleted;
        }
        if ( FilesModified != null ) {
            this.FilesModified = FilesModified;
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
        //      C# -> System.Int64? BytesAdded
        // GraphQL -> bytesAdded: Long! (scalar)
        if (this.BytesAdded != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bytesAdded\n" ;
            } else {
                s += ind + "bytesAdded\n" ;
            }
        }
        //      C# -> System.Int64? BytesDeleted
        // GraphQL -> bytesDeleted: Long! (scalar)
        if (this.BytesDeleted != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bytesDeleted\n" ;
            } else {
                s += ind + "bytesDeleted\n" ;
            }
        }
        //      C# -> System.Int64? BytesModified
        // GraphQL -> bytesModified: Long! (scalar)
        if (this.BytesModified != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bytesModified\n" ;
            } else {
                s += ind + "bytesModified\n" ;
            }
        }
        //      C# -> System.Int64? FilesAdded
        // GraphQL -> filesAdded: Long! (scalar)
        if (this.FilesAdded != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filesAdded\n" ;
            } else {
                s += ind + "filesAdded\n" ;
            }
        }
        //      C# -> System.Int64? FilesDeleted
        // GraphQL -> filesDeleted: Long! (scalar)
        if (this.FilesDeleted != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filesDeleted\n" ;
            } else {
                s += ind + "filesDeleted\n" ;
            }
        }
        //      C# -> System.Int64? FilesModified
        // GraphQL -> filesModified: Long! (scalar)
        if (this.FilesModified != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filesModified\n" ;
            } else {
                s += ind + "filesModified\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? BytesAdded
        // GraphQL -> bytesAdded: Long! (scalar)
        if (ec.Includes("bytesAdded",true))
        {
            if(this.BytesAdded == null) {

                this.BytesAdded = new System.Int64();

            } else {


            }
        }
        else if (this.BytesAdded != null && ec.Excludes("bytesAdded",true))
        {
            this.BytesAdded = null;
        }
        //      C# -> System.Int64? BytesDeleted
        // GraphQL -> bytesDeleted: Long! (scalar)
        if (ec.Includes("bytesDeleted",true))
        {
            if(this.BytesDeleted == null) {

                this.BytesDeleted = new System.Int64();

            } else {


            }
        }
        else if (this.BytesDeleted != null && ec.Excludes("bytesDeleted",true))
        {
            this.BytesDeleted = null;
        }
        //      C# -> System.Int64? BytesModified
        // GraphQL -> bytesModified: Long! (scalar)
        if (ec.Includes("bytesModified",true))
        {
            if(this.BytesModified == null) {

                this.BytesModified = new System.Int64();

            } else {


            }
        }
        else if (this.BytesModified != null && ec.Excludes("bytesModified",true))
        {
            this.BytesModified = null;
        }
        //      C# -> System.Int64? FilesAdded
        // GraphQL -> filesAdded: Long! (scalar)
        if (ec.Includes("filesAdded",true))
        {
            if(this.FilesAdded == null) {

                this.FilesAdded = new System.Int64();

            } else {


            }
        }
        else if (this.FilesAdded != null && ec.Excludes("filesAdded",true))
        {
            this.FilesAdded = null;
        }
        //      C# -> System.Int64? FilesDeleted
        // GraphQL -> filesDeleted: Long! (scalar)
        if (ec.Includes("filesDeleted",true))
        {
            if(this.FilesDeleted == null) {

                this.FilesDeleted = new System.Int64();

            } else {


            }
        }
        else if (this.FilesDeleted != null && ec.Excludes("filesDeleted",true))
        {
            this.FilesDeleted = null;
        }
        //      C# -> System.Int64? FilesModified
        // GraphQL -> filesModified: Long! (scalar)
        if (ec.Includes("filesModified",true))
        {
            if(this.FilesModified == null) {

                this.FilesModified = new System.Int64();

            } else {


            }
        }
        else if (this.FilesModified != null && ec.Excludes("filesModified",true))
        {
            this.FilesModified = null;
        }
    }


    #endregion

    } // class AnomalyResultAggregation
    
    #endregion

    public static class ListAnomalyResultAggregationExtensions
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
            this List<AnomalyResultAggregation> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AnomalyResultAggregation> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AnomalyResultAggregation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AnomalyResultAggregation> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types