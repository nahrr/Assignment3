// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$('#courseSelect').on('change', function () {



    var e = document.getElementById("courseSelect")
    var result = e.options[e.selectedIndex].text;

    //alert(result); //För testning
    $('#moduleSelect').empty();
    $.ajax({
        // url: "http://localhost:51526/api/epok/X0002X"
        url: "http://localhost:51526/api/epok/" + result

    }).then(function (data) {

        var modules = data.split(";");

        for (i = 0; i < modules.length; i++) {
            $('#moduleSelect').append("<option>" + modules[i] + "</option>");
        }
    });

});

function readInStudents() {

    var e = document.getElementById("courseSelect")
    var course = e.options[e.selectedIndex].text;

    $.ajax({
        url: "http://localhost:51526/api/GetStudentsOnCourse/" + course
    }).then(function (data) {

        var students = data.split(";");

        for (i = 0; i < students.length; i++) {



            var fields = students[i].split("|");

            document.getElementById("studentName").value = fields[0];


        }
    });
}
