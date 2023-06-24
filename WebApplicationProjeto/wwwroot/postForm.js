document.addEventListener("DOMContentLoaded", () => {
    preencher_select();
});

const postForm = document.querySelector('.postForm');
postForm.addEventListener(('submit'), e =>{
    e.preventDefault();
    var post = {usuario_id: postForm.nome_usuario.value, texto: postForm.post_usuario.value}
    enviar(post);
})

const enviar = async (post) => {
    try {
        let response = await fetch('api/post', {
        method: 'POST',
        body: JSON.stringify(post),
        headers: {"Content-type": "application/json; charset=UTF-8"}
        });
        const result = await response.json();

        console.log(result);
    } catch (error) {
        console.log(error);
    }
};

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
