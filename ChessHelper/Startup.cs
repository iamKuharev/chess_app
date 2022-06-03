using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ChessHelper.Infrastructure.Repository.RepositoryPost;
using ChessHelper.Infrastructure.Repository.RepositoryUser;
using Microsoft.EntityFrameworkCore;
using ChessHelper.Domain.Repositories.RepositoriesPost;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using ChessHelper.Domain.Repositories.RepositoriesUser;

namespace ChessHelper
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // �������� ������ ����������� �� ����� ������������
            string connectionWithPostgre = Configuration.GetConnectionString("PostgreConnection");
            string connectionWithMariaDB = Configuration.GetConnectionString("MariaDBConnection");
            // ��������� �������� ApplicationContext � �������� ������� � ����������
            services.AddDbContext<PostContext>(options =>
                options.UseNpgsql(connectionWithPostgre));

            services.AddDbContext<UserContext>(options => options
            .UseMySql(
                connectionWithMariaDB,
                new MySqlServerVersion(new Version(10, 4))
            ));

            //services.AddScoped<PostContext>();
            services.AddScoped<IChessPlayerRepository, ChessPlayerRepository>();
            services.AddScoped<IVideoLessonRepository, VideoLessonRepository>();
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<IHistoricalPartyRepository, HistoricalPartyRepository>();
            services.AddScoped<ITaskRepository, TaskRepository>();
            services.AddScoped<ITheoryRepository, TheoryRepository>();
            services.AddScoped<ITypeTheoryRepository, TypeTheoryRepository>();

            services.AddScoped<IAchievementRepository, AchievementRepository>();
            services.AddScoped<IAvatarRepository, AvatarRepository>();

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
