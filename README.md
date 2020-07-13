# FootballManager
Da pokrenete API:
- skinite MySql Workbench i u njemu napravite footballmanager bazu
- na tri mesta u solution-u imamo connection string (popravicu ovo da imamo samo na jednom mestu) - promenite ga da gadja vasu bazu i koristi vase kredencijale
  Connection string: server=localhost;port=3306;database=footbalmanager;uid=root;password=*****
- pokretanje migracije na bazi: dotnet ef database update
- a pre toga kreirajte migrations tabelu u bazi: 

CREATE TABLE `__EFMigrationsHistory` ( `MigrationId` nvarchar(150) NOT NULL, `ProductVersion` nvarchar(32) NOT NULL, PRIMARY KEY (`MigrationId`) );





Kreiranje novih migracija: dotnet ef migrations add IME_MIGRACIJE




