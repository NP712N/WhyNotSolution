using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using WhyNotSolution.Repository;
using WhyNotSolution.Repository.PostService;
using WhyNotSolution.Repository.RoleService;

namespace WhyNotSolution.Extensions {
    public static class ServiceExtensions {
        public static void ConfigureRepositoryManager(this IServiceCollection services) { 
            services.AddTransient<IRoleRepository, RoleManagement>();
            services.AddTransient<IPostRepository, PostManagement>();
            //var allrepositoryinterfaces = Assembly.GetAssembly(typeof(IRepository<>))
            //    ?.GetTypes().Where(t => t.Name.EndsWith("Repository")).ToList();
            //var allrepositoryimplements = Assembly.GetAssembly(typeof(Repository<>))
            //    ?.GetTypes().Where(t => t.Name.EndsWith("Repository")).ToList();

            //foreach (var repositorytype in allrepositoryinterfaces.Where(t => t.IsInterface)) {
            //    var implement = allrepositoryimplements.FirstOrDefault(c => c.IsClass && repositorytype.Name.Substring(1) == c.Name);
            //    if (implement != null) services.AddScoped(repositorytype, implement);
            //}
        }
    }
}
