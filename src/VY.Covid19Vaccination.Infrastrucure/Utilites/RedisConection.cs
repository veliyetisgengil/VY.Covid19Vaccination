using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VY.Covid19Vaccination.Infrastructure.Const;

namespace VY.Covid19Vaccination.Infrastructure.Utilities
{
    public class RedisConnection
    {
        #region Props
        private static RedisConnection dbInstance;
        private ConnectionMultiplexer conn;
        #endregion

        #region Public Methods
        public RedisConnection()
        {
        }
        /// <summary>
        /// Get RedisConnection Instance singleton pattern
        /// </summary>
        /// <returns></returns>
        public static RedisConnection GetRedisInstance()
        {
            if (dbInstance == null)
            {
                dbInstance = new();
            }
            return dbInstance;
        }
        /// <summary>
        /// Get Connection Object Redis
        /// </summary>
        /// <returns></returns>
        public ConnectionMultiplexer GetRedisConnection()
        {
            try
            {
                conn = ConnectionMultiplexer.Connect(RedisConfig.Host + ",password=" + RedisConfig.Password + ",ssl=" + RedisConfig.Ssl + ",abortConnect=" + RedisConfig.AbortConnect);
            }
            catch
            {
                throw;
            }

            return conn;
        } 
        #endregion

    }
}
