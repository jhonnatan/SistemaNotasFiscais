/*	Valores agrupadors por CFOP */
	
if OBJECT_ID('P_CFOP') is not null
	drop procedure dbo.P_CFOP;
go

create procedure dbo.P_CFOP
as
begin
	select 
		cfop, 
		SUM(BaseIcms) as totalBaseIcms, 
		SUM(ValorICMS) as totalValorICMS, 
		SUM(BaseIpi) totalBaseIpi, 
		SUM(ValorIPI) as totalValorIPI 
	from NotaFiscalItem
	group by cfop;
end;