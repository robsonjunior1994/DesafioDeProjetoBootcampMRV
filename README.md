# DesafioDeProjetoBootcampMRV
Bootcamp MRV na Digital Innovation One -  Criando um APP simples de cadastro de séries em .NET

### RESUMO DO PROJETO
Foi bem proveitoso esse desafio, alguns pontos que acho que vale apena eu falar aqui é que:
- Separei em mais uma camada o programa, criei uma classe de serviço, coloquei ela como static então eu chamo ela sem ter que instanciar e tudo que precisa ser feito para manipular eu faço dentro dela, inclusive chamar a outra camada de Repository;
- Fiz uma pequena mudança quando vou adicionar um número ao ID de Série, eu criei uma propriedade statica que vai contando a cada criação de Série(no construtor da classe Série), e adiciono ao ID da Serie inserida na ListaDeSerie
- Fiz o uso dos operadores GET da classe Serie ao invés de criar um método para retornar eles;

### ETAPAS DO PROJETO

# 1 - Primeira etapa:
Nesse primeiro commit eu criei os Modelos do meu projeto, serie, mídia e gênero, mídia é uma classe abstrata que é implementada pela série, e Enum é usado como tipo dentro de serie, criei a opção de adicionar na lista de séries uma série, com o id fiz um pouco diferente do projeto feito em aula(era criado um método que retornava a quantidade da lista de series), eu criei uma propriedade static dentro de serie com um adição a cada criação de uma serie, então eu vou sempre aumentar um numero a esse campo chamado index(Fiz assim para experimentar o uso do static), e pego desse número o valor pra preencher o campo Id de serie, e para separar a aplicação em mais uma camada, criei uma classe ServiceSerie que faz toda a lógica de adicionar Serie a Lista de Serie, despoluindo a minha classe Program.

# 2 - Segunda etapa 

Nessa segunda etapa, eu criei o listar series a forma que criei foi parecida com a que foi ensinada, usando o operador ternário para exibição do status deletado ou ativo a série, mas eu fiz uma modificação na classe serie, coloquei as propriedades como públicas e alterei a visibilidade do modificador SET para privado, para poder recuperar a propriedade com o GET e não criar mais código, já que existe o GET pronto.

# 3 - Terceira etapa

Nessa etapa eu criei o excluir, tive que fazer uma alteração na adição do ID que acontece na classe série, ele é uma propriedade static que pertence a classe, eu coloquei para que a adição dele no construtor seja depois de adicionar o primeiro id de valor 0 a série que é inserida na lista

# 4 - Quarta etapa

Nessa etapa eu criei a opção de buscar por ID e a função de limpar a tela, nada de diferente para comentar

# 5 - Quinta etapa 

Nessa etapa eu criei o atualizar série por id, tive que fazer algumas mudanças para não ficar digitando código repetido, eu tive que abstrair a listagem do gênero para um método, e tive que alterar o retorno do ServiceSerie.BuscarPorId, para além de imprimir na tela retornar o objeto série, para atualizar a lista, não fiz nada de muito diferente do projeto produzido em aula.
