
//Get the Student Details
const GetUserDetails = async () => {

    var Response;

    try {
        await $.ajax({
            type: 'GET',
            url: "https://localhost:44362/api/Student/GetUserDetails",
            contentType: "application/json",
            data: {},
            async: false,
            success: function (data) {
                if (data != null && data.statusCode == 200) {
                    if (data.resultData.length > 0) {
                        var tbodydata = '';
                        $.each(data.resultData, function (key, value) {
                            tbodydata += '<tr>';
                            tbodydata += '<td> <a href="/AddOrUpdateStudentDetails?StudentId=' + value.studentId + '">Edit</a><a href = "#"onclick="DeleteStudentById(' + value.studentId + ')">Delete</a></td>';
                            tbodydata += '<td>' + value.studentId + '</td>';
                            tbodydata += '<td>' + value.firstName + '</td>';
                            tbodydata += '<td>' + value.lastName + '</td>';
                            tbodydata += '<td>' + value.address1 + '</td>';
                            tbodydata += '<td>' + value.address2 + '</td>';
                            tbodydata += '<td>' + value.phoneNo + '</td>';
                            tbodydata += '</tr>';
                        });

                        $("#tblStudent tbody").empty();
                        $("#tblStudent tbody").append(tbodydata);
                    }
                }
            }
        });
    }
    catch (err) {
        await console.log(err);
    }

    return Response;
}


// To Save or Update the Student Details
const SaveorUpdateStudentDetails = async () => {

    var Response = 0;
    try {

        var data = {

            StudentId: parseInt($('#hdnStudentId').val()),
            FirstName: $('#firstName').val(),
            LastName: $('#lastName').val(),
            Address1: $('#address1').val(),
            Address2: $('#address2').val(),
            PhoneNo: $('#phoneNo').val(),
        }

        await $.ajax({
            type: 'POST',
            url: "https://localhost:44362/api/Student/InsertUserDetailsAsync",
            contentType: "application/json",
            data: JSON.stringify(data),
            async: false,
            success: function (data) {
                debugger
                if (data != null && data.statusCode == 200) {
                    window.location.href = "/StudentView";
                }
            }
        });
    }
    catch (err) {
        await console.log(err);
    }

}


//Get the Student Details By Id
const GetStudentDetailsById = async (Id) => {
    var Response = 0;


    try {
        await $.ajax({
            type: 'GET',
            url: "https://localhost:44362/api/Student/GetUserDetailsByIdAsync",
            contentType: "application/json",
            data: { id: Id },
            async: false,
            success: function (data) {
                debugger
                if (data != null && data.statusCode == 200) {
                    $('#hdnStudentId').val(data.resultData.studentId);
                    $('#firstName').val(data.resultData.firstName);
                    $('#lastName').val(data.resultData.lastName);
                    $('#address1').val(data.resultData.address1);
                    $('#address2').val(data.resultData.address2);
                    $('#phoneNo').val(data.resultData.phoneNo);

                }
            }
        });
    }
    catch (err) {
        await console.log(err);
    }

    return Response;
}

//Delete the Student Details By Id
const DeleteStudentById = async (Id) => {
    var Response = 0;


    try {
        await $.ajax({
            type: 'DELETE',
            url: 'https://localhost:44362/api/Student/DeleteUserDetailsByIdAsync?id=' + Id + '',
            contentType: "application/json",
            data: { id: Id },
            async: false,
            success: function (data) {
                if (data != null && data.statusCode == 200) {
                    alert("Deletd Sucessfully");
                    GetStudentDetails();
                }
            }
        });
    }
    catch (err) {
        await console.log(err);
    }

    return Response;

}

//login the user
const logindetails = async (Id) => {

    var Response;
    var username = $("#username").val();
    var password = $("#password").val();



    try {
        var requestData = JSON.stringify({
            username: username,
            password: password
        });
        await $.ajax({
            type: 'POST',
            url: "https://localhost:44362/api/Student/LoginUserAsync",
            contentType: "application/json",
            data: requestData,
            async: false,
            success: function (data) {

                if (data.statusCode == 200) {

                    alert("login sucess")
                }

                //else if (data.statusCode == 500) {
                //    alert("user not fount the data base")
                //}
                else {
                    alert("login faild")
                }
                window.location.href = "StudentView";
            }

        });
    }
    catch (err) {
        await console.log(err);
    }

    return Response;

}