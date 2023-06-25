document.addEventListener("DOMContentLoaded", () => {
    preencher_select();
});
const queryString = window.location.search;
const urlParams = new URLSearchParams(queryString);
const post_id = urlParams.get('post_id');

const comentarioForm = document.querySelector('#comentarioForm');
comentarioForm.addEventListener(('submit'), e =>{
    e.preventDefault();
    var comentario = {post_id: post_id, texto: comentarioForm.comentario_texto.value, usuario_id: comentarioForm.nome_usuario.value}
    enviar(comentario);
})

const enviar = async (comentario) => {
    try {
        let response = await fetch('api/comentario', {
        method: 'POST',
        body: JSON.stringify(comentario),
        headers: {"Content-type": "application/json; charset=UTF-8"}
        });
        const result = await response;
        window.location.assign('index.html');

    } catch (error) {
        console.log(error);
    }
};

const preencher_select = () =>{
    var select = document.getElementById('nome_usuario');
    buscar_usuarios().then((result) =>{
        result.forEach(usuario => {
            var op = document.createElement('option');
            op.text = usuario.nome;
            op.value = usuario.usuario_id;
            select.appendChild(op);
        });
    })
}

const buscar_usuarios = async () => {
    try {
        let response = await fetch('api/usuario', {
        method: 'GET',
        headers: {"Content-type": "application/json; charset=UTF-8"}
        });
        const result = await response.json();
        // console.log(result);
        return result;
    } catch (error) {
        console.log(error);
    }
};