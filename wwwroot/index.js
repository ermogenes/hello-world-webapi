const iniciar = async () => {
    const mensagem = document.getElementById('mensagem');
    const response = await fetch('/HelloWorld');
    const result = await response.json();
    mensagem.innerHTML = `<a href="${result.url}">${result.mensagem}</a>`;
};

document.addEventListener('DOMContentLoaded', iniciar);