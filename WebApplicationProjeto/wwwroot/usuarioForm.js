const usuarioForm = document.querySelector('.usuarioForm');

console.log(usuarioForm);

usuarioForm.addEventListener(('submit'), e =>{
    e.preventDefault();
    const formData = new FormData(usuarioForm, submitter);
    console.log(formData);

    let response = fetch('/api/usuario', {
        method: 'POST',
        body: formData
    });
})