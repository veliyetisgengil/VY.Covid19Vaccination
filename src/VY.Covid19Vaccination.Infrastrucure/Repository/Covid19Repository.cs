using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VY.Covid19Vaccination.Application.Repository;
using VY.Covid19Vaccination.Domain.AggregateModels.Covid19Models;
using VY.Covid19Vaccination.Infrastructure.Const;
using VY.Covid19Vaccination.Infrastructure.Utilities;

namespace VY.Covid19Vaccination.Infrastrucure.Repository
{
    public class Covid19Repository : ICovid19Repository
    {
        public Covid19 Add(Covid19 Entity)
        {
            try
            {
                RedisConnection redisConnection = RedisConnection.GetRedisInstance();
                var con = redisConnection.GetRedisConnection();
                var db = con.GetDatabase();

                db.StringSet(Entity.GetType().Name + "-" + Entity.CITY2, JsonConvert.SerializeObject(Entity));

                return Entity;
            }
            catch
            {
                throw;
            }
        }

        public Covid19 GetByCity(string city)
        {
            try
            {
                RedisConnection redisConnection = RedisConnection.GetRedisInstance();
                var con = redisConnection.GetRedisConnection();
                var db = con.GetDatabase();

                var redisData = db.StringGet("Covid19-" + city.ToUpper());
                var entity = redisData.HasValue ? JsonConvert.DeserializeObject<Covid19>(redisData) : new Covid19();
                return entity;
            }
            catch
            {
                throw;
            }
        }

        public List<Covid19> GetList()
        {
            try
            {
                List<Covid19> lst = new List<Covid19>();
                RedisConnection redisConnection = RedisConnection.GetRedisInstance();
                var con = redisConnection.GetRedisConnection();
                var db = con.GetDatabase();
                var svr = con.GetServer(RedisConfig.Host.Split(":")[0], 6380);


                var keys = svr.Keys(pattern: "Covid19*").ToList();

                var ret = keys.Select(a => db.StringGet(a).ToString()).ToList();

                foreach (var item in ret)
                {
                    var entity = JsonConvert.DeserializeObject<Covid19>(item);
                    lst.Add(entity);
                }

                return lst.OrderBy(x=>x.CITY).ToList();
            }
            catch
            {
                throw;
            }
        }


    }
}
