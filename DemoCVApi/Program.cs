using DemoCVApi.GraphQL.Queries;
using DemoCVApi.GraphQL.Types;
using GraphQL;

var builder = WebApplication.CreateBuilder(args);

// GQL
builder.Services.AddSingleton<PersonType>();
builder.Services.AddSingleton<SkillType>();
builder.Services.AddSingleton<EducationType>();
builder.Services.AddSingleton<CompanyType>();
builder.Services.AddSingleton<ProjectType>();
builder.Services.AddSingleton<WorkExperienceType>();

builder.Services.AddSingleton<PersonsQuery>();

builder.Services.AddSingleton<PublicSchema>();

builder.Services.AddGraphQL(b => b
    .AddSchema<PublicSchema>()
    .AddSystemTextJson()
    .AddDataLoader()
);

// CORS. Allow all for now
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builder => builder
            .AllowAnyMethod()
            .AllowCredentials()
            .SetIsOriginAllowed((host) => true)
            .AllowAnyHeader());
});

var app = builder.Build();

app.UseCors("CorsPolicy");
app.UseHttpsRedirection();
app.UseRouting();

// Add GraphQL endpoint
app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL("/graphql");
});

// Add Playground UI at /ui/playground
app.UseGraphQLPlayground("/ui/playground");

app.Run();
