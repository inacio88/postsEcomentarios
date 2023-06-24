const usuarioForm = document.querySelector('.usuarioForm');
const formData = document.querySelector('.usuarioForm');
const messageEl = document.querySelector('#message');
console.log(usuarioForm);

usuarioForm.addEventListener(('submit'), e =>{
    const usuario = {nome: formData.nome.value, email: formData.email.value}
    e.preventDefault();
    console.log(usuario);
    console.log(JSON.stringify(usuario))
    enviar(usuario);
})


const enviar = async (usuario) => {
    try {
        let response = await fetch('api/usuario', {
        method: 'POST',
        body: JSON.stringify(usuario),
        headers: {"Content-type": "application/json; charset=UTF-8"}
        });
        const result = await response.json();

        console.log(result);
    } catch (error) {
        console.log(error);
    }
};
