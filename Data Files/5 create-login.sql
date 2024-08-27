--IMPORTANT CREATE LOGIN IN MASTER 
--USE master
create login recipeadmin with PASSWORD = 'NEWuser123(!)'
--important switch ro RecordKeeperDb
create user recipeadmin_user from login appadmin