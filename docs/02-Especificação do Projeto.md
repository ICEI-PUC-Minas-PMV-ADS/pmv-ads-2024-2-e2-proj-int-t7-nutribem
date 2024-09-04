# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

Persona 1: Nutricionista
- Nome: Ana Karla Silva
- Idade: 30 anos
- Formação: Nutricionista com especialização em Nutrição Esportiva.
- Experiência: 5 anos de prática clínica.

Persona 2: Nutricionista
- Nome: Larissa Teixeira Alves
- Idade: 35 anos
- Formação: Nutricionista, com especialização em Nutrição Clínica e Esportiva
- Experiência: 10 anos de experiência em consultório próprio, atendendo
principalmente pacientes com objetivo de emagrecimento e reeducação
alimentar.

Persona 3: Cliente
- Nome: Marcos Pereira
- Idade: 28 anos
- Profissão: Analista de Marketing.

Persona 4: Cliente
- Nome: Vera Lúcia de Lima
- Idade: 37 anos
- Profissão: Supervisora de atendimento e mãe ocupada
 


## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA` | QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`|
|------|-----------------------------------------|----|
|Nutricionista1  | Aumentar a visibilidade e atrair novos clientes, oferecer um serviço mais eficiente e personalizado, facilitar o acompanhamento do progresso dos clientes. | Dificuldade em gerenciar agendamentos e consultas. Necessidade de ferramentas para monitorar a evolução dos clientes.
|Nutricionista2  | Aumentar a sua base de pacientes e consolidar sua marca como referência em emagrecimento na sua região, oferecer um atendimento mais personalizado e eficiente aos seus pacientes, otimizando o seu tempo e recursos.Utilizar a tecnologia para se conectar com seus pacientes de forma mais dinâmica e engajadora. | Falta de tempo para consultas presenciais. Dificuldade em seguir dietas sem acompanhamento.
|Cliente 3  | Perder 10 kg em 3 meses. Aprender a fazer escolhas alimentares saudáveis. Receber suporte e motivação de um profissional.| Falta de tempo para consultas presenciais. Dificuldade em seguir dietas sem acompanhamento.
|Cliente 4  | Praticidade: tem uma rotina muito ocupada e precisa de soluções rápidas e práticas para a alimentação da família. Receitas Rápidas: Ela busca receitas saudáveis que possam ser preparadas em menos de 30 minutos.| Planejamento de Refeições:Necessita de um recurso que ajude a planejar as refeições da semana, considerando as preferências alimentares dos filhos. Informações Nutricionais: Quer saber mais sobre os nutrientes dos alimentos que está oferecendo à sua família.


## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Cadastrar nutricionista como usuário, através da criação de um perfil com informações pessoais gerais ligadas a sua formação.| ALTA | 
|RF-002| Cadastrar um paciente como usuário, com informações pessoais em geral, objetivos e dados ligados a sua saúde (IMC, altura, idade, etc.) | ALTA |
|RF-003| Cadastrar um plano alimentar pelo nutricionista para seu respectivo paciente, com receitas, ingredientes, valor nutricional básico (calorias, proteínas, gorduras, etc.) | ALTA |
|RF-004| Fazer comentário sobre o plano alimentar pelo paciente| BAIXA | 
|RF-005| Fazer modificações no plano alimentar do paciente pelo nutricionista | ALTA | 
|RF-006| Registrar o diário alimentar do paciente com informações sobre horário das refeições, calorias ingeridas, ingredientes consumidos, etc por meio de um campo Editável| ALTA | 
|RF-007| Propor dicas de receitas por nutricionistas e pacientes| MÉDIA | 
|RF-008| Registrar perda de peso do paciente ao longo do tempo e exibir o histórico desta informação| ALTA | 
|RF-009| Avaliar as receitas propostas (like ou joinha) | BAIXA | 
|RF-010| Calcular índice de massa corpórea para o usuário nutricionista| ALTA |


### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| Responsividade para dispositivos móveis | ALTA | 
|RNF-002| Proteção contra acesso não autorizado | ALTA | 
|RNF-003| Tempo de resposta à requisições inferior a 1 segundo | ALTA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| O back-end não pode ser projetado em outra linguagem que não seja C#|
|03| Não poderá ser utilizado framework no front-end a não ser o Bootstrap|


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de caso de uso pode ser observado abaixo:

<img src= "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-2-e2-proj-int-t7-nutribem/blob/1834e5e2842a02d7f4fd754f6d37ff89d091bb75/docs/img/D.%20Caso%20de%20uso%20Nutribem%20final.png"/>
