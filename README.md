# DesafioDeProjetoBootcampMRV
Bootcamp MRV na Digital Innovation One -  Criando um APP simples de cadastro de séries em .NET

### RASCUNHO PARA FINAL DO PROJETO

# 1 - Primeiro etapa:

Nesse primeiro commit eu criei os Modelos do meu projeto, serie, midia e genero, midia é uma classe abstrata que é implementada pela serie, e Enum é usado como tipo dentro de serie, criei a opção de adicionar na lista de série uma série, como id fiz um pouco diferente do projeto feito em aula(era criado um medoto que retornava a quantidade da lista de serie), eu criei uma propriedade static dentro de serie com um adição a cada criação de uma serie então eu vou sempre aumentar um numero a esse campo chamado index(Fiz assim para experimentar o uso do static), e pego desse numero o valor pra preencher o campo Id de serie, e para separar a aplicação em mais uma camada, criei uma classe ServiceSerie que faz toda a lógica de adicionar Serie a Lista de Serie, despoluindo a minha classe Program.

# 2 - Segunda etapa 

Nessa segunda etapa, eu criei o listar series a forma que criei foi parecida com a que foi ensinada, usando o operador ternário para exibição do status deletado ou ativo a série, mas eu fiz uma modificação na classe serie, coloquei as propriedades como publicas e alterei a visibilidade do modificador SET para privado, para poder recuperar a propriedade com o GET e não criar mais código, ja que existe o GET pronto.

# 3 - Terceira etapa

Nessa etapa eu criei o excluir, tive que fazer uma alteração na adição do ID que acontece na classe série, ele é uma propriedade static que pertence a classe, eu coloquei para que a adição dele no construtor seja depois de adicionar o primeiro id de valor 0 a serie que é inserida na lista
