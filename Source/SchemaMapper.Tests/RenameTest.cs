﻿using System;
using System.Xml;
using System.Xml.Serialization;
using NUnit.Framework;
using SchemaExplorer;
using SchemaExplorer.Serialization;

namespace SchemaMapper.Tests
{
    [TestFixture]
    public class RenameTest
    {
        [Test]
        public void RenameEntity()
        {
            var selector = GetDatabaseSchema("Tracker");
            Assert.IsNotNull(selector);

            var generator = new Generator();
            EntityContext entityContext = generator.Generate(selector);

            Assert.IsNotNull(entityContext);

            var settings = new XmlWriterSettings { Indent = true };
            var serializer = new XmlSerializer(typeof(EntityContext));

            using (var writer = XmlWriter.Create(@"..\..\Tracker.Before.xml", settings))
                serializer.Serialize(writer, entityContext);

            entityContext.RenameEntity("Task", "TaskRename");

            using (var writer = XmlWriter.Create(@"..\..\Tracker.After.xml", settings))
                serializer.Serialize(writer, entityContext);
        }

        [Test]
        public void RenameProperty()
        {
            var selector = GetDatabaseSchema("Tracker");
            Assert.IsNotNull(selector);
            var generator = new Generator();
            EntityContext entityContext = generator.Generate(selector);

            Assert.IsNotNull(entityContext);

            var settings = new XmlWriterSettings { Indent = true };
            var serializer = new XmlSerializer(typeof(EntityContext));

            using (var writer = XmlWriter.Create(@"..\..\Tracker.Before.xml", settings))
                serializer.Serialize(writer, entityContext);

            entityContext.RenameProperty("Task", "PriorityId", "NewPriorityId");

            using (var writer = XmlWriter.Create(@"..\..\Tracker.After.xml", settings))
                serializer.Serialize(writer, entityContext);
        }


        private SchemaSelector GetDatabaseSchema(string name)
        {
            var databaseSchema = DatabaseSchemaSerializer.GetDatabaseSchemaFromName(name);            
            
            var selector = new SchemaSelector(databaseSchema.Provider, databaseSchema.ConnectionString);
            selector.Database.DeepLoad = true;

            return selector;
        }

    }
}
