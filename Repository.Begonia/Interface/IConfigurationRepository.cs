using Repository.Models.Begonia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interface.Begonia
{
    public interface IConfigurationRepository
    {
        public IEnumerable<BegoniaConfiguration> GetBegoniaConfigurations();

    }
}
