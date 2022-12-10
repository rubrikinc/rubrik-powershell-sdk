// MssqlLogShippingLinks.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:30.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region MssqlLogShippingLinks
    public class MssqlLogShippingLinks: IFragment
    {
        #region members
        //      C# -> Link? PrimaryDatabase
        // GraphQL -> primaryDatabase: Link (type)
        [JsonProperty("primaryDatabase")]
        public Link? PrimaryDatabase { get; set; }

        //      C# -> Link? SecondaryDatabase
        // GraphQL -> secondaryDatabase: Link (type)
        [JsonProperty("secondaryDatabase")]
        public Link? SecondaryDatabase { get; set; }

        //      C# -> Link? SecondaryInstance
        // GraphQL -> secondaryInstance: Link (type)
        [JsonProperty("secondaryInstance")]
        public Link? SecondaryInstance { get; set; }

        //      C# -> Link? SeedRequest
        // GraphQL -> seedRequest: Link (type)
        [JsonProperty("seedRequest")]
        public Link? SeedRequest { get; set; }

        #endregion

    #region methods

    public MssqlLogShippingLinks Set(
        Link? PrimaryDatabase = null,
        Link? SecondaryDatabase = null,
        Link? SecondaryInstance = null,
        Link? SeedRequest = null
    ) 
    {
        if ( PrimaryDatabase != null ) {
            this.PrimaryDatabase = PrimaryDatabase;
        }
        if ( SecondaryDatabase != null ) {
            this.SecondaryDatabase = SecondaryDatabase;
        }
        if ( SecondaryInstance != null ) {
            this.SecondaryInstance = SecondaryInstance;
        }
        if ( SeedRequest != null ) {
            this.SeedRequest = SeedRequest;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> Link? PrimaryDatabase
            // GraphQL -> primaryDatabase: Link (type)
            if (this.PrimaryDatabase != null)
            {
                 s += ind + "primaryDatabase\n";

                 s += ind + "{\n" + 
                 this.PrimaryDatabase.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> Link? SecondaryDatabase
            // GraphQL -> secondaryDatabase: Link (type)
            if (this.SecondaryDatabase != null)
            {
                 s += ind + "secondaryDatabase\n";

                 s += ind + "{\n" + 
                 this.SecondaryDatabase.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> Link? SecondaryInstance
            // GraphQL -> secondaryInstance: Link (type)
            if (this.SecondaryInstance != null)
            {
                 s += ind + "secondaryInstance\n";

                 s += ind + "{\n" + 
                 this.SecondaryInstance.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> Link? SeedRequest
            // GraphQL -> seedRequest: Link (type)
            if (this.SeedRequest != null)
            {
                 s += ind + "seedRequest\n";

                 s += ind + "{\n" + 
                 this.SeedRequest.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> Link? PrimaryDatabase
            // GraphQL -> primaryDatabase: Link (type)
            if (this.PrimaryDatabase == null && Exploration.Includes(parent + ".primaryDatabase"))
            {
                this.PrimaryDatabase = new Link();
                this.PrimaryDatabase.ApplyExploratoryFragment(parent + ".primaryDatabase");
            }
            //      C# -> Link? SecondaryDatabase
            // GraphQL -> secondaryDatabase: Link (type)
            if (this.SecondaryDatabase == null && Exploration.Includes(parent + ".secondaryDatabase"))
            {
                this.SecondaryDatabase = new Link();
                this.SecondaryDatabase.ApplyExploratoryFragment(parent + ".secondaryDatabase");
            }
            //      C# -> Link? SecondaryInstance
            // GraphQL -> secondaryInstance: Link (type)
            if (this.SecondaryInstance == null && Exploration.Includes(parent + ".secondaryInstance"))
            {
                this.SecondaryInstance = new Link();
                this.SecondaryInstance.ApplyExploratoryFragment(parent + ".secondaryInstance");
            }
            //      C# -> Link? SeedRequest
            // GraphQL -> seedRequest: Link (type)
            if (this.SeedRequest == null && Exploration.Includes(parent + ".seedRequest"))
            {
                this.SeedRequest = new Link();
                this.SeedRequest.ApplyExploratoryFragment(parent + ".seedRequest");
            }
        }


    #endregion

    } // class MssqlLogShippingLinks
    #endregion

    public static class ListMssqlLogShippingLinksExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<MssqlLogShippingLinks> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<MssqlLogShippingLinks> list, 
            String parent = "")
        {
            var item = new MssqlLogShippingLinks();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types