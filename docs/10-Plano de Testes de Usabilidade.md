# Plano de Testes de Usabilidade

## Objetivo

O objetivo do teste de usabilidade da plataforma Nutribem é avaliar a facilidade de uso, eficiência e satisfação dos usuários ao interagir com as principais funcionalidades da aplicação, garantindo que as necessidades dos nutricionistas e pacientes sejam atendidas de maneira intuitiva e funcional. A avaliação focará nas interações de cadastro, gestão de pacientes, planos alimentares e funcionalidades associadas à nutrição, como o diário alimentar e a avaliação de receitas.

## Seleção de Participantes

Os participantes deverão ter os seguintes perfis:

- **Nutricionistas:** Usuários com experiência em ferramentas digitais de saúde e gestão de pacientes.
- **Pacientes:** Usuários com interesse em dietas e controle de saúde alimentar.

## Procedimentos

Os testes serão realizados de forma remota, com moderação e gravação via plataformas como Google Meet ou Teams. O moderador orientará os usuários e observará suas interações, registrando dificuldades e feedbacks em tempo real.

#### **Etapas:**

1. **Apresentação das Tarefas:** Cada participante receberá uma lista de tarefas a serem realizadas, conforme seu perfil (Nutricionista ou Paciente).
2. **Execução das Tarefas:** O moderador acompanhará a execução, sem interferir diretamente, salvo em casos de dúvidas críticas.
3. **Observação e Registro:** Durante o teste, o moderador observará o comportamento dos usuários, focando em erros, dificuldades e comentários espontâneos.

## Tarefas para Nutricionistas

| Número | Descrição da Tarefa                                                                                                    | RF Relacionado |
|--------|----------------------------------------------------------------------------------------------------------------------  |----------------|
| 01     | Cadastrar-se como nutricionista no sistema, criando um perfil com suas informações pessoais gerais e de formação.      | RF-001         |
| 02     | Realizar login utilizando o CPF e senha cadastrados.                                                                   | RF-004         |
| 03     | Cadastrar um paciente com seus dados pessoais, altura, idade, objetivos de saúde, etc.                                 | RF-003         |
| 04     | Utilizar as funcionalidades de CRUD para editar as informações de um paciente cadastrado.                              | RF-003         |
| 05     | Cadastrar um plano alimentar para o paciente e gerenciá-lo usando as funcionalidades de CRUD.                          | RF-005         |
| 06     | Modificar o plano alimentar de um paciente, adicionando ou alterando receitas e valor nutricional.                     | RF-005         |
| 07     | Propor dicas de receitas e utilizar as funcionalidades de CRUD para o gerenciamento das mesmas.                        | RF-007         |
| 09     | Alterar os dados do seu perfil como nutricionista, conforme necessário.                                                | RF-009         |

## Tarefas para Pacientes

| Número | Descrição da Tarefa                                                                                                    | RF Relacionado |
|--------|----------------------------------------------------------------------------------------------------------------------- |----------------|
| 01     | Cadastrar-se como paciente no sistema, incluindo dados pessoais, objetivos e informações de saúde.                     | RF-003         |
| 02     | Realizar login utilizando o CPF e senha cadastrados.                                                                   | RF-004         |
| 03     | Visualizar o plano alimentar criado pelo nutricionista.                                                                | RF-005         |
| 04     | Registrar o diário alimentar com informações detalhadas sobre refeições, calorias ingeridas, e ingredientes consumidos.| RF-006         |
| 05     | Avaliar as receitas propostas por nutricionistas ou outros pacientes, dando likes ou joinhas.                          | RF-008         |
| 06     | Alterar seus dados pessoais cadastrados no perfil.                                                                     | RF-009         |

## Métricas de Avaliação

| Métrica                    | Descrição                                                                                                           |
|----------------------------|--------------------------------------------------------------------------------------------------                   |
| **Facilidade de Uso**      | Quantidade de erros cometidos pelos participantes ao realizar as tarefas.                                           |
| **Eficiência**             | Tempo necessário para concluir cada tarefa e número de cliques necessários para completar ações.                    |
| **Número de Erros**        | Quantidade de erros ocorridos durante a execução das tarefas.                                                       |
| **Taxa de Sucesso**        | Percentual de participantes que completaram as tarefas sem erros ou ajuda.                                          |

## Recursos Demandados

- **Plataforma de Videoconferência:** Google Meet ou Teams.
- **Gravação dos Testes:** Para análise posterior das interações.
- **Moderador:** Para acompanhar os testes e fazer observações.
- **Formulário de Consentimento:** Respeitando a LGPD.

## Análise dos Resultados

Os dados coletados durante os testes serão analisados para identificar padrões de comportamento, dificuldades enfrentadas pelos usuários e pontos de melhoria. O foco estará na usabilidade, fluidez da navegação, clareza das informações e eficiência das funcionalidades. A partir das métricas avaliadas nos testes, serão propostas otimizações na interface e nas funcionalidades da Nutribem.

## Conclusão

O plano de testes visa garantir que a Nutribem ofereça uma experiência fluida e intuitiva para seus usuários, tanto nutricionistas quanto pacientes. A partir da coleta de dados e observações, as melhorias serão implementadas para aumentar a satisfação e eficiência na utilização da plataforma.
