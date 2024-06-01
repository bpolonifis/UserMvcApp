namespace UserMvcApp.Repositories
{
    public static class RepositoriesDIExtentions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;

        }


    }
}
