select * from users;

UPDATE users
SET created = GETDATE()
WHERE created IS NULL;