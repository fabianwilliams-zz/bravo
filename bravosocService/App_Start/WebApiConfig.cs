using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Http;
using Microsoft.WindowsAzure.Mobile.Service;
using bravosocService.DataObjects;
using bravosocService.Models;

namespace bravosocService
{
    public static class WebApiConfig
    {
        public static void Register()
        {
            // Use this class to set configuration options for your mobile service
            ConfigOptions options = new ConfigOptions();

            // Use this class to set WebAPI configuration options
            HttpConfiguration config = ServiceConfig.Initialize(new ConfigBuilder(options));

            // To display errors in the browser during development, uncomment the following
            // line. Comment it out again when you deploy your service for production use.
            // config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;
            
            Database.SetInitializer(new bravosocInitializer());
        }
    }

    public class bravosocInitializer : ClearDatabaseSchemaIfModelChanges<bravosocContext>
    {
        protected override void Seed(bravosocContext context)
        {
            List<TodoItem> todoItems = new List<TodoItem>
            {
                new TodoItem { Id = Guid.NewGuid().ToString(), Text = "First item", Complete = false },
                new TodoItem { Id = Guid.NewGuid().ToString(), Text = "Second item", Complete = false },
                new TodoItem { Id = Guid.NewGuid().ToString(), Text = "Alice Terrier", Complete = false, EmailAddress = "atwdoggie@gmail.com", FaceBookName = "aliceterrier", InstagramName = "alicestaffy", MobilePhone = "202-567-3487", TwitterHandle = "aliceterrier", Remove = false},
                new TodoItem { Id = Guid.NewGuid().ToString(), Text = "Gabby Williams", Complete = false, EmailAddress = "gabbyw@live.com", FaceBookName = "gabbywilliams", InstagramName = "gabbsw", MobilePhone = "443-256-6873", TwitterHandle = "gabbyw", Remove = false},
                new TodoItem { Id = Guid.NewGuid().ToString(), Text = "Bart Tubalinal", Complete = false, EmailAddress = "bxt@gmail.com", FaceBookName = "bxt", InstagramName = "bxtpro4", MobilePhone = "312-555-1212", TwitterHandle = "bart_tubalinal", Remove = false},
            };

            foreach (TodoItem todoItem in todoItems)
            {
                context.Set<TodoItem>().Add(todoItem);
            }

            base.Seed(context);
        }
    }
}

