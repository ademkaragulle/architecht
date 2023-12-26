const loading = document.getElementById('loading')
const loadingprogress = document.getElementById('loading-progress')
const title = document.getElementById('title')
const logIn = document.getElementById('logIn')
const input = document.getElementById('input')
const button = document.getElementById('button')
const warning = document.getElementById('warning')
i = 0;

const interval = setInterval(() => {
    loading.ariaValueNow = i
    loadingprogress.style.width = i + "%"
    i++
    i > 200 && clearInterval(interval)
}, 10)

interval
const changeIndex = setTimeout(() => {
    openHello()
}, 2500);


const openHello = () => {
    document.getElementById('loading').remove()
    title.style.display = 'block'
    setTimeout(() => {
        title.style.display = 'none'
        logIn.style.display = 'block'
    }, 2000)
}


button.addEventListener('click', () => {
    if (input.value == 1234) {
        window.location.href = "./index3.html";
    }
    else {
        input.value = ''
        warning.style.visibility = 'visible'
    }
})
