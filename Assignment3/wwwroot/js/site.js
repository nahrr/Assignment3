// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "http://localhost:51526/api/epok/X0002X",
        success: function (data) {
            var s = '<option value="-1">Välj kurskod</option>';
            //for (var i = 0; i < data.length; i++)
              for (var i = 0; i < 1; i++) {
                s += '<option value="' + data+ '">' + data + '</option>';
            }
            $("#course-select").html(s);
        }
    });
});  


