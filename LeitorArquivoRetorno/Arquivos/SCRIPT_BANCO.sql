
create table Pessoa
(IdPessoa int identity not null
,NomePessoa varchar(100) not null
,NomeFantasia varchar(150)
,DocumentoPessoa varchar(14) not null
,TipoPessoa char(1) not null
);

alter table Pessoa add constraint Pk_IdPessoa primary key(IdPessoa);
alter table Pessoa with check add constraint TipoPessoa check (TipoPessoa in ('f', 'j'))


create table Boleto
(IdBoleto int identity not null
,DataVencimento date
,ValorBoleto money
,IdPessoa int 
,DataPagamento  date
,SituacaoBoleto char(1)
,NumeroCodigoBarras varchar(44)
,DataCredito date
,ValorPagamento money
)

alter table Boleto add constraint Pk_IdBoleto primary key(IdBoleto);
alter table Boleto with check add constraint fk_IdPessoa foreign key (IdPessoa) references Pessoa(IdPessoa); 
 

-- ROTINA INSERIR BOLETOS
CREATE PROCEDURE INSERIRBOLETO(@LINHA VARCHAR(150))  
AS  
  
DECLARE @VALORBOLETO MONEY  
DECLARE @DATAPAGAMENTO DATETIME  
DECLARE @DATACREDITO DATETIME  
DECLARE @NUMEROCODIGOBARRAS VARCHAR(150)  
  
  
SELECT   
@DATAPAGAMENTO=  
CAST(  
CONCAT  
(SUBSTRING(  
@LINHA,28,2)  
,'/',  
SUBSTRING(  
@LINHA,26,2)  
,  
'/',SUBSTRING(  
@LINHA,22,4)) AS DATETIME)  
,  
@DATACREDITO=  
CAST(  
CONCAT  
(SUBSTRING(  
@LINHA,36,2)  
,'/'  
,SUBSTRING(  
@LINHA,34,2)  
,  
'/',  
SUBSTRING(  
@LINHA,30,4)) AS DATETIME)  
,  
@NUMEROCODIGOBARRAS=  
(SUBSTRING(  
@LINHA,38,44)  
  
)  
  
,  
@VALORBOLETO=  
CAST(  
SUBSTRING(  
LTRIM(@LINHA),82,12)  
AS MONEY  
)/100   
  
  
  
INSERT INTO BOLETO(DataVencimento,ValorBoleto,IdPessoa,DataPagamento,SituacaoBoleto,NumeroCodigoBarras)  
VALUES('2021-12-31',@VALORBOLETO,1,NULL,'N',@NUMEROCODIGOBARRAS)  
  

--INSERINTO BOLETOS
EXEC INSERIRBOLETO 'G816710000020001     2020073020200803816700000000253184520200730010500000059331120000000002530000460000000011893    27E80A2361B66AAD7       1         '
EXEC INSERIRBOLETO 'G816710000020001     2020073020200803816500000000253184520200730010500000059327120000000002530000460000000021893    216B920CE4C0111B1       1         '
EXEC INSERIRBOLETO 'G816710000020001     2020073020200803816000000000591184520200730010500000059330120000000005910000460000000031893    2939F0869B8ADCEE7       1         '
EXEC INSERIRBOLETO 'G816710000020001     2020073020200803816200000000591184520200730010500000059329120000000005910000460000000041893    24DDC4362432D7E57       1         '
EXEC INSERIRBOLETO 'G816710000020001     2020073020200803816400000001425184520200730010500000059328120000000014250000460000000051893    2306F715CFA71F59F       1         '
EXEC INSERIRBOLETO 'G816710000020001     2020073020200803816500000003331184520200730010500000059332120000000033310000460000000061893    22176036F42CCF2EF       1         '
EXEC INSERIRBOLETO 'G816710000020001     2020073020200803816600000002000184520200731010100000064217070000000020000000600000000078167    554F41F5037FB0679       1         '
EXEC INSERIRBOLETO 'G816710000020001     2020120120201203816100000002000184520201210010100000065478070000000020000000460000000018167    3AFF9BF993F827D38       1         '
EXEC INSERIRBOLETO 'G816710000020001     2020120120201203816300000002000184520201210010100000065477070000000020000000460000000028167    3621B6CD7F832FCDE       1         '
EXEC INSERIRBOLETO 'G816710000020001     2020120320201207816700000002548184520201211000100000061384010000000025480000460000000011091    388C0AA788DD3C74A       1         '
EXEC INSERIRBOLETO 'G816710000020001     2019103120191104816000000002790184520191130000100000056893010000000027900000600000000018167    504744FCD2F4DF72B       1         '
EXEC INSERIRBOLETO 'G816710000020001     2019103120191104816800000002790184520191130000100000053961010000000027900000600000000028167    5C4594EC97466564A       1         '
EXEC INSERIRBOLETO 'G816710000020001     2019103120191104816200000003132184520191130000100000054579010000000031320000600000000038167    5FCE6ACEED79BCF1D       1         '
EXEC INSERIRBOLETO 'G816710000020001     2019103120191104816700000003204184520191130000100000053079010000000032040000600000000048167    56091E2C07693DE3B       1         '
EXEC INSERIRBOLETO 'G816710000020001     2019103120191104816700000003420184520191130000100000054539010000000034200000600000000058167    588EF3AF1E88D833B       1         '
EXEC INSERIRBOLETO 'G816710000020001     2020101320201015816000000005000184520201020000400000065369040000000050000000460000000018167    6D5817D7B57A04B4B       1         '
EXEC INSERIRBOLETO 'G816710000020001     2020101320201015816800000010000184520201031003400000065371080000000100000000460000000028167    67B568000E9513012       1         '
EXEC INSERIRBOLETO 'G816710000020001     2020102820201030816000000002000184520201031010100000065401070000000020000000460000000018167    67B00C6ED66B162A9       1         '
EXEC INSERIRBOLETO 'G816710000020001     2020102820201030816200000002000184520201031010100000065400070000000020000000460000000028167    614C56C7F72C6D212       1         '
EXEC INSERIRBOLETO 'G816710000020001     2020102620201028816400000002000184520201031010100000065381070000000020000000460000000018167    6601569B9FC7B0E87       1         '
EXEC INSERIRBOLETO 'G816710000020001     2020102620201028816400000020000184520201030000400000065399040000000200000000460000000028167    66C7BC34EDC50079A       1         '
EXEC INSERIRBOLETO 'G816710000020001     2020102620201028816400000002000184520201031010100000065381070000000020000000460000000018167    6601569B9FC7B0E87       1         '
EXEC INSERIRBOLETO 'G816710000020001     2020102620201028816400000020000184520201030000400000065399040000000200000000460000000028167    66C7BC34EDC50079A       1         '
EXEC INSERIRBOLETO 'G816710000020001     2020101620201020816700000022200184520201031003100000065384080000000222000000460000000011091    6CA94C37297BBCFF2       1         '
EXEC INSERIRBOLETO 'G816710000020001     2020101620201020816300000002000184520201031010100000065386070000000020000000460000000028167    63495F60DAB1AD50A       1         '