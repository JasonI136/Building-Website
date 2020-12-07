using System;
using System.Collections.Generic;
using System.Text;

namespace Palisade.Domain.Repository
{
   
    
    public class RepositoryBase
    {
        // This will create the context when the repository is instantiated
        internal Entity.PalisadeMirandaContext _dataContext;

        public RepositoryBase() 
        {
            _dataContext = new Entity.PalisadeMirandaContext();
        }
    }
}
