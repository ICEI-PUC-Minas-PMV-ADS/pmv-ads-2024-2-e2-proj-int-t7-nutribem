# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="https://github.com/ICEI-PUC-Minas-PMV-ADS/PMV-ADS-2024-1-E1-Proj-Direcionamento-Profissional/blob/main/documentos/02-Especificação%20do%20Projeto.md"> Especificação do Projeto</a></span>, <a href="https://github.com/ICEI-PUC-Minas-PMV-ADS/PMV-ADS-2024-1-E1-Proj-Direcionamento-Profissional/blob/main/documentos/04-Projeto%20de%20Interface.md"> Projeto de Interface</a>

Os requisitos para realização dos testes de software são:
<ul><li>Site publicado na internet;</li>
<li>Banco de dados configurado e acessível;</li>
<li>Ferramenta de testes unitários e integração;</li>
<li>Navegador para testes de interface e segurança(Chrome, Firefox ou Edge);</li>
<li>Ambiente de teste configurado.</li>
</ul>

Os testes funcionais a serem realizados na aplicação são descritos a seguir.

<table>
    <tr>
        <th><strong>Caso de Teste</strong></th>
        <th><strong>CT-01 –  CRUD Nutricionista</strong></th>
    </tr>
    <tr>
        <td><strong>Requisito Associado</strong></td>
        <td>RF-001 - Cadastrar nutricionista como usuário, vizualizar, editar e excluir os dados.</td>
    </tr>
    <tr>
        <td><strong>Objetivo do Teste</strong></td>
        <td>Verificar se o nutricionista consegue criar um perfil na aplicação.</td>
    </tr>
    <tr>
        <td><strong>Passos</strong></td>
        <td>
            - Acessar o navegador. <br>
            - Informar o endereço do site. <br>
            - Visualizar a página de "Inicio". <br>
            - Clicar em "Login". <br>
            - Clicar em "Cadastre-se". <br>
            - Selecionar a opção "Nutricionista". <br>
            - Preencher informações de cadastro. <br>
            - Clicar em "Confirmar". <br>
            - Clicar na ferramenta de edição do Nutricionista. <br>
            - Alterar dados. <br>
            - Clicar em "Confirmar". <br>
            - Clicar na ferramenta de vizualização do Nutricionista. <br>
            - Clicar no botão voltar.
            - Clicar na ferramenta de exclusão do perfil do Nutricionista. <br>
            - Clicar em "Confirmar". <br>
        </td>
    </tr>
    <tr>
        <td><strong>Critério de Êxito</strong></td>
        <td>Mensagem "Cadastro realizado com sucesso" e redirecionamento para a página de login.</td>
    </tr>
</table>

<br>

<table>
    <tr>
        <th><strong>Caso de Teste</strong></th>
        <th><strong>CT-02 – Nutricionista cadastra/edita/exclui paciente</strong></th>
    </tr>
    <tr>
        <td><strong>Requisito Associado</strong></td>
        <td>RF-002 - Nutricionista cadastra um paciente e utiliza CRUD's para o seu gerenciamento.</td>
    </tr>
    <tr>
        <td><strong>Objetivo do Teste</strong></td>
        <td>Verificar se o nutricionista consegue criar, editar e excluir o perfil de paciente.</td>
    </tr>
    <tr>
        <td><strong>Passos</strong></td>
        <td>
            - Acessar o menu "Pacientes". <br>
            - Clicar em "Cadastrar novo Paciente". <br>         
            - Preencher informações.<br>
            - Clicar em "Enviar convite".<br>
            - Clicar na ferramenta de edição do paciente.<br>
            - Alterar dados.<br>
            - Clicar em "Confirmar".<br>
            - Clicar na ferramenta de exclusão do perfil de paciente.<br>
            - Clicar em "Confirmar".
        </td>
    </tr>
    <tr>
        <td><strong>Critério de Êxito</strong></td>
        <td>Perfil do paciente deve ser exibido na lista, as alterações devem ser salvas com êxito e perfil deve ser excluído da lista.</td>
    </tr>
</table>

<br>

<table>
    <tr>
        <th><strong>Caso de Teste</strong></th>
        <th><strong>CT-03 – Cadastrar paciente</strong></th>
    </tr>
    <tr>
        <td><strong>Requisito Associado</strong></td>
        <td>RF-003 - Cadastrar um paciente como usuário, com informações pessoais em geral, objetivos e dados ligados a sua saúde (IMC, altura, idade, etc.).</td>
    </tr>
    <tr>
        <td><strong>Objetivo do Teste</strong></td>
        <td>Verificar se o paciente consegue criar um perfil na aplicação.</td>
    </tr>
    <tr>
        <td><strong>Passos</strong></td>
        <td>
            - Acessar o navegador. <br>
            - Informar o endereço do site. <br>
            - Visualizar a página de "Inicio". <br>
            - Clicar em "Login". <br>
            - Clicar em "Cadastre-se". <br>
            - Selecionar a opção "Paciente". <br>
            - Preencher informações de cadastro. <br>
            - Clicar em "Confirmar".
        </td>
    </tr>
    <tr>
        <td><strong>Critério de Êxito</strong></td>
        <td>Mensagem "Cadastro realizado com sucesso" e redirecionamento para a página de login.</td>
    </tr>
</table>

<br>

<table>
    <tr>
        <th><strong>Caso de Teste</strong></th>
        <th><strong>CT-04 – Testar login com e-mail e senha.</strong></th>
    </tr>
    <tr>
        <td><strong>Requisito Associado</strong></td>
        <td>RF-004 - Realizar login utilizando e-mail e senha.</td>
    </tr>
    <tr>
        <td><strong>Objetivo do Teste</strong></td>
        <td>Verificar se o login com e-mail e senha está funcionando corretamente, validando as credenciais fornecidas.</td>
    </tr>
    <tr>
        <td><strong>Passos</strong></td>
        <td>
            - Visualizar a página de "Inicio". <br>
            - Clicar em "Login". <br>
            - Inserir um e-mail e senha válidos. <br>
            - Clicar em "Login".
        </td>
    </tr>
    <tr>
        <td><strong>Critério de Êxito</strong></td>
        <td>O usuário deve ser autenticado com sucesso quando fornecer um e-mail e senha corretos. Caso a combinação esteja errada, o sistema deve exibir uma mensagem de erro e não permitir o login.</td>
    </tr>
</table>

<br>

<table>
    <tr>
        <th><strong>Caso de Teste</strong></th>
        <th><strong>CT-05 – Testar recuperação de senha.</strong></th>
    </tr>
    <tr>
        <td><strong>Requisito Associado</strong></td>
        <td>RF-005 - Recuperar a senha através do e-mail registrado.</td>
    </tr>
    <tr>
        <td><strong>Objetivo do Teste</strong></td>
        <td>Verificar se o processo de recuperação de senha está funcionando corretamente e se o e-mail de redefinição é enviado.</td>
    </tr>
    <tr>
        <td><strong>Passos</strong></td>
        <td>
            - Visualizar a página de "Inicio". <br>
            - Clicar em "Login". <br>
            - Clicar em "Esqueci a senha". <br>
            - Inserir o e-mail um registrado. <br>
            - Enviar solicitação.
        </td>
    </tr>
    <tr>
        <td><strong>Critério de Êxito</strong></td>
        <td>Um e-mail com o link de redefinição de senha deve ser fornecido, permitir que o úsuario redefina a senha e realize o login.</td>
    </tr>
</table>

<br>

<table>
    <tr>
        <th><strong>Caso de Teste</strong></th>
        <th><strong>CT-06 – Cadastrar/editar/excluir plano alimentar</strong></th>
    </tr>
    <tr>
        <td><strong>Requisito Associado</strong></td>
        <td>RF-006 - Cadastrar um plano alimentar pelo nutricionista e utiliza CRUD's para o seu gerenciamento.</td>
    </tr>
    <tr>
        <td><strong>Objetivo do Teste</strong></td>
        <td>Verificar se o nutricionista consegue cadastrar/editar/excluir um plano alimentar.</td>
    </tr>
    <tr>
        <td><strong>Passos</strong></td>
        <td>
            - Acessar o menu "Plano Alimentar". <br>
            - Clicar em "Cadastrar novo Plano Alimentar". <br>         
            - Preencher informações para o plano alimentar.<br>
            - Clicar em "Cadastrar Plano".
            - Clicar na ferramenta de edição do "Plano Alimentar".<br>
            - Alterar dados.<br>
            - Clicar em "Confirmar".<br>
            - Clicar na ferramenta de exclusão do "Plano Alimentar"<br>
            - Clicar em "Confirmar".
        </td>
    </tr>
    <tr>
        <td><strong>Critério de Êxito</strong></td>
        <td>O plano alimentar aparece na lista de planos associados ao paciente, é editado e atualizações salvas, plano alimentar é excluído com êxito.</td>
    </tr>
</table>

<br>

<table>
    <tr>
        <th><strong>Caso de Teste</strong></th>
        <th><strong>CT-07 – Fazer comentário sobre o plano alimentar</strong></th>
    </tr>
    <tr>
        <td><strong>Requisito Associado</strong></td>
        <td>RF-007 - Fazer comentário sobre o plano alimentar pelo paciente.</td>
    </tr>
    <tr>
        <td><strong>Objetivo do Teste</strong></td>
        <td>Verificar se o paciente consegue comentar em seu plano alimentar.</td>
    </tr>
    <tr>
        <td><strong>Passos</strong></td>
        <td>
            - Acessar o menu "Plano Alimentar". <br>
            - Inserir comentário no campo específico. <br>
            - Clicar em "Enviar Comentário".
        </td>
    </tr>
    <tr>
        <td><strong>Critério de Êxito</strong></td>
        <td>Comentário aparece abaixo do plano alimentar e é visível para o nutricionista.</td>
    </tr>
</table>

<br>

<table>
    <tr>
        <th><strong>Caso de Teste</strong></th>
        <th><strong>CT-08 – Registrar diário alimentar</strong></th>
    </tr>
    <tr>
        <td><strong>Requisito Associado</strong></td>
        <td>RF-008 - O paciente Registra o diário alimentar com informações sobre horário das refeições, calorias ingeridas, ingredientes consumidos, etc por meio de um campo Editável.</td>
    </tr>
    <tr>
        <td><strong>Objetivo do Teste</strong></td>
        <td>Verificar se o paciente consegue registrar suas refeições no diário alimentar.</td>
    </tr>
    <tr>
        <td><strong>Passos</strong></td>
        <td>
            - Acessar o menu "Diário Alimentar". <br>
            - Inserir detalhes da refeição (horário, ingredientes, calorias). <br>
            - Clicar em "Enviar".
        </td>
    </tr>
    <tr>
        <td><strong>Critério de Êxito</strong></td>
        <td>A refeição aparece registrada no diário do paciente.</td>
    </tr>
</table>

<br>

<table>
    <tr>
        <th><strong>Caso de Teste</strong></th>
        <th><strong>CT-09 – Propor/editar/excluir dicas de receitas</strong></th>
    </tr>
    <tr>
        <td><strong>Requisito Associado</strong></td>
        <td>RF-009 - Propor dicas de receitas por nutricionistas e pacientes e utiliza CRUD's para o seu gerenciamento.</td>
    </tr>
    <tr>
        <td><strong>Objetivo do Teste</strong></td>
        <td>Verificar se nutricionistas e pacientes conseguem propor dicas de receitas.</td>
    </tr>
    <tr>
        <td><strong>Passos</strong></td>
        <td>
            - Acessar o menu "Receitas". <br>
            - Clicar em "Cadastrar nova Receita". <br>
            - Preencher as informações da receita. <br>
            - Clicar em "Cadastrar Receita". <br>
            - Clicar na ferramenta de edição da "Receita". <br>
            - Alterar dados.<br>
            - Clicar em "Confirmar". <br>
            - Clicar na ferramenta de exclusão da "Receita" <br>
            - Clicar em "Confirmar".
        </td>
    </tr>
    <tr>
        <td><strong>Critério de Êxito</strong></td>
        <td>A nova receita proposta é exibida na lista de dicas para outros usuários, é editado e atualizações salvas, a receita é excluído com êxito. </td>
    </tr>
</table>

<br>

<table>
    <tr>
        <th><strong>Caso de Teste</strong></th>
        <th><strong>CT-10 – Registrar perda de peso do paciente e exibir histórico</strong></th>
    </tr>
    <tr>
        <td><strong>Requisito Associado</strong></td>
        <td>RF-010 - Registrar perda de peso do paciente ao longo do tempo e exibir o histórico desta informação.</td>
    </tr>
    <tr>
        <td><strong>Objetivo do Teste</strong></td>
        <td>Verificar se o sistema permite registrar a perda de peso do paciente e exibe o histórico.</td>
    </tr>
    <tr>
        <td><strong>Passos</strong></td>
        <td>
            - Acessar o menu "Meu Perfil". <br>
            - Inserir informações do "Histórico de Peso" <br>
            - Clicar em "Adicionar".
        </td>
    </tr>
    <tr>
        <td><strong>Critério de Êxito</strong></td>
        <td>O peso é registrado corretamente, e o histórico é exibido com os dados passados.</td>
    </tr>
</table>

<br>

<table>
    <tr>
        <th><strong>Caso de Teste</strong></th>
        <th><strong>CT-11 – Avaliar as receitas</strong></th>
    </tr>
    <tr>
        <td><strong>Requisito Associado</strong></td>
        <td>RF-011 - Avaliar as receitas propostas (like ou joinha).</td>
    </tr>
    <tr>
        <td><strong>Objetivo do Teste</strong></td>
        <td>Verificar se o paciente ou nutricionista pode avaliar as receitas propostas com um like ou joinha.</td>
    </tr>
    <tr>
        <td><strong>Passos</strong></td>
        <td>
            - Acessar o menu "Receitas". <br>
            - Selecionar uma receita da lista. <br>
            - Clicar no ícone de "Coração".
        </td>
    </tr>
    <tr>
        <td><strong>Critério de Êxito</strong></td>
        <td>A avaliação (like ou joinha) é registrada corretamente e o número de avaliações é atualizado.</td>
    </tr>
</table>

<br>

<table>
    <tr>
        <th><strong>Caso de Teste</strong></th>
        <th><strong>CT-12 – Calcular IMC</strong></th>
    </tr>
    <tr>
        <td><strong>Requisito Associado</strong></td>
        <td>RF-012 - Calcular índice de massa corpórea para o usuário nutricionista.</td>
    </tr>
    <tr>
        <td><strong>Objetivo do Teste</strong></td>
        <td>Verificar se o sistema calcula o índice de massa corpórea (IMC) corretamente com base no peso e altura informados.</td>
    </tr>
    <tr>
        <td><strong>Passos</strong></td>
        <td>
            - Acessar o menu "Meu Perfil". <br>
            - Inserir informações do "IMC" <br>
            - Clicar em "Calcularr".
        </td>
    </tr>
    <tr>
        <td><strong>Critério de Êxito</strong></td>
        <td>O IMC é calculado corretamente.</td>
    </tr>
</table>

<br>

<table>
    <tr>
        <th><strong>Caso de Teste</strong></th>
        <th><strong>CT-13 – Testar alteração de dados de cadastro</strong></th>
    </tr>
    <tr>
        <td><strong>Requisito Associado</strong></td>
        <td>RF-013 - Permitir que tanto o paciente quanto o nutricionista alterem seus dados de cadastro.</td>
    </tr>
    <tr>
        <td><strong>Objetivo do Teste</strong></td>
        <td>Verificar se o paciente e o nutricionista conseguem alterar seus dados de cadastro</td>
    </tr>
    <tr>
        <td><strong>Passos</strong></td>
        <td>
            - Acessar o menu "Meu Perfil". <br>
            - Alterar informações de cadastro.
        </td>
    </tr>
    <tr>
        <td><strong>Critério de Êxito</strong></td>
        <td>Permiti que o paciente e o nutricionista alterem seus dados de perfil.</td>
    </tr>
</table>
