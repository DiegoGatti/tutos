USE master
GO
PRINT 'Restoring VentaReal'
 -------------------------------------------------
--> Restoring VentaReal
-------------------------------------------------
RESTORE DATABASE VentaReal
FROM DISK =  N'/var/opt/mssql/backup/VentaReal.bak'
WITH FILE = 1,
     MOVE N'VentaReal'
     TO  N'/var/opt/mssql/data/VentaReal.mdf',
     MOVE N'VentaReal_log'
     TO  N'/var/opt/mssql/data/VentaReal_log.ldf',
     NOUNLOAD,
     STATS = 5;
GO
-------------------------------------------------
--> Adding user VentaRealUser
-------------------------------------------------
USE master;
GO
CREATE LOGIN VentaRealUser
WITH PASSWORD = N'VentaReal.@2021',
     DEFAULT_DATABASE = VentaReal
GO
-------------------------------------------------
--> Adding permissions to VentaRealUser
-------------------------------------------------
USE VentaReal
GO
CREATE USER VentaRealUser FOR LOGIN VentaRealUser
GO
USE VentaReal
GO
ALTER ROLE db_owner ADD MEMBER VentaRealUser
GO