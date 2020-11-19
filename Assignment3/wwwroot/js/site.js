// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(document).ready(function () {


    $.get('GetList', function (data) {
        console.log(data)
        $.each(data, function (index, value) {
            console.log(index + value)
            $('<option>').val(value).text(value).appendTo("#courseSelect");
            })
    })
})



  


