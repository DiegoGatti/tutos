FROM mcr.microsoft.com/mssql/server:2019-latest
RUN mkdir /var/opt/mssql/backup
COPY /VentaReal.bak /var/opt/mssql/backup
COPY /RestoreDb.sql /var/opt/mssql/backup
COPY /Restore.sh /var/opt/mssql/backup
WORKDIR /var/opt/mssql/backup
USER root
RUN chmod 755 /var/opt/mssql/backup/Restore.sh
RUN /var/opt/mssql/backup/Restore.sh /var/opt/mssql/backup/RestoreDb.sql 