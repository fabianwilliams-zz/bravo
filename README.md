bravo
=====

Fully Extending Azure Mobile Service Xamarin ToDo sample to add all my Social Fields &amp; mod UI to fit
This originally was the To Do App that comes with Azure Mobile Service. Here is what i did
---
For the Service
----
1. After creating the new Mobile Service, Downloaded Project into VS 2013
2. In the Service project, Extended the ToDoItem.cs to include all the fields i want for my intended app
3. Seeded the WebApiConfig.cs file with additional items using the new fields i added
4. Deleted the original ToDoItemController and added a new one after the changes (just becasue I am cautious), this is an Azure Table Cotroller btw
5. Published the Service to Azure Mobile Services
---- 
For the Client "this is a work in progress (WIP)"
---
1. Updated the ToDoItem.cs with the new fields and JSON.net attribute
2. Updated the QSToDoService.cs to take out the refernce for "Complete" as this is no longer a ToDo app to "remove" to reflect deleting someone from the list
3. Updated QSCOntroller.cs to add the fields in the method that the button add is connected to so that it will update the SQL Database. As of 12/24/14 4 am EST, i have not created the additional controls UITextField for the additonal fields yet, i have just created dummy data in the method call
//End 12/24/2014