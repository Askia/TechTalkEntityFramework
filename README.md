# TechTalkEntityFramework
This is a repository used for the techtalk demo

# Step 1 : Prepare solution

Create two projects :
- Demo.Web : project to expose an api
- Demo.Data : project to access to datas

# Step 2 :  Add DbContext
Add Survey and include it into your DbContext
Define Connection string for your database.

# Step 3 : Create intial migration
dotnet ef migrations add InitialMigration -s .\Demo.Web\Demo.Web.csproj -p .\Demo.Data\Demo.Data.csproj


