use teste;
go

if OBJECT_ID('dbo.P_TRATAMENTO_FISCAL') is not null
	drop proc dbo.P_TRATAMENTO_FISCAL;
go

CREATE PROCEDURE dbo.P_TRATAMENTO_FISCAL
(
	@pId int output,
	@pEstadoOrigem varchar(2),
	@pEstadoDestino varchar(2),
	@pCfop varchar(5),
	@pBrinde bit,
	@pTipoIcms varchar(20),
	@pAliquotaIcms decimal(18,5),
	@pAliquotaIpi decimal(18,5),
	@pReducaoBaseIcms decimal(18,5),	
	@pDesconto decimal(18,5)
)
AS
BEGIN	
	declare @idTratamentoFiscal int = 0;
	
	-- Mesmo em caso de um novo tratamento fiscal, é verificado se a regra não está sendo duplicada
	if @pId = 0
	begin
		select @idTratamentoFiscal = id from dbo.[TratamentoFiscal]
		where EstadoOrigem = @pEstadoOrigem
			and EstadoDestino = @pEstadoDestino			
			and Brinde = @pBrinde
	end

	IF (@pId = 0 AND @idTratamentoFiscal = 0)		
	BEGIN 

		INSERT INTO [dbo].[TratamentoFiscal]
			   ([EstadoOrigem]
			   ,[EstadoDestino]
			   ,[Cfop]
			   ,[TipoIcms]
			   ,[AliquotaIcms]
			   ,[AliquotaIpi]
			   ,[ReducaoBaseIcms]
			   ,[Brinde]
			   ,[Desconto]
			   ,[DataAlteracao])
		 VALUES
			   (@pEstadoOrigem
			   ,@pEstadoDestino
			   ,@pCfop
			   ,@pTipoIcms
			   ,@pAliquotaIcms
			   ,@pAliquotaIpi
			   ,@pReducaoBaseIcms
			   ,@pBrinde
			   ,@pDesconto
			   ,getdate())
		
	END
	ELSE
	BEGIN

		UPDATE [dbo].[TratamentoFiscal]
		   SET [TipoIcms] = @pTipoIcms
			  ,[AliquotaIcms] = @pAliquotaIcms
			  ,[AliquotaIpi] = @pAliquotaIpi
			  ,[ReducaoBaseIcms] = @pReducaoBaseIcms			  
			  ,[Desconto] = @pDesconto
			  ,[DataAlteracao] = getdate()
		 where EstadoOrigem  = @pEstadoOrigem
			and EstadoDestino  = @pEstadoDestino			
			and Brinde = @pBrinde
	END
END
go

if OBJECT_ID('dbo.P_TRATAMENTO_FISCAL') is not null
    PRINT '<<< PROCEDURE dbo.P_TRATAMENTO_FISCAL CRIADA >>>'
ELSE
    PRINT '<<< FALHA NA CRIACAO DA PROCEDURE dbo.P_TRATAMENTO_FISCAL >>>'
go