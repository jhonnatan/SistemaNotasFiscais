-- Popula os tratamentos Fiscais
use Teste;
go

begin try
	begin tran;
	-- SP / RJ
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='SP', @pEstadoDestino='RJ', @pCfop='6.000', @pBrinde=0, @pTipoIcms='10', @pAliquotaIcms=0.17, @pAliquotaIpi=10, @pReducaoBaseIcms=0, @pDesconto=10
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='SP', @pEstadoDestino='RJ', @pCfop='6.000', @pBrinde=1, @pTipoIcms='60', @pAliquotaIcms=0.18, @pAliquotaIpi=0, @pReducaoBaseIcms=0, @pDesconto=10

	-- SP / PE
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='SP', @pEstadoDestino='PE', @pCfop='6.001', @pBrinde=0, @pTipoIcms='10', @pAliquotaIcms=0.17, @pAliquotaIpi=10, @pReducaoBaseIcms=0, @pDesconto=0
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='SP', @pEstadoDestino='PE', @pCfop='6.001', @pBrinde=1, @pTipoIcms='60', @pAliquotaIcms=0.18, @pAliquotaIpi=0, @pReducaoBaseIcms=0, @pDesconto=0
	
	-- SP / MG
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='SP', @pEstadoDestino='MG', @pCfop='6.002', @pBrinde=0, @pTipoIcms='10', @pAliquotaIcms=0.17, @pAliquotaIpi=10, @pReducaoBaseIcms=0, @pDesconto=10
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='SP', @pEstadoDestino='MG', @pCfop='6.002', @pBrinde=1, @pTipoIcms='60', @pAliquotaIcms=0.18, @pAliquotaIpi=0, @pReducaoBaseIcms=0, @pDesconto=10
   
	-- SP / PB
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='SP', @pEstadoDestino='PB', @pCfop='6.003', @pBrinde=0, @pTipoIcms='10', @pAliquotaIcms=0.17, @pAliquotaIpi=10, @pReducaoBaseIcms=0, @pDesconto=0
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='SP', @pEstadoDestino='PB', @pCfop='6.003', @pBrinde=1, @pTipoIcms='60', @pAliquotaIcms=0.18, @pAliquotaIpi=0, @pReducaoBaseIcms=0, @pDesconto=0
	         
	-- SP / PR
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='SP', @pEstadoDestino='PR', @pCfop='6.004', @pBrinde=0, @pTipoIcms='10', @pAliquotaIcms=0.17, @pAliquotaIpi=10, @pReducaoBaseIcms=0, @pDesconto=0
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='SP', @pEstadoDestino='PR', @pCfop='6.004', @pBrinde=1, @pTipoIcms='60', @pAliquotaIcms=0.18, @pAliquotaIpi=0, @pReducaoBaseIcms=0, @pDesconto=0
	         
	-- SP / PI
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='SP', @pEstadoDestino='PI', @pCfop='6.005', @pBrinde=0, @pTipoIcms='10', @pAliquotaIcms=0.17, @pAliquotaIpi=10, @pReducaoBaseIcms=0, @pDesconto=0
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='SP', @pEstadoDestino='PI', @pCfop='6.005', @pBrinde=1, @pTipoIcms='60', @pAliquotaIcms=0.18, @pAliquotaIpi=0, @pReducaoBaseIcms=0, @pDesconto=0
	         
	-- SP / RO
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='SP', @pEstadoDestino='RO', @pCfop='6.006', @pBrinde=0, @pTipoIcms='10', @pAliquotaIcms=0.17, @pAliquotaIpi=10, @pReducaoBaseIcms=0, @pDesconto=0
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='SP', @pEstadoDestino='RO', @pCfop='6.006', @pBrinde=1, @pTipoIcms='60', @pAliquotaIcms=0.18, @pAliquotaIpi=0, @pReducaoBaseIcms=0, @pDesconto=0
	                            
	-- SP / SE
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='SP', @pEstadoDestino='SE', @pCfop='6.007', @pBrinde=0, @pTipoIcms='10', @pAliquotaIcms=0.17, @pAliquotaIpi=10, @pReducaoBaseIcms=0, @pDesconto=0
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='SP', @pEstadoDestino='SE', @pCfop='6.007', @pBrinde=1, @pTipoIcms='60', @pAliquotaIcms=0.18, @pAliquotaIpi=0, @pReducaoBaseIcms=0, @pDesconto=0
 
	-- SP / TO
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='SP', @pEstadoDestino='TO', @pCfop='6.008', @pBrinde=0, @pTipoIcms='10', @pAliquotaIcms=0.17, @pAliquotaIpi=10, @pReducaoBaseIcms=0, @pDesconto=0
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='SP', @pEstadoDestino='TO', @pCfop='6.008', @pBrinde=1, @pTipoIcms='60', @pAliquotaIcms=0.18, @pAliquotaIpi=0, @pReducaoBaseIcms=0, @pDesconto=0

	-- SP / PA
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='SP', @pEstadoDestino='PA', @pCfop='6.009', @pBrinde=0, @pTipoIcms='10', @pAliquotaIcms=0.17, @pAliquotaIpi=10, @pReducaoBaseIcms=0.9, @pDesconto=0
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='SP', @pEstadoDestino='PA', @pCfop='6.009', @pBrinde=1, @pTipoIcms='60', @pAliquotaIcms=0.18, @pAliquotaIpi=0, @pReducaoBaseIcms=0.9, @pDesconto=0
     
	-- MG / RJ
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='MG', @pEstadoDestino='RJ', @pCfop='6.000', @pBrinde=0, @pTipoIcms='10', @pAliquotaIcms=0.17, @pAliquotaIpi=10, @pReducaoBaseIcms=0, @pDesconto=0
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='MG', @pEstadoDestino='RJ', @pCfop='6.000', @pBrinde=1, @pTipoIcms='60', @pAliquotaIcms=0.18, @pAliquotaIpi=0, @pReducaoBaseIcms=0, @pDesconto=0
                 
	-- MG / PE
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='MG', @pEstadoDestino='PE', @pCfop='6.001', @pBrinde=0, @pTipoIcms='10', @pAliquotaIcms=0.17, @pAliquotaIpi=10, @pReducaoBaseIcms=0, @pDesconto=0
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='MG', @pEstadoDestino='PE', @pCfop='6.001', @pBrinde=1, @pTipoIcms='60', @pAliquotaIcms=0.18, @pAliquotaIpi=0, @pReducaoBaseIcms=0, @pDesconto=0
        
	-- MG / MG
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='MG', @pEstadoDestino='MG', @pCfop='6.002', @pBrinde=0, @pTipoIcms='60', @pAliquotaIcms=0.18, @pAliquotaIpi=10, @pReducaoBaseIcms=0, @pDesconto=0
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='MG', @pEstadoDestino='MG', @pCfop='6.002', @pBrinde=1, @pTipoIcms='60', @pAliquotaIcms=0.18, @pAliquotaIpi=0, @pReducaoBaseIcms=0, @pDesconto=0
      
	-- MG / PB
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='MG', @pEstadoDestino='PB', @pCfop='6.003', @pBrinde=0, @pTipoIcms='10', @pAliquotaIcms=0.17, @pAliquotaIpi=10, @pReducaoBaseIcms=0, @pDesconto=0
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='MG', @pEstadoDestino='PB', @pCfop='6.003', @pBrinde=1, @pTipoIcms='60', @pAliquotaIcms=0.18, @pAliquotaIpi=0, @pReducaoBaseIcms=0, @pDesconto=0
   	         
	-- MG / PR
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='MG', @pEstadoDestino='PR', @pCfop='6.004', @pBrinde=0, @pTipoIcms='10', @pAliquotaIcms=0.17, @pAliquotaIpi=10, @pReducaoBaseIcms=0, @pDesconto=0
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='MG', @pEstadoDestino='PR', @pCfop='6.004', @pBrinde=1, @pTipoIcms='60', @pAliquotaIcms=0.18, @pAliquotaIpi=0, @pReducaoBaseIcms=0, @pDesconto=0
   
	-- MG / PI
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='MG', @pEstadoDestino='PI', @pCfop='6.005', @pBrinde=0, @pTipoIcms='10', @pAliquotaIcms=0.17, @pAliquotaIpi=10, @pReducaoBaseIcms=0, @pDesconto=0
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='MG', @pEstadoDestino='PI', @pCfop='6.005', @pBrinde=1, @pTipoIcms='60', @pAliquotaIcms=0.18, @pAliquotaIpi=0, @pReducaoBaseIcms=0, @pDesconto=0

	-- MG / RO
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='MG', @pEstadoDestino='PI', @pCfop='6.006', @pBrinde=0, @pTipoIcms='10', @pAliquotaIcms=0.17, @pAliquotaIpi=10, @pReducaoBaseIcms=0, @pDesconto=0
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='MG', @pEstadoDestino='PI', @pCfop='6.006', @pBrinde=1, @pTipoIcms='60', @pAliquotaIcms=0.18, @pAliquotaIpi=0, @pReducaoBaseIcms=0, @pDesconto=0
      
	-- MG / SE
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='MG', @pEstadoDestino='SE', @pCfop='6.007', @pBrinde=0, @pTipoIcms='10', @pAliquotaIcms=0.17, @pAliquotaIpi=10, @pReducaoBaseIcms=0, @pDesconto=0
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='MG', @pEstadoDestino='SE', @pCfop='6.007', @pBrinde=1, @pTipoIcms='60', @pAliquotaIcms=0.18, @pAliquotaIpi=0, @pReducaoBaseIcms=0, @pDesconto=0
     
	-- MG / TO
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='MG', @pEstadoDestino='TO', @pCfop='6.008', @pBrinde=0, @pTipoIcms='10', @pAliquotaIcms=0.17, @pAliquotaIpi=10, @pReducaoBaseIcms=0, @pDesconto=0
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='MG', @pEstadoDestino='TO', @pCfop='6.008', @pBrinde=1, @pTipoIcms='60', @pAliquotaIcms=0.18, @pAliquotaIpi=0, @pReducaoBaseIcms=0, @pDesconto=0
   
	-- MG / SE
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='MG', @pEstadoDestino='SE', @pCfop='6.009', @pBrinde=0, @pTipoIcms='10', @pAliquotaIcms=0.17, @pAliquotaIpi=10, @pReducaoBaseIcms=0.9, @pDesconto=0
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='MG', @pEstadoDestino='SE', @pCfop='6.009', @pBrinde=1, @pTipoIcms='60', @pAliquotaIcms=0.18, @pAliquotaIpi=0, @pReducaoBaseIcms=0.9, @pDesconto=0
  
	-- MG / PA
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='MG', @pEstadoDestino='PA', @pCfop='6.010', @pBrinde=0, @pTipoIcms='10', @pAliquotaIcms=0.17, @pAliquotaIpi=10, @pReducaoBaseIcms=0, @pDesconto=0
	exec dbo.P_TRATAMENTO_FISCAL  @pId=0, @pEstadoOrigem='MG', @pEstadoDestino='PA', @pCfop='6.010', @pBrinde=1, @pTipoIcms='60', @pAliquotaIcms=0.18, @pAliquotaIpi=0, @pReducaoBaseIcms=0, @pDesconto=0
       
	commit;           
end try
begin catch
	rollback;
	throw;
end catch