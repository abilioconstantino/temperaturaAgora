using System;
using Ddtank.API.Repository;
using MongoDB.Driver;
using temperaturaAgora.Model;
using temperaturaAgora.repository.Entities;

namespace temperaturaAgora.Data
{
    public class MongoDbContext<T> where T : BaseEntity
    {
        private readonly  IMongoDatabase _database;
        private readonly string _collection;
        public MongoDbContext(IMongoDatabase database, string collection)
        {
            _database = database;
            _collection = collection;
        }

        public IMongoCollection<T> Collection => _database.GetCollection<T>(_collection);
    }
}