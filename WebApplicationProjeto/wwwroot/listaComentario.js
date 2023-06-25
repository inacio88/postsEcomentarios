document.addEventListener("DOMContentLoaded", () => {
    preencher_lista_comentarios();
});

const queryString = window.location.search;
const urlParams = new URLSearchParams(queryString);
const post_id = urlParams.get('post_id');

const buscar_comentarios = async () => {
    try {
        let response = await fetch(`api/comentario/${post_id}`, {
        method: 'GET',
        headers: {"Content-type": "application/json; charset=UTF-8"}
        });
        const result = await response.json();
    
        return result;
    } catch (error) {
        console.log(error);
    }
};

const preencher_lista_comentarios = () =>{
    var tabela = document.getElementById('tabela');
    buscar_comentarios().then((result) =>{
        result.forEach(comentario => {
            var linha = document.createElement('tr');
            var coluna1 = document.createElement('td');
            var coluna2 = document.createElement('td');
            
            linha.appendChild(coluna1);
            linha.appendChild(coluna2);
            
            tabela.children[1].appendChild(linha);

            coluna1.textContent = comentario.texto;
            coluna2.textContent = comentario.usuario_id;
            
        });
    })
}
