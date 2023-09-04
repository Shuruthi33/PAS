
// GET the Project Details
const GetMentorDetails = async () => {

    var Response;

    try {
        await $.ajax({
            type: 'GET',
            url: "https://localhost:7138/api/Mentor/GetMentorDetails",
            contentType: "application/json",
            data: {},
            async: false,
            success: function (data) {
                if (data != null && data.statusCode == 200) {
                    if (data.resultData.length > 0) {
                        var tbodydata = '';
                        $.each(data.resultData, function (key, value) {
                            tbodydata += '<tr class="jsgrid-row">';
                            tbodydata += '<td class="jsgrid-cell">' + value.name + '</td>';
                            tbodydata += '<td class="jsgrid-cell">' + value.email + '</td>';
                            tbodydata += '<td class="jsgrid-cell">' + value.mobileNo + '</td>';

                            tbodydata += '<td> <a href="/AddOrUpdateStudentDetails?StudentId=' + value.studentId + '"><span class="jsgrid-button jsgrid-edit-button ti-pencil" type="button" title="Edit"></span></a><a href = "#"onclick="DeleteCandidate(' + value.mentorId + ')"><span class="jsgrid-button jsgrid-delete-button ti-trash" type="button" title="Delete"></span></a></td>';
                            //tbodydata += '<td> <a href="/AddOrUpdateStudentDetails?StudentId=' + value.UserId +'"><span class="jsgrid-button jsgrid-edit-button ti-pencil" type="button" title="Edit"></span></a>< a href = "#"onclick = "DeleteCandidate(' + value.userId + ')" > <span class="jsgrid-button jsgrid-delete-button ti-trash" type="button" title="Delete"></span></a ></td > ';
                            tbodydata += '</tr>';
                        });

                        $("#tblMentorId tbody").empty();
                        $("#tblMentorId tbody").append(tbodydata);
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

// Get Project ById
const GetMentorDetailsById = async (Id) => {
    var Response = 0;


    try {
        await $.ajax({
            type: 'GET',
            url: "https://localhost:7138/api/Mentor/GetMentorDetailsByIdAsync?",
            contentType: "application/json",
            data: { id: Id },
            async: false,
            success: function (data) {
                debugger
                if (data != null && data.statusCode == 200) {
                    $('#tblMentorId').val(data.resultData.mentorId);
                    $('#name').val(data.resultData.name);
                    $('#email').val(data.resultData.email);
                    $('#mobileNo').val(data.resultData.email);

                }
            }
        });
    }
    catch (err) {
        await console.log(err);
    }

    return Response;
}

//save or update candidate Details
const SaveOrUpdateMentor = async () => {
    var Response = 0;

    var data = {
        userId: parseInt($('#tblMentorId').val()),
        userName: $('#name').val(),
        password: $('#email').val(),
        email: $('#mobileNo').val(),


    }
    console.log('data', data);
    alert()
    $.ajax({
        type: 'POST',
        url: https://localhost:7138/api/Mentor/InsertMentortDetailsAsync",
        contentType: "application/json",
        data: JSON.stringify(data),
        async: false,
        success: function (data) {
            console.log('data', data);
            alert()
            if (data != null && data.statusCode == 200) {
                window.location.href = "~/MentorGrid";
            }
        }
    });
});


//Delete the Project Details By Id
const DeleteMentorById = async (Id) => {
    var Response = 0;


    try {
        await $.ajax({
            type: 'DELETE',
            url: 'https://localhost:7138/api/Mentor/DeleteMentorDetailsByIdAsync' + Id + '',
            contentType: "application/json",
            data: { id: Id },
            async: false,
            success: function (data) {
                if (data != null && data.statusCode == 200) {
                    alert("Deletd Sucessfully");
                    GetMentorDetails();
                }
            }
        });
    }
    catch (err) {
        await console.log(err);
    }

    return Response;

}