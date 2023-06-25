document.addEventListener("DOMContentLoaded", () => {
    preencher_lista_posts();
});


const buscar_posts = async () => {
    try {
        let response = await fetch('api/post', {
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

const preencher_lista_posts = () =>{
    var tabela = document.getElementById('tabela');
    buscar_posts().then((result) =>{
        result.forEach(post => {
            var linha = document.createElement('tr');
            var coluna1 = document.createElement('td');
            var coluna2 = document.createElement('td');
            var coluna3 = document.createElement('td');

            linha.appendChild(coluna1);
            linha.appendChild(coluna2);
            linha.appendChild(coluna3);

            tabela.children[1].appendChild(linha);

            var link = document.createElement('a');
            link.href = `comentarioForm.html?post_id=${post.post_id}`
            link.text = 'comentar';

            coluna1.textContent = post.texto;
            coluna2.appendChild(link);


            var linkVer = document.createElement('a');
            linkVer.href = `listaComentario.html?post_id=${post.post_id}`
            linkVer.text = 'ver comentários';

            coluna3.appendChild(linkVer);

        });
    })
}
