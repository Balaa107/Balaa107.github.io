create table Employee(EmpNo int primary key identity,Ename nvarchar(100),Job nvarchar(100),MGR nvarchar(100),Hiredate varchar(50),Salary float,DeptNo int,FOREIGN KEY (DeptNo) REFERENCES Department(DeptNo))
create table Department(DeptNo int primary key identity,Dname nvarchar(100),Location nvarchar(100))
