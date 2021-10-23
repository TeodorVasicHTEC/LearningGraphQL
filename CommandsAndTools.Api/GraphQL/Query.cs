using System.Linq;
using CommandsAndTools.Api.Data;
using CommandsAndTools.Api.Models;
using HotChocolate;
using HotChocolate.Data;

namespace CommandsAndTools.Api.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(AppDbContext))]//Because of db pooling
        //[UseProjection]//Gets all child objects
        [GraphQLDescription("Gets the queryable platform.")]
        public IQueryable<Platform> GetPlatform([ScopedService]AppDbContext context)
        {
            return context.Platforms;
        }

        [UseDbContext(typeof(AppDbContext))]
        [UseProjection]
        public IQueryable<Command> GetCommand([ScopedService] AppDbContext context)
        {
            return context.Commands;
        }
    }
}