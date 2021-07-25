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


    //const imagePreviewContainerEl = document.getElementById('image-preview');

    const sideListBtnEl = document.querySelector('.side-btn')
    const inputGetFileEl = document.getElementById('getFile')
    //const imageContainerEl = document.querySelector('.img-container')
    //const previewImageEl = imageContainerEl.querySelector('.preview-image')
    //const imageDateEl = document.getElementById('img-date')

    const sideListBtn2El = document.querySelector('.side-btn2');
    const inputGetFilesEl = document.getElementById('getFiles');
    const imageContainerSectionEl = document.querySelector('.image-container-section');



    //sideListBtnEl.addEventListener('click', function () {
    //    inputGetFileEl.click();
    //})
    //inputGetFileEl.addEventListener('change', function () {
    //    //selecting first file in the array

    //    const file = this.files[0];

    //    //if we seletected the file, we need to create a new file reader as data url
    //    if (file) {
    //        const reader = new FileReader();
    //        previewImageEl.style.display = 'block'

    //        reader.addEventListener('load', function () {
    //            imagePreviewContainerEl.style.display="block"
    //            //this.result is the default propery of reader that contains the data url
    //            previewImageEl.setAttribute('src', this.result)
    //                imageDateEl.innerHTML = new Date().toLocaleDateString().replace(/[/]+/gi, "-")

    //        })
    //        reader.readAsDataURL(file)
    //    } else {
    //        imagePreviewContainerEl.style.display = null;
    //        previewImageEl.style.display = null;

    //        previewImageEl.setAttribute('src',"")
    //    }
    //})


    function createImageContainer(file) {
        console.log("iiidi", file)

        imageContainerSectionEl.innerHTML += `
        <div class="image-preview" >

            <div class="date-container">
                <p id="img-date">HelloS </p>
                <span><i class="fas fa-caret-down"></i></span>
            </div>
            <div class="img-container">
                <img src="" alt="image-preview" class="preview-image" />
            </div>

        </div>
`



    }

    const arrayList = [];


    sideListBtn2El.addEventListener('click', function () {
        inputGetFilesEl.click();
    })
    inputGetFilesEl.addEventListener('change', function (e) {
        //selecting first file in the array
  
        //arrayList.push(this.files)
        //console.log('filess', arrayList)
        ////console.log('sddrerr',this.files)

        let files = e.target.files; // FileList object

        //Loop through the FileList and render image files as thumbnails.
        
        for (var i = 0, f; f = files[i]; i++) {



            let reader = new FileReader();

            // Closure to capture the file information.
            reader.onload = (function (theFile) {
                return function (e) {
                    // Render thumbnail.
                 
                    let imagePreviewContainerEl = document.createElement('div');
                    imagePreviewContainerEl.classList.add("image-preview")

                    imagePreviewContainerEl.innerHTML = `
               <div class="date-container">
                <p id="img-date">${new Date().toLocaleDateString().replace(/[/]+/gi, "-")} </p>
                <span><i class="fas fa-caret-down"></i></span>
              </div>
              <div class="img-container">
                <img src="${e.target.result}" alt="image-preview" class="preview-image" />
               </div>`
                    

                    imageContainerSectionEl.insertBefore(imagePreviewContainerEl, null)

                }

            })(f);


            // Read in the image file as a data URL.
            reader.readAsDataURL(f);
        }

        //imageContainerSectionEl.innerHTML = '';


        //if (arrayList.length > 0) {
        //    const reader = new FileReader();
        //    arrayList.forEach(file => {


        //        //previewImageEl.style.display = 'block'


        //        reader.addEventListener('load', function () {
        //            createImageContainer(file)
        //            const imageContainerEl = document.querySelector('.img-container')
        //            const previewImageEl = imageContainerEl.querySelector('.preview-image')
        //            const imageDateEl = document.getElementById('img-date')

        //            //imagePreviewContainerEl.style.display = "block"
        //            //this.result is the default propery of reader that contains the data url

        //            previewImageEl.setAttribute('src', this.result)
        //            console.log('reader', reader)
        //            //console.log("thisoao",this.result)
        //            imageDateEl.innerHTML = new Date().toLocaleDateString().replace(/[/]+/gi, "-")

        //        })
        //        console.log('filesss', file)

        //        reader.readAsDataURL(file[0])
        //    })




        //} else {
        //    //imagePreviewContainerEl.style.display = null;
        //    //previewImageEl.style.display = null;

        //    //previewImageEl.setAttribute('src', "")
        //}
    })

        
    function handleFileSelect(evt) {
        var files = evt.target.files; // FileList object

        // Loop through the FileList and render image files as thumbnails.
        for (var i = 0, f; f = files[i]; i++) {

            // Only process image files.
            if (!f.type.match('image.*')) {
                continue;
            }

            var reader = new FileReader();  

            // Closure to capture the file information.
            reader.onload = (function (theFile) {
                return function (e) {
                    // Render thumbnail.
                    var span = document.createElement('span');
                    span.innerHTML = ['<img class="thumb" src="', e.target.result,
                        '" title="', escape(theFile.name), '"/>'].join('');
                    document.getElementById('list').insertBefore(span, null);
                };
            })(f);
        

            // Read in the image file as a data URL.
            reader.readAsDataURL(f);
        }
    }

    document.getElementById('files').addEventListener('change', handleFileSelect, false);


    //const usersData = [
    //    {
    //        "id": 10001,
    //        "name": "Abraham"
    //    }, {
    //        "id": 10002,    
    //        "name": "Adam"
    //    }, {
    //        "id": 10003,
    //        "name": "Antony AdamGonslavas"
    //    },
    //    {
    //        "id": 10004,
    //        "name": "Bobby"
    //    },
    //    {
    //        "id": 10005,
    //        "name": "Boss AntonyMarshell"
    //    },
    //    {
    //        "id": 10006,
    //        "name": "Bencher"
    //    },
    //    {
    //        "id": 10007,
    //        "name": "Christopher Gonsalves"
    //    },
    //    {
    //        "id": 10008,
    //        "name": "Calvin"
    //    },
    //    {
    //        "id": 10009,
    //        "name": "Christy Christopher"
    //    },
    //    {
    //        "id": 10010,
    //        "name": "Don"
    //    },
    //    {
    //        "id": 10011,
    //        "name": "Danny ImmanuelBidenSalves"
    //    },
    //    {
    //        "id": 10012,
    //        "name": "Denver"
    //    },
    //    {
    //        "id": 10013,
    //        "name": "Eagle"
    //    },
    //    {
    //        "id": 10014,
    //        "name": "Entity"
    //    },
    //    {
    //        "id": 10015,
    //        "name": "Elgar"
    //    },
    //    {
    //        "id": 10016,
    //        "name": "Fedric"
    //    },
    //    {
    //        "id": 10017,
    //        "name": "Fernandes"
    //    },
    //    {
    //        "id": 10018,
    //        "name": "Felix"
    //    }, {
    //        "id": 10019,
    //        "name": "Gangster"
    //    },
    //    {
    //        "id": 10020,
    //        "name": "Gambler"
    //    },
    //    {
    //        "id": 10021,
    //        "name": "Guardian"
    //    }, {
    //        "id": 10022,
    //        "name": "Harry"
    //    },
    //    {
    //        "id": 10023,
    //        "name": "Hamilton"
    //    },
    //    {
    //        "id": 10024,
    //        "name": "Helen"
    //    },
    //    {
    //        "id": 10025,
    //        "name": "Immanuel"
    //    }, {
    //        "id": 10026,
    //        "name": "Inker"
    //    },
    //    {
    //        "id": 10027,
    //        "name": "Ivan"
    //    },
    //    {
    //        "id": 10028,
    //        "name": "Jennifer"
    //    }, {
    //        "id": 10029,
    //        "name": "James"
    //    },
    //    {
    //        "id": 10030,
    //        "name": "John"
    //    },
    //    {
    //        "id": 10031,
    //        "name": "Kevin"
    //    }, {
    //        "id": 10032,
    //        "name": "Karl"
    //    },
    //    {
    //        "id": 10033,
    //        "name": "Kristopher"
    //    },
    //    {
    //        "id": 10034,
    //        "name": "Lenin"
    //    }




    //]


   


    // creating patient card based on the event
    function createPatientCard({ name, id }) {
        patientCardEl.innerHTML = `
          <h3> ${name}</h3>
          <p>${id}</p>`

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
        //usersData.forEach(user => createPatients(user))
        let result = DotNet.invokeMethodAsync("WebsitePane", 'GetPatientsList')

        result.then(data => data.forEach(user => {

            createPatients(user)

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
        }))
       
      
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
