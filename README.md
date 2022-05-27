# Tournament Tracker
Tournament tracker is a desktop application to create and organize tournaments. 

# Instalation tips

## Email
If you want to use Email Notifying, go to app.config and configure both sections <b>appSettings</b> and <b>mailSettings</b> and uncomment block in <b>EmailLogic.cs</b>. If everything is correct users will receive emails from appliaction (tested and worked fine).

## SQL
  Use <b>databaseScript.sql</b> to re-create the database with default tournaments for TT and edit <b>connectionStrings</b> section in App.config providing your database name. Check DatabaseType in Program.cs if everything is correct you can use SQL database storage for your tournaments.
 
