function Create() {
    var data = {};
    data.firstname = document.getElementById('first_name').value;
    data.lastname = document.getElementById('last_name').value;
    data.age = document.getElementById('age').value;

    $.post({
        type: "POST",
        url: '/Person/CreatePerson',
        data: JSON.stringify(data),
        contentType: "application/json",
        dataType: "json",
        success: function (msg) {
            alert('In Ajax');
        }
    });
}

function GetTable() {
    document.getElementById("demo").innerHTML = '';
    $.ajax({
        type: "GET",
        url: "Person/GetPeople",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function(data) {
            var $output = $('#demo');
            $(function() {
                data.forEach(function(item) {
                    $output.append($("<tr><td>" + item.firstName + "</td><td> " + item.lastName + "</td><td>" + item.age + "</td></tr>"));
                });
            });
        },
        error: function(response) {
            alert('error');
        }
    });
}

