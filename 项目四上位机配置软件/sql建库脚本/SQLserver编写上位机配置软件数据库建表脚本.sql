use master --��ѯϵͳ���ݿ⣬��Ҫ�������ݿ��Ƿ����
go

if exists(select * from sysdatabases where name='ProConfigDB')
drop database ProConfigDB  --�������ProConfigDB�����ݿ⣬�ͽ���ɾ��
go
--�����������ļ�,��־�ļ����ļ�������ַ���ļ���С
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

--�����û���
if exists(select * from sysobjects where name='SysAdmins')
drop table SysAdmins
go
create table SysAdmins
(
	SysAdminID int identity(10,1) primary key,--����SysAdminID,����(100��1)��
	SysAccount varchar(100) unique check(len(SysAccount)>=4),--Ψһ�����û��˺�SysAccount  ����Լ��>=4
	AdminName varchar(100) not null,--�ǿ�Լ�� SysAdminName
	AdminPwd varchar(18) check(len(AdminPwd)>=6 and len(AdminPwd)<=18) not null--�û����� SysAdminPwd,����Լ��>=6,<=18
)
go

--������Ŀ��
if exists(select * from sysobjects where name='Projects')
drop table Projects
go
create table Projects
(
	ProjectID int identity(100,1) primary key,--����SysAdminID,����(100��1)��
	ProjectName varchar(100) not null
)
go

--�����豸���ͱ�
if exists(select * from sysobjects where name='EquipMentType')
drop table EquipMentType
go
create table EquipMentType
(
	EtypeID int identity(10,1) primary key,--����SysAdminID,����(100��1)��
	EtypeName varchar(100) not null
)
go

--����Э�����ͱ�
if exists(select * from sysobjects where name='ProTocolType')
drop table ProTocolType
go
create table ProtocolType
(
	ProtocolTypeID int identity(10,1) primary key,--����SysAdminID,����(100��1)��
	EtypeID int references EquipMentType(EtypeID),--������豸����ID
	PtypeName varchar(100) not null
)
go

--�����豸��
if exists(select * from sysobjects where name='EquipeMents')
drop table EquipeMents
go
create table EquipeMents
(
	EquipeMentID int identity(100,1) primary key,--����SysAdminID,����(100��1)��
	ProjectID int references Projects(ProjectID), --������� ��ĿID
	EtypeID int references EquipMentType(EtypeID),-- ������� �豸����ID
	PtypeID int  references ProtocolType(ProtocolTypeID),--������� Э������ID
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


--ͨ�����
if exists(select * from sysobjects where name='CommunicationsGroups')
drop table CommunicationsGroups
go
create table CommunicationsGroups
(
	CGID int identity(10000,1) primary key,--����SysAdminID,����(100��1)��
	EtypementID int references EquipeMents(EquipeMentID), --�����豸ID
	CGName nvarchar(100) not null,
	StartAddress varchar(100),
	CGlength int,
	IsEnable int,
	Commnets  nvarchar(200)
)
go

--������
if exists(select * from sysobjects where name='Variables')
drop table Variables
go
create table Variables
(
	VariableID int identity(100000,1) primary key,--����SysAdminID,����(100��1)��
	VariableName varchar(100) not null,--
	CGID int references CommunicationsGroups(CGID), --���������ͨ����ID
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


--��������,�û������豸���ͣ�Э������
insert into sysadmins(SysAccount,adminname,adminpwd)
values('Admin','����Ա','123456'),('wenqiaocui','����','jgw5201314')

insert into EquipMentType(EtypeName)
values('��̫��'),('����'),('OPC')

insert into ProtocolType(EtypeID,PtypeName)
values(10,'������S7'),(10,'����MC'),(10,'����AIE'),(10,'ŷķ��FlnsTCP'),(10,'ModbusTCP'),
 (10,'ModbusRTUOverTCP'),(11,'����FXSerial'),(11,'ModbusRTU'),(12,'OPCDA'),(12,'OPCUA')

 select * from sysadmins
 select * from EquipMentType
 select  * from ProtocolType
