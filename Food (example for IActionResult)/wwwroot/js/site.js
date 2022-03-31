// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let rotateAngle = 90;

function rotate(image) {

    setTimeout(() => {

        image.setAttribute("style", " opacity: 0;transition: opacity 1s; width:100px; cursor:pointer");

    }, 500);

    setTimeout(() => {

        image.setAttribute("style", " opacity: 1;transition: opacity 1s; width:100px; cursor:pointer");

    }, 1000);
 
}

