
-- 3rd LAB
select * from ecgreport

select * from cardiodiagnosis

select * from symptom;

select * from memberinfo;

-- 4th LAB
SELECT * FROM cardiodiagnosis;

SELECT date, cardioarrestdetected FROM cardiodiagnosis;

SELECT date as Predication_Date, sum(cardioarrestdetected) as Predictions FROM cardiodiagnosis GROUP BY date;


-- 5th LAB
SELECT distinct(city) FROM addressinfo;

SELECT * FROM memberinfo WHERE member_id in (SELECT memberinfo_member_id FROM addressinfo WHERE city = 'Flora')

SELECT m.* FROM memberinfo as m JOIN addressinfo as a ON m.member_id = a.memberinfo_member_id WHERE a.city='Flora';


-- 6th LAB
SELECT * FROM memberinfo member JOIN addressinfo address ON member.member_id = address.memberinfo_member_id WHERE address.city='Burgos';

SELECT COUNT(b.blood_id) FROM bloodtest as b JOIN cardiodiagnosis as c ON b.cardiodiagnosis_cardio_id = c.cardio_id JOIN memberinfo as m ON c.memberinfo_member_id = m.member_id 
WHERE m.firstname='Aisha';

-- 7th LAB
SELECT xr.* FROM xray as xr JOIN cardiodiagnosis as c ON xr.cardiodiagnosis_cardio_id=c.cardio_id JOIN memberinfo as m ON c.memberinfo_member_id=m.member_id 
WHERE m.firstname='Ajay' AND c.date='2019-01-26'


-- 8th LAB : Create stored procedure to display firstname, lastname, age of a member by member_id
CREATE PROC sp_memberinfo
@id varchar(45)
AS
BEGIN
	SELECT firstname, lastname, age from memberinfo WHERE member_id = @id;
END

EXEC sp_memberinfo 'M100';


-- 9th LAB : Create stored procedure to add new members

CREATE PROC sp_addNewMember
@id varchar(45),
@username varchar(45),
@firstname varchar(45),
@lastname varchar(45),
@age int,
@gender varchar(45),
@email varchar(45),
@phone bigint
AS
BEGIN
	INSERT INTO memberinfo VALUES (@id, @username, @firstname, @lastname, @age, @gender,@email,@phone);
END

EXEC sp_addNewMember 'M500', 'Rakesh', 'Rakesh','Thakur', 22, 'Male', 'R@gmail.com','1234567890';

select * from memberinfo where member_id = 'M500'


-- 10th LAB : Create stored procedure to display xray details by patient name and and date

CREATE PROC sp_getxraydetailsByPatientNameAndDate
@name varchar(45),
@date datetime2(0)
AS
BEGIN
	SELECT xr.* FROM xray as xr JOIN cardiodiagnosis as c ON xr.cardiodiagnosis_cardio_id=c.cardio_id JOIN memberinfo as m ON c.memberinfo_member_id=m.member_id 
	WHERE m.firstname = @name AND c.date = @date;
END

EXEC sp_getxraydetailsByPatientNameAndDate 'Ajay', '2019-01-26';


-- 11th LAB : 
Create function fn_Count()
returns int 
begin
	return(SELECT COUNT(*) FROM cardiodiagnosis WHERE cardioarrestdetected = '1')
end

SELECT dbo.fn_Count()







-- 12th LAB :  creating cursor to display memberId, username, firstname and age of member where age is greater than 35

DECLARE @memb_id varchar(45), @username varchar(45), @firstname varchar(45), @age int;

DECLARE memb_cusror  CURSOR FOR
SELECT member_id, username, firstname,age FROM memberinfo WHERE age > 35;

OPEN memb_cusror 

FETCH NEXT FROM memb_cusror INTO @memb_id , @username , @firstname , @age;

Print '	' + 'Member id	username	firstname	age'

WHILE @@FETCH_STATUS = 0
BEGIN
	print '	' + CAST(@memb_id as varchar(45)) + '	' + CAST(@username as varchar(45))+ '		' + CAST(@firstname as varchar(45))+ '	' + CAST(@age as varchar(45))
	
	FETCH NEXT FROM memb_cusror INTO @memb_id , @username , @firstname , @age;
END
CLOSE memb_cusror;
DEALLOCATE memb_cusror;



-- 13th LAB : create a cursor to display all member name in a particular format 

DECLARE  @first_name varchar(45), @last_name varchar(45)

DECLARE memberinfo_cusror  CURSOR FOR
SELECT firstname, lastname FROM memberinfo;

OPEN memberinfo_cusror 

FETCH NEXT FROM memberinfo_cusror INTO @first_name , @last_name;

WHILE @@FETCH_STATUS = 0
BEGIN
	print 'The member name is : ' + CAST(@first_name as varchar(45))+ ' ' + CAST(@last_name as varchar(45))
	
	FETCH NEXT FROM  memberinfo_cusror INTO @first_name , @last_name;

END
CLOSE memberinfo_cusror;
DEALLOCATE memberinfo_cusror;


-- 14th LAB : create procedure with cursor to display all member name belongs to a particular city
CREATE PROC sp_memberinfoByCity
@City varchar(45)
AS
BEGIN	

	DECLARE  @name varchar(45);

	DECLARE memberinfoByCity_cusror  CURSOR FOR

		SELECT m.firstname FROM memberinfo as m JOIN addressinfo as a ON m.member_id = a.memberinfo_member_id WHERE a.city = @City;

	OPEN memberinfoByCity_cusror 

	FETCH NEXT FROM memberinfoByCity_cusror INTO @name;

	WHILE @@FETCH_STATUS = 0
	BEGIN
		print ' ' + CAST(@name as varchar(45));
	
		FETCH NEXT FROM  memberinfoByCity_cusror INTO @name;

	END
	CLOSE memberinfoByCity_cusror;
	DEALLOCATE memberinfoByCity_cusror;

END

EXEC sp_memberinfoByCity 'Flora';


-- 15th LAB : create procedure with cursor to display all member information who are passing particular age

CREATE PROC sp_displayMemberInfo
@AgeParam int
AS
BEGIN

	DECLARE @memb_id varchar(45), @lastname varchar(45), @firstname varchar(45), @age int, @phone bigint

	DECLARE memb_cusror  CURSOR FOR
		SELECT member_id, lastname, firstname, age, phonenumber FROM memberinfo WHERE age = @AgeParam;

	OPEN memb_cusror 

	FETCH NEXT FROM memb_cusror INTO @memb_id , @lastname , @firstname , @age, @phone;

	Print '	' + 'Member_id	firstname	lastname   age	Phonenumber'

	WHILE @@FETCH_STATUS = 0
	BEGIN
		print '	' + CAST(@memb_id as varchar(45)) + '		' + CAST(@firstname as varchar(45))+ '		' + CAST(@lastname as varchar(45))+ '		' + CAST(@age as varchar(45)) + '		'+CAST(@phone as varchar(45))
	
		FETCH NEXT FROM memb_cusror INTO @memb_id , @lastname , @firstname , @age, @phone;
	END
	CLOSE memb_cusror;
	DEALLOCATE memb_cusror;

END

EXEC sp_displayMemberInfo 30;

drop proc sp_displayMemberInfo


-- 16th LAB : 
drop trigger tg_addMember

CREATE TRIGGER tg_addMember ON memberinfo
INSTEAD of INSERT
AS
BEGIN
	DECLARE @email varchar(45)
	SELECT @email = email FROM inserted
	IF not exists(SELECT * FROM memberinfo WHERE email=@email)
	BEGIN
		INSERT INTO memberinfo (member_id,email) SELECT member_id,email FROM inserted
	END
	ELSE
	BEGIN
		print'Email Id already exists...'
	END
END

SELECT * FROM memberinfo

INSERT INTO memberinfo values ('M505', 'Rakesh', 'Rakesh','Thakur', 22, 'Male', 'R@gmail.com','1234567890')



-- 17th LAB
drop trigger tg_memberTable

CREATE TRIGGER tg_memberTable ON memberinfo
FOR INSERT,UPDATE,DELETE
AS
BEGIN
	DECLARE @id varchar(45)
	DECLARE @operation varchar(45)
	IF exists(SELECT * FROM inserted)
	BEGIN
		IF exists(SELECT * FROM inserted)
		BEGIN
			SELECT @id=member_id FROM inserted
			SELECT @operation='Updated...'
		END
	ELSE
	BEGIN
		SELECT @id=member_id FROM inserted;
		SELECT @operation='Inserted...'
	END
	END
	ELSE IF exists(SELECT * FROM deleted)
	BEGIN
		SELECT @id=member_id FROM deleted;
		SELECT @operation='Deleted...'
	END
	ELSE IF exists(SELECT * FROM updated)
	BEGIN
		SELECT @id=member_id FROM updated;
		SELECT @operation='Updated...'
	END


	INSERT INTO memberLog VALUES(GETDATE(),@id,@operation,'   ')
	print'Operation successful'
END

CREATE TABLE  memberLog(change_date date,member_id varchar(45),operation varchar(45),description varchar(50))

SELECT * FROM memberinfo
SELECT * FROM memberLog
INSERT INTO memberinfo VALUES('M506', 'Rakesh', 'Rakesh','Thakur', 22, 'Male', 'Rakesh@gmail.com','1234567890')


-- 18th LAB
drop trigger memberLogTrigger

CREATE TRIGGER memberLogTrigger ON memberinfo
FOR INSERT,UPDATE,DELETE
AS
BEGIN
	DECLARE @id varchar(45)
	DECLARE @operation varchar(45)
	DECLARE @desc varchar(45)
	IF exists(SELECT * FROM inserted)
	BEGIN
		IF exists(SELECT * FROM inserted)
		BEGIN
			SELECT @id=member_id FROM inserted
			SELECT @operation = 'Updated...'
			SELECT @desc = 'Member Details Updated...'
		END
	ELSE
	BEGIN
		SELECT @id=member_id FROM inserted;
		SELECT @operation='Inserted...'
		SELECT @desc = 'Member Details Inserted...'
	END
	END
	
	ELSE IF exists(SELECT * FROM deleted)
	BEGIN
		SELECT @id=member_id FROM deleted;
		SELECT @operation='Deleted...'
		SELECT @desc = 'Member Details Deleted...'
	END


	INSERT INTO memberLog VALUES(GETDATE(),@id,@operation, @desc)
	print'successful...'
END

UPDATE memberinfo SET gender = '0' WHERE member_id = 'M1';
SELECT * FROM memberinfo
DELETE FROM memberinfo WHERE member_id = 'M501';
SELECT * FROM memberLog