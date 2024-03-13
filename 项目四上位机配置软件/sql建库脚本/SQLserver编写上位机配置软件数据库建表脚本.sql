use master --查询系统数据库，将要创建数据库是否存在
go

if exists(select * from sysdatabases where name='ProConfigDB')
drop database ProConfigDB  --如果存在ProConfigDB的数据库，就将其删除
go
--创建主数据文件,日志文件，文件名，地址，文件大小
create database ProConfigDB
on primary
(
	name='ProConfigDB_data',
	filename='C:\SQLserverDB\ProConfigDB_mdf',
	size=200MB,
	filegrowth=100MB
)
log on
(
	
	name='ProConfigDB_log',
	filename='C:\SQLserverDB\ProConfigDB_log',
	size=200MB,
	filegrowth=100MB
)
go

use ProConfigDB
go

--创建用户表
if exists(select * from sysobjects where name='SysAdmins')
drop table SysAdmins
go
create table SysAdmins
(
	SysAdminID int identity(10,1) primary key,--主键SysAdminID,自增(100，1)，
	SysAccount varchar(100) unique check(len(SysAccount)>=4),--唯一键，用户账号SysAccount  长度约束>=4
	AdminName varchar(100) not null,--非空约束 SysAdminName
	AdminPwd varchar(18) check(len(AdminPwd)>=6 and len(AdminPwd)<=18) not null--用户密码 SysAdminPwd,长度约束>=6,<=18
)
go

--创建项目表
if exists(select * from sysobjects where name='Projects')
drop table Projects
go
create table Projects
(
	ProjectID int identity(100,1) primary key,--主键SysAdminID,自增(100，1)，
	ProjectName varchar(100) not null
)
go

--创建设备类型表
if exists(select * from sysobjects where name='EquipMentType')
drop table EquipMentType
go
create table EquipMentType
(
	EtypeID int identity(10,1) primary key,--主键SysAdminID,自增(100，1)，
	EtypeName varchar(100) not null
)
go

--创建协议类型表
if exists(select * from sysobjects where name='ProTocolType')
drop table ProTocolType
go
create table ProtocolType
(
	ProtocolTypeID int identity(10,1) primary key,--主键SysAdminID,自增(100，1)，
	EtypeID int references EquipMentType(EtypeID),--外键，设备类型ID
	PtypeName varchar(100) not null
)
go

--创建设备表
if exists(select * from sysobjects where name='EquipeMents')
drop table EquipeMents
go
create table EquipeMents
(
	EquipeMentID int identity(100,1) primary key,--主键SysAdminID,自增(100，1)，
	ProjectID int references Projects(ProjectID), --外键关联 项目ID
	EtypeID int references EquipMentType(EtypeID),-- 外键关联 设备类型ID
	PtypeID int  references ProtocolType(ProtocolTypeID),--外键关联 协议类型ID
	EquipeMent varchar(100) not null,
	IpAddress varchar(100),
	ProtNo varchar(50),
	SeriablNo varchar(50),
	BaudRate  int,
	DataBit int,
	ParityBit varchar(50),
	StopBit int,
	OPCNodeName varchar(100),
	OPCCserverName varchar(100),
	IsEnable  int,
	Comments nvarchar(200)
)
go


--通信组表
if exists(select * from sysobjects where name='CommunicationsGroups')
drop table CommunicationsGroups
go
create table CommunicationsGroups
(
	CGID int identity(10000,1) primary key,--主键SysAdminID,自增(100，1)，
	EtypementID int references EquipeMents(EquipeMentID), --关联设备ID
	CGName nvarchar(100) not null,
	StartAddress varchar(100),
	CGlength int,
	IsEnable int,
	Commnets  nvarchar(200)
)
go

--变量表
if exists(select * from sysobjects where name='Variables')
drop table Variables
go
create table Variables
(
	VariableID int identity(100000,1) primary key,--主键SysAdminID,自增(100，1)，
	VariableName varchar(100) not null,--
	CGID int references CommunicationsGroups(CGID), --外键关联，通信组ID
	StartAddress  varchar(100),
	DataType Varchar(100),
	IsMaxAlarm bit,
	IsMinAlarm bit,
	AlarmMax varchar(100),
	AlarmMin varchar(100),
	IsFile bit,
	AlarmMaxNode nvarchar(200),
	AlarmMinNode nvarchar(200),
	Scale varchar(100),
	OffsetORlength varchar(100),
	Comments nvarchar(200)
)
go


--插入数据,用户名，设备类型，协议类型
insert into sysadmins(SysAccount,adminname,adminpwd)
values('Admin','管理员','123456'),('wenqiaocui','文憔悴','jgw5201314')

insert into EquipMentType(EtypeName)
values('以太网'),('串口'),('OPC')

insert into ProtocolType(EtypeID,PtypeName)
values(10,'西门子S7'),(10,'三菱MC'),(10,'三菱AIE'),(10,'欧姆龙FlnsTCP'),(10,'ModbusTCP'),
 (10,'ModbusRTUOverTCP'),(11,'三菱FXSerial'),(11,'ModbusRTU'),(12,'OPCDA'),(12,'OPCUA')

 select * from sysadmins
 select * from EquipMentType
 select  * from ProtocolType
