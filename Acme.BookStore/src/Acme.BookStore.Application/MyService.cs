using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.BookStore
{
    public class MyService : ITransientDependency
    {
        private readonly MyOptions _options;

        public MyService(IOptions<MyOptions> options)
        {
            _options = options.Value; //Notice the options.Value usage!
        }

        public void DoIt()
        {
            var v1 = _options.Value1;
            var v2 = _options.Value2;
        }
    }

}
