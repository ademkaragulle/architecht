const powerElement = document.getElementById('power')
const powerIcon = document.getElementById('power-icon')


const start = async () => {
    powerElement.classList.add('animation-start')
    powerElement.style.width = '2000px'
    powerElement.style.height = '2000px'
    powerElement.style.backgroundColor = "#fff";
    powerIcon.style.display = 'none'

    await setTimeout(() => {
        window.location.href = "./index2.html";
    }, 2000);
}


powerElement.addEventListener('click', start)