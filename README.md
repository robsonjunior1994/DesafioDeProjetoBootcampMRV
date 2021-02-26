# DesafioDeProjetoBootcampMRV
Bootcamp MRV na Digital Innovation One -  Criando um APP simples de cadastro de séries em .NET

### RASCUNHO PARA FINAL DO PROJETO

# 1 - Primeiro commit:

Nesse primeiro commit eu criei os Modelos do meu projeto, serie, midia e genero, midia é uma classe abstrata que é implementada pela serie, e Enum é usado como tipo dentro de serie, criei a opção de adicionar na lista de série uma série, como id fiz um pouco diferente do projeto feito em aula(era criado um medoto que retornava a quantidade da lista de serie), eu criei uma propriedade static dentro de serie com um adição a cada criação de uma serie então eu vou sempre aumentar um numero a esse campo chamado index(Fiz assim para experimentar o uso do static), e pego desse numero o valor pra preencher o campo Id de serie, e para separar a aplicação em mais uma camada, criei uma classe ServiceSerie que faz toda a lógica de adicionar Serie a Lista de Serie, despoluindo a minha classe Program.
