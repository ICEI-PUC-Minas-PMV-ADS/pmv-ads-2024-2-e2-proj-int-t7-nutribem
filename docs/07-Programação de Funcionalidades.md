# Programação de Funcionalidades

Implementação do sistema descrita por meio dos requisitos funcionais e/ou não funcionais. Nesta seção foi relacionado os requisitos atendidos com os artefatos criados (código fonte) e com o(s) responsável(is) pelo desenvolvimento de cada artefato a cada etapa. 

|ID    | Descrição do Requisito Funcional  | Artefatos produzidos | Aluno(a) responsável |
|------|-----------------------------------------|----|----|
|RF-001| Cadastrar nutricionista como usuário, através da criação de um perfil com informações pessoais gerais ligadas a sua formação.|Crud completo|Guilherme|
|RF-002| Nutricionista cadastra um paciente e utiliza CRUD's para o seu gerenciamento. |Crud completo|Guilherme|
|RF-003| Cadastrar um paciente como usuário, com informações pessoais em geral, objetivos e dados ligados a sua saúde (altura, idade, etc.). | Em andamento |Guilherme|
|RF-004| Realizar login utilizando CPF e senha. | Tela de login com senha incriptada |Guilherme, Karina e Victor|
|RF-005| Cadastrar um plano alimentar pelo nutricionista e utiliza CRUD's para o seu gerenciamento.|Crud completo|Joel|
|RF-006| O paciente Registra o diário alimentar com informações sobre horário das refeições, calorias ingeridas, ingredientes consumidos, etc por meio de um campo Editável.|Crud completo|Ana|
|RF-007| Propor dicas de receitas por nutricionistas e pacientes e utiliza CRUD's para o seu gerenciamento.| Crud completo|Ana|
|RF-008| Avaliar as receitas propostas (like ou joinha). |Like|Karina|
|RF-009| Permitir que tanto o paciente quanto o nutricionista alterem seus dados de cadastro.|Tela de edição de cadastro|Guilherme|
<br>

|ID    | Descrição do Requisito não Funcional  | Artefatos produzidos | Aluno(a) responsável |
|------|-----------------------------------------|----|----|
|RNF-001| Responsividade para dispositivos móveis |Em andamento|Todos|
|RNF-002| Proteção contra acesso não autorizado |incriptação da senha e itens de segurança|Guilherme, Karina e Victor|
|RNF-003| Tempo de resposta à requisições inferior a 1 segundo |Em andamento|Todos|




# Instruções de acesso
## Requisito atendido
### RF-001-Cadastrar nutricionista como usuário, através da criação de um perfil com informações pessoais gerais ligadas a sua formação.
O acessoa criação do usuário deve ser realizado pelo menu lateral, clicando em "Criar conta como nutricionista", após deve ser preenchido dados solicitados e assim que completo os dados, clicar em "Salvar"
<br>
**Link criar usuário:** https://nutribem-a3gzgfhqhbfyh4cd.brazilsouth-01.azurewebsites.net/<br>
**Link criar um Nutricionista:** https://nutribem-a3gzgfhqhbfyh4cd.brazilsouth-01.azurewebsites.net/Nutricionistas/Create
<br> <p align="center">
**Exemplo da tela de acesso a criar Usuários:**
<br>
<br>
<img src= "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-2-e2-proj-int-t7-nutribem/blob/aa09b09831bf71642b271cb940fd1da697ece7b0/docs/img/Tela%20efetiva%20da%20cria%C3%A7%C3%A3o%20de%20usuario.jpeg">
<br> <p align="center">
**Exemplo da tela de criar Nutricionista:**
<br>
<br>
<img src= "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-2-e2-proj-int-t7-nutribem/blob/aa09b09831bf71642b271cb940fd1da697ece7b0/docs/img/Tela%20efetiva%20criar%20nutricionista.jpeg">
<br>


### RF-002-Nutricionista cadastra um paciente e utiliza CRUD's para o seu gerenciamento e RF-003 Cadastrar um paciente como usuário, com informações pessoais em geral, objetivos e dados ligados a sua saúde (altura, idade, etc.)
O acesso a criação do paciente deve ser realizado pelo nutricionista após login, deve clicar no ícone "Pacientes" e/ou menu lateral clica em "Pacientes", após ser direcionado a nova página clica em "Adicionar novo paciente"
Após deve ser preenchido dados solicitados e assim que completo o cadastro clicar em "Salvar".
<br>
**Link página paciente:** https://nutribem-a3gzgfhqhbfyh4cd.brazilsouth-01.azurewebsites.net/<br>
**Link criando um paciente:** https://nutribem-a3gzgfhqhbfyh4cd.brazilsouth-01.azurewebsites.net/Pacientes/Create
<br> <p align="center">
**Exemplo da tela Pacientes:**
<br>
<br>
<img src= "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-2-e2-proj-int-t7-nutribem/blob/aa09b09831bf71642b271cb940fd1da697ece7b0/docs/img/Tela%20efetiva%20paciente.png">
<br> <p align="center">
**Exemplo da tela Criar pacientes:**
<br>
<br>
<img src= "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-2-e2-proj-int-t7-nutribem/blob/aa09b09831bf71642b271cb940fd1da697ece7b0/docs/img/Tela%20efetiva%20criar%20um%20paciente.jpeg">
<br>

### RF-004-Realizar login utilizando CPF e senha.
O acesso ao login deve ser realizado clicando em "Logar como nutricionista" ou "Logar como paciente"
<br>
**Link para nutricionista:** https://nutribem-a3gzgfhqhbfyh4cd.brazilsouth-01.azurewebsites.net/Nutricionistas/Login <br>
**Link para paciente:** https://nutribem-a3gzgfhqhbfyh4cd.brazilsouth-01.azurewebsites.net/Pacientes/Login
<br> <p align="center">
**Exemplo da tela Login Nutricionista:**
<br>
<br>
<img src= "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-2-e2-proj-int-t7-nutribem/blob/c50b82c0cdfc98c69fae826b8c2d93c9bb6fa0c8/docs/img/Tela%20efetiva%20Login%20Nutricionista.png">
<br> <p align="center">
**Exemplo da tela Login Paciente:**
<br>
<br>
<img src= "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-2-e2-proj-int-t7-nutribem/blob/c50b82c0cdfc98c69fae826b8c2d93c9bb6fa0c8/docs/img/Tela%20efetiva%20Login%20Paciente.png">
<br>

### RF-005-Cadastrar um plano alimentar pelo nutricionista e utiliza CRUD's para o seu gerenciamento.
O acesso para criar um plano alimentar é realizado pelo usuário nutricionista, após realizar o login, deve clicar no ícone "Plano alimentar" e/ou menu lateral clica em "Planos alimentares", após ser direcionado a nova página clica em "Novo plano alimentar". Deve ser preenchido dados solicitados e assim que completo o plano alimentar clicar em "Criar".<br>
**Link para plano alimentar:** https://nutribem-a3gzgfhqhbfyh4cd.brazilsouth-01.azurewebsites.net/PlanosAlimentares <br>
**Link para criar plano alimentar:** https://nutribem-a3gzgfhqhbfyh4cd.brazilsouth-01.azurewebsites.net/PlanosAlimentares/Create
<br> <p align="center">
**Exemplo da tela Plano alimentar:**
<br>
<br>
<img src= "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-2-e2-proj-int-t7-nutribem/blob/aa09b09831bf71642b271cb940fd1da697ece7b0/docs/img/Tela%20efetiva%20de%20plano%20alimentar.png">
<br> <p align="center">
**Exemplo da tela Criar plano alimentar:**
<br>
<br>
<img src= "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-2-e2-proj-int-t7-nutribem/blob/aa09b09831bf71642b271cb940fd1da697ece7b0/docs/img/Tela%20efetiva%20de%20criar%20do%20plano%20alimentar.png">
<br>



### RF-006-O paciente Registra o diário alimentar com informações sobre horário das refeições, calorias ingeridas, ingredientes consumidos, etc por meio de um campo Editável.
O acesso para criar um registro no diário alimentar é realizado pelo usuário paciente, após realizar o login, deve clicar no ícone "Diário alimentar" e/ou menu lateral clica em "Diário alimentar", após ser direcionado a nova página clica em "Adicionar anotação". Deve ser preenchido dados solicitados e assim que completo o plano alimentar clicar em "Salvar".<br>
**Link para diário alimentar:** https://nutribem-a3gzgfhqhbfyh4cd.brazilsouth-01.azurewebsites.net/Comentarios <br>
**Link para criar diário alimentar:** https://nutribem-a3gzgfhqhbfyh4cd.brazilsouth-01.azurewebsites.net/Comentarios/Create
<br> <p align="center">
**Exemplo da tela Diário alimentar:**
<br>
<br>
<img src= "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-2-e2-proj-int-t7-nutribem/blob/aa09b09831bf71642b271cb940fd1da697ece7b0/docs/img/Tela%20efetiva%20do%20diario%20alimentar.png">
<br> <p align="center">
**Exemplo da tela Criar Diário alimentar:**
<br>
<br>
<img src= "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-2-e2-proj-int-t7-nutribem/blob/aa09b09831bf71642b271cb940fd1da697ece7b0/docs/img/Tela%20efetiva%20de%20criar%20di%C3%A1rio%20alimentar.png">
<br>


### RF-007-Propor dicas de receitas por nutricionistas e pacientes e utiliza CRUD's para o seu gerenciamento e RF-008-Avaliar as receitas propostas (like ou joinha). 
O acesso para criar uma é realizado pelos usuários após realizarem o login, deve clicar no ícone "Receitas" e/ou menu lateral clica em "Receitas", após ser direcionado a nova página clica em "Criar nova receita". Deve ser preenchido dados solicitados e assim que completo clicar em "Salvar".<br>
Para curtir a receita clicar em cima do nome da receita que deseja curtir, será apresentada a receita e também o botão de curtida, clicar no ícone de coração que será contabilizada a curtida.
Para retirar curtida basta clicar novamente no ícone coração que será retirada a curtida.<br>
**Link para receitas:** https://nutribem-a3gzgfhqhbfyh4cd.brazilsouth-01.azurewebsites.net/Receitas <br>
**Link para criar receitas:** https://nutribem-a3gzgfhqhbfyh4cd.brazilsouth-01.azurewebsites.net/Receitas/Create
<br> <p align="center">
**Exemplo da tela Receitas:**
<br>
<br>
<img src= "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-2-e2-proj-int-t7-nutribem/blob/aa09b09831bf71642b271cb940fd1da697ece7b0/docs/img/Tela%20efetiva%20de%20receitas.png">
<br> <p align="center">
**Exemplo da tela Criar receitas:**
<br>
<br>
<img src= "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-2-e2-proj-int-t7-nutribem/blob/aa09b09831bf71642b271cb940fd1da697ece7b0/docs/img/Tela%20efetiva%20criar%20receita.jpeg">
<br>

### RF-009-Permitir que tanto o paciente quanto o nutricionista alterem seus dados de cadastro.
O acesso para editar o cadastro é realizado pelos usuários após realizarem o login, deve clicar no ícone "Nutricionistas" e/ou menu lateral clica em "Nutricionista" para usuário nutricionista, e para pacientes deve clicar no ícone "Pacientes" e/ou menu lateral clica em "Pacientes", será direcionado a nova página, deve clicar no próprio nome e após em "Editar", alterar o dado que deseja e após em clicar "Salvar".<br>
**Link para editar Nutricionistas:** https://nutribem-a3gzgfhqhbfyh4cd.brazilsouth-01.azurewebsites.net/Nutricionistas/Edit <br>
**Link para editar pacientes:** https://nutribem-a3gzgfhqhbfyh4cd.brazilsouth-01.azurewebsites.net/Pacientes/Edit
<br> <p align="center">
**Exemplo da tela Editar dados do Nutricionista:**
<br>
<br>
<img src= "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-2-e2-proj-int-t7-nutribem/blob/aa09b09831bf71642b271cb940fd1da697ece7b0/docs/img/Tela%20efetiva%20editar%20Nutricionista.jpeg">
<br> <p align="center">
**Exemplo da tela Editar dados do Paciente:**
<br>
<br>
<img src= "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-2-e2-proj-int-t7-nutribem/blob/aa09b09831bf71642b271cb940fd1da697ece7b0/docs/img/tela%20efetiva%20editar%20paciente.jpeg">
<br>
