using CommandsAndTools.Api.Models;
using HotChocolate;
using HotChocolate.Types;

namespace CommandsAndTools.Api.GraphQL
{
    public class Subscription
    {
        [Subscribe]
        [Topic]
        public Platform OnPlatformAdded([EventMessage] Platform platform) => platform;
    }
}