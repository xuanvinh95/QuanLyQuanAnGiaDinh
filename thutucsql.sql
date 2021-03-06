USE [DatabaseQLQN]
GO

CREATE proc [dbo].[PSP_HoaDon_Luu]
	@MaMon varchar(6) , 
	@SoLuong int, 
	@ThanhGia float
as
GO


CREATE Proc [dbo].[PSP_XoaBan]
	@Khu varchar
	as
	delete Khu where Khu=(select top 1 * from Khu
	where left(Khu,1)=@Khu
	order by Khu desc
	)
GO

 
create proc [dbo].[PSP_ThucDon_Select]
@MaPL varchar
as
select ROW_NUMBER() over (order by (select 1)) as STT,MaMon, TenMon, DonGia  from ThucDon
where left(MaMon,1)=@MaPL
GO


create proc [dbo].[PSP_ThucDon_LayTenMon]
	@MaMon varchar(6)
	as
		select * from ThucDon where MaMon=@MaMon
GO


create proc [dbo].[PSP_ThucDon_Delete]
@MaMon varchar(6)
As

delete ThucDon
where MaMon=@MaMon

if @@ROWCOUNT >0
select 1 maso,N'Xóa Thành Công' as thongbao
else
select 0 maso,N'Xóa không Thành Công' as thongbao
GO



create proc [dbo].[PSP_ThucDon_CapNhat]
@MaMon varchar(6)
, @TenMon nvarchar(50)
, @DonGia float
as
if exists (select 1 from ThucDon where MaMon=@MaMon)
	begin --update
		update ThucDon
		set 
		  TenMon=@TenMon
		, DonGia=@DonGia
		where  MaMon=@MaMon
	end --update
else
	begin --insert
		insert into ThucDon values(@MaMon,@TenMon, @DonGia)
	end--insert
GO



CREATE Proc [dbo].[PSP_THemBan]
	@Ban varchar(3)
	as
		insert Khu(Khu)
		values (@Ban)
GO



CREATE proc [dbo].[PSP_BanHang_LayDanhSachMon]
@Loai varchar
as
	select ROW_NUMBER() over (order by (select 1)) as STT,MaMon, TenMon, DonGia
	from ThucDon where LEFT(MaMon,1)=@Loai;
GO



create proc [dbo].[PSP_reset_matkhau]
	@MaNV varchar(6)
	as	
		update NhanVien set MatKhau=PWDENCRYPT(123)
		where MaNV=@MaNV
GO




create proc [dbo].[PSP_NhanVien_Xoa]
@MaNV varchar(6)
as
delete NhanVien
where MaNV=@MaNV
GO




CREATE proc [dbo].[PSP_NhanVien_ThemSua]
  @MaNV varchar(6)
, @TenNV nvarchar(50)
, @PhaiNam bit
, @DiaChi nvarchar(100)
,@ChucVu nvarchar(50)
, @TaiKhoan varchar(30)
, @MatKhau varchar(128)
as
if exists (select 1 from NhanVien where MaNV=@MaNV)
	begin--update
		update NhanVien
		set
				
			TenNV=@TenNV
			, PhaiNam=@PhaiNam
			, DiaChi=@DiaChi
			,	ChucVu=@ChucVu
		where MaNV=@MaNV
	end
else
	begin--insert
		
			insert into NhanVien(MaNV, TenNV, PhaiNam, DiaChi, ChucVu, TaiKhoan, MatKhau)
			values(@MaNV,@TenNV, @PhaiNam, @DiaChi,@ChucVu, @TaiKhoan,pwdencrypt(@MatKhau))
		
	end
GO



create proc [dbo].[PSP_NhanVien_taikhoan]
	@MaNV varchar(6)
	as
		select TaiKhoan from NhanVien where MaNV=@MaNV
GO





create proc [dbo].[PSP_NhanVien_MaNV]
	@TaiKhoan varchar(30)
	as
		select MaNV from NhanVien where TaiKhoan=@TaiKhoan
GO



CREATE proc [dbo].[PSP_NhanVien_KiemTraDangNhap]
	@TaiKhoan varchar(30),
	@MatKhau varchar(20)
	as
	Select MaNV, TenNV, PhaiNam, DiaChi, ChucVu, TaiKhoan, MatKhau
	from NhanVien
	where TaiKhoan=@taikhoan and PWDCOMPARE(@MatKhau,MatKhau)=1
GO



CREATE proc [dbo].[PSP_LayNhanVientheomaso]
@MaNhanVien varchar(6)
as
if(@MaNhanVien=0)
begin
select  ROW_NUMBER() over (order by (select 1)) as STT,MaNV
, TenNV
, case PhaiNam when 0 then 'Nam' else N'Nữ' end as PhaiNam
, DiaChi
,ChucVu
, TaiKhoan
from NhanVien
where LEFT(MaNV,2)='NV'
end
else
begin
select  ROW_NUMBER() over (order by (select 1)) as STT,MaNV
, TenNV
, case PhaiNam when 0 then 'Nam' else N'Nữ' end as PhaiNam
, DiaChi
,ChucVu
, TaiKhoan
from NhanVien
where MaNV=@MaNhanVien and LEFT(MaNV,2)='NV'

end
GO



CREATE Proc [dbo].[PSP_LayKhu]
	@Khu varchar
	as
		select * from Khu where LEFT(Khu,1)=@Khu
GO




create proc [dbo].[PSP_laybangNhanVien]
	as
	select * from NhanVien where LEFT(MaNV,2)='NV'
GO




create proc [dbo].[PSP_KiemTraTKTonTai]
	@TaiKhoan varchar(30)
	as
		if(exists (select 1 from NhanVien where TaiKhoan=@TaiKhoan))
		select err =1
		else
		select err =0
GO




create proc [dbo].[PSP_Khohang_Update]
	@nhaphang bit
	,@MaSP int
	, @SoLgSP float
	as
		declare  @n float
		set @n=(select SoLgSP from KhoHang where MaSp=@MaSP)
		if(@nhaphang=1)
			update KhoHang
			set SoLgSP=@SoLgSP+@n where MaSP=@MaSP
		else 
			update KhoHang
			set SoLgSP=@n-@SoLgSP where MaSP=@MaSP
GO



create proc [dbo].[PSP_KhoHang_Select]
	as	
	select ROW_NUMBER() over (order by (select 1)) as STT,MaSP, TenSP, SoLgSP, DonVi from KhoHang
GO




CREATE Proc [dbo].[DoiMatKhau]
@MaNV varchar(6),
@matkhaucu varchar(32),  
@matkhaumoi varchar(32)
as
if(exists(select TaiKhoan From NhanVien 
where MaNV=@MaNV and PWDCOMPARE(@matkhaucu,MatKhau)=1))
begin
	update NhanVien set MatKhau = pwdencrypt(@matkhaumoi)
	where MaNV=@MaNV
	select err = 0
end
else
	select err = 1
GO




create proc [dbo].[PSP_ChiTietMon_Xoa]
	@MaMon varchar(6)
	,@MaSP int
	as
		delete ChiTietMon where MaMon=@MaMon and MaSP=@MaSP
GO




create proc [dbo].[PSP_ChiTietMon_Select]
	@MaMon varchar(6)
	as
		
			select ROW_NUMBER() over (order by (select 1)) as STT,
				 a.MaSP,TenSP, LuongDung, a.DonVi
			from ChiTietMon a inner join KhoHang b on a.MaSP=b.MaSP
			where MaMon=@MaMon
GO



create proc [dbo].[PSP_ChiTietMon]
	  @MaMon varchar(6)
	, @TenSP nvarchar(50)
	, @LuongDung float 
	, @DonVi nvarchar(15)--MaXuat, MaSP, SoLgSP, DonVi, Gia1DonVi, ThanhTien

	as
		if(not exists (select * from KhoHang where TenSP=@TenSP))
			begin 
				insert KhoHang(TenSP, SoLgSP, DonVi)
				values (@TenSP, 0, @DonVi)
			end
		declare @MaSP as float
		set @MaSP=(select MaSP from KhoHang where TenSP=@TenSP)
		
		if(
			not exists(select * from ChiTietMon where MaSP=@MaSP and MaMon=@MaMon ))
			begin		
				insert ChiTietMon(MaMon, MaSP, LuongDung, DonVi)
				values ( @MaMon,@MaSP, @LuongDung, @DonVi)
			end
		else
			if(exists (select * from ChiTietMon where MaSP=@MaSP and MaMon=@MaMon))
			begin
				update ChiTietMon
				set LuongDung=@LuongDung,DonVi=@DonVi
				where MaMon=@MaMon and MaSP=@MaSP
			end
GO



CREATE proc [dbo].[PSP_HoaDonChuaTinh]
	as
		select ROW_NUMBER() over (order by (select 1)) as STT,MaHD, TongTien, NgayHoaDon 
		from HoaDon
		where TinhTien=0;
GO



create proc [dbo].[PSP_NhapXuatKho_select]
	@nhaphang int 
	as 
		if(@nhaphang=1) 
			select * from NhapKho
		else 	select * from XuatKho
GO



CREATE proc [dbo].[PSP_NhapKho_select_ngay] 
	@tungay date,
	@denngay date
	as
		select ROW_NUMBER() over (order by (select 1)) as STT,MaNhap, MaNV, NgayNhap from NhapKho
		where  CONVERT(date, NgayNhap) between @tungay and @denngay
GO



CREATE proc [dbo].[PSP_BangHoaDon]
	@Ban varchar(3)
as
	select * from HoaDon where LEFT(MaHD,3)=@Ban
GO



CREATE proc [dbo].[PSP_tungaydenngay] 
@tungay date,
@denngay date
as
select ROW_NUMBER()over (order by (select 1)) as STT,MaHD,MaNV,CONVERT(date, NgayHoaDon) as NgayLapHoaDon ,TongTien
from HoaDon	
where  TinhTien=1 and CONVERT(date,NgayHoaDon)  between @tungay and @denngay
GO



CREATE proc [dbo].[PSP_XuatKho_select_ngay]
	@tungay date,
	@denngay date
	as
		select ROW_NUMBER() over (order by (select 1)) as STT,MaXuat, MaNV, NgayXuat from XuatKho
		where  CONVERT(date, NgayXuat) between @tungay and @denngay
GO



CREATE proc [dbo].[PSP_XoaHoaDon]
	@MaHD varchar(8)
	as
	delete Chitiethoadon where MaHD=@MaHD or left(MaHD,1) not in('A','B','C')
	delete HoaDon where MaHD=@MaHD or left(MaHD,1) not in('A','B','C')
GO



CREATE proc [dbo].[PSP_uotluongnguyenlieu] 
@tungay date,
@denngay date
as
select ROW_NUMBER()over (order by (select 1)) as STT,b.MaSP,CONVERT(date, a.NgayXuat)as NgayXuat,b.SoLgSP,Gia1Donvi,(b.SoLgSP*c.Gia1Donvi)as ThanhTien
from (XuatKho a inner join ChitietXK b on a.MaXuat=b.MaSP)inner join ChitietNK c on b.MaSP=c.MaSP
where CONVERT(date, NgayXuat) between @tungay and @denngay
GO



CREATE proc [dbo].[PSP_TinhTien]
	@MaHD varchar(6)
	as
		
		update HoaDon
		set TinhTien=1,TongTien=(select SUM(ThanhGia) as TongTien 
								from Chitiethoadon 
								where MaHD=@MaHD
								group by MaHD )
		where MaHD=@MaHD
GO


create proc [dbo].[PSP_XuatKho_TongTren1SP_TheoNgay]
	@tungay date,
	@denngay date
	as
	select MaSP,Sum(SoLgSP)as SoLgSP
	from ChitietXK  a inner join XuatKho b on a.MaXuat=b.MaXuat
	where CONVERT(date, NgayXuat) between @tungay and @denngay
	group by MaSP
GO


create proc [dbo].[PSP_Sosanh_BanXuat]  
	@tungay date,
	@denngay date
	as
		select TenSP,(SUM(SoLuong)*LuongDung)as UocTinh,TongSLXuat,b.DonVi
		from HoaDon aa inner join
				Chitiethoadon a on aa.MaHD=a.MaHD
				inner join ChiTietMon b  on a.MaMon=b.MaMon
				inner join KhoHang k on k.MaSP=b.MaSP
				inner join 
				(
					select MaSP,Sum(SoLgSP)as TongSLXuat
					from ChitietXK  a inner join XuatKho b on a.MaXuat=b.MaXuat
					---where CONVERT(date, NgayXuat) between @tungay and @denngay
					where CONVERT(date, NgayXuat) between @tungay and @denngay
					group by MaSP
					)c on  b.MaSP= c.MaSP
				--inner join XuatKho  d on c.MaXuat=d.MaXuat
		where CONVERT(date, NgayHoaDon) between @tungay and @denngay
		group by TenSP,LuongDung,TongSLXuat,b.DonVi
GO

create proc [dbo].[PSP_HoaDOn_SoLuong_Update] --'A02022','B002',10
	@MaHD varchar(8),
	@MaMon varchar(6),
	@Soluong int
	as
		if exists(select * from Chitiethoadon 
						   where MaHD=@MaHD and MaMon=@MaMon)
		begin
			declare @ThanhGia as float
			set @ThanhGia=(select DonGia from ThucDon where MaMon=@MaMon)
			if(@Soluong<=0)
				begin
					delete Chitiethoadon where MaHD=@MaHD and MaMon=@MaMon
				end
			else
				begin
					update Chitiethoadon
					set SoLuong=@Soluong,ThanhGia=@Soluong*@ThanhGia 
					where MaHD=@MaHD and MaMon=@MaMon
				end
			
		end
GO


CREATE proc [dbo].[PSP_hoadon_IN]
@mahd varchar(6)
as
set xact_abort on
begin tran
select ROW_NUMBER() over (order by (select 1)) as STT,a.MaHD,b.TenMon,a.NgayHoaDon,c.SoLuong ,b.DonGia,(c.SoLuong*b.DonGia)as ThanhTien
from (Chitiethoadon c inner join ThucDon b on c.MaMon=b.MaMon )inner join HoaDon a on a.MaHD=c.MaHD
where a.MaHD=@mahd
commit
GO


create proc [dbo].[PSP_GiaTbNguyenLieu]
	@tungay date,
	@denngay date
	as
		select MaSP, (SUM(ThanhTien)/Sum(SoLgSP))as GiaTB 
		from ChitietNK a inner join NhapKho b on a.MaNhap=b.MaNhap
		where CONVERT(date, NgayNhap) between @tungay and @denngay
		group by MaSP
GO


CREATE proc [dbo].[PSP_GiamMon]
	@MaHD varchar(8),
	@MaMon varchar(6)
	as
		if exists(select * from Chitiethoadon 
						   where MaHD=@MaHD and MaMon=@MaMon)
		begin
			declare @ThanhGia as float
			set @ThanhGia=(select DonGia from ThucDon where MaMon=@MaMon)
			declare @SoLuong as int
			set @SoLuong=(select SoLuong from Chitiethoadon where MaMon=@MaMon and MaHD=@MaHD)
			if(@SoLuong<=1)
				begin
					delete Chitiethoadon where MaHD=@MaHD and MaMon=@MaMon
				end
			else
				begin
					update Chitiethoadon
					set SoLuong=(@SoLuong-1),ThanhGia=(@SoLuong-1)*@ThanhGia 
					where MaHD=@MaHD and MaMon=@MaMon
				end
			
		end
GO


CREATE proc [dbo].[PSP_ChiTietXuatKho]
	  @MaXuat int
	, @MaNV varchar(6)
	, @TenSP nvarchar(50)
	, @SoLgSP float 
	, @DonVi nvarchar(15)--MaXuat, MaSP, SoLgSP, DonVi,  ,  


	as
		if(not exists (select * from KhoHang where TenSP=@TenSP))
			begin 
				insert KhoHang(TenSP, SoLgSP, DonVi)
				values (@TenSP, 0, @DonVi)
			end
		declare @MaSP as float
		set @MaSP=(select MaSP from KhoHang where TenSP=@TenSP)
		
		if(exists (select * from XuatKho where MaXuat=@MaXuat)and
		not exists(select * from ChitietXK where MaSP=@MaSP and MaXuat=@MaXuat ))
			begin		
				insert ChitietXK(MaXuat, MaSP, SoLgSP, DonVi  )
				values ( @MaXuat,@MaSP, @SoLgSP, @DonVi   )
			end
		else
			if(exists (select * from ChitietXK where MaXuat=@MaXuat and MaSP=@MaSP))
			begin
				update ChitietXK
				set SoLgSP=@SoLgSP,DonVi=@DonVi
				where MaXuat=@MaXuat and MaSP=@MaSP
			end
		
		if(not exists (select * from XuatKho where MaXuat=@MaXuat))
		begin
			insert XuatKho(MaXuat,MaNV)
			values (@MaXuat,@MaNV)
			insert ChitietXK(MaXuat, MaSP, SoLgSP, DonVi  )
			values (@MaXuat, @MaSP, @SoLgSP, @DonVi  )
		end
GO




CREATE proc [dbo].[PSP_ChiTietNK_NewGia] 
	@MaSP int 
	as	
		if(exists (select * from ChitietNK 
		where MaSP=@MaSP))
		begin
			select * from ChitietNK 
			where MaSP=@MaSP
			order by MaNhap desc
		end
GO


create proc [dbo].[PSP_ChiTietNhapXuat_Select]
	@nhaphang bit
	,@MaNhapXuat int
	as
		if(@nhaphang=1) 
			select ROW_NUMBER() over (order by (select 1)) as STT
				,MaNhap, a.MaSP,TenSP, a.SoLgSP, a.DonVi, a.Gia1DonVi, a.ThanhTien
			from ChitietNK a inner join KhoHang b on a.MaSP=b.MaSP
			where MaNhap=@MaNhapXuat
		else 	
			select ROW_NUMBER() over (order by (select 1)) as STT
				,MaXuat, a.MaSP,TenSP, a.SoLgSP, a.DonVi
			from ChitietXK a inner join KhoHang b on a.MaSP=b.MaSP
			where MaXuat=@MaNhapXuat
GO


create proc [dbo].[PSP_ChitietNhapXuat_delete]
	@nhaphang int
	,@MaNhapXuat int 
	, @MaSP int
	as
		if(@nhaphang=1) 
			begin
					if (@MaSP=0)
					begin 
						delete ChitietNK where MaNhap=@MaNhapXuat
						delete NhapKho where MaNhap=@MaNhapXuat
					end
					else
						delete ChitietNK where MaNhap=@MaNhapXuat and MaSP=@MaSP
																																
			end
		else
			begin
					if (@MaSP=0)
					begin 
						delete ChitietXK where MaXuat=@MaNhapXuat
						delete XuatKho where MaXuat=@MaNhapXuat
					end
					else
						delete ChitietXK where MaXuat=@MaNhapXuat and MaSP=@MaSP
																																
			end
GO


CREATE proc [dbo].[PSP_ChiTietNhapKho]
	  @MaNhap int
	, @MaNV varchar(6)
	, @TenSP nvarchar(50)
	, @SoLgSP float 
	, @DonVi nvarchar(15)--MaXuat, MaSP, SoLgSP, DonVi, Gia1DonVi, ThanhTien
	, @Gia1DonVi float
	, @ThanhTien float
	as
		if(not exists (select * from KhoHang where TenSP=@TenSP))
			begin 
				insert KhoHang(TenSP, SoLgSP, DonVi)
				values (@TenSP, 0, @DonVi)
			end
		declare @MaSP as float
		set @MaSP=(select MaSP from KhoHang where TenSP=@TenSP)
		
		if(exists (select * from NhapKho where MaNhap=@MaNhap)and
		not exists(select * from ChitietNK where MaSP=@MaSP and MaNhap=@MaNhap ))
			begin		
				insert ChitietNK(MaNhap, MaSP, SoLgSP, DonVi, Gia1DonVi, ThanhTien)
				values ( @MaNhap,@MaSP, @SoLgSP, @DonVi, @Gia1DonVi, @ThanhTien)
			end
		else
			if(exists (select * from ChitietNK where MaNhap=@MaNhap and MaSP=@MaSP))
			begin
				update ChitietNK
				set SoLgSP=@SoLgSP,DonVi=@DonVi,Gia1DonVi=@Gia1DonVi,ThanhTien=@ThanhTien
				where MaNhap=@MaNhap and MaSP=@MaSP
			end
		
		if(not exists (select * from NhapKho where MaNhap=@MaNhap))
		begin
			insert NhapKho(MaNhap,MaNV,TongTien)
			values (@MaNhap,@MaNV,0)
			insert ChitietNK(MaNhap, MaSP, SoLgSP, DonVi, Gia1DonVi, ThanhTien)
			values (@MaNhap, @MaSP, @SoLgSP, @DonVi, @Gia1DonVi, @ThanhTien)
		end
		
		update NhapKho
		set TongTien=(select SUM(ThanhTien) as TongTien 
								from ChitietNK
								where MaNhap=@MaNhap
								group by MaNhap )
		where MaNhap=@MaNhap
GO


CREATE proc [dbo].[PSP_ChitietHoaDon_select]
	@MaHD varchar(6)
	as
	select ROW_NUMBER() over (order by (select 1)) as STT, MaHD, a.MaMon,b.TenMon, SoLuong, ThanhGia 
	from Chitiethoadon a inner join ThucDon b on a.MaMon=b.MaMon
	where MaHD=@MaHD
GO


CREATE proc [dbo].[PSP_ChitietHoaDon]
	@MaHD varchar(8)
	,@MaNV varchar(6) 
	, @MaMon varchar(6)
	
as
	
	declare @ThanhGia as float
	set @ThanhGia=(select DonGia from ThucDon where MaMon=@MaMon)
	if(exists (select * from HoaDon where MaHD=@MaHD)and 
		not exists(select * from Chitiethoadon 
							where MaHD=@MaHD and MaMon=@MaMon))
	begin
		
		insert Chitiethoadon(MaHD, MaMon, SoLuong, ThanhGia)
		values (@MaHD,@MaMon,1,@ThanhGia)
	
	end
	else
	-----------------------------------------------------------
		if exists(select * from Chitiethoadon 
						   where MaHD=@MaHD and MaMon=@MaMon)
		begin
			
			declare @SoLuong as int
			set @SoLuong=(select SoLuong from Chitiethoadon where MaMon=@MaMon and MaHD=@MaHD)
			update Chitiethoadon
			set SoLuong=(@SoLuong+1),ThanhGia=(@SoLuong+1)*@ThanhGia 
			where MaHD=@MaHD and MaMon=@MaMon
		
		end
	if(not exists (select * from HoaDon where MaHD=@MaHD))
	begin
		insert HoaDon(MaHD,MaNV,TongTien, TinhTien)
		values (@MaHD,@MaNV,@ThanhGia,0)
		insert Chitiethoadon(MaHD, MaMon, SoLuong, ThanhGia)
		values (@MaHD,@MaMon,1,@ThanhGia)
	end
	-------------------------------------------------------------------
	update HoaDon
		set TinhTien=0,TongTien=(select SUM(ThanhGia) as TongTien 
								from Chitiethoadon 
								where MaHD=@MaHD
								group by MaHD )
		where MaHD=@MaHD
GO


CREATE proc [dbo].[PSP_ChiTietbaocao] --A01001'
@mahd varchar(6)
as
select ROW_NUMBER()over (order by (select 1)) as STT,a.MaHD,b.MaMon,b.TenMon,a.SoLuong,b.DonGia,(a.SoLuong*b.DonGia)as ThanhTien
from ChiTietHoaDon a inner join ThucDon b on a.MaMon=b.MaMon
where MaHD=@mahd
GO
