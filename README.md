# TesteBecomex
<h2>Teste para vaga de desenvolvedor back end Junior na empresa Becomex</h2>



<h3>Basico:</h3>
Api fazendo chamada de todos paises
Se o cache com informações não for vazio não precisa fazer outra call de api 

Basicamente uma api que faz uma chamada e guarda os dados dessa outra api.

Essa api vai fazer consultas no dados armazenados.
	Consultas feitas pelo campo nome do pais, sigla ou moeda e vai retornar uma lista de paises ou um pais 

Interface:
	Listando os paises com paginação
	Campo de pesquisa para inserir os dados a serem pesquisados.
	Ao selecionar um pais deve mostrar em uma aba ou model informações extras sobre o pais como: População, Timezone, 
		Moedas (currencies), Línguas (languages), Capital, Blocos 
		econômicos (Regional Blocks) e Países que fazem fronteira (bordering countries)
    
<h3>Parte 2:</h3>
	Pegar dois determinados paises, traçar a rota a partir dos paises fronteira e apresentar a ordem correta que seria feito o translado 

O que consegui completar no projeto?

- Interfaces.
- Chamada da Api
- Mostar todos países
- Acessar dados de um país especifico


O que faltou completar no projeto?
- Filtros > Cheguei a completar a função mas por conta de um bug achei melhor entregar sem do que correr o risco de quebrar o projeto.
- Adaptar controller para conseguir receber requisições get externas.
- Mapeamento de rota entre dois paises.
- Mostar todos países.
- Filtro retornando lista de países a partir do nome inserido, sigla ou moeda.

Extras que pretendia fazer:
- Paginação após 10 paises
- Opção de ver todos sem paginação
- Filtros em ordem A-Z ou Z-A
- Filtro de Ordenação por continente ou bloco econômico
