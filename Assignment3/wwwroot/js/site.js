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

    var e = document.getElementById("courseSelect");
    var course = e.options[e.selectedIndex].text;

    var moduleDropdown = document.getElementById("moduleSelect");
    var module = moduleDropdown.options[moduleDropdown.selectedIndex].text;

    $.ajax({
        url: "http://localhost:51526/api/GetStudentsOnCourse/" + course + "/" + module
    }).then(function (data) {

        var count = data.split("|").length;
        alert(count)
 
        for (i = 0; i < count-1; i++) {
            var html = $(`<tr>
        <td> <input type="checkbox" id="selectStud" name="selectStud"> </td>

        <td> <input type="text" id="studentName" name="studentName" form="registerResults" /></td>

        <td> <select id="gradeCanvas" name="gradeCanvas" form="registerResults">
                <option value="failed">U</option>
                <option value="approvedGroup">G#</option>
                <option value="approved">G</option>
                <option value="wellApproved">VG</option>
            </select> </td>

        <td> <input type="date" id="examineDate" name="examineDate" min="2020-11-16" max="2040-12-31"> </td>

        <td> <select id="gradeLadok" name="gradeLadok" form="registerResults">
                <option value="failed">U</option>
                <option value="approvedGroup">G#</option>
                <option value="approved">G</option>
                <option value="wellApproved">VG</option>
            </select> </td>

        <td> <input type="text" form="registerResults" /></td>

        <td> <input type="text" form="registerResults" /></td>
    </tr>`);
            $('table#maintable').append(html);
        }
        
        var students = data.split(";");
        alert(students)
        for (i = 0; i < students.length; i++) {



            var fields = students[i].split("|");

            document.getElementById("studentName").value = fields[0];
        }
    });
}

function buildTable() {

 


}
