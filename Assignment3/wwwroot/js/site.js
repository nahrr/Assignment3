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

            var option = document.createElement("option");

            var values = modules[i].split("|");
            option.value = values[0];
            option.text = values[0] + ' - ' + values[1];

            $('#moduleSelect').append(option);
        }
    });

});



function readInStudents() {

    var e = document.getElementById("courseSelect");
    var course = e.options[e.selectedIndex].text;

    var moduleDropdown = document.getElementById("moduleSelect");
    var module = moduleDropdown.options[moduleDropdown.selectedIndex].value;

    $.ajax({
        url: "http://localhost:51526/api/GetStudentsOnCourse/" + course + "/" + module
    }).then(function (data) {
        $('#myTable').empty();
         var array = data.split(";");
      ///   var array = data.split("|");
        var correctArray = []
        for (var i = 0; i < array.length; i++) {
            var object = array[i].split("|");
            var name = object[0];
            var grade = object[1];
            var student = { "name": name, "grade": grade}
            console.log(student)
            correctArray.push(student)
            console.log(correctArray)
        }

     
        buildTable(correctArray)
        
        function buildTable(data) {
            var table = document.getElementById('myTable')
            
            for (var i = 0; i < data.length; i++) {
                var row = `<tr>
							        <td>${data[i].name}</td>
							        <td>${data[i].grade}</td>
                                    <td> <input type="date" id="examineDate" name="examineDate" min="2020-11-16" max="2040-12-31"> </td>
                                    <td> <select id="gradeLadok" name="gradeLadok" form="registerResults">
                                        <option value="failed">U</option>
                                        <option value="approvedGroup">G#</option>
                                        <option value="approved">G</option>
                                        <option value="wellApproved">VG</option>
                                        </select></td>
                                    <td> <input type="text"  /></td>
                                    <td> <input type="text" /></td>
							       
					          </tr>`
                table.innerHTML += row


            }

        }
    });

}

