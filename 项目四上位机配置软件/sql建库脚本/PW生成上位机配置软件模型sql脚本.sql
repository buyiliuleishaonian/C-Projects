/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     2023/12/24 23:34:20                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CommunicationsGroup') and o.name = 'FK_COMMUNIC_REFERENCE_EQUIPMEN')
alter table CommunicationsGroup
   drop constraint FK_COMMUNIC_REFERENCE_EQUIPMEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Equipments') and o.name = 'FK_EQUIPMEN_REFERENCE_PROJECTS')
alter table Equipments
   drop constraint FK_EQUIPMEN_REFERENCE_PROJECTS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Equipments') and o.name = 'FK_EQUIPMEN_REFERENCE_EQUIPMEN')
alter table Equipments
   drop constraint FK_EQUIPMEN_REFERENCE_EQUIPMEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Equipments') and o.name = 'FK_EQUIPMEN_REFERENCE_PROTOCOL')
alter table Equipments
   drop constraint FK_EQUIPMEN_REFERENCE_PROTOCOL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ProtocolTyoe') and o.name = 'FK_PROTOCOL_REFERENCE_EQUIPMEN')
alter table ProtocolTyoe
   drop constraint FK_PROTOCOL_REFERENCE_EQUIPMEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Variables') and o.name = 'FK_VARIABLE_REFERENCE_COMMUNIC')
alter table Variables
   drop constraint FK_VARIABLE_REFERENCE_COMMUNIC
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CommunicationsGroup')
            and   type = 'U')
   drop table CommunicationsGroup
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EquipmentTyoe')
            and   type = 'U')
   drop table EquipmentTyoe
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Equipments')
            and   type = 'U')
   drop table Equipments
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Projects')
            and   type = 'U')
   drop table Projects
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ProtocolTyoe')
            and   type = 'U')
   drop table ProtocolTyoe
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SysAdmin')
            and   type = 'U')
   drop table SysAdmin
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Variables')
            and   type = 'U')
   drop table Variables
go

/*==============================================================*/
/* Table: CommunicationsGroup                                   */
/*==============================================================*/
create table CommunicationsGroup (
   CGID                 INT                  not null default 10000,
   EquipmentID          INT                  null,
   CGName               nvarchar(100)        null,
   StartAddress         varchar(100)        null,
   CGLength             int                  null,
   IsEnable             int                  null,
   Comments             nvarchar(200)        null,
   constraint PK_COMMUNICATIONSGROUP primary key (CGID)
)
go

/*==============================================================*/
/* Table: EquipmentTyoe                                         */
/*==============================================================*/
create table EquipmentTyoe
(
   EtypeID              int                  identity  (10,1),
   ETypeName            nVarchar(100)        null,
   constraint PK_EQUIPMENTTYOE primary key (EtypeID)
)
go

/*==============================================================*/
/* Table: Equipments                                            */
/*==============================================================*/
create table Equipments (
   EquipmentID          int                  not null,
   ProjectID            int                  null,
   EtypeID              int                  null,
   ProtocolTypeID       int                  null default 10,
   PtypeiID             int                  null,
   EquipmentName        varchar(100)         not null,
   IPAddRess            varchar(100)         null,
   PortNo               varchar(50)          null,
   SerialNO             varchar(50)          null,
   BaudRate             int                  null,
   DataBit              int                  null,
   ParityBit            varchar(50)          null,
   StopBit              int                  null,
   OPCNodeName          varchar(100)         null,
   OPCServerName        varchar(100)         null,
   IsEnable             int                  null,
   Comments             nvarchar(200)        null,
   constraint PK_EQUIPMENTS primary key (EquipmentID)
)
go

/*==============================================================*/
/* Table: Projects                                              */
/*==============================================================*/
create table Projects
(
   ProjectID            INT                  identity  (100,1),
   ProjectName          nvarchar(100)        null,
   constraint PK_PROJECTS primary key (ProjectID)
)
go

/*==============================================================*/
/* Table: ProtocolTyoe                                          */
/*==============================================================*/
create table ProtocolTyoe (
   ProtocolTypeID       int                  not null default 10,
   ETypeId              int                  not null,
   PtypeName            nVarchar(100)        not null,
   constraint PK_PROTOCOLTYOE primary key (ProtocolTypeID)
)
go

/*==============================================================*/
/* Table: SysAdmin                                              */
/*==============================================================*/
create table SysAdmin (
   SysAdminID           int                  identity (10,1),
   SysAccount           varchar(100)         not null
      constraint CKC_SYSACCOUNT_SYSADMIN check (len(SysAccount)>=4),
   AdminName            varbinary(100)       not null,
   AdminPwd             varbinary(8)         not null
      constraint CKC_ADMINPWD_SYSADMIN check (len(AdminPwd)>=6 and len(AdminPwd)<=18),
   constraint PK_SYSADMIN primary key (SysAdminID),
   constraint AK_KEY_2_SYSADMIN unique (SysAccount)
)
go

/*==============================================================*/
/* Table: Variables                                             */
/*==============================================================*/
create table Variables (
   VariableID           INT                  not null default 100000,
   VariableName         varchar(50)         null,
   CGID                 int                  null,
   StartAddress         varchar(100)         null,
   DataType             varchar(100)         null,
   IsMaxAlarm           bit                  null,
   IsMinAlarm           bit                  null,
   AlarmMax             varchar(100)         null,
   AlarmMin             varchar(100)         null,
   IsFiled              bit                  null,
   AlarmMaxNode         nvarchar(100)        null,
   AlarmMinNode         nvarchar(100)        null,
   Scale                float                null,
   Offset               float                null,
   Comments             nvarchar(200)        null,
   constraint PK_VARIABLES primary key (VariableID)
)
go

alter table CommunicationsGroup
   add constraint FK_COMMUNIC_REFERENCE_EQUIPMEN foreign key (EquipmentID)
      references Equipments (EquipmentID)
go

alter table Equipments
   add constraint FK_EQUIPMEN_REFERENCE_PROJECTS foreign key (ProjectID)
      references Projects (ProjectID)
go

alter table Equipments
   add constraint FK_EQUIPMEN_REFERENCE_EQUIPMEN foreign key (EtypeID)
      references EquipmentTyoe (EtypeID)
go

alter table Equipments
   add constraint FK_EQUIPMEN_REFERENCE_PROTOCOL foreign key (ProtocolTypeID)
      references ProtocolTyoe (ProtocolTypeID)
go

alter table ProtocolTyoe
   add constraint FK_PROTOCOL_REFERENCE_EQUIPMEN foreign key (ETypeId)
      references EquipmentTyoe (EtypeID)
go

alter table Variables
   add constraint FK_VARIABLE_REFERENCE_COMMUNIC foreign key (CGID)
      references CommunicationsGroup (CGID)
go

