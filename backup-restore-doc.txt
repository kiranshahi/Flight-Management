1) Open visual studio
2) Click on view
3) Click on SQL Server Object Explorer
4) Click on SQL Server
5) Right click on (localdb)\MSSQLLocalDb
6) Click New Query
7) Run following command

RESTORE FILELISTONLY
FROM DISK = 'E:\Git\Flight-Management\FlightManagement.bak'

RESTORE DATABASE FlightManagement
FROM DISK = 'E:\Git\Flight-Management\FlightManagement.bak'

WITH MOVE 'FlightManagement' TO 'E:\Git\Flight-Management\FlightManagement.mdf',
MOVE 'FlightManagement_log' TO 'E:\Git\Flight-Management\FlightManagement.ldf',
REPLACE;

Note: Change the file path according to you computer folder structure.