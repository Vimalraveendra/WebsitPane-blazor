window.loadUser = window.loadUser ||
    function (text) {
        console.log(text)
        loadUsers()
    }


function loadUsers() {
    const inputEL = document.querySelector('.form-control')
    const inputInsideEl = document.getElementById('input-inside')
    const searchListEl = document.querySelector('.list')
    const dropDownEl = document.querySelector('.card')
    const lettersListEl = document.querySelector('.letters')
    const patientListEl = document.querySelector('.patient-list')
    const splitBarEl = document.querySelector('.split-bar')
    const patientContainerEl = document.querySelector('.patient-container')
    const cardContainerEl = document.querySelector('.card-container')
    const patientCardEl = document.querySelector('.patient-card')
    
   
    const imagePreviewContainerEl = document.getElementById('image-preview')
   
    const sideListBtnEl = document.querySelector('.side-btn')
    const inputGetFileEl = document.getElementById('getFile')
    const imageContainerEl = document.querySelector('.img-container')
    const previewImageEl = imageContainerEl.querySelector('.preview-image')
    const imageDateEl = document.getElementById('img-date')




    sideListBtnEl.addEventListener('click', function () {
        inputGetFileEl.click();
    })
    inputGetFileEl.addEventListener('change', function () {
        //selecting first file in the array
        const file = this.files[0];
        console.log('file', file)
        //if we seletected the file, we need to create a new file reader as data url
        if (file) {
            const reader = new FileReader();
            previewImageEl.style.display = 'block'

            reader.addEventListener('load', function () {
                imagePreviewContainerEl.style.display="block"
                //this.result is the default propery of reader that contains the data url
                previewImageEl.setAttribute('src', this.result)
                    imageDateEl.innerHTML = new Date().toLocaleDateString().replace(/[/]+/gi, "-")
       
            })
            reader.readAsDataURL(file)
        } else {
            imagePreviewContainerEl.style.display = null;
            previewImageEl.style.display = null;

            previewImageEl.setAttribute('src',"")
        }
    })

    const usersData = [
        {
            "id": 10001,
            "name": "Abraham"
        }, {
            "id": 10002,
            "name": "Adam"
        }, {
            "id": 10003,
            "name": "Antony AdamGonslavas"
        },
        {
            "id": 10004,
            "name": "Bobby"
        },
        {
            "id": 10005,
            "name": "Boss AntonyMarshell"
        },
        {
            "id": 10006,
            "name": "Bencher"
        },
        {
            "id": 10007,
            "name": "Christopher Gonsalves"
        },
        {
            "id": 10008,
            "name": "Calvin"
        },
        {
            "id": 10009,
            "name": "Christy Christopher"
        },
        {
            "id": 10010,
            "name": "Don"
        },
        {
            "id": 10011,
            "name": "Danny ImmanuelBidenSalves"
        },
        {
            "id": 10012,
            "name": "Denver"
        },
        {
            "id": 10013,
            "name": "Eagle"
        },
        {
            "id": 10014,
            "name": "Entity"
        },
        {
            "id": 10015,
            "name": "Elgar"
        },
        {
            "id": 10016,
            "name": "Fedric"
        },
        {
            "id": 10017,
            "name": "Fernandes"
        },
        {
            "id": 10018,
            "name": "Felix"
        }, {
            "id": 10019,
            "name": "Gangster"
        },
        {
            "id": 10020,
            "name": "Gambler"
        },
        {
            "id": 10021,
            "name": "Guardian"
        }, {
            "id": 10022,
            "name": "Harry"
        },
        {
            "id": 10023,
            "name": "Hamilton"
        },
        {
            "id": 10024,
            "name": "Helen"
        },
        {
            "id": 10025,
            "name": "Immanuel"
        }, {
            "id": 10026,
            "name": "Inker"
        },
        {
            "id": 10027,
            "name": "Ivan"
        },
        {
            "id": 10028,
            "name": "Jennifer"
        }, {
            "id": 10029,
            "name": "James"
        },
        {
            "id": 10030,
            "name": "John"
        },
        {
            "id": 10031,
            "name": "Kevin"
        }, {
            "id": 10032,
            "name": "Karl"
        },
        {
            "id": 10033,
            "name": "Kristopher"
        },
        {
            "id": 10034,
            "name": "Lenin"
        }




    ]





    // creating patient card based on the event
    function createPatientCard({ name, id }) {
        patientCardEl.innerHTML = `
  <h3> ${name}</h3>
  <p>${id}</p>
  `

    }

    // rendering patientCard based on the onclick event
    function renderPatientCard(event) {
        let name = event.target.textContent
        // clearing the parent container before adding
        patientCardEl.innerHTML = "";
        usersData.forEach(user => {
            if (user.name.toLowerCase() === name.toLowerCase()) {
                createPatientCard(user)
            }
        })
    }

    function createPatients(patient) {
        const patientList = document.createElement('li');
        const patientText = document.createTextNode(patient.name)
        patientList.appendChild(patientText)
        patientList.addEventListener('click', renderPatientCard)
        // patientList.addEventListener('click', filterPatientList)
        patientListEl.appendChild(patientList)

    }

    function renderPatients() {
        //   clearing the parent container before adding
        patientListEl.innerHTML = "";
        usersData.forEach(user => createPatients(user))
        let patientListItemEl = document.querySelectorAll('.patient-list li')
        // Loop through the patientListItemEl and add the active class to the current/clicked button
        for (var i = 0; i < patientListItemEl.length; i++) {
            patientListItemEl[i].addEventListener("click", function () {
                let current = document.getElementsByClassName("active");


                // If there's no active class
                if (current.length > 0) {
                    current[0].className = current[0].className.replace(" active", "");
                }

                // Add the active class to the current/clicked button
                this.className += " active";
            });
        }
    }

    // invoking renderPatients function when the page loads
    renderPatients()


    //rendering usersList inside the dropDown
    function renderUsers() {

        // clearing the parent container before adding
        patientListEl.innerHTML = "";
        usersData.forEach(user => {
            if (user.name.toLowerCase().includes(inputInsideEl.value.toLowerCase())) {
                createPatients(user)
            }
        })

    }

    function setUserInput() {
        if (inputEL.value === 'Nazywa') {
            renderUsers()
        }

    }

    function setInputValue(event) {
        inputEL.value = event.target.textContent;

        inputInsideEl.focus();
        searchListEl.classList.toggle('done')
        inputInsideEl.addEventListener('input', setUserInput)

    }




    //   creating users inside the usersList
    function createUsers(user) {

        const userList = document.createElement('li');
        const userText = document.createTextNode(user)
        userList.addEventListener('click', setInputValue)
        inputInsideEl.value = "";
        inputEL.value = "";
        userList.appendChild(userText)
        searchListEl.appendChild(userList)

    }





    function renderSearchList() {
        //clearing the parent container before adding
        searchListEl.innerHTML = "";
        searchListEl.classList.toggle('done')
        searchData.forEach(data => createUsers(data))
    }

 


    // page pane using split bar
    let isMdn = 0
    splitBarEl.addEventListener('mousedown', mouseDown)

    function mouseDown() {
        isMdn = 1
        document.body.addEventListener('mousemove', mouseVertical)
        document.body.addEventListener('mouseup', end)
    }




    function mouseVertical(event) {
        if (isMdn === 1) {
            // patientContainerEl.style.flexBasis = event.clientX+ "px"
            // patientContainerEl.style.width = event.clientX+ "px"
            patientContainerEl.style.flexBasis = `${event.clientX-190}px`
         
        } else {
            end()
        }
    }


    const end = () => {
        isMdn = 0
        document.body.removeEventListener('mouseup', end)
        splitBarEl.removeEventListener('mousemove', mouseVertical)
    }
}