# Teste de Desenvolvimento

**PORTA PADRÃO DO PROJETO (em localhost): _50679_**

Faça download do repositório em uma pasta local. Em seguida inicie a Solução pelo Visual Studio com o arquivo **Teste - CTIS.sln**. Execulte a aplicação utilizando um navegador, preferencialmente Google Chrome.

Manual de execução
- GET

  Para teste por método GET deve ser utilizada a url **localhost:50679/api/simulador** e enviado os seguintes parâmetros pela URL:
  - **valor**: Valor total de crédito a ser calculado
  - **total**: Quantidade de parcelas que será utilizada para cálculo
  
  Formato da URL final: **localhost:50679/api/simulador?valor=10000&total=10**, e será exibido no navegador a resposta em JSON.



- POST

  Em POST é necessário um simulador de requisição, como o Postman proposto na atividade. Altere o método para POST, caso não esteja. Em seguida insira na caixa da URL o seguinte valor: http://localhost:50679/api/simulador. No botão **"Params"** insira dois parâmetros:
  - **ValorTotal**: Valor total de crédito a ser calculado
  - **QtdParcela**: Quantidade de parcelas que será utilizada para cálculo
  
  Em seguida envie a requisição pelo botão **Send**. A resposta, também em JSON, será resultada na aba *body* abaixo dos parâmetros.
