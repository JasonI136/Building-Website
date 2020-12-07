using Microsoft.Extensions.Configuration;
using Palisade.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Palisade.Shared.Helper
{
    public sealed class BuildingWebsiteConfiguration
    {
        private static BuildingWebsiteConfiguration instance = null;
        private static readonly object padlock = new object();
        public IConfiguration Configuration { get; set; }
        BuildingWebsiteConfiguration()
        { 
        }

        public static BuildingWebsiteConfiguration Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new BuildingWebsiteConfiguration();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
