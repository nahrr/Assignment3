// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$('#courseSelect').on('change', function () {

    var e = document.getElementById("courseSelect")
    var result = e.options[e.selectedIndex].text;

    $('#moduleSelect').empty();
    $.ajax({
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



function getStudents() {

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
            var studentId = object[2];
            var student = { "name": name, "grade": grade, "studentId": studentId}
           // console.log(student)
            correctArray.push(student)
            console.log(correctArray)
        }

     
        buildTable(correctArray)
        
        function buildTable(data) {
            var table = document.getElementById('myTable')

            for (var i = 0; i < data.length; i++) {
                var row = `<tr>      

                                    <td> <input type="checkbox" id="selectStud${i}"> </td>
                                    <td><span id="studentId${i}">${data[i].studentId}</span></td>
							        <td><span id="name${i}">${data[i].name}</span></td>
							        <td><span id="grade${i}">${data[i].grade}</span></td>
                                    <td> <input type="date" id="examineDate${i}" min="2020-11-16" max="2040-12-31"> </td>
                                    <td> <select id="gradeLadok${i}">
                                        <option value="U">U</option>
                                        <option value="G#">G#</option>
                                        <option value="G">G</option>
                                        <option value="VG">VG</option>
                                        </select></td>
                                    <td> <input type="text" id="status${i}"/></td>
                                    <td> <input type="text" id="information${i}"/></td>
							       
					          </tr>`;
                table.innerHTML += row;
            }

        }
    });

    
}

function setStudents() {


    var course = document.getElementById("courseSelect").value;
    var module = document.getElementById("moduleSelect").value;

    var table = document.getElementById('myTable')
    for (var i = 0; i < table.rows.length; i++) {

        
        var check = document.getElementById("selectStud"+i).checked;
        if (check) {
            var gradeToLadok = document.getElementById("gradeLadok" + i).value;
            var date = document.getElementById("examineDate" + i).value;

            console.log(date);
            console.log(gradeToLadok);
            console.log(module);
            console.log(course);
            var studentId = table.rows[i].cells[1].firstChild.innerHTML;
            console.log(studentId);
            
            //function foo(callback) {
            //   $.ajax({
            //   url: "http://localhost:51526/api/Ladok/" + studentSsn + "/" + grade + "/" + module + "/" + date + "/" + course
            //   })
            //}

            //function myCallback(result) {
            //    $.ajax({
            //        url: "http://localhost:51526/api/StudentITS/" + studentId
            //        success: callback
            //    });
            //}

            //foo(myCallback);


            //$.ajax({
            //    url: "http://localhost:51526/api/StudentITS/" + studentId
            //}).then(function (data) {
            //   var studentSsn = data;
            //   console.log(studentSsn);    
            //});   
            ////public string RegisterResult(string ssn, string grade, string module, DateTime date, string courseCode)
            //$.ajax({
            //    url: "http://localhost:51526/api/Ladok/" + studentSsn + "/" + grade + "/" + module + "/" + date + "/" + course
            //}).then(function (data) {
            //    var studentSsn = data;
            //    console.log(studentSsn);
            //});   

        }   
    }  
}


    


