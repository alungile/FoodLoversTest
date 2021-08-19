Instructions:

Download the files to your visual studio
I have assumes that at the time of any import there is NO DATA on the tables, because the ID fields on all the files are the same, (The DB ID fields is PK and NOT Identity)
When manually adding the new record you do not need to add ID, the system will detect
Import file button will automatically detect the file type and auto add to DB
Import the branch file when at the Branch page and Product file when at Product page
Exported file are stored : ~\FoodLoversTest\bin\Debug
There is NO specific reason for the BranchProduct upload to be on Product page.
You must import both Branch and Product before you import BranchProduct

Database :

Create a MSSQL Database named : FoodLovers
Run the scripts (C:\FoodLoversTest\DBScripts) folder on your MSSQL Database
On your App.config file Edit: ConnectionString and FoodLoversEntities with your correct credentials. NB : There are 4 scripts file to run, 3 create tables and a store procedure.
