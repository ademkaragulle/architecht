const date = document.getElementById('date')
const clock = document.getElementById('clock')


var currentDate = new Date();

var day = currentDate.getDate();
var month = currentDate.getMonth() + 1; // JavaScript'te ay indeksleri 0'dan başlar, bu yüzden 1 eklenir.
var year = currentDate.getFullYear();
var hours = currentDate.getHours();
var minutes = currentDate.getMinutes();


date.innerText = day + '.' + month + '.' + year
clock.innerText = (hours < 10 ? "0" + hours : hours) + '.' + minutes



const folders =
    [
        {
            folderID: 1,
            folderName: "My Computer",
            folderIcon: "fa-solid fa-computer",
            folderFiles:
                [
                    {
                        imagesTitle: "Local Disk(C:)",
                        imagesUrl: "./assets/img/computer-folder/hdd.svg",
                        progresssBar: 60
                    },
                    {
                        imagesTitle: "Local Disk(D:)",
                        imagesUrl: "./assets/img/computer-folder/hdd.svg",
                        progresssBar: 78
                    },
                ],
        },
        {
            folderID: 2,
            folderName: "My Documents",
            folderIcon: "fa-solid fa-folder-open",
            folderFiles:
                [
                    {
                        imagesTitle: "Word",
                        imagesUrl: "./assets/img/document-folder/word.png"
                    },
                    {
                        imagesTitle: "Exel",
                        imagesUrl: "./assets/img/document-folder/exel.png"
                    },
                    {
                        imagesTitle: "PowerPoint",
                        imagesUrl: "./assets/img/document-folder/powerpoint.png"
                    }
                ],
        },
        {
            folderID: 3,
            folderName: "My İmages",
            folderIcon: "fa-solid fa-images",
            folderFiles:
                [
                    {
                        imagesTitle: "İmages-1",
                        imagesUrl: "./assets/img/images-folder/image-1.avif"
                    },
                    {
                        imagesTitle: "İmages-2",
                        imagesUrl: "./assets/img/images-folder/image-2.avif"
                    },
                    {
                        imagesTitle: "İmages-3",
                        imagesUrl: "./assets/img/images-folder/image-3.avif"
                    },
                    {
                        imagesTitle: "İmages-4",
                        imagesUrl: "./assets/img/images-folder/image-4.avif"
                    },
                    {
                        imagesTitle: "İmages-5",
                        imagesUrl: "./assets/img/images-folder/image-5.avif"
                    }
                ],
        },
        {
            folderID: 4,
            folderName: "Games",
            folderIcon: "fa-solid fa-gamepad",
            folderFiles: [
                {
                    imagesTitle: "Game",
                    imagesUrl: "https://play-lh.googleusercontent.com/1N7HgZi-C8vPYwYeJHkKPZXQ2hJ8inp5NEsgYep9t8fPtp8SKPO-JMBxjojCDI2ADw"
                }
            ]
        }
    ]

let currentFolder;


const desktopFolders = document.getElementById('desktop-folders')
// desktop folders ekler
const addDesktopFolders = (item) => {
    let innDocument =
        `
    <div onClick=(openfolder(${item.folderID})) class="col text-center btn">
    <i class="${item.folderIcon} fa-2x"></i>
    <h6 class="mt-1">${item.folderName}</h6>
    </div>
    `
    return innDocument
}
let value = ''
folders.map((item) => {
    value += addDesktopFolders(item)
})
desktopFolders.innerHTML = value
// ekleme biter


const fileExplorer = () => {
    var fileExplorervalue = ''

    folders.map((item) => {
        fileExplorervalue +=
            `
        <div onClick=(openfolder(${item.folderID})) style="cursor:pointer" class="px-2">
            <i class="${item.folderIcon}"></i>
            <span class="">${item.folderName}</span>
        </div>
        `
    })

    document.getElementById('file-explorer').innerHTML = fileExplorervalue
}



const initializeRight = document.getElementById('initialize-left')

// Başlat Folders ekleme
const addInitializeFolders = () => {
    let innDocument =
        `
    <div class="btn btn-initialize dropdown-toggle" data-bs-toggle="dropdown" aria-expanded="false" >
        <i style="font-size: 20px !important" class="fa-brands fa-windows"></i>
    </div>
    <ul style="padding:0; width:400px" id="dropup-menu" class="dropdown-menu text-light">
        <li><div class="dropdown-item" href="#">
            <div onClick=(openfolder(1)) style="cursor:pointer" class="px-2 py-3 text-light">
                <i class="fa-solid fa-folder-open me-2"></i>
                <span>My Computer</span>
            </div>
        </div></li>
        <li><div class="dropdown-item" href="#">
            <div onClick=(openfolder(2)) style="cursor:pointer" class="px-2 py-3 text-light">
                <i class="fa-solid fa-computer me-2"></i>
                <span>My Documents</span>
            </div>
        </div></li>
        <li><div class="dropdown-item" href="#">
            <div onClick=(openfolder(3)) style="cursor:pointer" class="px-2 py-3 text-light">
                <i class="fa-solid fa-computer me-2"></i>
                <span>My Pictures</span>
            </div>
        </div></li>
        <li><div class="dropdown-item" href="#">
            <div onClick=(openfolder(4)) style="cursor:pointer" class="px-2 py-3 text-light">
                <i class="fa-solid fa-computer me-2"></i>
                <span>Games</span>
            </div>
        </div></li>
        <li><div class="dropdown-item" href="#">
            <div onClick=(shoutDown()) style="cursor:pointer" class="px-2 py-3 text-light">
                <img src="./assets/img/power.svg" class='me-2 text-light bg-light p-1 rounded' alt="">
                <span>Shot Down</span>
            </div>
        </div></li>
     </ul>
    `
    folders.map((item) => {
        innDocument +=
            `
        <div onClick=(openfolder(${item.folderID})) id="init-folder-${item.folderID}" class="btn btn-initialize">
            <i class="${item.folderIcon}"></i>
        </div>
        `
    })
    initializeRight.innerHTML = innDocument
}

addInitializeFolders()

const createfolder = (folderObj) => {
    const folderBody = document.getElementById("folderBody")
    let files = ''
    currentFolder = folderObj.folderID


    folderObj.folderFiles.map((item, index) => {
        files +=
            `
        <div onClick=(openPopUp(${folderObj, item, index})) data-bs-toggle="modal" data-bs-target="#exampleModal" class="folder-file-item">
        <div class="folder-file-item-img"><img class="w-100 img-fluid" src="${item.imagesUrl}" alt=""></div>
        <div class="text-center pt-2">${item.imagesTitle}</div>
    `,

            item.progresssBar ?
                files += `<div class="progress mt-2">
                         <div class="progress-bar" role="progressbar" aria-label="Basic example" style="width: ${item.progresssBar}%" aria-valuenow="${item.progresssBar}" aria-valuemin="0" aria-valuemax="100">${item.progresssBar}%</div>
                     </div></div>`
                : files += `</div>`
    })
    folderBody.innerHTML = files
}


function openPopUp(folderObj, item, index) {
    const modalTitle = document.getElementById('exampleModalLabel')
    const modalImg = document.getElementById('modalImg')
    modalImg.src = `${folders[currentFolder - 1].folderFiles[folderObj].imagesUrl}`
    modalTitle.innerText = `${folders[currentFolder - 1].folderFiles[folderObj].imagesTitle}`
}





const folderName = document.getElementById('folder-name')
const closeFolder = document.getElementById('close-folder')
const documentElement = document.getElementById('document')
// close folder
closeFolder.addEventListener('click', () => {
    documentElement.classList.remove("folder-active")
    documentElement.classList.add("folder-passive")
    currentFolder = ''
    openbgFolder()

})

// open folder
const openfolder = (itemID) => {

    const folder = folders.find((item) => item.folderID == itemID)
    folderName.innerText = folder.folderName
    createfolder(folder)
    documentElement.classList.add("folder-active")
    documentElement.classList.remove("folder-passive")
    openbgFolder(itemID)
    fileExplorer()
}


const openbgFolder = (itemID) => {
    const initializeLeft = document.getElementsByClassName('current-folder')[0]
    initializeLeft && initializeLeft.classList.remove('current-folder')
    if (itemID) {
        document.getElementById(`init-folder-${itemID}`).classList.add('current-folder')
    }
}



const shoutDown = () => {
    window.location.href = "./index1.html";
}