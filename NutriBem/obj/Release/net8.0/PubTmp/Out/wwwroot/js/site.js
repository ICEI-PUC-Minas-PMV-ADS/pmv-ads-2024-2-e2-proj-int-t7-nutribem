// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function likeRecipe(id) {
    let heartIcon = document.getElementById(`heart-icon-${id}`);
    let heartPath = document.getElementById(`heart-path-${id}`);
    let likesCountSpan = document.getElementById(`likes-count-${id}`);
    let isLiked = heartIcon.classList.contains('liked');

    // Atualiza a cor do coração
    if (isLiked) {
        heartPath.setAttribute('fill', 'currentColor');  // Volta ao estado original (transparente)
        heartIcon.classList.remove('liked');
    } else {
        heartPath.setAttribute('fill', 'red');  // Preenche o coração com vermelho
        heartIcon.classList.add('liked');
    }

    // Envia a requisição para o backend para atualizar o número de curtidas
    $.ajax({
        url: '/Receitas/Like', // Endpoint do controlador para lidar com a curtida
        type: 'POST',
        data: {
            id: id,
            like: !isLiked // Se estava curtido, vai descurtir; senão, vai curtir
        },
        success: function (newLikeCount) {
            // Atualiza o contador de curtidas na view
            likesCountSpan.textContent = newLikeCount;
        },
        error: function () {
            alert('Ocorreu um erro ao processar sua curtida.');
        }
    });
}
