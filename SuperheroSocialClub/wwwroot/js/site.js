// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//Selector
let addSuperpowerBtn = document.querySelector("#add-superpower-btn")
let superpowerContainer = document.querySelector("#add-superpower-container")
let clickCounter = 0;

//Event listener
addSuperpowerBtn.addEventListener("click", addSuperpowerInput);

//Functions
function addSuperpowerInput() {
    clickCounter++;
    event.preventDefault();
    superpowerContainer.innerHTML += `
    <input type="text" placeholder="Superpower" id="superpower-${clickCounter}" />
    <a class="btn remove-superhero-input d-block" id="remove-superhero-input-${clickCounter}" onclick="deleteSuperheroInput(${clickCounter})"> x </a>
    `
}

function deleteSuperheroInput(id) {
    let superpowerInputToDelete = document.querySelector(`#superpower-${id}`)
    let superpowerDeletebtn = document.querySelector(`#remove-superhero-input-${id}`)
    superpowerInputToDelete.remove();
    superpowerDeletebtn.remove();
}
