# STEPS

Run container with db
`sudo docker-compose up -d` or `docker run -d -p 1433:1433 --name sales-system-db sql-server-linux`

Create EF models if needed
`dotnet ef dbcontext scaffold "Server=localhost,1433;Database=VentaReal;User=sa;Password=UnChanchit0;" Microsoft.EntityFrameworkCore.SqlServer -o Models`
