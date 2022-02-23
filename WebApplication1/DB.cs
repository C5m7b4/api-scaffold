using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public static class DB
    {

        public static string ConnectionString(IConfiguration _config)
        {
            string _encrypt = "!dcrpos!";
            var server = Encryption.Decrypt(_config["DB:server"], _encrypt);
            var database = Encryption.Decrypt(_config["DB:database"], _encrypt);
            var username = Encryption.Decrypt(_config["DB:username"], _encrypt);
            var password = Encryption.Decrypt(_config["DB:password"], _encrypt);

            string connect = $"Server={server}; Initial Catalog={database}; User Id={username}; Password={password}";
            return connect;
        }
    }
}
