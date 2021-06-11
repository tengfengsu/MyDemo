using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Modularity;

namespace Acme.BookStore.Web
{
    public class BlogModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            //跳过自动注册，使用AddAssemblyOf扩展方法依照约定手动注册所有服务
            context.Services.AddAssemblyOf<BlogModule>();
        }
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            //禁用自动注册
            SkipAutoServiceRegistration = true;
        }

       
    }

}
