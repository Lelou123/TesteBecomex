# TesteBecomex
<h2>Teste para vaga de desenvolvedor back end Junior na empresa Becomex</h2>

<h2>Abaixo narrei como a minha primeira impressão após analisar o projeto e o que ele deveria conter.</h2>

<h3>Básico:</h3>
Api fazendo chamada de todos países
Se o cache com informações não for vazio não precisa fazer outra call de api 

Basicamente uma api que faz uma chamada e guarda os dados dessa outra api.

Essa api vai fazer consultas no dados armazenados.
	Consultas feitas pelo campo nome do pais, sigla ou moeda e vai retornar uma lista de países ou um pais 

Interface:
	Listando os países com paginação
	Campo de pesquisa para inserir os dados a serem pesquisados.
	Ao selecionar um pais deve mostrar em uma aba ou model informações extras sobre o pais como: População, Timezone, 
		Moedas (currencies), Línguas (languages), Capital, Blocos 
		econômicos (Regional Blocks) e Países que fazem fronteira (bordering countries)
    
<h3>Parte 2:</h3>
	Pegar dois determinados países, traçar a rota a partir dos países fronteira e apresentar a ordem correta que seria feito o translado 

<h3>Linha de raciocínio</h3>
Comecei fazendo o design de como seria feito as telas, após isso parti para estudar a api, todos dados que ela me fornecia e como os consumir,
vi que tinha a possibilidade de ao invés de utilizar os métodos mais conhecidos para realizar as requisições da api como httpclient ou restsharp a api possuía uma biblioteca no .net que facilitava as requisições https://github.com/egbakou/RESTCountries.NET, estudei como deveria fazer para utilizar a biblioteca e de primeira tive alguns bugs por conta de estar com a do restsharp instalado e ambas se colidiam, após resolver esse erro consegui fazer a primeira requisição de todos países na tela principal e comecei a organizar em uma tabela os países retornados... Após isso passei o nome do pais que fosse selecionado para o controller e o utilizei para fazer uma nova requisição a esse pais especifico e retornar seus dados. Ao concluir esse método eu fui em busca de fazer o filtro, mas tive uma dificuldade em passar para o controller o dado inserido por conta de estar já utilizando um model de List na view, passei então utilizando json mas meu tempo estava acabando após isso e não consegui terminar o filtro. Meus próximos passos seriam terminar o filtro adaptar o controller para receber requisições externas fazer o mapeamento de rotas e inserir os extras citados abaixo






<h4>O que consegui completar no projeto?</h4>


- Interfaces.
- Chamada da Api
- Mostar todos os países
- Acessar dados de um país específico


<h4>O que faltou completar no projeto?</h4>
- Filtros > Cheguei a completar a função mas por conta de um bug achei melhor entregar sem do que correr o risco de quebrar o projeto.
- Adaptar controller para conseguir receber requisições get externas.
- Mapeamento de rota entre dois países.
- Mostar todos países.
- Filtro retornando lista de países a partir do nome inserido, sigla ou moeda.

<h4>Extras que pretendia fazer:</h4>
- Paginação após 10 países
- Opção de ver todos sem paginação
- Filtros em ordem A-Z ou Z-A
- Filtro de Ordenação por continente ou bloco econômico
