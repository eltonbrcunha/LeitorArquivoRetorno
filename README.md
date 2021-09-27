# LeitorArquivoRetorno
Leito de Arquivos de Pagamentos com integração com API de Leitura de pagamento.


<h2>Apresentação  :speech_balloon:</h2> 
Programa para leitura de arquivos de retorno no Padrão (Leiaute do Arquivo Padrão FEBRABAN 150 - SIACC), para visualização das informações do arquivo, versão com banco de dados em SQL apenas para demonstração de rotina.

<h2>Imagens do projeto :computer:</h2> 

![alt text](https://github.com/eltonbrcunha/LeitorArquivoRetorno/blob/main/LeitorArquivoRetorno/imagens/001.jpg)

![alt text](https://github.com/eltonbrcunha/LeitorArquivoRetorno/blob/main/LeitorArquivoRetorno/imagens/002.jpg)

<h2>Instruções de Uso :blue_book:</h2>
Na pasta arquivos há alguns arquivos de retornos para serem testados e validados, bem como um script em SQL para replicação do banco de dados inicial, possibilitando a inclusões livremente de novos boletos, desde que os códigos de barras constem dentro dos arqvivos.

Após finalizar a inclusão do banco de dados, ao executar o sistema, localize o arquivo de retorno, para ser lido e o sistema irá identificar com o sinal <strong>VERDE</strong> os que constam no banco de dados
e de <strong>VERMELHO</strong> os que não foram encontrados

</br>
<strong>Observação</strong> 
Necessário ter um banco de dado SQL configurado para validar a leitura e baixa dos arquivos.
Se atentar que há uma <strong>PROCEDURE</strong> responsável pela inclusão das linhas dos arquivos, para teste, que se encontra no script geral do banco de dados.

<h2>Sobre a Tecnologia usada</h2>
:white_check_mark: Linguagem: C# </br>
:white_check_mark: Banco de Dados: SQL Server </br>

<h2>Conceitos Usados</h2>
Modelagem DDD

<h2> Desenvolvedor :technologist:</h2>
Elto Brito
Linkedin: (https://www.linkedin.com/in/elton-cunha-87631056)
