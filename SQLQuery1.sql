create database HangHoa
 ON primary 
 (name ='HangHoa',filename ='D:\NhapmonCs\database_HangHoa\HangHoa.mdf')
 LOG ON
 (name ='HangHoa_log',filename ='D:\NhapmonCs\database_HangHoa\HangHoa_log.ldf')
use HangHoa

create table DaiLy
(
		STT_DL int primary key,
		TEN_DL nvarchar(25) not null,
		DCHI_DL nvarchar(100) not null,
		SDT varchar(11)
)
create table HANGHOA
(
	MA_HANG nvarchar(3) primary key,

	TEN_HG nvarchar(20) not null,
	DVT nvarchar(12),
	NCC nvarchar(30),
)
drop table HANGHOA
create table BAN
(
	MA_HANG nvarchar(3) references HANGHOA(MA_HANG),
	STT_DL int references DAILY(STT_DL),
	NGAY_BAN smalldatetime not null check(NGAY_BAN <= GETDATE())default GETDATE(),
	SOLG_BAN int  not null check (SOLG_BAN >0),
	TRIGIA_BAN float not null check (TRIGIA_BAN>0),
	PRIMARY KEY (MA_HANG,STT_DL,NGAY_BAN)
)

create table MUA
(
	MA_HANG nvarchar(3) references HANGHOA(MA_HANG),
	STT_DL int references DAILY(STT_DL),
	NGAY_MUA smalldatetime not null check(NGAY_MUA <= GETDATE())default GETDATE(),
	SOLG_MUA int not null check(SOLG_MUA>0),
	TRIGIA_MUA float not null check(TRIGIA_MUA>0),
	PRIMARY KEY (MA_HANG,STT_DL,NGAY_MUA)
)
Select h.*,SOLG_MUA,TRIGIA_MUA,(SOLG_MUA * TRIGIA_MUA) as TongMUA,SOLG_BAN,TRIGIA_BAN,(SOLG_BAN * TRIGIA_BAN)as TongBAN,((SOLG_BAN * TRIGIA_BAN)-(SOLG_MUA * TRIGIA_MUA) )as LAI_LO from HANGHOA h join BAN b on h.MA_HANG = b.MA_HANG join MUA m on h.MA_HANG = m.MA_HANG

select (SOLG_MUA * TRIGIA_MUA) as SoTienMua ,(SOLG_BAN * TRIGIA_BAN) as SoTienBan from MUA,BAN