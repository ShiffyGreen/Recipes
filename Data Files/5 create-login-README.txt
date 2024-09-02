script to create login and user is excluded form this repo.
create a file called create-login.sql (this file is ignored by git ignore in this repo)
add the following to that file

--IMPORTANT CREATE LOGIN IN MASTER 
--USE master
create login [loginname] with PASSWORD = '[password]'
--important switch ro RecordKeeperDb
create user [username] from login [login name]