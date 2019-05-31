using OverwatchAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OverwatchGraphQL.Schema
{
    public class Query
    {
        private readonly OverwatchClient client;

        public Query(OverwatchClient client)
        {
            this.client = client;
        }

        public Task<Player> GetPlayer(string name)
        {
            return client.GetPlayerAsync(name);
        }
    }
}
