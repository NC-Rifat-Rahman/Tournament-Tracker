# Tournament Tracker
Tournament Tracker is a desktop application created in .NET with a view in WinForms and two way data storage. The appliaction handles storage in text files (CSV files) or an SQL database (using Dapper). TT was created for learning purposes and for fun.
Applications meet all conditions that I put up at the beginning:
<ul>
  <li>Two way storage for data</li>
  <li>Creating new tournaments, teams, players and pool prizes</li>
  <li>Loading unfinished tournaments, teams and players</li>
  <li>Tracking current matchups, adding scores</li>
  <li>Email notify</li>
</ul>

# Used Technologies, patterns, libraries etc
<ul>
  <li>WinForms</li>
  <li>MVC pattern</li>
  <li>Lambda expressions using Linq</li>
  <li>.Net Emailing</li>
  <li>SQL database</li>
  <li>Dapper</li>
  <li>Text file storage</li>
  <li>Stored procedures in SQL</li>
</ul> 

# Instalation tips

## Email
If you want to use Email Notifying, go to app.config and configure both sections <b>appSettings</b> and <b>mailSettings</b> and uncomment block in <b>EmailLogic.cs</b>. If everything is correct users will receive emails from appliaction (tested and worked fine).

## SQL
  Use <b>databaseScript.sql</b> to re-create the database with default tournaments for TT and edit <b>connectionStrings</b> section in App.config providing your database name. Check DatabaseType in Program.cs if everything is correct you can use SQL database storage for your tournaments.
  
## TEXT
  Check DatabaseType in Program.cs and if needed change from SQL to TextFile. Default .csv files in repo provide default tournament for tests.
  
# Possible improvements
  Almost all dapper calls can be re-created using genercis to respect DRY. Also adding (any) graphic design would be nice.
  Buttons like "Edit Player", "Close Tournament without Winner", "Edit Team" would be nice, but i moved on to the next project.
  
# Screenshots
  Maybe it isn't my top notch graphic design application, but the overall view is "okay".
  Coming soon.
